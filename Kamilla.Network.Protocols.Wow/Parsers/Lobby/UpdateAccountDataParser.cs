﻿using System;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Lobby
{
    [WowPacketParser(WowOpcodes.SMSG_UPDATE_ACCOUNT_DATA)]
    internal sealed class UpdateAccountDataParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            throw new NotImplementedException();
        }
    }
}
