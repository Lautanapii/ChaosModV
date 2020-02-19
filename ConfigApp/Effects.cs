﻿using System.Collections.Generic;

namespace ConfigApp
{
    public static class Effects
    {
        public struct EffectInfo
        {
            public EffectInfo(string name, EffectCategory effectCategory, string id, bool isTimed = false, bool isShort = false)
            {
                Name = name;
                EffectCategory = effectCategory;
                Id = id;
                IsTimed = isTimed;
                IsShort = isShort;
            }

            public readonly string Name;
            public readonly EffectCategory EffectCategory;
            public readonly string Id;
            public readonly bool IsTimed;
            public readonly bool IsShort;
        }

        public enum EffectCategory
        {
            PLAYER,
            VEHICLE,
            PEDS,
            TIME,
            WEATHER,
            MISC
        }

        public enum EffectTimedType
        {
            TIMED_NORMAL,
            TIMED_SHORT
        }

        public enum EffectType
        {
            EFFECT_PLAYER_SUICIDE,
            EFFECT_PLUS_2_STARS,
            EFFECT_5_STARS,
            EFFECT_CLEAR_STARS,
            EFFECT_NEVER_WANTED,
            EFFECT_STRIP_WEAPONS,
            EFFECT_GIVE_RPG,
            EFFECT_GIVE_MINIGUN,
            EFFECT_GIVE_PARACHUTE,
            EFFECT_GIVE_PISTOL,
            EFFECT_GIVE_TAZER,
            EFFECT_GIVE_RAILGUN,
            EFFECT_GIVE_KNIFE,
            EFFECT_GIVE_BATTLEAXE,
            EFFECT_HEAL,
            EFFECT_ARMOR,
            EFFECT_IGNITE,
            EFFECT_ANGRY_JESUS,
            EFFECT_SPAWN_IMPOTENTRAGE,
            EFFECT_ANGRY_JESUS2,
            EFFECT_IGNITE_PEDS,
            EFFECT_EXPLODE_VEHS,
            EFFECT_PLAYER_LAUNCH,
            EFFECT_PLAYER_VEH_LAUNCH,
            EFFECT_VEHS_LAUNCH,
            EFFECT_PLAYER_VEH_LOCK,
            EFFECT_NOTHING,
            EFFECT_KILL_ENGINE,
            EFFECT_TIME_MORNING,
            EFFECT_TIME_DAY,
            EFFECT_TIME_EVENING,
            EFFECT_TIME_NIGHT,
            EFFECT_WEATHER_SUNNY,
            EFFECT_WEATHER_EXTRASUNNY,
            EFFECT_WEATHER_RAINY,
            EFFECT_WEATHER_THUNDER,
            EFFECT_WEATHER_FOGGY,
            EFFECT_WEATHER_NEUTRAL,
            EFFECT_WEATHER_XMAS,
            EFFECT_TP_LSAIRPORT,
            EFFECT_TP_MAZETOWER,
            EFFECT_TP_FORTZANCUDO,
            EFFECT_TP_MOUNTCHILLIAD,
            EFFECT_TP_SKYFALL,
            EFFECT_NO_PHONE,
            EFFECT_SET_INTO_CLOSEST_VEH,
            EFFECT_EXIT_CURRENT_VEH,
            EFFECT_GAMESPEED_X05,
            EFFECT_GAMESPEED_X02,
            EFFECT_GAMESPEED_LAG,
            EFFECT_PEDS_RIOT,
            EFFECT_RED_VEHS,
            EFFECT_BLUE_VEHS,
            EFFECT_GREEN_VEHS,
            EFFECT_BLACK_VEHS,
            EFFECT_CHROME_VEHS,
            EFFECT_PINK_VEHS,
            EFFECT_RAINBOW_VEHS,
            EFFECT_FORCED_FP,
            EFFECT_SLIPPERY_VEHS,
            EFFECT_NO_GRAV_VEHS,
            EFFECT_PLAYER_INVINCIBLE,
            EFFECT_2XENGINE_VEHS,
            EFFECT_10XENGINE_VEHS,
            EFFECT_05XENGINE_VEHS,
            EFFECT_SPAWN_TANK,
            EFFECT_SPAWN_ADDER,
            EFFECT_SPAWN_DUMP,
            EFFECT_SPAWN_MONSTER,
            EFFECT_SPAWN_BMX,
            EFFECT_SPAWN_TUG,
            EFFECT_SPAWN_CARGO,
            EFFECT_SPAWN_BUS,
            EFFECT_SPAWN_BLIMP,
            EFFECT_SPAWN_BUZZARD,
            EFFECT_SPAWN_FAGGIO,
            EFFECT_SPAWN_RUINER3,
            EFFECT_SPAWN_RANDOM,
            EFFECT_NO_VEHS,
            EFFECT_NO_PEDS,
            EFFECT_EXPLODE_CUR_VEH,
            EFFECT_PEDS_INVISIBLE,
            EFFECT_VEHS_INVISIBLE,
            EFFECT_NO_RADAR,
            EFFECT_NO_HUD,
            EFFECT_SUPER_RUN,
            EFFECT_SUPER_JUMP,
            EFFECT_PLAYER_RAGDOLL,
            EFFECT_PEDS_RAGDOLL_ON_TOUCH,
            EFFECT_PLUS_100K,
            EFFECT_MINUS_100K,
            EFFECT_PEDS_FOLLOW_PLAYER,
            EFFECT_PLAYER_DRUNK,
            EFFECT_PEDS_OHKO,
            EFFECT_PEDS_NO_FEAR,
            EFFECT_SCREEN_BLOOM,
            EFFECT_SCREEN_LSD,
            EFFECT_SCREEN_REALLSD,
            EFFECT_SCREEN_CHOPVISION,
            EFFECT_SCREEN_RENDERDIST,
            EFFECT_SCREEN_FOG,
            EFFECT_SCREEN_BRIGHT,
            EFFECT_SCREEN_MEXICO,
            EFFECT_PEDS_IGNORE_PLAYER,
            EFFECT_HONK_BOOSTING,
            EFFECT_MIN_DAMAGE,
            EFFECT_NO_HEADSHOTS,
            EFFECT_PEDS_FROZEN,
            EFFECT_LOW_GRAV,
            EFFECT_VERY_LOW_GRAV,
            EFFECT_INSANE_GRAV,
            EFFECT_VEH_REPAIR,
            EFFECT_VEH_POP_TIRES,
            EFFECT_ALL_VEH_POP_TIRES,
            EFFECT_NO_SPECIAL_ABILITY,
            EFFECT_IN_THE_HOOD,
            EFFECT_FORCED_CINEMATIC,
            EFFECT_PEDS_FLEE,
            EFFECT_BREAK_VEH_DOORS,
            EFFECT_ZOMBIES,
            EFFECT_METEOR_RAIN,
            EFFECT_BLIND,
            EFFECT_BLACKOUT,
            EFFECT_QUICK_TIME,
            EFFECT_PAUSE_TIME,
            EFFECT_MOV_NO_UD,
            EFFECT_MOV_NO_LR,
            EFFECT_BREAK,
            EFFECT_EVERYONE_RPG,
            EFFECT_EVERYONE_TAZER,
            EFFECT_EVERYONE_MINIGUN,
            EFFECT_EVERYONE_UPNATOMIZER,
            EFFECT_EVERYONE_RANDOMWEP,
            EFFECT_NO_SPRINT,
            EFFECT_NO_JUMP,
            EFFECT_EVERYONE_INVINCIBLE,
            EFFECT_VEHS_INVINCIBLE,
            EFFECT_PLAYER_SHOT_RAGDOLL,
            EFFECT_JUMPY_VEHS,
            EFFECT_LOCK_VEHS,
            EFFECT_TOTAL_CHAOS,
            EFFECT_NO_RAGDOLL,
            EFFECT_VEHS_HORN,
            EFFECT_TP_WAYPOINT,
            EFFECT_PEDS_SAY_HI,
            EFFECT_PEDS_INSULT,
            EFFECT_EXPLOSIVE_BULLETS,
            EFFECT_EXPLOSIVE_PUNCH,
            EFFECT_GIVE_ALL_WEPS,
            EFFECT_PEDS_AIMBOT,
            EFFECT_PEDS_BLIND,
            EFFECT_SPAWN_COMPANION_CHOP,
            EFFECT_SPAWN_COMPANION_CHIMP,
            EFFECT_SPAWN_COMPANION_BRAD,
            EFFECT_PLAYER_NIGHTVISION,
            EFFECT_PLAYER_HEATVISION,
            EFFECT_PLAYER_MONEYDROPS,
            EFFECT_VEH_MAXENGINE,
            EFFECT_VEH_NITRO,
            EFFECT_VEH_MAXARMOR,
            EFFECT_VEH_BULLETPROOFTIRES,
            EFFECT_VEH_RAINBOWHEADLIGHTS,
            EFFECT_VEH_TPRANDOMPEDS,
            EFFECT_PEDS_REVIVE,
            EFFECT_SNOW,
            EFFECT_WHALE_RAIN,
            EFFECT_VEH_MAX_UPGRADES,
            EFFECT_VEH_RANDOM_UPGRADES,
            EFFECT_INTENSE_MUSIC,
            EFFECT_PEDS_DRIVEBY,
            EFFECT_PLAYER_RANDOMCLOTHES,
            EFFECT_PEDS_RAINBOWWEPS,
            EFFECT_GTAO_TRAFFIC,
            EFFECT_SPAWN_IE_SULTAN,
            EFFECT_PLAYER_SETINTORANDVEH,
            EFFECT_VEHS_FULLACCEL,
            EFFECT_SPAWN_UFO,
            EFFECT_EXPLOSIVE_PEDS,
            EFFECT_PEDS_ONEPUNCH,
            EFFECT_INVERTVELOCITY,
            EFFECT_PLAYER_TPEVERYTHING,
            EFFECT_WEATHER_RANDOMWEATHER,
            EFFECT_LOW_POLY,
            EFFECT_NEARBY_PEDS_OBLITERATE,
            EFFECT_VEHS_TRIGGER_ALARM,
            _EFFECT_ENUM_MAX
        }

