using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Lobby
{
    [WowPacketParser(WowOpcodes.SMSG_ACCOUNT_DATA_TIMES)]
    internal sealed class AccountDataTimesParser : WowPacketParser
    {
        const uint NumAccountDataTypes = (uint)AccountDataType.End;

        protected override void InternalParse()
        {
            Output.AppendLine("Server Time: " + Reader.ReadUInt32().AsUnixTime());
            Output.AppendLine("Unk Byte: " + Reader.ReadByte());
            uint mask = Reader.ReadUInt32();
            Output.AppendLine("Mask: " + (AccountDataTypeMask)mask);

            for (int i = 0; i < NumAccountDataTypes; ++i)
            {
                if ((mask & (1 << i)) != 0)
                    Output.AppendFormatLine("  {0} time: {1}", (AccountDataType)i, Reader.ReadUInt32().AsUnixTime());
            }
        }
    }
}
