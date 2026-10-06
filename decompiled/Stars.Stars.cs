using System.Collections.Generic;
using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib.Models;

namespace Stars;

public class Stars : Mod
{
	public override string Author => "富川喻子";

	public override string Name => "Stars Necromancy and Proselyte";

	public override string Description => "The skill branches of necromancy and Proselyte, which should be used with Stars Enemy Enhancing. ";

	public override string Version => "0.9.4.20";

	public override string TargetVersion => "0.8.2.10";

	public override void PatchMod()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Obj, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected Obj, but got Unknown
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Obj, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected Obj, but got Unknown
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected Obj, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Obj, but got Unknown
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected Obj, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected Obj, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected Obj, but got Unknown
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected Obj, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected Obj, but got Unknown
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected Obj, but got Unknown
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected Obj, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected Obj, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected Obj, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected Obj, but got Unknown
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got Unknown
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Expected Obj, but got Unknown
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected Obj, but got Unknown
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Expected Obj, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected Obj, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected Obj, but got Unknown
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected Obj, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected Obj, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected Obj, but got Unknown
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected Obj, but got Unknown
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected Obj, but got Unknown
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Obj, but got Unknown
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Expected Obj, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Expected Obj, but got Unknown
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected Obj, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected Obj, but got Unknown
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed9: Expected Obj, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Expected Obj, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4c: Expected Obj, but got Unknown
		//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f89: Expected Obj, but got Unknown
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected Obj, but got Unknown
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected Obj, but got Unknown
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Expected Obj, but got Unknown
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected Obj, but got Unknown
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102f: Expected Obj, but got Unknown
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected Obj, but got Unknown
		//IL_105e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Expected Obj, but got Unknown
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected Obj, but got Unknown
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bc: Expected Obj, but got Unknown
		//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected Obj, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected Obj, but got Unknown
		//IL_114b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected Obj, but got Unknown
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Expected Obj, but got Unknown
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Expected Obj, but got Unknown
		//IL_11bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c3: Expected Obj, but got Unknown
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11de: Expected Obj, but got Unknown
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Expected Obj, but got Unknown
		//IL_1230: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Expected Obj, but got Unknown
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1273: Expected Obj, but got Unknown
		//IL_1287: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Expected Obj, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a8: Expected Obj, but got Unknown
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c3: Expected Obj, but got Unknown
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300: Expected Obj, but got Unknown
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a: Expected Obj, but got Unknown
		//IL_132e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Expected Obj, but got Unknown
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134f: Expected Obj, but got Unknown
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_136a: Expected Obj, but got Unknown
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Expected Obj, but got Unknown
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Expected Obj, but got Unknown
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ff: Expected Obj, but got Unknown
		//IL_1414: Unknown result type (might be due to invalid IL or missing references)
		//IL_141a: Expected Obj, but got Unknown
		//IL_1451: Unknown result type (might be due to invalid IL or missing references)
		//IL_1457: Expected Obj, but got Unknown
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1472: Expected Obj, but got Unknown
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14af: Expected Obj, but got Unknown
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c9: Expected Obj, but got Unknown
		//IL_14de: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Expected Obj, but got Unknown
		//IL_151b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1521: Expected Obj, but got Unknown
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_153b: Expected Obj, but got Unknown
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1555: Expected Obj, but got Unknown
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_156f: Expected Obj, but got Unknown
		//IL_1584: Unknown result type (might be due to invalid IL or missing references)
		//IL_158a: Expected Obj, but got Unknown
		//IL_15c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c7: Expected Obj, but got Unknown
		//IL_15db: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e1: Expected Obj, but got Unknown
		//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fc: Expected Obj, but got Unknown
		//IL_1633: Unknown result type (might be due to invalid IL or missing references)
		//IL_1639: Expected Obj, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1654: Expected Obj, but got Unknown
		//IL_168b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1691: Expected Obj, but got Unknown
		//IL_16a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected Obj, but got Unknown
		//IL_16c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c6: Expected Obj, but got Unknown
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1703: Expected Obj, but got Unknown
		//IL_1717: Unknown result type (might be due to invalid IL or missing references)
		//IL_171d: Expected Obj, but got Unknown
		//IL_1732: Unknown result type (might be due to invalid IL or missing references)
		//IL_1738: Expected Obj, but got Unknown
		//IL_176f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Expected Obj, but got Unknown
		//IL_1789: Unknown result type (might be due to invalid IL or missing references)
		//IL_178f: Expected Obj, but got Unknown
		//IL_17a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17aa: Expected Obj, but got Unknown
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e7: Expected Obj, but got Unknown
		//IL_17fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1801: Expected Obj, but got Unknown
		//IL_1816: Unknown result type (might be due to invalid IL or missing references)
		//IL_181c: Expected Obj, but got Unknown
		//IL_1831: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected Obj, but got Unknown
		//IL_186e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1874: Expected Obj, but got Unknown
		//IL_1889: Unknown result type (might be due to invalid IL or missing references)
		//IL_188f: Expected Obj, but got Unknown
		//IL_18c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cc: Expected Obj, but got Unknown
		//IL_18e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e7: Expected Obj, but got Unknown
		//IL_191e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1924: Expected Obj, but got Unknown
		//IL_1939: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected Obj, but got Unknown
		//IL_1976: Unknown result type (might be due to invalid IL or missing references)
		//IL_197c: Expected Obj, but got Unknown
		//IL_1990: Unknown result type (might be due to invalid IL or missing references)
		//IL_1996: Expected Obj, but got Unknown
		//IL_19ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b1: Expected Obj, but got Unknown
		//IL_19e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ee: Expected Obj, but got Unknown
		//IL_1a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a08: Expected Obj, but got Unknown
		//IL_1a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a23: Expected Obj, but got Unknown
		//IL_1a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a60: Expected Obj, but got Unknown
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7a: Expected Obj, but got Unknown
		//IL_1a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a95: Expected Obj, but got Unknown
		//IL_1acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad2: Expected Obj, but got Unknown
		//IL_1ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aec: Expected Obj, but got Unknown
		//IL_1b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b06: Expected Obj, but got Unknown
		//IL_1b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b21: Expected Obj, but got Unknown
		//IL_1b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5e: Expected Obj, but got Unknown
		//IL_1b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b78: Expected Obj, but got Unknown
		//IL_1b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b93: Expected Obj, but got Unknown
		//IL_1bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd0: Expected Obj, but got Unknown
		//IL_1be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bea: Expected Obj, but got Unknown
		//IL_1bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c04: Expected Obj, but got Unknown
		//IL_1c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1f: Expected Obj, but got Unknown
		//IL_1c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5c: Expected Obj, but got Unknown
		//IL_1c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c76: Expected Obj, but got Unknown
		//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c91: Expected Obj, but got Unknown
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cce: Expected Obj, but got Unknown
		//IL_1ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce9: Expected Obj, but got Unknown
		//IL_1d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d26: Expected Obj, but got Unknown
		//IL_1d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d41: Expected Obj, but got Unknown
		//IL_1d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7e: Expected Obj, but got Unknown
		//IL_1d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d99: Expected Obj, but got Unknown
		//IL_1dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd6: Expected Obj, but got Unknown
		//IL_1deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df1: Expected Obj, but got Unknown
		//IL_1e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2e: Expected Obj, but got Unknown
		//IL_1e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e49: Expected Obj, but got Unknown
		//IL_1e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e86: Expected Obj, but got Unknown
		//IL_1e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Expected Obj, but got Unknown
		//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ede: Expected Obj, but got Unknown
		//IL_1ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef9: Expected Obj, but got Unknown
		//IL_1f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f36: Expected Obj, but got Unknown
		//IL_1f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f51: Expected Obj, but got Unknown
		//IL_1f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8e: Expected Obj, but got Unknown
		//IL_1fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa9: Expected Obj, but got Unknown
		//IL_1fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe6: Expected Obj, but got Unknown
		//IL_1ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2001: Expected Obj, but got Unknown
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_203e: Expected Obj, but got Unknown
		//IL_2053: Unknown result type (might be due to invalid IL or missing references)
		//IL_2059: Expected Obj, but got Unknown
		//IL_2090: Unknown result type (might be due to invalid IL or missing references)
		//IL_2096: Expected Obj, but got Unknown
		//IL_20ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b1: Expected Obj, but got Unknown
		//IL_20e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ee: Expected Obj, but got Unknown
		//IL_2103: Unknown result type (might be due to invalid IL or missing references)
		//IL_2109: Expected Obj, but got Unknown
		//IL_2140: Unknown result type (might be due to invalid IL or missing references)
		//IL_2146: Expected Obj, but got Unknown
		//IL_215b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2161: Expected Obj, but got Unknown
		//IL_2198: Unknown result type (might be due to invalid IL or missing references)
		//IL_219e: Expected Obj, but got Unknown
		//IL_21b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b9: Expected Obj, but got Unknown
		//IL_21f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f6: Expected Obj, but got Unknown
		//IL_220b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2211: Expected Obj, but got Unknown
		//IL_2248: Unknown result type (might be due to invalid IL or missing references)
		//IL_224e: Expected Obj, but got Unknown
		//IL_2263: Unknown result type (might be due to invalid IL or missing references)
		//IL_2269: Expected Obj, but got Unknown
		//IL_22a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a6: Expected Obj, but got Unknown
		//IL_22bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c1: Expected Obj, but got Unknown
		//IL_22f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fe: Expected Obj, but got Unknown
		//IL_2313: Unknown result type (might be due to invalid IL or missing references)
		//IL_2319: Expected Obj, but got Unknown
		//IL_2350: Unknown result type (might be due to invalid IL or missing references)
		//IL_2356: Expected Obj, but got Unknown
		//IL_236b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2371: Expected Obj, but got Unknown
		//IL_23a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ae: Expected Obj, but got Unknown
		//IL_23c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c9: Expected Obj, but got Unknown
		//IL_2400: Unknown result type (might be due to invalid IL or missing references)
		//IL_2406: Expected Obj, but got Unknown
		//IL_241b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2421: Expected Obj, but got Unknown
		//IL_2458: Unknown result type (might be due to invalid IL or missing references)
		//IL_245e: Expected Obj, but got Unknown
		//IL_2473: Unknown result type (might be due to invalid IL or missing references)
		//IL_2479: Expected Obj, but got Unknown
		//IL_24b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b6: Expected Obj, but got Unknown
		//IL_24cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d1: Expected Obj, but got Unknown
		//IL_2508: Unknown result type (might be due to invalid IL or missing references)
		//IL_250e: Expected Obj, but got Unknown
		//IL_2523: Unknown result type (might be due to invalid IL or missing references)
		//IL_2529: Expected Obj, but got Unknown
		//IL_2560: Unknown result type (might be due to invalid IL or missing references)
		//IL_2566: Expected Obj, but got Unknown
		//IL_257b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2581: Expected Obj, but got Unknown
		//IL_25b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25be: Expected Obj, but got Unknown
		//IL_25d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d9: Expected Obj, but got Unknown
		//IL_2610: Unknown result type (might be due to invalid IL or missing references)
		//IL_2616: Expected Obj, but got Unknown
		//IL_262b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2631: Expected Obj, but got Unknown
		//IL_2668: Unknown result type (might be due to invalid IL or missing references)
		//IL_266e: Expected Obj, but got Unknown
		//IL_2683: Unknown result type (might be due to invalid IL or missing references)
		//IL_2689: Expected Obj, but got Unknown
		//IL_26c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c6: Expected Obj, but got Unknown
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e1: Expected Obj, but got Unknown
		//IL_2718: Unknown result type (might be due to invalid IL or missing references)
		//IL_271e: Expected Obj, but got Unknown
		//IL_2733: Unknown result type (might be due to invalid IL or missing references)
		//IL_2739: Expected Obj, but got Unknown
		//IL_2770: Unknown result type (might be due to invalid IL or missing references)
		//IL_2776: Expected Obj, but got Unknown
		//IL_278b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2791: Expected Obj, but got Unknown
		//IL_27c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ce: Expected Obj, but got Unknown
		//IL_27e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e9: Expected Obj, but got Unknown
		//IL_2820: Unknown result type (might be due to invalid IL or missing references)
		//IL_2826: Expected Obj, but got Unknown
		//IL_283b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2841: Expected Obj, but got Unknown
		//IL_2878: Unknown result type (might be due to invalid IL or missing references)
		//IL_287e: Expected Obj, but got Unknown
		//IL_2893: Unknown result type (might be due to invalid IL or missing references)
		//IL_2899: Expected Obj, but got Unknown
		//IL_28d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d6: Expected Obj, but got Unknown
		//IL_28eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f1: Expected Obj, but got Unknown
		//IL_2928: Unknown result type (might be due to invalid IL or missing references)
		//IL_292e: Expected Obj, but got Unknown
		//IL_2943: Unknown result type (might be due to invalid IL or missing references)
		//IL_2949: Expected Obj, but got Unknown
		//IL_2980: Unknown result type (might be due to invalid IL or missing references)
		//IL_2986: Expected Obj, but got Unknown
		//IL_299b: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a1: Expected Obj, but got Unknown
		//IL_29d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29de: Expected Obj, but got Unknown
		//IL_29f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f9: Expected Obj, but got Unknown
		//IL_2a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a36: Expected Obj, but got Unknown
		//IL_2a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a51: Expected Obj, but got Unknown
		//IL_2a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8e: Expected Obj, but got Unknown
		//IL_2aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa9: Expected Obj, but got Unknown
		//IL_2ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae6: Expected Obj, but got Unknown
		//IL_2afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b01: Expected Obj, but got Unknown
		//IL_2b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3e: Expected Obj, but got Unknown
		//IL_2b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b59: Expected Obj, but got Unknown
		//IL_2b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b96: Expected Obj, but got Unknown
		//IL_2bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb1: Expected Obj, but got Unknown
		//IL_2be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bee: Expected Obj, but got Unknown
		//IL_2c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c09: Expected Obj, but got Unknown
		//IL_2c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c46: Expected Obj, but got Unknown
		//IL_2c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c61: Expected Obj, but got Unknown
		//IL_2c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9e: Expected Obj, but got Unknown
		//IL_2cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb9: Expected Obj, but got Unknown
		//IL_2cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf6: Expected Obj, but got Unknown
		//IL_2d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d11: Expected Obj, but got Unknown
		//IL_2d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4e: Expected Obj, but got Unknown
		//IL_2d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d69: Expected Obj, but got Unknown
		//IL_2da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da6: Expected Obj, but got Unknown
		//IL_2dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc1: Expected Obj, but got Unknown
		//IL_2df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfe: Expected Obj, but got Unknown
		//IL_2e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e19: Expected Obj, but got Unknown
		//IL_2e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e56: Expected Obj, but got Unknown
		//IL_2e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Expected Obj, but got Unknown
		//IL_2e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8c: Expected Obj, but got Unknown
		//IL_2ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec9: Expected Obj, but got Unknown
		//IL_2ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee4: Expected Obj, but got Unknown
		//IL_2f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f21: Expected Obj, but got Unknown
		//IL_2f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3c: Expected Obj, but got Unknown
		//IL_2f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f79: Expected Obj, but got Unknown
		//IL_2f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f94: Expected Obj, but got Unknown
		//IL_2fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd1: Expected Obj, but got Unknown
		//IL_2fe6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fec: Expected Obj, but got Unknown
		//IL_3023: Unknown result type (might be due to invalid IL or missing references)
		//IL_3029: Expected Obj, but got Unknown
		//IL_303e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3044: Expected Obj, but got Unknown
		//IL_307b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3081: Expected Obj, but got Unknown
		//IL_3096: Unknown result type (might be due to invalid IL or missing references)
		//IL_309c: Expected Obj, but got Unknown
		//IL_30d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d9: Expected Obj, but got Unknown
		//IL_30ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f4: Expected Obj, but got Unknown
		//IL_312b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3131: Expected Obj, but got Unknown
		//IL_3146: Unknown result type (might be due to invalid IL or missing references)
		//IL_314c: Expected Obj, but got Unknown
		//IL_3183: Unknown result type (might be due to invalid IL or missing references)
		//IL_3189: Expected Obj, but got Unknown
		//IL_319e: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a4: Expected Obj, but got Unknown
		//IL_31db: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e1: Expected Obj, but got Unknown
		//IL_31f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fc: Expected Obj, but got Unknown
		//IL_3233: Unknown result type (might be due to invalid IL or missing references)
		//IL_3239: Expected Obj, but got Unknown
		//IL_324e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3254: Expected Obj, but got Unknown
		//IL_328b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3291: Expected Obj, but got Unknown
		//IL_32a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ac: Expected Obj, but got Unknown
		//IL_32e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e9: Expected Obj, but got Unknown
		//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3304: Expected Obj, but got Unknown
		//IL_333b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3341: Expected Obj, but got Unknown
		//IL_3356: Unknown result type (might be due to invalid IL or missing references)
		//IL_335c: Expected Obj, but got Unknown
		//IL_3393: Unknown result type (might be due to invalid IL or missing references)
		//IL_3399: Expected Obj, but got Unknown
		//IL_33ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b4: Expected Obj, but got Unknown
		//IL_33eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f1: Expected Obj, but got Unknown
		//IL_3406: Unknown result type (might be due to invalid IL or missing references)
		//IL_340c: Expected Obj, but got Unknown
		//IL_3443: Unknown result type (might be due to invalid IL or missing references)
		//IL_3449: Expected Obj, but got Unknown
		//IL_345e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3464: Expected Obj, but got Unknown
		//IL_349b: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a1: Expected Obj, but got Unknown
		//IL_34b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34bc: Expected Obj, but got Unknown
		//IL_34f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f9: Expected Obj, but got Unknown
		//IL_350e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3514: Expected Obj, but got Unknown
		//IL_354b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3551: Expected Obj, but got Unknown
		//IL_3566: Unknown result type (might be due to invalid IL or missing references)
		//IL_356c: Expected Obj, but got Unknown
		//IL_35a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35a9: Expected Obj, but got Unknown
		//IL_35be: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c4: Expected Obj, but got Unknown
		//IL_35fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3601: Expected Obj, but got Unknown
		//IL_3616: Unknown result type (might be due to invalid IL or missing references)
		//IL_361c: Expected Obj, but got Unknown
		//IL_3653: Unknown result type (might be due to invalid IL or missing references)
		//IL_3659: Expected Obj, but got Unknown
		//IL_366e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3674: Expected Obj, but got Unknown
		//IL_36ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b1: Expected Obj, but got Unknown
		//IL_36c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36cc: Expected Obj, but got Unknown
		//IL_3703: Unknown result type (might be due to invalid IL or missing references)
		//IL_3709: Expected Obj, but got Unknown
		//IL_371e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3724: Expected Obj, but got Unknown
		//IL_375b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3761: Expected Obj, but got Unknown
		//IL_3776: Unknown result type (might be due to invalid IL or missing references)
		//IL_377c: Expected Obj, but got Unknown
		//IL_37b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b9: Expected Obj, but got Unknown
		//IL_37ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d4: Expected Obj, but got Unknown
		//IL_380b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3811: Expected Obj, but got Unknown
		//IL_3826: Unknown result type (might be due to invalid IL or missing references)
		//IL_382c: Expected Obj, but got Unknown
		//IL_3863: Unknown result type (might be due to invalid IL or missing references)
		//IL_3869: Expected Obj, but got Unknown
		//IL_387e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3884: Expected Obj, but got Unknown
		//IL_38bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_38c1: Expected Obj, but got Unknown
		//IL_38d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_38dc: Expected Obj, but got Unknown
		//IL_3913: Unknown result type (might be due to invalid IL or missing references)
		//IL_3919: Expected Obj, but got Unknown
		//IL_392e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3934: Expected Obj, but got Unknown
		//IL_396b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3971: Expected Obj, but got Unknown
		//IL_3986: Unknown result type (might be due to invalid IL or missing references)
		//IL_398c: Expected Obj, but got Unknown
		//IL_39c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39c9: Expected Obj, but got Unknown
		//IL_39dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e3: Expected Obj, but got Unknown
		//IL_39f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_39fe: Expected Obj, but got Unknown
		//IL_3a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a18: Expected Obj, but got Unknown
		//IL_3a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a33: Expected Obj, but got Unknown
		//IL_3a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a4e: Expected Obj, but got Unknown
		//IL_3a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8b: Expected Obj, but got Unknown
		//IL_3a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa5: Expected Obj, but got Unknown
		//IL_3aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac0: Expected Obj, but got Unknown
		//IL_3af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3afd: Expected Obj, but got Unknown
		//IL_3b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b18: Expected Obj, but got Unknown
		//IL_3b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b55: Expected Obj, but got Unknown
		//IL_3b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b70: Expected Obj, but got Unknown
		//IL_3ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bad: Expected Obj, but got Unknown
		//IL_3bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bc8: Expected Obj, but got Unknown
		//IL_3bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c05: Expected Obj, but got Unknown
		//IL_3c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c20: Expected Obj, but got Unknown
		//IL_3c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5d: Expected Obj, but got Unknown
		//IL_3c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c78: Expected Obj, but got Unknown
		//IL_3caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb5: Expected Obj, but got Unknown
		//IL_3cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd0: Expected Obj, but got Unknown
		//IL_3d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d0d: Expected Obj, but got Unknown
		//IL_3d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d28: Expected Obj, but got Unknown
		//IL_3d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d65: Expected Obj, but got Unknown
		//IL_3d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d80: Expected Obj, but got Unknown
		//IL_3db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dbd: Expected Obj, but got Unknown
		//IL_3dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dd8: Expected Obj, but got Unknown
		//IL_3e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e15: Expected Obj, but got Unknown
		//IL_3e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e2f: Expected Obj, but got Unknown
		//IL_3e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e4a: Expected Obj, but got Unknown
		//IL_3e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e87: Expected Obj, but got Unknown
		//IL_3e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea1: Expected Obj, but got Unknown
		//IL_3eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ebc: Expected Obj, but got Unknown
		//IL_3ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef9: Expected Obj, but got Unknown
		//IL_3f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f14: Expected Obj, but got Unknown
		//IL_3f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f51: Expected Obj, but got Unknown
		//IL_3f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f6b: Expected Obj, but got Unknown
		//IL_3f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f85: Expected Obj, but got Unknown
		//IL_3f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fa0: Expected Obj, but got Unknown
		//IL_3fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fdd: Expected Obj, but got Unknown
		//IL_3ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff7: Expected Obj, but got Unknown
		//IL_400b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4011: Expected Obj, but got Unknown
		//IL_4026: Unknown result type (might be due to invalid IL or missing references)
		//IL_402c: Expected Obj, but got Unknown
		//IL_4063: Unknown result type (might be due to invalid IL or missing references)
		//IL_4069: Expected Obj, but got Unknown
		//IL_407e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4084: Expected Obj, but got Unknown
		//IL_40bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c1: Expected Obj, but got Unknown
		//IL_40d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_40dc: Expected Obj, but got Unknown
		//IL_4113: Unknown result type (might be due to invalid IL or missing references)
		//IL_4119: Expected Obj, but got Unknown
		//IL_412e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4134: Expected Obj, but got Unknown
		//IL_416b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4171: Expected Obj, but got Unknown
		//IL_4185: Unknown result type (might be due to invalid IL or missing references)
		//IL_418b: Expected Obj, but got Unknown
		//IL_41a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_41a6: Expected Obj, but got Unknown
		//IL_41dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_41e3: Expected Obj, but got Unknown
		//IL_41f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_41fe: Expected Obj, but got Unknown
		//IL_4235: Unknown result type (might be due to invalid IL or missing references)
		//IL_423b: Expected Obj, but got Unknown
		//IL_424f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4255: Expected Obj, but got Unknown
		//IL_426a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4270: Expected Obj, but got Unknown
		//IL_4285: Unknown result type (might be due to invalid IL or missing references)
		//IL_428b: Expected Obj, but got Unknown
		//IL_42c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_42c8: Expected Obj, but got Unknown
		//IL_42dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e2: Expected Obj, but got Unknown
		//IL_42f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_42fc: Expected Obj, but got Unknown
		//IL_4311: Unknown result type (might be due to invalid IL or missing references)
		//IL_4317: Expected Obj, but got Unknown
		//IL_432c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4332: Expected Obj, but got Unknown
		//IL_4369: Unknown result type (might be due to invalid IL or missing references)
		//IL_436f: Expected Obj, but got Unknown
		//IL_4384: Unknown result type (might be due to invalid IL or missing references)
		//IL_438a: Expected Obj, but got Unknown
		//IL_43c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43c7: Expected Obj, but got Unknown
		//IL_43dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e2: Expected Obj, but got Unknown
		//IL_4419: Unknown result type (might be due to invalid IL or missing references)
		//IL_441f: Expected Obj, but got Unknown
		//IL_4434: Unknown result type (might be due to invalid IL or missing references)
		//IL_443a: Expected Obj, but got Unknown
		//IL_4471: Unknown result type (might be due to invalid IL or missing references)
		//IL_4477: Expected Obj, but got Unknown
		//IL_448b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4491: Expected Obj, but got Unknown
		//IL_44a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ac: Expected Obj, but got Unknown
		//IL_44e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_44e9: Expected Obj, but got Unknown
		//IL_44fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4503: Expected Obj, but got Unknown
		//IL_4517: Unknown result type (might be due to invalid IL or missing references)
		//IL_451d: Expected Obj, but got Unknown
		//IL_4531: Unknown result type (might be due to invalid IL or missing references)
		//IL_4537: Expected Obj, but got Unknown
		//IL_454c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4552: Expected Obj, but got Unknown
		//IL_4589: Unknown result type (might be due to invalid IL or missing references)
		//IL_458f: Expected Obj, but got Unknown
		//IL_45a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_45a9: Expected Obj, but got Unknown
		//IL_45be: Unknown result type (might be due to invalid IL or missing references)
		//IL_45c4: Expected Obj, but got Unknown
		//IL_45fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4601: Expected Obj, but got Unknown
		//IL_4616: Unknown result type (might be due to invalid IL or missing references)
		//IL_461c: Expected Obj, but got Unknown
		//IL_4653: Unknown result type (might be due to invalid IL or missing references)
		//IL_4659: Expected Obj, but got Unknown
		//IL_466d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4673: Expected Obj, but got Unknown
		//IL_4688: Unknown result type (might be due to invalid IL or missing references)
		//IL_468e: Expected Obj, but got Unknown
		//IL_46c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_46cb: Expected Obj, but got Unknown
		//IL_46df: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e5: Expected Obj, but got Unknown
		//IL_46fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_4700: Expected Obj, but got Unknown
		//IL_4737: Unknown result type (might be due to invalid IL or missing references)
		//IL_473d: Expected Obj, but got Unknown
		//IL_4751: Unknown result type (might be due to invalid IL or missing references)
		//IL_4757: Expected Obj, but got Unknown
		//IL_476c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4772: Expected Obj, but got Unknown
		//IL_47a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_47af: Expected Obj, but got Unknown
		//IL_47c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c9: Expected Obj, but got Unknown
		//IL_47de: Unknown result type (might be due to invalid IL or missing references)
		//IL_47e4: Expected Obj, but got Unknown
		//IL_47f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ff: Expected Obj, but got Unknown
		//IL_4836: Unknown result type (might be due to invalid IL or missing references)
		//IL_483c: Expected Obj, but got Unknown
		//IL_4851: Unknown result type (might be due to invalid IL or missing references)
		//IL_4857: Expected Obj, but got Unknown
		//IL_488e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4894: Expected Obj, but got Unknown
		//IL_48a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_48af: Expected Obj, but got Unknown
		//IL_48e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_48ec: Expected Obj, but got Unknown
		//IL_4901: Unknown result type (might be due to invalid IL or missing references)
		//IL_4907: Expected Obj, but got Unknown
		//IL_493e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4944: Expected Obj, but got Unknown
		//IL_4958: Unknown result type (might be due to invalid IL or missing references)
		//IL_495e: Expected Obj, but got Unknown
		//IL_4973: Unknown result type (might be due to invalid IL or missing references)
		//IL_4979: Expected Obj, but got Unknown
		//IL_49b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_49b6: Expected Obj, but got Unknown
		//IL_49ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_49d0: Expected Obj, but got Unknown
		//IL_49e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_49eb: Expected Obj, but got Unknown
		//IL_4a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a28: Expected Obj, but got Unknown
		//IL_4a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a42: Expected Obj, but got Unknown
		//IL_4a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a5d: Expected Obj, but got Unknown
		//IL_4a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a9a: Expected Obj, but got Unknown
		//IL_4aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ab4: Expected Obj, but got Unknown
		//IL_4ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ace: Expected Obj, but got Unknown
		//IL_4ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ae9: Expected Obj, but got Unknown
		//IL_4b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b26: Expected Obj, but got Unknown
		//IL_4b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b40: Expected Obj, but got Unknown
		//IL_4b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b5b: Expected Obj, but got Unknown
		//IL_4b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b98: Expected Obj, but got Unknown
		//IL_4bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bb2: Expected Obj, but got Unknown
		//IL_4bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bcc: Expected Obj, but got Unknown
		//IL_4be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4be7: Expected Obj, but got Unknown
		//IL_4c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c24: Expected Obj, but got Unknown
		//IL_4c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c3e: Expected Obj, but got Unknown
		//IL_4c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c59: Expected Obj, but got Unknown
		//IL_4cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cfb: Expected Obj, but got Unknown
		//IL_4d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d2d: Expected Obj, but got Unknown
		//IL_4d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d48: Expected Obj, but got Unknown
		//IL_4d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d7a: Expected Obj, but got Unknown
		//IL_4d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d89: Expected Obj, but got Unknown
		//IL_4d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d99: Expected Obj, but got Unknown
		//IL_4da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4da9: Expected Obj, but got Unknown
		//IL_4df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dfb: Expected Obj, but got Unknown
		//IL_4eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eb9: Expected Obj, but got Unknown
		//IL_4ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eeb: Expected Obj, but got Unknown
		//IL_4f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f06: Expected Obj, but got Unknown
		//IL_4f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f3a: Expected Obj, but got Unknown
		//IL_4f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f4a: Expected Obj, but got Unknown
		//IL_4fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fe8: Expected Obj, but got Unknown
		//IL_5020: Unknown result type (might be due to invalid IL or missing references)
		//IL_5026: Expected Obj, but got Unknown
		//IL_505e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5064: Expected Obj, but got Unknown
		//IL_509c: Unknown result type (might be due to invalid IL or missing references)
		//IL_50a2: Expected Obj, but got Unknown
		//IL_50da: Unknown result type (might be due to invalid IL or missing references)
		//IL_50e0: Expected Obj, but got Unknown
		//IL_5118: Unknown result type (might be due to invalid IL or missing references)
		//IL_511e: Expected Obj, but got Unknown
		//IL_5156: Unknown result type (might be due to invalid IL or missing references)
		//IL_515c: Expected Obj, but got Unknown
		//IL_5194: Unknown result type (might be due to invalid IL or missing references)
		//IL_519a: Expected Obj, but got Unknown
		//IL_51d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_51d8: Expected Obj, but got Unknown
		//IL_5210: Unknown result type (might be due to invalid IL or missing references)
		//IL_5216: Expected Obj, but got Unknown
		//IL_524e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5254: Expected Obj, but got Unknown
		//IL_528c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5292: Expected Obj, but got Unknown
		//IL_52ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d0: Expected Obj, but got Unknown
		//IL_5308: Unknown result type (might be due to invalid IL or missing references)
		//IL_530e: Expected Obj, but got Unknown
		//IL_5346: Unknown result type (might be due to invalid IL or missing references)
		//IL_534c: Expected Obj, but got Unknown
		//IL_5384: Unknown result type (might be due to invalid IL or missing references)
		//IL_538a: Expected Obj, but got Unknown
		//IL_53c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_53c8: Expected Obj, but got Unknown
		//IL_5400: Unknown result type (might be due to invalid IL or missing references)
		//IL_5406: Expected Obj, but got Unknown
		//IL_543e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5444: Expected Obj, but got Unknown
		//IL_547c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5482: Expected Obj, but got Unknown
		//IL_54ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_54c0: Expected Obj, but got Unknown
		//IL_54f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_54fe: Expected Obj, but got Unknown
		//IL_5536: Unknown result type (might be due to invalid IL or missing references)
		//IL_553c: Expected Obj, but got Unknown
		//IL_55d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_55d9: Expected Obj, but got Unknown
		//IL_55ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_55f4: Expected Obj, but got Unknown
		//IL_5615: Unknown result type (might be due to invalid IL or missing references)
		//IL_561b: Expected Obj, but got Unknown
		//IL_5630: Unknown result type (might be due to invalid IL or missing references)
		//IL_5636: Expected Obj, but got Unknown
		//IL_564b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5651: Expected Obj, but got Unknown
		//IL_5ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cd2: Expected Obj, but got Unknown
		//IL_5ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ced: Expected Obj, but got Unknown
		//IL_5fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fce: Expected Obj, but got Unknown
		//IL_6006: Unknown result type (might be due to invalid IL or missing references)
		//IL_600c: Expected Obj, but got Unknown
		//IL_6044: Unknown result type (might be due to invalid IL or missing references)
		//IL_604a: Expected Obj, but got Unknown
		//IL_60e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_60e9: Expected Obj, but got Unknown
		//IL_60ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_6105: Expected Obj, but got Unknown
		//IL_611b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6121: Expected Obj, but got Unknown
		//IL_6136: Unknown result type (might be due to invalid IL or missing references)
		//IL_613c: Expected Obj, but got Unknown
		//IL_6762: Unknown result type (might be due to invalid IL or missing references)
		//IL_6768: Expected Obj, but got Unknown
		//IL_677e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6784: Expected Obj, but got Unknown
		//IL_6a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a34: Expected Obj, but got Unknown
		//IL_6a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a50: Expected Obj, but got Unknown
		//IL_6c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c4c: Expected Obj, but got Unknown
		//IL_6c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c68: Expected Obj, but got Unknown
		//IL_6d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d62: Expected Obj, but got Unknown
		//IL_6d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6da0: Expected Obj, but got Unknown
		//IL_6dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dde: Expected Obj, but got Unknown
		//IL_6e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e1c: Expected Obj, but got Unknown
		//IL_6e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e5a: Expected Obj, but got Unknown
		//IL_6e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e98: Expected Obj, but got Unknown
		//IL_6ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ed6: Expected Obj, but got Unknown
		//IL_6f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f14: Expected Obj, but got Unknown
		//IL_6f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f52: Expected Obj, but got Unknown
		//IL_6f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f90: Expected Obj, but got Unknown
		//IL_6fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fce: Expected Obj, but got Unknown
		//IL_7006: Unknown result type (might be due to invalid IL or missing references)
		//IL_700c: Expected Obj, but got Unknown
		//IL_7044: Unknown result type (might be due to invalid IL or missing references)
		//IL_704a: Expected Obj, but got Unknown
		//IL_7082: Unknown result type (might be due to invalid IL or missing references)
		//IL_7088: Expected Obj, but got Unknown
		//IL_70c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_70c6: Expected Obj, but got Unknown
		//IL_70fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_7104: Expected Obj, but got Unknown
		Msl.AddFunction(base.ModFiles.GetCode("scr_enemy_spawn_wraith_servant.gml"), "scr_enemy_spawn_wraith_servant");
		Msl.AddFunction(base.ModFiles.GetCode("scr_servant_sort_targets.gml"), "scr_servant_sort_targets");
		Msl.AddFunction(base.ModFiles.GetCode("scr_servant_find_enemy.gml"), "scr_servant_find_enemy");
		Msl.AddFunction(base.ModFiles.GetCode("scr_param_servant.gml"), "scr_param_servant");
		Msl.AddFunction(base.ModFiles.GetCode("scr_ressurection_servant.gml"), "scr_ressurection_servant");
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_Servant", "", "o_enemy", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_Servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_Mouse_5.gml"), (EventType)6, 5u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_vamp_Servant", "", "o_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_vamp_Servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_vamp_Servant_Alarm_2.gml"), (EventType)2, 2u),
			new MslEvent(base.ModFiles.GetCode("o_vamp_Servant_PreCreate_0.gml"), (EventType)14, 0u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_Servant", "", "o_vamp_Servant", true, false, true, (CollisionShapeFlags)1), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_Servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_Servant_Alarm_2.gml"), (EventType)2, 2u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_Servant_Alarm_7.gml"), (EventType)2, 7u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_Undead_Servant", "", "o_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[1]
		{
			new MslEvent(base.ModFiles.GetCode("o_Undead_Servant_Create_0.gml"), (EventType)0, 0u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_Specter_Servant", "", "o_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[1]
		{
			new MslEvent(base.ModFiles.GetCode("o_Specter_Servant_Create_0.gml"), (EventType)0, 0u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("c_zombie_Servant", "", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("c_zombie_Servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("c_zombie_Servant_Destroy_0.gml"), (EventType)1, 0u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_Servant", "", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_Servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_skeleton_Servant_Destroy_0.gml"), (EventType)1, 0u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_convert_club_servant", "s_proselyte_convert_club01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_convert_club_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_convert_dagger_servant", "s_proselyte_convert_dagger01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_convert_dagger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_convert_2hmace_servant", "s_proselyte_convert_gmace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_convert_2hmace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_disciple_2hflail_servant", "s_proselyte_disciple_2hflail01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_disciple_2hflail_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_disciple_staff_servant", "s_proselyte_disciple_2hflail01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_disciple_staff_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_disciple_2haxe_servant", "s_proselyte_disciple_2haxe01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_disciple_2haxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_flagellant_servant", "s_proselyte_flagellant01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_flagellant_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_outcast_servant", "s_proselyte_outcast01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_outcast_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_immolated_servant", "s_proselyte_immolated01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_immolated_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_harbinger_servant", "s_proselyte_harbinger01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_harbinger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_apostate_servant", "s_proselyte_apostate01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_apostate_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_abomination_servant", "s_proselyte_abomination", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_abomination_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_zealot_spear_servant", "s_proselyte_zealot_spear01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_zealot_spear_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_zealot_mace_servant", "s_proselyte_zealot_mace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_zealot_mace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_tormentor_chain_servant", "s_proselyte_tormentor_chain01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_tormentor_chain_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_tormentor_cleaver_servant", "s_proselyte_tormentor_cleaver01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_tormentor_cleaver_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_stonethrower_servant", "s_proselyte_stonethrower01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_stonethrower_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_adept_dagger_servant", "s_proselyte_adept_dagger01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_adept_dagger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_adept_torch_servant", "s_proselyte_adept06", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_adept_torch_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_toller_servant", "s_proselyte_toller01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_toller_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_blood_golem_servant", "s_blood_golem", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[6]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Other_21.gml"), (EventType)7, 21u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_PreCreate_0.gml"), (EventType)14, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_matriarch_servant", "s_proselyte_matriarch", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_matriarch_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_matriarch_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_seer_servant", "s_proselyte_seer", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_seer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_furie_servant", "s_proselyte_furie01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_furie_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_liturgist_servant", "s_proselyte_liturgist01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_liturgist_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_executioner_chain_servant", "s_proselyte_executioner01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_executioner_chain_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_executioner_2hsword_servant", "s_proselyte_executioner02", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_executioner_2hsword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_chosen_servant", "s_proselyte_chosen01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_chosen_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_amalgam_tongue_servant", "s_proselyte_amalgam02", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_amalgam_tongue_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_amalgam_winged_servant", "s_proselyte_amalgam01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_amalgam_winged_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_sanguimage_servant", "s_proselyte_sanguimage01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_sanguimage_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_brander_servant", "s_proselyte_Brander", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_brander_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_brander_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_admonisher_servant", "s_proselyte_admonisher", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_admonisher_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_admonisher_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_begotten_servant", "s_proselyte_begotten", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_begotten_tentacle_servant", "s_proselyte_begotten_piece", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Alarm_2.gml"), (EventType)2, 2u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_begotten_flesh_servant", "s_proselyte_begotten_corpse", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_flesh_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_flesh_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Alarm_2.gml"), (EventType)2, 2u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_fiend_2hmace_servant", "s_proselyte_fiend_2hmace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_fiend_2hmace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_fiend_2haxe_servant", "s_proselyte_fiend_2haxe01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_fiend_2haxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_girrud_servant", "s_proselyte_girrud01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_girrud_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_saggul_servant", "s_proselyte_saggul01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_saggul_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_saggul_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_impaler_servant", "s_proselyte_impaler01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_impaler_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_murkstalker_servant", "s_proselyte_murkstalker01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_murkstalker_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_murkstalker_servant_Step_0.gml"), (EventType)3, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_murkstalker_servant_Other_11.gml"), (EventType)7, 11u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_thrall_servant", "s_thrall", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[5]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_thrall_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_thrall_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_thrall_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_PreCreate_0.gml"), (EventType)14, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_chainbound_servant", "s_proselyte_chainbound", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_chainbound_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_chainbound_freed_servant", "s_proselyte_chainbound_freed", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_chainbound_freed_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_ecclesiarch_servant", "s_proselyte_ecclesiarch01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_ecclesiarch_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_anmarrak_servant", "s_proselyte_anmarrak", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_anmarrak_tentacle_servant", "s_tentacle_loop", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[5]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Step_0.gml"), (EventType)3, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_juggernaut_servant", "s_proselyte_Juggernaut", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_juggernaut_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_juggernaut_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_wormbearer_servant", "s_proselyte_wormbearer", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_wormbearer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_worm_servant", "s_Worm", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_worm_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_worm_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_cherub_spear_servant", "s_proselyte_cherub_spear01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_spear_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_spear_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_cherub_axe_servant", "s_proselyte_cherub_axe01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_axe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_spear_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_bloodhunter_servant", "s_proselyte_bloodhunter", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodhunter_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodhunter_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodhunter_servant_Other_11.gml"), (EventType)7, 11u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_templar_sword_servant", "s_proselyte_templar_sword01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_templar_sword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_templar_mace_servant", "s_proselyte_templar_mace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_templar_mace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_anointed_servant", "s_proselyte_anointed01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anointed_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_yagram_servant", "s_proselyte_yagram01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_yagram_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_yagram_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_nakkatar_servant", "s_proselyte_nakkatar", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_nakkatar_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_nakkatar_servant_Step_0.gml"), (EventType)3, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_apostle_servant", "s_proselyte_apostle", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_apostle_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_apostle_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_unholy_bell_servant", "s_blasphemousmass_bell01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_unholy_bell_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_unholy_bell_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_unholy_bell_servant_Step_2.gml"), (EventType)3, 2u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_leechlord_servant", "s_proselyte_leechlord", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_leechlord_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_leechlord_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_spitter_worm_servant", "s_SpitterWorm", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_spitter_worm_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_worm_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_spitter_worm_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_bloodgorger_worm_servant", "s_BloodgorerWorm", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodgorger_worm_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodgorger_worm_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombie_servant", "s_zombie01", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombie_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieAxe_servant", "s_zombie05", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieAxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieDagger_servant", "s_zombie04", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieDagger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombiePitchfork_servant", "s_zombie06", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombiePitchfork_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_swordsman_servant", "s_skeleton_swordsman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_swordsman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_axeman_servant", "s_skeleton_axeman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_axeman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_maceman_servant", "s_skeleton_maceman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_maceman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_spearman_servant", "s_skeleton_spearman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_spearman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_bowman_servant", "s_skeleton_bowman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_bowman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_monk_servant", "s_skeleton_monk", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_monk_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieGuardSword_servant", "s_zombie07", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieGuardSword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieGuardSpear_servant", "s_zombie10", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieGuardSpear_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieGuardHalberd_servant", "s_zombie11", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieGuardHalberd_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieBrigandSword_servant", "s_zombie09", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieBrigandSword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_footman_servant", "s_skeleton_footman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_footman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_militiaman_servant", "s_skeleton_militiaman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_militiaman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_defender_servant", "s_skeleton_defender", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_defender_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_guard_servant", "s_skeleton_guard", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_guard_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_ranger_servant", "s_skeleton_ranger", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_ranger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_priest_servant", "s_skeleton_priest", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_priest_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghast_servant", "s_ghast", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghast_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieSoldierMace_servant", "s_zombie12", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieSoldierMace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieSoldierAxe_servant", "s_zombie13", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieSoldierAxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieSoldierHalberd_servant", "s_zombie14", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieSoldierHalberd_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_soldier_servant", "s_skeleton_soldier", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_soldier_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_warrior_servant", "s_skeleton_warrior", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_warrior_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_armorbreaker_servant", "s_skeleton_armorbreaker", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_armorbreaker_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_halberdier_servant", "s_skeleton_halberdier", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_halberdier_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_crossbowman_servant", "s_skeleton_crossbowman", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_crossbowman_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_highpriest_servant", "s_skeleton_highpriest", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_highpriest_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghast_accursed_servant", "s_ghast02", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghast_accursed_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombieHalberdDecayedSoldier_servant", "s_zombie16", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombieHalberdDecayedSoldier_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombie2HMaceDecayedSoldier_servant", "s_zombie15", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombie2HMaceDecayedSoldier_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_zombie2HAxeDecayedSoldier_servant", "s_zombie17", "c_zombie_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_zombie2HAxeDecayedSoldier_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_knightAxe_servant", "s_skeleton_knightaxe", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_knightAxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_knightSword_servant", "s_skeleton_knightsword", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_knightSword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_knightHammer_servant", "s_skeleton_knighthammer", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_knightHammer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_guardianSword_servant", "s_skeleton_knightswordshield", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_guardianSword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_guardianMace_servant", "s_skeleton_guardianmace", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_guardianMace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_guardianAxe_servant", "s_skeleton_guardianaxe", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_guardianAxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_skeleton_guardianSpear_servant", "s_skeleton_knightspear", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_skeleton_guardianSpear_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghast_elder_servant", "s_ghast03", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghast_elder_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_occultist_servant", "s_necromancer01", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_occultist_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_archivist_servant", "s_archivist", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_archivist_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_necromancer_servant", "s_necromancer02", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_necromancer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_undertaker_servant", "s_undertaker", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_undertaker_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ritualist_servant", "s_necromancer04", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ritualist_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_desecrator_servant", "s_necromancer07", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_desecrator_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_mortician_servant", "s_mortician", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_mortician_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_wraithbinder_servant", "s_necromancer06", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_wraithbinder_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_armored_husk_servant", "s_husk", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_armored_husk_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_crypt_warden_servant", "s_cryptwarden", "o_skeleton_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_crypt_warden_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_crypt_warden_servant_Other_11.gml"), (EventType)7, 11u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_restless_hero_servant", "s_restlesshero", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_restless_hero_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_revenant_servant", "s_necromancer05", "o_Undead_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_revenant_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_spectral_herald_servant", "s_ghost_spectralherald", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_spectral_herald_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_squire_servant", "s_ghost_squire", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_squire_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_sergeant_servant", "s_ghost_sergeant", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_sergeant_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_knight_servant", "s_wraith_knight", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_knight_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_templar_servant", "s_ghost_templar", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_templar_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_commander_servant", "s_ghost_commander", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_commander_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_servant", "s_ghost", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_monk_servant", "s_ghost_monk", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_monk_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_cleric_servant", "s_ghost_cleric", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_cleric_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_ghost_seer_servant", "s_wraith_hierarch", "o_Specter_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_ghost_seer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_convert_club_servant_servant", "s_proselyte_convert_club01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_convert_club_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_convert_dagger_servant_servant", "s_proselyte_convert_dagger01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_convert_dagger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_convert_2hmace_servant_servant", "s_proselyte_convert_gmace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_convert_2hmace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_disciple_2hflail_servant_servant", "s_proselyte_disciple_2hflail01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_disciple_2hflail_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_disciple_staff_servant_servant", "s_proselyte_disciple_2hflail01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_disciple_staff_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_disciple_2haxe_servant_servant", "s_proselyte_disciple_2haxe01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_disciple_2haxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_flagellant_servant_servant", "s_proselyte_flagellant01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_flagellant_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_outcast_servant_servant", "s_proselyte_outcast01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_outcast_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_immolated_servant_servant", "s_proselyte_immolated01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_immolated_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_harbinger_servant_servant", "s_proselyte_harbinger01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_harbinger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_apostate_servant_servant", "s_proselyte_apostate01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_apostate_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_abomination_servant_servant", "s_proselyte_abomination", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_abomination_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_zealot_spear_servant_servant", "s_proselyte_zealot_spear01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_zealot_spear_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_zealot_mace_servant_servant", "s_proselyte_zealot_mace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_zealot_mace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_tormentor_chain_servant_servant", "s_proselyte_tormentor_chain01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_tormentor_chain_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_tormentor_cleaver_servant_servant", "s_proselyte_tormentor_cleaver01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_tormentor_cleaver_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_stonethrower_servant_servant", "s_proselyte_stonethrower01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_stonethrower_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_adept_dagger_servant_servant", "s_proselyte_adept_dagger01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_adept_dagger_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_adept_torch_servant_servant", "s_proselyte_adept06", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_adept_torch_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_toller_servant_servant", "s_proselyte_toller01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_toller_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_blood_golem_servant_servant", "s_blood_golem", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[6]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Other_21.gml"), (EventType)7, 21u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_PreCreate_0.gml"), (EventType)14, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_matriarch_servant_servant", "s_proselyte_matriarch", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_matriarch_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_matriarch_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_seer_servant_servant", "s_proselyte_seer", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_seer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_furie_servant_servant", "s_proselyte_furie01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_furie_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_liturgist_servant_servant", "s_proselyte_liturgist01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_liturgist_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_executioner_chain_servant_servant", "s_proselyte_executioner01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_executioner_chain_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_executioner_2hsword_servant_servant", "s_proselyte_executioner02", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_executioner_2hsword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_chosen_servant_servant", "s_proselyte_chosen01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_chosen_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_amalgam_tongue_servant_servant", "s_proselyte_amalgam02", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_amalgam_tongue_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_amalgam_winged_servant_servant", "s_proselyte_amalgam01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_amalgam_winged_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_sanguimage_servant_servant", "s_proselyte_sanguimage01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_sanguimage_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_brander_servant_servant", "s_proselyte_Brander", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_brander_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_brander_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_admonisher_servant_servant", "s_proselyte_admonisher", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_admonisher_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_admonisher_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_begotten_servant_servant", "s_proselyte_begotten", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_begotten_tentacle_servant_servant", "s_proselyte_begotten_piece", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Alarm_2.gml"), (EventType)2, 2u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_begotten_flesh_servant_servant", "s_proselyte_begotten_corpse", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_flesh_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_flesh_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Alarm_2.gml"), (EventType)2, 2u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_begotten_tentacle_servant_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_fiend_2hmace_servant_servant", "s_proselyte_fiend_2hmace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_fiend_2hmace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_fiend_2haxe_servant_servant", "s_proselyte_fiend_2haxe01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_fiend_2haxe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_girrud_servant_servant", "s_proselyte_girrud01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_girrud_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_saggul_servant_servant", "s_proselyte_saggul01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_saggul_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_saggul_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_impaler_servant_servant", "s_proselyte_impaler01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_impaler_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_murkstalker_servant_servant", "s_proselyte_murkstalker01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_murkstalker_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_murkstalker_servant_Step_0.gml"), (EventType)3, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_murkstalker_servant_Other_11.gml"), (EventType)7, 11u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_thrall_servant_servant", "s_thrall", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[5]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_thrall_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_thrall_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_thrall_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_blood_golem_servant_PreCreate_0.gml"), (EventType)14, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_chainbound_servant_servant", "s_proselyte_chainbound", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_chainbound_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_chainbound_freed_servant_servant", "s_proselyte_chainbound_freed", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_chainbound_freed_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_ecclesiarch_servant_servant", "s_proselyte_ecclesiarch01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_ecclesiarch_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_anmarrak_servant_servant", "s_proselyte_anmarrak", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_anmarrak_tentacle_servant_servant", "s_tentacle_loop", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[5]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Step_0.gml"), (EventType)3, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anmarrak_tentacle_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_juggernaut_servant_servant", "s_proselyte_Juggernaut", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_juggernaut_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_juggernaut_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_wormbearer_servant_servant", "s_proselyte_wormbearer", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_wormbearer_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_worm_servant_servant", "s_Worm", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_worm_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_worm_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_cherub_spear_servant_servant", "s_proselyte_cherub_spear01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_spear_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_spear_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_cherub_axe_servant_servant", "s_proselyte_cherub_axe01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_axe_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_cherub_spear_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_bloodhunter_servant_servant", "s_proselyte_bloodhunter", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodhunter_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodhunter_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodhunter_servant_Other_11.gml"), (EventType)7, 11u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_templar_sword_servant_servant", "s_proselyte_templar_sword01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_templar_sword_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_templar_mace_servant_servant", "s_proselyte_templar_mace01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_templar_mace_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_anointed_servant_servant", "s_proselyte_anointed01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_anointed_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_yagram_servant_servant", "s_proselyte_yagram01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_yagram_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_yagram_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_nakkatar_servant_servant", "s_proselyte_nakkatar", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_nakkatar_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_nakkatar_servant_Step_0.gml"), (EventType)3, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_apostle_servant_servant", "s_proselyte_apostle", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_apostle_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_apostle_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_unholy_bell_servant_servant", "s_blasphemousmass_bell01", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_unholy_bell_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_unholy_bell_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_unholy_bell_servant_Step_2.gml"), (EventType)3, 2u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_leechlord_servant_servant", "s_proselyte_leechlord", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_leechlord_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_leechlord_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_spitter_worm_servant_servant", "s_SpitterWorm", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_spitter_worm_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_worm_servant_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_spitter_worm_servant_Other_7.gml"), (EventType)7, 7u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_proselyte_bloodgorger_worm_servant_servant", "s_BloodgorerWorm", "o_proselyte_Servant", true, false, true, (CollisionShapeFlags)0), new MslEvent[3]
		{
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodgorger_worm_servant_Create_0.gml"), (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_proselyte_bloodgorger_worm_Destroy_0.gml"), (EventType)1, 0u),
			new MslEvent(base.ModFiles.GetCode("o_Servant_servant_AI_Other_10.gml"), (EventType)7, 10u)
		});
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_skill_Create_0")), "event_inherited()\nimage_speed = 0\ninfo_height = 0\nyshift = 25\ntype = ds_list_find_value(global.skill_category, 2)\ntarget = -4\ncrit_attack = 0\nsave_counter = 0\nxshift = 226\nyy = 78\nweapon = \"any\"\ntype_col = make_color_rgb(163, 183, 25)\nclass = \"passive\"\npassive = true\ntext_map = __dsDebuggerMapCreate()\nis_skill = false"));
		Msl.InjectTableSkillsLocalization(new LocalizationSkill[1]
		{
			new LocalizationSkill("Aura_of_Unlife", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Aura of Unlife"
				},
				{
					(ModLanguage)2,
					"不死之兆"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"For every ~w~3~/~ spells cast, the ~w~3rd~/~ spell of the same school instantly restores ~lg~9%~/~ of Max Health to the caster and all Undead within sight, and inflicts ~r~-9% Unholy Resistance~/~ on all enemies within sight for ~w~9~/~ turns.##This effect stacks up to ~w~5~/~ times.##For every ~w~6~/~ spells cast, the ~w~6th~/~ spell of the same school randomly resurrects an Undead within sight, instantly restoring ~lg~33%~/~ of its Max Health and ~bl~33%~/~ of its Max Energy.##The resurrected Undead's armor durability is set to ~w~0%~/~, and all of its ability cooldowns are reduced by ~w~50%~/~."
				},
				{
					(ModLanguage)2,
					string.Join("##", "以~w~3~/~道法咒为周期，每个周期的第~w~3~/~道同系法咒令施法者和视野之内所有亡灵立刻恢复生命上限~lg~9%~/~的生命，同时令视野之内所有敌人~w~9~/~个回合之内~r~邪术抗性-9%~/ ~。", "这个效果可以叠加，最多~w~5~/~层。", "以~w~6~/~道法咒为周期，每个周期的第~w~6~/~道同系法咒随机复活视野之内的一个亡灵，令其立刻恢复生命上限~lg~33%~/~的生命和精力上限~bl~33%~/~的精力。", "复活的亡灵防具耐久变为~w~0%~/~，而且所有能力冷却时间缩短~w~50%~/~。")
				}
			})
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_pass_skill_aura_of_unlife", "s_passive_AuraofUnlife", "o_skill_passive", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent("\n        event_inherited()\n        scr_skill_atr(\"Aura_of_Unlife\")\n        attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\n        attributes_value_to_open = 20\n        level_to_open = 22\n        tier_to_open = global.necromancy_tier1\n        class = \"spell\"\n        save_counter = 1\n    ", (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_pass_skill_aura_of_unlife_Other_13.gml"), (EventType)7, 13u)
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_db_revelation_Attack", "s_db_revelation_attack", "o_physical_debuff", true, false, true, (CollisionShapeFlags)0), new MslEvent[4]
		{
			new MslEvent("event_inherited()\nscr_buff_atr()\nstack = 1\nrestore_owner = true", (EventType)0, 0u),
			new MslEvent("event_inherited()", (EventType)2, 2u),
			new MslEvent("event_inherited()", (EventType)7, 10u),
			new MslEvent("event_inherited()\nscr_enemy_spawn_wraith_servant(choose(o_ghost_servant, o_ghost_squire_servant, o_ghost_monk_servant, o_ghost_sergeant_servant, o_ghost_knight_servant, o_ghost_cleric_servant))", (EventType)7, 14u)
		});
		Msl.InjectTableModifiersLocalization(new LocalizationModifier[1]
		{
			new LocalizationModifier("o_db_revelation_Attack", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Revelation: Overconfidence"
				},
				{
					(ModLanguage)2,
					"幻象：自傲"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"using ~w~Attack~/~ skills or spells summons a random weak ~w~Wraith~/~ on an adjacent tile."
				},
				{
					(ModLanguage)2,
					"运用~sy~攻击~/~技能或催动法咒会令临近的方格随机出现一个较弱的~sy~幽魂~/~。"
				}
			})
		});
		Msl.InjectTableSkillsLocalization(new LocalizationSkill[1]
		{
			new LocalizationSkill("Ghastly_Revelation", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Ghastly Revelation"
				},
				{
					(ModLanguage)2,
					"幽冥幻景"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					string.Join("##", "Every ~w~third~/~ spell of the same school applies one of the following effects to a random enemy within Vision for ~w~3~/~ turns:", "~r~Revelation: Overconfidence~/~: using ~w~Attack~/~ skills or spells summons a random weak ~w~Wraith~/~ on an adjacent tile", "~r~Revelation: Hastiness~/~: moving to another tile or using a ~w~Maneuver~/~ causes ~ur~33 Unholy Damage~/~.", "~r~Revelation: Misfortune~/~: a fumbled strike, shot, or miscast spell increases the cooldown of all abilities by ~r~2~/~ turns.", "~r~Revelation: Losses~/~: using or throwing an item causes ~r~Confusion~/~, ~r~Weakness~/~, or ~r~Enervation~/~ for ~w~10~/~ turns, or ~r~Blindness~/~ for ~w~3~/~ turns.")
				},
				{
					(ModLanguage)2,
					string.Join("##", "以~w~三~/~道法咒为周期，每个周期第~w~三~/~道同系法咒会令视野之内随机一个敌人获得以下一个效果，效果存续~w~3~/~个回合：", "~r~幻象：自傲~/~：运用~sy~攻击~/~技能或催动法咒会令临近的方格随机出现一个较弱的~sy~幽魂~/~", "~r~幻象：匆忙~/~：移到其他方格或运用~w~机动能力~/~会受到~ur~33点邪术伤害~/~", "~r~幻象：不利~/~：击打或射击失手或者法咒失误会令所有能力冷却时间增加~r~2~/~个回合", "~r~幻象：损失~/~：使用物品或投掷物品会造成~w~10~/~个回合的~r~慌乱~/~、~r~虚弱~/~、~r~倦怠~/~或~w~3~/~个回合的~r~盲目~/~。")
				}
			})
		});
		GameObjectUtils.ApplyEvent(Msl.AddObject("o_pass_skill_ghastly_revelation", "s_passive_GhastlyRevelation", "o_skill_passive", true, false, true, (CollisionShapeFlags)0), new MslEvent[2]
		{
			new MslEvent("\n        event_inherited()\n        scr_skill_atr(\"Ghastly_Revelation\")\n        attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\n        attributes_value_to_open = 25\n        level_to_open = 23\n        tier_to_open = global.necromancy_tier1\n        save_counter = 1\n        class = \"spell\"\n    ", (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_pass_skill_ghastly_revelation_Other_13.gml"), (EventType)7, 13u)
		});
		UndertaleGameObject val = Msl.AddObject("o_skill_necromancy", "", "o_skill", true, false, true, (CollisionShapeFlags)1);
		GameObjectUtils.ApplyEvent(val, new MslEvent[2]
		{
			new MslEvent("\n                event_inherited()\n                Miscast_Type = \"Arcanistic_Miscast_Chance\"\n            ", (EventType)0, 0u),
			new MslEvent("\n        event_inherited()\n        if instance_exists(o_player)\n        {\n            scr_skill_call_passive(o_pass_skill_aura_of_unlife, o_player.id)\n            scr_skill_call_passive(o_pass_skill_ghastly_revelation, o_player.id)\n        }\n    ", (EventType)7, 15u)
		});
		Msl.InjectTableSkillsLocalization(new LocalizationSkill[1]
		{
			new LocalizationSkill("Summon_Servant", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Hela's Edict"
				},
				{
					(ModLanguage)2,
					"海拉的传谕"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					string.Join("##", "Proclaims a false edict in the name of Hela, the Goddess of Death, summoning an ~ur~Undead~/~ on the target tile. The type of ~ur~Undead~/~ summoned depends on the caster's ~lg~\"Magic Power\"~/~ and ~lg~\"Level\"~/~.", "If this ~ur~Undead~/~ is struck by its summoner while there are no enemies nearby, it dies ~r~instantly~/~.", "Only ~ur~Undead~/~ summoned by this skill can be resurrected by spells of the same school.")
				},
				{
					(ModLanguage)2,
					string.Join("##", "假传死亡之神海拉的神谕，在目标方格召唤一个~ur~亡灵~/~。这个~ur~亡灵~/~的类型取决于召唤者的~lg~“法力”~/~和~lg~“等级”~/~。", "当~ur~亡灵~/~在附近无敌人的情况下受到召唤者攻击会立即~r~死亡~/~。", "只有此技能召唤的~ur~亡灵~/~才能被同系法咒复活。")
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Darkbolt", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...Av..."
					},
					{
						(ModLanguage)2,
						"海...阿瓦..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Death_Touch", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...Hs..."
					},
					{
						(ModLanguage)2,
						"瓦...西斯..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Essence_Leech", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·MOGO!"
					},
					{
						(ModLanguage)2,
						"海拉·蒙戈温！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Essence_Leech", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE..Mog..."
					},
					{
						(ModLanguage)2,
						"海拉...蒙戈..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Dark_Blessing", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...Ble..."
					},
					{
						(ModLanguage)2,
						"海...布莱..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Curse_of_Weakness", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Agony!"
					},
					{
						(ModLanguage)2,
						"海拉·阿格尼！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Curse_of_Weakness", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...gony..."
					},
					{
						(ModLanguage)2,
						"海...格尼..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Curse", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...Tho..."
					},
					{
						(ModLanguage)2,
						"海...索..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Sigil_Of_Binding", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Cifer!"
					},
					{
						(ModLanguage)2,
						"海拉·西斯法！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Sigil_Of_Binding", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...Cif..."
					},
					{
						(ModLanguage)2,
						"海拉...西斯..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Mark_of_the_Feast", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Sov...Vam..."
					},
					{
						(ModLanguage)2,
						"因...斯..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Life_Leech", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Wura...Los..."
					},
					{
						(ModLanguage)2,
						"乌拉...卢兹..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Deadly_Premonition", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Valimar!"
					},
					{
						(ModLanguage)2,
						"海拉·瓦尔玛！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Deadly_Premonition", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...Vmar..."
					},
					{
						(ModLanguage)2,
						"海...尔玛..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Final_Stand", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Devono!"
					},
					{
						(ModLanguage)2,
						"海拉·德佛诺！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Final_Stand", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HE...vono..."
					},
					{
						(ModLanguage)2,
						"海...佛诺..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Wraith_Summoning", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Abysso!"
					},
					{
						(ModLanguage)2,
						"海拉·阿拜索！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Wraith_Summoning", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"He...bysso..."
					},
					{
						(ModLanguage)2,
						"海...拜索..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Sign_of_Darkness", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Mosquen!"
					},
					{
						(ModLanguage)2,
						"海拉·莫斯昆！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Sign_of_Darkness", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"H...Mos..."
					},
					{
						(ModLanguage)2,
						"海...慕斯..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Summon_Servant", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"HELA·Saruto!"
					},
					{
						(ModLanguage)2,
						"海拉·萨鲁德！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Summon_Servant", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"H...ELA..."
					},
					{
						(ModLanguage)2,
						"海...鲁德..."
					}
				}
			})
		});
		Msl.InjectTableSkillsStats((SkillsStatsHook)21, "Summon_Servant", "o_summon_servant", (SkillsStatsTarget)2, "3", (ushort)24, (ushort)36, (ushort)18, (ushort)0, (byte)0, (byte)0, false, (SkillsStatsPattern)0, (SkillsStatsValidator)0, (SkillsStatsClass)1, true, (string)null, "none", false, true, (SkillsStatsMetacategory)0, (short)0, "x", false, false, false, false, true);
		UndertaleGameObject val2 = Msl.AddObject("o_skill_summon_servant", "s_skills_summon_zombie", "o_skill_necromancy", true, false, true, (CollisionShapeFlags)0);
		UndertaleGameObject val3 = Msl.AddObject("o_skill_summon_servant_ico", "s_skills_summon_zombie", "o_skill_ico", true, false, true, (CollisionShapeFlags)0);
		UndertaleGameObject val4 = Msl.AddObject("o_summon_servant", "s_wraithsummon_cast", "o_spellbirth", true, false, true, (CollisionShapeFlags)0);
		GameObjectUtils.ApplyEvent(val3, new MslEvent[1]
		{
			new MslEvent("\n        event_inherited()\n        child_skill = o_skill_summon_servant\n        event_perform_object(child_skill, ev_create, 0)\n    ", (EventType)0, 0u)
		});
		GameObjectUtils.ApplyEvent(val2, new MslEvent[1]
		{
			new MslEvent("\n        event_inherited()\n        skill = \"Summon_Servant\"\n        scr_skill_atr()\n        can_learn = true\n        ignore_interact = true\n        ds_list_add(attribute, ds_map_find_value(global.attribute, \"Magic_Power\"), ds_map_find_value(global.attribute, \"Bonus_Range\"))\n    ", (EventType)0, 0u)
		});
		GameObjectUtils.ApplyEvent(val2, new MslEvent[1]
		{
			new MslEvent(base.ModFiles.GetCode("o_skill_summon_servant_Other_17.gml"), (EventType)7, 17u)
		});
		GameObjectUtils.ApplyEvent(val4, new MslEvent[2]
		{
			new MslEvent("\n        event_inherited()\n        alpha = 0\n        lumalpha = 0\n        image_speed = 1\n        cast_frame = 6\n        is_flying = false\n        spell = o_enemy_birth\n        scr_audio_play_at(snd_skill_wraith_summoning_cast)\n    ", (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_summon_servant_Other_10.gml"), (EventType)7, 10u)
		});
		Msl.GetObject("o_skill_darkbolt").ParentId = val;
		Msl.GetObject("o_skill_curse").ParentId = val;
		Msl.GetObject("o_skill_dark_blessing").ParentId = val;
		Msl.GetObject("o_skill_curse_of_weakness").ParentId = val;
		Msl.GetObject("o_skill_essence_leech").ParentId = val;
		Msl.GetObject("o_skill_deadly_premonition").ParentId = val;
		Msl.GetObject("o_skill_death_touch").ParentId = val;
		Msl.GetObject("o_skill_sigil_of_binding").ParentId = val;
		Msl.GetObject("o_skill_final_stand").ParentId = val;
		Msl.GetObject("o_skill_wraith_summoning").ParentId = val;
		Msl.GetObject("o_skill_sign_of_darkness").ParentId = val;
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_dark_blessing_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_curse_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_curse_of_weakness_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_life_leech_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_sickening_vapours_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_confess_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_burdened_by_sin_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_deadly_premonition_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_dark_ressurection_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_mark_of_the_feast_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_summon_blood_golem_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_essence_leech_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_wraith_summoning_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_deadly_premonition_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_sign_of_darkness_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_unholy_communion_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_come_my_fanatics_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_judgement_day_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_summon_the_worm_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_boiling_blood_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_apocalyptic_sermon_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_vampire_rune_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_darkbolt_Create_0"), "can_learn = true"), "ignore_interact = true"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_dark_blessing_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_dark_blessing_Create_0"), "can_learn = true"), "ds_list_add(attribute, ds_map_find_value(global.attribute, \"Magic_Power\"))"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_curse_of_weakness_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_sign_of_darkness_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_deadly_premonition_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_sigil_of_binding_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 13\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_essence_leech_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 13\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_death_touch_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 13\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_death_touch_Alarm_1")), base.ModFiles.GetCode("o_death_touch_Alarm_1.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_b_harvested_essence_Create_0"), "max_stage = 3"), "max_stage = 5"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_wraith_summoning_Other_10")), base.ModFiles.GetCode("o_wraith_summoning_Other_10.gml")));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_wraith_summoning_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 25\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_final_stand_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 25\ntier_to_open = global.necromancy_tier1"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_final_stand_birth_Other_10")), base.ModFiles.GetCode("o_final_stand_birth_Other_10.gml")));
		Msl.GetSprite("s_arcanistics_branch").OriginX = 0;
		Msl.GetSprite("s_arcanistics_branch").OriginY = 0;
		UndertaleGameObject val5 = Msl.AddObject("o_skill_category_necromancy", "", "o_sklill_category_magic", true, false, true, (CollisionShapeFlags)0);
		Msl.InjectTableTextTreesLocalization(new LocalizationTextTree[1]
		{
			new LocalizationTextTree("Necromancy", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Necromancy"
				},
				{
					(ModLanguage)2,
					"死灵术"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Originating in ancient Axonian magic, Necromancy was originally intended to recover knowledge from the dead across all ages and lands. Today, it has fallen into obscurity and survives only as an occult study rejected by most of Aldor society.##~y~Main focus:~/~#~w~Summoning~/~, ~w~Curses~/~, ~w~Crowd Control~/~"
				},
				{
					(ModLanguage)2,
					"起源于古亚克逊的魔法，本意是通过复生亡者获取古今中外的知识，如今已被埋没为不被奥尔多大众所认可的玄秘研究。##~y~能力要义：~/~#~w~召唤~/~、~w~诅咒~/~、~w~控场~/~"
				}
			})
		});
		GameObjectUtils.ApplyEvent(val5, new MslEvent[1]
		{
			new MslEvent("\n        event_inherited()\n        text = \"Necromancy\"\n        is_execute = false;\n        skill = [o_skill_darkbolt_ico, o_skill_curse_ico, o_skill_summon_servant_ico,\n                 o_skill_dark_blessing_ico, o_skill_curse_of_weakness_ico , o_skill_essence_leech_ico, o_skill_deadly_premonition_ico, \n                 o_skill_death_touch_ico, o_skill_sign_of_darkness_ico, o_skill_sigil_of_binding_ico, \n                 o_pass_skill_aura_of_unlife, o_skill_final_stand_ico, o_pass_skill_ghastly_revelation, o_skill_wraith_summoning_ico]\n        branch_sprite = s_arcanistics_branch\n        alarm[1] = 2\n    ", (EventType)0, 0u)
		});
		Msl.AddNewEvent(val5, base.ModFiles.GetCode("o_skill_category_necromancy_Other_24.asm"), (EventType)7, 24u, true);
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skillmenu_Create_0"), "var _metaCategoriesArray = "), "array_push(_metaCategoriesArray[1], o_skill_category_necromancy)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init"), "function scr_skill_tier_init() //gml_Script_scr_skill_tier_init\n{"), "global.necromancy_tier1 = [\"Necromancy\", o_skill_darkbolt_ico, o_skill_curse_ico, o_skill_summon_servant_ico]\n    global.necromancy_tier2 = [\"Necromancy\", o_skill_dark_blessing_ico, o_skill_curse_of_weakness_ico , o_skill_sign_of_darkness_ico, o_skill_deadly_premonition_ico]\n    global.necromancy_tier3 = [\"Necromancy\", o_skill_death_touch_ico, o_skill_sigil_of_binding_ico, o_skill_essence_leech_ico]\n    global.necromancy_tier4 = [\"Necromancy\", o_pass_skill_aura_of_unlife, o_skill_final_stand_ico, o_pass_skill_ghastly_revelation, o_skill_wraith_summoning_ico]"));
		UndertaleGameObject parentId = Msl.GetObject("o_inv_treatise");
		Msl.GetObject("o_inv_lorebook_magic").ParentId = parentId;
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_inv_lorebook_magic_Create_0"), "event_inherited()"), "skills_array = global.necromancy_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_runaway_wizzard_Create_0"), "scr_inventory_add_item(o_inv_map_osbrook)"), "scr_inventory_add_item(o_inv_lorebook_magic)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_occultist_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_necromancer_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_archivist_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_ritualist_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_armored_husk_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_desecrator_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_undertaker_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_crypt_warden_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_mortician_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_revenant_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_wraithbinder_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_magic, x, y, 100)"));
		Msl.InjectTableSkillsLocalization(new LocalizationSkill[1]
		{
			new LocalizationSkill("Come_My_Servants", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Come, My Fanatics!"
				},
				{
					(ModLanguage)2,
					"众徒，来！"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					string.Join("##", "Summons a ~w~Proselyte~/~ on the target tile and another within a ~w~4-tile~/~ radius around the caster. The type of ~w~Proselyte~/~ summoned depends on the caster's ~lg~\"Magic Power\"~/~ and ~lg~\"Level\"~/~.", "If a ~w~Proselyte~/~ summoned this way is struck by its summoner while there are no enemies nearby, it dies ~r~instantly~/~.")
				},
				{
					(ModLanguage)2,
					string.Join("##", "在身周围~w~4~/~格的范围之内和目标地点分别召唤一个~w~变节信徒~/~。~w~变节信徒~/~的类型取决于召唤者的~lg~“法力”~/~和~lg~“等级”~/~。", "当~w~变节信徒~/~在附近无敌人的情况下受到召唤者攻击会立即~r~死亡~/~。")
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Come_My_Servants", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Ye...Tro..."
					},
					{
						(ModLanguage)2,
						"伊...莫..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Come_My_Servants", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"YESO·TROPH!"
					},
					{
						(ModLanguage)2,
						"伊斯·莫伐！"
					}
				}
			})
		});
		Msl.InjectTableSkillsStats((SkillsStatsHook)24, "Come_My_Servants", "o_come_my_servants", (SkillsStatsTarget)2, "6", (ushort)50, (ushort)55, (ushort)18, (ushort)0, (byte)0, (byte)0, false, (SkillsStatsPattern)0, (SkillsStatsValidator)0, (SkillsStatsClass)1, true, (string)null, "none", false, true, (SkillsStatsMetacategory)0, (short)0, "x", false, false, false, false, true);
		UndertaleGameObject val6 = Msl.AddObject("o_skill_come_my_servants", "s_skills_come_my_fanatics", "o_skill", true, false, true, (CollisionShapeFlags)0);
		UndertaleGameObject val7 = Msl.AddObject("o_skill_come_my_servants_ico", "s_skills_come_my_fanatics", "o_skill_ico", true, false, true, (CollisionShapeFlags)0);
		UndertaleGameObject val8 = Msl.AddObject("o_come_my_servants", "s_comemyfanatics_cast", "o_spellbirth", true, false, true, (CollisionShapeFlags)0);
		GameObjectUtils.ApplyEvent(val7, new MslEvent[1]
		{
			new MslEvent("\n                event_inherited()\n                child_skill = o_skill_come_my_servants\n                event_perform_object(child_skill, ev_create, 0)\n            ", (EventType)0, 0u)
		});
		GameObjectUtils.ApplyEvent(val6, new MslEvent[1]
		{
			new MslEvent("\n                event_inherited()\nskill = \"Come_My_Servants\"\nscr_skill_atr()\ncan_learn = true\nignore_interact = true\nds_list_add(attribute, ds_map_find_value(global.attribute, \"Magic_Power\"), ds_map_find_value(global.attribute, \"Bonus_Range\"))\n            ", (EventType)0, 0u)
		});
		GameObjectUtils.ApplyEvent(val8, new MslEvent[2]
		{
			new MslEvent("event_inherited()\nalpha = 0\nlumalpha = 0\nimage_speed = 1\ncast_frame = 3\nis_flying = false\nspell = o_enemy_birth\nscr_audio_play_at(snd_comemyfanatics_cast)\nalways_visible = true", (EventType)0, 0u),
			new MslEvent(base.ModFiles.GetCode("o_come_my_servants_Other_10.gml"), (EventType)7, 10u)
		});
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_GlobalScript_scr_skill_get_priority"), "case \"Oath_of_Retribution\":\n            _points = 30\n            break"), "case \"Come_My_Servants\":\n            _points = 150\n            break"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_vampiric_blood_Other_17"), "ds_map_replace(data, \"Life_Steal\", owner.VIT)"), "ds_map_replace(data, \"Life_Steal\", owner.Vitality)"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_vampiric_blood_Other_25"), "var _life_steal = owner.VIT"), "var _life_steal = owner.Vitality"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_symphony_of_pain_Alarm_0"), "with (_target)\n            {\n                var _wound_stage = scr_wound_count()\n                var _bleed_count = scr_instance_in_list(6043, buffs, 0)\n                with (other.id)\n                    scr_skill_change_KD_enemy(\"Symphony_of_Pain\", (-((_wound_stage + _bleed_count))))\n            }\n        }\n    }\n}\nevent_inherited()"), "with (_target)\n            {\n                if (!is_player(other))\n                {\n                    var _wound_stage = scr_wound_count()\n                    var _bleed_count = scr_instance_in_list(o_db_bleed_parent, buffs, 0)\n                    with (other.id)\n                        scr_skill_change_KD_enemy(\"Symphony_of_Pain\", (-((_wound_stage + _bleed_count))))\n                }\n            }\n        }\n    }\n}\nevent_inherited()"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_scream_of_doom_Draw_0"), "if (instance_exists(target) && instance_exists(owner))"), "if (instance_exists(target) && instance_exists(owner) && (!is_player(owner)))"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_twisted_words_Other_16")), base.ModFiles.GetCode("o_enemy_pass_twisted_words_Other_16.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_twisted_words_Other_13")), base.ModFiles.GetCode("o_enemy_pass_twisted_words_Other_13.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_summon_thrall_birth_Other_10")), base.ModFiles.GetCode("o_summon_thrall_birth_Other_10.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_summon_blood_golem_bith_Other_10")), base.ModFiles.GetCode("o_summon_blood_golem_bith_Other_10.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_summon_spitter_leech_birth_Other_10")), base.ModFiles.GetCode("o_summon_spitter_leech_birth_Other_10.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_summon_the_worm_birth_Other_10")), base.ModFiles.GetCode("o_summon_the_worm_birth_Other_10.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_heart_of_darkness_Other_13")), base.ModFiles.GetCode("o_enemy_pass_heart_of_darkness_Other_13.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_summon_bloodgorger_worm_birth_Other_10")), base.ModFiles.GetCode("o_summon_bloodgorger_worm_birth_Other_10.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_destructive_force_Alarm_0"), "with (owner)\n    {\n        is_cast_spell = true\n        scr_skill_set_animation(s_proselyte_Juggernaut_force_start, \"ForceStart\", 1, 0)\n        scr_audio_play_at(snd_skill_destructive_force_startcast)\n    }"), "if (!is_player(owner))\n    {\n        with (owner)\n        {\n            is_cast_spell = true;\n            scr_skill_set_animation(s_proselyte_Juggernaut_force_start, \"ForceStart\", 1, 0);\n            scr_audio_play_at(snd_skill_destructive_force_startcast);\n        }\n    }\n    else \n    {\n        with (owner)\n        {\n            is_cast_spell = true;\n            scr_audio_play_at(snd_skill_destructive_force_startcast);\n        }\n    }"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_destructive_force_mark_Other_10"), "with (owner)\n{\n    if (animation_state != \"ForceEnd\")\n    {\n        with (scr_skill_set_animation(s_proselyte_Juggernaut_force_end, \"ForceEnd\", 0, 0))\n            scr_set_lt()\n        scr_audio_play_at(snd_skill_destructive_force_cast)\n    }\n    else\n        instance_destroy(other.id)\n}"), "if (!is_player(owner))\n{\n    with (owner)\n    {\n        if (animation_state != \"ForceEnd\")\n        {\n            with (scr_skill_set_animation(s_proselyte_Juggernaut_force_end, \"ForceEnd\", 0, 0))\n                scr_set_lt();\n            \n            scr_audio_play_at(snd_skill_destructive_force_cast);\n        }\n        else\n        {\n            instance_destroy(other.id);\n        }\n    }\n}\nelse\n{\n    with (owner)\n    {\n        if (animation_state != \"ForceEnd\")\n            scr_audio_play_at(snd_skill_destructive_force_cast);\n    }\n}"));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_unholy_communion_Alarm_0")), base.ModFiles.GetCode("o_unholy_communion_Alarm_0.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_blood_scent_Other_16")), base.ModFiles.GetCode("o_enemy_pass_blood_scent_Other_16.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_driven_by_pain_Other_16")), base.ModFiles.GetCode("o_enemy_pass_driven_by_pain_Other_16.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_revel_in_suffering_Other_15")), base.ModFiles.GetCode("o_enemy_pass_revel_in_suffering_Other_15.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_witness_his_might_Other_15")), base.ModFiles.GetCode("o_enemy_pass_witness_his_might_Other_15.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_witness_his_might_Other_16")), base.ModFiles.GetCode("o_enemy_pass_witness_his_might_Other_16.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_feed_my_brethren_Other_15")), base.ModFiles.GetCode("o_enemy_pass_feed_my_brethren_Other_15.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_rip_and_tear_Other_20")), base.ModFiles.GetCode("o_enemy_pass_rip_and_tear_Other_20.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_anthem_of_bloodshed_Other_15")), base.ModFiles.GetCode("o_enemy_pass_anthem_of_bloodshed_Other_15.gml")));
		Msl.Save(Msl.ReplaceBy(Msl.MatchAll(Msl.LoadGML("gml_Object_o_enemy_pass_anthem_of_bloodshed_Other_20")), base.ModFiles.GetCode("o_enemy_pass_anthem_of_bloodshed_Other_20.gml")));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_vampire_rune_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_mark_of_the_feast_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_summon_blood_golem_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_scream_of_doom_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 15\nlevel_to_open = 7\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_apocalyptic_sermon_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 16\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_twisted_words_Create_0"), "scr_skill_atr(\"twisted_words\")"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 16\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_summon_thrall_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 16\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_summon_the_worm_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 16\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_unholy_communion_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_spitter_leech_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_insatiable_hunger_Create_0"), "scr_skill_atr(\"insatiable_hunger\")"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_summon_the_bloodgorger_worm_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"Vitality\", \"WIL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_magic_tier1"));
		Msl.GetSprite("s_electro_branch").OriginX = 0;
		Msl.GetSprite("s_electro_branch").OriginY = 0;
		UndertaleGameObject val9 = Msl.AddObject("o_skill_category_proselyte_magic", "", "o_sklill_category_magic", true, false, true, (CollisionShapeFlags)0);
		Msl.InjectTableTextTreesLocalization(new LocalizationTextTree[1]
		{
			new LocalizationTextTree("Proselyte Magic", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Proselyte: Sloth"
				},
				{
					(ModLanguage)2,
					"变节信仰 怠惰"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"No one knows how the magical system of the Proselytes first arose or developed. The only thing the people of Aldor know for certain is that this kind of magic has always been bound to blood, fanaticism, and evil.##~y~Main focus:~/~#~w~Summoning~/~, ~w~Curses~/~, ~w~Crowd Control~/~"
				},
				{
					(ModLanguage)2,
					"无人知晓变节信徒的魔法体系是如何起源与发展的，奥尔多的人们唯一能得知的是这类魔法永远与鲜血、狂热以及邪恶脱不了干系。##~y~能力要义：~/~#~w~召唤~/~、~w~诅咒~/~、~w~控场~/~"
				}
			})
		});
		GameObjectUtils.ApplyEvent(val9, new MslEvent[1]
		{
			new MslEvent("\n        event_inherited()\n        text = \"Proselyte Magic\"\n        is_execute = false;\n        skill = [o_skill_life_leech_ico, o_skill_come_my_servants_ico, o_skill_vampire_rune_ico,\n                 o_skill_mark_of_the_feast_ico, o_skill_summon_blood_golem_ico, o_skill_scream_of_doom_ico, o_skill_apocalyptic_sermon_ico, \n                 o_enemy_pass_twisted_words, o_skill_summon_thrall_ico, o_skill_summon_the_worm_ico, \n                 o_skill_unholy_communion_ico, o_skill_spitter_leech_ico, o_enemy_pass_insatiable_hunger, o_skill_summon_the_bloodgorger_worm_ico]\n        branch_sprite = s_electro_branch\n        alarm[1] = 2\n    ", (EventType)0, 0u)
		});
		Msl.AddNewEvent(val9, base.ModFiles.GetCode("o_skill_category_proselyte_magic_Other_24.asm"), (EventType)7, 24u, true);
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skillmenu_Create_0"), "var _metaCategoriesArray = "), "array_push(_metaCategoriesArray[1], o_skill_category_proselyte_magic)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init"), "function scr_skill_tier_init() //gml_Script_scr_skill_tier_init\n{"), "global.proselyte_magic_tier1 = [\"Proselyte Magic\", o_skill_life_leech_ico, o_skill_come_my_servants_ico]\n    global.proselyte_magic_tier2 = [\"Proselyte Magic\", o_skill_vampire_rune_ico,\n                 o_skill_mark_of_the_feast_ico, o_skill_summon_blood_golem_ico, o_skill_scream_of_doom_ico]\n    global.proselyte_magic_tier3 = [\"Proselyte Magic\", o_skill_apocalyptic_sermon_ico, \n                 o_enemy_pass_twisted_words, o_skill_summon_thrall_ico, o_skill_summon_the_worm_ico]\n    global.proselyte_magic_tier4 = [\"Proselyte Magic\", o_skill_unholy_communion_ico, o_skill_spitter_leech_ico, o_enemy_pass_insatiable_hunger, o_skill_summon_the_bloodgorger_worm_ico]"));
		Msl.GetObject("o_inv_lorebook_beauty").ParentId = parentId;
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_inv_lorebook_beauty_Create_0"), "event_inherited()"), "skills_array = global.proselyte_magic_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_runaway_wizzard_Create_0"), "scr_inventory_add_item(o_inv_map_osbrook)"), "scr_inventory_add_item(o_inv_lorebook_beauty)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_revel_in_suffering_Create_0"), "scr_skill_atr(\"revel_in_suffering\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 17\nlevel_to_open = 15\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_vengeful_whiplash_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 17\nlevel_to_open = 15\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_symphony_of_pain_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 17\nlevel_to_open = 15\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_blood_craze_Create_0"), "scr_skill_atr(\"blood_craze\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 17\nlevel_to_open = 15\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_witness_his_might_Create_0"), "scr_skill_atr(\"witness_his_might\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 21\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_judgement_day_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 21\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_feed_my_brethren_Create_0"), "scr_skill_atr(\"feed_my_brethren\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 20\nlevel_to_open = 21\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_rip_and_tear_Create_0"), "scr_skill_atr(\"rip_and_tear\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_cull_the_weak_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_ripper_claws_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"PRC\"]\nattributes_value_to_open = 25\nlevel_to_open = 23\ntier_to_open = global.proselyte_combat_tier1"));
		Msl.GetSprite("s_pyro_branch").OriginX = 0;
		Msl.GetSprite("s_pyro_branch").OriginY = 0;
		UndertaleGameObject val10 = Msl.AddObject("o_skill_category_proselyte_combat", "", "o_skill_category_utility", true, false, true, (CollisionShapeFlags)0);
		Msl.InjectTableTextTreesLocalization(new LocalizationTextTree[1]
		{
			new LocalizationTextTree("Proselyte Combat", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Proselyte: Gluttony"
				},
				{
					(ModLanguage)2,
					"变节信仰 暴食"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"The Proselytes draw their strength from their craving for blood and wounds, as well as from an insatiable hunger. Those assimilated by these powers after joining the faith often end up enslaved by blood itself.##~y~Main focus:~/~#~w~High Damage~/~, ~w~Injury~/~, ~w~Bleeding~/~"
				},
				{
					(ModLanguage)2,
					"变节信徒的力量来源于他们对鲜血和伤口的欲望以及无穷的饥渴，入教后被这些能力同化的人往往会沦为鲜血的奴役。##~y~能力要义：~/~#~w~高伤害~/~, ~w~致伤~/~, ~w~造成出血~/~"
				}
			})
		});
		GameObjectUtils.ApplyEvent(val10, new MslEvent[1]
		{
			new MslEvent("\n        event_inherited()\n        text = \"Proselyte Combat\"\n        is_execute = false;\n        skill = [o_skill_bloodletting_ico, o_enemy_pass_blood_scent, o_enemy_pass_driven_by_pain,\n                 o_skill_vampiric_blood_ico, o_enemy_pass_revel_in_suffering, o_skill_vengeful_whiplash_ico, o_skill_symphony_of_pain_ico, \n                 o_enemy_pass_blood_craze, o_enemy_pass_witness_his_might, o_skill_judgement_day_ico, \n                 o_enemy_pass_feed_my_brethren, o_enemy_pass_rip_and_tear, o_skill_cull_the_weak_ico, o_skill_ripper_claws_ico]\n        branch_sprite = s_pyro_branch\n        alarm[1] = 2\n    ", (EventType)0, 0u)
		});
		Msl.AddNewEvent(val10, base.ModFiles.GetCode("o_skill_category_proselyte_combat_Other_24.asm"), (EventType)7, 24u, true);
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skillmenu_Create_0"), "var _metaCategoriesArray = "), "array_push(_metaCategoriesArray[1], o_skill_category_proselyte_combat)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init"), "function scr_skill_tier_init() //gml_Script_scr_skill_tier_init\n{"), "global.proselyte_combat_tier1 = [\"Proselyte Combat\", o_skill_bloodletting_ico, o_enemy_pass_blood_scent, o_enemy_pass_driven_by_pain,\n                 o_skill_vampiric_blood_ico]\n    global.proselyte_combat_tier2 = [\"Proselyte Combat\", o_enemy_pass_revel_in_suffering, o_skill_vengeful_whiplash_ico, o_skill_symphony_of_pain_ico, \n                 o_enemy_pass_blood_craze]\n    global.proselyte_combat_tier3 = [\"Proselyte Combat\", o_enemy_pass_witness_his_might, o_skill_judgement_day_ico, \n                 o_enemy_pass_feed_my_brethren]\n    global.proselyte_combat_tier4 = [\"Proselyte Combat\", o_enemy_pass_rip_and_tear, o_skill_cull_the_weak_ico, o_skill_ripper_claws_ico]"));
		Msl.GetObject("o_inv_lorebook_eidolons").ParentId = parentId;
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_inv_lorebook_eidolons_Create_0"), "event_inherited()"), "skills_array = global.proselyte_combat_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_runaway_wizzard_Create_0"), "scr_inventory_add_item(o_inv_map_osbrook)"), "scr_inventory_add_item(o_inv_lorebook_eidolons)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_oath_of_retribution_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"Vitality\"]\nattributes_value_to_open = 24\nlevel_to_open = 22\ntier_to_open = global.proselyte_gift_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_cindertrail_Create_0"), "scr_skill_atr(\"cindertrail\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"Vitality\"]\nattributes_value_to_open = 16\nlevel_to_open = 16\ntier_to_open = global.proselyte_gift_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_murk_strike_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"Vitality\"]\nattributes_value_to_open = 20\nlevel_to_open = 21\ntier_to_open = global.proselyte_gift_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_enemy_pass_heart_of_darkness_Create_0"), "scr_skill_atr(\"heart_of_darkness\")"), "attributes_names_to_open = [\"STR\", \"AGL\", \"Vitality\"]\nattributes_value_to_open = 28\nlevel_to_open = 25\ntier_to_open = global.proselyte_gift_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skill_destructive_force_ico_Create_0"), "event_perform_object(child_skill, ev_create, 0)"), "attributes_names_to_open = [\"STR\", \"AGL\", \"Vitality\"]\nattributes_value_to_open = 28\nlevel_to_open = 24\ntier_to_open = global.proselyte_gift_tier1"));
		Msl.GetSprite("s_armor_branch").OriginX = 0;
		Msl.GetSprite("s_armor_branch").OriginY = 0;
		UndertaleGameObject val11 = Msl.AddObject("o_skill_category_proselyte_gift", "", "o_skill_category_utility", true, false, true, (CollisionShapeFlags)0);
		Msl.InjectTableTextTreesLocalization(new LocalizationTextTree[1]
		{
			new LocalizationTextTree("Proselyte Gift", new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"Proselyte: Gift"
				},
				{
					(ModLanguage)2,
					"变节信仰 恩赐"
				}
			}, new Dictionary<ModLanguage, string>
			{
				{
					(ModLanguage)1,
					"The Proselytes most favored by the Court are granted the privilege of taking part in the Rite of Ascension. Though forever disfigured after receiving the Crimson Gift, they gain many powers such as monstrous strength and living flame. Unlike the Proselytes who willingly surrender themselves to such power, onlookers ought to ask whether the Court's favor truly comes without a price.##~y~Main focus:~/~#~w~Ascension~/~, ~w~Faith~/~, ~w~Corruption~/~"
				},
				{
					(ModLanguage)2,
					"最受圣宫宠爱的变节信徒将有幸参加飞升仪式，接受绯红恩赐后的变节信徒虽然面目全非但会获得诸如怪力、焚火等各种能力。不同于沉沦于力量的信徒自身，旁观者应该思考圣宫的宠爱是否是毫无代价的。##~y~能力要义：~/~#~w~飞升~/~, ~w~信仰~/~, ~w~堕落~/~"
				}
			})
		});
		GameObjectUtils.ApplyEvent(val11, new MslEvent[1]
		{
			new MslEvent("\n        event_inherited()\n        text = \"Proselyte Gift\"\n        is_execute = false;\n        skill = [o_enemy_pass_anthem_of_bloodshed, o_skill_brand_of_anguish_ico, o_skill_embrace_the_murk_ico,\n                 o_skill_oath_of_retribution_ico, o_enemy_pass_cindertrail, o_skill_murk_strike_ico, o_enemy_pass_heart_of_darkness, \n                 o_skill_destructive_force_ico]\n        branch_sprite = s_armor_branch\n        alarm[1] = 2\n    ", (EventType)0, 0u)
		});
		Msl.AddNewEvent(val11, base.ModFiles.GetCode("o_skill_category_proselyte_gift_Other_24.asm"), (EventType)7, 24u, true);
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_skillmenu_Create_0"), "var _metaCategoriesArray = "), "array_push(_metaCategoriesArray[1], o_skill_category_proselyte_gift)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init"), "function scr_skill_tier_init() //gml_Script_scr_skill_tier_init\n{"), "global.proselyte_gift_tier1 = [\"Proselyte Gift\", o_enemy_pass_anthem_of_bloodshed, o_skill_brand_of_anguish_ico, o_skill_embrace_the_murk_ico]\n    global.proselyte_gift_tier2 = [\"Proselyte Gift\", o_skill_oath_of_retribution_ico, o_enemy_pass_cindertrail, o_skill_murk_strike_ico]\n    global.proselyte_gift_tier3 = [\"Proselyte Gift\", o_enemy_pass_heart_of_darkness, \n                 o_skill_destructive_force_ico]"));
		Msl.GetObject("o_inv_lorebook_hieron").ParentId = parentId;
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_inv_lorebook_hieron_Create_0"), "event_inherited()"), "skills_array = global.proselyte_gift_tier1"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_runaway_wizzard_Create_0"), "scr_inventory_add_item(o_inv_map_osbrook)"), "scr_inventory_add_item(o_inv_lorebook_hieron)"));
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Embrace_the_Murk", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Velum·Noctis·Morvha!"
					},
					{
						(ModLanguage)2,
						"萨古·艾扎·恩斯法！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Embrace_the_Murk", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Vel...Mor..."
					},
					{
						(ModLanguage)2,
						"萨...恩斯..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Summon_Thrall", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Morvath·Khal·Vorun!"
					},
					{
						(ModLanguage)2,
						"因扎·莫古·库佛！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Summon_Thrall", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Mor...Vor..."
					},
					{
						(ModLanguage)2,
						"因...库..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Apocalyptic_Sermon", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Vesper·Cinis·Aetern!"
					},
					{
						(ModLanguage)2,
						"萨恩·西索·恩乌！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Apocalyptic_Sermon", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Ves...Aet..."
					},
					{
						(ModLanguage)2,
						"萨...恩呜..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Unholy_Communion", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Profan·Sanguis·Nexum!"
					},
					{
						(ModLanguage)2,
						"古索·布达·艾伐！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Unholy_Communion", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Pro...Nex..."
					},
					{
						(ModLanguage)2,
						"古...艾..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Spitter_Leech", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Ulkar·Vesk·Skarath!"
					},
					{
						(ModLanguage)2,
						"乌拉·昆西·斯卡纳！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Spitter_Leech", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Ul...Skar..."
					},
					{
						(ModLanguage)2,
						"乌...斯卡..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Summon_the_Bloodgorger_Worm", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Vermis·Sanguis·Vorax!"
					},
					{
						(ModLanguage)2,
						"伊斯·库诺·斯坎迪！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Summon_the_Bloodgorger_Worm", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Ver...Vor..."
					},
					{
						(ModLanguage)2,
						"伊...斯..."
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Oath_of_Retribution", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Praise the majesty of the Court!"
					},
					{
						(ModLanguage)2,
						"赞颂圣宫的威仪！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Oath_of_Retribution", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"Praise...the Court!"
					},
					{
						(ModLanguage)2,
						"赞颂..圣宫！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("Judgement_Day", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"The Great Court, grant me ascension!"
					},
					{
						(ModLanguage)2,
						"圣宫，赐我飞升！"
					}
				}
			})
		});
		Msl.InjectTableSpeechesLocalization(new LocalizationSpeech[1]
		{
			new LocalizationSpeech("MC_Judgement_Day", new Dictionary<ModLanguage, string>[1]
			{
				new Dictionary<ModLanguage, string>
				{
					{
						(ModLanguage)1,
						"At last...ascension!"
					},
					{
						(ModLanguage)2,
						"终将..晋升！"
					}
				}
			})
		});
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_apostate_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_abomination_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_matriarch_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_seer_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_admonisher_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_brander_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_juggernaut_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)\n    scr_loot(o_loot_lorebook_hieron, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_anmarrak_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)\n    scr_loot(o_loot_lorebook_hieron, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_leechlord_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)\n    scr_loot(o_loot_lorebook_hieron, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_apostle_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)\n    scr_loot(o_loot_lorebook_hieron, x, y, 100)"));
		Msl.Save(Msl.InsertBelow(Msl.MatchFrom(Msl.LoadGML("gml_Object_o_proselyte_nakkatar_Create_0"), "loot_script = function()\n{"), "scr_loot(o_loot_lorebook_eidolons, x, y, 100)\nscr_loot(o_loot_lorebook_beauty, x, y, 100)\n    scr_loot(o_loot_lorebook_hieron, x, y, 100)"));
	}
}
