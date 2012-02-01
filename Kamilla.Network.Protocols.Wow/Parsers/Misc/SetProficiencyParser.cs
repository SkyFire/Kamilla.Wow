using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_SET_PROFICIENCY)]
    internal sealed class SetProficiencyParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            var type = (ItemClass)Reader.ReadByte();
            Output.AppendFormatLine("Type: {0} ({0:D})", type);
            if (type == ItemClass.Armor)
                Output.AppendFormatLine("Value: {0} (0x{0:X})", (ItemSubClassArmorMask)Reader.ReadUInt32());
            else
                Output.AppendFormatLine("Value: {0} (0x{0:X})", (ItemSubClassWeaponMask)Reader.ReadUInt32());
        }
    }
}
