
// Kamilla 15211
// Auto generated on 01.02.2012 12:16:41
namespace Kamilla.Network.Protocols.Wow.Game
{
    public partial class UpdateFields
    {
        private static UpdateField<ObjectUpdateFields>[] _ObjectUpdateFields = new UpdateField<ObjectUpdateFields>[]
        {
            new UpdateField<ObjectUpdateFields>(4, 1, ObjectUpdateFields.OBJECT_FIELD_GUID),
            new UpdateField<ObjectUpdateFields>(4, 1, ObjectUpdateFields.OBJECT_FIELD_GUID_HIPART),
            new UpdateField<ObjectUpdateFields>(4, 1, ObjectUpdateFields.OBJECT_FIELD_DATA),
            new UpdateField<ObjectUpdateFields>(4, 1, ObjectUpdateFields.OBJECT_FIELD_DATA_HIPART),
            new UpdateField<ObjectUpdateFields>(2, 1, ObjectUpdateFields.OBJECT_FIELD_TYPE),
            new UpdateField<ObjectUpdateFields>(1, 1, ObjectUpdateFields.OBJECT_FIELD_ENTRY),
            new UpdateField<ObjectUpdateFields>(3, 1, ObjectUpdateFields.OBJECT_FIELD_SCALE_X),
            new UpdateField<ObjectUpdateFields>(1, 0, ObjectUpdateFields.OBJECT_FIELD_PADDING),
        };
        public static UpdateField<ObjectUpdateFields> GetUpdateField(ObjectUpdateFields uf)
        {
            uint index = (uint)uf;
            if (index >= (uint)ObjectUpdateFields.End)
                return UpdateField.CreateUnknown<ObjectUpdateFields>(uf);

            return _ObjectUpdateFields[index];
        }
    }
    public enum ObjectUpdateFields : uint
    {
        OBJECT_FIELD_GUID                                             = 0x0000, // Size: 2, Type: Long, Flags: Public
        OBJECT_FIELD_GUID_HIPART                                      = 0x0001,
        OBJECT_FIELD_DATA                                             = 0x0002, // Size: 2, Type: Long, Flags: Public
        OBJECT_FIELD_DATA_HIPART                                      = 0x0003,
        OBJECT_FIELD_TYPE                                             = 0x0004, // Size: 1, Type: TwoShort, Flags: Public
        OBJECT_FIELD_ENTRY                                            = 0x0005, // Size: 1, Type: Int, Flags: Public
        OBJECT_FIELD_SCALE_X                                          = 0x0006, // Size: 1, Type: Float, Flags: Public
        OBJECT_FIELD_PADDING                                          = 0x0007, // Size: 1, Type: Int, Flags: None
        End                                                           = 0x0008
    }

