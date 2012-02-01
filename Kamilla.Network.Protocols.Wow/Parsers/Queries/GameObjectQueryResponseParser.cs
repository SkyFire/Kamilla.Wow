using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Queries
{
    [WowPacketParser(WowOpcodes.SMSG_GAMEOBJECT_QUERY_RESPONSE)]
    internal sealed class GameObjectQueryResponseParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        GameObjectTemplate m_template;
        public GameObjectTemplate Template
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
            m_template = new GameObjectTemplate();

            m_template.Entry = Reader.ReadInt32();

            Output.AppendLine("Entry:      " + m_template.Entry);

            if (m_template.Entry < 0)
                return;

            m_template.Type = Reader.ReadUInt32();
            m_template.DisplayId = Reader.ReadUInt32();
            for (int i = 0; i < GameObjectTemplate.MaxNames; ++i)
                m_template.Name[i] = Reader.ReadCString();
            m_template.IconName = Reader.ReadCString();
            m_template.CastBarCaption = Reader.ReadCString();
            m_template.UnkString = Reader.ReadCString();
            for (int i = 0; i < GameObjectTemplate.MaxDatas; ++i)
                m_template.Data[i] = Reader.ReadUInt32();
            m_template.Size = Reader.ReadSingle();
            for (int i = 0; i < GameObjectTemplate.MaxQuestItems; ++i)
                m_template.QuestItems[i] = Reader.ReadUInt32();
            m_template.UnkInt = Reader.ReadInt32();

            Output.AppendFormatLine("GO Type:    {0:D} ({0})", (GameObjectTypes)m_template.Type);
            Output.AppendLine("Display ID: " + m_template.DisplayId);
            Output.AppendLine("Name:       " + m_template.Name[0]);
            Output.AppendLine("CastBarCpt: " + m_template.CastBarCaption);
            Output.AppendLine("Icon Name:  " + m_template.IconName);
            Output.AppendLine("UnkString:  " + m_template.UnkString);

            for (int i = 0; i < GameObjectTemplate.MaxDatas; ++i)
                if (m_template.Data[i] != 0)
                    Output.AppendFormatLine(" Data[{0}] = {1}", i, m_template.Data[i]);

            Output.AppendLine("Size: " + m_template.Size);

            for (int i = 0; i < GameObjectTemplate.MaxQuestItems; i++)
                if (m_template.QuestItems[i] != 0)
                    Output.AppendFormatLine(" QuestItem[{0}] = {1}", i, m_template.QuestItems[i]);

            Output.AppendLine("Unk: " + m_template.UnkInt);
        }
    }

    internal class GameObjectTemplate
    {
        public const int MaxNames = 4;
        public const int MaxDatas = 32;
        public const int MaxQuestItems = 6;

        public int Entry;
        public uint Type;
        public uint DisplayId;
        public string[] Name = new string[MaxNames];
        public string IconName;
        public string CastBarCaption;
        public string UnkString;
        public uint[] Data = new uint[MaxDatas];
        public float Size;
        public uint[] QuestItems = new uint[MaxQuestItems];
        public int UnkInt;
    }
}
