using Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Lobby
{
    [WowPacketParser(WowOpcodes.SMSG_CONNECT_TO)]
    internal sealed class ConnectToParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            var redirect = new ConnectToPacket(Reader);

            redirect.ToString(this.Output);

            this.ContainedData.Add(redirect.FixedBlob);
        }
    }
}
