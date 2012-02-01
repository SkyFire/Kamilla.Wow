using System;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Guilds
{
    [WowPacketParser(WowOpcodes.SMSG_GUILD_NEWS)]
    internal sealed class GuildQueryNewsParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            uint count = Reader.ReadUInt32();
            Output.AppendLine("Count: " + count);

            for (uint i = 0; i < count; ++i)
            {
                uint count2 = Reader.ReadUInt32();
                Output.AppendFormatLine("  {1}) Additional Guids: {0}", count2, i);

                for (uint j = 0; j < count2; ++j)
                    Output.AppendLine("       Guid: " + Reader.ReadGuid());
            }

            for (uint i = 0; i < count; ++i)
                Output.AppendFormatLine("  {1}) Unk: {0}", Reader.ReadUInt32(), i);
            for (uint i = 0; i < count; ++i)
                Output.AppendFormatLine("  {1}) News Type: {0} ({0:D})", (GuildNewsTypes)Reader.ReadUInt32(), i);
            for (uint i = 0; i < count; ++i)
                Output.AppendFormatLine("  {1}) Time: {0}", Reader.ReadUInt32().AsTimeBitFields(), i);
            for (uint i = 0; i < count; ++i)
            {
                Output.AppendFormatLine("  {1}) Value 1: {0}", Reader.ReadUInt32(), i);
                Output.AppendFormatLine("  {1}) Value 2: {0}", Reader.ReadUInt32(), i);
            }
            for (uint i = 0; i < count; ++i)
                Output.AppendFormatLine("  {1}) Unk: {0}", TimeSpan.FromSeconds(Reader.ReadUInt32()), i);
            for (uint i = 0; i < count; ++i)
                Output.AppendFormatLine("  {1}) Source Guid: {0}", Reader.ReadGuid(), i);
        }
    }
}
