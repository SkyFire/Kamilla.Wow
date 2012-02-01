using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_SETUP_RESEARCH_HISTORY)]
    internal sealed class ResearchHistoryParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            var reader = this.Reader;
            uint count = reader.ReadUInt32();
            Output.AppendLine("Count: " + count);

            for (uint i = 0; i < count; ++i)
                Output.AppendFormatLine("  Project: {1} Field1: {0} Field3: {2}",
                    reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
        }
    }
}
