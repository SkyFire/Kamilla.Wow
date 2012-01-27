using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum TameFailReason
    {
        Ok                      = 0,
        InvalidCreature         = 1,
        TooManyPets             = 2,
        CreatureAlreadyOwned    = 3,
        NotTamable              = 4,
        SummonActive            = 5,
        UnitCantTame            = 6,
        NotAvailable            = 7,
        Internal                = 8,
        TooHighLevel            = 9,
        TargetDead              = 10,
        TargetNotDead           = 11,
        CantControlExotic       = 12,
        Unknown                 = 13,
    }

    public enum PetTalentType
    {
        None        = -1,
        Ferocity    = 0,
        Tenacity    = 1,
        Cunning     = 2,
    }

    public enum PetNameInvalidReason : uint
    {
        Ok                              = 0,
        Invalid                         = 1,
        NoName                          = 2,
        TooShort                        = 3,
        TooLong                         = 4,
        // There is no number 5
        MixedLanguages                  = 6,
        Profane                         = 7,
        Reserved                        = 8,
        // There is no number 9
        // There is no number 10
        /// <summary>
        /// For example "errrbear"
        /// </summary>
        ThreeConsecutive                = 11,
        InvalidSpace                    = 12,
        ConsecutiveSpaces               = 13,
        RussianConsecutiveSilentChars   = 14,
        RussianSilentCharAtBeginOrEnd   = 15,
        DeclensionDoesntMatchBaseName   = 16,
    }

    public enum PetMood
    {
        Unhappy,
        Content,
        Happy,
    }

    public enum PetLoyaltyLevel : uint
    {
        Rebelious   = 1,
        Unruly      = 2,
        Submissive  = 3,
        Dependable  = 4,
        Faithful    = 5,
        BestFriend  = 6,
    }

    public enum StableResult : byte
    {
        NotEnoughMoney  = 0x01,
        Fail            = 0x06,
        StableSuccess   = 0x08,
        DeStableSuccess = 0x09,
        BuySlotSuccess  = 0x0A,
    }

    public enum PetActionFeedback : byte
    {
        None,
        PetDead,
        NothingToAttack,
        CantAttackTarget,
    }

    public enum PetAction : ushort
    {
        Stay        = 0,
        Follow      = 1,
        Attack      = 2,
        Abandon     = 3,
    }

    [Flags]
    public enum PetActionType : byte
    {
        CastSpell           = 1,
        CastSpell2          = 8,
        CastSpell3          = 9,
        CastSpell4          = 10,
        CastSpell5          = 11,
        CastSpell6          = 12,
        CastSpell7          = 13,
        CastSpell8          = 14,
        CastSpell9          = 15,
        CastSpell10         = 16,
        CastSpell11         = 17,

        /// <summary>
        ///  (actionId is PetAttackMode)
        /// </summary>
        SetMode             = 0x06,
        /// <summary>
        /// (actionId is PetAction)
        /// </summary>
        SetAction           = 0x07,

        IsAutoCastEnabled   = 0x40,
        IsAutoCastAllowed   = 0x80,
    }

    public enum PetAttackMode : byte
    {
        Passive     = 0,
        Defensive   = 1,
        Aggressive  = 2,
    }

    [Flags]
    public enum PetSpellState : ushort
    {
        None,
        Default = 0x0100,
        Unk2    = 0xC100,
    }

    [Flags]
    public enum PetFlags : ushort
    {
        None    = 0x0,
        Stabled = 0x1,
    }

    /// <summary>
    /// Used in UNIT_FIELD_BYTES_2, 3rd byte 
    /// </summary>
    [Flags]
    public enum PetState
    {
        CanBeRenamed    = 0x1,
        CanBeAbandoned  = 0x2,
    }

    public enum PetFoodType
    {
        None        = 0,
        Meat        = 1,
        Fish        = 2,
        Cheese      = 3,
        Bread       = 4,
        Fungus      = 5,
        Fruit       = 6,
        RawMeat     = 7,
        RawFish     = 8,
    }

    [Flags]
    public enum PetFoodMask : uint
    {
        Meat        = 0x0001,
        Fish        = 0x0002,
        Cheese      = 0x0004,
        Bread       = 0x0008,
        Fungus      = 0x0010,
        Fruit       = 0x0020,
        RawMeat     = 0x0040,
        RawFish     = 0x0080,
    }

    public enum PetType
    {
        Minion,
        Guardian,
        Pet,
        None,
    }
}