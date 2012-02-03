using System;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Lobby
{
    [WowPacketParser(WowOpcodes.SMSG_AUTH_RESPONSE)]
    internal sealed class AuthResponseParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            Output.AppendLine("Response Code: " + (ResponseCodes)Reader.ReadByte());

            var hasAccountInfo = Reader.UnalignedReadBit();
            var isQueued = Reader.UnalignedReadBit();

            if (isQueued)
            {
                Output
                    .AppendLine("Unknown Queue Bool (3.3.0): " + Reader.UnalignedReadBit())
                    .AppendLine("Position In Queue: " + Reader.ReadUInt32());
            }

            if (hasAccountInfo)
            {
                Output
                    .AppendLine("Payed Expansion: " + ((Expansions)Reader.ReadByte()).GetLocalizedName())
                    .AppendLine("Unk UInt32: " + Reader.ReadUInt32())
                    .AppendLine("Account Expansion: " + ((Expansions)Reader.ReadByte()).GetLocalizedName())
                    .AppendLine("Billing Time Rested: " + Reader.ReadUInt32())
                    .AppendLine("Billing Time Flags: " + Reader.ReadByte())
                    .AppendLine("Billing Time Remaining: " + TimeSpan.FromMinutes(Reader.ReadUInt32()));
            }
        }
    }
}
