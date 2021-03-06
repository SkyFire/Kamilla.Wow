﻿using System;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Security
{
    [WowPacketParser(WowOpcodes.SMSG_CHECK_FOR_BOTS)]
    internal sealed class CheckForBotsParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Security; } }

        protected override void InternalParse()
        {
            throw new NotImplementedException();
        }
    }
}
