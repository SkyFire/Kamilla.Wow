using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum QuestType : uint
    {
        /// <summary>
        /// Group?
        /// </summary>
        Normal      = 0,
        Elite       = 1,
        Life        = 21,
        PvP         = 41,
        Raid        = 62,
        Dungeon     = 81,
        WorldEvent  = 82,
        Legendary   = 83,
        Escort      = 84,
        Heroic      = 85,
    }

    [Flags]
    public enum QuestSpecialFlags : uint
    {
        NoExtraRequirements             = 0,
        /// <summary>
        /// Makes the quest repeatable.
        /// </summary>
        MakeRepeateable                 = 1,
        /// <summary>
        /// Makes the quest only completable by some external event (an entry in areatrigger_involvedrelation, 
        /// spell effect quest complete or an entry in spell_scripts with command 7 as some examples)
        /// </summary>
        EventCompletable                = 2,
        /// <summary>
        /// Both repeatable and completable only through an external event
        /// </summary>
        RepeateableEventCompleteable    = 3, 
    }

    /// <summary>
    /// Indicates a status of a quest at a questgiver.
    /// </summary>
    public enum QuestStatus : uint
    {
        /// <summary>
        /// Indicates that questgiver has no quests available.
        /// Displays nothing.
        /// </summary>
        NotAvailable            = 0,

        /// <summary>
        /// Indicates that you does not meet the requirements for the quest.
        /// Displays gray exclamation mark.
        /// </summary>
        TooHighLevel            = 1,

        /// <summary>
        /// ?
        /// </summary>
        Obsolete                = 2,

        /// <summary>
        /// Indicates that you haven't completed a quest.
        /// Displays gray question mark.
        /// </summary>
        NotCompleted            = 4,

        /// <summary>
        /// ?
        /// </summary>
        RepeateableCompletable  = 8,

        /// <summary>
        /// Indicates that a repeatable quest is available.
        /// Displays blue exclamation mark.
        /// </summary>
        Repeatable              = 16,

        /// <summary>
        /// Indicates that a quest is available.
        /// Displays yellow exclamation mark.
        /// </summary>
        Available               = 32,

        /// <summary>
        /// ?
        /// </summary>
        CompletableNoMinimap    = 64,

        /// <summary>
        /// Indicates that a quest is available to be turned in.
        /// Displays yellow question mark.
        /// </summary>
        Completable             = 128,
    };

    public enum QuestTemplateStatus : uint
    {
        /// <summary>
        /// Quest is not active and player can't do it.
        /// </summary>
        Inactive = 0,
        /// <summary>
        /// Can accept only in current session, will be deleted on start.
        /// </summary>
        Session  = 1,
        /// <summary>
        /// Quest is active and player can take and do it.
        /// </summary>
        Active   = 2,
    }

    public enum QuestCompleteStatus : byte
    {
        NotCompleted = 0,
        Completed    = 1,
        Failed       = 2,
    }

    public enum QuestFailedReason : byte
    {
        NoDetails     = 0,
        InventoryFull = 4,
        DupeItemFound = 17,
    };

    public enum QuestInvalidReason : byte
    {
        Ok                  = 0xFF,
        NoRequirements      = 0,
        LowLevel            = 1,
        WrongClass          = 5,
        WrongRace           = 6,
        AlreadyCompleted    = 7,
        AlreadyOnTimedQuest = 12,
        AlreadyHave         = 13,
        NoExpansionAccount  = 16,
        NoRequiredItems     = 21,
        NotEnoughMoney      = 23,
        TooManyDailys       = 26,
        /// <summary>
        /// 27 - "You cannot completed quests once you have reached tired time"
        /// probably have something to do with parental control (and/or the Chinese client)
        /// </summary>
        Tired               = 27,
    };

    public enum QuestPushResponse : byte
    {
        Sharing         = 0,
        CannotTake      = 1,
        AcceptedQuest   = 2,
        RefusedQuest    = 3,
        TooFar          = 4,
        Busy            = 5,
        QuestlogFull    = 6,
        AlreadyHave     = 7,
        AlreadyFinished = 8,
    };

    [Flags]
    public enum QuestFlags : uint
    {
        None            = 0x0000,
        /// <summary>
        /// Stay Alive or else it's failed
        /// </summary>
        Deliver         = 0x0001,
        /// <summary>
        /// Escort and event based Quests
        /// </summary>
        Escort          = 0x0002,
        /// <summary>
        /// Explore Areas
        /// </summary>
        Explore         = 0x0004,
        /// <summary>
        /// Can be shared
        /// </summary>
        Sharable        = 0x0008,
        Exploration     = 0x0010, //not used
        Timed           = 0x0020, // 7632
        Raid            = 0x0040,
        TBCOnly         = 0x0080,
        /// <summary>
        /// Quest needs more than normal quest item drops from mobs, 
        /// maybe it's permanent blue question mark?
        /// </summary>
        DeliverMore     = 0x0100,
        /// <summary>
        /// combined with 0x80
        /// </summary>
        HiddenRewards   = 0x0200,
        Unknown4        = 0x0400,
        TBCRaces        = 0x0800,
        Daily           = 0x1000
    }
}
