using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Gossip
{
    [WowPacketParser(WowOpcodes.SMSG_VENDOR_INVENTORY)]
    internal sealed class ListInventoryParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            InventoryList il = new InventoryList();

            Output.AppendLine("NPC:   " + (il.NpcGuid = Reader.ReadGuid()));
            Output.AppendLine("Count: " + (il.Count   = Reader.ReadByte()));

            if (il.Count > 0)
            {
                il.SlotList = new InventoryList.Slots[il.Count];

                for (int i = 0; i < il.Count; ++i)
                {
                    il.SlotList[i].Slot             = Reader.ReadUInt32();
                    il.SlotList[i].Unk1             = Reader.ReadUInt32();
                    il.SlotList[i].ItemId           = Reader.ReadUInt32();
                    il.SlotList[i].DisplayId        = Reader.ReadUInt32();
                    il.SlotList[i].MaxCount         = Reader.ReadInt32();
                    il.SlotList[i].BuyPrice         = Reader.ReadInt32();
                    il.SlotList[i].MaxDurability    = Reader.ReadInt32();
                    il.SlotList[i].BuyCount         = Reader.ReadInt32();
                    il.SlotList[i].ExtendedCost     = Reader.ReadUInt32();
                    il.SlotList[i].Unk2             = Reader.ReadByte();
                }

                Output.AppendLine();
                Output.AppendLine("------------------------------------------------------------------------------------------------------------------");
                Output.AppendLine("| Slot   | Item ID | DisplayId | Max Count | Buy Price | Durability | Buy Count | ExtendedCost | Unk 1   | Unk 2 |");
                Output.AppendLine("------------------------------------------------------------------------------------------------------------------");
                for (int j = 0; j < il.Count; ++j)
                {
                    Output.AppendFormatLine(
                        "| {0,-7}| {1,-8}| {2,-10}| {3,-10}| {4,-10}| {5,-11}| {6,-10}| {7,-13}| {8,-8}| {9,-6}|",
                        il.SlotList[j].Slot,
                        il.SlotList[j].ItemId,
                        il.SlotList[j].DisplayId,
                        il.SlotList[j].MaxCount,
                        il.SlotList[j].BuyPrice,
                        il.SlotList[j].MaxDurability,
                        il.SlotList[j].BuyCount,
                        il.SlotList[j].ExtendedCost,
                        il.SlotList[j].Unk1,
                        il.SlotList[j].Unk2
                        );
                }
                Output.AppendLine("------------------------------------------------------------------------------------------------------------------");

                //SqlOutput.AppendFormatLine("INSERT INTO npc_vendor (entry, item, maxcount, incrtime, ExtendedCost) VALUES ");

                //for (int j = 0; j < il.Count; ++j)
                //    SqlOutput.AppendFormatLine("({0}, {1}, {2}, {3}, {4}){5}",
                //        il.NpcGuid.Entry,
                //        il.SlotList[j].ItemId,
                //        il.SlotList[j].MaxCount,
                //        0,
                //        il.SlotList[j].ExtendedCost,
                //        (j < il.Count) ? "," : ";");
            }
            else
            {
                Output.AppendLine("Reason: " + (InventoryReason)Reader.ReadByte());
            }
        }
    }

    internal class InventoryList
    {
        public WowGuid NpcGuid;
        public byte Count;
        public Slots[] SlotList;

        public struct Slots
        {
            public uint Slot;
            public uint ItemId;
            public uint DisplayId;
            public  int MaxCount;
            public  int BuyPrice;
            public  int MaxDurability;
            public  int BuyCount;
            public uint ExtendedCost;
            public uint Unk1;
            public byte Unk2;
        }
    }
}
