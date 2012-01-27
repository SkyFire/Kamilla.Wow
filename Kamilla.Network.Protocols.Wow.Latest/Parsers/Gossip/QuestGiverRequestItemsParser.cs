using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Gossip
{
    [WowPacketParser(WowOpcodes.SMSG_QUESTGIVER_REQUEST_ITEMS)]
    internal sealed class QuestGiverRequestItemsParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            RequestItem ri = new RequestItem();
            ri.NpcGuid          = Reader.ReadGuid();
            ri.QuestEntry       = Reader.ReadUInt32();
            ri.Title            = Reader.ReadCString();
            ri.TextRequestItem  = Reader.ReadCString();
            ri.unk1             = Reader.ReadUInt32();
            ri.Emote            = Reader.ReadUInt32();
            ri.Autofinish       = Reader.ReadUInt32();
            ri.QuestFlag        = Reader.ReadUInt32();
            ri.unk2             = Reader.ReadUInt32();
            ri.RewOrReqMoney    = Reader.ReadUInt32();
            ri.ReqItemsCount    = Reader.ReadUInt32();
            ri.reqItemList      = new RequestItem.ReqItemOR[6];
            for (int i = 0; i < ri.ReqItemsCount; ++i)
            {
                ri.reqItemList[i].ReqItemId     = Reader.ReadUInt32();
                ri.reqItemList[i].ReqItemCount  = Reader.ReadUInt32();
                ri.reqItemList[i].DisplayInfoID = Reader.ReadUInt32();
            }
            ri.UnkFieldCount = Reader.ReadUInt32();
            ri.unkFieldList = new RequestItem.UnkField[4];
            for (int i = 0; i < ri.UnkFieldCount; ++i)
            {
                ri.unkFieldList[i].unkField1 = Reader.ReadUInt32();
                ri.unkFieldList[i].unkField2 = Reader.ReadUInt32();
            }
            ri.unk3 = Reader.ReadUInt32();
            ri.unk4 = Reader.ReadUInt32();
            ri.unk5 = Reader.ReadUInt32();
            ri.unk6 = Reader.ReadUInt32();
            ri.unk7 = Reader.ReadUInt32();

            Output.AppendLine("GUID: " +        ri.NpcGuid);
            Output.AppendLine("Quest Entry: " + ri.QuestEntry);
            Output.AppendLine("Title: " +       ri.Title);
            Output.AppendLine("Text: " +        ri.TextRequestItem);
            Output.AppendLine("Unk1 " +         ri.unk1);
            Output.AppendLine("Emote " +        ri.Emote);
            Output.AppendLine("Autofinish " +   ri.Autofinish);
            Output.AppendLine("Quest Flag: " +  ri.QuestFlag);
            Output.AppendLine("Unk2 " +         ri.unk2);
            Output.AppendFormatLine("RewOrReqMoney: {0,-12}, ReqItemsCount: {1}", ri.RewOrReqMoney, ri.ReqItemsCount);
 
            for (int i = 0; i < ri.ReqItemsCount; ++i)
            {
                Output.AppendFormatLine("Req Item Id_{0}:     {1}", i, ri.reqItemList[i].ReqItemId);
                Output.AppendFormatLine("Req Item Count_{0}:  {1}", i, ri.reqItemList[i].ReqItemCount);
                Output.AppendFormatLine("Display Info ID_{0}: {1}", i, ri.reqItemList[i].DisplayInfoID);
            }

            Output.AppendLine("Unk Field Count " + ri.UnkFieldCount);
            for (int i = 0; i < ri.UnkFieldCount; ++i)
            {
                Output.AppendFormatLine("Unk_0_{0}:  {1}", i, ri.unkFieldList[i].unkField1);
                Output.AppendFormatLine("Unk_1_{0}:  {1}", i, ri.unkFieldList[i].unkField2);
            }

            Output.AppendLine("Unk3 " + ri.unk3);
            Output.AppendLine("Unk4 " + ri.unk4);
            Output.AppendLine("Unk5 " + ri.unk5);
            Output.AppendLine("Unk6 " + ri.unk6);
            Output.AppendLine("Unk7 " + ri.unk7);
        }
    }
 
    class RequestItem
    {
        public WowGuid NpcGuid;
        public uint   QuestEntry;
        public string Title;
        public string TextRequestItem;
        public uint   unk1;
        public uint   Emote;
        public uint   Autofinish;
        public uint   QuestFlag;
        public uint   unk2;
        public uint   RewOrReqMoney;
        public uint   ReqItemsCount;
 
        public struct ReqItemOR // max 6
        {
            public uint ReqItemId;
            public uint ReqItemCount;
            public uint DisplayInfoID;
        };
 
        public uint UnkFieldCount;
 
        public struct UnkField // max 4
        {
            public uint unkField1;
            public uint unkField2;
        };
 
        public uint   unk3;
        public uint   unk4;
        public uint   unk5;
        public uint   unk6;
        public uint   unk7;
 
        public ReqItemOR[] reqItemList  = new ReqItemOR[6];
        public UnkField[]  unkFieldList = new UnkField[4];
    }
}