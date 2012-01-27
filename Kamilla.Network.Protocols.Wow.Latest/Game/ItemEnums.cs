using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum DB2Ids : uint
    {
        [LocalizedName("Item.db2")]
        Item = 0x50238EC2,
        [LocalizedName("Item-sparse.db2")]
        ItemSparse = 0x919BE54E,
    }

    public enum ItemSubClass
    {
        // Weapon
        WeaponAxe1H     = 0,
        WeaponAxe2H     = 1,
        WeaponBow       = 2,
        WeaponGun       = 3,
        WeaponMace1H    = 4,
        WeaponMace2H    = 5,
        WeaponPolearm   = 6,
        WeaponSword1H   = 7,
        WeaponSword2H   = 8,
        WeaponNotDisplayedTotem = 9,
        WeaponStaff     = 10,
        WeaponExotic1H  = 11,
        WeaponExotic2H  = 12,
        WeaponFist      = 13,
        WeaponMisc      = 14,
        WeaponDagger    = 15,
        WeaponThrown    = 16,
        WeaponSpear     = 17,
        WeaponCrossbow  = 18,
        WeaponWand      = 19,
        WeaponFishingPole = 20,

        // Armor
        ArmorMisc       = 0,
        ArmorCloth      = 1,
        ArmorLeather    = 2,
        ArmorMail       = 3,
        ArmorPlate      = 4,
        ArmorBuckler    = 5,
        ArmorShield     = 6,
        ArmorLibram     = 7,
        ArmorIdol       = 8,
        ArmorTotem      = 9,
        ArmorSigil      = 10,

        // Projectile
        ProjectileArrow  = 2,
        ProjectileBullet = 3,

        // Trade goods
        TradeGoodMisc = 0,
        TradeGoodParts = 1,
        TradeGoodExplosives = 2,
        TradeGoodDevices = 3,

        // Recipe
        RecipeBook = 0,
        RecipeLeatherworking = 1,
        RecipeTailoring = 2,
        RecipeEngineering = 3,
        RecipeBlacksmithing = 4,
        RecipeCooking = 5,
        RecipeAlchemy = 6,
        RecipeFirstAid = 7,
        RecipeEnchanting = 8,
        RecipeFishing = 9,

        // Quiver
        AmmoPouch   = 3,
        Quiver      = 2,

        // Misc
        Junk    = 0,
        Reagent = 1,
        Pet     = 2,
        Holiday = 3,
        Other   = 4,
        Mount   = 5,
    }

    public enum ItemClass
    {
        Consumable  = 0,
        Container   = 1,
        Weapon      = 2,
        Gem         = 3,
        Armor       = 4,
        Reagent     = 5,
        Projectile  = 6,
        TradeGoods  = 7,
        Generic     = 8,
        Recipe      = 9,
        Money       = 10,
        Quiver      = 11,
        Quest       = 12,
        Key         = 13,
        Permanent   = 14,
        Misc        = 15,
        Glyph       = 16,
    }

    [Flags]
    public enum ItemSubClassWeaponMask
    {
        All             = -1,
        Axe1H           = 1 << ItemSubClass.WeaponAxe1H,
        Axe2H           = 1 << ItemSubClass.WeaponAxe2H,
        Bow             = 1 << ItemSubClass.WeaponBow,
        Gun             = 1 << ItemSubClass.WeaponGun,
        Mace1H          = 1 << ItemSubClass.WeaponMace1H,
        Mace2H          = 1 << ItemSubClass.WeaponMace2H,
        Polearm         = 1 << ItemSubClass.WeaponPolearm,
        Sword1H         = 1 << ItemSubClass.WeaponSword1H,
        Sword2H         = 1 << ItemSubClass.WeaponSword2H,
        NotDisplayedTotem = 1 << ItemSubClass.WeaponNotDisplayedTotem,
        Staff           = 1 << ItemSubClass.WeaponStaff,
        Exotic1H        = 1 << ItemSubClass.WeaponExotic1H,
        Exotic2H        = 1 << ItemSubClass.WeaponExotic2H,
        Fist            = 1 << ItemSubClass.WeaponFist,
        Misc            = 1 << ItemSubClass.WeaponMisc,
        Dagger          = 1 << ItemSubClass.WeaponDagger,
        Thrown          = 1 << ItemSubClass.WeaponThrown,
        Spear           = 1 << ItemSubClass.WeaponSpear,
        Crossbow        = 1 << ItemSubClass.WeaponCrossbow,
        Wand            = 1 << ItemSubClass.WeaponWand,
        FishingPole     = 1 << ItemSubClass.WeaponFishingPole,
    }

    [Flags]
    public enum ItemSubClassArmorMask
    {
        All     = -1,
        Misc    = 1 << ItemSubClass.ArmorMisc,
        Cloth   = 1 << ItemSubClass.ArmorCloth,
        leather = 1 << ItemSubClass.ArmorLeather,
        Mail    = 1 << ItemSubClass.ArmorMail,
        Plate   = 1 << ItemSubClass.ArmorPlate,
        Buckler = 1 << ItemSubClass.ArmorBuckler,
        Shield  = 1 << ItemSubClass.ArmorShield,
        Libram  = 1 << ItemSubClass.ArmorLibram,
        Idol    = 1 << ItemSubClass.ArmorIdol,
        Totem   = 1 << ItemSubClass.ArmorTotem,
        Sigil   = 1 << ItemSubClass.ArmorSigil,
    }

    [Flags]
    public enum ItemSubClassMiscMask
    {
        All     = -1,
        Junk    = 1 << ItemSubClass.Junk,
        Reagent = 1 << ItemSubClass.Reagent,
        Pet     = 1 << ItemSubClass.Pet,
        Holiday = 1 << ItemSubClass.Holiday,
        Other   = 1 << ItemSubClass.Other,
        Mount   = 1 << ItemSubClass.Mount,
    }

    public enum ItemQuality
    {
        Poor        = 0,
        Common      = 1,
        Uncommon    = 2,
        Superior    = 3,
        Epic        = 4,
        Legendary   = 5,
        GM          = 6,
        Heirloom    = 7,
    }

    public enum InventorySlot
    {
        Head = 0,
        Neck = 1,
        Shoulders = 2,
        Body = 3,
        Chest = 4,
        Waist = 5,
        Legs = 6,
        Feet = 7,
        Wrists = 8,
        Hands = 9,
        Finger1 = 10,
        Finger2 = 11,
        Trinket1 = 12,
        Trinket2 = 13,
        Back = 14,
        MainHand = 15,
        OffHand = 16,
        ExtraWeapon = 17,
        Tabard = 18,

        Bag1 = 19,
        Bag2,
        Bag3,
        BagLast,

        BackPack1 = 23,
        BackPack2,
        BackPack3,
        BackPack4,
        BackPack5,
        BackPack6,
        BackPack7,
        BackPack8,
        BackPack9,
        BackPack10,
        BackPack11,
        BackPack12,
        BackPack13,
        BackPack14,
        BackPack15,
        /// <summary>
        /// BackPack16 (amount might change in the future)
        /// </summary>
        BackPackLast,

        Bank1 = 39,
        Bank2,
        Bank3,
        Bank4,
        Bank5,
        Bank6,
        Bank7,
        Bank8,
        Bank9,
        Bank10,
        Bank11,
        Bank12,
        Bank13,
        Bank14,
        Bank15,
        Bank16,
        Bank17,
        Bank18,
        Bank19,
        Bank20,
        Bank21,
        Bank22,
        Bank23,
        Bank24,
        Bank25,
        Bank26,
        Bank27,
        /// <summary>
        /// Bank28 (amount might change in the future)
        /// </summary>
        BankLast,

        BankBag1 = 67,
        BankBag2,
        BankBag3,
        BankBag4,
        BankBag5,
        BankBag6,
        /// <summary>
        /// BankBag7 (amount might change in the future)
        /// </summary>
        BankBagLast = 73,

        BuyBack1 = 74,
        BuyBack2,
        BuyBack3,
        BuyBack4,
        BuyBack5,
        BuyBack6,
        BuyBack7,
        BuyBack8,
        BuyBack9,
        BuyBack10,
        BuyBack11,
        /// <summary>
        /// BuyBack12 (amount might change in the future)
        /// </summary>
        BuyBackLast,

        // keyring keys
        Key1 = 86,
        Key2,
        Key3,
        Key4,
        Key5,
        Key6,
        Key7,
        Key8,
        Key9,
        Key10,
        Key11,
        Key12,
        Key13,
        Key14,
        Key15,
        Key16,
        Key17,
        Key18,
        Key19,
        Key20,
        Key21,
        Key22,
        Key23,
        Key24,
        Key25,
        Key26,
        Key27,
        Key28,
        Key29,
        Key30,
        Key31,
        /// <summary>
        /// Key32 (amount might change in the future)
        /// </summary>
        KeyLast,

        Count,
        Invalid = 255
    }

    public enum InventorySlotType
    {
        None = 0,
        Head = 1,
        Neck = 2,
        Shoulder = 3,
        Body = 4,
        Chest = 5,
        Waist = 6,
        Legs = 7,
        Feet = 8,
        Wrist = 9,
        Hand = 10,
        Finger = 11,
        Trinket = 12,
        Weapon = 13,
        Shield = 14,
        Ranged = 15,
        Cloak = 16,
        TwoHandWeapon = 17,
        Bag = 18,
        Tabard = 19,
        Robe = 20,
        WeaponMainHand = 21,
        WeaponOffHand = 22,
        Holdable = 23,
        Ammo = 24,
        Thrown = 25,
        RangedRight = 26,
        /// <summary>
        /// Ammo pouch
        /// </summary>
        Quiver = 27,
        Relic = 28,
        End
    }

    [Flags]
    public enum InventorySlotTypeMask
    {
        None = 0,
        Head = 0x002,
        Neck = 0x000004,
        Shoulder = 0x000008,
        Body = 0x000010,
        Chest = 0x000020,
        Waist = 0x00040,
        Legs = 0x00080,
        Feet = 0x000100,
        Wrist = 0x00200,
        Hand = 0x00400,
        Finger = 0x00800,
        Trinket = 0x01000,
        Weapon = 0x02000,
        Shield = 0x04000,
        Ranged = 0x08000,
        Cloak = 0x10000,
        TwoHandWeapon = 0x20000,
        Bag = 0x040000,
        Tabard = 0x080000,
        Robe = 0x00100000,
        WeaponMainHand = 0x00200000,
        WeaponOffHand = 0x00400000,
        Holdable = 0x00800000,
        Ammo = 0x01000000,
        Thrown = 0x02000000,
        RangedRight = 0x04000000,
        /// <summary>
        /// Ammo pouch
        /// </summary>
        Quiver = 0x08000000,
        Relic = 0x10000000
    }

    /// <summary>
    /// Item modifiers
    /// </summary>
    public enum ItemModType
    {
        None = -1,
        Power = 0,
        Health = 1,
        /// <summary>
        /// Unused
        /// </summary>
        Unused = 2,
        Agility = 3,
        Strength = 4,
        Intellect = 5,
        Spirit = 6,
        Stamina = 7,

        WeaponSkillRating = 11,
        DefenseRating = 12,
        DodgeRating = 13,
        ParryRating = 14,
        BlockRating = 15,
        /// <summary>
        /// Unused
        /// </summary>
        MeleeHitRating = 16,
        /// <summary>
        /// Unused
        /// </summary>
        RangedHitRating = 17,
        SpellHitRating = 18,
        MeleeCriticalStrikeRating = 19,
        RangedCriticalStrikeRating = 20,
        SpellCriticalStrikeRating = 21,
        /// <summary>
        /// Unused
        /// </summary>
        MeleeHitAvoidanceRating = 22,
        /// <summary>
        /// Unused
        /// </summary>
        RangedHitAvoidanceRating = 23,
        /// <summary>
        /// Unused
        /// </summary>
        SpellHitAvoidanceRating = 24,
        /// <summary>
        /// Unused (see Resilience)
        /// </summary>
        MeleeCriticalAvoidanceRating = 25,
        /// <summary>
        /// Unused (see Resilience)
        /// </summary>
        RangedCriticalAvoidanceRating = 26,
        /// <summary>
        /// Unused (see Resilience)
        /// </summary>
        SpellCriticalAvoidanceRating = 27,
        MeleeHasteRating = 28,
        RangedHasteRating = 29,
        SpellHasteRating = 30,
        /// <summary>
        /// Melee and Ranged HitRating (no SpellHitRating)
        /// </summary>
        HitRating = 31,

        CriticalStrikeRating = 32,
        /// <summary>
        /// Unused
        /// </summary>
        HitAvoidanceRating = 33,
        /// <summary>
        /// Unused (see Resilience)
        /// </summary>
        CriticalAvoidanceRating = 34,
        ResilienceRating = 35,
        HasteRating = 36,
        ExpertiseRating = 37,

        // 3.x
        AttackPower = 38,
        RangedAttackPower = 39,
        FeralAttackPower = 40,
        SpellHealingDone = 41,
        SpellDamageDone = 42,
        ManaRegeneration = 43,
        ArmorRegenRating = 44,
        SpellPower = 45,

        // 3.2.2
        HealthRegenration = 46,
        SpellPenetration = 47,
        BlockValue = 48,

        End = 100
    }

    public enum ItemBondType
    {
        None = 0,
        OnPickup = 1,
        OnEquip = 2,
        OnUse = 3,
        Quest = 4,
    }

    public enum ItemSpellTrigger
    {
        Use = 0,
        Equip = 1,
        ChanceOnHit = 2,

        /// <summary>
        /// Only used by: Glowing Sanctified Crystal (ID: 23442)
        /// To cast: Unsummon Sanctified Crystal (Id: 29343)
        /// </summary>
        Unsummon = 3,

        Soulstone = 4,

        /// <summary>
        /// Only used by 3 Quest Items; 
        /// each triggering a Dummy spell which seems to check for another requirement and -if given- allow something to happen
        /// </summary>
        Combo = 5,

        /// <summary>
        /// Casted once and then consumes the Item (usually teaching formulars, patterns, designs etc)
        /// </summary>
        Consume = 6
    }

    public enum ItemProjectileType
    {
        None = 0,
        /// <summary>
        /// Obsolete
        /// </summary>
        Bolts = 1,
        Arrows = 2,
        Bullets = 3,
        Thrown = 4
    }

    [Flags]
    public enum SocketColor : uint
    {
        None = 0,
        Meta = 1,
        Red = 2,

        Yellow = 4,

        Blue = 8,

    }

    /// <summary>
    /// Used In CMSG_ITEM_PUSH_RESULT
    /// </summary>
    public enum HowObtained : byte
    {
        Looted = 0,
        NPCTransaction = 1
    }

    /// <summary>
    /// Used In CMSG_ITEM_PUSH_RESULT
    /// </summary>
    public enum HowReceived : byte
    {
        Transaction = 0,
        Created = 1
    }

    public enum Material
    {
        None = 0,
        None2 = -1,
        Metal = 1,
        Wood = 2,
        Gem = 3,
        Cloth = 7
    }

    public enum PageMaterial
    {
        None2 = -1,
        None = 0,
        Parchment = 1,
        Stone = 2,
        Marble = 3,
        Silver = 4,
        Bronze = 5,
        Valentine = 6
    }

    public enum ItemBagFamily
    {
        None = 0,
        Arrows = 1,
        Bullets = 2,
        SoulShards = 3,
        Leatherworking = 4,
        Unused = 5,
        Herbs = 6,
        Enchanting = 7,
        Engineering = 8,
        Keys = 9,
        Gems = 10,
        Mining = 11,
        SoulboundEquipment = 12,
        VanityPets = 13,
        CurrencyTokens = 14,
        QuestItems = 15
    }

    // TODO
    [Flags]
    public enum ItemBagFamilyMask
    {
        None = 0,
        Arrows = 1,
        Bullets = 2,
        SoulShards = 4,
        Leatherworking = 8,
        Unused = 0x0010,
        Herbs = 0x0020,
        Enchanting = 0x0040,
        Engineering = 0x0080,
        Keys = 0x0100,
        Gems = 0x0200,
        Mining = 0x0400,
        Soulbound = 0x0800,
        VanityPets = 0x1000,
        CurrencyTokens = 0x2000,
        QuestItems = 0x4000,
    }

    public enum TotemCategory : uint
    {
        None = 0,
        SkinningKnifeOLD = 1,
        EarthTotem = 2,
        AirTotem = 3,
        FireTotem = 4,
        WaterTotem = 5,
        RunedCopperRod = 6,
        RunedSilverRod = 7,
        RunedGoldenRod = 8,
        RunedTruesilverRod = 9,
        RunedArcaniteRod = 10,
        MiningPickOLD = 11,
        PhilosophersStone = 12,
        BlacksmithHammerOLD = 13,
        ArclightSpanner = 14,
        GyromaticMicroAdjustor = 15,
        MasterTotem = 21,
        RunedFelIronRod = 41,
        RunedAdamantiteRod = 62,
        RunedEterniumRod = 63,
        HollowQuill = 81,
        RunedAzuriteRod = 101,
        VirtuosoInkingSet = 121,
        Drums = 141,
        GnomishArmyKnife = 161,
        BlacksmithHammer = 162,
        MiningPick = 165,
        SkinningKnife = 166,
        HammerPick = 167,
        BladedPickaxe = 168,
        FlintAndTinder = 169,
        RunedCobaltRodDONOTUSE = 189,
        RunedTitaniumRod = 190,
        End
    }

    public enum SellItemError : byte
    {
        Success = 0x00,
        CantFindItem = 0x01,
        CantSellItem = 0x02,
        CantFindVendor = 0x03,
        PlayerDoesntOwnItem = 0x04,
        Unknown = 0x05,
        OnlyEmptyBag = 0x06
    }

    public enum BuyItemError : byte
    {
        CantFindItem = 0x00,
        ItemAlreadySold = 0x01,
        NotEnoughMoney = 0x02,
        Unknown1 = 0x03,
        SellerDoesntLikeYou = 0x04,
        DistanceTooFar = 0x05,
        Unknown2 = 0x06,
        ItemSoldOut = 0x07,
        CantCarryAnymore = 0x08,
        Unknown3 = 0x09,
        Unknown4 = 0x10,
        RankRequirementNotMet = 0x11,
        ReputationRequirementNotMet = 0x12
    }

    public enum LootType
    {
        Corpse          = 1,
        PickPocket      = 2,
        Fishing         = 3,
        Disenchanting   = 4,
        UNKNOWN_5       = 5,
        Skinning        = 6,
        Prospecting     = 7,
        Milling         = 8,
    }

    public enum LootItemPermission : byte
    {
        CanLoot     = 0,
        ViewOnly    = 1,
        /// <summary>
        /// This item is waiting for Master Looter's decision.
        /// </summary>
        MLOnly      = 2,
        CanLoot2    = 4,
    }

    public enum ItemObtainType
    {
        Looted = 0,
        FromNPC = 1,
    }

    public enum ItemCreateType
    {
        Received = 0,
        Created = 1,
    }

    public enum InventoryReason : byte
    {
        VendorHasNoInventory            = 0,
        IDontThinkHeLikesYouVeryMuch    = 1,
        YouAreTooFarAway                = 2,
        VendorIsDead                    = 3,
        YouCantShopWhileDead            = 4,
    }

    public enum InventoryChangeFailure
    {
        EQUIP_ERR_OK = 0,
        EQUIP_ERR_CANT_EQUIP_LEVEL_I = 1,       // ERR_CANT_EQUIP_LEVEL_I
        EQUIP_ERR_CANT_EQUIP_SKILL = 2,       // ERR_CANT_EQUIP_SKILL
        EQUIP_ERR_ITEM_DOESNT_GO_TO_SLOT = 3,       // ERR_WRONG_SLOT
        EQUIP_ERR_BAG_FULL = 4,       // ERR_BAG_FULL
        EQUIP_ERR_NONEMPTY_BAG_OVER_OTHER_BAG = 5,       // ERR_BAG_IN_BAG
        EQUIP_ERR_CANT_TRADE_EQUIP_BAGS = 6,       // ERR_TRADE_EQUIPPED_BAG
        EQUIP_ERR_ONLY_AMMO_CAN_GO_HERE = 7,       // ERR_AMMO_ONLY
        EQUIP_ERR_NO_REQUIRED_PROFICIENCY = 8,       // ERR_PROFICIENCY_NEEDED
        EQUIP_ERR_NO_EQUIPMENT_SLOT_AVAILABLE = 9,       // ERR_NO_SLOT_AVAILABLE
        EQUIP_ERR_YOU_CAN_NEVER_USE_THAT_ITEM = 10,      // ERR_CANT_EQUIP_EVER
        EQUIP_ERR_YOU_CAN_NEVER_USE_THAT_ITEM2 = 11,      // ERR_CANT_EQUIP_EVER
        EQUIP_ERR_NO_EQUIPMENT_SLOT_AVAILABLE2 = 12,      // ERR_NO_SLOT_AVAILABLE
        EQUIP_ERR_CANT_EQUIP_WITH_TWOHANDED = 13,      // ERR_2HANDED_EQUIPPED
        EQUIP_ERR_CANT_DUAL_WIELD = 14,      // ERR_2HSKILLNOTFOUND
        EQUIP_ERR_ITEM_DOESNT_GO_INTO_BAG = 15,      // ERR_WRONG_BAG_TYPE
        EQUIP_ERR_ITEM_DOESNT_GO_INTO_BAG2 = 16,      // ERR_WRONG_BAG_TYPE
        EQUIP_ERR_CANT_CARRY_MORE_OF_THIS = 17,      // ERR_ITEM_MAX_COUNT
        EQUIP_ERR_NO_EQUIPMENT_SLOT_AVAILABLE3 = 18,      // ERR_NO_SLOT_AVAILABLE
        EQUIP_ERR_ITEM_CANT_STACK = 19,      // ERR_CANT_STACK
        EQUIP_ERR_ITEM_CANT_BE_EQUIPPED = 20,      // ERR_NOT_EQUIPPABLE
        EQUIP_ERR_ITEMS_CANT_BE_SWAPPED = 21,      // ERR_CANT_SWAP
        EQUIP_ERR_SLOT_IS_EMPTY = 22,      // ERR_SLOT_EMPTY
        EQUIP_ERR_ITEM_NOT_FOUND = 23,      // ERR_ITEM_NOT_FOUND
        EQUIP_ERR_CANT_DROP_SOULBOUND = 24,      // ERR_DROP_BOUND_ITEM
        EQUIP_ERR_OUT_OF_RANGE = 25,      // ERR_OUT_OF_RANGE
        EQUIP_ERR_TRIED_TO_SPLIT_MORE_THAN_COUNT = 26,      // ERR_TOO_FEW_TO_SPLIT
        EQUIP_ERR_COULDNT_SPLIT_ITEMS = 27,      // ERR_SPLIT_FAILED
        EQUIP_ERR_MISSING_REAGENT = 28,      // ERR_SPELL_FAILED_REAGENTS_GENERIC
        EQUIP_ERR_NOT_ENOUGH_MONEY = 29,      // ERR_NOT_ENOUGH_MONEY
        EQUIP_ERR_NOT_A_BAG = 30,      // ERR_NOT_A_BAG
        EQUIP_ERR_CAN_ONLY_DO_WITH_EMPTY_BAGS = 31,      // ERR_DESTROY_NONEMPTY_BAG
        EQUIP_ERR_DONT_OWN_THAT_ITEM = 32,      // ERR_NOT_OWNER
        EQUIP_ERR_CAN_EQUIP_ONLY1_QUIVER = 33,      // ERR_ONLY_ONE_QUIVER
        EQUIP_ERR_MUST_PURCHASE_THAT_BAG_SLOT = 34,      // ERR_NO_BANK_SLOT
        EQUIP_ERR_TOO_FAR_AWAY_FROM_BANK = 35,      // ERR_NO_BANK_HERE
        EQUIP_ERR_ITEM_LOCKED = 36,      // ERR_ITEM_LOCKED
        EQUIP_ERR_YOU_ARE_STUNNED = 37,      // ERR_GENERIC_STUNNED
        EQUIP_ERR_YOU_ARE_DEAD = 38,      // ERR_PLAYER_DEAD
        EQUIP_ERR_CANT_DO_RIGHT_NOW = 39,      // ERR_CLIENT_LOCKED_OUT
        EQUIP_ERR_INT_BAG_ERROR = 40,      // ERR_INTERNAL_BAG_ERROR
        EQUIP_ERR_CAN_EQUIP_ONLY1_QUIVER2 = 41,      // ERR_ONLY_ONE_BOLT
        EQUIP_ERR_CAN_EQUIP_ONLY1_AMMOPOUCH = 42,      // ERR_ONLY_ONE_AMMO
        EQUIP_ERR_STACKABLE_CANT_BE_WRAPPED = 43,      // ERR_CANT_WRAP_STACKABLE
        EQUIP_ERR_EQUIPPED_CANT_BE_WRAPPED = 44,      // ERR_CANT_WRAP_EQUIPPED
        EQUIP_ERR_WRAPPED_CANT_BE_WRAPPED = 45,      // ERR_CANT_WRAP_WRAPPED
        EQUIP_ERR_BOUND_CANT_BE_WRAPPED = 46,      // ERR_CANT_WRAP_BOUND
        EQUIP_ERR_UNIQUE_CANT_BE_WRAPPED = 47,      // ERR_CANT_WRAP_UNIQUE
        EQUIP_ERR_BAGS_CANT_BE_WRAPPED = 48,      // ERR_CANT_WRAP_BAGS
        EQUIP_ERR_ALREADY_LOOTED = 49,      // ERR_LOOT_GONE
        EQUIP_ERR_INVENTORY_FULL = 50,      // ERR_INV_FULL
        EQUIP_ERR_BANK_FULL = 51,      // ERR_BAG_FULL
        EQUIP_ERR_ITEM_IS_CURRENTLY_SOLD_OUT = 52,      // ERR_VENDOR_SOLD_OUT
        EQUIP_ERR_BAG_FULL3 = 53,      // ERR_BAG_FULL
        EQUIP_ERR_ITEM_NOT_FOUND2 = 54,      // ERR_ITEM_NOT_FOUND
        EQUIP_ERR_ITEM_CANT_STACK2 = 55,      // ERR_CANT_STACK
        EQUIP_ERR_BAG_FULL4 = 56,      // ERR_BAG_FULL
        EQUIP_ERR_ITEM_SOLD_OUT = 57,      // ERR_VENDOR_SOLD_OUT
        EQUIP_ERR_OBJECT_IS_BUSY = 58,      // ERR_OBJECT_IS_BUSY
        EQUIP_ERR_NONE = 59,      // ERR_CANT_BE_DISENCHANTED
        EQUIP_ERR_NOT_IN_COMBAT = 60,      // ERR_NOT_IN_COMBAT
        EQUIP_ERR_NOT_WHILE_DISARMED = 61,      // ERR_NOT_WHILE_DISARMED
        EQUIP_ERR_BAG_FULL6 = 62,      // ERR_BAG_FULL
        EQUIP_ERR_CANT_EQUIP_RANK = 63,      // ERR_CANT_EQUIP_RANK
        EQUIP_ERR_CANT_EQUIP_REPUTATION = 64,      // ERR_CANT_EQUIP_REPUTATION
        EQUIP_ERR_TOO_MANY_SPECIAL_BAGS = 65,      // ERR_TOO_MANY_SPECIAL_BAGS
        EQUIP_ERR_LOOT_CANT_LOOT_THAT_NOW = 66,      // ERR_LOOT_CANT_LOOT_THAT_NOW
        EQUIP_ERR_ITEM_UNIQUE_EQUIPABLE = 67,      // ERR_ITEM_UNIQUE_EQUIPPABLE
        EQUIP_ERR_VENDOR_MISSING_TURNINS = 68,      // ERR_VENDOR_MISSING_TURNINS
        EQUIP_ERR_NOT_ENOUGH_HONOR_POINTS = 69,      // ERR_NOT_ENOUGH_HONOR_POINTS
        EQUIP_ERR_NOT_ENOUGH_ARENA_POINTS = 70,      // ERR_NOT_ENOUGH_ARENA_POINTS
        EQUIP_ERR_ITEM_MAX_COUNT_SOCKETED = 71,      // ERR_ITEM_MAX_COUNT_SOCKETED
        EQUIP_ERR_MAIL_BOUND_ITEM = 72,      // ERR_MAIL_BOUND_ITEM
        EQUIP_ERR_NO_SPLIT_WHILE_PROSPECTING = 73,      // ERR_INTERNAL_BAG_ERROR
        EQUIP_ERR_BAG_FULL7 = 74,      // ERR_BAG_FULL
        EQUIP_ERR_ITEM_MAX_COUNT_EQUIPPED_SOCKETED = 75,      // ERR_ITEM_MAX_COUNT_EQUIPPED_SOCKETED
        EQUIP_ERR_ITEM_UNIQUE_EQUIPPABLE_SOCKETED = 76,      // ERR_ITEM_UNIQUE_EQUIPPABLE_SOCKETED
        EQUIP_ERR_TOO_MUCH_GOLD = 77,      // ERR_TOO_MUCH_GOLD
        EQUIP_ERR_NOT_DURING_ARENA_MATCH = 78,      // ERR_NOT_DURING_ARENA_MATCH
        EQUIP_ERR_CANNOT_TRADE_THAT = 79,      // ERR_TRADE_BOUND_ITEM
        EQUIP_ERR_PERSONAL_ARENA_RATING_TOO_LOW = 80,      // ERR_CANT_EQUIP_RATING
        EQUIP_ERR_EVENT_AUTOEQUIP_BIND_CONFIRM = 81,      // EQUIP_ERR_OK, EVENT_AUTOEQUIP_BIND_CONFIRM
        EQUIP_ERR_ARTEFACTS_ONLY_FOR_OWN_CHARACTERS = 82,      // ERR_NOT_SAME_ACCOUNT
        EQUIP_ERR_OK2 = 83,      // EQUIP_ERR_OK
        EQUIP_ERR_ITEM_MAX_LIMIT_CATEGORY_COUNT_EXCEEDED_IS = 84,
        EQUIP_ERR_ITEM_MAX_LIMIT_CATEGORY_SOCKETED_EXCEEDED_IS = 85,
        EQUIP_ERR_SCALING_STAT_ITEM_LEVEL_EXCEEDED = 86,
        EQUIP_ERR_PURCHASE_LEVEL_TOO_LOW = 87,
        EQUIP_ERR_CANT_EQUIP_NEED_TALENT = 88,
        EQUIP_ERR_ITEM_MAX_LIMIT_CATEGORY_EQUIPPED_EXCEEDED_IS = 89
    }
}