    public partial class UpdateFields
    {
        private static UpdateField<ItemUpdateFields>[] _ItemUpdateFields = new UpdateField<ItemUpdateFields>[]
        {
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_OWNER),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_OWNER_HIPART),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_CONTAINED),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_CONTAINED_HIPART),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_CREATOR),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_CREATOR_HIPART),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_GIFTCREATOR),
            new UpdateField<ItemUpdateFields>(4, 1, ItemUpdateFields.ITEM_FIELD_GIFTCREATOR_HIPART),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_STACK_COUNT),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_DURATION),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_SPELL_CHARGES),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_SPELL_CHARGES_2),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_SPELL_CHARGES_3),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_SPELL_CHARGES_4),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_SPELL_CHARGES_5),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_FLAGS),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_1_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_1_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_1_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_2_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_2_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_2_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_3_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_3_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_3_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_4_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_4_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_4_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_5_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_5_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_5_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_6_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_6_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_6_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_7_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_7_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_7_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_8_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_8_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_8_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_9_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_9_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_9_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_10_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_10_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_10_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_11_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_11_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_11_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_12_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_12_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_12_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_13_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_13_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_13_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_14_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_14_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_14_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_15_1),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_15_2),
            new UpdateField<ItemUpdateFields>(2, 1, ItemUpdateFields.ITEM_FIELD_ENCHANTMENT_15_3),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_PROPERTY_SEED),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_RANDOM_PROPERTIES_ID),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_DURABILITY),
            new UpdateField<ItemUpdateFields>(1, 12, ItemUpdateFields.ITEM_FIELD_MAXDURABILITY),
            new UpdateField<ItemUpdateFields>(1, 1, ItemUpdateFields.ITEM_FIELD_CREATE_PLAYED_TIME),
        };
        public static UpdateField<ItemUpdateFields> GetUpdateField(ItemUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ObjectUpdateFields.End;
            if (index >= (uint)ItemUpdateFields.End)
                return UpdateField.CreateUnknown<ItemUpdateFields>(uf);

            return _ItemUpdateFields[index];
        }
    }
    public enum ItemUpdateFields : uint
    {
        ITEM_FIELD_OWNER                                              = ObjectUpdateFields.End + 0x0000, // Size: 2, Type: Long, Flags: Public
        ITEM_FIELD_OWNER_HIPART                                       = ObjectUpdateFields.End + 0x0001,
        ITEM_FIELD_CONTAINED                                          = ObjectUpdateFields.End + 0x0002, // Size: 2, Type: Long, Flags: Public
        ITEM_FIELD_CONTAINED_HIPART                                   = ObjectUpdateFields.End + 0x0003,
        ITEM_FIELD_CREATOR                                            = ObjectUpdateFields.End + 0x0004, // Size: 2, Type: Long, Flags: Public
        ITEM_FIELD_CREATOR_HIPART                                     = ObjectUpdateFields.End + 0x0005,
        ITEM_FIELD_GIFTCREATOR                                        = ObjectUpdateFields.End + 0x0006, // Size: 2, Type: Long, Flags: Public
        ITEM_FIELD_GIFTCREATOR_HIPART                                 = ObjectUpdateFields.End + 0x0007,
        ITEM_FIELD_STACK_COUNT                                        = ObjectUpdateFields.End + 0x0008, // Size: 1, Type: Int, Flags: OwnerOnly, Unk1
        ITEM_FIELD_DURATION                                           = ObjectUpdateFields.End + 0x0009, // Size: 1, Type: Int, Flags: OwnerOnly, Unk1
        ITEM_FIELD_SPELL_CHARGES                                      = ObjectUpdateFields.End + 0x000A, // Size: 5, Type: Int, Flags: OwnerOnly, Unk1
        ITEM_FIELD_SPELL_CHARGES_2                                    = ObjectUpdateFields.End + 0x000B,
        ITEM_FIELD_SPELL_CHARGES_3                                    = ObjectUpdateFields.End + 0x000C,
        ITEM_FIELD_SPELL_CHARGES_4                                    = ObjectUpdateFields.End + 0x000D,
        ITEM_FIELD_SPELL_CHARGES_5                                    = ObjectUpdateFields.End + 0x000E,
        ITEM_FIELD_FLAGS                                              = ObjectUpdateFields.End + 0x000F, // Size: 1, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_1_1                                    = ObjectUpdateFields.End + 0x0010, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_1_2                                    = ObjectUpdateFields.End + 0x0011,
        ITEM_FIELD_ENCHANTMENT_1_3                                    = ObjectUpdateFields.End + 0x0012, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_2_1                                    = ObjectUpdateFields.End + 0x0013, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_2_2                                    = ObjectUpdateFields.End + 0x0014,
        ITEM_FIELD_ENCHANTMENT_2_3                                    = ObjectUpdateFields.End + 0x0015, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_3_1                                    = ObjectUpdateFields.End + 0x0016, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_3_2                                    = ObjectUpdateFields.End + 0x0017,
        ITEM_FIELD_ENCHANTMENT_3_3                                    = ObjectUpdateFields.End + 0x0018, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_4_1                                    = ObjectUpdateFields.End + 0x0019, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_4_2                                    = ObjectUpdateFields.End + 0x001A,
        ITEM_FIELD_ENCHANTMENT_4_3                                    = ObjectUpdateFields.End + 0x001B, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_5_1                                    = ObjectUpdateFields.End + 0x001C, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_5_2                                    = ObjectUpdateFields.End + 0x001D,
        ITEM_FIELD_ENCHANTMENT_5_3                                    = ObjectUpdateFields.End + 0x001E, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_6_1                                    = ObjectUpdateFields.End + 0x001F, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_6_2                                    = ObjectUpdateFields.End + 0x0020,
        ITEM_FIELD_ENCHANTMENT_6_3                                    = ObjectUpdateFields.End + 0x0021, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_7_1                                    = ObjectUpdateFields.End + 0x0022, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_7_2                                    = ObjectUpdateFields.End + 0x0023,
        ITEM_FIELD_ENCHANTMENT_7_3                                    = ObjectUpdateFields.End + 0x0024, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_8_1                                    = ObjectUpdateFields.End + 0x0025, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_8_2                                    = ObjectUpdateFields.End + 0x0026,
        ITEM_FIELD_ENCHANTMENT_8_3                                    = ObjectUpdateFields.End + 0x0027, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_9_1                                    = ObjectUpdateFields.End + 0x0028, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_9_2                                    = ObjectUpdateFields.End + 0x0029,
        ITEM_FIELD_ENCHANTMENT_9_3                                    = ObjectUpdateFields.End + 0x002A, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_10_1                                   = ObjectUpdateFields.End + 0x002B, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_10_2                                   = ObjectUpdateFields.End + 0x002C,
        ITEM_FIELD_ENCHANTMENT_10_3                                   = ObjectUpdateFields.End + 0x002D, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_11_1                                   = ObjectUpdateFields.End + 0x002E, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_11_2                                   = ObjectUpdateFields.End + 0x002F,
        ITEM_FIELD_ENCHANTMENT_11_3                                   = ObjectUpdateFields.End + 0x0030, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_12_1                                   = ObjectUpdateFields.End + 0x0031, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_12_2                                   = ObjectUpdateFields.End + 0x0032,
        ITEM_FIELD_ENCHANTMENT_12_3                                   = ObjectUpdateFields.End + 0x0033, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_13_1                                   = ObjectUpdateFields.End + 0x0034, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_13_2                                   = ObjectUpdateFields.End + 0x0035,
        ITEM_FIELD_ENCHANTMENT_13_3                                   = ObjectUpdateFields.End + 0x0036, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_14_1                                   = ObjectUpdateFields.End + 0x0037, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_14_2                                   = ObjectUpdateFields.End + 0x0038,
        ITEM_FIELD_ENCHANTMENT_14_3                                   = ObjectUpdateFields.End + 0x0039, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_ENCHANTMENT_15_1                                   = ObjectUpdateFields.End + 0x003A, // Size: 2, Type: Int, Flags: Public
        ITEM_FIELD_ENCHANTMENT_15_2                                   = ObjectUpdateFields.End + 0x003B,
        ITEM_FIELD_ENCHANTMENT_15_3                                   = ObjectUpdateFields.End + 0x003C, // Size: 1, Type: TwoShort, Flags: Public
        ITEM_FIELD_PROPERTY_SEED                                      = ObjectUpdateFields.End + 0x003D, // Size: 1, Type: Int, Flags: Public
        ITEM_FIELD_RANDOM_PROPERTIES_ID                               = ObjectUpdateFields.End + 0x003E, // Size: 1, Type: Int, Flags: Public
        ITEM_FIELD_DURABILITY                                         = ObjectUpdateFields.End + 0x003F, // Size: 1, Type: Int, Flags: OwnerOnly, Unk1
        ITEM_FIELD_MAXDURABILITY                                      = ObjectUpdateFields.End + 0x0040, // Size: 1, Type: Int, Flags: OwnerOnly, Unk1
        ITEM_FIELD_CREATE_PLAYED_TIME                                 = ObjectUpdateFields.End + 0x0041, // Size: 1, Type: Int, Flags: Public
        End                                                           = ObjectUpdateFields.End + 0x0042
    }

    public partial class UpdateFields
    {
        private static UpdateField<ContainerUpdateFields>[] _ContainerUpdateFields = new UpdateField<ContainerUpdateFields>[]
        {
            new UpdateField<ContainerUpdateFields>(1, 1, ContainerUpdateFields.CONTAINER_FIELD_NUM_SLOTS),
            new UpdateField<ContainerUpdateFields>(5, 0, ContainerUpdateFields.CONTAINER_ALIGN_PAD),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_1),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_1_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_2),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_2_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_3),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_3_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_4),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_4_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_5),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_5_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_6),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_6_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_7),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_7_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_8),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_8_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_9),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_9_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_10),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_10_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_11),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_11_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_12),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_12_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_13),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_13_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_14),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_14_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_15),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_15_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_16),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_16_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_17),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_17_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_18),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_18_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_19),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_19_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_20),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_20_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_21),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_21_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_22),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_22_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_23),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_23_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_24),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_24_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_25),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_25_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_26),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_26_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_27),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_27_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_28),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_28_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_29),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_29_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_30),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_30_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_31),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_31_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_32),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_32_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_33),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_33_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_34),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_34_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_35),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_35_HIPART),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_36),
            new UpdateField<ContainerUpdateFields>(4, 1, ContainerUpdateFields.CONTAINER_FIELD_SLOT_36_HIPART),
        };
        public static UpdateField<ContainerUpdateFields> GetUpdateField(ContainerUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ItemUpdateFields.End;
            if (index >= (uint)ContainerUpdateFields.End)
                return UpdateField.CreateUnknown<ContainerUpdateFields>(uf);

            return _ContainerUpdateFields[index];
        }
    }
    public enum ContainerUpdateFields : uint
    {
        CONTAINER_FIELD_NUM_SLOTS                                     = ItemUpdateFields.End + 0x0000, // Size: 1, Type: Int, Flags: Public
        CONTAINER_ALIGN_PAD                                           = ItemUpdateFields.End + 0x0001, // Size: 1, Type: Bytes, Flags: None
        CONTAINER_FIELD_SLOT_1                                        = ItemUpdateFields.End + 0x0002, // Size: 72, Type: Long, Flags: Public
        CONTAINER_FIELD_SLOT_1_HIPART                                 = ItemUpdateFields.End + 0x0003,
        CONTAINER_FIELD_SLOT_2                                        = ItemUpdateFields.End + 0x0004,
        CONTAINER_FIELD_SLOT_2_HIPART                                 = ItemUpdateFields.End + 0x0005,
        CONTAINER_FIELD_SLOT_3                                        = ItemUpdateFields.End + 0x0006,
        CONTAINER_FIELD_SLOT_3_HIPART                                 = ItemUpdateFields.End + 0x0007,
        CONTAINER_FIELD_SLOT_4                                        = ItemUpdateFields.End + 0x0008,
        CONTAINER_FIELD_SLOT_4_HIPART                                 = ItemUpdateFields.End + 0x0009,
        CONTAINER_FIELD_SLOT_5                                        = ItemUpdateFields.End + 0x000A,
        CONTAINER_FIELD_SLOT_5_HIPART                                 = ItemUpdateFields.End + 0x000B,
        CONTAINER_FIELD_SLOT_6                                        = ItemUpdateFields.End + 0x000C,
        CONTAINER_FIELD_SLOT_6_HIPART                                 = ItemUpdateFields.End + 0x000D,
        CONTAINER_FIELD_SLOT_7                                        = ItemUpdateFields.End + 0x000E,
        CONTAINER_FIELD_SLOT_7_HIPART                                 = ItemUpdateFields.End + 0x000F,
        CONTAINER_FIELD_SLOT_8                                        = ItemUpdateFields.End + 0x0010,
        CONTAINER_FIELD_SLOT_8_HIPART                                 = ItemUpdateFields.End + 0x0011,
        CONTAINER_FIELD_SLOT_9                                        = ItemUpdateFields.End + 0x0012,
        CONTAINER_FIELD_SLOT_9_HIPART                                 = ItemUpdateFields.End + 0x0013,
        CONTAINER_FIELD_SLOT_10                                       = ItemUpdateFields.End + 0x0014,
        CONTAINER_FIELD_SLOT_10_HIPART                                = ItemUpdateFields.End + 0x0015,
        CONTAINER_FIELD_SLOT_11                                       = ItemUpdateFields.End + 0x0016,
        CONTAINER_FIELD_SLOT_11_HIPART                                = ItemUpdateFields.End + 0x0017,
        CONTAINER_FIELD_SLOT_12                                       = ItemUpdateFields.End + 0x0018,
        CONTAINER_FIELD_SLOT_12_HIPART                                = ItemUpdateFields.End + 0x0019,
        CONTAINER_FIELD_SLOT_13                                       = ItemUpdateFields.End + 0x001A,
        CONTAINER_FIELD_SLOT_13_HIPART                                = ItemUpdateFields.End + 0x001B,
        CONTAINER_FIELD_SLOT_14                                       = ItemUpdateFields.End + 0x001C,
        CONTAINER_FIELD_SLOT_14_HIPART                                = ItemUpdateFields.End + 0x001D,
        CONTAINER_FIELD_SLOT_15                                       = ItemUpdateFields.End + 0x001E,
        CONTAINER_FIELD_SLOT_15_HIPART                                = ItemUpdateFields.End + 0x001F,
        CONTAINER_FIELD_SLOT_16                                       = ItemUpdateFields.End + 0x0020,
        CONTAINER_FIELD_SLOT_16_HIPART                                = ItemUpdateFields.End + 0x0021,
        CONTAINER_FIELD_SLOT_17                                       = ItemUpdateFields.End + 0x0022,
        CONTAINER_FIELD_SLOT_17_HIPART                                = ItemUpdateFields.End + 0x0023,
        CONTAINER_FIELD_SLOT_18                                       = ItemUpdateFields.End + 0x0024,
        CONTAINER_FIELD_SLOT_18_HIPART                                = ItemUpdateFields.End + 0x0025,
        CONTAINER_FIELD_SLOT_19                                       = ItemUpdateFields.End + 0x0026,
        CONTAINER_FIELD_SLOT_19_HIPART                                = ItemUpdateFields.End + 0x0027,
        CONTAINER_FIELD_SLOT_20                                       = ItemUpdateFields.End + 0x0028,
        CONTAINER_FIELD_SLOT_20_HIPART                                = ItemUpdateFields.End + 0x0029,
        CONTAINER_FIELD_SLOT_21                                       = ItemUpdateFields.End + 0x002A,
        CONTAINER_FIELD_SLOT_21_HIPART                                = ItemUpdateFields.End + 0x002B,
        CONTAINER_FIELD_SLOT_22                                       = ItemUpdateFields.End + 0x002C,
        CONTAINER_FIELD_SLOT_22_HIPART                                = ItemUpdateFields.End + 0x002D,
        CONTAINER_FIELD_SLOT_23                                       = ItemUpdateFields.End + 0x002E,
        CONTAINER_FIELD_SLOT_23_HIPART                                = ItemUpdateFields.End + 0x002F,
        CONTAINER_FIELD_SLOT_24                                       = ItemUpdateFields.End + 0x0030,
        CONTAINER_FIELD_SLOT_24_HIPART                                = ItemUpdateFields.End + 0x0031,
        CONTAINER_FIELD_SLOT_25                                       = ItemUpdateFields.End + 0x0032,
        CONTAINER_FIELD_SLOT_25_HIPART                                = ItemUpdateFields.End + 0x0033,
        CONTAINER_FIELD_SLOT_26                                       = ItemUpdateFields.End + 0x0034,
        CONTAINER_FIELD_SLOT_26_HIPART                                = ItemUpdateFields.End + 0x0035,
        CONTAINER_FIELD_SLOT_27                                       = ItemUpdateFields.End + 0x0036,
        CONTAINER_FIELD_SLOT_27_HIPART                                = ItemUpdateFields.End + 0x0037,
        CONTAINER_FIELD_SLOT_28                                       = ItemUpdateFields.End + 0x0038,
        CONTAINER_FIELD_SLOT_28_HIPART                                = ItemUpdateFields.End + 0x0039,
        CONTAINER_FIELD_SLOT_29                                       = ItemUpdateFields.End + 0x003A,
        CONTAINER_FIELD_SLOT_29_HIPART                                = ItemUpdateFields.End + 0x003B,
        CONTAINER_FIELD_SLOT_30                                       = ItemUpdateFields.End + 0x003C,
        CONTAINER_FIELD_SLOT_30_HIPART                                = ItemUpdateFields.End + 0x003D,
        CONTAINER_FIELD_SLOT_31                                       = ItemUpdateFields.End + 0x003E,
        CONTAINER_FIELD_SLOT_31_HIPART                                = ItemUpdateFields.End + 0x003F,
        CONTAINER_FIELD_SLOT_32                                       = ItemUpdateFields.End + 0x0040,
        CONTAINER_FIELD_SLOT_32_HIPART                                = ItemUpdateFields.End + 0x0041,
        CONTAINER_FIELD_SLOT_33                                       = ItemUpdateFields.End + 0x0042,
        CONTAINER_FIELD_SLOT_33_HIPART                                = ItemUpdateFields.End + 0x0043,
        CONTAINER_FIELD_SLOT_34                                       = ItemUpdateFields.End + 0x0044,
        CONTAINER_FIELD_SLOT_34_HIPART                                = ItemUpdateFields.End + 0x0045,
        CONTAINER_FIELD_SLOT_35                                       = ItemUpdateFields.End + 0x0046,
        CONTAINER_FIELD_SLOT_35_HIPART                                = ItemUpdateFields.End + 0x0047,
        CONTAINER_FIELD_SLOT_36                                       = ItemUpdateFields.End + 0x0048,
        CONTAINER_FIELD_SLOT_36_HIPART                                = ItemUpdateFields.End + 0x0049,
        End                                                           = ItemUpdateFields.End + 0x004A
    }

    public partial class UpdateFields
    {
        private static UpdateField<UnitUpdateFields>[] _UnitUpdateFields = new UpdateField<UnitUpdateFields>[]
        {
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CHARM),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CHARM_HIPART),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_SUMMON),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_SUMMON_HIPART),
            new UpdateField<UnitUpdateFields>(4, 2, UnitUpdateFields.UNIT_FIELD_CRITTER),
            new UpdateField<UnitUpdateFields>(4, 2, UnitUpdateFields.UNIT_FIELD_CRITTER_HIPART),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CHARMEDBY),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CHARMEDBY_HIPART),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_SUMMONEDBY),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_SUMMONEDBY_HIPART),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CREATEDBY),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CREATEDBY_HIPART),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_TARGET),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_TARGET_HIPART),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CHANNEL_OBJECT),
            new UpdateField<UnitUpdateFields>(4, 1, UnitUpdateFields.UNIT_FIELD_CHANNEL_OBJECT_HIPART),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_CHANNEL_SPELL),
            new UpdateField<UnitUpdateFields>(5, 1, UnitUpdateFields.UNIT_FIELD_BYTES_0),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_HEALTH),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_POWER1),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_POWER2),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_POWER3),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_POWER4),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_POWER5),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXHEALTH),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXPOWER1),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXPOWER2),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXPOWER3),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXPOWER4),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXPOWER5),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_2),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_3),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_4),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_5),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_2),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_3),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_4),
            new UpdateField<UnitUpdateFields>(3, 70, UnitUpdateFields.UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_5),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_LEVEL),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_FACTIONTEMPLATE),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_VIRTUAL_ITEM_SLOT_ID),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_VIRTUAL_ITEM_SLOT_ID_2),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_VIRTUAL_ITEM_SLOT_ID_3),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_FLAGS),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_FLAGS_2),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_AURASTATE),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_BASEATTACKTIME),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_BASEATTACKTIME_2),
            new UpdateField<UnitUpdateFields>(1, 2, UnitUpdateFields.UNIT_FIELD_RANGEDATTACKTIME),
            new UpdateField<UnitUpdateFields>(3, 1, UnitUpdateFields.UNIT_FIELD_BOUNDINGRADIUS),
            new UpdateField<UnitUpdateFields>(3, 1, UnitUpdateFields.UNIT_FIELD_COMBATREACH),
            new UpdateField<UnitUpdateFields>(1, 128, UnitUpdateFields.UNIT_FIELD_DISPLAYID),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_NATIVEDISPLAYID),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MOUNTDISPLAYID),
            new UpdateField<UnitUpdateFields>(3, 22, UnitUpdateFields.UNIT_FIELD_MINDAMAGE),
            new UpdateField<UnitUpdateFields>(3, 22, UnitUpdateFields.UNIT_FIELD_MAXDAMAGE),
            new UpdateField<UnitUpdateFields>(3, 22, UnitUpdateFields.UNIT_FIELD_MINOFFHANDDAMAGE),
            new UpdateField<UnitUpdateFields>(3, 22, UnitUpdateFields.UNIT_FIELD_MAXOFFHANDDAMAGE),
            new UpdateField<UnitUpdateFields>(5, 1, UnitUpdateFields.UNIT_FIELD_BYTES_1),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_PETNUMBER),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_PET_NAME_TIMESTAMP),
            new UpdateField<UnitUpdateFields>(1, 4, UnitUpdateFields.UNIT_FIELD_PETEXPERIENCE),
            new UpdateField<UnitUpdateFields>(1, 4, UnitUpdateFields.UNIT_FIELD_PETNEXTLEVELEXP),
            new UpdateField<UnitUpdateFields>(1, 128, UnitUpdateFields.UNIT_DYNAMIC_FLAGS),
            new UpdateField<UnitUpdateFields>(3, 1, UnitUpdateFields.UNIT_MOD_CAST_SPEED),
            new UpdateField<UnitUpdateFields>(3, 1, UnitUpdateFields.UNIT_MOD_CAST_HASTE),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_CREATED_BY_SPELL),
            new UpdateField<UnitUpdateFields>(1, 128, UnitUpdateFields.UNIT_NPC_FLAGS),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_NPC_EMOTESTATE),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_STAT0),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_STAT1),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_STAT2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_STAT3),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_STAT4),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POSSTAT0),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POSSTAT1),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POSSTAT2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POSSTAT3),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POSSTAT4),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_NEGSTAT0),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_NEGSTAT1),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_NEGSTAT2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_NEGSTAT3),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_NEGSTAT4),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES_2),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES_3),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES_4),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES_5),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES_6),
            new UpdateField<UnitUpdateFields>(1, 22, UnitUpdateFields.UNIT_FIELD_RESISTANCES_7),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_3),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_4),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_5),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_6),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_7),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_3),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_4),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_5),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_6),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_7),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_BASE_MANA),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_BASE_HEALTH),
            new UpdateField<UnitUpdateFields>(5, 1, UnitUpdateFields.UNIT_FIELD_BYTES_2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_ATTACK_POWER),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_ATTACK_POWER_MOD_POS),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_ATTACK_POWER_MOD_NEG),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_ATTACK_POWER_MULTIPLIER),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RANGED_ATTACK_POWER),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RANGED_ATTACK_POWER_MOD_POS),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_RANGED_ATTACK_POWER_MOD_NEG),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_MINRANGEDDAMAGE),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_MAXRANGEDDAMAGE),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER_2),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER_3),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER_4),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER_5),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER_6),
            new UpdateField<UnitUpdateFields>(1, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MODIFIER_7),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER_2),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER_3),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER_4),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER_5),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER_6),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_POWER_COST_MULTIPLIER_7),
            new UpdateField<UnitUpdateFields>(3, 6, UnitUpdateFields.UNIT_FIELD_MAXHEALTHMODIFIER),
            new UpdateField<UnitUpdateFields>(3, 1, UnitUpdateFields.UNIT_FIELD_HOVERHEIGHT),
            new UpdateField<UnitUpdateFields>(1, 1, UnitUpdateFields.UNIT_FIELD_MAXITEMLEVEL),
            new UpdateField<UnitUpdateFields>(1, 0, UnitUpdateFields.UNIT_FIELD_PADDING),
        };
        public static UpdateField<UnitUpdateFields> GetUpdateField(UnitUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ObjectUpdateFields.End;
            if (index >= (uint)UnitUpdateFields.End)
                return UpdateField.CreateUnknown<UnitUpdateFields>(uf);

            return _UnitUpdateFields[index];
        }
    }
    public enum UnitUpdateFields : uint
    {
        UNIT_FIELD_CHARM                                              = ObjectUpdateFields.End + 0x0000, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_CHARM_HIPART                                       = ObjectUpdateFields.End + 0x0001,
        UNIT_FIELD_SUMMON                                             = ObjectUpdateFields.End + 0x0002, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_SUMMON_HIPART                                      = ObjectUpdateFields.End + 0x0003,
        UNIT_FIELD_CRITTER                                            = ObjectUpdateFields.End + 0x0004, // Size: 2, Type: Long, Flags: Private
        UNIT_FIELD_CRITTER_HIPART                                     = ObjectUpdateFields.End + 0x0005,
        UNIT_FIELD_CHARMEDBY                                          = ObjectUpdateFields.End + 0x0006, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_CHARMEDBY_HIPART                                   = ObjectUpdateFields.End + 0x0007,
        UNIT_FIELD_SUMMONEDBY                                         = ObjectUpdateFields.End + 0x0008, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_SUMMONEDBY_HIPART                                  = ObjectUpdateFields.End + 0x0009,
        UNIT_FIELD_CREATEDBY                                          = ObjectUpdateFields.End + 0x000A, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_CREATEDBY_HIPART                                   = ObjectUpdateFields.End + 0x000B,
        UNIT_FIELD_TARGET                                             = ObjectUpdateFields.End + 0x000C, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_TARGET_HIPART                                      = ObjectUpdateFields.End + 0x000D,
        UNIT_FIELD_CHANNEL_OBJECT                                     = ObjectUpdateFields.End + 0x000E, // Size: 2, Type: Long, Flags: Public
        UNIT_FIELD_CHANNEL_OBJECT_HIPART                              = ObjectUpdateFields.End + 0x000F,
        UNIT_CHANNEL_SPELL                                            = ObjectUpdateFields.End + 0x0010, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_BYTES_0                                            = ObjectUpdateFields.End + 0x0011, // Size: 1, Type: Bytes, Flags: Public
        UNIT_FIELD_HEALTH                                             = ObjectUpdateFields.End + 0x0012, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_POWER1                                             = ObjectUpdateFields.End + 0x0013, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_POWER2                                             = ObjectUpdateFields.End + 0x0014, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_POWER3                                             = ObjectUpdateFields.End + 0x0015, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_POWER4                                             = ObjectUpdateFields.End + 0x0016, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_POWER5                                             = ObjectUpdateFields.End + 0x0017, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MAXHEALTH                                          = ObjectUpdateFields.End + 0x0018, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MAXPOWER1                                          = ObjectUpdateFields.End + 0x0019, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MAXPOWER2                                          = ObjectUpdateFields.End + 0x001A, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MAXPOWER3                                          = ObjectUpdateFields.End + 0x001B, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MAXPOWER4                                          = ObjectUpdateFields.End + 0x001C, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MAXPOWER5                                          = ObjectUpdateFields.End + 0x001D, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER                          = ObjectUpdateFields.End + 0x001E, // Size: 5, Type: Float, Flags: Private, OwnerOnly, GroupOnly
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_2                        = ObjectUpdateFields.End + 0x001F,
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_3                        = ObjectUpdateFields.End + 0x0020,
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_4                        = ObjectUpdateFields.End + 0x0021,
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_5                        = ObjectUpdateFields.End + 0x0022,
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER              = ObjectUpdateFields.End + 0x0023, // Size: 5, Type: Float, Flags: Private, OwnerOnly, GroupOnly
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_2            = ObjectUpdateFields.End + 0x0024,
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_3            = ObjectUpdateFields.End + 0x0025,
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_4            = ObjectUpdateFields.End + 0x0026,
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_5            = ObjectUpdateFields.End + 0x0027,
        UNIT_FIELD_LEVEL                                              = ObjectUpdateFields.End + 0x0028, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_FACTIONTEMPLATE                                    = ObjectUpdateFields.End + 0x0029, // Size: 1, Type: Int, Flags: Public
        UNIT_VIRTUAL_ITEM_SLOT_ID                                     = ObjectUpdateFields.End + 0x002A, // Size: 3, Type: Int, Flags: Public
        UNIT_VIRTUAL_ITEM_SLOT_ID_2                                   = ObjectUpdateFields.End + 0x002B,
        UNIT_VIRTUAL_ITEM_SLOT_ID_3                                   = ObjectUpdateFields.End + 0x002C,
        UNIT_FIELD_FLAGS                                              = ObjectUpdateFields.End + 0x002D, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_FLAGS_2                                            = ObjectUpdateFields.End + 0x002E, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_AURASTATE                                          = ObjectUpdateFields.End + 0x002F, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_BASEATTACKTIME                                     = ObjectUpdateFields.End + 0x0030, // Size: 2, Type: Int, Flags: Public
        UNIT_FIELD_BASEATTACKTIME_2                                   = ObjectUpdateFields.End + 0x0031,
        UNIT_FIELD_RANGEDATTACKTIME                                   = ObjectUpdateFields.End + 0x0032, // Size: 1, Type: Int, Flags: Private
        UNIT_FIELD_BOUNDINGRADIUS                                     = ObjectUpdateFields.End + 0x0033, // Size: 1, Type: Float, Flags: Public
        UNIT_FIELD_COMBATREACH                                        = ObjectUpdateFields.End + 0x0034, // Size: 1, Type: Float, Flags: Public
        UNIT_FIELD_DISPLAYID                                          = ObjectUpdateFields.End + 0x0035, // Size: 1, Type: Int, Flags: Unk4
        UNIT_FIELD_NATIVEDISPLAYID                                    = ObjectUpdateFields.End + 0x0036, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MOUNTDISPLAYID                                     = ObjectUpdateFields.End + 0x0037, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_MINDAMAGE                                          = ObjectUpdateFields.End + 0x0038, // Size: 1, Type: Float, Flags: Private, OwnerOnly, Unk2
        UNIT_FIELD_MAXDAMAGE                                          = ObjectUpdateFields.End + 0x0039, // Size: 1, Type: Float, Flags: Private, OwnerOnly, Unk2
        UNIT_FIELD_MINOFFHANDDAMAGE                                   = ObjectUpdateFields.End + 0x003A, // Size: 1, Type: Float, Flags: Private, OwnerOnly, Unk2
        UNIT_FIELD_MAXOFFHANDDAMAGE                                   = ObjectUpdateFields.End + 0x003B, // Size: 1, Type: Float, Flags: Private, OwnerOnly, Unk2
        UNIT_FIELD_BYTES_1                                            = ObjectUpdateFields.End + 0x003C, // Size: 1, Type: Bytes, Flags: Public
        UNIT_FIELD_PETNUMBER                                          = ObjectUpdateFields.End + 0x003D, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_PET_NAME_TIMESTAMP                                 = ObjectUpdateFields.End + 0x003E, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_PETEXPERIENCE                                      = ObjectUpdateFields.End + 0x003F, // Size: 1, Type: Int, Flags: OwnerOnly
        UNIT_FIELD_PETNEXTLEVELEXP                                    = ObjectUpdateFields.End + 0x0040, // Size: 1, Type: Int, Flags: OwnerOnly
        UNIT_DYNAMIC_FLAGS                                            = ObjectUpdateFields.End + 0x0041, // Size: 1, Type: Int, Flags: Unk4
        UNIT_MOD_CAST_SPEED                                           = ObjectUpdateFields.End + 0x0042, // Size: 1, Type: Float, Flags: Public
        UNIT_MOD_CAST_HASTE                                           = ObjectUpdateFields.End + 0x0043, // Size: 1, Type: Float, Flags: Public
        UNIT_CREATED_BY_SPELL                                         = ObjectUpdateFields.End + 0x0044, // Size: 1, Type: Int, Flags: Public
        UNIT_NPC_FLAGS                                                = ObjectUpdateFields.End + 0x0045, // Size: 1, Type: Int, Flags: Unk4
        UNIT_NPC_EMOTESTATE                                           = ObjectUpdateFields.End + 0x0046, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_STAT0                                              = ObjectUpdateFields.End + 0x0047, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_STAT1                                              = ObjectUpdateFields.End + 0x0048, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_STAT2                                              = ObjectUpdateFields.End + 0x0049, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_STAT3                                              = ObjectUpdateFields.End + 0x004A, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_STAT4                                              = ObjectUpdateFields.End + 0x004B, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_POSSTAT0                                           = ObjectUpdateFields.End + 0x004C, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_POSSTAT1                                           = ObjectUpdateFields.End + 0x004D, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_POSSTAT2                                           = ObjectUpdateFields.End + 0x004E, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_POSSTAT3                                           = ObjectUpdateFields.End + 0x004F, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_POSSTAT4                                           = ObjectUpdateFields.End + 0x0050, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_NEGSTAT0                                           = ObjectUpdateFields.End + 0x0051, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_NEGSTAT1                                           = ObjectUpdateFields.End + 0x0052, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_NEGSTAT2                                           = ObjectUpdateFields.End + 0x0053, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_NEGSTAT3                                           = ObjectUpdateFields.End + 0x0054, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_NEGSTAT4                                           = ObjectUpdateFields.End + 0x0055, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_RESISTANCES                                        = ObjectUpdateFields.End + 0x0056, // Size: 7, Type: Int, Flags: Private, OwnerOnly, Unk2
        UNIT_FIELD_RESISTANCES_2                                      = ObjectUpdateFields.End + 0x0057,
        UNIT_FIELD_RESISTANCES_3                                      = ObjectUpdateFields.End + 0x0058,
        UNIT_FIELD_RESISTANCES_4                                      = ObjectUpdateFields.End + 0x0059,
        UNIT_FIELD_RESISTANCES_5                                      = ObjectUpdateFields.End + 0x005A,
        UNIT_FIELD_RESISTANCES_6                                      = ObjectUpdateFields.End + 0x005B,
        UNIT_FIELD_RESISTANCES_7                                      = ObjectUpdateFields.End + 0x005C,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE                         = ObjectUpdateFields.End + 0x005D, // Size: 7, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_2                       = ObjectUpdateFields.End + 0x005E,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_3                       = ObjectUpdateFields.End + 0x005F,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_4                       = ObjectUpdateFields.End + 0x0060,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_5                       = ObjectUpdateFields.End + 0x0061,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_6                       = ObjectUpdateFields.End + 0x0062,
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_7                       = ObjectUpdateFields.End + 0x0063,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE                         = ObjectUpdateFields.End + 0x0064, // Size: 7, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_2                       = ObjectUpdateFields.End + 0x0065,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_3                       = ObjectUpdateFields.End + 0x0066,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_4                       = ObjectUpdateFields.End + 0x0067,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_5                       = ObjectUpdateFields.End + 0x0068,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_6                       = ObjectUpdateFields.End + 0x0069,
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_7                       = ObjectUpdateFields.End + 0x006A,
        UNIT_FIELD_BASE_MANA                                          = ObjectUpdateFields.End + 0x006B, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_BASE_HEALTH                                        = ObjectUpdateFields.End + 0x006C, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_BYTES_2                                            = ObjectUpdateFields.End + 0x006D, // Size: 1, Type: Bytes, Flags: Public
        UNIT_FIELD_ATTACK_POWER                                       = ObjectUpdateFields.End + 0x006E, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_ATTACK_POWER_MOD_POS                               = ObjectUpdateFields.End + 0x006F, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_ATTACK_POWER_MOD_NEG                               = ObjectUpdateFields.End + 0x0070, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER                            = ObjectUpdateFields.End + 0x0071, // Size: 1, Type: Float, Flags: Private, OwnerOnly
        UNIT_FIELD_RANGED_ATTACK_POWER                                = ObjectUpdateFields.End + 0x0072, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_POS                        = ObjectUpdateFields.End + 0x0073, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_NEG                        = ObjectUpdateFields.End + 0x0074, // Size: 1, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER                     = ObjectUpdateFields.End + 0x0075, // Size: 1, Type: Float, Flags: Private, OwnerOnly
        UNIT_FIELD_MINRANGEDDAMAGE                                    = ObjectUpdateFields.End + 0x0076, // Size: 1, Type: Float, Flags: Private, OwnerOnly
        UNIT_FIELD_MAXRANGEDDAMAGE                                    = ObjectUpdateFields.End + 0x0077, // Size: 1, Type: Float, Flags: Private, OwnerOnly
        UNIT_FIELD_POWER_COST_MODIFIER                                = ObjectUpdateFields.End + 0x0078, // Size: 7, Type: Int, Flags: Private, OwnerOnly
        UNIT_FIELD_POWER_COST_MODIFIER_2                              = ObjectUpdateFields.End + 0x0079,
        UNIT_FIELD_POWER_COST_MODIFIER_3                              = ObjectUpdateFields.End + 0x007A,
        UNIT_FIELD_POWER_COST_MODIFIER_4                              = ObjectUpdateFields.End + 0x007B,
        UNIT_FIELD_POWER_COST_MODIFIER_5                              = ObjectUpdateFields.End + 0x007C,
        UNIT_FIELD_POWER_COST_MODIFIER_6                              = ObjectUpdateFields.End + 0x007D,
        UNIT_FIELD_POWER_COST_MODIFIER_7                              = ObjectUpdateFields.End + 0x007E,
        UNIT_FIELD_POWER_COST_MULTIPLIER                              = ObjectUpdateFields.End + 0x007F, // Size: 7, Type: Float, Flags: Private, OwnerOnly
        UNIT_FIELD_POWER_COST_MULTIPLIER_2                            = ObjectUpdateFields.End + 0x0080,
        UNIT_FIELD_POWER_COST_MULTIPLIER_3                            = ObjectUpdateFields.End + 0x0081,
        UNIT_FIELD_POWER_COST_MULTIPLIER_4                            = ObjectUpdateFields.End + 0x0082,
        UNIT_FIELD_POWER_COST_MULTIPLIER_5                            = ObjectUpdateFields.End + 0x0083,
        UNIT_FIELD_POWER_COST_MULTIPLIER_6                            = ObjectUpdateFields.End + 0x0084,
        UNIT_FIELD_POWER_COST_MULTIPLIER_7                            = ObjectUpdateFields.End + 0x0085,
        UNIT_FIELD_MAXHEALTHMODIFIER                                  = ObjectUpdateFields.End + 0x0086, // Size: 1, Type: Float, Flags: Private, OwnerOnly
        UNIT_FIELD_HOVERHEIGHT                                        = ObjectUpdateFields.End + 0x0087, // Size: 1, Type: Float, Flags: Public
        UNIT_FIELD_MAXITEMLEVEL                                       = ObjectUpdateFields.End + 0x0088, // Size: 1, Type: Int, Flags: Public
        UNIT_FIELD_PADDING                                            = ObjectUpdateFields.End + 0x0089, // Size: 1, Type: Int, Flags: None
        End                                                           = ObjectUpdateFields.End + 0x008A
    }

    public partial class UpdateFields
    {
        private static UpdateField<PlayerUpdateFields>[] _PlayerUpdateFields = new UpdateField<PlayerUpdateFields>[]
        {
            new UpdateField<PlayerUpdateFields>(4, 1, PlayerUpdateFields.PLAYER_DUEL_ARBITER),
            new UpdateField<PlayerUpdateFields>(4, 1, PlayerUpdateFields.PLAYER_DUEL_ARBITER_HIPART),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_FLAGS),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_GUILDRANK),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_GUILDDELETE_DATE),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_GUILDLEVEL),
            new UpdateField<PlayerUpdateFields>(5, 1, PlayerUpdateFields.PLAYER_BYTES),
            new UpdateField<PlayerUpdateFields>(5, 1, PlayerUpdateFields.PLAYER_BYTES_2),
            new UpdateField<PlayerUpdateFields>(5, 1, PlayerUpdateFields.PLAYER_BYTES_3),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_DUEL_TEAM),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_GUILD_TIMESTAMP),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_1_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_1_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_1_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_1_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_1_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_2_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_2_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_2_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_2_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_2_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_3_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_3_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_3_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_3_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_3_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_4_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_4_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_4_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_4_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_4_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_5_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_5_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_5_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_5_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_5_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_6_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_6_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_6_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_6_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_6_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_7_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_7_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_7_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_7_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_7_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_8_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_8_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_8_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_8_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_8_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_9_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_9_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_9_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_9_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_9_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_10_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_10_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_10_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_10_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_10_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_11_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_11_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_11_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_11_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_11_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_12_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_12_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_12_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_12_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_12_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_13_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_13_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_13_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_13_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_13_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_14_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_14_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_14_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_14_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_14_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_15_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_15_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_15_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_15_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_15_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_16_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_16_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_16_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_16_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_16_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_17_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_17_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_17_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_17_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_17_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_18_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_18_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_18_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_18_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_18_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_19_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_19_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_19_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_19_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_19_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_20_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_20_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_20_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_20_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_20_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_21_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_21_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_21_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_21_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_21_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_22_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_22_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_22_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_22_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_22_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_23_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_23_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_23_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_23_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_23_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_24_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_24_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_24_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_24_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_24_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_25_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_25_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_25_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_25_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_25_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_26_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_26_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_26_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_26_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_26_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_27_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_27_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_27_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_27_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_27_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_28_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_28_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_28_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_28_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_28_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_29_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_29_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_29_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_29_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_29_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_30_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_30_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_30_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_30_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_30_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_31_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_31_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_31_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_31_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_31_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_32_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_32_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_32_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_32_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_32_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_33_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_33_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_33_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_33_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_33_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_34_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_34_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_34_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_34_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_34_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_35_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_35_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_35_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_35_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_35_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_36_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_36_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_36_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_36_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_36_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_37_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_37_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_37_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_37_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_37_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_38_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_38_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_38_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_38_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_38_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_39_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_39_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_39_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_39_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_39_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_40_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_40_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_40_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_40_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_40_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_41_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_41_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_41_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_41_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_41_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_42_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_42_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_42_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_42_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_42_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_43_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_43_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_43_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_43_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_43_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_44_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_44_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_44_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_44_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_44_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_45_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_45_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_45_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_45_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_45_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_46_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_46_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_46_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_46_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_46_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_47_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_47_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_47_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_47_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_47_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_48_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_48_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_48_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_48_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_48_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_49_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_49_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_49_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_49_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_49_5),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_50_1),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_50_2),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_50_3),
            new UpdateField<PlayerUpdateFields>(2, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_50_4),
            new UpdateField<PlayerUpdateFields>(1, 32, PlayerUpdateFields.PLAYER_QUEST_LOG_50_5),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_1_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_1_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_2_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_2_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_3_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_3_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_4_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_4_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_5_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_5_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_6_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_6_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_7_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_7_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_8_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_8_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_9_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_9_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_10_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_10_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_11_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_11_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_12_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_12_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_13_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_13_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_14_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_14_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_15_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_15_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_16_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_16_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_17_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_17_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_18_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_18_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_19_ENTRYID),
            new UpdateField<PlayerUpdateFields>(2, 1, PlayerUpdateFields.PLAYER_VISIBLE_ITEM_19_ENCHANTMENT),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_CHOSEN_TITLE),
            new UpdateField<PlayerUpdateFields>(1, 1, PlayerUpdateFields.PLAYER_FAKE_INEBRIATION),
            new UpdateField<PlayerUpdateFields>(1, 0, PlayerUpdateFields.PLAYER_FIELD_PAD_0),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_2),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_2_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_3),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_3_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_4),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_4_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_5),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_5_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_6),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_6_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_7),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_7_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_8),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_8_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_9),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_9_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_10),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_10_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_11),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_11_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_12),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_12_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_13),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_13_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_14),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_14_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_15),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_15_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_16),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_16_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_17),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_17_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_18),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_18_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_19),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_19_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_20),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_20_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_21),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_21_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_22),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_22_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_23),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD_23_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_1),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_1_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_2),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_2_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_3),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_3_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_4),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_4_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_5),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_5_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_6),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_6_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_7),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_7_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_8),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_8_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_9),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_9_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_10),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_10_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_11),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_11_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_12),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_12_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_13),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_13_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_14),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_14_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_15),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_15_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_16),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_PACK_SLOT_16_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_1),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_1_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_2),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_2_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_3),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_3_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_4),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_4_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_5),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_5_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_6),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_6_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_7),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_7_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_8),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_8_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_9),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_9_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_10),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_10_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_11),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_11_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_12),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_12_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_13),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_13_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_14),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_14_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_15),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_15_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_16),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_16_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_17),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_17_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_18),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_18_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_19),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_19_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_20),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_20_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_21),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_21_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_22),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_22_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_23),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_23_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_24),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_24_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_25),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_25_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_26),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_26_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_27),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_27_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_28),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANK_SLOT_28_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_1),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_1_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_2),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_2_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_3),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_3_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_4),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_4_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_5),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_5_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_6),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_6_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_7),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_BANKBAG_SLOT_7_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_1),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_1_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_2),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_2_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_3),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_3_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_4),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_4_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_5),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_5_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_6),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_6_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_7),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_7_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_8),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_8_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_9),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_9_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_10),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_10_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_11),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_11_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_12),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_VENDORBUYBACK_SLOT_12_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FARSIGHT),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FARSIGHT_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES1),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES1_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES2),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES2_HIPART),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES3),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER__FIELD_KNOWN_TITLES3_HIPART),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_XP),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_NEXT_LEVEL_XP),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_0),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_9),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_10),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_11),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_13),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_14),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_15),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_16),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_17),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_18),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_19),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_20),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_21),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_22),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_23),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_24),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_25),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_26),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_27),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_28),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_29),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_30),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_31),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_32),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_33),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_34),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_35),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_36),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_37),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_38),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_39),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_40),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_41),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_42),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_43),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_44),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_45),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_46),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_47),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_48),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_49),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_50),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_51),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_52),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_53),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_54),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_55),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_56),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_57),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_58),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_59),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_60),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_61),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_62),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_LINEID_63),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_0),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_9),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_10),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_11),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_13),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_14),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_15),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_16),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_17),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_18),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_19),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_20),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_21),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_22),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_23),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_24),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_25),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_26),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_27),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_28),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_29),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_30),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_31),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_32),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_33),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_34),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_35),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_36),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_37),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_38),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_39),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_40),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_41),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_42),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_43),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_44),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_45),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_46),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_47),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_48),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_49),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_50),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_51),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_52),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_53),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_54),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_55),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_56),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_57),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_58),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_59),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_60),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_61),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_62),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_STEP_63),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_0),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_9),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_10),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_11),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_13),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_14),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_15),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_16),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_17),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_18),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_19),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_20),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_21),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_22),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_23),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_24),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_25),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_26),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_27),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_28),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_29),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_30),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_31),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_32),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_33),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_34),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_35),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_36),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_37),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_38),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_39),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_40),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_41),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_42),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_43),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_44),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_45),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_46),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_47),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_48),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_49),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_50),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_51),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_52),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_53),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_54),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_55),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_56),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_57),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_58),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_59),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_60),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_61),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_62),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_RANK_63),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_0),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_9),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_10),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_11),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_13),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_14),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_15),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_16),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_17),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_18),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_19),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_20),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_21),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_22),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_23),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_24),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_25),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_26),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_27),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_28),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_29),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_30),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_31),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_32),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_33),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_34),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_35),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_36),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_37),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_38),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_39),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_40),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_41),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_42),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_43),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_44),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_45),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_46),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_47),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_48),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_49),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_50),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_51),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_52),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_53),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_54),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_55),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_56),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_57),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_58),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_59),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_60),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_61),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_62),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MAX_RANK_63),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_0),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_9),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_10),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_11),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_13),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_14),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_15),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_16),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_17),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_18),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_19),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_20),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_21),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_22),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_23),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_24),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_25),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_26),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_27),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_28),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_29),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_30),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_31),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_32),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_33),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_34),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_35),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_36),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_37),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_38),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_39),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_40),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_41),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_42),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_43),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_44),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_45),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_46),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_47),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_48),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_49),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_50),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_51),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_52),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_53),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_54),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_55),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_56),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_57),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_58),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_59),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_60),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_61),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_62),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_MODIFIER_63),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_0),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_9),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_10),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_11),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_13),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_14),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_15),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_16),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_17),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_18),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_19),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_20),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_21),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_22),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_23),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_24),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_25),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_26),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_27),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_28),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_29),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_30),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_31),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_32),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_33),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_34),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_35),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_36),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_37),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_38),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_39),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_40),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_41),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_42),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_43),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_44),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_45),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_46),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_47),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_48),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_49),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_50),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_51),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_52),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_53),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_54),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_55),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_56),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_57),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_58),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_59),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_60),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_61),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_62),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_SKILL_TALENT_63),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_CHARACTER_POINTS),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_TRACK_CREATURES),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_TRACK_RESOURCES),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_EXPERTISE),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_OFFHAND_EXPERTISE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_BLOCK_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_DODGE_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_PARRY_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_CRIT_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_RANGED_CRIT_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_OFFHAND_CRIT_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1_2),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1_3),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1_4),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1_5),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1_6),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SPELL_CRIT_PERCENTAGE1_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_SHIELD_BLOCK),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_MASTERY),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_1),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_2),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_3),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_4),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_5),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_6),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_7),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_8),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_9),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_10),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_11),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_12),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_13),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_14),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_15),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_16),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_17),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_18),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_19),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_20),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_21),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_22),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_23),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_24),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_25),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_26),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_27),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_28),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_29),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_30),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_31),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_32),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_33),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_34),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_35),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_36),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_37),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_38),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_39),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_40),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_41),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_42),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_43),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_44),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_45),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_46),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_47),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_48),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_49),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_50),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_51),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_52),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_53),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_54),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_55),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_56),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_57),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_58),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_59),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_60),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_61),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_62),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_63),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_64),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_65),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_66),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_67),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_68),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_69),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_70),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_71),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_72),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_73),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_74),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_75),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_76),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_77),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_78),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_79),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_80),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_81),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_82),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_83),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_84),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_85),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_86),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_87),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_88),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_89),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_90),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_91),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_92),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_93),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_94),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_95),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_96),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_97),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_98),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_99),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_100),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_101),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_102),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_103),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_104),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_105),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_106),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_107),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_108),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_109),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_110),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_111),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_112),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_113),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_114),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_115),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_116),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_117),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_118),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_119),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_120),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_121),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_122),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_123),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_124),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_125),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_126),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_127),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_128),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_129),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_130),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_131),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_132),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_133),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_134),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_135),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_136),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_137),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_138),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_139),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_140),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_141),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_142),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_143),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_144),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_145),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_146),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_147),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_148),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_149),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_150),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_151),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_152),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_153),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_154),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_155),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_EXPLORED_ZONES_156),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_REST_STATE_EXPERIENCE),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_COINAGE),
            new UpdateField<PlayerUpdateFields>(4, 2, PlayerUpdateFields.PLAYER_FIELD_COINAGE_HIPART),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_POS_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_HEALING_DONE_POS),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_HEALING_PCT),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_HEALING_DONE_PCT),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS_2),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS_3),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_SPELL_POWER_PCT),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_OVERRIDE_SPELL_POWER_BY_AP_PCT),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_TARGET_RESISTANCE),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE),
            new UpdateField<PlayerUpdateFields>(5, 2, PlayerUpdateFields.PLAYER_FIELD_BYTES),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_SELF_RES_SPELL),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_PVP_MEDALS),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_10),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_11),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_PRICE_12),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_10),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_11),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BUYBACK_TIMESTAMP_12),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_KILLS),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_LIFETIME_HONORBALE_KILLS),
            new UpdateField<PlayerUpdateFields>(6, 2, PlayerUpdateFields.PLAYER_FIELD_BYTES2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_WATCHED_FACTION_INDEX),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_10),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_11),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_12),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_13),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_14),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_15),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_16),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_17),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_18),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_19),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_20),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_21),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_22),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_23),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_24),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_25),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_COMBAT_RATING_26),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_10),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_11),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_12),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_13),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_14),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_15),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_16),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_17),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_18),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_19),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_20),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_ARENA_TEAM_INFO_1_21),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_BATTLEGROUND_RATING),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_MAX_LEVEL),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_10),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_11),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_12),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_13),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_14),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_15),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_16),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_17),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_18),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_19),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_20),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_21),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_22),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_23),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_24),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_DAILY_QUESTS_25),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_RUNE_REGEN_1),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_RUNE_REGEN_2),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_RUNE_REGEN_3),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_RUNE_REGEN_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_NO_REAGENT_COST_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_NO_REAGENT_COST_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_NO_REAGENT_COST_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPH_SLOTS_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_2),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_3),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_4),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_5),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_6),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_7),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_GLYPHS_9),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_GLYPHS_ENABLED),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_PET_SPELL_POWER),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESEARCHING_8),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_1),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_2),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_3),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_4),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_5),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_6),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_7),
            new UpdateField<PlayerUpdateFields>(2, 2, PlayerUpdateFields.PLAYER_FIELD_RESERACH_SITE_8),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_PROFESSION_SKILL_LINE_1),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_PROFESSION_SKILL_LINE_2),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_UI_HIT_MODIFIER),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_UI_SPELL_HIT_MODIFIER),
            new UpdateField<PlayerUpdateFields>(1, 2, PlayerUpdateFields.PLAYER_FIELD_HOME_REALM_TIME_OFFSET),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_HASTE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_RANGED_HASTE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_PET_HASTE),
            new UpdateField<PlayerUpdateFields>(3, 2, PlayerUpdateFields.PLAYER_FIELD_MOD_HASTE_REGEN),
        };
        public static UpdateField<PlayerUpdateFields> GetUpdateField(PlayerUpdateFields uf)
        {
            uint index = (uint)uf - (uint)UnitUpdateFields.End;
            if (index >= (uint)PlayerUpdateFields.End)
                return UpdateField.CreateUnknown<PlayerUpdateFields>(uf);

            return _PlayerUpdateFields[index];
        }
    }
    public enum PlayerUpdateFields : uint
    {
        PLAYER_DUEL_ARBITER                                           = UnitUpdateFields.End + 0x0000, // Size: 2, Type: Long, Flags: Public
        PLAYER_DUEL_ARBITER_HIPART                                    = UnitUpdateFields.End + 0x0001,
        PLAYER_FLAGS                                                  = UnitUpdateFields.End + 0x0002, // Size: 1, Type: Int, Flags: Public
        PLAYER_GUILDRANK                                              = UnitUpdateFields.End + 0x0003, // Size: 1, Type: Int, Flags: Public
        PLAYER_GUILDDELETE_DATE                                       = UnitUpdateFields.End + 0x0004, // Size: 1, Type: Int, Flags: Public
        PLAYER_GUILDLEVEL                                             = UnitUpdateFields.End + 0x0005, // Size: 1, Type: Int, Flags: Public
        PLAYER_BYTES                                                  = UnitUpdateFields.End + 0x0006, // Size: 1, Type: Bytes, Flags: Public
        PLAYER_BYTES_2                                                = UnitUpdateFields.End + 0x0007, // Size: 1, Type: Bytes, Flags: Public
        PLAYER_BYTES_3                                                = UnitUpdateFields.End + 0x0008, // Size: 1, Type: Bytes, Flags: Public
        PLAYER_DUEL_TEAM                                              = UnitUpdateFields.End + 0x0009, // Size: 1, Type: Int, Flags: Public
        PLAYER_GUILD_TIMESTAMP                                        = UnitUpdateFields.End + 0x000A, // Size: 1, Type: Int, Flags: Public
        PLAYER_QUEST_LOG_1_1                                          = UnitUpdateFields.End + 0x000B, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_1_2                                          = UnitUpdateFields.End + 0x000C, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_1_3                                          = UnitUpdateFields.End + 0x000D, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_1_4                                          = UnitUpdateFields.End + 0x000E,
        PLAYER_QUEST_LOG_1_5                                          = UnitUpdateFields.End + 0x000F, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_2_1                                          = UnitUpdateFields.End + 0x0010, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_2_2                                          = UnitUpdateFields.End + 0x0011, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_2_3                                          = UnitUpdateFields.End + 0x0012, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_2_4                                          = UnitUpdateFields.End + 0x0013,
        PLAYER_QUEST_LOG_2_5                                          = UnitUpdateFields.End + 0x0014, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_3_1                                          = UnitUpdateFields.End + 0x0015, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_3_2                                          = UnitUpdateFields.End + 0x0016, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_3_3                                          = UnitUpdateFields.End + 0x0017, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_3_4                                          = UnitUpdateFields.End + 0x0018,
        PLAYER_QUEST_LOG_3_5                                          = UnitUpdateFields.End + 0x0019, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_4_1                                          = UnitUpdateFields.End + 0x001A, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_4_2                                          = UnitUpdateFields.End + 0x001B, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_4_3                                          = UnitUpdateFields.End + 0x001C, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_4_4                                          = UnitUpdateFields.End + 0x001D,
        PLAYER_QUEST_LOG_4_5                                          = UnitUpdateFields.End + 0x001E, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_5_1                                          = UnitUpdateFields.End + 0x001F, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_5_2                                          = UnitUpdateFields.End + 0x0020, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_5_3                                          = UnitUpdateFields.End + 0x0021, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_5_4                                          = UnitUpdateFields.End + 0x0022,
        PLAYER_QUEST_LOG_5_5                                          = UnitUpdateFields.End + 0x0023, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_6_1                                          = UnitUpdateFields.End + 0x0024, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_6_2                                          = UnitUpdateFields.End + 0x0025, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_6_3                                          = UnitUpdateFields.End + 0x0026, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_6_4                                          = UnitUpdateFields.End + 0x0027,
        PLAYER_QUEST_LOG_6_5                                          = UnitUpdateFields.End + 0x0028, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_7_1                                          = UnitUpdateFields.End + 0x0029, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_7_2                                          = UnitUpdateFields.End + 0x002A, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_7_3                                          = UnitUpdateFields.End + 0x002B, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_7_4                                          = UnitUpdateFields.End + 0x002C,
        PLAYER_QUEST_LOG_7_5                                          = UnitUpdateFields.End + 0x002D, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_8_1                                          = UnitUpdateFields.End + 0x002E, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_8_2                                          = UnitUpdateFields.End + 0x002F, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_8_3                                          = UnitUpdateFields.End + 0x0030, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_8_4                                          = UnitUpdateFields.End + 0x0031,
        PLAYER_QUEST_LOG_8_5                                          = UnitUpdateFields.End + 0x0032, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_9_1                                          = UnitUpdateFields.End + 0x0033, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_9_2                                          = UnitUpdateFields.End + 0x0034, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_9_3                                          = UnitUpdateFields.End + 0x0035, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_9_4                                          = UnitUpdateFields.End + 0x0036,
        PLAYER_QUEST_LOG_9_5                                          = UnitUpdateFields.End + 0x0037, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_10_1                                         = UnitUpdateFields.End + 0x0038, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_10_2                                         = UnitUpdateFields.End + 0x0039, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_10_3                                         = UnitUpdateFields.End + 0x003A, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_10_4                                         = UnitUpdateFields.End + 0x003B,
        PLAYER_QUEST_LOG_10_5                                         = UnitUpdateFields.End + 0x003C, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_11_1                                         = UnitUpdateFields.End + 0x003D, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_11_2                                         = UnitUpdateFields.End + 0x003E, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_11_3                                         = UnitUpdateFields.End + 0x003F, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_11_4                                         = UnitUpdateFields.End + 0x0040,
        PLAYER_QUEST_LOG_11_5                                         = UnitUpdateFields.End + 0x0041, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_12_1                                         = UnitUpdateFields.End + 0x0042, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_12_2                                         = UnitUpdateFields.End + 0x0043, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_12_3                                         = UnitUpdateFields.End + 0x0044, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_12_4                                         = UnitUpdateFields.End + 0x0045,
        PLAYER_QUEST_LOG_12_5                                         = UnitUpdateFields.End + 0x0046, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_13_1                                         = UnitUpdateFields.End + 0x0047, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_13_2                                         = UnitUpdateFields.End + 0x0048, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_13_3                                         = UnitUpdateFields.End + 0x0049, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_13_4                                         = UnitUpdateFields.End + 0x004A,
        PLAYER_QUEST_LOG_13_5                                         = UnitUpdateFields.End + 0x004B, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_14_1                                         = UnitUpdateFields.End + 0x004C, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_14_2                                         = UnitUpdateFields.End + 0x004D, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_14_3                                         = UnitUpdateFields.End + 0x004E, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_14_4                                         = UnitUpdateFields.End + 0x004F,
        PLAYER_QUEST_LOG_14_5                                         = UnitUpdateFields.End + 0x0050, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_15_1                                         = UnitUpdateFields.End + 0x0051, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_15_2                                         = UnitUpdateFields.End + 0x0052, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_15_3                                         = UnitUpdateFields.End + 0x0053, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_15_4                                         = UnitUpdateFields.End + 0x0054,
        PLAYER_QUEST_LOG_15_5                                         = UnitUpdateFields.End + 0x0055, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_16_1                                         = UnitUpdateFields.End + 0x0056, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_16_2                                         = UnitUpdateFields.End + 0x0057, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_16_3                                         = UnitUpdateFields.End + 0x0058, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_16_4                                         = UnitUpdateFields.End + 0x0059,
        PLAYER_QUEST_LOG_16_5                                         = UnitUpdateFields.End + 0x005A, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_17_1                                         = UnitUpdateFields.End + 0x005B, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_17_2                                         = UnitUpdateFields.End + 0x005C, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_17_3                                         = UnitUpdateFields.End + 0x005D, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_17_4                                         = UnitUpdateFields.End + 0x005E,
        PLAYER_QUEST_LOG_17_5                                         = UnitUpdateFields.End + 0x005F, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_18_1                                         = UnitUpdateFields.End + 0x0060, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_18_2                                         = UnitUpdateFields.End + 0x0061, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_18_3                                         = UnitUpdateFields.End + 0x0062, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_18_4                                         = UnitUpdateFields.End + 0x0063,
        PLAYER_QUEST_LOG_18_5                                         = UnitUpdateFields.End + 0x0064, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_19_1                                         = UnitUpdateFields.End + 0x0065, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_19_2                                         = UnitUpdateFields.End + 0x0066, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_19_3                                         = UnitUpdateFields.End + 0x0067, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_19_4                                         = UnitUpdateFields.End + 0x0068,
        PLAYER_QUEST_LOG_19_5                                         = UnitUpdateFields.End + 0x0069, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_20_1                                         = UnitUpdateFields.End + 0x006A, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_20_2                                         = UnitUpdateFields.End + 0x006B, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_20_3                                         = UnitUpdateFields.End + 0x006C, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_20_4                                         = UnitUpdateFields.End + 0x006D,
        PLAYER_QUEST_LOG_20_5                                         = UnitUpdateFields.End + 0x006E, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_21_1                                         = UnitUpdateFields.End + 0x006F, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_21_2                                         = UnitUpdateFields.End + 0x0070, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_21_3                                         = UnitUpdateFields.End + 0x0071, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_21_4                                         = UnitUpdateFields.End + 0x0072,
        PLAYER_QUEST_LOG_21_5                                         = UnitUpdateFields.End + 0x0073, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_22_1                                         = UnitUpdateFields.End + 0x0074, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_22_2                                         = UnitUpdateFields.End + 0x0075, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_22_3                                         = UnitUpdateFields.End + 0x0076, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_22_4                                         = UnitUpdateFields.End + 0x0077,
        PLAYER_QUEST_LOG_22_5                                         = UnitUpdateFields.End + 0x0078, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_23_1                                         = UnitUpdateFields.End + 0x0079, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_23_2                                         = UnitUpdateFields.End + 0x007A, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_23_3                                         = UnitUpdateFields.End + 0x007B, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_23_4                                         = UnitUpdateFields.End + 0x007C,
        PLAYER_QUEST_LOG_23_5                                         = UnitUpdateFields.End + 0x007D, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_24_1                                         = UnitUpdateFields.End + 0x007E, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_24_2                                         = UnitUpdateFields.End + 0x007F, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_24_3                                         = UnitUpdateFields.End + 0x0080, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_24_4                                         = UnitUpdateFields.End + 0x0081,
        PLAYER_QUEST_LOG_24_5                                         = UnitUpdateFields.End + 0x0082, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_25_1                                         = UnitUpdateFields.End + 0x0083, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_25_2                                         = UnitUpdateFields.End + 0x0084, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_25_3                                         = UnitUpdateFields.End + 0x0085, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_25_4                                         = UnitUpdateFields.End + 0x0086,
        PLAYER_QUEST_LOG_25_5                                         = UnitUpdateFields.End + 0x0087, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_26_1                                         = UnitUpdateFields.End + 0x0088, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_26_2                                         = UnitUpdateFields.End + 0x0089, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_26_3                                         = UnitUpdateFields.End + 0x008A, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_26_4                                         = UnitUpdateFields.End + 0x008B,
        PLAYER_QUEST_LOG_26_5                                         = UnitUpdateFields.End + 0x008C, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_27_1                                         = UnitUpdateFields.End + 0x008D, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_27_2                                         = UnitUpdateFields.End + 0x008E, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_27_3                                         = UnitUpdateFields.End + 0x008F, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_27_4                                         = UnitUpdateFields.End + 0x0090,
        PLAYER_QUEST_LOG_27_5                                         = UnitUpdateFields.End + 0x0091, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_28_1                                         = UnitUpdateFields.End + 0x0092, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_28_2                                         = UnitUpdateFields.End + 0x0093, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_28_3                                         = UnitUpdateFields.End + 0x0094, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_28_4                                         = UnitUpdateFields.End + 0x0095,
        PLAYER_QUEST_LOG_28_5                                         = UnitUpdateFields.End + 0x0096, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_29_1                                         = UnitUpdateFields.End + 0x0097, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_29_2                                         = UnitUpdateFields.End + 0x0098, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_29_3                                         = UnitUpdateFields.End + 0x0099, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_29_4                                         = UnitUpdateFields.End + 0x009A,
        PLAYER_QUEST_LOG_29_5                                         = UnitUpdateFields.End + 0x009B, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_30_1                                         = UnitUpdateFields.End + 0x009C, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_30_2                                         = UnitUpdateFields.End + 0x009D, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_30_3                                         = UnitUpdateFields.End + 0x009E, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_30_4                                         = UnitUpdateFields.End + 0x009F,
        PLAYER_QUEST_LOG_30_5                                         = UnitUpdateFields.End + 0x00A0, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_31_1                                         = UnitUpdateFields.End + 0x00A1, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_31_2                                         = UnitUpdateFields.End + 0x00A2, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_31_3                                         = UnitUpdateFields.End + 0x00A3, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_31_4                                         = UnitUpdateFields.End + 0x00A4,
        PLAYER_QUEST_LOG_31_5                                         = UnitUpdateFields.End + 0x00A5, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_32_1                                         = UnitUpdateFields.End + 0x00A6, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_32_2                                         = UnitUpdateFields.End + 0x00A7, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_32_3                                         = UnitUpdateFields.End + 0x00A8, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_32_4                                         = UnitUpdateFields.End + 0x00A9,
        PLAYER_QUEST_LOG_32_5                                         = UnitUpdateFields.End + 0x00AA, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_33_1                                         = UnitUpdateFields.End + 0x00AB, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_33_2                                         = UnitUpdateFields.End + 0x00AC, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_33_3                                         = UnitUpdateFields.End + 0x00AD, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_33_4                                         = UnitUpdateFields.End + 0x00AE,
        PLAYER_QUEST_LOG_33_5                                         = UnitUpdateFields.End + 0x00AF, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_34_1                                         = UnitUpdateFields.End + 0x00B0, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_34_2                                         = UnitUpdateFields.End + 0x00B1, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_34_3                                         = UnitUpdateFields.End + 0x00B2, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_34_4                                         = UnitUpdateFields.End + 0x00B3,
        PLAYER_QUEST_LOG_34_5                                         = UnitUpdateFields.End + 0x00B4, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_35_1                                         = UnitUpdateFields.End + 0x00B5, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_35_2                                         = UnitUpdateFields.End + 0x00B6, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_35_3                                         = UnitUpdateFields.End + 0x00B7, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_35_4                                         = UnitUpdateFields.End + 0x00B8,
        PLAYER_QUEST_LOG_35_5                                         = UnitUpdateFields.End + 0x00B9, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_36_1                                         = UnitUpdateFields.End + 0x00BA, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_36_2                                         = UnitUpdateFields.End + 0x00BB, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_36_3                                         = UnitUpdateFields.End + 0x00BC, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_36_4                                         = UnitUpdateFields.End + 0x00BD,
        PLAYER_QUEST_LOG_36_5                                         = UnitUpdateFields.End + 0x00BE, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_37_1                                         = UnitUpdateFields.End + 0x00BF, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_37_2                                         = UnitUpdateFields.End + 0x00C0, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_37_3                                         = UnitUpdateFields.End + 0x00C1, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_37_4                                         = UnitUpdateFields.End + 0x00C2,
        PLAYER_QUEST_LOG_37_5                                         = UnitUpdateFields.End + 0x00C3, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_38_1                                         = UnitUpdateFields.End + 0x00C4, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_38_2                                         = UnitUpdateFields.End + 0x00C5, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_38_3                                         = UnitUpdateFields.End + 0x00C6, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_38_4                                         = UnitUpdateFields.End + 0x00C7,
        PLAYER_QUEST_LOG_38_5                                         = UnitUpdateFields.End + 0x00C8, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_39_1                                         = UnitUpdateFields.End + 0x00C9, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_39_2                                         = UnitUpdateFields.End + 0x00CA, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_39_3                                         = UnitUpdateFields.End + 0x00CB, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_39_4                                         = UnitUpdateFields.End + 0x00CC,
        PLAYER_QUEST_LOG_39_5                                         = UnitUpdateFields.End + 0x00CD, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_40_1                                         = UnitUpdateFields.End + 0x00CE, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_40_2                                         = UnitUpdateFields.End + 0x00CF, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_40_3                                         = UnitUpdateFields.End + 0x00D0, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_40_4                                         = UnitUpdateFields.End + 0x00D1,
        PLAYER_QUEST_LOG_40_5                                         = UnitUpdateFields.End + 0x00D2, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_41_1                                         = UnitUpdateFields.End + 0x00D3, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_41_2                                         = UnitUpdateFields.End + 0x00D4, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_41_3                                         = UnitUpdateFields.End + 0x00D5, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_41_4                                         = UnitUpdateFields.End + 0x00D6,
        PLAYER_QUEST_LOG_41_5                                         = UnitUpdateFields.End + 0x00D7, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_42_1                                         = UnitUpdateFields.End + 0x00D8, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_42_2                                         = UnitUpdateFields.End + 0x00D9, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_42_3                                         = UnitUpdateFields.End + 0x00DA, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_42_4                                         = UnitUpdateFields.End + 0x00DB,
        PLAYER_QUEST_LOG_42_5                                         = UnitUpdateFields.End + 0x00DC, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_43_1                                         = UnitUpdateFields.End + 0x00DD, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_43_2                                         = UnitUpdateFields.End + 0x00DE, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_43_3                                         = UnitUpdateFields.End + 0x00DF, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_43_4                                         = UnitUpdateFields.End + 0x00E0,
        PLAYER_QUEST_LOG_43_5                                         = UnitUpdateFields.End + 0x00E1, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_44_1                                         = UnitUpdateFields.End + 0x00E2, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_44_2                                         = UnitUpdateFields.End + 0x00E3, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_44_3                                         = UnitUpdateFields.End + 0x00E4, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_44_4                                         = UnitUpdateFields.End + 0x00E5,
        PLAYER_QUEST_LOG_44_5                                         = UnitUpdateFields.End + 0x00E6, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_45_1                                         = UnitUpdateFields.End + 0x00E7, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_45_2                                         = UnitUpdateFields.End + 0x00E8, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_45_3                                         = UnitUpdateFields.End + 0x00E9, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_45_4                                         = UnitUpdateFields.End + 0x00EA,
        PLAYER_QUEST_LOG_45_5                                         = UnitUpdateFields.End + 0x00EB, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_46_1                                         = UnitUpdateFields.End + 0x00EC, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_46_2                                         = UnitUpdateFields.End + 0x00ED, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_46_3                                         = UnitUpdateFields.End + 0x00EE, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_46_4                                         = UnitUpdateFields.End + 0x00EF,
        PLAYER_QUEST_LOG_46_5                                         = UnitUpdateFields.End + 0x00F0, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_47_1                                         = UnitUpdateFields.End + 0x00F1, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_47_2                                         = UnitUpdateFields.End + 0x00F2, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_47_3                                         = UnitUpdateFields.End + 0x00F3, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_47_4                                         = UnitUpdateFields.End + 0x00F4,
        PLAYER_QUEST_LOG_47_5                                         = UnitUpdateFields.End + 0x00F5, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_48_1                                         = UnitUpdateFields.End + 0x00F6, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_48_2                                         = UnitUpdateFields.End + 0x00F7, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_48_3                                         = UnitUpdateFields.End + 0x00F8, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_48_4                                         = UnitUpdateFields.End + 0x00F9,
        PLAYER_QUEST_LOG_48_5                                         = UnitUpdateFields.End + 0x00FA, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_49_1                                         = UnitUpdateFields.End + 0x00FB, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_49_2                                         = UnitUpdateFields.End + 0x00FC, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_49_3                                         = UnitUpdateFields.End + 0x00FD, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_49_4                                         = UnitUpdateFields.End + 0x00FE,
        PLAYER_QUEST_LOG_49_5                                         = UnitUpdateFields.End + 0x00FF, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_50_1                                         = UnitUpdateFields.End + 0x0100, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_50_2                                         = UnitUpdateFields.End + 0x0101, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_QUEST_LOG_50_3                                         = UnitUpdateFields.End + 0x0102, // Size: 2, Type: TwoShort, Flags: Unk3
        PLAYER_QUEST_LOG_50_4                                         = UnitUpdateFields.End + 0x0103,
        PLAYER_QUEST_LOG_50_5                                         = UnitUpdateFields.End + 0x0104, // Size: 1, Type: Int, Flags: Unk3
        PLAYER_VISIBLE_ITEM_1_ENTRYID                                 = UnitUpdateFields.End + 0x0105, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_1_ENCHANTMENT                             = UnitUpdateFields.End + 0x0106, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_2_ENTRYID                                 = UnitUpdateFields.End + 0x0107, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_2_ENCHANTMENT                             = UnitUpdateFields.End + 0x0108, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_3_ENTRYID                                 = UnitUpdateFields.End + 0x0109, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_3_ENCHANTMENT                             = UnitUpdateFields.End + 0x010A, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_4_ENTRYID                                 = UnitUpdateFields.End + 0x010B, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_4_ENCHANTMENT                             = UnitUpdateFields.End + 0x010C, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_5_ENTRYID                                 = UnitUpdateFields.End + 0x010D, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_5_ENCHANTMENT                             = UnitUpdateFields.End + 0x010E, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_6_ENTRYID                                 = UnitUpdateFields.End + 0x010F, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_6_ENCHANTMENT                             = UnitUpdateFields.End + 0x0110, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_7_ENTRYID                                 = UnitUpdateFields.End + 0x0111, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_7_ENCHANTMENT                             = UnitUpdateFields.End + 0x0112, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_8_ENTRYID                                 = UnitUpdateFields.End + 0x0113, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_8_ENCHANTMENT                             = UnitUpdateFields.End + 0x0114, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_9_ENTRYID                                 = UnitUpdateFields.End + 0x0115, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_9_ENCHANTMENT                             = UnitUpdateFields.End + 0x0116, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_10_ENTRYID                                = UnitUpdateFields.End + 0x0117, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_10_ENCHANTMENT                            = UnitUpdateFields.End + 0x0118, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_11_ENTRYID                                = UnitUpdateFields.End + 0x0119, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_11_ENCHANTMENT                            = UnitUpdateFields.End + 0x011A, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_12_ENTRYID                                = UnitUpdateFields.End + 0x011B, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_12_ENCHANTMENT                            = UnitUpdateFields.End + 0x011C, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_13_ENTRYID                                = UnitUpdateFields.End + 0x011D, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_13_ENCHANTMENT                            = UnitUpdateFields.End + 0x011E, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_14_ENTRYID                                = UnitUpdateFields.End + 0x011F, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_14_ENCHANTMENT                            = UnitUpdateFields.End + 0x0120, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_15_ENTRYID                                = UnitUpdateFields.End + 0x0121, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_15_ENCHANTMENT                            = UnitUpdateFields.End + 0x0122, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_16_ENTRYID                                = UnitUpdateFields.End + 0x0123, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_16_ENCHANTMENT                            = UnitUpdateFields.End + 0x0124, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_17_ENTRYID                                = UnitUpdateFields.End + 0x0125, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_17_ENCHANTMENT                            = UnitUpdateFields.End + 0x0126, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_18_ENTRYID                                = UnitUpdateFields.End + 0x0127, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_18_ENCHANTMENT                            = UnitUpdateFields.End + 0x0128, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_VISIBLE_ITEM_19_ENTRYID                                = UnitUpdateFields.End + 0x0129, // Size: 1, Type: Int, Flags: Public
        PLAYER_VISIBLE_ITEM_19_ENCHANTMENT                            = UnitUpdateFields.End + 0x012A, // Size: 1, Type: TwoShort, Flags: Public
        PLAYER_CHOSEN_TITLE                                           = UnitUpdateFields.End + 0x012B, // Size: 1, Type: Int, Flags: Public
        PLAYER_FAKE_INEBRIATION                                       = UnitUpdateFields.End + 0x012C, // Size: 1, Type: Int, Flags: Public
        PLAYER_FIELD_PAD_0                                            = UnitUpdateFields.End + 0x012D, // Size: 1, Type: Int, Flags: None
        PLAYER_FIELD_INV_SLOT_HEAD                                    = UnitUpdateFields.End + 0x012E, // Size: 46, Type: Long, Flags: Private
        PLAYER_FIELD_INV_SLOT_HEAD_HIPART                             = UnitUpdateFields.End + 0x012F,
        PLAYER_FIELD_INV_SLOT_HEAD_2                                  = UnitUpdateFields.End + 0x0130,
        PLAYER_FIELD_INV_SLOT_HEAD_2_HIPART                           = UnitUpdateFields.End + 0x0131,
        PLAYER_FIELD_INV_SLOT_HEAD_3                                  = UnitUpdateFields.End + 0x0132,
        PLAYER_FIELD_INV_SLOT_HEAD_3_HIPART                           = UnitUpdateFields.End + 0x0133,
        PLAYER_FIELD_INV_SLOT_HEAD_4                                  = UnitUpdateFields.End + 0x0134,
        PLAYER_FIELD_INV_SLOT_HEAD_4_HIPART                           = UnitUpdateFields.End + 0x0135,
        PLAYER_FIELD_INV_SLOT_HEAD_5                                  = UnitUpdateFields.End + 0x0136,
        PLAYER_FIELD_INV_SLOT_HEAD_5_HIPART                           = UnitUpdateFields.End + 0x0137,
        PLAYER_FIELD_INV_SLOT_HEAD_6                                  = UnitUpdateFields.End + 0x0138,
        PLAYER_FIELD_INV_SLOT_HEAD_6_HIPART                           = UnitUpdateFields.End + 0x0139,
        PLAYER_FIELD_INV_SLOT_HEAD_7                                  = UnitUpdateFields.End + 0x013A,
        PLAYER_FIELD_INV_SLOT_HEAD_7_HIPART                           = UnitUpdateFields.End + 0x013B,
        PLAYER_FIELD_INV_SLOT_HEAD_8                                  = UnitUpdateFields.End + 0x013C,
        PLAYER_FIELD_INV_SLOT_HEAD_8_HIPART                           = UnitUpdateFields.End + 0x013D,
        PLAYER_FIELD_INV_SLOT_HEAD_9                                  = UnitUpdateFields.End + 0x013E,
        PLAYER_FIELD_INV_SLOT_HEAD_9_HIPART                           = UnitUpdateFields.End + 0x013F,
        PLAYER_FIELD_INV_SLOT_HEAD_10                                 = UnitUpdateFields.End + 0x0140,
        PLAYER_FIELD_INV_SLOT_HEAD_10_HIPART                          = UnitUpdateFields.End + 0x0141,
        PLAYER_FIELD_INV_SLOT_HEAD_11                                 = UnitUpdateFields.End + 0x0142,
        PLAYER_FIELD_INV_SLOT_HEAD_11_HIPART                          = UnitUpdateFields.End + 0x0143,
        PLAYER_FIELD_INV_SLOT_HEAD_12                                 = UnitUpdateFields.End + 0x0144,
        PLAYER_FIELD_INV_SLOT_HEAD_12_HIPART                          = UnitUpdateFields.End + 0x0145,
        PLAYER_FIELD_INV_SLOT_HEAD_13                                 = UnitUpdateFields.End + 0x0146,
        PLAYER_FIELD_INV_SLOT_HEAD_13_HIPART                          = UnitUpdateFields.End + 0x0147,
        PLAYER_FIELD_INV_SLOT_HEAD_14                                 = UnitUpdateFields.End + 0x0148,
        PLAYER_FIELD_INV_SLOT_HEAD_14_HIPART                          = UnitUpdateFields.End + 0x0149,
        PLAYER_FIELD_INV_SLOT_HEAD_15                                 = UnitUpdateFields.End + 0x014A,
        PLAYER_FIELD_INV_SLOT_HEAD_15_HIPART                          = UnitUpdateFields.End + 0x014B,
        PLAYER_FIELD_INV_SLOT_HEAD_16                                 = UnitUpdateFields.End + 0x014C,
        PLAYER_FIELD_INV_SLOT_HEAD_16_HIPART                          = UnitUpdateFields.End + 0x014D,
        PLAYER_FIELD_INV_SLOT_HEAD_17                                 = UnitUpdateFields.End + 0x014E,
        PLAYER_FIELD_INV_SLOT_HEAD_17_HIPART                          = UnitUpdateFields.End + 0x014F,
        PLAYER_FIELD_INV_SLOT_HEAD_18                                 = UnitUpdateFields.End + 0x0150,
        PLAYER_FIELD_INV_SLOT_HEAD_18_HIPART                          = UnitUpdateFields.End + 0x0151,
        PLAYER_FIELD_INV_SLOT_HEAD_19                                 = UnitUpdateFields.End + 0x0152,
        PLAYER_FIELD_INV_SLOT_HEAD_19_HIPART                          = UnitUpdateFields.End + 0x0153,
        PLAYER_FIELD_INV_SLOT_HEAD_20                                 = UnitUpdateFields.End + 0x0154,
        PLAYER_FIELD_INV_SLOT_HEAD_20_HIPART                          = UnitUpdateFields.End + 0x0155,
        PLAYER_FIELD_INV_SLOT_HEAD_21                                 = UnitUpdateFields.End + 0x0156,
        PLAYER_FIELD_INV_SLOT_HEAD_21_HIPART                          = UnitUpdateFields.End + 0x0157,
        PLAYER_FIELD_INV_SLOT_HEAD_22                                 = UnitUpdateFields.End + 0x0158,
        PLAYER_FIELD_INV_SLOT_HEAD_22_HIPART                          = UnitUpdateFields.End + 0x0159,
        PLAYER_FIELD_INV_SLOT_HEAD_23                                 = UnitUpdateFields.End + 0x015A,
        PLAYER_FIELD_INV_SLOT_HEAD_23_HIPART                          = UnitUpdateFields.End + 0x015B,
        PLAYER_FIELD_PACK_SLOT_1                                      = UnitUpdateFields.End + 0x015C, // Size: 32, Type: Long, Flags: Private
        PLAYER_FIELD_PACK_SLOT_1_HIPART                               = UnitUpdateFields.End + 0x015D,
        PLAYER_FIELD_PACK_SLOT_2                                      = UnitUpdateFields.End + 0x015E,
        PLAYER_FIELD_PACK_SLOT_2_HIPART                               = UnitUpdateFields.End + 0x015F,
        PLAYER_FIELD_PACK_SLOT_3                                      = UnitUpdateFields.End + 0x0160,
        PLAYER_FIELD_PACK_SLOT_3_HIPART                               = UnitUpdateFields.End + 0x0161,
        PLAYER_FIELD_PACK_SLOT_4                                      = UnitUpdateFields.End + 0x0162,
        PLAYER_FIELD_PACK_SLOT_4_HIPART                               = UnitUpdateFields.End + 0x0163,
        PLAYER_FIELD_PACK_SLOT_5                                      = UnitUpdateFields.End + 0x0164,
        PLAYER_FIELD_PACK_SLOT_5_HIPART                               = UnitUpdateFields.End + 0x0165,
        PLAYER_FIELD_PACK_SLOT_6                                      = UnitUpdateFields.End + 0x0166,
        PLAYER_FIELD_PACK_SLOT_6_HIPART                               = UnitUpdateFields.End + 0x0167,
        PLAYER_FIELD_PACK_SLOT_7                                      = UnitUpdateFields.End + 0x0168,
        PLAYER_FIELD_PACK_SLOT_7_HIPART                               = UnitUpdateFields.End + 0x0169,
        PLAYER_FIELD_PACK_SLOT_8                                      = UnitUpdateFields.End + 0x016A,
        PLAYER_FIELD_PACK_SLOT_8_HIPART                               = UnitUpdateFields.End + 0x016B,
        PLAYER_FIELD_PACK_SLOT_9                                      = UnitUpdateFields.End + 0x016C,
        PLAYER_FIELD_PACK_SLOT_9_HIPART                               = UnitUpdateFields.End + 0x016D,
        PLAYER_FIELD_PACK_SLOT_10                                     = UnitUpdateFields.End + 0x016E,
        PLAYER_FIELD_PACK_SLOT_10_HIPART                              = UnitUpdateFields.End + 0x016F,
        PLAYER_FIELD_PACK_SLOT_11                                     = UnitUpdateFields.End + 0x0170,
        PLAYER_FIELD_PACK_SLOT_11_HIPART                              = UnitUpdateFields.End + 0x0171,
        PLAYER_FIELD_PACK_SLOT_12                                     = UnitUpdateFields.End + 0x0172,
        PLAYER_FIELD_PACK_SLOT_12_HIPART                              = UnitUpdateFields.End + 0x0173,
        PLAYER_FIELD_PACK_SLOT_13                                     = UnitUpdateFields.End + 0x0174,
        PLAYER_FIELD_PACK_SLOT_13_HIPART                              = UnitUpdateFields.End + 0x0175,
        PLAYER_FIELD_PACK_SLOT_14                                     = UnitUpdateFields.End + 0x0176,
        PLAYER_FIELD_PACK_SLOT_14_HIPART                              = UnitUpdateFields.End + 0x0177,
        PLAYER_FIELD_PACK_SLOT_15                                     = UnitUpdateFields.End + 0x0178,
        PLAYER_FIELD_PACK_SLOT_15_HIPART                              = UnitUpdateFields.End + 0x0179,
        PLAYER_FIELD_PACK_SLOT_16                                     = UnitUpdateFields.End + 0x017A,
        PLAYER_FIELD_PACK_SLOT_16_HIPART                              = UnitUpdateFields.End + 0x017B,
        PLAYER_FIELD_BANK_SLOT_1                                      = UnitUpdateFields.End + 0x017C, // Size: 56, Type: Long, Flags: Private
        PLAYER_FIELD_BANK_SLOT_1_HIPART                               = UnitUpdateFields.End + 0x017D,
        PLAYER_FIELD_BANK_SLOT_2                                      = UnitUpdateFields.End + 0x017E,
        PLAYER_FIELD_BANK_SLOT_2_HIPART                               = UnitUpdateFields.End + 0x017F,
        PLAYER_FIELD_BANK_SLOT_3                                      = UnitUpdateFields.End + 0x0180,
        PLAYER_FIELD_BANK_SLOT_3_HIPART                               = UnitUpdateFields.End + 0x0181,
        PLAYER_FIELD_BANK_SLOT_4                                      = UnitUpdateFields.End + 0x0182,
        PLAYER_FIELD_BANK_SLOT_4_HIPART                               = UnitUpdateFields.End + 0x0183,
        PLAYER_FIELD_BANK_SLOT_5                                      = UnitUpdateFields.End + 0x0184,
        PLAYER_FIELD_BANK_SLOT_5_HIPART                               = UnitUpdateFields.End + 0x0185,
        PLAYER_FIELD_BANK_SLOT_6                                      = UnitUpdateFields.End + 0x0186,
        PLAYER_FIELD_BANK_SLOT_6_HIPART                               = UnitUpdateFields.End + 0x0187,
        PLAYER_FIELD_BANK_SLOT_7                                      = UnitUpdateFields.End + 0x0188,
        PLAYER_FIELD_BANK_SLOT_7_HIPART                               = UnitUpdateFields.End + 0x0189,
        PLAYER_FIELD_BANK_SLOT_8                                      = UnitUpdateFields.End + 0x018A,
        PLAYER_FIELD_BANK_SLOT_8_HIPART                               = UnitUpdateFields.End + 0x018B,
        PLAYER_FIELD_BANK_SLOT_9                                      = UnitUpdateFields.End + 0x018C,
        PLAYER_FIELD_BANK_SLOT_9_HIPART                               = UnitUpdateFields.End + 0x018D,
        PLAYER_FIELD_BANK_SLOT_10                                     = UnitUpdateFields.End + 0x018E,
        PLAYER_FIELD_BANK_SLOT_10_HIPART                              = UnitUpdateFields.End + 0x018F,
        PLAYER_FIELD_BANK_SLOT_11                                     = UnitUpdateFields.End + 0x0190,
        PLAYER_FIELD_BANK_SLOT_11_HIPART                              = UnitUpdateFields.End + 0x0191,
        PLAYER_FIELD_BANK_SLOT_12                                     = UnitUpdateFields.End + 0x0192,
        PLAYER_FIELD_BANK_SLOT_12_HIPART                              = UnitUpdateFields.End + 0x0193,
        PLAYER_FIELD_BANK_SLOT_13                                     = UnitUpdateFields.End + 0x0194,
        PLAYER_FIELD_BANK_SLOT_13_HIPART                              = UnitUpdateFields.End + 0x0195,
        PLAYER_FIELD_BANK_SLOT_14                                     = UnitUpdateFields.End + 0x0196,
        PLAYER_FIELD_BANK_SLOT_14_HIPART                              = UnitUpdateFields.End + 0x0197,
        PLAYER_FIELD_BANK_SLOT_15                                     = UnitUpdateFields.End + 0x0198,
        PLAYER_FIELD_BANK_SLOT_15_HIPART                              = UnitUpdateFields.End + 0x0199,
        PLAYER_FIELD_BANK_SLOT_16                                     = UnitUpdateFields.End + 0x019A,
        PLAYER_FIELD_BANK_SLOT_16_HIPART                              = UnitUpdateFields.End + 0x019B,
        PLAYER_FIELD_BANK_SLOT_17                                     = UnitUpdateFields.End + 0x019C,
        PLAYER_FIELD_BANK_SLOT_17_HIPART                              = UnitUpdateFields.End + 0x019D,
        PLAYER_FIELD_BANK_SLOT_18                                     = UnitUpdateFields.End + 0x019E,
        PLAYER_FIELD_BANK_SLOT_18_HIPART                              = UnitUpdateFields.End + 0x019F,
        PLAYER_FIELD_BANK_SLOT_19                                     = UnitUpdateFields.End + 0x01A0,
        PLAYER_FIELD_BANK_SLOT_19_HIPART                              = UnitUpdateFields.End + 0x01A1,
        PLAYER_FIELD_BANK_SLOT_20                                     = UnitUpdateFields.End + 0x01A2,
        PLAYER_FIELD_BANK_SLOT_20_HIPART                              = UnitUpdateFields.End + 0x01A3,
        PLAYER_FIELD_BANK_SLOT_21                                     = UnitUpdateFields.End + 0x01A4,
        PLAYER_FIELD_BANK_SLOT_21_HIPART                              = UnitUpdateFields.End + 0x01A5,
        PLAYER_FIELD_BANK_SLOT_22                                     = UnitUpdateFields.End + 0x01A6,
        PLAYER_FIELD_BANK_SLOT_22_HIPART                              = UnitUpdateFields.End + 0x01A7,
        PLAYER_FIELD_BANK_SLOT_23                                     = UnitUpdateFields.End + 0x01A8,
        PLAYER_FIELD_BANK_SLOT_23_HIPART                              = UnitUpdateFields.End + 0x01A9,
        PLAYER_FIELD_BANK_SLOT_24                                     = UnitUpdateFields.End + 0x01AA,
        PLAYER_FIELD_BANK_SLOT_24_HIPART                              = UnitUpdateFields.End + 0x01AB,
        PLAYER_FIELD_BANK_SLOT_25                                     = UnitUpdateFields.End + 0x01AC,
        PLAYER_FIELD_BANK_SLOT_25_HIPART                              = UnitUpdateFields.End + 0x01AD,
        PLAYER_FIELD_BANK_SLOT_26                                     = UnitUpdateFields.End + 0x01AE,
        PLAYER_FIELD_BANK_SLOT_26_HIPART                              = UnitUpdateFields.End + 0x01AF,
        PLAYER_FIELD_BANK_SLOT_27                                     = UnitUpdateFields.End + 0x01B0,
        PLAYER_FIELD_BANK_SLOT_27_HIPART                              = UnitUpdateFields.End + 0x01B1,
        PLAYER_FIELD_BANK_SLOT_28                                     = UnitUpdateFields.End + 0x01B2,
        PLAYER_FIELD_BANK_SLOT_28_HIPART                              = UnitUpdateFields.End + 0x01B3,
        PLAYER_FIELD_BANKBAG_SLOT_1                                   = UnitUpdateFields.End + 0x01B4, // Size: 14, Type: Long, Flags: Private
        PLAYER_FIELD_BANKBAG_SLOT_1_HIPART                            = UnitUpdateFields.End + 0x01B5,
        PLAYER_FIELD_BANKBAG_SLOT_2                                   = UnitUpdateFields.End + 0x01B6,
        PLAYER_FIELD_BANKBAG_SLOT_2_HIPART                            = UnitUpdateFields.End + 0x01B7,
        PLAYER_FIELD_BANKBAG_SLOT_3                                   = UnitUpdateFields.End + 0x01B8,
        PLAYER_FIELD_BANKBAG_SLOT_3_HIPART                            = UnitUpdateFields.End + 0x01B9,
        PLAYER_FIELD_BANKBAG_SLOT_4                                   = UnitUpdateFields.End + 0x01BA,
        PLAYER_FIELD_BANKBAG_SLOT_4_HIPART                            = UnitUpdateFields.End + 0x01BB,
        PLAYER_FIELD_BANKBAG_SLOT_5                                   = UnitUpdateFields.End + 0x01BC,
        PLAYER_FIELD_BANKBAG_SLOT_5_HIPART                            = UnitUpdateFields.End + 0x01BD,
        PLAYER_FIELD_BANKBAG_SLOT_6                                   = UnitUpdateFields.End + 0x01BE,
        PLAYER_FIELD_BANKBAG_SLOT_6_HIPART                            = UnitUpdateFields.End + 0x01BF,
        PLAYER_FIELD_BANKBAG_SLOT_7                                   = UnitUpdateFields.End + 0x01C0,
        PLAYER_FIELD_BANKBAG_SLOT_7_HIPART                            = UnitUpdateFields.End + 0x01C1,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_1                             = UnitUpdateFields.End + 0x01C2, // Size: 24, Type: Long, Flags: Private
        PLAYER_FIELD_VENDORBUYBACK_SLOT_1_HIPART                      = UnitUpdateFields.End + 0x01C3,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_2                             = UnitUpdateFields.End + 0x01C4,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_2_HIPART                      = UnitUpdateFields.End + 0x01C5,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_3                             = UnitUpdateFields.End + 0x01C6,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_3_HIPART                      = UnitUpdateFields.End + 0x01C7,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_4                             = UnitUpdateFields.End + 0x01C8,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_4_HIPART                      = UnitUpdateFields.End + 0x01C9,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_5                             = UnitUpdateFields.End + 0x01CA,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_5_HIPART                      = UnitUpdateFields.End + 0x01CB,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_6                             = UnitUpdateFields.End + 0x01CC,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_6_HIPART                      = UnitUpdateFields.End + 0x01CD,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_7                             = UnitUpdateFields.End + 0x01CE,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_7_HIPART                      = UnitUpdateFields.End + 0x01CF,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_8                             = UnitUpdateFields.End + 0x01D0,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_8_HIPART                      = UnitUpdateFields.End + 0x01D1,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_9                             = UnitUpdateFields.End + 0x01D2,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_9_HIPART                      = UnitUpdateFields.End + 0x01D3,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_10                            = UnitUpdateFields.End + 0x01D4,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_10_HIPART                     = UnitUpdateFields.End + 0x01D5,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_11                            = UnitUpdateFields.End + 0x01D6,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_11_HIPART                     = UnitUpdateFields.End + 0x01D7,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_12                            = UnitUpdateFields.End + 0x01D8,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_12_HIPART                     = UnitUpdateFields.End + 0x01D9,
        PLAYER_FARSIGHT                                               = UnitUpdateFields.End + 0x01DA, // Size: 2, Type: Long, Flags: Private
        PLAYER_FARSIGHT_HIPART                                        = UnitUpdateFields.End + 0x01DB,
        PLAYER__FIELD_KNOWN_TITLES                                    = UnitUpdateFields.End + 0x01DC, // Size: 2, Type: Long, Flags: Private
        PLAYER__FIELD_KNOWN_TITLES_HIPART                             = UnitUpdateFields.End + 0x01DD,
        PLAYER__FIELD_KNOWN_TITLES1                                   = UnitUpdateFields.End + 0x01DE, // Size: 2, Type: Long, Flags: Private
        PLAYER__FIELD_KNOWN_TITLES1_HIPART                            = UnitUpdateFields.End + 0x01DF,
        PLAYER__FIELD_KNOWN_TITLES2                                   = UnitUpdateFields.End + 0x01E0, // Size: 2, Type: Long, Flags: Private
        PLAYER__FIELD_KNOWN_TITLES2_HIPART                            = UnitUpdateFields.End + 0x01E1,
        PLAYER__FIELD_KNOWN_TITLES3                                   = UnitUpdateFields.End + 0x01E2, // Size: 2, Type: Long, Flags: Private
        PLAYER__FIELD_KNOWN_TITLES3_HIPART                            = UnitUpdateFields.End + 0x01E3,
        PLAYER_XP                                                     = UnitUpdateFields.End + 0x01E4, // Size: 1, Type: Int, Flags: Private
        PLAYER_NEXT_LEVEL_XP                                          = UnitUpdateFields.End + 0x01E5, // Size: 1, Type: Int, Flags: Private
        PLAYER_SKILL_LINEID_0                                         = UnitUpdateFields.End + 0x01E6, // Size: 64, Type: TwoShort, Flags: Private
        PLAYER_SKILL_LINEID_1                                         = UnitUpdateFields.End + 0x01E7,
        PLAYER_SKILL_LINEID_2                                         = UnitUpdateFields.End + 0x01E8,
        PLAYER_SKILL_LINEID_3                                         = UnitUpdateFields.End + 0x01E9,
        PLAYER_SKILL_LINEID_4                                         = UnitUpdateFields.End + 0x01EA,
        PLAYER_SKILL_LINEID_5                                         = UnitUpdateFields.End + 0x01EB,
        PLAYER_SKILL_LINEID_6                                         = UnitUpdateFields.End + 0x01EC,
        PLAYER_SKILL_LINEID_7                                         = UnitUpdateFields.End + 0x01ED,
        PLAYER_SKILL_LINEID_8                                         = UnitUpdateFields.End + 0x01EE,
        PLAYER_SKILL_LINEID_9                                         = UnitUpdateFields.End + 0x01EF,
        PLAYER_SKILL_LINEID_10                                        = UnitUpdateFields.End + 0x01F0,
        PLAYER_SKILL_LINEID_11                                        = UnitUpdateFields.End + 0x01F1,
        PLAYER_SKILL_LINEID_12                                        = UnitUpdateFields.End + 0x01F2,
        PLAYER_SKILL_LINEID_13                                        = UnitUpdateFields.End + 0x01F3,
        PLAYER_SKILL_LINEID_14                                        = UnitUpdateFields.End + 0x01F4,
        PLAYER_SKILL_LINEID_15                                        = UnitUpdateFields.End + 0x01F5,
        PLAYER_SKILL_LINEID_16                                        = UnitUpdateFields.End + 0x01F6,
        PLAYER_SKILL_LINEID_17                                        = UnitUpdateFields.End + 0x01F7,
        PLAYER_SKILL_LINEID_18                                        = UnitUpdateFields.End + 0x01F8,
        PLAYER_SKILL_LINEID_19                                        = UnitUpdateFields.End + 0x01F9,
        PLAYER_SKILL_LINEID_20                                        = UnitUpdateFields.End + 0x01FA,
        PLAYER_SKILL_LINEID_21                                        = UnitUpdateFields.End + 0x01FB,
        PLAYER_SKILL_LINEID_22                                        = UnitUpdateFields.End + 0x01FC,
        PLAYER_SKILL_LINEID_23                                        = UnitUpdateFields.End + 0x01FD,
        PLAYER_SKILL_LINEID_24                                        = UnitUpdateFields.End + 0x01FE,
        PLAYER_SKILL_LINEID_25                                        = UnitUpdateFields.End + 0x01FF,
        PLAYER_SKILL_LINEID_26                                        = UnitUpdateFields.End + 0x0200,
        PLAYER_SKILL_LINEID_27                                        = UnitUpdateFields.End + 0x0201,
        PLAYER_SKILL_LINEID_28                                        = UnitUpdateFields.End + 0x0202,
        PLAYER_SKILL_LINEID_29                                        = UnitUpdateFields.End + 0x0203,
        PLAYER_SKILL_LINEID_30                                        = UnitUpdateFields.End + 0x0204,
        PLAYER_SKILL_LINEID_31                                        = UnitUpdateFields.End + 0x0205,
        PLAYER_SKILL_LINEID_32                                        = UnitUpdateFields.End + 0x0206,
        PLAYER_SKILL_LINEID_33                                        = UnitUpdateFields.End + 0x0207,
        PLAYER_SKILL_LINEID_34                                        = UnitUpdateFields.End + 0x0208,
        PLAYER_SKILL_LINEID_35                                        = UnitUpdateFields.End + 0x0209,
        PLAYER_SKILL_LINEID_36                                        = UnitUpdateFields.End + 0x020A,
        PLAYER_SKILL_LINEID_37                                        = UnitUpdateFields.End + 0x020B,
        PLAYER_SKILL_LINEID_38                                        = UnitUpdateFields.End + 0x020C,
        PLAYER_SKILL_LINEID_39                                        = UnitUpdateFields.End + 0x020D,
        PLAYER_SKILL_LINEID_40                                        = UnitUpdateFields.End + 0x020E,
        PLAYER_SKILL_LINEID_41                                        = UnitUpdateFields.End + 0x020F,
        PLAYER_SKILL_LINEID_42                                        = UnitUpdateFields.End + 0x0210,
        PLAYER_SKILL_LINEID_43                                        = UnitUpdateFields.End + 0x0211,
        PLAYER_SKILL_LINEID_44                                        = UnitUpdateFields.End + 0x0212,
        PLAYER_SKILL_LINEID_45                                        = UnitUpdateFields.End + 0x0213,
        PLAYER_SKILL_LINEID_46                                        = UnitUpdateFields.End + 0x0214,
        PLAYER_SKILL_LINEID_47                                        = UnitUpdateFields.End + 0x0215,
        PLAYER_SKILL_LINEID_48                                        = UnitUpdateFields.End + 0x0216,
        PLAYER_SKILL_LINEID_49                                        = UnitUpdateFields.End + 0x0217,
        PLAYER_SKILL_LINEID_50                                        = UnitUpdateFields.End + 0x0218,
        PLAYER_SKILL_LINEID_51                                        = UnitUpdateFields.End + 0x0219,
        PLAYER_SKILL_LINEID_52                                        = UnitUpdateFields.End + 0x021A,
        PLAYER_SKILL_LINEID_53                                        = UnitUpdateFields.End + 0x021B,
        PLAYER_SKILL_LINEID_54                                        = UnitUpdateFields.End + 0x021C,
        PLAYER_SKILL_LINEID_55                                        = UnitUpdateFields.End + 0x021D,
        PLAYER_SKILL_LINEID_56                                        = UnitUpdateFields.End + 0x021E,
        PLAYER_SKILL_LINEID_57                                        = UnitUpdateFields.End + 0x021F,
        PLAYER_SKILL_LINEID_58                                        = UnitUpdateFields.End + 0x0220,
        PLAYER_SKILL_LINEID_59                                        = UnitUpdateFields.End + 0x0221,
        PLAYER_SKILL_LINEID_60                                        = UnitUpdateFields.End + 0x0222,
        PLAYER_SKILL_LINEID_61                                        = UnitUpdateFields.End + 0x0223,
        PLAYER_SKILL_LINEID_62                                        = UnitUpdateFields.End + 0x0224,
        PLAYER_SKILL_LINEID_63                                        = UnitUpdateFields.End + 0x0225,
        PLAYER_SKILL_STEP_0                                           = UnitUpdateFields.End + 0x0226, // Size: 64, Type: TwoShort, Flags: Private
        PLAYER_SKILL_STEP_1                                           = UnitUpdateFields.End + 0x0227,
        PLAYER_SKILL_STEP_2                                           = UnitUpdateFields.End + 0x0228,
        PLAYER_SKILL_STEP_3                                           = UnitUpdateFields.End + 0x0229,
        PLAYER_SKILL_STEP_4                                           = UnitUpdateFields.End + 0x022A,
        PLAYER_SKILL_STEP_5                                           = UnitUpdateFields.End + 0x022B,
        PLAYER_SKILL_STEP_6                                           = UnitUpdateFields.End + 0x022C,
        PLAYER_SKILL_STEP_7                                           = UnitUpdateFields.End + 0x022D,
        PLAYER_SKILL_STEP_8                                           = UnitUpdateFields.End + 0x022E,
        PLAYER_SKILL_STEP_9                                           = UnitUpdateFields.End + 0x022F,
        PLAYER_SKILL_STEP_10                                          = UnitUpdateFields.End + 0x0230,
        PLAYER_SKILL_STEP_11                                          = UnitUpdateFields.End + 0x0231,
        PLAYER_SKILL_STEP_12                                          = UnitUpdateFields.End + 0x0232,
        PLAYER_SKILL_STEP_13                                          = UnitUpdateFields.End + 0x0233,
        PLAYER_SKILL_STEP_14                                          = UnitUpdateFields.End + 0x0234,
        PLAYER_SKILL_STEP_15                                          = UnitUpdateFields.End + 0x0235,
        PLAYER_SKILL_STEP_16                                          = UnitUpdateFields.End + 0x0236,
        PLAYER_SKILL_STEP_17                                          = UnitUpdateFields.End + 0x0237,
        PLAYER_SKILL_STEP_18                                          = UnitUpdateFields.End + 0x0238,
        PLAYER_SKILL_STEP_19                                          = UnitUpdateFields.End + 0x0239,
        PLAYER_SKILL_STEP_20                                          = UnitUpdateFields.End + 0x023A,
        PLAYER_SKILL_STEP_21                                          = UnitUpdateFields.End + 0x023B,
        PLAYER_SKILL_STEP_22                                          = UnitUpdateFields.End + 0x023C,
        PLAYER_SKILL_STEP_23                                          = UnitUpdateFields.End + 0x023D,
        PLAYER_SKILL_STEP_24                                          = UnitUpdateFields.End + 0x023E,
        PLAYER_SKILL_STEP_25                                          = UnitUpdateFields.End + 0x023F,
        PLAYER_SKILL_STEP_26                                          = UnitUpdateFields.End + 0x0240,
        PLAYER_SKILL_STEP_27                                          = UnitUpdateFields.End + 0x0241,
        PLAYER_SKILL_STEP_28                                          = UnitUpdateFields.End + 0x0242,
        PLAYER_SKILL_STEP_29                                          = UnitUpdateFields.End + 0x0243,
        PLAYER_SKILL_STEP_30                                          = UnitUpdateFields.End + 0x0244,
        PLAYER_SKILL_STEP_31                                          = UnitUpdateFields.End + 0x0245,
        PLAYER_SKILL_STEP_32                                          = UnitUpdateFields.End + 0x0246,
        PLAYER_SKILL_STEP_33                                          = UnitUpdateFields.End + 0x0247,
        PLAYER_SKILL_STEP_34                                          = UnitUpdateFields.End + 0x0248,
        PLAYER_SKILL_STEP_35                                          = UnitUpdateFields.End + 0x0249,
        PLAYER_SKILL_STEP_36                                          = UnitUpdateFields.End + 0x024A,
        PLAYER_SKILL_STEP_37                                          = UnitUpdateFields.End + 0x024B,
        PLAYER_SKILL_STEP_38                                          = UnitUpdateFields.End + 0x024C,
        PLAYER_SKILL_STEP_39                                          = UnitUpdateFields.End + 0x024D,
        PLAYER_SKILL_STEP_40                                          = UnitUpdateFields.End + 0x024E,
        PLAYER_SKILL_STEP_41                                          = UnitUpdateFields.End + 0x024F,
        PLAYER_SKILL_STEP_42                                          = UnitUpdateFields.End + 0x0250,
        PLAYER_SKILL_STEP_43                                          = UnitUpdateFields.End + 0x0251,
        PLAYER_SKILL_STEP_44                                          = UnitUpdateFields.End + 0x0252,
        PLAYER_SKILL_STEP_45                                          = UnitUpdateFields.End + 0x0253,
        PLAYER_SKILL_STEP_46                                          = UnitUpdateFields.End + 0x0254,
        PLAYER_SKILL_STEP_47                                          = UnitUpdateFields.End + 0x0255,
        PLAYER_SKILL_STEP_48                                          = UnitUpdateFields.End + 0x0256,
        PLAYER_SKILL_STEP_49                                          = UnitUpdateFields.End + 0x0257,
        PLAYER_SKILL_STEP_50                                          = UnitUpdateFields.End + 0x0258,
        PLAYER_SKILL_STEP_51                                          = UnitUpdateFields.End + 0x0259,
        PLAYER_SKILL_STEP_52                                          = UnitUpdateFields.End + 0x025A,
        PLAYER_SKILL_STEP_53                                          = UnitUpdateFields.End + 0x025B,
        PLAYER_SKILL_STEP_54                                          = UnitUpdateFields.End + 0x025C,
        PLAYER_SKILL_STEP_55                                          = UnitUpdateFields.End + 0x025D,
        PLAYER_SKILL_STEP_56                                          = UnitUpdateFields.End + 0x025E,
        PLAYER_SKILL_STEP_57                                          = UnitUpdateFields.End + 0x025F,
        PLAYER_SKILL_STEP_58                                          = UnitUpdateFields.End + 0x0260,
        PLAYER_SKILL_STEP_59                                          = UnitUpdateFields.End + 0x0261,
        PLAYER_SKILL_STEP_60                                          = UnitUpdateFields.End + 0x0262,
        PLAYER_SKILL_STEP_61                                          = UnitUpdateFields.End + 0x0263,
        PLAYER_SKILL_STEP_62                                          = UnitUpdateFields.End + 0x0264,
        PLAYER_SKILL_STEP_63                                          = UnitUpdateFields.End + 0x0265,
        PLAYER_SKILL_RANK_0                                           = UnitUpdateFields.End + 0x0266, // Size: 64, Type: TwoShort, Flags: Private
        PLAYER_SKILL_RANK_1                                           = UnitUpdateFields.End + 0x0267,
        PLAYER_SKILL_RANK_2                                           = UnitUpdateFields.End + 0x0268,
        PLAYER_SKILL_RANK_3                                           = UnitUpdateFields.End + 0x0269,
        PLAYER_SKILL_RANK_4                                           = UnitUpdateFields.End + 0x026A,
        PLAYER_SKILL_RANK_5                                           = UnitUpdateFields.End + 0x026B,
        PLAYER_SKILL_RANK_6                                           = UnitUpdateFields.End + 0x026C,
        PLAYER_SKILL_RANK_7                                           = UnitUpdateFields.End + 0x026D,
        PLAYER_SKILL_RANK_8                                           = UnitUpdateFields.End + 0x026E,
        PLAYER_SKILL_RANK_9                                           = UnitUpdateFields.End + 0x026F,
        PLAYER_SKILL_RANK_10                                          = UnitUpdateFields.End + 0x0270,
        PLAYER_SKILL_RANK_11                                          = UnitUpdateFields.End + 0x0271,
        PLAYER_SKILL_RANK_12                                          = UnitUpdateFields.End + 0x0272,
        PLAYER_SKILL_RANK_13                                          = UnitUpdateFields.End + 0x0273,
        PLAYER_SKILL_RANK_14                                          = UnitUpdateFields.End + 0x0274,
        PLAYER_SKILL_RANK_15                                          = UnitUpdateFields.End + 0x0275,
        PLAYER_SKILL_RANK_16                                          = UnitUpdateFields.End + 0x0276,
        PLAYER_SKILL_RANK_17                                          = UnitUpdateFields.End + 0x0277,
        PLAYER_SKILL_RANK_18                                          = UnitUpdateFields.End + 0x0278,
        PLAYER_SKILL_RANK_19                                          = UnitUpdateFields.End + 0x0279,
        PLAYER_SKILL_RANK_20                                          = UnitUpdateFields.End + 0x027A,
        PLAYER_SKILL_RANK_21                                          = UnitUpdateFields.End + 0x027B,
        PLAYER_SKILL_RANK_22                                          = UnitUpdateFields.End + 0x027C,
        PLAYER_SKILL_RANK_23                                          = UnitUpdateFields.End + 0x027D,
        PLAYER_SKILL_RANK_24                                          = UnitUpdateFields.End + 0x027E,
        PLAYER_SKILL_RANK_25                                          = UnitUpdateFields.End + 0x027F,
        PLAYER_SKILL_RANK_26                                          = UnitUpdateFields.End + 0x0280,
        PLAYER_SKILL_RANK_27                                          = UnitUpdateFields.End + 0x0281,
        PLAYER_SKILL_RANK_28                                          = UnitUpdateFields.End + 0x0282,
        PLAYER_SKILL_RANK_29                                          = UnitUpdateFields.End + 0x0283,
        PLAYER_SKILL_RANK_30                                          = UnitUpdateFields.End + 0x0284,
        PLAYER_SKILL_RANK_31                                          = UnitUpdateFields.End + 0x0285,
        PLAYER_SKILL_RANK_32                                          = UnitUpdateFields.End + 0x0286,
        PLAYER_SKILL_RANK_33                                          = UnitUpdateFields.End + 0x0287,
        PLAYER_SKILL_RANK_34                                          = UnitUpdateFields.End + 0x0288,
        PLAYER_SKILL_RANK_35                                          = UnitUpdateFields.End + 0x0289,
        PLAYER_SKILL_RANK_36                                          = UnitUpdateFields.End + 0x028A,
        PLAYER_SKILL_RANK_37                                          = UnitUpdateFields.End + 0x028B,
        PLAYER_SKILL_RANK_38                                          = UnitUpdateFields.End + 0x028C,
        PLAYER_SKILL_RANK_39                                          = UnitUpdateFields.End + 0x028D,
        PLAYER_SKILL_RANK_40                                          = UnitUpdateFields.End + 0x028E,
        PLAYER_SKILL_RANK_41                                          = UnitUpdateFields.End + 0x028F,
        PLAYER_SKILL_RANK_42                                          = UnitUpdateFields.End + 0x0290,
        PLAYER_SKILL_RANK_43                                          = UnitUpdateFields.End + 0x0291,
        PLAYER_SKILL_RANK_44                                          = UnitUpdateFields.End + 0x0292,
        PLAYER_SKILL_RANK_45                                          = UnitUpdateFields.End + 0x0293,
        PLAYER_SKILL_RANK_46                                          = UnitUpdateFields.End + 0x0294,
        PLAYER_SKILL_RANK_47                                          = UnitUpdateFields.End + 0x0295,
        PLAYER_SKILL_RANK_48                                          = UnitUpdateFields.End + 0x0296,
        PLAYER_SKILL_RANK_49                                          = UnitUpdateFields.End + 0x0297,
        PLAYER_SKILL_RANK_50                                          = UnitUpdateFields.End + 0x0298,
        PLAYER_SKILL_RANK_51                                          = UnitUpdateFields.End + 0x0299,
        PLAYER_SKILL_RANK_52                                          = UnitUpdateFields.End + 0x029A,
        PLAYER_SKILL_RANK_53                                          = UnitUpdateFields.End + 0x029B,
        PLAYER_SKILL_RANK_54                                          = UnitUpdateFields.End + 0x029C,
        PLAYER_SKILL_RANK_55                                          = UnitUpdateFields.End + 0x029D,
        PLAYER_SKILL_RANK_56                                          = UnitUpdateFields.End + 0x029E,
        PLAYER_SKILL_RANK_57                                          = UnitUpdateFields.End + 0x029F,
        PLAYER_SKILL_RANK_58                                          = UnitUpdateFields.End + 0x02A0,
        PLAYER_SKILL_RANK_59                                          = UnitUpdateFields.End + 0x02A1,
        PLAYER_SKILL_RANK_60                                          = UnitUpdateFields.End + 0x02A2,
        PLAYER_SKILL_RANK_61                                          = UnitUpdateFields.End + 0x02A3,
        PLAYER_SKILL_RANK_62                                          = UnitUpdateFields.End + 0x02A4,
        PLAYER_SKILL_RANK_63                                          = UnitUpdateFields.End + 0x02A5,
        PLAYER_SKILL_MAX_RANK_0                                       = UnitUpdateFields.End + 0x02A6, // Size: 64, Type: TwoShort, Flags: Private
        PLAYER_SKILL_MAX_RANK_1                                       = UnitUpdateFields.End + 0x02A7,
        PLAYER_SKILL_MAX_RANK_2                                       = UnitUpdateFields.End + 0x02A8,
        PLAYER_SKILL_MAX_RANK_3                                       = UnitUpdateFields.End + 0x02A9,
        PLAYER_SKILL_MAX_RANK_4                                       = UnitUpdateFields.End + 0x02AA,
        PLAYER_SKILL_MAX_RANK_5                                       = UnitUpdateFields.End + 0x02AB,
        PLAYER_SKILL_MAX_RANK_6                                       = UnitUpdateFields.End + 0x02AC,
        PLAYER_SKILL_MAX_RANK_7                                       = UnitUpdateFields.End + 0x02AD,
        PLAYER_SKILL_MAX_RANK_8                                       = UnitUpdateFields.End + 0x02AE,
        PLAYER_SKILL_MAX_RANK_9                                       = UnitUpdateFields.End + 0x02AF,
        PLAYER_SKILL_MAX_RANK_10                                      = UnitUpdateFields.End + 0x02B0,
        PLAYER_SKILL_MAX_RANK_11                                      = UnitUpdateFields.End + 0x02B1,
        PLAYER_SKILL_MAX_RANK_12                                      = UnitUpdateFields.End + 0x02B2,
        PLAYER_SKILL_MAX_RANK_13                                      = UnitUpdateFields.End + 0x02B3,
        PLAYER_SKILL_MAX_RANK_14                                      = UnitUpdateFields.End + 0x02B4,
        PLAYER_SKILL_MAX_RANK_15                                      = UnitUpdateFields.End + 0x02B5,
        PLAYER_SKILL_MAX_RANK_16                                      = UnitUpdateFields.End + 0x02B6,
        PLAYER_SKILL_MAX_RANK_17                                      = UnitUpdateFields.End + 0x02B7,
        PLAYER_SKILL_MAX_RANK_18                                      = UnitUpdateFields.End + 0x02B8,
        PLAYER_SKILL_MAX_RANK_19                                      = UnitUpdateFields.End + 0x02B9,
        PLAYER_SKILL_MAX_RANK_20                                      = UnitUpdateFields.End + 0x02BA,
        PLAYER_SKILL_MAX_RANK_21                                      = UnitUpdateFields.End + 0x02BB,
        PLAYER_SKILL_MAX_RANK_22                                      = UnitUpdateFields.End + 0x02BC,
        PLAYER_SKILL_MAX_RANK_23                                      = UnitUpdateFields.End + 0x02BD,
        PLAYER_SKILL_MAX_RANK_24                                      = UnitUpdateFields.End + 0x02BE,
        PLAYER_SKILL_MAX_RANK_25                                      = UnitUpdateFields.End + 0x02BF,
        PLAYER_SKILL_MAX_RANK_26                                      = UnitUpdateFields.End + 0x02C0,
        PLAYER_SKILL_MAX_RANK_27                                      = UnitUpdateFields.End + 0x02C1,
        PLAYER_SKILL_MAX_RANK_28                                      = UnitUpdateFields.End + 0x02C2,
        PLAYER_SKILL_MAX_RANK_29                                      = UnitUpdateFields.End + 0x02C3,
        PLAYER_SKILL_MAX_RANK_30                                      = UnitUpdateFields.End + 0x02C4,
        PLAYER_SKILL_MAX_RANK_31                                      = UnitUpdateFields.End + 0x02C5,
        PLAYER_SKILL_MAX_RANK_32                                      = UnitUpdateFields.End + 0x02C6,
        PLAYER_SKILL_MAX_RANK_33                                      = UnitUpdateFields.End + 0x02C7,
        PLAYER_SKILL_MAX_RANK_34                                      = UnitUpdateFields.End + 0x02C8,
        PLAYER_SKILL_MAX_RANK_35                                      = UnitUpdateFields.End + 0x02C9,
        PLAYER_SKILL_MAX_RANK_36                                      = UnitUpdateFields.End + 0x02CA,
        PLAYER_SKILL_MAX_RANK_37                                      = UnitUpdateFields.End + 0x02CB,
        PLAYER_SKILL_MAX_RANK_38                                      = UnitUpdateFields.End + 0x02CC,
        PLAYER_SKILL_MAX_RANK_39                                      = UnitUpdateFields.End + 0x02CD,
        PLAYER_SKILL_MAX_RANK_40                                      = UnitUpdateFields.End + 0x02CE,
        PLAYER_SKILL_MAX_RANK_41                                      = UnitUpdateFields.End + 0x02CF,
        PLAYER_SKILL_MAX_RANK_42                                      = UnitUpdateFields.End + 0x02D0,
        PLAYER_SKILL_MAX_RANK_43                                      = UnitUpdateFields.End + 0x02D1,
        PLAYER_SKILL_MAX_RANK_44                                      = UnitUpdateFields.End + 0x02D2,
        PLAYER_SKILL_MAX_RANK_45                                      = UnitUpdateFields.End + 0x02D3,
        PLAYER_SKILL_MAX_RANK_46                                      = UnitUpdateFields.End + 0x02D4,
        PLAYER_SKILL_MAX_RANK_47                                      = UnitUpdateFields.End + 0x02D5,
        PLAYER_SKILL_MAX_RANK_48                                      = UnitUpdateFields.End + 0x02D6,
        PLAYER_SKILL_MAX_RANK_49                                      = UnitUpdateFields.End + 0x02D7,
        PLAYER_SKILL_MAX_RANK_50                                      = UnitUpdateFields.End + 0x02D8,
        PLAYER_SKILL_MAX_RANK_51                                      = UnitUpdateFields.End + 0x02D9,
        PLAYER_SKILL_MAX_RANK_52                                      = UnitUpdateFields.End + 0x02DA,
        PLAYER_SKILL_MAX_RANK_53                                      = UnitUpdateFields.End + 0x02DB,
        PLAYER_SKILL_MAX_RANK_54                                      = UnitUpdateFields.End + 0x02DC,
        PLAYER_SKILL_MAX_RANK_55                                      = UnitUpdateFields.End + 0x02DD,
        PLAYER_SKILL_MAX_RANK_56                                      = UnitUpdateFields.End + 0x02DE,
        PLAYER_SKILL_MAX_RANK_57                                      = UnitUpdateFields.End + 0x02DF,
        PLAYER_SKILL_MAX_RANK_58                                      = UnitUpdateFields.End + 0x02E0,
        PLAYER_SKILL_MAX_RANK_59                                      = UnitUpdateFields.End + 0x02E1,
        PLAYER_SKILL_MAX_RANK_60                                      = UnitUpdateFields.End + 0x02E2,
        PLAYER_SKILL_MAX_RANK_61                                      = UnitUpdateFields.End + 0x02E3,
        PLAYER_SKILL_MAX_RANK_62                                      = UnitUpdateFields.End + 0x02E4,
        PLAYER_SKILL_MAX_RANK_63                                      = UnitUpdateFields.End + 0x02E5,
        PLAYER_SKILL_MODIFIER_0                                       = UnitUpdateFields.End + 0x02E6, // Size: 64, Type: TwoShort, Flags: Private
        PLAYER_SKILL_MODIFIER_1                                       = UnitUpdateFields.End + 0x02E7,
        PLAYER_SKILL_MODIFIER_2                                       = UnitUpdateFields.End + 0x02E8,
        PLAYER_SKILL_MODIFIER_3                                       = UnitUpdateFields.End + 0x02E9,
        PLAYER_SKILL_MODIFIER_4                                       = UnitUpdateFields.End + 0x02EA,
        PLAYER_SKILL_MODIFIER_5                                       = UnitUpdateFields.End + 0x02EB,
        PLAYER_SKILL_MODIFIER_6                                       = UnitUpdateFields.End + 0x02EC,
        PLAYER_SKILL_MODIFIER_7                                       = UnitUpdateFields.End + 0x02ED,
        PLAYER_SKILL_MODIFIER_8                                       = UnitUpdateFields.End + 0x02EE,
        PLAYER_SKILL_MODIFIER_9                                       = UnitUpdateFields.End + 0x02EF,
        PLAYER_SKILL_MODIFIER_10                                      = UnitUpdateFields.End + 0x02F0,
        PLAYER_SKILL_MODIFIER_11                                      = UnitUpdateFields.End + 0x02F1,
        PLAYER_SKILL_MODIFIER_12                                      = UnitUpdateFields.End + 0x02F2,
        PLAYER_SKILL_MODIFIER_13                                      = UnitUpdateFields.End + 0x02F3,
        PLAYER_SKILL_MODIFIER_14                                      = UnitUpdateFields.End + 0x02F4,
        PLAYER_SKILL_MODIFIER_15                                      = UnitUpdateFields.End + 0x02F5,
        PLAYER_SKILL_MODIFIER_16                                      = UnitUpdateFields.End + 0x02F6,
        PLAYER_SKILL_MODIFIER_17                                      = UnitUpdateFields.End + 0x02F7,
        PLAYER_SKILL_MODIFIER_18                                      = UnitUpdateFields.End + 0x02F8,
        PLAYER_SKILL_MODIFIER_19                                      = UnitUpdateFields.End + 0x02F9,
        PLAYER_SKILL_MODIFIER_20                                      = UnitUpdateFields.End + 0x02FA,
        PLAYER_SKILL_MODIFIER_21                                      = UnitUpdateFields.End + 0x02FB,
        PLAYER_SKILL_MODIFIER_22                                      = UnitUpdateFields.End + 0x02FC,
        PLAYER_SKILL_MODIFIER_23                                      = UnitUpdateFields.End + 0x02FD,
        PLAYER_SKILL_MODIFIER_24                                      = UnitUpdateFields.End + 0x02FE,
        PLAYER_SKILL_MODIFIER_25                                      = UnitUpdateFields.End + 0x02FF,
        PLAYER_SKILL_MODIFIER_26                                      = UnitUpdateFields.End + 0x0300,
        PLAYER_SKILL_MODIFIER_27                                      = UnitUpdateFields.End + 0x0301,
        PLAYER_SKILL_MODIFIER_28                                      = UnitUpdateFields.End + 0x0302,
        PLAYER_SKILL_MODIFIER_29                                      = UnitUpdateFields.End + 0x0303,
        PLAYER_SKILL_MODIFIER_30                                      = UnitUpdateFields.End + 0x0304,
        PLAYER_SKILL_MODIFIER_31                                      = UnitUpdateFields.End + 0x0305,
        PLAYER_SKILL_MODIFIER_32                                      = UnitUpdateFields.End + 0x0306,
        PLAYER_SKILL_MODIFIER_33                                      = UnitUpdateFields.End + 0x0307,
        PLAYER_SKILL_MODIFIER_34                                      = UnitUpdateFields.End + 0x0308,
        PLAYER_SKILL_MODIFIER_35                                      = UnitUpdateFields.End + 0x0309,
        PLAYER_SKILL_MODIFIER_36                                      = UnitUpdateFields.End + 0x030A,
        PLAYER_SKILL_MODIFIER_37                                      = UnitUpdateFields.End + 0x030B,
        PLAYER_SKILL_MODIFIER_38                                      = UnitUpdateFields.End + 0x030C,
        PLAYER_SKILL_MODIFIER_39                                      = UnitUpdateFields.End + 0x030D,
        PLAYER_SKILL_MODIFIER_40                                      = UnitUpdateFields.End + 0x030E,
        PLAYER_SKILL_MODIFIER_41                                      = UnitUpdateFields.End + 0x030F,
        PLAYER_SKILL_MODIFIER_42                                      = UnitUpdateFields.End + 0x0310,
        PLAYER_SKILL_MODIFIER_43                                      = UnitUpdateFields.End + 0x0311,
        PLAYER_SKILL_MODIFIER_44                                      = UnitUpdateFields.End + 0x0312,
        PLAYER_SKILL_MODIFIER_45                                      = UnitUpdateFields.End + 0x0313,
        PLAYER_SKILL_MODIFIER_46                                      = UnitUpdateFields.End + 0x0314,
        PLAYER_SKILL_MODIFIER_47                                      = UnitUpdateFields.End + 0x0315,
        PLAYER_SKILL_MODIFIER_48                                      = UnitUpdateFields.End + 0x0316,
        PLAYER_SKILL_MODIFIER_49                                      = UnitUpdateFields.End + 0x0317,
        PLAYER_SKILL_MODIFIER_50                                      = UnitUpdateFields.End + 0x0318,
        PLAYER_SKILL_MODIFIER_51                                      = UnitUpdateFields.End + 0x0319,
        PLAYER_SKILL_MODIFIER_52                                      = UnitUpdateFields.End + 0x031A,
        PLAYER_SKILL_MODIFIER_53                                      = UnitUpdateFields.End + 0x031B,
        PLAYER_SKILL_MODIFIER_54                                      = UnitUpdateFields.End + 0x031C,
        PLAYER_SKILL_MODIFIER_55                                      = UnitUpdateFields.End + 0x031D,
        PLAYER_SKILL_MODIFIER_56                                      = UnitUpdateFields.End + 0x031E,
        PLAYER_SKILL_MODIFIER_57                                      = UnitUpdateFields.End + 0x031F,
        PLAYER_SKILL_MODIFIER_58                                      = UnitUpdateFields.End + 0x0320,
        PLAYER_SKILL_MODIFIER_59                                      = UnitUpdateFields.End + 0x0321,
        PLAYER_SKILL_MODIFIER_60                                      = UnitUpdateFields.End + 0x0322,
        PLAYER_SKILL_MODIFIER_61                                      = UnitUpdateFields.End + 0x0323,
        PLAYER_SKILL_MODIFIER_62                                      = UnitUpdateFields.End + 0x0324,
        PLAYER_SKILL_MODIFIER_63                                      = UnitUpdateFields.End + 0x0325,
        PLAYER_SKILL_TALENT_0                                         = UnitUpdateFields.End + 0x0326, // Size: 64, Type: TwoShort, Flags: Private
        PLAYER_SKILL_TALENT_1                                         = UnitUpdateFields.End + 0x0327,
        PLAYER_SKILL_TALENT_2                                         = UnitUpdateFields.End + 0x0328,
        PLAYER_SKILL_TALENT_3                                         = UnitUpdateFields.End + 0x0329,
        PLAYER_SKILL_TALENT_4                                         = UnitUpdateFields.End + 0x032A,
        PLAYER_SKILL_TALENT_5                                         = UnitUpdateFields.End + 0x032B,
        PLAYER_SKILL_TALENT_6                                         = UnitUpdateFields.End + 0x032C,
        PLAYER_SKILL_TALENT_7                                         = UnitUpdateFields.End + 0x032D,
        PLAYER_SKILL_TALENT_8                                         = UnitUpdateFields.End + 0x032E,
        PLAYER_SKILL_TALENT_9                                         = UnitUpdateFields.End + 0x032F,
        PLAYER_SKILL_TALENT_10                                        = UnitUpdateFields.End + 0x0330,
        PLAYER_SKILL_TALENT_11                                        = UnitUpdateFields.End + 0x0331,
        PLAYER_SKILL_TALENT_12                                        = UnitUpdateFields.End + 0x0332,
        PLAYER_SKILL_TALENT_13                                        = UnitUpdateFields.End + 0x0333,
        PLAYER_SKILL_TALENT_14                                        = UnitUpdateFields.End + 0x0334,
        PLAYER_SKILL_TALENT_15                                        = UnitUpdateFields.End + 0x0335,
        PLAYER_SKILL_TALENT_16                                        = UnitUpdateFields.End + 0x0336,
        PLAYER_SKILL_TALENT_17                                        = UnitUpdateFields.End + 0x0337,
        PLAYER_SKILL_TALENT_18                                        = UnitUpdateFields.End + 0x0338,
        PLAYER_SKILL_TALENT_19                                        = UnitUpdateFields.End + 0x0339,
        PLAYER_SKILL_TALENT_20                                        = UnitUpdateFields.End + 0x033A,
        PLAYER_SKILL_TALENT_21                                        = UnitUpdateFields.End + 0x033B,
        PLAYER_SKILL_TALENT_22                                        = UnitUpdateFields.End + 0x033C,
        PLAYER_SKILL_TALENT_23                                        = UnitUpdateFields.End + 0x033D,
        PLAYER_SKILL_TALENT_24                                        = UnitUpdateFields.End + 0x033E,
        PLAYER_SKILL_TALENT_25                                        = UnitUpdateFields.End + 0x033F,
        PLAYER_SKILL_TALENT_26                                        = UnitUpdateFields.End + 0x0340,
        PLAYER_SKILL_TALENT_27                                        = UnitUpdateFields.End + 0x0341,
        PLAYER_SKILL_TALENT_28                                        = UnitUpdateFields.End + 0x0342,
        PLAYER_SKILL_TALENT_29                                        = UnitUpdateFields.End + 0x0343,
        PLAYER_SKILL_TALENT_30                                        = UnitUpdateFields.End + 0x0344,
        PLAYER_SKILL_TALENT_31                                        = UnitUpdateFields.End + 0x0345,
        PLAYER_SKILL_TALENT_32                                        = UnitUpdateFields.End + 0x0346,
        PLAYER_SKILL_TALENT_33                                        = UnitUpdateFields.End + 0x0347,
        PLAYER_SKILL_TALENT_34                                        = UnitUpdateFields.End + 0x0348,
        PLAYER_SKILL_TALENT_35                                        = UnitUpdateFields.End + 0x0349,
        PLAYER_SKILL_TALENT_36                                        = UnitUpdateFields.End + 0x034A,
        PLAYER_SKILL_TALENT_37                                        = UnitUpdateFields.End + 0x034B,
        PLAYER_SKILL_TALENT_38                                        = UnitUpdateFields.End + 0x034C,
        PLAYER_SKILL_TALENT_39                                        = UnitUpdateFields.End + 0x034D,
        PLAYER_SKILL_TALENT_40                                        = UnitUpdateFields.End + 0x034E,
        PLAYER_SKILL_TALENT_41                                        = UnitUpdateFields.End + 0x034F,
        PLAYER_SKILL_TALENT_42                                        = UnitUpdateFields.End + 0x0350,
        PLAYER_SKILL_TALENT_43                                        = UnitUpdateFields.End + 0x0351,
        PLAYER_SKILL_TALENT_44                                        = UnitUpdateFields.End + 0x0352,
        PLAYER_SKILL_TALENT_45                                        = UnitUpdateFields.End + 0x0353,
        PLAYER_SKILL_TALENT_46                                        = UnitUpdateFields.End + 0x0354,
        PLAYER_SKILL_TALENT_47                                        = UnitUpdateFields.End + 0x0355,
        PLAYER_SKILL_TALENT_48                                        = UnitUpdateFields.End + 0x0356,
        PLAYER_SKILL_TALENT_49                                        = UnitUpdateFields.End + 0x0357,
        PLAYER_SKILL_TALENT_50                                        = UnitUpdateFields.End + 0x0358,
        PLAYER_SKILL_TALENT_51                                        = UnitUpdateFields.End + 0x0359,
        PLAYER_SKILL_TALENT_52                                        = UnitUpdateFields.End + 0x035A,
        PLAYER_SKILL_TALENT_53                                        = UnitUpdateFields.End + 0x035B,
        PLAYER_SKILL_TALENT_54                                        = UnitUpdateFields.End + 0x035C,
        PLAYER_SKILL_TALENT_55                                        = UnitUpdateFields.End + 0x035D,
        PLAYER_SKILL_TALENT_56                                        = UnitUpdateFields.End + 0x035E,
        PLAYER_SKILL_TALENT_57                                        = UnitUpdateFields.End + 0x035F,
        PLAYER_SKILL_TALENT_58                                        = UnitUpdateFields.End + 0x0360,
        PLAYER_SKILL_TALENT_59                                        = UnitUpdateFields.End + 0x0361,
        PLAYER_SKILL_TALENT_60                                        = UnitUpdateFields.End + 0x0362,
        PLAYER_SKILL_TALENT_61                                        = UnitUpdateFields.End + 0x0363,
        PLAYER_SKILL_TALENT_62                                        = UnitUpdateFields.End + 0x0364,
        PLAYER_SKILL_TALENT_63                                        = UnitUpdateFields.End + 0x0365,
        PLAYER_CHARACTER_POINTS                                       = UnitUpdateFields.End + 0x0366, // Size: 1, Type: Int, Flags: Private
        PLAYER_TRACK_CREATURES                                        = UnitUpdateFields.End + 0x0367, // Size: 1, Type: Int, Flags: Private
        PLAYER_TRACK_RESOURCES                                        = UnitUpdateFields.End + 0x0368, // Size: 1, Type: Int, Flags: Private
        PLAYER_EXPERTISE                                              = UnitUpdateFields.End + 0x0369, // Size: 1, Type: Int, Flags: Private
        PLAYER_OFFHAND_EXPERTISE                                      = UnitUpdateFields.End + 0x036A, // Size: 1, Type: Int, Flags: Private
        PLAYER_BLOCK_PERCENTAGE                                       = UnitUpdateFields.End + 0x036B, // Size: 1, Type: Float, Flags: Private
        PLAYER_DODGE_PERCENTAGE                                       = UnitUpdateFields.End + 0x036C, // Size: 1, Type: Float, Flags: Private
        PLAYER_PARRY_PERCENTAGE                                       = UnitUpdateFields.End + 0x036D, // Size: 1, Type: Float, Flags: Private
        PLAYER_CRIT_PERCENTAGE                                        = UnitUpdateFields.End + 0x036E, // Size: 1, Type: Float, Flags: Private
        PLAYER_RANGED_CRIT_PERCENTAGE                                 = UnitUpdateFields.End + 0x036F, // Size: 1, Type: Float, Flags: Private
        PLAYER_OFFHAND_CRIT_PERCENTAGE                                = UnitUpdateFields.End + 0x0370, // Size: 1, Type: Float, Flags: Private
        PLAYER_SPELL_CRIT_PERCENTAGE1                                 = UnitUpdateFields.End + 0x0371, // Size: 7, Type: Float, Flags: Private
        PLAYER_SPELL_CRIT_PERCENTAGE1_2                               = UnitUpdateFields.End + 0x0372,
        PLAYER_SPELL_CRIT_PERCENTAGE1_3                               = UnitUpdateFields.End + 0x0373,
        PLAYER_SPELL_CRIT_PERCENTAGE1_4                               = UnitUpdateFields.End + 0x0374,
        PLAYER_SPELL_CRIT_PERCENTAGE1_5                               = UnitUpdateFields.End + 0x0375,
        PLAYER_SPELL_CRIT_PERCENTAGE1_6                               = UnitUpdateFields.End + 0x0376,
        PLAYER_SPELL_CRIT_PERCENTAGE1_7                               = UnitUpdateFields.End + 0x0377,
        PLAYER_SHIELD_BLOCK                                           = UnitUpdateFields.End + 0x0378, // Size: 1, Type: Int, Flags: Private
        PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE                           = UnitUpdateFields.End + 0x0379, // Size: 1, Type: Float, Flags: Private
        PLAYER_MASTERY                                                = UnitUpdateFields.End + 0x037A, // Size: 1, Type: Float, Flags: Private
        PLAYER_EXPLORED_ZONES_1                                       = UnitUpdateFields.End + 0x037B, // Size: 156, Type: Bytes, Flags: Private
        PLAYER_EXPLORED_ZONES_2                                       = UnitUpdateFields.End + 0x037C,
        PLAYER_EXPLORED_ZONES_3                                       = UnitUpdateFields.End + 0x037D,
        PLAYER_EXPLORED_ZONES_4                                       = UnitUpdateFields.End + 0x037E,
        PLAYER_EXPLORED_ZONES_5                                       = UnitUpdateFields.End + 0x037F,
        PLAYER_EXPLORED_ZONES_6                                       = UnitUpdateFields.End + 0x0380,
        PLAYER_EXPLORED_ZONES_7                                       = UnitUpdateFields.End + 0x0381,
        PLAYER_EXPLORED_ZONES_8                                       = UnitUpdateFields.End + 0x0382,
        PLAYER_EXPLORED_ZONES_9                                       = UnitUpdateFields.End + 0x0383,
        PLAYER_EXPLORED_ZONES_10                                      = UnitUpdateFields.End + 0x0384,
        PLAYER_EXPLORED_ZONES_11                                      = UnitUpdateFields.End + 0x0385,
        PLAYER_EXPLORED_ZONES_12                                      = UnitUpdateFields.End + 0x0386,
        PLAYER_EXPLORED_ZONES_13                                      = UnitUpdateFields.End + 0x0387,
        PLAYER_EXPLORED_ZONES_14                                      = UnitUpdateFields.End + 0x0388,
        PLAYER_EXPLORED_ZONES_15                                      = UnitUpdateFields.End + 0x0389,
        PLAYER_EXPLORED_ZONES_16                                      = UnitUpdateFields.End + 0x038A,
        PLAYER_EXPLORED_ZONES_17                                      = UnitUpdateFields.End + 0x038B,
        PLAYER_EXPLORED_ZONES_18                                      = UnitUpdateFields.End + 0x038C,
        PLAYER_EXPLORED_ZONES_19                                      = UnitUpdateFields.End + 0x038D,
        PLAYER_EXPLORED_ZONES_20                                      = UnitUpdateFields.End + 0x038E,
        PLAYER_EXPLORED_ZONES_21                                      = UnitUpdateFields.End + 0x038F,
        PLAYER_EXPLORED_ZONES_22                                      = UnitUpdateFields.End + 0x0390,
        PLAYER_EXPLORED_ZONES_23                                      = UnitUpdateFields.End + 0x0391,
        PLAYER_EXPLORED_ZONES_24                                      = UnitUpdateFields.End + 0x0392,
        PLAYER_EXPLORED_ZONES_25                                      = UnitUpdateFields.End + 0x0393,
        PLAYER_EXPLORED_ZONES_26                                      = UnitUpdateFields.End + 0x0394,
        PLAYER_EXPLORED_ZONES_27                                      = UnitUpdateFields.End + 0x0395,
        PLAYER_EXPLORED_ZONES_28                                      = UnitUpdateFields.End + 0x0396,
        PLAYER_EXPLORED_ZONES_29                                      = UnitUpdateFields.End + 0x0397,
        PLAYER_EXPLORED_ZONES_30                                      = UnitUpdateFields.End + 0x0398,
        PLAYER_EXPLORED_ZONES_31                                      = UnitUpdateFields.End + 0x0399,
        PLAYER_EXPLORED_ZONES_32                                      = UnitUpdateFields.End + 0x039A,
        PLAYER_EXPLORED_ZONES_33                                      = UnitUpdateFields.End + 0x039B,
        PLAYER_EXPLORED_ZONES_34                                      = UnitUpdateFields.End + 0x039C,
        PLAYER_EXPLORED_ZONES_35                                      = UnitUpdateFields.End + 0x039D,
        PLAYER_EXPLORED_ZONES_36                                      = UnitUpdateFields.End + 0x039E,
        PLAYER_EXPLORED_ZONES_37                                      = UnitUpdateFields.End + 0x039F,
        PLAYER_EXPLORED_ZONES_38                                      = UnitUpdateFields.End + 0x03A0,
        PLAYER_EXPLORED_ZONES_39                                      = UnitUpdateFields.End + 0x03A1,
        PLAYER_EXPLORED_ZONES_40                                      = UnitUpdateFields.End + 0x03A2,
        PLAYER_EXPLORED_ZONES_41                                      = UnitUpdateFields.End + 0x03A3,
        PLAYER_EXPLORED_ZONES_42                                      = UnitUpdateFields.End + 0x03A4,
        PLAYER_EXPLORED_ZONES_43                                      = UnitUpdateFields.End + 0x03A5,
        PLAYER_EXPLORED_ZONES_44                                      = UnitUpdateFields.End + 0x03A6,
        PLAYER_EXPLORED_ZONES_45                                      = UnitUpdateFields.End + 0x03A7,
        PLAYER_EXPLORED_ZONES_46                                      = UnitUpdateFields.End + 0x03A8,
        PLAYER_EXPLORED_ZONES_47                                      = UnitUpdateFields.End + 0x03A9,
        PLAYER_EXPLORED_ZONES_48                                      = UnitUpdateFields.End + 0x03AA,
        PLAYER_EXPLORED_ZONES_49                                      = UnitUpdateFields.End + 0x03AB,
        PLAYER_EXPLORED_ZONES_50                                      = UnitUpdateFields.End + 0x03AC,
        PLAYER_EXPLORED_ZONES_51                                      = UnitUpdateFields.End + 0x03AD,
        PLAYER_EXPLORED_ZONES_52                                      = UnitUpdateFields.End + 0x03AE,
        PLAYER_EXPLORED_ZONES_53                                      = UnitUpdateFields.End + 0x03AF,
        PLAYER_EXPLORED_ZONES_54                                      = UnitUpdateFields.End + 0x03B0,
        PLAYER_EXPLORED_ZONES_55                                      = UnitUpdateFields.End + 0x03B1,
        PLAYER_EXPLORED_ZONES_56                                      = UnitUpdateFields.End + 0x03B2,
        PLAYER_EXPLORED_ZONES_57                                      = UnitUpdateFields.End + 0x03B3,
        PLAYER_EXPLORED_ZONES_58                                      = UnitUpdateFields.End + 0x03B4,
        PLAYER_EXPLORED_ZONES_59                                      = UnitUpdateFields.End + 0x03B5,
        PLAYER_EXPLORED_ZONES_60                                      = UnitUpdateFields.End + 0x03B6,
        PLAYER_EXPLORED_ZONES_61                                      = UnitUpdateFields.End + 0x03B7,
        PLAYER_EXPLORED_ZONES_62                                      = UnitUpdateFields.End + 0x03B8,
        PLAYER_EXPLORED_ZONES_63                                      = UnitUpdateFields.End + 0x03B9,
        PLAYER_EXPLORED_ZONES_64                                      = UnitUpdateFields.End + 0x03BA,
        PLAYER_EXPLORED_ZONES_65                                      = UnitUpdateFields.End + 0x03BB,
        PLAYER_EXPLORED_ZONES_66                                      = UnitUpdateFields.End + 0x03BC,
        PLAYER_EXPLORED_ZONES_67                                      = UnitUpdateFields.End + 0x03BD,
        PLAYER_EXPLORED_ZONES_68                                      = UnitUpdateFields.End + 0x03BE,
        PLAYER_EXPLORED_ZONES_69                                      = UnitUpdateFields.End + 0x03BF,
        PLAYER_EXPLORED_ZONES_70                                      = UnitUpdateFields.End + 0x03C0,
        PLAYER_EXPLORED_ZONES_71                                      = UnitUpdateFields.End + 0x03C1,
        PLAYER_EXPLORED_ZONES_72                                      = UnitUpdateFields.End + 0x03C2,
        PLAYER_EXPLORED_ZONES_73                                      = UnitUpdateFields.End + 0x03C3,
        PLAYER_EXPLORED_ZONES_74                                      = UnitUpdateFields.End + 0x03C4,
        PLAYER_EXPLORED_ZONES_75                                      = UnitUpdateFields.End + 0x03C5,
        PLAYER_EXPLORED_ZONES_76                                      = UnitUpdateFields.End + 0x03C6,
        PLAYER_EXPLORED_ZONES_77                                      = UnitUpdateFields.End + 0x03C7,
        PLAYER_EXPLORED_ZONES_78                                      = UnitUpdateFields.End + 0x03C8,
        PLAYER_EXPLORED_ZONES_79                                      = UnitUpdateFields.End + 0x03C9,
        PLAYER_EXPLORED_ZONES_80                                      = UnitUpdateFields.End + 0x03CA,
        PLAYER_EXPLORED_ZONES_81                                      = UnitUpdateFields.End + 0x03CB,
        PLAYER_EXPLORED_ZONES_82                                      = UnitUpdateFields.End + 0x03CC,
        PLAYER_EXPLORED_ZONES_83                                      = UnitUpdateFields.End + 0x03CD,
        PLAYER_EXPLORED_ZONES_84                                      = UnitUpdateFields.End + 0x03CE,
        PLAYER_EXPLORED_ZONES_85                                      = UnitUpdateFields.End + 0x03CF,
        PLAYER_EXPLORED_ZONES_86                                      = UnitUpdateFields.End + 0x03D0,
        PLAYER_EXPLORED_ZONES_87                                      = UnitUpdateFields.End + 0x03D1,
        PLAYER_EXPLORED_ZONES_88                                      = UnitUpdateFields.End + 0x03D2,
        PLAYER_EXPLORED_ZONES_89                                      = UnitUpdateFields.End + 0x03D3,
        PLAYER_EXPLORED_ZONES_90                                      = UnitUpdateFields.End + 0x03D4,
        PLAYER_EXPLORED_ZONES_91                                      = UnitUpdateFields.End + 0x03D5,
        PLAYER_EXPLORED_ZONES_92                                      = UnitUpdateFields.End + 0x03D6,
        PLAYER_EXPLORED_ZONES_93                                      = UnitUpdateFields.End + 0x03D7,
        PLAYER_EXPLORED_ZONES_94                                      = UnitUpdateFields.End + 0x03D8,
        PLAYER_EXPLORED_ZONES_95                                      = UnitUpdateFields.End + 0x03D9,
        PLAYER_EXPLORED_ZONES_96                                      = UnitUpdateFields.End + 0x03DA,
        PLAYER_EXPLORED_ZONES_97                                      = UnitUpdateFields.End + 0x03DB,
        PLAYER_EXPLORED_ZONES_98                                      = UnitUpdateFields.End + 0x03DC,
        PLAYER_EXPLORED_ZONES_99                                      = UnitUpdateFields.End + 0x03DD,
        PLAYER_EXPLORED_ZONES_100                                     = UnitUpdateFields.End + 0x03DE,
        PLAYER_EXPLORED_ZONES_101                                     = UnitUpdateFields.End + 0x03DF,
        PLAYER_EXPLORED_ZONES_102                                     = UnitUpdateFields.End + 0x03E0,
        PLAYER_EXPLORED_ZONES_103                                     = UnitUpdateFields.End + 0x03E1,
        PLAYER_EXPLORED_ZONES_104                                     = UnitUpdateFields.End + 0x03E2,
        PLAYER_EXPLORED_ZONES_105                                     = UnitUpdateFields.End + 0x03E3,
        PLAYER_EXPLORED_ZONES_106                                     = UnitUpdateFields.End + 0x03E4,
        PLAYER_EXPLORED_ZONES_107                                     = UnitUpdateFields.End + 0x03E5,
        PLAYER_EXPLORED_ZONES_108                                     = UnitUpdateFields.End + 0x03E6,
        PLAYER_EXPLORED_ZONES_109                                     = UnitUpdateFields.End + 0x03E7,
        PLAYER_EXPLORED_ZONES_110                                     = UnitUpdateFields.End + 0x03E8,
        PLAYER_EXPLORED_ZONES_111                                     = UnitUpdateFields.End + 0x03E9,
        PLAYER_EXPLORED_ZONES_112                                     = UnitUpdateFields.End + 0x03EA,
        PLAYER_EXPLORED_ZONES_113                                     = UnitUpdateFields.End + 0x03EB,
        PLAYER_EXPLORED_ZONES_114                                     = UnitUpdateFields.End + 0x03EC,
        PLAYER_EXPLORED_ZONES_115                                     = UnitUpdateFields.End + 0x03ED,
        PLAYER_EXPLORED_ZONES_116                                     = UnitUpdateFields.End + 0x03EE,
        PLAYER_EXPLORED_ZONES_117                                     = UnitUpdateFields.End + 0x03EF,
        PLAYER_EXPLORED_ZONES_118                                     = UnitUpdateFields.End + 0x03F0,
        PLAYER_EXPLORED_ZONES_119                                     = UnitUpdateFields.End + 0x03F1,
        PLAYER_EXPLORED_ZONES_120                                     = UnitUpdateFields.End + 0x03F2,
        PLAYER_EXPLORED_ZONES_121                                     = UnitUpdateFields.End + 0x03F3,
        PLAYER_EXPLORED_ZONES_122                                     = UnitUpdateFields.End + 0x03F4,
        PLAYER_EXPLORED_ZONES_123                                     = UnitUpdateFields.End + 0x03F5,
        PLAYER_EXPLORED_ZONES_124                                     = UnitUpdateFields.End + 0x03F6,
        PLAYER_EXPLORED_ZONES_125                                     = UnitUpdateFields.End + 0x03F7,
        PLAYER_EXPLORED_ZONES_126                                     = UnitUpdateFields.End + 0x03F8,
        PLAYER_EXPLORED_ZONES_127                                     = UnitUpdateFields.End + 0x03F9,
        PLAYER_EXPLORED_ZONES_128                                     = UnitUpdateFields.End + 0x03FA,
        PLAYER_EXPLORED_ZONES_129                                     = UnitUpdateFields.End + 0x03FB,
        PLAYER_EXPLORED_ZONES_130                                     = UnitUpdateFields.End + 0x03FC,
        PLAYER_EXPLORED_ZONES_131                                     = UnitUpdateFields.End + 0x03FD,
        PLAYER_EXPLORED_ZONES_132                                     = UnitUpdateFields.End + 0x03FE,
        PLAYER_EXPLORED_ZONES_133                                     = UnitUpdateFields.End + 0x03FF,
        PLAYER_EXPLORED_ZONES_134                                     = UnitUpdateFields.End + 0x0400,
        PLAYER_EXPLORED_ZONES_135                                     = UnitUpdateFields.End + 0x0401,
        PLAYER_EXPLORED_ZONES_136                                     = UnitUpdateFields.End + 0x0402,
        PLAYER_EXPLORED_ZONES_137                                     = UnitUpdateFields.End + 0x0403,
        PLAYER_EXPLORED_ZONES_138                                     = UnitUpdateFields.End + 0x0404,
        PLAYER_EXPLORED_ZONES_139                                     = UnitUpdateFields.End + 0x0405,
        PLAYER_EXPLORED_ZONES_140                                     = UnitUpdateFields.End + 0x0406,
        PLAYER_EXPLORED_ZONES_141                                     = UnitUpdateFields.End + 0x0407,
        PLAYER_EXPLORED_ZONES_142                                     = UnitUpdateFields.End + 0x0408,
        PLAYER_EXPLORED_ZONES_143                                     = UnitUpdateFields.End + 0x0409,
        PLAYER_EXPLORED_ZONES_144                                     = UnitUpdateFields.End + 0x040A,
        PLAYER_EXPLORED_ZONES_145                                     = UnitUpdateFields.End + 0x040B,
        PLAYER_EXPLORED_ZONES_146                                     = UnitUpdateFields.End + 0x040C,
        PLAYER_EXPLORED_ZONES_147                                     = UnitUpdateFields.End + 0x040D,
        PLAYER_EXPLORED_ZONES_148                                     = UnitUpdateFields.End + 0x040E,
        PLAYER_EXPLORED_ZONES_149                                     = UnitUpdateFields.End + 0x040F,
        PLAYER_EXPLORED_ZONES_150                                     = UnitUpdateFields.End + 0x0410,
        PLAYER_EXPLORED_ZONES_151                                     = UnitUpdateFields.End + 0x0411,
        PLAYER_EXPLORED_ZONES_152                                     = UnitUpdateFields.End + 0x0412,
        PLAYER_EXPLORED_ZONES_153                                     = UnitUpdateFields.End + 0x0413,
        PLAYER_EXPLORED_ZONES_154                                     = UnitUpdateFields.End + 0x0414,
        PLAYER_EXPLORED_ZONES_155                                     = UnitUpdateFields.End + 0x0415,
        PLAYER_EXPLORED_ZONES_156                                     = UnitUpdateFields.End + 0x0416,
        PLAYER_REST_STATE_EXPERIENCE                                  = UnitUpdateFields.End + 0x0417, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_COINAGE                                          = UnitUpdateFields.End + 0x0418, // Size: 2, Type: Long, Flags: Private
        PLAYER_FIELD_COINAGE_HIPART                                   = UnitUpdateFields.End + 0x0419,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS                              = UnitUpdateFields.End + 0x041A, // Size: 7, Type: Int, Flags: Private
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS_2                            = UnitUpdateFields.End + 0x041B,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS_3                            = UnitUpdateFields.End + 0x041C,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS_4                            = UnitUpdateFields.End + 0x041D,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS_5                            = UnitUpdateFields.End + 0x041E,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS_6                            = UnitUpdateFields.End + 0x041F,
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS_7                            = UnitUpdateFields.End + 0x0420,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG                              = UnitUpdateFields.End + 0x0421, // Size: 7, Type: Int, Flags: Private
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_2                            = UnitUpdateFields.End + 0x0422,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_3                            = UnitUpdateFields.End + 0x0423,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_4                            = UnitUpdateFields.End + 0x0424,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_5                            = UnitUpdateFields.End + 0x0425,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_6                            = UnitUpdateFields.End + 0x0426,
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_7                            = UnitUpdateFields.End + 0x0427,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT                              = UnitUpdateFields.End + 0x0428, // Size: 7, Type: Int, Flags: Private
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_2                            = UnitUpdateFields.End + 0x0429,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_3                            = UnitUpdateFields.End + 0x042A,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_4                            = UnitUpdateFields.End + 0x042B,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_5                            = UnitUpdateFields.End + 0x042C,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_6                            = UnitUpdateFields.End + 0x042D,
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_7                            = UnitUpdateFields.End + 0x042E,
        PLAYER_FIELD_MOD_HEALING_DONE_POS                             = UnitUpdateFields.End + 0x042F, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_MOD_HEALING_PCT                                  = UnitUpdateFields.End + 0x0430, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_MOD_HEALING_DONE_PCT                             = UnitUpdateFields.End + 0x0431, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS                           = UnitUpdateFields.End + 0x0432, // Size: 3, Type: Float, Flags: Private
        PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS_2                         = UnitUpdateFields.End + 0x0433,
        PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS_3                         = UnitUpdateFields.End + 0x0434,
        PLAYER_FIELD_MOD_SPELL_POWER_PCT                              = UnitUpdateFields.End + 0x0435, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_OVERRIDE_SPELL_POWER_BY_AP_PCT                   = UnitUpdateFields.End + 0x0436, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_MOD_TARGET_RESISTANCE                            = UnitUpdateFields.End + 0x0437, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE                   = UnitUpdateFields.End + 0x0438, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_BYTES                                            = UnitUpdateFields.End + 0x0439, // Size: 1, Type: Bytes, Flags: Private
        PLAYER_SELF_RES_SPELL                                         = UnitUpdateFields.End + 0x043A, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_PVP_MEDALS                                       = UnitUpdateFields.End + 0x043B, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_BUYBACK_PRICE_1                                  = UnitUpdateFields.End + 0x043C, // Size: 12, Type: Int, Flags: Private
        PLAYER_FIELD_BUYBACK_PRICE_2                                  = UnitUpdateFields.End + 0x043D,
        PLAYER_FIELD_BUYBACK_PRICE_3                                  = UnitUpdateFields.End + 0x043E,
        PLAYER_FIELD_BUYBACK_PRICE_4                                  = UnitUpdateFields.End + 0x043F,
        PLAYER_FIELD_BUYBACK_PRICE_5                                  = UnitUpdateFields.End + 0x0440,
        PLAYER_FIELD_BUYBACK_PRICE_6                                  = UnitUpdateFields.End + 0x0441,
        PLAYER_FIELD_BUYBACK_PRICE_7                                  = UnitUpdateFields.End + 0x0442,
        PLAYER_FIELD_BUYBACK_PRICE_8                                  = UnitUpdateFields.End + 0x0443,
        PLAYER_FIELD_BUYBACK_PRICE_9                                  = UnitUpdateFields.End + 0x0444,
        PLAYER_FIELD_BUYBACK_PRICE_10                                 = UnitUpdateFields.End + 0x0445,
        PLAYER_FIELD_BUYBACK_PRICE_11                                 = UnitUpdateFields.End + 0x0446,
        PLAYER_FIELD_BUYBACK_PRICE_12                                 = UnitUpdateFields.End + 0x0447,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_1                              = UnitUpdateFields.End + 0x0448, // Size: 12, Type: Int, Flags: Private
        PLAYER_FIELD_BUYBACK_TIMESTAMP_2                              = UnitUpdateFields.End + 0x0449,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_3                              = UnitUpdateFields.End + 0x044A,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_4                              = UnitUpdateFields.End + 0x044B,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_5                              = UnitUpdateFields.End + 0x044C,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_6                              = UnitUpdateFields.End + 0x044D,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_7                              = UnitUpdateFields.End + 0x044E,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_8                              = UnitUpdateFields.End + 0x044F,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_9                              = UnitUpdateFields.End + 0x0450,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_10                             = UnitUpdateFields.End + 0x0451,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_11                             = UnitUpdateFields.End + 0x0452,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_12                             = UnitUpdateFields.End + 0x0453,
        PLAYER_FIELD_KILLS                                            = UnitUpdateFields.End + 0x0454, // Size: 1, Type: TwoShort, Flags: Private
        PLAYER_FIELD_LIFETIME_HONORBALE_KILLS                         = UnitUpdateFields.End + 0x0455, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_BYTES2                                           = UnitUpdateFields.End + 0x0456, // Size: 1, Type: 6, Flags: Private
        PLAYER_FIELD_WATCHED_FACTION_INDEX                            = UnitUpdateFields.End + 0x0457, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_COMBAT_RATING_1                                  = UnitUpdateFields.End + 0x0458, // Size: 26, Type: Int, Flags: Private
        PLAYER_FIELD_COMBAT_RATING_2                                  = UnitUpdateFields.End + 0x0459,
        PLAYER_FIELD_COMBAT_RATING_3                                  = UnitUpdateFields.End + 0x045A,
        PLAYER_FIELD_COMBAT_RATING_4                                  = UnitUpdateFields.End + 0x045B,
        PLAYER_FIELD_COMBAT_RATING_5                                  = UnitUpdateFields.End + 0x045C,
        PLAYER_FIELD_COMBAT_RATING_6                                  = UnitUpdateFields.End + 0x045D,
        PLAYER_FIELD_COMBAT_RATING_7                                  = UnitUpdateFields.End + 0x045E,
        PLAYER_FIELD_COMBAT_RATING_8                                  = UnitUpdateFields.End + 0x045F,
        PLAYER_FIELD_COMBAT_RATING_9                                  = UnitUpdateFields.End + 0x0460,
        PLAYER_FIELD_COMBAT_RATING_10                                 = UnitUpdateFields.End + 0x0461,
        PLAYER_FIELD_COMBAT_RATING_11                                 = UnitUpdateFields.End + 0x0462,
        PLAYER_FIELD_COMBAT_RATING_12                                 = UnitUpdateFields.End + 0x0463,
        PLAYER_FIELD_COMBAT_RATING_13                                 = UnitUpdateFields.End + 0x0464,
        PLAYER_FIELD_COMBAT_RATING_14                                 = UnitUpdateFields.End + 0x0465,
        PLAYER_FIELD_COMBAT_RATING_15                                 = UnitUpdateFields.End + 0x0466,
        PLAYER_FIELD_COMBAT_RATING_16                                 = UnitUpdateFields.End + 0x0467,
        PLAYER_FIELD_COMBAT_RATING_17                                 = UnitUpdateFields.End + 0x0468,
        PLAYER_FIELD_COMBAT_RATING_18                                 = UnitUpdateFields.End + 0x0469,
        PLAYER_FIELD_COMBAT_RATING_19                                 = UnitUpdateFields.End + 0x046A,
        PLAYER_FIELD_COMBAT_RATING_20                                 = UnitUpdateFields.End + 0x046B,
        PLAYER_FIELD_COMBAT_RATING_21                                 = UnitUpdateFields.End + 0x046C,
        PLAYER_FIELD_COMBAT_RATING_22                                 = UnitUpdateFields.End + 0x046D,
        PLAYER_FIELD_COMBAT_RATING_23                                 = UnitUpdateFields.End + 0x046E,
        PLAYER_FIELD_COMBAT_RATING_24                                 = UnitUpdateFields.End + 0x046F,
        PLAYER_FIELD_COMBAT_RATING_25                                 = UnitUpdateFields.End + 0x0470,
        PLAYER_FIELD_COMBAT_RATING_26                                 = UnitUpdateFields.End + 0x0471,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_1                              = UnitUpdateFields.End + 0x0472, // Size: 21, Type: Int, Flags: Private
        PLAYER_FIELD_ARENA_TEAM_INFO_1_2                              = UnitUpdateFields.End + 0x0473,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_3                              = UnitUpdateFields.End + 0x0474,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_4                              = UnitUpdateFields.End + 0x0475,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_5                              = UnitUpdateFields.End + 0x0476,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_6                              = UnitUpdateFields.End + 0x0477,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_7                              = UnitUpdateFields.End + 0x0478,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_8                              = UnitUpdateFields.End + 0x0479,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_9                              = UnitUpdateFields.End + 0x047A,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_10                             = UnitUpdateFields.End + 0x047B,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_11                             = UnitUpdateFields.End + 0x047C,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_12                             = UnitUpdateFields.End + 0x047D,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_13                             = UnitUpdateFields.End + 0x047E,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_14                             = UnitUpdateFields.End + 0x047F,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_15                             = UnitUpdateFields.End + 0x0480,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_16                             = UnitUpdateFields.End + 0x0481,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_17                             = UnitUpdateFields.End + 0x0482,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_18                             = UnitUpdateFields.End + 0x0483,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_19                             = UnitUpdateFields.End + 0x0484,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_20                             = UnitUpdateFields.End + 0x0485,
        PLAYER_FIELD_ARENA_TEAM_INFO_1_21                             = UnitUpdateFields.End + 0x0486,
        PLAYER_FIELD_BATTLEGROUND_RATING                              = UnitUpdateFields.End + 0x0487, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_MAX_LEVEL                                        = UnitUpdateFields.End + 0x0488, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_DAILY_QUESTS_1                                   = UnitUpdateFields.End + 0x0489, // Size: 25, Type: Int, Flags: Private
        PLAYER_FIELD_DAILY_QUESTS_2                                   = UnitUpdateFields.End + 0x048A,
        PLAYER_FIELD_DAILY_QUESTS_3                                   = UnitUpdateFields.End + 0x048B,
        PLAYER_FIELD_DAILY_QUESTS_4                                   = UnitUpdateFields.End + 0x048C,
        PLAYER_FIELD_DAILY_QUESTS_5                                   = UnitUpdateFields.End + 0x048D,
        PLAYER_FIELD_DAILY_QUESTS_6                                   = UnitUpdateFields.End + 0x048E,
        PLAYER_FIELD_DAILY_QUESTS_7                                   = UnitUpdateFields.End + 0x048F,
        PLAYER_FIELD_DAILY_QUESTS_8                                   = UnitUpdateFields.End + 0x0490,
        PLAYER_FIELD_DAILY_QUESTS_9                                   = UnitUpdateFields.End + 0x0491,
        PLAYER_FIELD_DAILY_QUESTS_10                                  = UnitUpdateFields.End + 0x0492,
        PLAYER_FIELD_DAILY_QUESTS_11                                  = UnitUpdateFields.End + 0x0493,
        PLAYER_FIELD_DAILY_QUESTS_12                                  = UnitUpdateFields.End + 0x0494,
        PLAYER_FIELD_DAILY_QUESTS_13                                  = UnitUpdateFields.End + 0x0495,
        PLAYER_FIELD_DAILY_QUESTS_14                                  = UnitUpdateFields.End + 0x0496,
        PLAYER_FIELD_DAILY_QUESTS_15                                  = UnitUpdateFields.End + 0x0497,
        PLAYER_FIELD_DAILY_QUESTS_16                                  = UnitUpdateFields.End + 0x0498,
        PLAYER_FIELD_DAILY_QUESTS_17                                  = UnitUpdateFields.End + 0x0499,
        PLAYER_FIELD_DAILY_QUESTS_18                                  = UnitUpdateFields.End + 0x049A,
        PLAYER_FIELD_DAILY_QUESTS_19                                  = UnitUpdateFields.End + 0x049B,
        PLAYER_FIELD_DAILY_QUESTS_20                                  = UnitUpdateFields.End + 0x049C,
        PLAYER_FIELD_DAILY_QUESTS_21                                  = UnitUpdateFields.End + 0x049D,
        PLAYER_FIELD_DAILY_QUESTS_22                                  = UnitUpdateFields.End + 0x049E,
        PLAYER_FIELD_DAILY_QUESTS_23                                  = UnitUpdateFields.End + 0x049F,
        PLAYER_FIELD_DAILY_QUESTS_24                                  = UnitUpdateFields.End + 0x04A0,
        PLAYER_FIELD_DAILY_QUESTS_25                                  = UnitUpdateFields.End + 0x04A1,
        PLAYER_RUNE_REGEN_1                                           = UnitUpdateFields.End + 0x04A2, // Size: 4, Type: Float, Flags: Private
        PLAYER_RUNE_REGEN_2                                           = UnitUpdateFields.End + 0x04A3,
        PLAYER_RUNE_REGEN_3                                           = UnitUpdateFields.End + 0x04A4,
        PLAYER_RUNE_REGEN_4                                           = UnitUpdateFields.End + 0x04A5,
        PLAYER_NO_REAGENT_COST_1                                      = UnitUpdateFields.End + 0x04A6, // Size: 3, Type: Int, Flags: Private
        PLAYER_NO_REAGENT_COST_2                                      = UnitUpdateFields.End + 0x04A7,
        PLAYER_NO_REAGENT_COST_3                                      = UnitUpdateFields.End + 0x04A8,
        PLAYER_FIELD_GLYPH_SLOTS_1                                    = UnitUpdateFields.End + 0x04A9, // Size: 9, Type: Int, Flags: Private
        PLAYER_FIELD_GLYPH_SLOTS_2                                    = UnitUpdateFields.End + 0x04AA,
        PLAYER_FIELD_GLYPH_SLOTS_3                                    = UnitUpdateFields.End + 0x04AB,
        PLAYER_FIELD_GLYPH_SLOTS_4                                    = UnitUpdateFields.End + 0x04AC,
        PLAYER_FIELD_GLYPH_SLOTS_5                                    = UnitUpdateFields.End + 0x04AD,
        PLAYER_FIELD_GLYPH_SLOTS_6                                    = UnitUpdateFields.End + 0x04AE,
        PLAYER_FIELD_GLYPH_SLOTS_7                                    = UnitUpdateFields.End + 0x04AF,
        PLAYER_FIELD_GLYPH_SLOTS_8                                    = UnitUpdateFields.End + 0x04B0,
        PLAYER_FIELD_GLYPH_SLOTS_9                                    = UnitUpdateFields.End + 0x04B1,
        PLAYER_FIELD_GLYPHS_1                                         = UnitUpdateFields.End + 0x04B2, // Size: 9, Type: Int, Flags: Private
        PLAYER_FIELD_GLYPHS_2                                         = UnitUpdateFields.End + 0x04B3,
        PLAYER_FIELD_GLYPHS_3                                         = UnitUpdateFields.End + 0x04B4,
        PLAYER_FIELD_GLYPHS_4                                         = UnitUpdateFields.End + 0x04B5,
        PLAYER_FIELD_GLYPHS_5                                         = UnitUpdateFields.End + 0x04B6,
        PLAYER_FIELD_GLYPHS_6                                         = UnitUpdateFields.End + 0x04B7,
        PLAYER_FIELD_GLYPHS_7                                         = UnitUpdateFields.End + 0x04B8,
        PLAYER_FIELD_GLYPHS_8                                         = UnitUpdateFields.End + 0x04B9,
        PLAYER_FIELD_GLYPHS_9                                         = UnitUpdateFields.End + 0x04BA,
        PLAYER_GLYPHS_ENABLED                                         = UnitUpdateFields.End + 0x04BB, // Size: 1, Type: Int, Flags: Private
        PLAYER_PET_SPELL_POWER                                        = UnitUpdateFields.End + 0x04BC, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_RESEARCHING_1                                    = UnitUpdateFields.End + 0x04BD, // Size: 8, Type: TwoShort, Flags: Private
        PLAYER_FIELD_RESEARCHING_2                                    = UnitUpdateFields.End + 0x04BE,
        PLAYER_FIELD_RESEARCHING_3                                    = UnitUpdateFields.End + 0x04BF,
        PLAYER_FIELD_RESEARCHING_4                                    = UnitUpdateFields.End + 0x04C0,
        PLAYER_FIELD_RESEARCHING_5                                    = UnitUpdateFields.End + 0x04C1,
        PLAYER_FIELD_RESEARCHING_6                                    = UnitUpdateFields.End + 0x04C2,
        PLAYER_FIELD_RESEARCHING_7                                    = UnitUpdateFields.End + 0x04C3,
        PLAYER_FIELD_RESEARCHING_8                                    = UnitUpdateFields.End + 0x04C4,
        PLAYER_FIELD_RESERACH_SITE_1                                  = UnitUpdateFields.End + 0x04C5, // Size: 8, Type: TwoShort, Flags: Private
        PLAYER_FIELD_RESERACH_SITE_2                                  = UnitUpdateFields.End + 0x04C6,
        PLAYER_FIELD_RESERACH_SITE_3                                  = UnitUpdateFields.End + 0x04C7,
        PLAYER_FIELD_RESERACH_SITE_4                                  = UnitUpdateFields.End + 0x04C8,
        PLAYER_FIELD_RESERACH_SITE_5                                  = UnitUpdateFields.End + 0x04C9,
        PLAYER_FIELD_RESERACH_SITE_6                                  = UnitUpdateFields.End + 0x04CA,
        PLAYER_FIELD_RESERACH_SITE_7                                  = UnitUpdateFields.End + 0x04CB,
        PLAYER_FIELD_RESERACH_SITE_8                                  = UnitUpdateFields.End + 0x04CC,
        PLAYER_PROFESSION_SKILL_LINE_1                                = UnitUpdateFields.End + 0x04CD, // Size: 2, Type: Int, Flags: Private
        PLAYER_PROFESSION_SKILL_LINE_2                                = UnitUpdateFields.End + 0x04CE,
        PLAYER_FIELD_UI_HIT_MODIFIER                                  = UnitUpdateFields.End + 0x04CF, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_UI_SPELL_HIT_MODIFIER                            = UnitUpdateFields.End + 0x04D0, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_HOME_REALM_TIME_OFFSET                           = UnitUpdateFields.End + 0x04D1, // Size: 1, Type: Int, Flags: Private
        PLAYER_FIELD_MOD_HASTE                                        = UnitUpdateFields.End + 0x04D2, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_MOD_RANGED_HASTE                                 = UnitUpdateFields.End + 0x04D3, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_MOD_PET_HASTE                                    = UnitUpdateFields.End + 0x04D4, // Size: 1, Type: Float, Flags: Private
        PLAYER_FIELD_MOD_HASTE_REGEN                                  = UnitUpdateFields.End + 0x04D5, // Size: 1, Type: Float, Flags: Private
        End                                                           = UnitUpdateFields.End + 0x04D6
    }

    public partial class UpdateFields
    {
        private static UpdateField<GameObjectUpdateFields>[] _GameObjectUpdateFields = new UpdateField<GameObjectUpdateFields>[]
        {
            new UpdateField<GameObjectUpdateFields>(4, 1, GameObjectUpdateFields.OBJECT_FIELD_CREATED_BY),
            new UpdateField<GameObjectUpdateFields>(4, 1, GameObjectUpdateFields.OBJECT_FIELD_CREATED_BY_HIPART),
            new UpdateField<GameObjectUpdateFields>(1, 1, GameObjectUpdateFields.GAMEOBJECT_DISPLAYID),
            new UpdateField<GameObjectUpdateFields>(1, 1, GameObjectUpdateFields.GAMEOBJECT_FLAGS),
            new UpdateField<GameObjectUpdateFields>(3, 1, GameObjectUpdateFields.GAMEOBJECT_PARENTROTATION),
            new UpdateField<GameObjectUpdateFields>(3, 1, GameObjectUpdateFields.GAMEOBJECT_PARENTROTATION_2),
            new UpdateField<GameObjectUpdateFields>(3, 1, GameObjectUpdateFields.GAMEOBJECT_PARENTROTATION_3),
            new UpdateField<GameObjectUpdateFields>(3, 1, GameObjectUpdateFields.GAMEOBJECT_PARENTROTATION_4),
            new UpdateField<GameObjectUpdateFields>(2, 128, GameObjectUpdateFields.GAMEOBJECT_DYNAMIC),
            new UpdateField<GameObjectUpdateFields>(1, 1, GameObjectUpdateFields.GAMEOBJECT_FACTION),
            new UpdateField<GameObjectUpdateFields>(1, 1, GameObjectUpdateFields.GAMEOBJECT_LEVEL),
            new UpdateField<GameObjectUpdateFields>(5, 1, GameObjectUpdateFields.GAMEOBJECT_BYTES_1),
        };
        public static UpdateField<GameObjectUpdateFields> GetUpdateField(GameObjectUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ObjectUpdateFields.End;
            if (index >= (uint)GameObjectUpdateFields.End)
                return UpdateField.CreateUnknown<GameObjectUpdateFields>(uf);

            return _GameObjectUpdateFields[index];
        }
    }
    public enum GameObjectUpdateFields : uint
    {
        OBJECT_FIELD_CREATED_BY                                       = ObjectUpdateFields.End + 0x0000, // Size: 2, Type: Long, Flags: Public
        OBJECT_FIELD_CREATED_BY_HIPART                                = ObjectUpdateFields.End + 0x0001,
        GAMEOBJECT_DISPLAYID                                          = ObjectUpdateFields.End + 0x0002, // Size: 1, Type: Int, Flags: Public
        GAMEOBJECT_FLAGS                                              = ObjectUpdateFields.End + 0x0003, // Size: 1, Type: Int, Flags: Public
        GAMEOBJECT_PARENTROTATION                                     = ObjectUpdateFields.End + 0x0004, // Size: 4, Type: Float, Flags: Public
        GAMEOBJECT_PARENTROTATION_2                                   = ObjectUpdateFields.End + 0x0005,
        GAMEOBJECT_PARENTROTATION_3                                   = ObjectUpdateFields.End + 0x0006,
        GAMEOBJECT_PARENTROTATION_4                                   = ObjectUpdateFields.End + 0x0007,
        GAMEOBJECT_DYNAMIC                                            = ObjectUpdateFields.End + 0x0008, // Size: 1, Type: TwoShort, Flags: Unk4
        GAMEOBJECT_FACTION                                            = ObjectUpdateFields.End + 0x0009, // Size: 1, Type: Int, Flags: Public
        GAMEOBJECT_LEVEL                                              = ObjectUpdateFields.End + 0x000A, // Size: 1, Type: Int, Flags: Public
        GAMEOBJECT_BYTES_1                                            = ObjectUpdateFields.End + 0x000B, // Size: 1, Type: Bytes, Flags: Public
        End                                                           = ObjectUpdateFields.End + 0x000C
    }

    public partial class UpdateFields
    {
        private static UpdateField<DynamicObjectUpdateFields>[] _DynamicObjectUpdateFields = new UpdateField<DynamicObjectUpdateFields>[]
        {
            new UpdateField<DynamicObjectUpdateFields>(4, 1, DynamicObjectUpdateFields.DYNAMICOBJECT_CASTER),
            new UpdateField<DynamicObjectUpdateFields>(4, 1, DynamicObjectUpdateFields.DYNAMICOBJECT_CASTER_HIPART),
            new UpdateField<DynamicObjectUpdateFields>(1, 128, DynamicObjectUpdateFields.DYNAMICOBJECT_BYTES),
            new UpdateField<DynamicObjectUpdateFields>(1, 1, DynamicObjectUpdateFields.DYNAMICOBJECT_SPELLID),
            new UpdateField<DynamicObjectUpdateFields>(3, 1, DynamicObjectUpdateFields.DYNAMICOBJECT_RADIUS),
            new UpdateField<DynamicObjectUpdateFields>(1, 1, DynamicObjectUpdateFields.DYNAMICOBJECT_CASTTIME),
        };
        public static UpdateField<DynamicObjectUpdateFields> GetUpdateField(DynamicObjectUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ObjectUpdateFields.End;
            if (index >= (uint)DynamicObjectUpdateFields.End)
                return UpdateField.CreateUnknown<DynamicObjectUpdateFields>(uf);

            return _DynamicObjectUpdateFields[index];
        }
    }
    public enum DynamicObjectUpdateFields : uint
    {
        DYNAMICOBJECT_CASTER                                          = ObjectUpdateFields.End + 0x0000, // Size: 2, Type: Long, Flags: Public
        DYNAMICOBJECT_CASTER_HIPART                                   = ObjectUpdateFields.End + 0x0001,
        DYNAMICOBJECT_BYTES                                           = ObjectUpdateFields.End + 0x0002, // Size: 1, Type: Int, Flags: Unk4
        DYNAMICOBJECT_SPELLID                                         = ObjectUpdateFields.End + 0x0003, // Size: 1, Type: Int, Flags: Public
        DYNAMICOBJECT_RADIUS                                          = ObjectUpdateFields.End + 0x0004, // Size: 1, Type: Float, Flags: Public
        DYNAMICOBJECT_CASTTIME                                        = ObjectUpdateFields.End + 0x0005, // Size: 1, Type: Int, Flags: Public
        End                                                           = ObjectUpdateFields.End + 0x0006
    }

    public partial class UpdateFields
    {
        private static UpdateField<CorpseUpdateFields>[] _CorpseUpdateFields = new UpdateField<CorpseUpdateFields>[]
        {
            new UpdateField<CorpseUpdateFields>(4, 1, CorpseUpdateFields.CORPSE_FIELD_OWNER),
            new UpdateField<CorpseUpdateFields>(4, 1, CorpseUpdateFields.CORPSE_FIELD_OWNER_HIPART),
            new UpdateField<CorpseUpdateFields>(4, 1, CorpseUpdateFields.CORPSE_FIELD_PARTY),
            new UpdateField<CorpseUpdateFields>(4, 1, CorpseUpdateFields.CORPSE_FIELD_PARTY_HIPART),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_DISPLAY_ID),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_2),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_3),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_4),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_5),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_6),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_7),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_8),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_9),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_10),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_11),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_12),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_13),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_14),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_15),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_16),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_17),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_18),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_ITEM_19),
            new UpdateField<CorpseUpdateFields>(5, 1, CorpseUpdateFields.CORPSE_FIELD_BYTES_1),
            new UpdateField<CorpseUpdateFields>(5, 1, CorpseUpdateFields.CORPSE_FIELD_BYTES_2),
            new UpdateField<CorpseUpdateFields>(1, 1, CorpseUpdateFields.CORPSE_FIELD_FLAGS),
            new UpdateField<CorpseUpdateFields>(1, 128, CorpseUpdateFields.CORPSE_FIELD_DYNAMIC_FLAGS),
        };
        public static UpdateField<CorpseUpdateFields> GetUpdateField(CorpseUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ObjectUpdateFields.End;
            if (index >= (uint)CorpseUpdateFields.End)
                return UpdateField.CreateUnknown<CorpseUpdateFields>(uf);

            return _CorpseUpdateFields[index];
        }
    }
    public enum CorpseUpdateFields : uint
    {
        CORPSE_FIELD_OWNER                                            = ObjectUpdateFields.End + 0x0000, // Size: 2, Type: Long, Flags: Public
        CORPSE_FIELD_OWNER_HIPART                                     = ObjectUpdateFields.End + 0x0001,
        CORPSE_FIELD_PARTY                                            = ObjectUpdateFields.End + 0x0002, // Size: 2, Type: Long, Flags: Public
        CORPSE_FIELD_PARTY_HIPART                                     = ObjectUpdateFields.End + 0x0003,
        CORPSE_FIELD_DISPLAY_ID                                       = ObjectUpdateFields.End + 0x0004, // Size: 1, Type: Int, Flags: Public
        CORPSE_FIELD_ITEM                                             = ObjectUpdateFields.End + 0x0005, // Size: 19, Type: Int, Flags: Public
        CORPSE_FIELD_ITEM_2                                           = ObjectUpdateFields.End + 0x0006,
        CORPSE_FIELD_ITEM_3                                           = ObjectUpdateFields.End + 0x0007,
        CORPSE_FIELD_ITEM_4                                           = ObjectUpdateFields.End + 0x0008,
        CORPSE_FIELD_ITEM_5                                           = ObjectUpdateFields.End + 0x0009,
        CORPSE_FIELD_ITEM_6                                           = ObjectUpdateFields.End + 0x000A,
        CORPSE_FIELD_ITEM_7                                           = ObjectUpdateFields.End + 0x000B,
        CORPSE_FIELD_ITEM_8                                           = ObjectUpdateFields.End + 0x000C,
        CORPSE_FIELD_ITEM_9                                           = ObjectUpdateFields.End + 0x000D,
        CORPSE_FIELD_ITEM_10                                          = ObjectUpdateFields.End + 0x000E,
        CORPSE_FIELD_ITEM_11                                          = ObjectUpdateFields.End + 0x000F,
        CORPSE_FIELD_ITEM_12                                          = ObjectUpdateFields.End + 0x0010,
        CORPSE_FIELD_ITEM_13                                          = ObjectUpdateFields.End + 0x0011,
        CORPSE_FIELD_ITEM_14                                          = ObjectUpdateFields.End + 0x0012,
        CORPSE_FIELD_ITEM_15                                          = ObjectUpdateFields.End + 0x0013,
        CORPSE_FIELD_ITEM_16                                          = ObjectUpdateFields.End + 0x0014,
        CORPSE_FIELD_ITEM_17                                          = ObjectUpdateFields.End + 0x0015,
        CORPSE_FIELD_ITEM_18                                          = ObjectUpdateFields.End + 0x0016,
        CORPSE_FIELD_ITEM_19                                          = ObjectUpdateFields.End + 0x0017,
        CORPSE_FIELD_BYTES_1                                          = ObjectUpdateFields.End + 0x0018, // Size: 1, Type: Bytes, Flags: Public
        CORPSE_FIELD_BYTES_2                                          = ObjectUpdateFields.End + 0x0019, // Size: 1, Type: Bytes, Flags: Public
        CORPSE_FIELD_FLAGS                                            = ObjectUpdateFields.End + 0x001A, // Size: 1, Type: Int, Flags: Public
        CORPSE_FIELD_DYNAMIC_FLAGS                                    = ObjectUpdateFields.End + 0x001B, // Size: 1, Type: Int, Flags: Unk4
        End                                                           = ObjectUpdateFields.End + 0x001C
    }

    public partial class UpdateFields
    {
        private static UpdateField<AreaTriggerUpdateFields>[] _AreaTriggerUpdateFields = new UpdateField<AreaTriggerUpdateFields>[]
        {
            new UpdateField<AreaTriggerUpdateFields>(1, 1, AreaTriggerUpdateFields.AREATRIGGER_SPELLID),
            new UpdateField<AreaTriggerUpdateFields>(1, 1, AreaTriggerUpdateFields.AREATRIGGER_SPELLVISUALID),
            new UpdateField<AreaTriggerUpdateFields>(1, 1, AreaTriggerUpdateFields.AREATRIGGER_DURATION),
            new UpdateField<AreaTriggerUpdateFields>(3, 1, AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS),
            new UpdateField<AreaTriggerUpdateFields>(3, 1, AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS_2),
            new UpdateField<AreaTriggerUpdateFields>(3, 1, AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS_3),
        };
        public static UpdateField<AreaTriggerUpdateFields> GetUpdateField(AreaTriggerUpdateFields uf)
        {
            uint index = (uint)uf - (uint)ObjectUpdateFields.End;
            if (index >= (uint)AreaTriggerUpdateFields.End)
                return UpdateField.CreateUnknown<AreaTriggerUpdateFields>(uf);

            return _AreaTriggerUpdateFields[index];
        }
    }
    public enum AreaTriggerUpdateFields : uint
    {
        AREATRIGGER_SPELLID                                           = ObjectUpdateFields.End + 0x0000, // Size: 1, Type: Int, Flags: Public
        AREATRIGGER_SPELLVISUALID                                     = ObjectUpdateFields.End + 0x0001, // Size: 1, Type: Int, Flags: Public
        AREATRIGGER_DURATION                                          = ObjectUpdateFields.End + 0x0002, // Size: 1, Type: Int, Flags: Public
        AREATRIGGER_FINAL_POS                                         = ObjectUpdateFields.End + 0x0003, // Size: 3, Type: Float, Flags: Public
        AREATRIGGER_FINAL_POS_2                                       = ObjectUpdateFields.End + 0x0004,
        AREATRIGGER_FINAL_POS_3                                       = ObjectUpdateFields.End + 0x0005,
        End                                                           = ObjectUpdateFields.End + 0x0006
    }

}
