using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_SHOWTAXINODES)]
    internal sealed class ShowTaxiNodesParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            uint taxiMaster = Reader.ReadUInt32();
            Output.AppendLine("Taxi Master: " + taxiMaster);
            if (taxiMaster != 0)
            {
                Output.AppendLine(" Guid: " + Reader.ReadGuid());
                Output.AppendLine(" Area: " + (Zones)Reader.ReadUInt32());
            }

            int nBytes = Reader.ReadInt32();
            Output.AppendLine("Mask Bytes: " + nBytes);
            Output.AppendLine("Bytes: " + Reader.ReadBytes(nBytes).ToHexString());
        }
    }
}
