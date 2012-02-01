using System;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Movement
{
    [WowPacketParser(WowOpcodes.SMSG_COMPOUND_MOVE)]
    internal sealed class CompoundMoveParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.MonsterMovement; } }

        protected override void InternalParse()
        {
            throw new NotImplementedException();
        }
    }
}
