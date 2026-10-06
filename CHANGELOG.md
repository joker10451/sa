# Stars New Skills All-in-One — Update for Stoneshard 0.9.4.24

This is a community fix/update of **Stars New Skills All-in-One** (originally by 富川喜子 / YjyzZ), bringing it up to date with Stoneshard **0.9.4.24** and adding a few quality-of-life improvements to the Necromancy skill tree. Should be used alongside **Stars Enemy Enhancing** as originally intended.

## 🛠️ Compatibility fixes (0.9.4.20 → 0.9.4.24)

- Fixed compile-time errors caused by the game update shifting internal object indices (`o_rockeater_soldier`, `o_rockeater_hunter`, `o_rockeater_worker`) used by `o_summon_the_hive`.
- Fixed a broken reference in `o_manticore_Create_0` (`have_pow` variable renamed/removed by the vanilla update) that prevented the mod from patching correctly.

## 🧟 "Smart Follow" behavior (already part of a previous update)

- Necromancy/Proselyte servants no longer die simply for wandering too far from the player.
- Servants now **automatically follow** the player when no enemies are nearby.
- Servants **automatically engage** enemies when detected, instead of just following passively.

## 🩸 Aura of Unlife & Final Stand — crash fix

These two skills used to summon a broken "generic" undead object that was missing its base stats, causing a **guaranteed crash** a few turns after casting (`Variable <unknown_object>.bSTR / Magic_Power not set before reading it`). This has been fixed:

- Both skills now properly initialize the summoned creature's stats.
- Fixed a related bug where the summoned undead's `owner` was set to the corpse used to raise it rather than to the caster — if that corpse got cleaned up (e.g. after a room/floor change), the servant's stats calculation would crash on the following turn. `owner` is now correctly set to the player.
- Removed overly restrictive conditions that prevented most corpses from being eligible for resurrection (previously only your own already-undead fallen servants could be revived; now any eligible nearby corpse — human, undead, etc. — can be raised, matching the skill's original intended behavior).

## ⚔️ New: Magic Power / Level scaling for Aura of Unlife & Final Stand

Previously, both skills always raised the exact same weak zombie regardless of your character's power. They now scale with your **Level** and **Magic Power**, picking a random creature from an appropriate tier — the same tiering logic used by Hela's Edict:

| Tier | Requirement | Example creatures |
|---|---|---|
| 0 | (base) | Zombies |
| 1 | Level > 5 and Magic Power ≥ 140% | Skeleton swordsman/axeman/spearman, zombie guards |
| 2 | Level > 10 and Magic Power ≥ 180% | Skeleton footman/guard, ghasts |
| 3 | Level > 15 and Magic Power ≥ 220% | Skeleton soldier/warrior, accursed ghasts |
| 4 | Level > 20 and Magic Power ≥ 260% | Skeleton knights/guardians, elder ghasts, crypt wardens, restless heroes, revenants |

## ⚠️ Known limitations (not fixed yet)

- Necromancy/Proselyte servants still do **not** travel with the player through room/floor transitions (they stay behind). This is a much deeper architectural issue we're still investigating.
- Skeleton archers/rangers (`o_skeleton_bowman_servant`, `o_skeleton_crossbowman_servant`, `o_skeleton_ranger_servant`) and the "ghost" servant family exist in the game files but aren't currently included in the Aura of Unlife / Final Stand tier lists — could be added in a future update.

## Credits

Original mod by 富川喜子 (YjyzZ). This update was put together with a lot of trial, error, and help from Claude (Anthropic) to dig through the compiled game code and figure out exactly what the update had broken.
