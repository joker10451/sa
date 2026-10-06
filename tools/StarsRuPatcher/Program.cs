using System.Buffers.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Mono.Cecil;
using Mono.Cecil.Cil;

internal sealed record Translation(string Type, string Id, string[] Values);

internal static class Program
{
    private const string StarsType = "Stars.Stars";
    private const string PatchMethod = "PatchMod";

    private static int Main(string[] args)
    {
        if (args.Length is < 3 or > 4)
        {
            Console.Error.WriteLine("Usage: StarsRuPatcher <input.sml> <translations.json> <output.sml> [--start-necromancer]");
            return 2;
        }

        var inputPath = args[0];
        var translationsPath = args[1];
        var outputPath = args[2];
        var startNecromancer = args.Length == 4 && string.Equals(args[3], "--start-necromancer", StringComparison.Ordinal);
        if (args.Length == 4 && !startNecromancer)
        {
            Console.Error.WriteLine($"Unknown option: {args[3]}");
            return 2;
        }

        var translations = JsonSerializer.Deserialize<List<Translation>>(
            File.ReadAllText(translationsPath, Encoding.UTF8),
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            ?? throw new InvalidOperationException("Could not read translations.");

        var sml = File.ReadAllBytes(inputPath);
        var layout = ParseSml(sml);
        var originalAssembly = sml.AsSpan(layout.AssemblyStart, layout.AssemblyLength).ToArray();

        byte[] patchedAssembly;
        using (var input = new MemoryStream(originalAssembly, writable: false))
        using (var asm = AssemblyDefinition.ReadAssembly(input))
        {
            var method = GetPatchMethod(asm);
            var body = method.Body;
            var processor = body.GetILProcessor();

            var expectedDictionaries = translations.Sum(t => t.Values.Length);
            var inserted = 0;
            var alreadyPresent = 0;

            foreach (var translation in translations)
            {
                var constructor = FindLocalizationConstructor(body.Instructions, translation);
                var dictionaryCtors = FindDictionaryConstructors(body.Instructions, translation, constructor);

                if (dictionaryCtors.Count != translation.Values.Length)
                {
                    throw new InvalidOperationException(
                        $"[{translation.Type}:{translation.Id}] expected {translation.Values.Length} dictionaries, found {dictionaryCtors.Count}.");
                }

                for (var valueIndex = dictionaryCtors.Count - 1; valueIndex >= 0; valueIndex--)
                {
                    var dictionaryCtor = dictionaryCtors[valueIndex];

                    if (HasRussianEntry(body.Instructions, dictionaryCtor, constructor))
                    {
                        alreadyPresent++;
                        continue;
                    }

                    var addMethod = FindDictionaryAdd(body.Instructions, dictionaryCtor, constructor);
                    var anchor = dictionaryCtor;

                    var dup = processor.Create(OpCodes.Dup);
                    processor.InsertAfter(anchor, dup);
                    anchor = dup;

                    var russianKey = processor.Create(OpCodes.Ldc_I4_0);
                    processor.InsertAfter(anchor, russianKey);
                    anchor = russianKey;

                    var russianValue = processor.Create(OpCodes.Ldstr, translation.Values[valueIndex]);
                    processor.InsertAfter(anchor, russianValue);
                    anchor = russianValue;

                    var add = processor.Create(OpCodes.Callvirt, addMethod);
                    processor.InsertAfter(anchor, add);
                    inserted++;
                }
            }

            if (inserted + alreadyPresent != expectedDictionaries)
            {
                throw new InvalidOperationException(
                    $"Patch accounting mismatch: expected {expectedDictionaries}, inserted {inserted}, already present {alreadyPresent}.");
            }

            if (startNecromancer)
                PatchStarterNecromancyBook(body.Instructions);

            using var output = new MemoryStream();
            asm.Write(output);
            patchedAssembly = output.ToArray();

            Console.WriteLine($"Localization objects: {translations.Count}");
            Console.WriteLine($"Russian dictionary entries expected: {expectedDictionaries}");
            Console.WriteLine($"Russian dictionary entries inserted: {inserted}");
            Console.WriteLine($"Russian dictionary entries already present: {alreadyPresent}");
        }

        ValidatePatchedAssembly(patchedAssembly, translations, startNecromancer);

        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(outputPath))!);
        WritePatchedSml(sml, layout, patchedAssembly, outputPath);

