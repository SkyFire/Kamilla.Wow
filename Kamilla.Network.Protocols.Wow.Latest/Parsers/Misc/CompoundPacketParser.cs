using System;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_COMPOUND_PACKET)]
    internal sealed class CompoundPacketParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            throw new NotImplementedException();
        }
    }
}