        public static readonly Dictionary<EffectType, EffectInfo> EffectsMap = new Dictionary<EffectType, EffectInfo>()
        {
            {EffectType.EFFECT_PLAYER_SUICIDE, new EffectInfo("Suicide", EffectCategory.PLAYER, "player_suicide")},
	        {EffectType.EFFECT_PLUS_2_STARS, new EffectInfo("+2 Wanted Stars", EffectCategory.PLAYER, "player_plus2stars")},
	        {EffectType.EFFECT_5_STARS, new EffectInfo("5 Wanted Stars", EffectCategory.PLAYER, "player_5stars")},
	        {EffectType.EFFECT_CLEAR_STARS, new EffectInfo("Clear Wanted Level", EffectCategory.PLAYER, "player_clearwanted")},
            {EffectType.EFFECT_NEVER_WANTED, new EffectInfo("Never Wanted", EffectCategory.PLAYER, "player_neverwanted", true)},
            {EffectType.EFFECT_STRIP_WEAPONS, new EffectInfo("Remove Weapons From Everyone", EffectCategory.PEDS, "peds_remweps")},
	        {EffectType.EFFECT_GIVE_RPG, new EffectInfo("Give RPG", EffectCategory.PLAYER, "player_giverpg")},
	        {EffectType.EFFECT_GIVE_MINIGUN, new EffectInfo("Give Minigun", EffectCategory.PLAYER, "player_giveminigun")},
	        {EffectType.EFFECT_GIVE_PARACHUTE, new EffectInfo("Give Parachute", EffectCategory.PLAYER, "player_giveparachute")},
	        {EffectType.EFFECT_GIVE_PISTOL, new EffectInfo("Give Pistol", EffectCategory.PLAYER, "player_givepistol")},
	        {EffectType.EFFECT_GIVE_TAZER, new EffectInfo("Give Stungun", EffectCategory.PLAYER, "player_givestungun")},
	        {EffectType.EFFECT_GIVE_RAILGUN, new EffectInfo("Give Railgun", EffectCategory.PLAYER, "player_giverailgun")},
            {EffectType.EFFECT_GIVE_KNIFE, new EffectInfo("Give Knife", EffectCategory.PLAYER, "player_giveknife")},
            {EffectType.EFFECT_GIVE_BATTLEAXE, new EffectInfo("Give Battleaxe", EffectCategory.PLAYER, "player_givebattleaxe")},
            {EffectType.EFFECT_HEAL, new EffectInfo("Heal Player", EffectCategory.PLAYER, "player_heal")},
	        {EffectType.EFFECT_ARMOR, new EffectInfo("Give Armor", EffectCategory.PLAYER, "player_armor")},
	        {EffectType.EFFECT_IGNITE, new EffectInfo("Ignite Player", EffectCategory.PLAYER, "player_ignite")},
	        {EffectType.EFFECT_ANGRY_JESUS, new EffectInfo("Spawn Griefer Jesus", EffectCategory.MISC, "spawn_grieferjesus")},
            {EffectType.EFFECT_SPAWN_IMPOTENTRAGE, new EffectInfo("Spawn Impotent Rage", EffectCategory.PEDS, "peds_spawnimrage")},
            {EffectType.EFFECT_ANGRY_JESUS2, new EffectInfo("Spawn Extreme Griefer Jesus", EffectCategory.PEDS, "spawn_grieferjesus2")},
            {EffectType.EFFECT_IGNITE_PEDS, new EffectInfo("Ignite All Nearby Peds", EffectCategory.PEDS, "peds_ignite")},
	        {EffectType.EFFECT_EXPLODE_VEHS, new EffectInfo("Explode All Nearby Vehicles", EffectCategory.VEHICLE, "vehs_explode")},
	        {EffectType.EFFECT_PLAYER_LAUNCH, new EffectInfo("Launch Player Up", EffectCategory.PLAYER, "player_upupaway")},
	        {EffectType.EFFECT_PLAYER_VEH_LAUNCH, new EffectInfo("Launch Current Vehicle Up", EffectCategory.VEHICLE, "playerveh_upupaway")},
            {EffectType.EFFECT_VEHS_LAUNCH, new EffectInfo("Launch All Vehicles Up", EffectCategory.VEHICLE, "vehs_upupaway")},
            {EffectType.EFFECT_PLAYER_VEH_LOCK, new EffectInfo("Lock Vehicle Player Is In", EffectCategory.VEHICLE, "playerveh_lock")},
	        {EffectType.EFFECT_NOTHING, new EffectInfo("Nothing", EffectCategory.MISC, "nothing")},
	        {EffectType.EFFECT_KILL_ENGINE, new EffectInfo("Kill Engine Of Current Vehicle", EffectCategory.VEHICLE, "playerveh_killengine")},
	        {EffectType.EFFECT_TIME_MORNING, new EffectInfo("Set Time To Morning", EffectCategory.TIME, "time_morning")},
	        {EffectType.EFFECT_TIME_DAY, new EffectInfo("Set Time To Daytime", EffectCategory.TIME, "time_day")},
	        {EffectType.EFFECT_TIME_EVENING, new EffectInfo("Set Time To Evening", EffectCategory.TIME, "time_evening")},
	        {EffectType.EFFECT_TIME_NIGHT, new EffectInfo("Set Time To Night", EffectCategory.TIME, "time_night")},
	        {EffectType.EFFECT_WEATHER_SUNNY, new EffectInfo("Sunny Weather", EffectCategory.WEATHER, "weather_sunny")},
	        {EffectType.EFFECT_WEATHER_EXTRASUNNY, new EffectInfo("Extra Sunny Weather", EffectCategory.WEATHER, "weather_extrasunny")},
	        {EffectType.EFFECT_WEATHER_RAINY, new EffectInfo("Rainy Weather", EffectCategory.WEATHER, "weather_rainy")},
	        {EffectType.EFFECT_WEATHER_THUNDER, new EffectInfo("Stormy Weather", EffectCategory.WEATHER, "weather_stormy")},
	        {EffectType.EFFECT_WEATHER_FOGGY, new EffectInfo("Foggy Weather", EffectCategory.WEATHER, "weather_foggy")},
            {EffectType.EFFECT_WEATHER_NEUTRAL, new EffectInfo("Neutral Weather", EffectCategory.WEATHER, "weather_neutral")},
            {EffectType.EFFECT_WEATHER_XMAS, new EffectInfo("Snowy Weather", EffectCategory.WEATHER, "weather_snowy")},
	        {EffectType.EFFECT_TP_LSAIRPORT, new EffectInfo("Teleport To LS Airport", EffectCategory.PLAYER, "tp_lsairport")},
	        {EffectType.EFFECT_TP_MAZETOWER, new EffectInfo("Teleport To Top Of Maze Bank Tower", EffectCategory.PLAYER, "tp_mazebanktower")},
	        {EffectType.EFFECT_TP_FORTZANCUDO, new EffectInfo("Teleport To Fort Zancudo", EffectCategory.PLAYER, "tp_fortzancudo")},
            {EffectType.EFFECT_TP_SKYFALL, new EffectInfo("Teleport To Heaven", EffectCategory.PLAYER, "tp_skyfall")},
            {EffectType.EFFECT_TP_MOUNTCHILLIAD, new EffectInfo("Teleport To Mount Chilliad", EffectCategory.PLAYER, "tp_mountchilliad")},
	        {EffectType.EFFECT_NO_PHONE, new EffectInfo("No Phone", EffectCategory.MISC, "player_nophone", true)},
	        {EffectType.EFFECT_SET_INTO_CLOSEST_VEH, new EffectInfo("Set Player Into Closest Vehicle", EffectCategory.PLAYER, "player_tpclosestveh")},
	        {EffectType.EFFECT_EXIT_CURRENT_VEH, new EffectInfo("Exit Current Vehicle", EffectCategory.PLAYER, "playerveh_exit")},
	        {EffectType.EFFECT_GAMESPEED_X02, new EffectInfo("x0.2 Gamespeed", EffectCategory.TIME, "time_x02", true)},
	        {EffectType.EFFECT_GAMESPEED_X05, new EffectInfo("x0.5 Gamespeed", EffectCategory.TIME, "time_x05", true)},
            {EffectType.EFFECT_GAMESPEED_LAG, new EffectInfo("Lag", EffectCategory.TIME, "time_lag", true)},
            {EffectType.EFFECT_PEDS_RIOT, new EffectInfo("Peds Riot", EffectCategory.PEDS, "peds_riot", true)},
	        {EffectType.EFFECT_RED_VEHS, new EffectInfo("Red Traffic", EffectCategory.VEHICLE, "vehs_red", true)},
	        {EffectType.EFFECT_BLUE_VEHS, new EffectInfo("Blue Traffic", EffectCategory.VEHICLE, "vehs_blue", true)},
	        {EffectType.EFFECT_GREEN_VEHS, new EffectInfo("Green Traffic", EffectCategory.VEHICLE, "vehs_green", true)},
            {EffectType.EFFECT_BLACK_VEHS, new EffectInfo("Black Traffic", EffectCategory.VEHICLE, "vehs_black", true)},
            {EffectType.EFFECT_CHROME_VEHS, new EffectInfo("Chrome Traffic", EffectCategory.VEHICLE, "vehs_chrome", true)},
            {EffectType.EFFECT_PINK_VEHS, new EffectInfo("Hot Traffic", EffectCategory.VEHICLE, "vehs_pink", true)},
            {EffectType.EFFECT_RAINBOW_VEHS, new EffectInfo("Rainbow Traffic", EffectCategory.VEHICLE, "vehs_rainbow", true)},
	        {EffectType.EFFECT_FORCED_FP, new EffectInfo("First Person", EffectCategory.MISC, "player_firstperson", true)},
	        {EffectType.EFFECT_SLIPPERY_VEHS, new EffectInfo("Slippery Vehicles", EffectCategory.VEHICLE, "vehs_slippery", true)},
	        {EffectType.EFFECT_NO_GRAV_VEHS, new EffectInfo("Vehicles Have No Gravity", EffectCategory.VEHICLE, "vehs_nogravity", true, true)},
	        {EffectType.EFFECT_PLAYER_INVINCIBLE, new EffectInfo("Invincibility", EffectCategory.PLAYER, "player_invincible", true)},
	        {EffectType.EFFECT_2XENGINE_VEHS, new EffectInfo("2x Vehicle Engine Speed", EffectCategory.VEHICLE, "vehs_x2engine", true)},
	        {EffectType.EFFECT_10XENGINE_VEHS, new EffectInfo("10x Vehicle Engine Speed", EffectCategory.VEHICLE, "vehs_x10engine", true)},
	        {EffectType.EFFECT_05XENGINE_VEHS, new EffectInfo("0.5x Vehicle Engine Speed", EffectCategory.VEHICLE, "vehs_x05engine", true)},
	        {EffectType.EFFECT_SPAWN_TANK, new EffectInfo("Spawn Rhino", EffectCategory.VEHICLE, "spawn_rhino")},
	        {EffectType.EFFECT_SPAWN_ADDER, new EffectInfo("Spawn Adder", EffectCategory.VEHICLE, "spawn_adder")},
	        {EffectType.EFFECT_SPAWN_DUMP, new EffectInfo("Spawn Dump", EffectCategory.VEHICLE, "spawn_dump")},
	        {EffectType.EFFECT_SPAWN_MONSTER, new EffectInfo("Spawn Monster", EffectCategory.VEHICLE, "spawn_monster")},
	        {EffectType.EFFECT_SPAWN_BMX, new EffectInfo("Spawn BMX", EffectCategory.VEHICLE, "spawn_bmx")},
	        {EffectType.EFFECT_SPAWN_TUG, new EffectInfo("Spawn Tug", EffectCategory.VEHICLE, "spawn_tug")},
	        {EffectType.EFFECT_SPAWN_CARGO, new EffectInfo("Spawn Cargo Plane", EffectCategory.VEHICLE, "spawn_cargo")},
	        {EffectType.EFFECT_SPAWN_BUS, new EffectInfo("Spawn Bus", EffectCategory.VEHICLE, "spawn_bus")},
	        {EffectType.EFFECT_SPAWN_BLIMP, new EffectInfo("Spawn Blimp", EffectCategory.VEHICLE, "spawn_blimp")},
            {EffectType.EFFECT_SPAWN_BUZZARD, new EffectInfo("Spawn Buzzard", EffectCategory.VEHICLE, "spawn_buzzard")},
            {EffectType.EFFECT_SPAWN_FAGGIO, new EffectInfo("Spawn Faggio", EffectCategory.VEHICLE, "spawn_faggio")},
            {EffectType.EFFECT_SPAWN_RUINER3, new EffectInfo("Spawn Ruined Ruiner", EffectCategory.VEHICLE, "spawn_ruiner3")},
            {EffectType.EFFECT_SPAWN_RANDOM, new EffectInfo("Spawn Random Vehicle", EffectCategory.VEHICLE, "spawn_random")},
            {EffectType.EFFECT_NO_VEHS, new EffectInfo("No Traffic", EffectCategory.VEHICLE, "notraffic", true)},
	        {EffectType.EFFECT_NO_PEDS, new EffectInfo("No Pedestrians", EffectCategory.PEDS, "nopeds", true)},
	        {EffectType.EFFECT_EXPLODE_CUR_VEH, new EffectInfo("Explode Current Vehicle", EffectCategory.VEHICLE, "playerveh_explode")},
	        {EffectType.EFFECT_PEDS_INVISIBLE, new EffectInfo("Everyone Is A Ghost", EffectCategory.PEDS, "peds_ghost", true)},
	        {EffectType.EFFECT_VEHS_INVISIBLE, new EffectInfo("Invisible Vehicles", EffectCategory.VEHICLE, "vehs_ghost", true)},
	        {EffectType.EFFECT_NO_RADAR, new EffectInfo("No Radar", EffectCategory.MISC, "no_radar", true)},
	        {EffectType.EFFECT_NO_HUD, new EffectInfo("No HUD", EffectCategory.MISC, "no_hud", true)},
	        {EffectType.EFFECT_SUPER_RUN, new EffectInfo("Super Run", EffectCategory.PLAYER, "player_superrun", true)},
	        {EffectType.EFFECT_SUPER_JUMP, new EffectInfo("Super Jump", EffectCategory.PLAYER, "player_superjump", true)},
	        {EffectType.EFFECT_PLAYER_RAGDOLL, new EffectInfo("Ragdoll", EffectCategory.PLAYER, "player_ragdoll")},
	        {EffectType.EFFECT_PEDS_RAGDOLL_ON_TOUCH, new EffectInfo("Sensitive Touch", EffectCategory.PEDS, "peds_sensitivetouch", true)},
	        {EffectType.EFFECT_PLUS_100K, new EffectInfo("+$100.000", EffectCategory.PLAYER, "richboi")},
	        {EffectType.EFFECT_MINUS_100K, new EffectInfo("-$100.000", EffectCategory.PLAYER, "poorboi")},
	        {EffectType.EFFECT_PEDS_FOLLOW_PLAYER, new EffectInfo("You Are Famous", EffectCategory.PEDS, "player_famous")},
	        {EffectType.EFFECT_PLAYER_DRUNK, new EffectInfo("Drunk", EffectCategory.PLAYER, "player_drunk", true)},
	        {EffectType.EFFECT_PEDS_OHKO, new EffectInfo("One Hit KO", EffectCategory.PEDS, "player_ohko", true)},
	        {EffectType.EFFECT_PEDS_NO_FEAR, new EffectInfo("Peds Are Easily Provoked", EffectCategory.PEDS, "peds_nofear", true)},
	        {EffectType.EFFECT_SCREEN_BLOOM, new EffectInfo("Bloom", EffectCategory.MISC, "screen_bloom", true)},
	        {EffectType.EFFECT_SCREEN_LSD, new EffectInfo("LSD", EffectCategory.PLAYER, "screen_lsd", true)},
            {EffectType.EFFECT_SCREEN_REALLSD, new EffectInfo("Actual LSD", EffectCategory.PLAYER, "screen_lsd2", true)},
            {EffectType.EFFECT_SCREEN_CHOPVISION, new EffectInfo("Chop Vision", EffectCategory.PLAYER, "screen_chop", true)},
            {EffectType.EFFECT_SCREEN_RENDERDIST, new EffectInfo("Where Did Everything Go?", EffectCategory.MISC, "screen_lowrenderdist", true, true)},
            {EffectType.EFFECT_SCREEN_FOG, new EffectInfo("Extreme Fog", EffectCategory.MISC, "screen_fog", true, true)},
            {EffectType.EFFECT_SCREEN_BRIGHT, new EffectInfo("Deep Fried", EffectCategory.MISC, "screen_bright", true)},
            {EffectType.EFFECT_SCREEN_MEXICO, new EffectInfo("Is This What Mexico Looks Like?", EffectCategory.MISC, "screen_mexico", true)},
            {EffectType.EFFECT_PEDS_IGNORE_PLAYER, new EffectInfo("Peds Ignore Player", EffectCategory.PEDS, "peds_ignoreplayer", true)},
	        {EffectType.EFFECT_HONK_BOOSTING, new EffectInfo("Honk Boosting", EffectCategory.VEHICLE, "vehs_honkboost", true)},
	        {EffectType.EFFECT_MIN_DAMAGE, new EffectInfo("Minimal Damage", EffectCategory.PEDS, "peds_mindmg", true)},
	        {EffectType.EFFECT_NO_HEADSHOTS, new EffectInfo("No Headshots", EffectCategory.PEDS, "peds_noheadshot", true)},
	        {EffectType.EFFECT_PEDS_FROZEN, new EffectInfo("Peds Are Brainless", EffectCategory.PEDS, "peds_frozen", true)},
	        {EffectType.EFFECT_LOW_GRAV, new EffectInfo("Low Gravity", EffectCategory.MISC, "lowgravity", true)},
	        {EffectType.EFFECT_VERY_LOW_GRAV, new EffectInfo("Very Low Gravity", EffectCategory.MISC, "verylowgravity", true)},
            {EffectType.EFFECT_INSANE_GRAV, new EffectInfo("Insane Gravity", EffectCategory.MISC, "insanegravity", true, true)},
            {EffectType.EFFECT_VEH_REPAIR, new EffectInfo("Repair Current Vehicle", EffectCategory.VEHICLE, "playerveh_repair")},
	        {EffectType.EFFECT_VEH_POP_TIRES, new EffectInfo("Pop Tires Of Current Vehicle", EffectCategory.VEHICLE, "playerveh_poptires")},
	        {EffectType.EFFECT_ALL_VEH_POP_TIRES, new EffectInfo("Now This Is Some Tire Poppin'", EffectCategory.VEHICLE, "vehs_poptiresconstant", true)},
	        {EffectType.EFFECT_NO_SPECIAL_ABILITY, new EffectInfo("No Special Ability", EffectCategory.PLAYER, "player_nospecial", true)},
	        {EffectType.EFFECT_IN_THE_HOOD, new EffectInfo("In The Hood", EffectCategory.PEDS, "peds_dance", true)},
	        {EffectType.EFFECT_FORCED_CINEMATIC, new EffectInfo("Cinematic Vehicle Cam", EffectCategory.VEHICLE, "player_forcedcinematiccam", true)},
	        {EffectType.EFFECT_PEDS_FLEE, new EffectInfo("All Nearby Peds Are Fleeing", EffectCategory.PEDS, "peds_flee")},
	        {EffectType.EFFECT_BREAK_VEH_DOORS, new EffectInfo("Break All Doors Of Current Vehicle", EffectCategory.VEHICLE, "playerveh_breakdoors")},
            {EffectType.EFFECT_ZOMBIES, new EffectInfo("Zombies", EffectCategory.PEDS, "zombies", true)},
            {EffectType.EFFECT_METEOR_RAIN, new EffectInfo("Meteor Shower", EffectCategory.MISC, "meteorrain", true)},
            {EffectType.EFFECT_BLIND, new EffectInfo("Blind", EffectCategory.PLAYER, "screen_blind", true, true)},
            {EffectType.EFFECT_BLACKOUT, new EffectInfo("Blackout", EffectCategory.MISC, "world_blackout", true)},
            {EffectType.EFFECT_QUICK_TIME, new EffectInfo("Timelapse", EffectCategory.TIME, "time_quickday", true)},
            {EffectType.EFFECT_PAUSE_TIME, new EffectInfo("Pause Clock", EffectCategory.TIME, "time_slowday", true)},
            {EffectType.EFFECT_MOV_NO_UD, new EffectInfo("Disable Forwards / Backwards Movement", EffectCategory.PLAYER, "player_noforwardbackward", true, true)},
            {EffectType.EFFECT_MOV_NO_LR, new EffectInfo("Disable Left / Right Movement", EffectCategory.PLAYER, "player_noleftright", true, true)},
            {EffectType.EFFECT_BREAK, new EffectInfo("It's Time For A Break", EffectCategory.PLAYER, "player_break", true, true)},
            {EffectType.EFFECT_EVERYONE_RPG, new EffectInfo("Give Everyone A RPG", EffectCategory.PEDS, "peds_giverpg")},
            {EffectType.EFFECT_EVERYONE_TAZER, new EffectInfo("Give Everyone A Stungun", EffectCategory.PEDS, "peds_stungun")},
            {EffectType.EFFECT_EVERYONE_MINIGUN, new EffectInfo("Give Everyone A Minigun", EffectCategory.PEDS, "peds_minigun")},
            {EffectType.EFFECT_EVERYONE_UPNATOMIZER, new EffectInfo("Give Everyone An Up-N-Atomizer", EffectCategory.PEDS, "peds_upnatomizer")},
            {EffectType.EFFECT_EVERYONE_RANDOMWEP, new EffectInfo("Give Everyone A Random Weapon", EffectCategory.PEDS, "peds_randomwep")},
            {EffectType.EFFECT_NO_SPRINT, new EffectInfo("No Sprint", EffectCategory.PLAYER, "player_nosprint", true)},
            {EffectType.EFFECT_NO_JUMP, new EffectInfo("No Jump", EffectCategory.PLAYER, "player_nojump", true)},
            {EffectType.EFFECT_EVERYONE_INVINCIBLE, new EffectInfo("Everyone Is Invincible", EffectCategory.PEDS, "peds_invincible", true)},
            {EffectType.EFFECT_VEHS_INVINCIBLE, new EffectInfo("All Vehicles Are Invulnerable", EffectCategory.VEHICLE, "vehs_invincible", true)},
            {EffectType.EFFECT_PLAYER_SHOT_RAGDOLL, new EffectInfo("Player Ragdolls When Shot", EffectCategory.PLAYER, "player_ragdollondmg", true)},
            {EffectType.EFFECT_JUMPY_VEHS, new EffectInfo("Jumpy Vehicles", EffectCategory.VEHICLE, "vehs_jumpy", true)},
            {EffectType.EFFECT_LOCK_VEHS, new EffectInfo("Lock All Vehicles", EffectCategory.VEHICLE, "vehs_lockdoors")},
            {EffectType.EFFECT_TOTAL_CHAOS, new EffectInfo("Doomsday", EffectCategory.MISC, "chaosmode", true)},
            {EffectType.EFFECT_NO_RAGDOLL, new EffectInfo("No Ragdoll", EffectCategory.PLAYER, "player_noragdoll", true)},
            {EffectType.EFFECT_VEHS_HORN, new EffectInfo("All Vehicles Honk", EffectCategory.VEHICLE, "vehs_honkconstant", true)},
            {EffectType.EFFECT_TP_WAYPOINT, new EffectInfo("Teleport To Waypoint", EffectCategory.PLAYER, "player_tptowaypoint")},
            {EffectType.EFFECT_PEDS_SAY_HI, new EffectInfo("Friendly Neighborhood", EffectCategory.PEDS, "peds_sayhi", true)},
            {EffectType.EFFECT_PEDS_INSULT, new EffectInfo("Unfriendly Neighborhood", EffectCategory.PEDS, "peds_insult", true)},
            {EffectType.EFFECT_EXPLOSIVE_BULLETS, new EffectInfo("Explosive Bullets", EffectCategory.PLAYER, "player_explosivebullets", true)},
            {EffectType.EFFECT_EXPLOSIVE_PUNCH, new EffectInfo("Explosive Punch", EffectCategory.PLAYER, "player_explosivepunch", true)},
            {EffectType.EFFECT_GIVE_ALL_WEPS, new EffectInfo("Give All Weapons", EffectCategory.PLAYER, "player_allweps")},
            {EffectType.EFFECT_PEDS_AIMBOT, new EffectInfo("Aimbot Peds", EffectCategory.PEDS, "peds_aimbot", true)},
            {EffectType.EFFECT_PEDS_BLIND, new EffectInfo("Peds Don't See Very Well", EffectCategory.PEDS, "peds_blind", true)},
            {EffectType.EFFECT_SPAWN_COMPANION_CHOP, new EffectInfo("Spawn Companion Doggo", EffectCategory.PEDS, "spawn_chop")},
            {EffectType.EFFECT_SPAWN_COMPANION_CHIMP, new EffectInfo("Spawn Companion Chimp", EffectCategory.PEDS, "spawn_chimp")},
            {EffectType.EFFECT_SPAWN_COMPANION_BRAD, new EffectInfo("Spawn Companion Brad", EffectCategory.PEDS, "spawn_compbrad")},
            {EffectType.EFFECT_PLAYER_NIGHTVISION, new EffectInfo("Night Vision", EffectCategory.MISC, "player_nightvision", true)},
            {EffectType.EFFECT_PLAYER_HEATVISION, new EffectInfo("Heat Vision", EffectCategory.MISC, "player_heatvision", true, true)},
            {EffectType.EFFECT_PLAYER_MONEYDROPS, new EffectInfo("Money Rain", EffectCategory.MISC, "player_moneydrops", true)},
            {EffectType.EFFECT_VEH_MAXENGINE, new EffectInfo("Upgrade Engine Of Current Vehicle", EffectCategory.VEHICLE, "playerveh_maxengine")},
            {EffectType.EFFECT_VEH_NITRO, new EffectInfo("Install Turbo On Current Vehicle", EffectCategory.VEHICLE, "playerveh_nitro")},
            {EffectType.EFFECT_VEH_MAXARMOR, new EffectInfo("Add Armor To Current Vehicle", EffectCategory.VEHICLE, "playerveh_maxarmor")},
            {EffectType.EFFECT_VEH_BULLETPROOFTIRES, new EffectInfo("Make Tires Of Current Vehicle Bulletproof", EffectCategory.VEHICLE, "playerveh_bulletprooftires")},
            {EffectType.EFFECT_VEH_RAINBOWHEADLIGHTS, new EffectInfo("Rainbow Headlights", EffectCategory.VEHICLE, "veh_rainbowheadlights", true)},
            {EffectType.EFFECT_VEH_TPRANDOMPEDS, new EffectInfo("Teleport Random Peds Into Current Vehicle", EffectCategory.PEDS, "playerveh_tprandompeds")},
            {EffectType.EFFECT_PEDS_REVIVE, new EffectInfo("Revive Dead Peds", EffectCategory.PEDS, "peds_revive")},
            {EffectType.EFFECT_SNOW, new EffectInfo("Snow", EffectCategory.MISC, "world_snow", true)},
            {EffectType.EFFECT_WHALE_RAIN, new EffectInfo("Whale Rain", EffectCategory.MISC, "world_whalerain", true)},
            {EffectType.EFFECT_VEH_MAX_UPGRADES, new EffectInfo("Add Max Upgrades To Current Vehicle", EffectCategory.VEHICLE, "playerveh_maxupgrades")},
            {EffectType.EFFECT_VEH_RANDOM_UPGRADES, new EffectInfo("Add Random Upgrades To Current Vehicle", EffectCategory.VEHICLE, "playerveh_randupgrades")},
            {EffectType.EFFECT_INTENSE_MUSIC, new EffectInfo("Play Arena Wars Theme", EffectCategory.MISC, "player_arenawarstheme", true)},
            {EffectType.EFFECT_PEDS_DRIVEBY, new EffectInfo("Peds Drive-By Player", EffectCategory.PEDS, "peds_driveby", true)},
            {EffectType.EFFECT_PLAYER_RANDOMCLOTHES, new EffectInfo("Randomize Player Clothes", EffectCategory.PLAYER, "player_randclothes")},
            {EffectType.EFFECT_PEDS_RAINBOWWEPS, new EffectInfo("Rainbow Weapons", EffectCategory.MISC, "peds_rainbowweps", true)},
            {EffectType.EFFECT_GTAO_TRAFFIC, new EffectInfo("GTA Online Traffic", EffectCategory.PEDS, "traffic_gtao", true)},
            {EffectType.EFFECT_SPAWN_IE_SULTAN, new EffectInfo("Spawn Blue Sultan", EffectCategory.VEHICLE, "spawn_bluesultan")},
            {EffectType.EFFECT_PLAYER_SETINTORANDVEH, new EffectInfo("Set Player Into Random Vehicle", EffectCategory.PLAYER, "player_setintorandveh")},
            {EffectType.EFFECT_VEHS_FULLACCEL, new EffectInfo("Full Acceleration", EffectCategory.VEHICLE, "traffic_fullaccel", true, true)},
            {EffectType.EFFECT_SPAWN_UFO, new EffectInfo("Spawn UFO", EffectCategory.MISC, "misc_spawnufo")},
            {EffectType.EFFECT_EXPLOSIVE_PEDS, new EffectInfo("Explosive Peds", EffectCategory.PEDS, "peds_explosive", true)},
            {EffectType.EFFECT_PEDS_ONEPUNCH, new EffectInfo("Deadly Punches", EffectCategory.PEDS, "peds_onepunch", true)},
            {EffectType.EFFECT_INVERTVELOCITY, new EffectInfo("Invert Current Velocity", EffectCategory.MISC, "invertvelocity")},
            {EffectType.EFFECT_PLAYER_TPEVERYTHING, new EffectInfo("Teleport Everything To Player", EffectCategory.PLAYER, "player_tpeverything")},
            {EffectType.EFFECT_WEATHER_RANDOMWEATHER, new EffectInfo("Modder Stop Changing Weather Plz", EffectCategory.WEATHER, "weather_randomizer", true)},
            {EffectType.EFFECT_LOW_POLY, new EffectInfo("Low Render Distance", EffectCategory.MISC, "world_lowpoly", true)},
            {EffectType.EFFECT_NEARBY_PEDS_OBLITERATE, new EffectInfo("Obliterate All Nearby Peds", EffectCategory.PEDS, "peds_obliterate")},
            {EffectType.EFFECT_VEHS_TRIGGER_ALARM, new EffectInfo("Alarmy Vehicles", EffectCategory.VEHICLE, "vehs_alarmloop", true)},
        };
    }
}
