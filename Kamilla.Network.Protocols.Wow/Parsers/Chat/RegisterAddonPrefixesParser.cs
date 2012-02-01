using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Chat
{
    [WowPacketParser(WowOpcodes.CMSG_REGISTER_ADDON_PREFIXES)]
    internal sealed class RegisterAddonPrefixesParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Chat; } }

        protected override void InternalParse()
        {
            var count = Reader.UnalignedReadInt(25);
            Output.AppendLine("Count: " + count);

            var lengths = new int[count];
            for (int i = 0; i < count; i++)
                lengths[i] = Reader.UnalignedReadTinyInt(5);

            var encoding = Encoding.UTF8;
            for (int i = 0; i < count; i++)
                Output.AppendLine("  Prefix: " + encoding.GetString(Reader.ReadBytes(lengths[i])));
        }
    }
}
