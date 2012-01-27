using Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Spells
{
    [WowPacketParser(WowOpcodes.SMSG_SPELL_GO)]
    internal sealed class SpellGoParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Spells; } }

        protected override void InternalParse()
        {
            var go = new SpellGo(Reader);

            go.ToString(Output);
        }
    }
}
