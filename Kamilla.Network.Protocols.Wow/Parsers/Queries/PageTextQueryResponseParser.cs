using Kamilla;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Queries
{
    [WowPacketParser(WowOpcodes.SMSG_PAGE_TEXT_QUERY_RESPONSE)]
    internal sealed class PageTextQueryResponseParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        PageText m_template;
        public PageText Template
        {
            get
            {
                if (!IsParsed)
                    Parse();

                return m_template;
            }
        }

        protected override void InternalParse()
        {
            m_template = new PageText();

            m_template.Entry = Reader.ReadInt32();

            Output.AppendLine("Entry:      " + m_template.Entry);

            if (m_template.Entry < 0)
                return;

            m_template.Text = Reader.ReadCString();
            m_template.NextPage = Reader.ReadUInt32();

            Output.AppendLine("Text:      " + m_template.Text);
            Output.AppendLine("Next Page: " + m_template.NextPage);
        }
    }

    internal class PageText
    {
        public int Entry;
        public string Text;
        public uint NextPage;
    }
}
