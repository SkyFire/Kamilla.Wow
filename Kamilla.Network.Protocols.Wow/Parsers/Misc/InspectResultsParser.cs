using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_INSPECT_RESULTS)]
    [WowPacketParser(WowOpcodes.SMSG_INSPECT_RESULTS_UPDATE)]
    internal sealed class InspectResultsParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            bool full = (WowOpcodes)Packet.Opcode == WowOpcodes.SMSG_INSPECT_RESULTS;
            Output.AppendLine("GUID: " + (full ? Reader.ReadGuid() : Reader.ReadPackedGuid()));

            if (full)
            {
                Output.AppendLine("Free Talent Points: " + Reader.ReadUInt32());
                var talentGroupsCount = Reader.ReadByte();
                Output.AppendLine("Spec Count: " + talentGroupsCount);
                Output.AppendLine("Active Spec: " + Reader.ReadByte());

                if (talentGroupsCount > 0)
                {
                    for (byte spec = 0; spec < talentGroupsCount; ++spec)
                    {
                        Output.AppendLine();
                        Output.AppendFormatLine(" Spec {0}, main branch {1}", spec, Reader.ReadUInt32());

                        byte talentsCount = Reader.ReadByte();
                        Output.AppendLine("  Talents: " + talentsCount);

                        for (byte i = 0; i < talentsCount; ++i)
                            Output.AppendFormatLine("   Talent {0}: id {1}, rank {2}", i, Reader.ReadUInt32(), Reader.ReadByte());

                        byte glyphs = Reader.ReadByte();
                        Output.AppendLine("  Glyphs: " + glyphs);

                        for (byte i = 0; i < glyphs; ++i)
                            Output.AppendFormatLine("   Glyph {0}: {1}", i, Reader.ReadUInt16());
                    }
                }

                Output.AppendLine();
            }

            var slotUsedMask = Reader.ReadUInt32();

            for (var i = 0; i < WowPlayer.MaxVisibleItems; ++i)
            {
                if (((1 << i) & slotUsedMask) != 0)
                {
                    Output.AppendFormatLine("Item {0}: entry {1}", i, Reader.ReadUInt32());

                    var enchantmentMask = Reader.ReadUInt16();

                    for (var j = 0; j < WowItem.MaxEnchantments; ++j)
                    {
                        if (((1 << j) & enchantmentMask) != 0)
                        {
                            Output.AppendFormatLine("Item {0}: enchant {1}, id {2}", i, j, Reader.ReadUInt16());
                        }
                    }

                    Output.AppendFormatLine("Item {0}: unk1 {1}", i, Reader.ReadUInt16());
                    Output.AppendFormatLine("Item {0}: unk2 {1}", i, Reader.ReadPackedGuid().Raw);
                    Output.AppendFormatLine("Item {0}: unk3 {1}", i, Reader.ReadUInt32());
                }
            }

            if (full)
            {
                Output.AppendLine();

                Output.AppendLine("Guild: " + Reader.ReadGuid());
                Output.AppendLine("Guild Level: " + Reader.ReadUInt32());
                Output.AppendLine("Guild XP: " + Reader.ReadUInt64());
                Output.AppendLine("Guild Members: " + Reader.ReadUInt32());
            }
        }
    }
}
