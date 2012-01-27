using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum XpType : byte
    {
        Kill    = 0,
        NonKill = 1,
    }

    [Flags]
    public enum CharacterCustomizeFlags : uint
    {
        Customize = 0x00000001,       // name, gender, etc...
        Unknown01 = 0x00000002,
        Unknown02 = 0x00000004,
        Unknown03 = 0x00000008,
        Unknown04 = 0x00000010,
        Unknown05 = 0x00000020,
        Unknown06 = 0x00000040,
        Unknown07 = 0x00000080,
        Unknown08 = 0x00000100,
        Unknown09 = 0x00000200,
        Unknown10 = 0x00000400,
        Unknown11 = 0x00000800,
        Unknown12 = 0x00001000,
        Unknown13 = 0x00002000,
        Unknown14 = 0x00004000,
        Unknown15 = 0x00008000,
        Faction   = 0x00010000,       // name, gender, faction, etc...
        Unknown16 = 0x00020000,
        Unknown17 = 0x00040000,
        Unknown18 = 0x00080000,
        Race      = 0x00100000,       // name, gender, race, etc...
        Unknown19 = 0x00200000,
        Unknown20 = 0x00400000,
        Unknown21 = 0x00800000,
        Unknown22 = 0x01000000,
        Unknown23 = 0x02000000,
        Unknown24 = 0x04000000,
        Unknown25 = 0x08000000,
        Unknown26 = 0x10000000,
        Unknown27 = 0x20000000,
        Unknown28 = 0x40000000,
        Unknown29 = 0x80000000,
    }

    [Flags]
    public enum CharacterFlags : uint
    {
        Unknown00 = 0x00000001,       // name, gender, etc...
        Unknown01 = 0x00000002,
        LockedForTransfer = 0x00000004,
        Unknown03 = 0x00000008,
        Unknown04 = 0x00000010,
        Unknown05 = 0x00000020,
        Unknown06 = 0x00000040,
        Unknown07 = 0x00000080,
        Unknown08 = 0x00000100,
        Unknown09 = 0x00000200,
        HideHelm  = 0x00000400,
        HideCloak = 0x00000800,
        Unknown12 = 0x00001000,
        Ghost     = 0x00002000,
        Rename    = 0x00004000,
        Unknown15 = 0x00008000,
        Unknown16 = 0x00010000,
        Unknown17 = 0x00020000,
        Unknown18 = 0x00040000,
        Unknown19 = 0x00080000,
        Unknown20 = 0x00100000,
        Unknown21 = 0x00200000,
        Unknown22 = 0x00400000,
        Unknown23 = 0x00800000,
        LockedByBilling = 0x01000000,
        Declined  = 0x02000000,
        Unknown26 = 0x04000000,
        Unknown27 = 0x08000000,
        Unknown28 = 0x10000000,
        Unknown29 = 0x20000000,
        Unknown30 = 0x40000000,
        Unknown31 = 0x80000000,
    }

    [Flags]
    public enum ReputationFlags
    {
        None            = 0x00,
        Visible         = 0x01,
        AtWar           = 0x02,
        Hidden          = 0x04,
        /// <summary>
        /// Always overrides the <value>Visible</value> flag
        /// </summary>
        ForcedInvisible = 0x08,
        /// <summary>
        /// Always overrides the <value>AtWar</value> flag
        /// </summary>
        ForcedPeace     = 0x10,
        Inactive        = 0x20,
        /// <summary>
        /// Factions from The Burning Crusade
        /// </summary>
        Flag_0x40       = 0x40,
        /// <summary>
        /// The main 2 opposing factions from Wrath of the Lich King
        /// </summary>
        Expansion_2     = 0x80,
    }

    /// <summary>
    /// The actual reputation value of each Standing
    /// </summary>
    public enum FactionStanding : int
    {
        Exalted     = 42000,
        Revered     = 21000,
        Honored     = 9000,
        Friendly    = 3000,
        Neutral     = 0,
        Unfriendly  = -3000,
        Hostile     = -6000,
        Hated       = -42000,
    }

    /// <summary>
    /// The level of each standing (0 - hated to 7 - exhalted)
    /// </summary>
    public enum FactionStandingLevel : uint
    {
        Exalted     = 7,
        Revered     = 6,
        Honored     = 5,
        Friendly    = 4,
        Neutral     = 3,
        Unfriendly  = 2,
        Hostile     = 1,
        Hated       = 0,
        Unknown     = Hated
    }
}
