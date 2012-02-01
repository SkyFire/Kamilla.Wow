using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Gossip
{
    // TODO: redo
    [WowPacketParser(WowOpcodes.SMSG_QUESTGIVER_OFFER_REWARD)]
    internal sealed class QuestGiverOfferRewardParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            OfferReward or = new OfferReward();

            if (Reader.BaseStream.Length < 5)
                return;

            or.Guid             = Reader.ReadGuid();
            or.Entry            = Reader.ReadUInt32();
            or.Title            = Reader.ReadCString();
            or.OfferRewardText  = Reader.ReadCString();
            or.UnkText1         = Reader.ReadCString(); // 13329
            or.UnkText2         = Reader.ReadCString(); // 13329
            or.UnkText3         = Reader.ReadCString(); // 13329
            or.UnkText4         = Reader.ReadCString(); // 13329
            or.Unk9             = Reader.ReadUInt32();  // 13329
            or.Unk10            = Reader.ReadUInt32();  // 13329
            or.EnableNext       = Reader.ReadByte();
            or.Flags            = Reader.ReadUInt32();
            or.SuggestedPlayers = Reader.ReadUInt32();
            or.EmoteCount       = Reader.ReadUInt32();
            or.offerRevardEmote = new OfferReward.OfferRewardEm[4];
            for (int i = 0; i < or.EmoteCount; ++i)
            {
                or.offerRevardEmote[i].OfferRewardEmoteDelay = Reader.ReadUInt32();
                or.offerRevardEmote[i].OfferRewardEmote      = Reader.ReadUInt32();
            }
 
            or.RewChoiceItemsCount = Reader.ReadUInt32();
 
            for (int i = 0; i < 6; ++i)
                or.RewChoiceItemId[i]    = Reader.ReadUInt32();
            for (int i = 0; i < 6; ++i)
                or.RewChoiceItemCount[i] = Reader.ReadUInt32();
            for (int i = 0; i < 6; ++i)
                or.DisplayInfoID1[i]     = Reader.ReadUInt32();
 
            or.RewItemsCount = Reader.ReadUInt32();
 
            for (int i = 0; i < 4; ++i)
                or.RewItemId[i]      = Reader.ReadUInt32();
            for (int i = 0; i < 4; ++i)
                or.RewItemCount[i] = Reader.ReadUInt32();
            for (int i = 0; i < 4; ++i)
                or.DisplayInfoID2[i] = Reader.ReadUInt32();
 
            or.Unk25              = Reader.ReadUInt32();
            or.Unk26              = Reader.ReadUInt32();
            or.RewOrReqMoney      = Reader.ReadUInt32();
            or.XPValue            = Reader.ReadUInt32();
            or.RewHonorAddition   = Reader.ReadUInt32();
            or.RewHonorMultiplier = Reader.ReadSingle();
            or.Unk31              = Reader.ReadUInt32();
            or.Unk32              = Reader.ReadUInt32();
 
            for (int i = 0; i < 5; ++i)
                or.RewRepFaction[i] = Reader.ReadUInt32();
            for (int i = 0; i < 5; ++i)
                or.RewRepValueId[i] = Reader.ReadInt32();
            for (int i = 0; i < 5; ++i)
                or.RewRepValue[i]   = Reader.ReadInt32();
 
            or.unk36 = Reader.ReadUInt32();
            or.unk37 = Reader.ReadUInt32();
 
            for (int i = 0; i < 4; ++i)
                or.unk38[i] = Reader.ReadInt32();
            for (int i = 0; i < 4; ++i)
                or.unk39[i] = Reader.ReadInt32();
 
            or.unk40 = Reader.ReadUInt32();
            or.unk41 = Reader.ReadUInt32();

            Output.AppendLine("Guid:            " + or.Guid);
            Output.AppendLine("Entry:           " + or.Entry);
            Output.AppendLine("Title:           " + or.Title);
            Output.AppendLine("OfferRewardText: " + or.OfferRewardText);
            Output.AppendLine("UnkText1:        " + or.UnkText1);
            Output.AppendLine("UnkText2:        " + or.UnkText2);
            Output.AppendLine("UnkText3:        " + or.UnkText3);
            Output.AppendLine("UnkText4:        " + or.UnkText4);
            Output.AppendLine("Unk9:            " + or.Unk9);
            Output.AppendLine("Unk10:           " + or.Unk10);
            Output.AppendLine("Enable Next:     " + or.EnableNext);
            Output.AppendLine("Flags:           " + or.Flags);
            Output.AppendLine("Suggested Players: " + or.SuggestedPlayers);
            Output.AppendLine("Emote Count:     " + or.EmoteCount);
            for (int i = 0; i < 4; ++i)
            {
                Output.AppendFormatLine("Offer Reward EmoteDelay {0}:  {1}", i, or.offerRevardEmote[i].OfferRewardEmoteDelay);
                Output.AppendFormatLine("Offer Reward Emote {0}:       {1}", i, or.offerRevardEmote[i].OfferRewardEmote);
            }
            Output.AppendLine("Get Rew Choice Items Count:   " + or.RewChoiceItemsCount);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("Rew Choice Item Id{0}:    {1}", i, or.RewChoiceItemId[i]);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("Rew Choice Item Count{0}: {1}", i, or.RewChoiceItemCount[i]);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("Display Info ID 1_{0}:    {1}", i, or.DisplayInfoID1[i]);
 
            Output.AppendLine("Get Rew Items Count: " + or.RewItemsCount);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("Rew Item Id{0}:           {1}", i, or.RewItemId[i]);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("Rew Item Count{0}:        {1}", i, or.RewItemCount[i]);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("Display Info ID 2_{0}:    {1}", i, or.DisplayInfoID2[i]);
 
            Output.AppendLine("Unk25:                    " + or.Unk25);
            Output.AppendLine("Unk26:                    " + or.Unk26);
 
            Output.AppendLine("Rew Or Req Money:         " + or.RewOrReqMoney);
            Output.AppendLine("XP Value:                 " + or.XPValue);
            Output.AppendLine("Rew Honor Addition:       " + or.RewHonorAddition);
            Output.AppendFormatLine("Rew Honorable Multiplier: {0:F5}", or.RewHonorMultiplier);
            Output.AppendLine("Unk31:                    " + or.Unk31);
            Output.AppendLine("Unk32:                    " + or.Unk32);
            for (int i = 0; i < 5;++i )
                Output.AppendFormatLine("Rew Rep Faction_{0}:      {1}", i, or.RewRepFaction[i]);
            for (int i = 0; i < 5; ++i)
                Output.AppendFormatLine("Rew Rep Value Id_{0}:     {1}", i, or.RewRepValueId[i]);
            for (int i = 0; i < 5; ++i)
                Output.AppendFormatLine("unk6_{0}:                 {1}", i, or.RewRepValue[i]);
 
            Output.AppendLine("unk36:                    " + or.unk36);
            Output.AppendLine("unk37:                    " + or.unk37);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("unk38_{0}:                {1}", i, or.RewRepFaction[i]);
            for (int i = 0; i < 4; ++i)
                Output.AppendFormatLine("unk39_{0}:                {1}", i, or.RewRepFaction[i]);
            Output.AppendLine("unk40:                    " + or.unk40);
            Output.AppendLine("unk41:                    " + or.unk41);
        }
    }

    class OfferReward
    {
        public WowGuid Guid;
        public uint   Entry;
        public string Title;
        public string OfferRewardText;
        public string UnkText1;
        public string UnkText2;
        public string UnkText3;
        public string UnkText4;
        public uint   Unk9;
        public uint   Unk10;
        public byte   EnableNext;
        public uint   Flags;
        public uint   SuggestedPlayers;
        public uint   EmoteCount;
        
        public struct OfferRewardEm
        {                  
            public uint OfferRewardEmoteDelay;
            public uint OfferRewardEmote;
        }
 
        public uint   RewChoiceItemsCount;
        public uint[] RewChoiceItemId       = new uint[6];
        public uint[] RewChoiceItemCount    = new uint[6];
        public uint[] DisplayInfoID1        = new uint[6];
 
        public uint   RewItemsCount;
        public uint[] RewItemId             = new uint[4];
        public uint[] RewItemCount          = new uint[4];
        public uint[] DisplayInfoID2        = new uint[4];
 
        public uint   Unk25;
        public uint   Unk26;
        public uint   RewOrReqMoney;
        public uint   XPValue;
        public uint   RewHonorAddition;
        public float  RewHonorMultiplier;
        public uint   Unk31;
        public uint   Unk32;
        public uint[] RewRepFaction  = new uint[5];
        public int[]  RewRepValueId  = new int[5];
        public int[]  RewRepValue    = new int[5];
 
        public uint   unk36;
        public uint   unk37;
 
        public int[]  unk38 = new int[4];
        public int[]  unk39 = new int[4];
 
        public uint   unk40;
        public uint   unk41;
 
        public OfferRewardEm[] offerRevardEmote;
    }
}
