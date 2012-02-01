using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Mail
{
    [WowPacketParser(WowOpcodes.SMSG_SEND_MAIL_RESULT)]
    internal sealed class SendMailResultParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Mail; } }

        protected override void InternalParse()
        {
            Output.AppendLine("Mail Id: " + Reader.ReadUInt32());
            MailResponseType type = (MailResponseType)Reader.ReadUInt32();
            Output.AppendLine("Type: " + type);
            MailResponseResult result = (MailResponseResult)Reader.ReadUInt32();
            Output.AppendLine("Result: " + result);

            if (result == MailResponseResult.MAIL_ERR_EQUIP_ERROR)
                Output.AppendLine("Equip Error: " + (InventoryChangeFailure)Reader.ReadUInt32());
            if (type == MailResponseType.MAIL_ITEM_TAKEN)
            {
                Output.AppendLine("Attachment Id: " + Reader.ReadUInt32());
                Output.AppendLine("Count: " + Reader.ReadUInt32());
            }
        }
    }
}
