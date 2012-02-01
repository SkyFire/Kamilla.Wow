using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Queries
{
    [WowPacketParser(WowOpcodes.SMSG_PET_NAME_QUERY_RESPONSE)]
    internal sealed class PetNameQueryResponseParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            Output.AppendLine("Pet Number: " + this.Reader.ReadUInt32());
            Output.AppendLine("Name: " + this.Reader.ReadCString());
            Output.AppendLine("Time: " + this.Reader.ReadUInt32().AsUnixTime());
            bool declined = Reader.ReadBoolean();
            Output.AppendLine("Declined: " + declined);
            if (declined)
            {
                for (int i = 0; i < 5; ++i)
                    Output.AppendFormatLine("  Declined Name {1}: {0}", Reader.ReadCString(), i);
            }
        }
    }
}
