using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum LFGDungeons
    {
        [LocalizedName("Wailing Caverns")]
        Wailing_Caverns = 1,
        [LocalizedName("Scholomance")]
        Scholomance = 2,
        [LocalizedName("Ragefire Chasm")]
        Ragefire_Chasm = 4,
        [LocalizedName("Deadmines")]
        Deadmines = 6,
        [LocalizedName("Shadowfang Keep")]
        Shadowfang_Keep = 8,
        [LocalizedName("Blackfathom Deeps")]
        Blackfathom_Deeps = 10,
        [LocalizedName("Stormwind Stockade")]
        Stormwind_Stockade = 12,
        [LocalizedName("Gnomeregan")]
        Gnomeregan = 14,
        [LocalizedName("Razorfen Kraul")]
        Razorfen_Kraul = 16,
        [LocalizedName("Scarlet Monastery - Graveyard")]
        Scarlet_Monastery_Graveyard = 18,
        [LocalizedName("Razorfen Downs")]
        Razorfen_Downs = 20,
        [LocalizedName("Uldaman")]
        Uldaman = 22,
        [LocalizedName("Zul'Farrak")]
        ZulFarrak = 24,
        [LocalizedName("Maraudon - Foulspore Cavern")]
        Maraudon_Foulspore_Cavern = 26,
        [LocalizedName("Sunken Temple")]
        Sunken_Temple = 28,
        [LocalizedName("Blackrock Depths - Detention Block")]
        Blackrock_Depths_Detention_Block = 30,
        [LocalizedName("Lower Blackrock Spire")]
        Lower_Blackrock_Spire = 32,
        [LocalizedName("Dire Maul - Warpwood Quarter")]
        Dire_Maul_Warpwood_Quarter = 34,
        [LocalizedName("Dire Maul - Capital Gardens")]
        Dire_Maul_Capital_Gardens = 36,
        [LocalizedName("Dire Maul - Gordok Commons")]
        Dire_Maul_Gordok_Commons = 38,
        [LocalizedName("Stratholme - Main Gate")]
        Stratholme_Main_Gate = 40,
        [LocalizedName("Hellfire Ramparts (Normal)")]
        Hellfire_Ramparts_Normal = 136,
        [LocalizedName("Blood Furnace (Normal)")]
        Blood_Furnace_Normal = 137,
        [LocalizedName("Shattered Halls (Normal)")]
        Shattered_Halls_Normal = 138,
        [LocalizedName("Slave Pens (Normal)")]
        Slave_Pens_Normal = 140,
        [LocalizedName("Underbog (Normal)")]
        Underbog_Normal = 146,
        [LocalizedName("The Steamvault (Normal)")]
        The_Steamvault_Normal = 147,
        [LocalizedName("Mana-Tombs (Normal)")]
        Mana_Tombs_Normal = 148,
        [LocalizedName("Auchenai Crypts (Normal)")]
        Auchenai_Crypts_Normal = 149,
        [LocalizedName("Sethekk Halls (Normal)")]
        Sethekk_Halls_Normal = 150,
        [LocalizedName("Shadow Labyrinth (Normal)")]
        Shadow_Labyrinth_Normal = 151,
        [LocalizedName("Scarlet Monastery - Armory")]
        Scarlet_Monastery_Armory = 163,
        [LocalizedName("Scarlet Monastery - Cathedral")]
        Scarlet_Monastery_Cathedral = 164,
        [LocalizedName("Scarlet Monastery - Library")]
        Scarlet_Monastery_Library = 165,
        [LocalizedName("The Escape From Durnholde (Normal)")]
        The_Escape_From_Durnholde_Normal = 170,
        [LocalizedName("Opening of the Dark Portal (Normal)")]
        Opening_of_the_Dark_Portal_Normal = 171,
        [LocalizedName("The Mechanar (Normal)")]
        The_Mechanar_Normal = 172,
        [LocalizedName("The Botanica (Normal)")]
        The_Botanica_Normal = 173,
        [LocalizedName("The Arcatraz (Normal)")]
        The_Arcatraz_Normal = 174,
        [LocalizedName("Magisters' Terrace (Normal)")]
        Magisters_Terrace_Normal = 198,
        [LocalizedName("Utgarde Keep (Normal)")]
        Utgarde_Keep_Normal = 202,
        [LocalizedName("Utgarde Pinnacle (Normal)")]
        Utgarde_Pinnacle_Normal = 203,
        [LocalizedName("Azjol-Nerub (Normal)")]
        Azjol_Nerub_Normal = 204,
        [LocalizedName("The Oculus (Normal)")]
        The_Oculus_Normal = 206,
        [LocalizedName("Halls of Lightning (Normal)")]
        Halls_of_Lightning_Normal = 207,
        [LocalizedName("Halls of Stone (Normal)")]
        Halls_of_Stone_Normal = 208,
        [LocalizedName("The Culling of Stratholme (Normal)")]
        The_Culling_of_Stratholme_Normal = 209,
        [LocalizedName("Drak'Tharon Keep (Normal)")]
        DrakTharon_Keep_Normal = 214,
        [LocalizedName("Gundrak (Normal)")]
        Gundrak_Normal = 216,
        [LocalizedName("Ahn'kahet: The Old Kingdom (Normal)")]
        Ahnkahet_The_Old_Kingdom_Normal = 218,
        [LocalizedName("Violet Hold (Normal)")]
        Violet_Hold_Normal = 220,
        [LocalizedName("The Nexus (Normal)")]
        The_Nexus_Normal = 225,
        [LocalizedName("Trial of the Champion (Normal)")]
        Trial_of_the_Champion_Normal = 245,
        [LocalizedName("The Forge of Souls (Normal)")]
        The_Forge_of_Souls_Normal = 251,
        [LocalizedName("Pit of Saron (Normal)")]
        Pit_of_Saron_Normal = 253,
        [LocalizedName("Halls of Reflection (Normal)")]
        Halls_of_Reflection_Normal = 255,
        [LocalizedName("Maraudon - The Wicked Grotto")]
        Maraudon_The_Wicked_Grotto = 272,
        [LocalizedName("Maraudon - Earth Song Falls")]
        Maraudon_Earth_Song_Falls = 273,
        [LocalizedName("Stratholme - Service Entrance")]
        Stratholme_Service_Entrance = 274,
        [LocalizedName("Blackrock Depths - Upper City")]
        Blackrock_Depths_Upper_City = 276,
        [LocalizedName("The Headless Horseman")]
        The_Headless_Horseman = 285,
        [LocalizedName("The Frost Lord Ahune")]
        The_Frost_Lord_Ahune = 286,
        [LocalizedName("Coren Direbrew")]
        Coren_Direbrew = 287,
        [LocalizedName("The Crown Chemical Co.")]
        The_Crown_Chemical_Co = 288,
        [LocalizedName("Grand Ambassador Flamelash")]
        Grand_Ambassador_Flamelash = 296,
        [LocalizedName("Crown Princess Theradras")]
        Crown_Princess_Theradras = 297,
        [LocalizedName("Kai'ju Gahz'rilla")]
        Kaiju_Gahzrilla = 298,
        [LocalizedName("Prince Sarsarun")]
        Prince_Sarsarun = 299,
        [LocalizedName("Throne of the Tides (Normal)")]
        Throne_of_the_Tides_Normal = 302,
        [LocalizedName("Blackrock Caverns (Normal)")]
        Blackrock_Caverns_Normal = 303,
        [LocalizedName("Grim Batol (Normal)")]
        Grim_Batol_Normal = 304,
        [LocalizedName("Halls of Origination (Normal)")]
        Halls_of_Origination_Normal = 305,
        [LocalizedName("Kai'ju Gahz'rilla")]
        Kaiju_Gahzrilla2 = 306,
        [LocalizedName("The Stonecore (Normal)")]
        The_Stonecore_Normal = 307,
        [LocalizedName("Grand Ambassador Flamelash")]
        Grand_Ambassador_Flamelash2 = 308,
        [LocalizedName("Crown Princess Theradras")]
        Crown_Princess_Theradras2 = 309,
        [LocalizedName("Prince Sarsarun")]
        Prince_Sarsarun2 = 310,
        [LocalizedName("The Vortex Pinnacle (Normal)")]
        The_Vortex_Pinnacle_Normal = 311,
        [LocalizedName("Lost City of the Tol'vir (Normal)")]
        Lost_City_of_the_Tolvir_Normal = 312,
        [LocalizedName("Upper Blackrock Spire")]
        Upper_Blackrock_Spire = 44,
        [LocalizedName("Onyxia's Lair (10)")]
        Onyxias_Lair_10 = 46,
        [LocalizedName("Molten Core")]
        Molten_Core = 48,
        [LocalizedName("Blackwing Lair")]
        Blackwing_Lair = 50,
        [LocalizedName("Naxxramas (10)")]
        Naxxramas_10 = 159,
        [LocalizedName("Ahn'Qiraj Ruins")]
        AhnQiraj_Ruins = 160,
        [LocalizedName("Ahn'Qiraj Temple")]
        AhnQiraj_Temple = 161,
        [LocalizedName("Karazhan")]
        Karazhan = 175,
        [LocalizedName("Magtheridon's Lair")]
        Magtheridons_Lair = 176,
        [LocalizedName("Gruul's Lair")]
        Gruuls_Lair = 177,
        [LocalizedName("Tempest Keep")]
        Tempest_Keep = 193,
        [LocalizedName("Serpentshrine Cavern")]
        Serpentshrine_Cavern = 194,
        [LocalizedName("Hyjal Past")]
        Hyjal_Past = 195,
        [LocalizedName("Black Temple")]
        Black_Temple = 196,
        [LocalizedName("Zul'Aman")]
        ZulAman = 197,
        [LocalizedName("The Sunwell")]
        The_Sunwell = 199,
        [LocalizedName("The Eye of Eternity (10)")]
        The_Eye_of_Eternity_10 = 223,
        [LocalizedName("The Obsidian Sanctum (10)")]
        The_Obsidian_Sanctum_10 = 224,
        [LocalizedName("Naxxramas (25)")]
        Naxxramas_25 = 227,
        [LocalizedName("The Eye of Eternity (25)")]
        The_Eye_of_Eternity_25 = 237,
        [LocalizedName("The Obsidian Sanctum (25)")]
        The_Obsidian_Sanctum_25 = 238,
        [LocalizedName("Vault of Archavon (10)")]
        Vault_of_Archavon_10 = 239,
        [LocalizedName("Vault of Archavon (25)")]
        Vault_of_Archavon_25 = 240,
        [LocalizedName("Ulduar (10)")]
        Ulduar_10 = 243,
        [LocalizedName("Ulduar (25)")]
        Ulduar_25 = 244,
        [LocalizedName("Trial of the Crusader (10)")]
        Trial_of_the_Crusader_10 = 246,
        [LocalizedName("Trial of the Grand Crusader (10)")]
        Trial_of_the_Grand_Crusader_10 = 247,
        [LocalizedName("Trial of the Crusader (25)")]
        Trial_of_the_Crusader_25 = 248,
        [LocalizedName("Trial of the Grand Crusader (25)")]
        Trial_of_the_Grand_Crusader_25 = 250,
        [LocalizedName("Onyxia's Lair (25)")]
        Onyxias_Lair_25 = 257,
        [LocalizedName("Icecrown Citadel (10)")]
        Icecrown_Citadel_10 = 279,
        [LocalizedName("Icecrown Citadel (25)")]
        Icecrown_Citadel_25 = 280,
        [LocalizedName("Ruby Sanctum (10)")]
        Ruby_Sanctum_10 = 293,
        [LocalizedName("Ruby Sanctum (25)")]
        Ruby_Sanctum_25 = 294,
        [LocalizedName("Blackwing Descent (10)")]
        Blackwing_Descent_10 = 313,
        [LocalizedName("Blackwing Descent (25)")]
        Blackwing_Descent_25 = 314,
        [LocalizedName("The Bastion of Twilight (10)")]
        The_Bastion_of_Twilight_10 = 315,
        [LocalizedName("The Bastion of Twilight (25)")]
        The_Bastion_of_Twilight_25 = 316,
        [LocalizedName("Throne of the Four Winds (10)")]
        Throne_of_the_Four_Winds_10 = 317,
        [LocalizedName("Throne of the Four Winds (25)")]
        Throne_of_the_Four_Winds_25 = 318,
        [LocalizedName("Baradin Hold (10)")]
        Baradin_Hold_10 = 328,
        [LocalizedName("Baradin Hold (25)")]
        Baradin_Hold_25 = 329,
        [LocalizedName("Elwynn Forest")]
        Elwynn_Forest = 58,
        [LocalizedName("Westfall")]
        Westfall = 60,
        [LocalizedName("Duskwood")]
        Duskwood = 62,
        [LocalizedName("Dun Morogh")]
        Dun_Morogh = 64,
        [LocalizedName("Loch Modan")]
        Loch_Modan = 66,
        [LocalizedName("Wetlands")]
        Wetlands = 68,
        [LocalizedName("Stranglethorn Vale")]
        Stranglethorn_Vale = 70,
        [LocalizedName("Blasted Lands")]
        Blasted_Lands = 72,
        [LocalizedName("Swamp of Sorrows")]
        Swamp_of_Sorrows = 74,
        [LocalizedName("Redridge Mountains")]
        Redridge_Mountains = 76,
        [LocalizedName("Burning Steppes")]
        Burning_Steppes = 78,
        [LocalizedName("Searing Gorge")]
        Searing_Gorge = 80,
        [LocalizedName("Badlands")]
        Badlands = 82,
        [LocalizedName("Arathi Highlands")]
        Arathi_Highlands = 84,
        [LocalizedName("Hillsbrad Foothills")]
        Hillsbrad_Foothills = 86,
        [LocalizedName("Hinterlands")]
        Hinterlands = 88,
        [LocalizedName("Western Plaguelands")]
        Western_Plaguelands = 90,
        [LocalizedName("Eastern Plaguelands")]
        Eastern_Plaguelands = 92,
        [LocalizedName("Tirisfal Glades")]
        Tirisfal_Glades = 94,
        [LocalizedName("Silverpine Forest")]
        Silverpine_Forest = 96,
        [LocalizedName("Alterac Mountains")]
        Alterac_Mountains = 98,
        [LocalizedName("Durotar")]
        Durotar = 100,
        [LocalizedName("Mulgore")]
        Mulgore = 102,
        [LocalizedName("The Barrens")]
        The_Barrens = 104,
        [LocalizedName("Stonetalon Mountains")]
        Stonetalon_Mountains = 106,
        [LocalizedName("Thousand Needles")]
        Thousand_Needles = 108,
        [LocalizedName("Desolace")]
        Desolace = 110,
        [LocalizedName("Feralas")]
        Feralas = 112,
        [LocalizedName("Dustwallow Marsh")]
        Dustwallow_Marsh = 114,
        [LocalizedName("Tanaris")]
        Tanaris = 116,
        [LocalizedName("Un'Goro Crater")]
        UnGoro_Crater = 118,
        [LocalizedName("Silithus")]
        Silithus = 120,
        [LocalizedName("Teldrassil")]
        Teldrassil = 122,
        [LocalizedName("Darkshore")]
        Darkshore = 124,
        [LocalizedName("Ashenvale")]
        Ashenvale = 126,
        [LocalizedName("Felwood")]
        Felwood = 128,
        [LocalizedName("Azshara")]
        Azshara = 130,
        [LocalizedName("Winterspring")]
        Winterspring = 132,
        [LocalizedName("Hellfire Peninsula")]
        Hellfire_Peninsula = 152,
        [LocalizedName("Zangarmarsh")]
        Zangarmarsh = 153,
        [LocalizedName("Terokkar Forest")]
        Terokkar_Forest = 154,
        [LocalizedName("Nagrand")]
        Nagrand = 155,
        [LocalizedName("Shadowmoon Valley")]
        Shadowmoon_Valley = 156,
        [LocalizedName("Blade's Edge Mountains")]
        Blades_Edge_Mountains = 157,
        [LocalizedName("Netherstorm")]
        Netherstorm = 158,
        [LocalizedName("Eversong Woods")]
        Eversong_Woods = 166,
        [LocalizedName("Azuremyst Isle")]
        Azuremyst_Isle = 167,
        [LocalizedName("Ghostlands")]
        Ghostlands = 168,
        [LocalizedName("Bloodmyst Isle")]
        Bloodmyst_Isle = 169,
        [LocalizedName("Isle of Quel'Danas")]
        Isle_of_QuelDanas = 200,
        [LocalizedName("Borean Tundra")]
        Borean_Tundra = 228,
        [LocalizedName("Howling Fjord")]
        Howling_Fjord = 229,
        [LocalizedName("Grizzly Hills")]
        Grizzly_Hills = 230,
        [LocalizedName("Dragonblight")]
        Dragonblight = 231,
        [LocalizedName("Wintergrasp")]
        Wintergrasp = 232,
        [LocalizedName("Zul'Drak")]
        ZulDrak = 233,
        [LocalizedName("Sholazar Basin")]
        Sholazar_Basin = 234,
        [LocalizedName("The Storm Peaks")]
        The_Storm_Peaks = 235,
        [LocalizedName("Icecrown")]
        Icecrown = 236,
        [LocalizedName("Auchenai Crypts (Heroic)")]
        Auchenai_Crypts_Heroic = 178,
        [LocalizedName("Mana-Tombs (Heroic)")]
        Mana_Tombs_Heroic = 179,
        [LocalizedName("Sethekk Halls (Heroic)")]
        Sethekk_Halls_Heroic = 180,
        [LocalizedName("Shadow Labyrinth (Heroic)")]
        Shadow_Labyrinth_Heroic = 181,
        [LocalizedName("Opening of the Dark Portal (Heroic)")]
        Opening_of_the_Dark_Portal_Heroic = 182,
        [LocalizedName("The Escape From Durnholde (Heroic)")]
        The_Escape_From_Durnholde_Heroic = 183,
        [LocalizedName("Slave Pens (Heroic)")]
        Slave_Pens_Heroic = 184,
        [LocalizedName("The Steamvault (Heroic)")]
        The_Steamvault_Heroic = 185,
        [LocalizedName("Underbog (Heroic)")]
        Underbog_Heroic = 186,
        [LocalizedName("Blood Furnace (Heroic)")]
        Blood_Furnace_Heroic = 187,
        [LocalizedName("Hellfire Ramparts (Heroic)")]
        Hellfire_Ramparts_Heroic = 188,
        [LocalizedName("Shattered Halls (Heroic)")]
        Shattered_Halls_Heroic = 189,
        [LocalizedName("The Arcatraz (Heroic)")]
        The_Arcatraz_Heroic = 190,
        [LocalizedName("The Botanica (Heroic)")]
        The_Botanica_Heroic = 191,
        [LocalizedName("The Mechanar (Heroic)")]
        The_Mechanar_Heroic = 192,
        [LocalizedName("Magisters' Terrace (Heroic)")]
        Magisters_Terrace_Heroic = 201,
        [LocalizedName("Utgarde Pinnacle (Heroic)")]
        Utgarde_Pinnacle_Heroic = 205,
        [LocalizedName("The Culling of Stratholme (Heroic)")]
        The_Culling_of_Stratholme_Heroic = 210,
        [LocalizedName("The Oculus (Heroic)")]
        The_Oculus_Heroic = 211,
        [LocalizedName("Halls of Lightning (Heroic)")]
        Halls_of_Lightning_Heroic = 212,
        [LocalizedName("Halls of Stone (Heroic)")]
        Halls_of_Stone_Heroic = 213,
        [LocalizedName("Drak'Tharon Keep (Heroic)")]
        DrakTharon_Keep_Heroic = 215,
        [LocalizedName("Gundrak (Heroic)")]
        Gundrak_Heroic = 217,
        [LocalizedName("Ahn'kahet: The Old Kingdom (Heroic)")]
        Ahnkahet_The_Old_Kingdom_Heroic = 219,
        [LocalizedName("Violet Hold (Heroic)")]
        Violet_Hold_Heroic = 221,
        [LocalizedName("The Nexus (Heroic)")]
        The_Nexus_Heroic = 226,
        [LocalizedName("Azjol-Nerub (Heroic)")]
        Azjol_Nerub_Heroic = 241,
        [LocalizedName("Utgarde Keep (Heroic)")]
        Utgarde_Keep_Heroic = 242,
        [LocalizedName("Trial of the Champion (Heroic)")]
        Trial_of_the_Champion_Heroic = 249,
        [LocalizedName("The Forge of Souls (Heroic)")]
        The_Forge_of_Souls_Heroic = 252,
        [LocalizedName("Pit of Saron (Heroic)")]
        Pit_of_Saron_Heroic = 254,
        [LocalizedName("Halls of Reflection (Heroic)")]
        Halls_of_Reflection_Heroic = 256,
        [LocalizedName("The Vortex Pinnacle (Heroic)")]
        The_Vortex_Pinnacle_Heroic = 319,
        [LocalizedName("The Stonecore (Heroic)")]
        The_Stonecore_Heroic = 320,
        [LocalizedName("Halls of Origination (Heroic)")]
        Halls_of_Origination_Heroic = 321,
        [LocalizedName("Grim Batol (Heroic)")]
        Grim_Batol_Heroic = 322,
        [LocalizedName("Blackrock Caverns (Heroic)")]
        Blackrock_Caverns_Heroic = 323,
        [LocalizedName("Throne of the Tides (Heroic)")]
        Throne_of_the_Tides_Heroic = 324,
        [LocalizedName("Lost City of the Tol'vir (Heroic)")]
        Lost_City_of_the_Tolvir_Heroic = 325,
        [LocalizedName("Deadmines (Heroic)")]
        Deadmines_Heroic = 326,
        [LocalizedName("Shadowfang Keep (Heroic)")]
        Shadowfang_Keep_Heroic = 327,
        [LocalizedName("Random Classic Dungeon")]
        Random_Classic_Dungeon = 258,
        [LocalizedName("Random Burning Crusade Dungeon (Normal)")]
        Random_Burning_Crusade_Dungeon_Normal = 259,
        [LocalizedName("Random Burning Crusade Heroic (Heroic)")]
        Random_Burning_Crusade_Heroic_Heroic = 260,
        [LocalizedName("Random Lich King Dungeon (Normal)")]
        Random_Lich_King_Dungeon_Normal = 261,
        [LocalizedName("Random Lich King Heroic (Heroic)")]
        Random_Lich_King_Heroic_Heroic = 262,
        [LocalizedName("Random Cataclysm Dungeon (Normal)")]
        Random_Cataclysm_Dungeon_Normal = 300,
        [LocalizedName("Random Cataclysm Heroic (Heroic)")]
        Random_Cataclysm_Heroic_Heroic = 301,
    }
}
