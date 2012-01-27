using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum LFGType
    {
        None            = 0,
        Dungeon         = 1,
        Raid            = 2,
        Quest           = 3,
        Zone            = 4,
        HeroicDungeon   = 5,
        DungeonFinder   = 6,
    }

    [Flags]
    public enum GroupRoles
    {
        None    = 0,
        Guide   = 1,
        Tank    = 2,
        Healer  = 4,
        DPS     = 8,
    }

    [Flags]
    public enum LFGMemberFlags
    {
        CharacterInfo   = 0x01,
        Comment         = 0x02,
        Unknown1        = 0x04,
        Guid            = 0x08,
        Roles           = 0x10,
        Unknown2        = 0x20,
        Unknown3        = 0x40,
        Unknown4        = 0x80,
    }

    public enum LFGUpdateType
    {
        Leader = 1,
        RolecheckAborted = 4,
        JoinProposal = 5,
        RolecheckFailed = 6,
        RemovedFromQueue = 7,
        ProposalFailed = 8,
        ProposalDeclined = 9,
        GroupFound = 10,
        AddedToQueue = 12,
        ProposalBegin = 13,
        ClearLockList = 14,
        GroupMemberOffline = 15,
        GroupDisband = 16,
    }

    public enum LFGState
    {
        [LocalizedName("Not using LFG/LFR")]
        None = 0,                                        // Not using LFG / LFR
        [LocalizedName("Rolecheck Active")]
        Rolecheck = 1,                                   // Rolecheck active
        [LocalizedName("Queued")]
        Queued = 2,                                      // Queued
        [LocalizedName("Proposal Active")]
        Proposal = 3,                                    // Proposal active
        [LocalizedName("Vote Kick Active")]
        Boot = 4,                                        // Vote kick active
        [LocalizedName("In a Dungeon")]
        Dungeon = 5,                                     // In LFG Group, in a Dungeon
        [LocalizedName("In a Finished Dungeon")]
        FinishedDungeon = 6,                             // In LFG Group, in a finished Dungeon
        [LocalizedName("Using Raid Finder")]
        RaidBrowser = 7,                                 // Using Raid finder
    }

    public enum LFGLockStatusType
    {
        InsufficientExpansion = 1,
        TooLowLevel = 2,
        TooHighLevel = 3,
        TooLowGearScore = 4,
        TooHighGearScore = 5,
        RaidLocked = 6,
        ExplorationRequired = 9, // Additional1 = Entrance Area Id
        AttunementTooLowLevel = 1001,
        AttunementTooHighLevel = 1002,
        AttunementUnavailable = 1003, // unsure
        QuestNotCompleted = 1022,
        MissingItem = 1025,
        NotInSeason = 1031,
    }

    public enum RollVote
    {
        Pass            = 0,
        Need            = 1,
        Greed           = 2,
        Disenchant      = 3,
    }

    [Flags]
    public enum RollVoteMask
    {
        Pass        = 1 << RollVote.Pass,
        Need        = 1 << RollVote.Need,
        Greed       = 1 << RollVote.Greed,
        Disenchant  = 1 << RollVote.Disenchant,
    }

    [Flags]
    public enum GroupTypeMask
    {
        Normal          = 0,
        Battleground    = 1,
        Raid            = 2,
        Unknown4        = 4,
        DungeonFinder   = 8,
        Unknown16       = 16,                   // Battleground finished?
    }

    [Flags]
    public enum GroupMemberFlags
    {
        Regular         = 0,
        Assistant       = 1,
        MainAssistant   = 2,
        MainTank        = 4,
    }

    [Flags]
    public enum GroupMemberStateMask : byte
    {
        Offline   = 0x00,
        Online    = 0x01,                       // Lua_UnitIsConnected
        PvP       = 0x02,                       // Lua_UnitIsPVP
        Dead      = 0x04,                       // Lua_UnitIsDead
        Hhost     = 0x08,                       // Lua_UnitIsGhost
        PvP_FFA   = 0x10,                       // Lua_UnitIsPVPFreeForAll
        Unk3      = 0x20,                       // used in calls from Lua_GetPlayerMapPosition/Lua_GetBattlefieldFlagPosition
        AFK       = 0x40,                       // Lua_UnitIsAFK
        DND       = 0x80,                       // Lua_UnitIsDND
    }

    public enum LootMethod
    {
        FreeForAll      = 0,
        RoundRobin      = 1,
        MasterLoot      = 2,
        GroupLoot       = 3,
        NeedBeforeGreed = 4,
    }
}
