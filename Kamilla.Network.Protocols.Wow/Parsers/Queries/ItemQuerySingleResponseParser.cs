using System;
using Kamilla.IO;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Queries
{
    [WowPacketParser(WowOpcodes.SMSG_DB_REPLY)]
    internal sealed class ItemQuerySingleResponse : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            int row;
            int size;

            Output.AppendLine("Row: " + (row = Reader.ReadInt32()));
            Output.AppendLine("Data Size: " + (size = Reader.ReadInt32()));
            byte[] data = Reader.ReadBytes(size);

            Output.AppendLine("Time(?): " + Reader.ReadUInt32());
            DB2Ids type;
            Output.AppendLine("Type: " + (type = (DB2Ids)Reader.ReadUInt32()));
            Output.AppendLine();

            if (row < 0)
                return;

            using (var dataReader = new StreamHandler(data))
            {
                if (type == DB2Ids.Item)
                {
                    Output.AppendLine("Item Id: " + dataReader.ReadUInt32());
                    Output.AppendLine("Class: " + (ItemClass)dataReader.ReadUInt32());
                    Output.AppendLine("SubClass: " + (ItemSubClass)dataReader.ReadUInt32());
                    Output.AppendLine("Unk -1: " + dataReader.ReadInt32());
                    Output.AppendLine("Material: " + (Material)dataReader.ReadUInt32());
                    Output.AppendLine("Display Id: " + dataReader.ReadUInt32());
                    Output.AppendLine("Inventory Type: " + (InventorySlot)dataReader.ReadUInt32());
                    Output.AppendLine("Sheath: " + dataReader.ReadUInt32());
                }
                else if (type == DB2Ids.ItemSparse)
                {
                    Output.AppendLine("id: " + dataReader.ReadInt32());
                    Output.AppendLine("quality: " + (ItemQuality)dataReader.ReadInt32());
                    Output.AppendLine("flags: " + dataReader.ReadUInt32());
                    Output.AppendLine("flags2: " + dataReader.ReadUInt32());
                    Output.AppendLine("buyprice: " + dataReader.ReadInt32());
                    Output.AppendLine("sellprice: " + dataReader.ReadInt32());
                    Output.AppendLine("inventorytype: " + dataReader.ReadInt32());
                    Output.AppendLine("allowableclass: " + dataReader.ReadInt32());
                    Output.AppendLine("allowablerace: " + dataReader.ReadInt32());
                    Output.AppendLine("itemlevel: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredlevel: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredskill: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredskillrank: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredspell: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredhonorrank: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredcityrank: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredreputationfaction: " + dataReader.ReadInt32());
                    Output.AppendLine("requiredreputationrank: " + dataReader.ReadInt32());
                    Output.AppendLine("maxcount: " + dataReader.ReadInt32());
                    Output.AppendLine("stackable: " + dataReader.ReadInt32());
                    Output.AppendLine("containerslots: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type1: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type2: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type3: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type4: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type5: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type6: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type7: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type8: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type9: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_type10: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value1: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value2: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value3: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value4: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value5: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value6: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value7: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value8: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value9: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_value10: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_1: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_2: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_3: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_4: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_5: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_6: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_7: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_8: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_9: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk1_10: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_1: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_2: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_3: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_4: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_5: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_6: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_7: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_8: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_9: " + dataReader.ReadInt32());
                    Output.AppendLine("stat_unk2_10: " + dataReader.ReadInt32());
                    Output.AppendLine("scalingstatdistribution: " + dataReader.ReadInt32());
                    Output.AppendLine("damagetype: " + dataReader.ReadInt32());
                    Output.AppendLine("delay: " + dataReader.ReadInt32());
                    Output.AppendLine("rangedmodrange: " + dataReader.ReadSingle());
                    Output.AppendLine("spellid_1: " + dataReader.ReadInt32());
                    Output.AppendLine("spellid_2: " + dataReader.ReadInt32());
                    Output.AppendLine("spellid_3: " + dataReader.ReadInt32());
                    Output.AppendLine("spellid_4: " + dataReader.ReadInt32());
                    Output.AppendLine("spellid_5: " + dataReader.ReadInt32());
                    Output.AppendLine("spelltrigger_1: " + dataReader.ReadInt32());
                    Output.AppendLine("spelltrigger_2: " + dataReader.ReadInt32());
                    Output.AppendLine("spelltrigger_3: " + dataReader.ReadInt32());
                    Output.AppendLine("spelltrigger_4: " + dataReader.ReadInt32());
                    Output.AppendLine("spelltrigger_5: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcharges_1: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcharges_2: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcharges_3: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcharges_4: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcharges_5: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcooldown_1: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcooldown_2: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcooldown_3: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcooldown_4: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcooldown_5: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategory_1: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategory_2: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategory_3: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategory_4: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategory_5: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategorycooldown_1: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategorycooldown_2: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategorycooldown_3: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategorycooldown_4: " + dataReader.ReadInt32());
                    Output.AppendLine("spellcategorycooldown_5: " + dataReader.ReadInt32());
                    Output.AppendLine("bonding: " + dataReader.ReadInt32());
                    Output.AppendLine("name: " + dataReader.ReadPascalString16());
                    Output.AppendLine("name2: " + dataReader.ReadPascalString16());
                    Output.AppendLine("name3: " + dataReader.ReadPascalString16());
                    Output.AppendLine("name4: " + dataReader.ReadPascalString16());
                    Output.AppendLine("description: " + dataReader.ReadPascalString16());
                    Output.AppendLine("pagetext: " + dataReader.ReadInt32());
                    Output.AppendLine("languageid: " + dataReader.ReadInt32());
                    Output.AppendLine("pagematerial: " + dataReader.ReadInt32());
                    Output.AppendLine("startquest: " + dataReader.ReadInt32());
                    Output.AppendLine("lockid: " + dataReader.ReadInt32());
                    Output.AppendLine("material: " + dataReader.ReadInt32());
                    Output.AppendLine("sheath: " + dataReader.ReadInt32());
                    Output.AppendLine("randomproperty: " + dataReader.ReadInt32());
                    Output.AppendLine("randomsuffix: " + dataReader.ReadInt32());
                    Output.AppendLine("itemset: " + dataReader.ReadInt32());
                    Output.AppendLine("maxdurability: " + dataReader.ReadInt32());
                    Output.AppendLine("area: " + dataReader.ReadInt32());
                    Output.AppendLine("map: " + dataReader.ReadInt32());
                    Output.AppendLine("bagfamily: " + dataReader.ReadInt32());
                    Output.AppendLine("totemcategory: " + dataReader.ReadInt32());
                    Output.AppendLine("socketcolor_1: " + dataReader.ReadInt32());
                    Output.AppendLine("socketcolor_2: " + dataReader.ReadInt32());
                    Output.AppendLine("socketcolor_3: " + dataReader.ReadInt32());
                    Output.AppendLine("socketcontent_1: " + dataReader.ReadInt32());
                    Output.AppendLine("socketcontent_2: " + dataReader.ReadInt32());
                    Output.AppendLine("socketcontent_3: " + dataReader.ReadInt32());
                    Output.AppendLine("socketbonus: " + dataReader.ReadInt32());
                    Output.AppendLine("gemproperties: " + dataReader.ReadInt32());
                    Output.AppendLine("armordamagemodifier: " + dataReader.ReadSingle());
                    Output.AppendLine("duration: " + dataReader.ReadInt32());
                    Output.AppendLine("itemlimitcategory: " + dataReader.ReadInt32());
                    Output.AppendLine("holidayid: " + dataReader.ReadInt32());
                    Output.AppendLine("statscalingfactor: " + dataReader.ReadSingle());
                    Output.AppendLine("arch_field_130: " + dataReader.ReadInt32());
                    Output.AppendLine("arch_field_131: " + dataReader.ReadInt32());
                }
                else
                    throw new Exception("Unknown item update type: " + type);

                if (!dataReader.IsRead)
                    throw new Exception("Data was not read fully, bytes still not read: " + dataReader.RemainingLength);
            }
        }
    }
}
