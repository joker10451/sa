# Installation Notes

## Required files

This update requires **all 3** mods to be installed together in your MSL `Mods` folder:

- `0_Stars Overhaul.sml`
- `Stars Enemy Enhancing.sml`
- `Stars New Skills All-in-One.sml`

They are meant to be used as a set — `Stars Enemy Enhancing` and `Stars New Skills All-in-One` are interdependent, and `Stars Overhaul` needs to load first (see below).

## ⚠️ Why file names matter — MSL load order

MSL loads mods **in alphabetical order** by file name, and if two mods patch the same part of the game, **the one loaded later wins** (it overwrites the earlier patch).

This matters here because `Stars Enemy Enhancing` and `Stars New Skills All-in-One` both patch the same event in a couple of places (e.g. Aura of Unlife). For the fixed version to actually take effect, `Stars New Skills All-in-One` **must** load *after* `Stars Enemy Enhancing` — which happens naturally since "E" comes before "N" alphabetically, as long as you don't rename the files.

The `0_` prefix on `Stars Overhaul` exists for the same reason: it forces that mod to load **first** (since `0` sorts before any letter), so its patches don't get overwritten by anything else touching the same objects.

### 🚫 Please don't:
- Rename any of the 3 `.sml` files
- Remove the `0_` prefix from `Stars Overhaul`
- Add another mod whose name would sort alphabetically *between* "Stars Enemy Enhancing" and "Stars New Skills All-in-One" without checking for conflicts first

Breaking the load order won't throw an error — the game will just silently go back to using the older, buggy patch instead of the fixed one, which can be confusing to debug.

## Installation steps

1. Make sure you're on a **fresh, unmodified** `data.win` before compiling (verify game files through Steam if unsure).
2. First, install the 3 original mods normally through MSL from the official Nexus page (this registers them properly in MSL).
3. Download the 3 `.sml` files from this folder.
4. **Rename `Stars Overhaul.sml` to `0_Stars Overhaul.sml`** (the `0_` prefix is not kept automatically by the download — see the load order explanation above, this step matters).
5. Replace the original `.sml` files in your MSL `Mods` folder with these fixed ones (same file names, just overwrite — don't delete-then-re-add, MSL may not pick it up correctly).
6. Open MSL, make sure all 3 mods are enabled and in the correct order in the mod list.
7. Compile.
8. Launch the game.

If you run into a "Code Error" popup on launch mentioning `UndertaleModLib` / `chunk CODE` coming from **MSL itself** during the patching step — this is a known harmless quirk of MSL's own internal verification pass and does not affect the actual game files. If the game launches fine afterward, you're good.
