using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_GROUP_LIST)]
    internal sealed class GroupListParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Loot; } }

        protected override void InternalParse()
        {
            GroupTypeMask typeMask = (GroupTypeMask)Reader.ReadByte();

            Output.AppendLine("Type: " + typeMask);
            Output.AppendLine("Your Group Index: " + Reader.ReadByte());
            Output.AppendLine("Your Flags: " + (GroupMemberFlags)Reader.ReadByte());
            Output.AppendLine("Your Roles: " + (GroupRoles)Reader.ReadByte());

            if (typeMask.HasFlag(GroupTypeMask.DungeonFinder))
            {
                Output.AppendLine("Unknown LFD Byte: " + Reader.ReadByte());
                Output.AppendLine("Unknown LFD UInt: " + Reader.ReadUInt32());
                Output.AppendLine("Unknown LFD Byte: " + Reader.ReadByte());
            }

            Output.AppendLine("Group Guid: " + Reader.ReadGuid());
            Output.AppendLine("Update Counter (?): " + Reader.ReadUInt32());

            Output.AppendLine();

            uint memberCount = Reader.ReadUInt32();
            Output.AppendLine("Member Count: " + memberCount);
            for (uint i = 0; i < memberCount; ++i)
            {
                Output.AppendFormatLine("  Member #{0}: {1} {2}", i, Reader.ReadCString(), Reader.ReadGuid());
                Output.AppendLine("  State: " + (GroupMemberStateMask)Reader.ReadByte());
                Output.AppendLine("  Group Index: " + Reader.ReadByte());
                Output.AppendLine("  Flags: " + (GroupMemberFlags)Reader.ReadByte());
                Output.AppendLine("  Roles: " + (GroupRoles)Reader.ReadByte());
                Output.AppendLine();
            }

            Output.AppendLine("Leader: " + Reader.ReadGuid());

            if (memberCount > 0)
            {
                Output.AppendLine("Loot Method: " + (LootMethod)Reader.ReadByte());
                Output.AppendLine("Looter: " + Reader.ReadGuid());
                Output.AppendLine("Loot Threshold: " + (ItemQuality)Reader.ReadByte());
                Output.AppendLine("Dungeon Difficulty: " + (DungeonDifficulty)Reader.ReadByte());
                Output.AppendLine("Raid Difficulty: " + (RaidDifficulty)Reader.ReadByte());
            }
        }
    }
}
