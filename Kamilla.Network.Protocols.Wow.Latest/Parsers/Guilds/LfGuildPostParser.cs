using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Guilds
{
    [WowPacketParser(WowOpcodes.SMSG_LF_GUILD_POST)]
    internal sealed class LfGuildPostParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.LookingForGuild; } }

        protected override void InternalParse()
        {
            var flags = (LookingForGuildPostFlags)Reader.ReadByte();
            Output.AppendLine("Flags: " + flags);
            if (flags.HasFlag(LookingForGuildPostFlags.Recruiting))
            {
                Output.AppendLine("Availability Flags: " + (GuildAvailability)Reader.ReadUInt32());
                Output.AppendLine("Comment: " + Reader.ReadCString());
                Output.AppendLine("Roles: " + (GroupRoles)Reader.ReadUInt32());
                Output.AppendLine("Interest: " + (GuildInterest)Reader.ReadUInt32());
                Output.AppendLine("Level Flags: " + (LookingForGuildLevelFlags)Reader.ReadUInt32());
                Output.AppendLine("Unk UInt32: " + Reader.ReadUInt32());
            }
        }
    }
}
