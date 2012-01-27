using System;

namespace Kamilla.Network.Protocols.Wow.Latest
{
    // TODO: fix names

    /// <summary>
    /// Defines the order in which the groups are displayed and used.
    /// </summary>
    enum PacketGroupIds
    {
        Auction = 0,
        Calendar,
        Chat,
        CombatLog,
        GMTickets,
        Group,
        LookingForGroup,
        LookingForGuild,
        Loot,
        Mail,
        MonsterMovement,
        ObjectUpdates,
        PlayerMovement,
        Queries,
        Security,
        Spells,
        Trade,
    }

    /// <summary>
    /// Specifies to which group a packet belongs.
    /// </summary>
    [Flags]
    public enum PacketGroups : ulong
    {
        /// <summary>
        /// Specifies ungrouped packets.
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies query packets.
        /// </summary>
        Queries = 1UL << PacketGroupIds.Queries,

        /// <summary>
        /// Specifies warden and other cheat-death packets mostly.
        /// </summary>
        [LocalizedName("Security")]
        Security = 1UL << PacketGroupIds.Security,

        /// <summary>
        /// Specifies combat log packets.
        /// </summary>
        [LocalizedName("Combat Log")]
        CombatLog = 1UL << PacketGroupIds.CombatLog,

        /// <summary>
        /// Specifies monster movement opcodes.
        /// </summary>
        [LocalizedName("Monster Movement")]
        MonsterMovement = 1UL << PacketGroupIds.MonsterMovement,

        /// <summary>
        /// Specifies player movement opcodes.
        /// </summary>
        [LocalizedName("Player Movement")]
        PlayerMovement = 1UL << PacketGroupIds.PlayerMovement,

        /// <summary>
        /// Specifies chat message opcodes.
        /// </summary>
        [LocalizedName("Chat")]
        Chat = 1UL << PacketGroupIds.Chat,

        /// <summary>
        /// Specifies spell packets.
        /// </summary>
        Spells = 1UL << PacketGroupIds.Spells,

        /// <summary>
        /// Specifies object update packets.
        /// </summary>
        [LocalizedName("Object Updates")]
        ObjectUpdates = 1UL << PacketGroupIds.ObjectUpdates,

        /// <summary>
        /// Specifies calendar packets.
        /// </summary>
        Calendar = 1UL << PacketGroupIds.Calendar,

        /// <summary>
        /// Specifies GM ticket packets.
        /// </summary>
        [LocalizedName("GM Tickets")]
        GMTickets = 1UL << PacketGroupIds.GMTickets,

        /// <summary>
        /// Specifies mail packets.
        /// </summary>
        Mail = 1UL << PacketGroupIds.Mail,

        /// <summary>
        /// Specifies trade packets.
        /// </summary>
        Trade = 1UL << PacketGroupIds.Trade,

        /// <summary>
        /// Specifies auction packets.
        /// </summary>
        Auction = 1UL << PacketGroupIds.Auction,

        /// <summary>
        /// Specifies loot packets.
        /// </summary>
        Loot = 1UL << PacketGroupIds.Loot,

        /// <summary>
        /// Specifies group packets.
        /// </summary>
        [LocalizedName("Party / Raid")]
        Group = 1UL << PacketGroupIds.Group,

        /// <summary>
        /// Specified guild recruitment packets.
        /// </summary>
        [LocalizedName("Looking For Guild")]
        LookingForGuild = 1UL << PacketGroupIds.LookingForGuild,

        [LocalizedName("Looking For Group")]
        LookingForGroup = 1UL << PacketGroupIds.LookingForGroup,
    }
}
