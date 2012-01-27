using Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_LOOT_RESPONSE)]
    internal sealed class LootResponseParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Loot; } }

        protected override void InternalParse()
        {
            var loot = new Loot(Reader);
            loot.ToString(Output);
        }
    }
}
