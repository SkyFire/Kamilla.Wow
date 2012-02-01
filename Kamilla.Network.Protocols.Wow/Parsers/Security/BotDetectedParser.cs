using System;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Security
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
