using System.Globalization;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Gossip
{
    [WowPacketParser(WowOpcodes.SMSG_NPC_TEXT_UPDATE)]
    internal sealed class NpcTextUpdateParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            int id = Reader.ReadInt32();
            if (id < 0)
                return;

            var nt = new NpcText();

            nt.Id = (uint)id;
            Output.AppendLine("ID: " + nt.Id);

            for (int i = 0; i < 8; ++i)
            {
                nt.Variant[i].Prob  = Reader.ReadSingle();
                nt.Variant[i].Text0 = Reader.ReadCString();
                nt.Variant[i].Text1 = Reader.ReadCString();
                nt.Variant[i].Lang  = Reader.ReadUInt32();
                nt.Variant[i].Emote = new uint[6];
                for (int j = 0; j < 6; ++j)
                    nt.Variant[i].Emote[j] = Reader.ReadUInt32();
            }

            for (int i = 0; i < 8; ++i)
            {
                Output.AppendFormatLine("Prob_{0}:    {1}", i, nt.Variant[i].Prob);
                Output.AppendFormatLine("Text_{0}_0:  {1}", i, nt.Variant[i].Text0);
                Output.AppendFormatLine("Text_{0}_1:  {1}", i, nt.Variant[i].Text1);
                Output.AppendFormatLine("Lang_{0}:    {1}", i, nt.Variant[i].Lang);
                for (int j = 0; j < 6; ++j)
                    Output.AppendFormatLine("Emote_{0}_{1}: {2}", i, j, nt.Variant[i].Emote[j]);
            }
        }
    }

    class NpcText
    {
        public uint         Id;
        public Variants[]   Variant = new Variants[8];

        public struct Variants
        {
            public float  Prob;
            public string Text0;
            public string Text1;
            public uint   Lang;
            public uint[] Emote;
        }
    }
}
