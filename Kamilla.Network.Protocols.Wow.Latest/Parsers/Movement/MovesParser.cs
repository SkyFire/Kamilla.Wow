using System;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Movement
{
    [WowPacketParser(WowOpcodes.SMSG_MOVES)]
    internal sealed class MovesParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.PlayerMovement; } }

        protected override void InternalParse()
        {
            throw new NotImplementedException();
        }
    }
}
