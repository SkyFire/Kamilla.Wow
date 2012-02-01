using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Gossip
{
    [WowPacketParser(WowOpcodes.SMSG_TRAINER_LIST)]
    internal sealed class TrainerListParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            TrainerList tl = new TrainerList();

            if (Reader.BaseStream.Length < 5)
                return;

            tl.NpcGuid     = Reader.ReadGuid();
            tl.TrainerType = Reader.ReadUInt32();
            tl.Unk1        = Reader.ReadUInt32();
            tl.SpellsSize  = Reader.ReadUInt32();
            tl.SpellList = new TrainerList.Spells[tl.SpellsSize];

            for (int i = 0; i < tl.SpellsSize; ++i)
            {
                tl.SpellList[i].Spell       = Reader.ReadUInt32();
                tl.SpellList[i].Canlearn    = Reader.ReadByte();
                tl.SpellList[i].SpellCost   = Reader.ReadUInt32();
                tl.SpellList[i].Unk2        = Reader.ReadUInt32();
                tl.SpellList[i].SpellLevel  = Reader.ReadByte();
                tl.SpellList[i].ReqSkill    = Reader.ReadUInt32();
                tl.SpellList[i].ReqSkillValue = Reader.ReadUInt32();
                tl.SpellList[i].PrevId      = Reader.ReadUInt32();
                tl.SpellList[i].Unk3        = Reader.ReadUInt32();
                tl.SpellList[i].Unk4        = Reader.ReadUInt32();
            }

            tl.Title = Reader.ReadCString(); 

            Output.AppendLine("NPC:   " + tl.NpcGuid);
            Output.AppendLine("Title: " + tl.Title);
            Output.AppendLine();
            Output.AppendFormatLine("-----------------------------------------------------------------------------------------------------------");
            Output.AppendFormatLine("| Spell   | SpellCost | ReqSkill | ReqSkillValue | ReqLevel | Learned | PrevId |  Unk2  |  Unk3  |  Unk4  |");
            Output.AppendFormatLine("-----------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < tl.SpellsSize; ++i)
                Output.AppendFormatLine("| {0,-8}| {1,-10}| {2,-9}| {3,-14}| {4,-9}| {5,-8}| {6,-7}| {7,-7}| {8,-7}| {9,-7}|",
                    tl.SpellList[i].Spell,
                    tl.SpellList[i].SpellCost,
                    tl.SpellList[i].ReqSkill,
                    tl.SpellList[i].ReqSkillValue,
                    tl.SpellList[i].SpellLevel,
                    tl.SpellList[i].Canlearn,
                    tl.SpellList[i].PrevId,
                    tl.SpellList[i].Unk2,
                    tl.SpellList[i].Unk3,
                    tl.SpellList[i].Unk4
                    );
            Output.AppendFormatLine("-----------------------------------------------------------------------------------------------------------");

            //SqlOutput.AppendFormatLine(
            //    "DELETE FROM `npc_trainer` WHERE `entry` = {0};", tl.NpcGuid.Entry);
            //SqlOutput.AppendFormatLine(
            //    "INSERT INTO `npc_trainer` (`entry`, `spell`, `spellcost`, `reqskill`, `reqskillvalue`, `reqlevel`) VALUE ");

            //for (int i = 0; i < tl.SpellsSize; ++i)
            //{
            //    SqlOutput.AppendFormatLine("({0}, {1}, {2}, {3}, {4}, {5}){6}", 
            //        tl.NpcGuid.Entry, 
            //        tl.SpellList[i].Spell, 
            //        tl.SpellList[i].SpellCost, 
            //        tl.SpellList[i].ReqSkill, 
            //        tl.SpellList[i].ReqSkillValue, 
            //        tl.SpellList[i].SpellLevel,
            //        (i < tl.SpellsSize - 1) ? "," : ";");
            //}
        }
    }

    class TrainerList
    {
        public WowGuid NpcGuid;
        public uint TrainerType;
        public uint Unk1;
        public uint SpellsSize;
        public struct Spells
        {
            public uint Spell;
            public byte Canlearn;
            public uint SpellCost;
            public uint Unk2;
            public byte SpellLevel;
            public uint ReqSkill;
            public uint ReqSkillValue;
            public uint PrevId;
            public uint Unk3;
            public uint Unk4;
        }
        public string Title;

        public Spells[] SpellList; 
    }
}
