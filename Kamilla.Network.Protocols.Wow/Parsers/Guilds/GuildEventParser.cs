using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Guilds
{
    [WowPacketParser(WowOpcodes.SMSG_GUILD_EVENT)]
    internal sealed class GuildEventParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            GuildEvents _event = (GuildEvents)Reader.ReadByte();
            Output.AppendFormatLine("Event: {0} ({0:D})", _event);

            byte nStrings = Reader.ReadByte();
            Output.AppendLine("Strings: " + nStrings);
            for (byte i = 0; i < nStrings; ++i)
                Output.AppendFormatLine("  {0}) {1}", i, Reader.ReadCString());

            switch (_event)
            {
                case GuildEvents.GE_JOINED:
                case GuildEvents.GE_LEFT:
                case GuildEvents.GE_SIGNED_ON:
                case GuildEvents.GE_SIGNED_OFF:
                case GuildEvents.GE_REMOVED:
                    Output.AppendLine("Guid: " + Reader.ReadGuid());
                    break;
            }
        }
    }
}
