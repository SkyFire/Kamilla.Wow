using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Mail
{
    [WowPacketParser(WowOpcodes.SMSG_MAIL_LIST_RESULT)]
    internal sealed class MailListResultParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Mail; } }

        protected override void InternalParse()
        {
            Output.AppendLine("Real Mail Count: " + Reader.ReadUInt32());
            byte count = Reader.ReadByte();
            Output.AppendLine("Shown Mail Count: " + count);

            for (byte i = 0; i < count; ++i)
            {
                Output.AppendLine();
                Output.AppendLine("  Data Size: " + Reader.ReadUInt16());
                Output.AppendLine("  Message Id: " + Reader.ReadUInt32());
                MailType type;
                Output.AppendLine("  Type: " + (type = (MailType)Reader.ReadByte()));

                switch (type)
                {
                    case MailType.Normal:
                        Output.AppendLine("  Player Guid: " + Reader.ReadGuid());
                        break;
                    case MailType.Creature:
                    case MailType.GameObject:
                    case MailType.Auction:
                    case MailType.Item:
                        Output.AppendLine("  Entry: " + Reader.ReadUInt32());
                        break;
                }

                Output.AppendLine("  COD: " + (Money)Reader.ReadUInt64());
                Output.AppendLine("  Unk: " + Reader.ReadUInt32());
                Output.AppendLine("  Stationary: " + (MailStationery)Reader.ReadUInt32());
                Output.AppendLine("  Money: " + (Money)Reader.ReadUInt64());
                Output.AppendLine("  Flags: " + (MailFlags)Reader.ReadUInt32());
                Output.AppendLine("  Hours Left: " + Reader.ReadSingle());
                Output.AppendLine("  Template: " + Reader.ReadUInt32());
                Output.AppendLine("  Subject: " + Reader.ReadCString());
                Output.AppendLine("  Body: " + Reader.ReadCString());

                byte item_count = Reader.ReadByte();
                Output.AppendLine("  Items: " + item_count);
                for (byte j = 0; j < item_count; ++j)
                {
                    Output.AppendLine();
                    Output.AppendLine("    Index: " + Reader.ReadByte());
                    Output.AppendFormatLine("    AttachmentId: {0}  Entry: {1}", Reader.ReadUInt32(), Reader.ReadUInt32());

                    for (int k = 0; k < ItemEnchantmentInfo.MaxItemEnchantments; ++k)
                    {
                        var ench = Reader.ReadStruct<ItemEnchantmentInfo>();
                        if (ench.Id != 0)
                            Output.AppendFormatLine("    Enchantment {0}: {1}", k, ench);
                    }

                    Output.AppendLine("    Random Property: " + Reader.ReadUInt32());
                    Output.AppendLine("    Suffix Factor: " + Reader.ReadUInt32());
                    Output.AppendLine("    Stack Count: " + Reader.ReadUInt32());
                    Output.AppendLine("    Charges: " + Reader.ReadUInt32());
                    Output.AppendLine("    Max Durability: " + Reader.ReadUInt32());
                    Output.AppendLine("    Current Durability: " + Reader.ReadUInt32());
                    Output.AppendLine("    Unk: " + Reader.ReadByte());
                }
            }
        }
    }
}
