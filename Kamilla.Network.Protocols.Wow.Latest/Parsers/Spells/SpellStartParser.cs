using Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Spells
{
    [WowPacketParser(WowOpcodes.SMSG_SPELL_START)]
    internal sealed class SpellStartParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Spells; } }

        protected override void InternalParse()
        {
            var start = new SpellStart();
            start.Read(Reader);

            start.ToString(Output);
        }
    }
}
