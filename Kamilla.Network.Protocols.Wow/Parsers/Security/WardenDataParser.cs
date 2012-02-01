using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Security
{
    [WowPacketParser(WowOpcodes.CMSG_WARDEN_DATA)]
    [WowPacketParser(WowOpcodes.SMSG_WARDEN_DATA)]
    internal sealed class WardenDataParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Security; } }

        protected override void InternalParse()
        {
            Reader.Skip(Reader.RemainingLength);
        }
    }
}
