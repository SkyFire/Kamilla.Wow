using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Queries
{
    [WowPacketParser(WowOpcodes.SMSG_CREATURE_QUERY_RESPONSE)]
    internal sealed class CreatureQueryResponseParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        CreatureTemplate m_template;
        public CreatureTemplate Template
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
            m_template = new CreatureTemplate();

            m_template.Entry = Reader.ReadInt32();
            
            Output.AppendLine("Creature Entry: " + m_template.Entry);
            
            if (m_template.Entry < 0)
                return;

            for (int i = 0; i < CreatureTemplate.MaxNames; ++i)
                m_template.Name[i] = Reader.ReadCString();

            m_template.SubName  = Reader.ReadCString();
            m_template.IconName = Reader.ReadCString();

            m_template.Unknown  = Reader.ReadUInt32();
            m_template.TypeFlag = Reader.ReadUInt32();
            m_template.Type     = Reader.ReadUInt32();
            m_template.Family   = Reader.ReadInt32();
            m_template.Rank     = Reader.ReadUInt32();

            for (int i = 0; i < CreatureTemplate.MaxKillCredits; ++i)
                m_template.KillCredit[i] = Reader.ReadUInt32();

            for (int i = 0; i < CreatureTemplate.MaxModelIds; ++i)
                m_template.ModelId[i] = Reader.ReadUInt32();

            m_template.HealthModifier = Reader.ReadSingle();
            m_template.PowerModifier  = Reader.ReadSingle();
            m_template.RacialLeader   = Reader.ReadSByte();

            for (int i = 0; i < CreatureTemplate.MaxQuestItems; ++i)
                m_template.QuestItem[i] = Reader.ReadUInt32();

            m_template.MovementId = Reader.ReadUInt32();
            m_template.Unk        = Reader.ReadInt32();

            for (int i = 0; i < CreatureTemplate.MaxNames; i++)
			{
                if (!string.IsNullOrEmpty(m_template.Name[i]))
                    Output.AppendFormatLine("Creature Name {0}: {1}", i, m_template.Name[i]);
			}
            Output.AppendLine("SubName:        " + m_template.SubName);
            Output.AppendLine("nIconName:      " + m_template.IconName);
            Output.AppendLine("Unknown 4.2:    " + m_template.Unknown);
            Output.AppendLine("Flags:          " + m_template.TypeFlag);
            Output.AppendFormatLine("Type:          ({0}) {1}", m_template.Type,   (CreatureType)m_template.Type);
            Output.AppendFormatLine("Family:        ({0}) {1}", m_template.Family, (CreatureFamilies)m_template.Family);
            Output.AppendFormatLine("Rank:          ({0}) {1}", m_template.Rank,   (CreatureEliteType)m_template.Rank);
            for (int i = 0; i < CreatureTemplate.MaxKillCredits; ++i)
                Output.AppendFormatLine("KillCredit{0}:    {1}", i, m_template.KillCredit[i]);

            Output.AppendFormatLine("ModelID_A:      {0} ModelID_A2: {1} ModelID_H: {2} ModelID_H2: {3}", m_template.ModelId[0], m_template.ModelId[1], m_template.ModelId[2], m_template.ModelId[3]);
            Output.AppendLine("HealthModifier: " + m_template.HealthModifier);
            Output.AppendLine("PowerModifier:  " +  m_template.PowerModifier);
            Output.AppendLine("RacialLeader:   " +  m_template.RacialLeader);

            for (int i = 0; i < CreatureTemplate.MaxQuestItems; ++i)
                Output.AppendFormatLine("QuestItem_{0}:  {1}", i, m_template.QuestItem[i]);

            Output.AppendLine("MovementId:     " + m_template.MovementId);
            Output.AppendLine("Unk:            " + m_template.Unk);
        }
    }

    internal class CreatureTemplate
    {
        public const int MaxNames = 8;
        public const int MaxKillCredits = 2;
        public const int MaxModelIds = 4;
        public const int MaxQuestItems = 6;

        public int      Entry;
        public string[] Name        = new string[MaxNames];
        public string   SubName;
        public string   IconName;
        public uint     Unknown;
        public uint     TypeFlag;
        public uint     Type;
        public int      Family;
        public uint     Rank;
        public uint[]   KillCredit  = new uint[MaxKillCredits];
        public uint[]   ModelId     = new uint[MaxModelIds];
        public float    HealthModifier;
        public float    PowerModifier;
        public sbyte    RacialLeader;
        public uint[]   QuestItem   = new uint[MaxQuestItems];
        public uint     MovementId;
        public int      Unk;
    }
}
