using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Spells
{
    [WowPacketParser(WowOpcodes.SMSG_CAST_FAILED)]
    internal sealed class CastFailedParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Spells; } }

        protected override void InternalParse()
        {
            Output.AppendLine("Cast Id: " + Reader.ReadByte());
            Output.AppendLine("Spell Id: " + Reader.ReadUInt32());
            Output.AppendLine("Reason: " + (SpellFailedReason)Reader.ReadByte());

            if (!Reader.IsRead)
                Output.AppendLine("Value 1: " + Reader.ReadUInt32());

            if (!Reader.IsRead)
                Output.AppendLine("Value 2: " + Reader.ReadUInt32());
        }
    }
}
