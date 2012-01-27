using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    /// <summary>
    /// Guild News added in patch 4.0.1 (Cataclysm Systems).
    /// </summary>
    public enum GuildNewsTypes
    {
        /// <summary>
        /// Guild achievement earned: [value1]
        /// </summary>
        GuildAchievementEarned      = 0,
        /// <summary>
        /// [source] earned the achievement [value1]
        /// </summary>
        MemberAchievementEarned     = 1,
        /// <summary>
        /// [guild] defeated [dungeonid?]
        /// </summary>
        RaidEncounterDefeated       = 2,
        /// <summary>
        /// [source] looted [value1]
        /// </summary>
        EpicItemLooted              = 3,
        /// <summary>
        /// [source] crafted [value1]
        /// </summary>
        EpicItemCrafted             = 4,
        /// <summary>
        /// [source] purchased [value1]
        /// </summary>
        EpicItemPurchased           = 5,
        /// <summary>
        /// [guild] has reached level [value1]!
        /// </summary>
        GuildLevelReached           = 6,
        /// <summary>
        /// [guild] has been founded.
        /// </summary>
        GuildFounded                = 7,
    }

    public enum GuildEvents
    {
        GE_PROMOTION                    = 0x01,
        GE_DEMOTION                     = 0x02,
        GE_MOTD                         = 0x03,
        GE_JOINED                       = 0x04,
        GE_LEFT                         = 0x05,
        GE_REMOVED                      = 0x06,
        GE_LEADER_IS                    = 0x07,
        GE_LEADER_CHANGED               = 0x08,
        GE_DISBANDED                    = 0x09,
                                                                // 0x0B-0x0F causes client to send CMSG_GUILD_GET_RANKS and 3 more opcodes
        GE_SIGNED_ON                    = 0x10,                 // ERR_FRIEND_ONLINE_SS
        GE_SIGNED_OFF                   = 0x11,                 // ERR_FRIEND_OFFLINE_S
        GE_GUILDBANKBAGSLOTS_CHANGED    = 0x12,                 // EVENT_GUILDBANKBAGSLOTS_CHANGED
        GE_BANKTAB_PURCHASED            = 0x13,                 // EVENT_GUILDBANK_UPDATE_TABS
        GE_UNK5                         = 0x14,                 // EVENT_GUILDBANK_UPDATE_TABS
        GE_GUILDBANK_UPDATE_MONEY       = 0x15,                 // EVENT_GUILDBANK_UPDATE_MONEY, string 0000000000002710 is 1 gold
        GE_GUILD_BANK_MONEY_WITHDRAWN   = 0x16,                 // MSG_GUILD_BANK_MONEY_WITHDRAWN
        GE_GUILDBANK_TEXT_CHANGED       = 0x17,                 // EVENT_GUILDBANK_TEXT_CHANGED
    }

    [Flags]
    public enum GuildBankRights
    {
        None = 0x00,
        ViewTab = 0x01,
        DepositItem = 0x02,
        UpdateText = 0x04,

        All = -1,
    }

    [Flags]
    public enum GuildRankRights
    {
        GR_RIGHT_EMPTY              = 0x00000040,
        GR_RIGHT_GCHATLISTEN        = 0x00000041,
        GR_RIGHT_GCHATSPEAK         = 0x00000042,
        GR_RIGHT_OFFCHATLISTEN      = 0x00000044,
        GR_RIGHT_OFFCHATSPEAK       = 0x00000048,
        GR_RIGHT_PROMOTE            = 0x000000C0,
        GR_RIGHT_DEMOTE             = 0x00000140,
        GR_RIGHT_INVITE             = 0x00000050,
        GR_RIGHT_REMOVE             = 0x00000060,
        GR_RIGHT_SETMOTD            = 0x00001040,
        GR_RIGHT_EPNOTE             = 0x00002040,
        GR_RIGHT_VIEWOFFNOTE        = 0x00004040,
        GR_RIGHT_EOFFNOTE           = 0x00008040,
        GR_RIGHT_MODIFY_GUILD_INFO  = 0x00010040,
        GR_RIGHT_WITHDRAW_GOLD_LOCK = 0x00020000,               // remove money withdraw capacity
        GR_RIGHT_WITHDRAW_REPAIR    = 0x00040000,               // withdraw for repair
        GR_RIGHT_WITHDRAW_GOLD      = 0x00080000,               // withdraw gold
        GR_RIGHT_CREATE_GUILD_EVENT = 0x00100000,               // wotlk
    }

    /// <summary>
    /// Used in <see href="Kamilla.Network.Protocols.Wow.Latest.WowOpcodes.SMSG_LF_GUILD_POST_UPDATE"/>.
    /// </summary>
    [Flags]
    public enum LookingForGuildPostFlags : byte
    {
        Listed = 0x40,
        Recruiting = 0x80,
    }

    [Flags]
    public enum GuildAvailability : uint
    {
        Weekdays = 0x01,
        Weekends = 0x02,
    }

    [Flags]
    public enum GuildInterest : uint
    {
        Quests      = 0x01,
        Dungeons    = 0x02,
        Raids       = 0x04,
        PvP         = 0x08,
        RP          = 0x10,
    }

    [Flags]
    public enum LookingForGuildLevelFlags : uint
    {
        AnyLevel = 0x01,
        MaxLevel = 0x02,
    }
}
