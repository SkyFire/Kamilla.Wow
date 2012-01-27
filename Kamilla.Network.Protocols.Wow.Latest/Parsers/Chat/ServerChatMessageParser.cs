using Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas.ChatMessages;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Chat
{
    [WowPacketParser(WowOpcodes.SMSG_GM_MESSAGECHAT)]
    [WowPacketParser(WowOpcodes.SMSG_MESSAGECHAT)]
    internal sealed class ServerChatMessageParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Chat; } }

        ServerChatMessage m_message;
        public ServerChatMessage Message
        {
            get
            {
                if (!IsParsed)
                    Parse();

                return m_message;
            }
        }

        protected override void InternalParse()
        {
            m_message = new ServerChatMessage(this.Reader, (WowOpcodes)this.Packet.Opcode);

            Output.Append(m_message.ToString());
        }
    }
}
