using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum CreatureFamilies
    {
        None            = 0,
        Wolf            = 1,
        Cat             = 2,
        Spider          = 3,
        Bear            = 4,
        Boar            = 5,
        Crocolisk       = 6,
        CarrionBird     = 7,
        Crab            = 8,
        Gorilla         = 9,
        Raptor          = 11,
        Tallstrider     = 12,
        Felhunter       = 15,
        Voidwalker      = 16,
        Succubus        = 17,
        Doomguard       = 19,
        Scorpid         = 20,
        Turtle          = 21,
        Imp             = 23,
        Bat             = 24,
        Hyena           = 25,
        BirdOfPrey      = 26,
        WindSerpent     = 27,
        RemoteControl   = 28,
        Felguard        = 29,
        Dragonhawk      = 30,
        Ravager         = 31,
        WarpStalker     = 32,
        Sporebat        = 33,
        NetherRay       = 34,
        Serpent         = 35,
        Moth            = 37,
        Chimaera        = 38,
        Devilsaur       = 39,
        Ghoul           = 40,
        Silithid        = 41,
        Worm            = 42,
        Rhino           = 43,
        Wasp            = 44,
        CoreHound       = 45,
        SpiritBeast     = 46,
    }

    public enum CreatureEliteType
    {
        Normal    = 0,
        Elite     = 1,
        RareElite = 2,
        WorldBoss = 3,
        Rare      = 4,
        Unknown   = 5,
    }

    public enum CreatureType
    {
        Beast           = 1,
        Dragonkin       = 2,
        Demon           = 3,
        Elemental       = 4,
        Giant           = 5,
        Undead          = 6,
        Humanoid        = 7,
        Critter         = 8,
        Mechanical      = 9,
        NotSpecified    = 10,
        Totem           = 11,
        NonCombatPet    = 12,
        GasCloud        = 13,
    }

    [Flags]
    public enum CreatureTypeMask
    {
        None = 0,
        Beast = 1 << (CreatureType.Beast - 1),
        Dragonkin = 1 << (CreatureType.Dragonkin - 1),
        Demon = 1 << (CreatureType.Demon - 1),
        Elemental = 1 << (CreatureType.Elemental - 1),
        Giant = 1 << (CreatureType.Giant - 1),
        Undead = 1 << (CreatureType.Undead - 1),
        Humanoid = 1 << (CreatureType.Humanoid - 1),
        Critter = 1 << (CreatureType.Critter - 1),
        Mechanical = 1 << (CreatureType.Mechanical - 1),
        NotSpecified = 1 << (CreatureType.NotSpecified - 1),
        Totem = 1 << (CreatureType.Totem - 1),
        NonCombatPet = 1 << (CreatureType.NonCombatPet - 1),
        GasCloud = 1 << (CreatureType.GasCloud - 1),

        All = Beast | Dragonkin | Demon | Elemental | Giant | Undead
            | Humanoid | Critter | Mechanical | NonCombatPet | GasCloud
    }

    public enum AIReaction
    {
        /// <summary>
        /// Pre-aggro. Used in client packet handler.
        /// </summary>
        Alert = 0,
        /// <summary>
        /// Not used in client packet handler.
        /// </summary>
        Friendly = 1,
        /// <summary>
        /// Sent on every attack, triggers aggro sound. Used in client packet handler.
        /// </summary>
        Hostile = 2,
        /// <summary>
        /// Seen for polymorph (when AI not in control of self?). Not used in client packet handler.
        /// </summary>
        Afraid = 3,
        /// <summary>
        /// Used on object destroy. Not used in client packet handler.
        /// </summary>
        Destroy = 4,
    }
}