        Console.WriteLine($"Input SHA256 : {Sha256(sml)}");
        Console.WriteLine($"Output SHA256: {Sha256(File.ReadAllBytes(outputPath))}");
        Console.WriteLine($"Patched assembly: {originalAssembly.Length} -> {patchedAssembly.Length} bytes");
        Console.WriteLine($"Output: {Path.GetFullPath(outputPath)}");
        return 0;
    }

    private static MethodDefinition GetPatchMethod(AssemblyDefinition asm)
    {
        var type = asm.MainModule.Types.FirstOrDefault(t => t.FullName == StarsType)
            ?? throw new InvalidOperationException($"Type {StarsType} not found.");
        return type.Methods.FirstOrDefault(m => m.Name == PatchMethod)
            ?? throw new InvalidOperationException($"Method {StarsType}.{PatchMethod} not found.");
    }

    private static Instruction FindLocalizationConstructor(
        Mono.Collections.Generic.Collection<Instruction> instructions,
        Translation translation)
    {
        var matches = new List<Instruction>();

        for (var i = 0; i < instructions.Count; i++)
        {
            var instruction = instructions[i];
            if (instruction.OpCode != OpCodes.Newobj || instruction.Operand is not MethodReference method)
                continue;
            if (method.DeclaringType.Name != translation.Type)
                continue;

            var start = Math.Max(0, i - 600);
            var foundId = false;
            for (var j = i - 1; j >= start; j--)
            {
                var previous = instructions[j];

                if (j != i - 1 && previous.OpCode == OpCodes.Newobj &&
                    previous.Operand is MethodReference previousCtor &&
                    previousCtor.DeclaringType.Name.StartsWith("Localization", StringComparison.Ordinal))
                {
                    break;
                }

                if (previous.OpCode == OpCodes.Ldstr &&
                    string.Equals(previous.Operand as string, translation.Id, StringComparison.Ordinal))
                {
                    foundId = true;
                    break;
                }
            }

            if (foundId)
                matches.Add(instruction);
        }

        if (matches.Count != 1)
        {
            throw new InvalidOperationException(
                $"[{translation.Type}:{translation.Id}] expected exactly one localization constructor, found {matches.Count}.");
        }

        return matches[0];
    }

    private static List<Instruction> FindDictionaryConstructors(
        Mono.Collections.Generic.Collection<Instruction> instructions,
        Translation translation,
        Instruction localizationCtor)
    {
        var ctorIndex = instructions.IndexOf(localizationCtor);
        var dictionaries = new List<Instruction>();

        // C# evaluation order may construct the first dictionary before the localization ID
        // string is loaded. Walk backwards from the already identified localization constructor
        // and take exactly the dictionaries consumed by that constructor.
        for (var i = ctorIndex - 1; i >= Math.Max(0, ctorIndex - 800); i--)
        {
            var instruction = instructions[i];

            if (instruction.OpCode == OpCodes.Newobj &&
                instruction.Operand is MethodReference method &&
                method.DeclaringType.FullName.StartsWith("System.Collections.Generic.Dictionary`2", StringComparison.Ordinal))
            {
                dictionaries.Add(instruction);
                if (dictionaries.Count == translation.Values.Length)
                    break;
            }

            // Do not cross into a previous completed localization object.
            if (instruction.OpCode == OpCodes.Newobj &&
                instruction.Operand is MethodReference previousLocalization &&
                previousLocalization.DeclaringType.Name.StartsWith("Localization", StringComparison.Ordinal))
            {
                break;
            }
        }

        dictionaries.Reverse();
        return dictionaries;
    }

    private static MethodReference FindDictionaryAdd(
        Mono.Collections.Generic.Collection<Instruction> instructions,
        Instruction dictionaryCtor,
        Instruction localizationCtor)
    {
        var start = instructions.IndexOf(dictionaryCtor) + 1;
        var end = instructions.IndexOf(localizationCtor);

        for (var i = start; i < end; i++)
        {
            if (instructions[i].OpCode == OpCodes.Callvirt &&
                instructions[i].Operand is MethodReference method &&
                method.Name == "Add" &&
                method.DeclaringType.FullName.StartsWith("System.Collections.Generic.Dictionary`2", StringComparison.Ordinal))
            {
                return method;
            }

            if (instructions[i].OpCode == OpCodes.Newobj &&
                instructions[i].Operand is MethodReference ctor &&
                ctor.DeclaringType.FullName.StartsWith("System.Collections.Generic.Dictionary`2", StringComparison.Ordinal))
            {
                break;
            }
        }

        throw new InvalidOperationException("Dictionary.Add call not found.");
    }

    private static bool HasRussianEntry(
        Mono.Collections.Generic.Collection<Instruction> instructions,
        Instruction dictionaryCtor,
        Instruction localizationCtor)
    {
        var start = instructions.IndexOf(dictionaryCtor) + 1;
        var end = instructions.IndexOf(localizationCtor);

        for (var i = start; i < end; i++)
        {
            if (instructions[i].OpCode == OpCodes.Newobj &&
                instructions[i].Operand is MethodReference ctor &&
                ctor.DeclaringType.FullName.StartsWith("System.Collections.Generic.Dictionary`2", StringComparison.Ordinal))
            {
                break;
            }

            if (IsLdcI4Zero(instructions[i]))
            {
                for (var j = i + 1; j < Math.Min(end, i + 8); j++)
                {
                    if (instructions[j].OpCode == OpCodes.Callvirt &&
                        instructions[j].Operand is MethodReference method &&
                        method.Name == "Add" &&
                        method.DeclaringType.FullName.StartsWith("System.Collections.Generic.Dictionary`2", StringComparison.Ordinal))
                        return true;
                }
            }
        }

        return false;
    }

    private static bool IsLdcI4Zero(Instruction instruction) =>
        instruction.OpCode == OpCodes.Ldc_I4_0 ||
        (instruction.OpCode == OpCodes.Ldc_I4 && instruction.Operand is int value && value == 0) ||
        (instruction.OpCode == OpCodes.Ldc_I4_S && instruction.Operand is sbyte small && small == 0);

    private static void ValidatePatchedAssembly(byte[] assemblyBytes, IReadOnlyList<Translation> translations, bool startNecromancer)
    {
        using var stream = new MemoryStream(assemblyBytes, writable: false);
        using var asm = AssemblyDefinition.ReadAssembly(stream);
        var method = GetPatchMethod(asm);
        var instructions = method.Body.Instructions;

        var validated = 0;
        foreach (var translation in translations)
        {
            var ctor = FindLocalizationConstructor(instructions, translation);
            var dictionaries = FindDictionaryConstructors(instructions, translation, ctor);

            if (dictionaries.Count != translation.Values.Length)
                throw new InvalidOperationException($"Validation failed for {translation.Type}:{translation.Id}.");

            foreach (var dictionary in dictionaries)
            {
                if (!HasRussianEntry(instructions, dictionary, ctor))
                    throw new InvalidOperationException($"Russian entry missing after patch: {translation.Type}:{translation.Id}.");
                validated++;
            }
        }

        Console.WriteLine($"Validation OK: {validated} Russian dictionary entries present.");

        if (startNecromancer)
        {
            var hasPlayerTarget = instructions.Any(i => i.OpCode == OpCodes.Ldstr &&
                string.Equals(i.Operand as string, "gml_Object_o_player_Create_0", StringComparison.Ordinal));
            var hasStarterGuard = instructions.Any(i => i.OpCode == OpCodes.Ldstr &&
                (i.Operand as string)?.Contains("stars_necromancy_start_book_given", StringComparison.Ordinal) == true);

            if (!hasPlayerTarget || !hasStarterGuard)
                throw new InvalidOperationException("Starter necromancer validation failed.");

            Console.WriteLine("Starter necromancer validation OK: player Create hook + one-time guard present.");
        }
    }

    private static void PatchStarterNecromancyBook(Mono.Collections.Generic.Collection<Instruction> instructions)
    {
        const string originalTarget = "gml_Object_o_runaway_wizzard_Create_0";
        const string originalMatch = "scr_inventory_add_item(o_inv_map_osbrook)";
        const string originalInsert = "scr_inventory_add_item(o_inv_lorebook_magic)";

        var insertIndex = -1;
        for (var i = 0; i < instructions.Count; i++)
        {
            if (instructions[i].OpCode == OpCodes.Ldstr &&
                string.Equals(instructions[i].Operand as string, originalInsert, StringComparison.Ordinal))
            {
                insertIndex = i;
                break;
            }
        }

        if (insertIndex < 0)
            throw new InvalidOperationException("Could not find the Stars necromancy lorebook injection.");

        Instruction? targetInstruction = null;
        Instruction? matchInstruction = null;

        for (var i = insertIndex - 1; i >= Math.Max(0, insertIndex - 80); i--)
        {
            if (instructions[i].OpCode != OpCodes.Ldstr)
                continue;

            var value = instructions[i].Operand as string;
            if (targetInstruction is null && string.Equals(value, originalTarget, StringComparison.Ordinal))
                targetInstruction = instructions[i];
            if (matchInstruction is null && string.Equals(value, originalMatch, StringComparison.Ordinal))
                matchInstruction = instructions[i];

            if (targetInstruction is not null && matchInstruction is not null)
                break;
        }

        if (targetInstruction is null || matchInstruction is null)
            throw new InvalidOperationException("Could not resolve the original Runaway Wizard lorebook patch sequence.");

        targetInstruction.Operand = "gml_Object_o_player_Create_0";
        matchInstruction.Operand = "event_inherited()";
        instructions[insertIndex].Operand =
            "if (!variable_global_exists(\"stars_necromancy_start_book_given\")) { " +
            "global.stars_necromancy_start_book_given = true; " +
            "if (!scr_instance_exists_item(o_inv_lorebook_magic)) scr_inventory_add_item(o_inv_lorebook_magic); " +
            "}";

        Console.WriteLine("Starter necromancer patch: lorebook will be granted from o_player Create.");
    }

    private sealed record SmlLayout(int AssemblyLengthOffset, int AssemblyStart, int AssemblyLength, int SuffixStart);

    private static SmlLayout ParseSml(byte[] data)
    {
        if (data.Length < 16 || Encoding.ASCII.GetString(data, 0, 4) != "MSLM")
            throw new InvalidOperationException("Input is not an MSLM container.");

        var position = 4;
        var versionProbe = data.AsSpan(position, Math.Min(24, data.Length - position));
        var versionLength = versionProbe.Length;

        for (var i = 1; i < versionProbe.Length; i++)
        {
            var b = versionProbe[i];
            if (b != (byte)'.' && (b < (byte)'0' || b > (byte)'9'))
            {
                versionLength = i;
                break;
            }
        }

        var version = Encoding.ASCII.GetString(data, position, versionLength);
        position = 4 + versionLength;

        var lastFileEnd = 0;
        for (var section = 0; section < 4; section++)
        {
            var count = ReadInt32(data, ref position);
            if (count < 0 || count > 100000)
                throw new InvalidOperationException($"Invalid section count: {count}.");

            for (var entry = 0; entry < count; entry++)
            {
                var nameLength = ReadInt32(data, ref position);
                if (nameLength < 0 || position + nameLength > data.Length)
                    throw new InvalidOperationException("Invalid SML entry name length.");

                position += nameLength;
                var offset = ReadInt32(data, ref position);
                var length = ReadInt32(data, ref position);
                lastFileEnd = Math.Max(lastFileEnd, checked(offset + length));
            }
        }

        var filesOffset = position;
        var assemblyLengthOffset = checked(filesOffset + lastFileEnd);
        position = assemblyLengthOffset;
        var assemblyLength = ReadInt32(data, ref position);
        var assemblyStart = position;
        var suffixStart = checked(assemblyStart + assemblyLength);

        if (assemblyLength <= 0 || suffixStart > data.Length)
            throw new InvalidOperationException("Invalid embedded assembly layout.");

        Console.WriteLine($"SML version: {version}");
        Console.WriteLine($"Embedded assembly: offset={assemblyStart}, length={assemblyLength}");

        return new SmlLayout(assemblyLengthOffset, assemblyStart, assemblyLength, suffixStart);
    }

    private static int ReadInt32(byte[] data, ref int position)
    {
        if (position + 4 > data.Length)
            throw new EndOfStreamException();
        var value = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(position, 4));
        position += 4;
        return value;
    }

    private static void WritePatchedSml(byte[] original, SmlLayout layout, byte[] patchedAssembly, string outputPath)
    {
        using var output = new MemoryStream();
        output.Write(original, 0, layout.AssemblyLengthOffset);

        Span<byte> lengthBytes = stackalloc byte[4];
        BinaryPrimitives.WriteInt32LittleEndian(lengthBytes, patchedAssembly.Length);
        output.Write(lengthBytes);
        output.Write(patchedAssembly);

        if (layout.SuffixStart < original.Length)
            output.Write(original, layout.SuffixStart, original.Length - layout.SuffixStart);

        File.WriteAllBytes(outputPath, output.ToArray());
    }

    private static string Sha256(byte[] bytes) =>
        Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
}
