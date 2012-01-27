using Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Spells
{
    [WowPacketParser(WowOpcodes.MSG_CHANNEL_START)]
    internal sealed class ChannelStartParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Spells; } }

        protected override void InternalParse()
        {
            ChannelStart cs = new ChannelStart();
            cs.Read(Reader);
            cs.ToString(Output);
        }
    }
}
