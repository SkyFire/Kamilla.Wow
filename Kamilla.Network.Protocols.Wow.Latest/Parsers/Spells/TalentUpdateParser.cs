using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Spells
{
    [WowPacketParser(WowOpcodes.SMSG_TALENT_UPDATE)]
    internal sealed class TalentUpdateParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Spells; } }

        protected override void InternalParse()
        {
            byte isPet = Reader.ReadByte();
            Output.AppendLine("IsPet: " + isPet);

            if (isPet != 0)
                ReadPet();
            else
                ReadPlayer();
        }

        void ReadPet()
        {
            Output.AppendLine("Unspent Talent Points: " + Reader.ReadUInt32());
            byte nTalents = Reader.ReadByte();
            Output.AppendLine("Talent Count: " + nTalents);

            for (byte i = 0; i < nTalents; ++i)
                Output.AppendFormatLine("  Talent Id: {0}, Rank: {1}", Reader.ReadUInt32(), Reader.ReadByte());
        }

        void ReadPlayer()
        {
            Output.AppendLine();
            Output.AppendLine("Unspent Talent Points: " + Reader.ReadUInt32());
            byte nSpecs;
            Output.AppendLine("Spec Count: " + (nSpecs = Reader.ReadByte()));
            Output.AppendLine("Current Spec: " + Reader.ReadByte());

            for (byte i = 0; i < nSpecs; ++i)
            {
                Output.AppendFormatLine(" Spec {0}:", i);
                Output.AppendLine("   Unspent Talent Points: " + Reader.ReadUInt32());

                byte nTalents = Reader.ReadByte();
                Output.AppendLine("   Talent Count: " + nTalents);

                for (byte j = 0; j < nTalents; ++j)
                    Output.AppendFormatLine("    Talent Id: {0}, Rank: {1}", Reader.ReadUInt32(), Reader.ReadByte());

                byte nGlyphs = Reader.ReadByte();
                Output.AppendLine("   Glyph Count: " + nGlyphs);

                for (byte j = 0; j < nGlyphs; ++j)
                    Output.AppendLine("    Glyph: " + Reader.ReadUInt16());
            }
        }
    }
}
