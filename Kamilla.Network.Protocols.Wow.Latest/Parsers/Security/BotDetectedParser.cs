using System;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Security
{
    [WowPacketParser(WowOpcodes.CMSG_BOT_DETECTED)]
    [WowPacketParser(WowOpcodes.CMSG_BOT_DETECTED2)]
    internal sealed class BotDetectedParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Security; } }

        protected override void InternalParse()
        {
            throw new NotImplementedException();
        }
    }
}
