using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Guilds
{
    [WowPacketParser(WowOpcodes.SMSG_GUILD_KNOWN_RECIPES)]
    internal sealed class GuildQueryRecipesParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            var reader = this.Reader;
            uint count = reader.ReadUInt32();
            Output.AppendLine("Professions: " + count);

            for (uint i = 0; i < count; ++i)
            {
                Output.AppendFormat("   {0}) Members: ", i);
                reader.ReadBytes(300).ToHexString(Output);
                Output.AppendLine();

                Output.AppendFormatLine("   {0}) Profession: {1}", i, reader.ReadUInt32());
            }
        }
    }
}
