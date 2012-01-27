using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum GameObjectTypes
    {
        Door                    = 0,
        Button                  = 1,
        QuestGiver              = 2,
        Chest                   = 3,
        Binder                  = 4,
        Generic                 = 5,
        Trap                    = 6,
        Chair                   = 7,
        SpellFocus              = 8,
        Text                    = 9,
        Goober                  = 10,
        Transport               = 11,
        AreaDamage              = 12,
        Camera                  = 13,
        MapObject               = 14,
        MOTransport             = 15,
        DuelArbiter             = 16,
        FishingNode             = 17,
        SummoningRitual         = 18,
        Mailbox                 = 19,
        DoNotUse                = 20,
        GuardPost               = 21,
        SpellCaster             = 22,
        MeetingStone            = 23,
        FlagStand               = 24,
        FishingHole             = 25,
        FlagDrop                = 26,
        MiniGame                = 27,
        DoNotUse2               = 28,
        CapturePoint            = 29,
        AuraGenerator           = 30,
        DungeonDifficulty       = 31,
        BarberChair             = 32,
        DestructibleBuilding    = 33,
        GuildBank               = 34,
        Trapdoor                = 35,
    }

    public enum GameObjectState
    {
        Active      = 0,
        Ready       = 1,
        ActiveAlt   = 2,
    }

    [Flags]
    public enum GameObjectDynamicFlagsLo : ushort
    {
        /// <summary>
        /// Enables interaction with the GameObject.
        /// </summary>
        Activate = 0x01,

        /// <summary>
        /// Possibly makes the animation of the GameObject more distinct.
        /// </summary>
        Animate = 0x02,

        /// <summary>
        /// Possibly disables interaction with the GameObject
        /// </summary>
        CannotInteract = 0x04,

        /// <summary>
        /// Make the GameObject sparkle, like it is a quest target.
        /// </summary>
        Sparkle = 0x08,
    }

    [Flags]
    public enum GameObjectDynamicFlagsHi : ushort
    {
        None = 0,
        All = ushort.MaxValue
    }

    public sealed class WowGameObject : WowObject
    {
        public WowGameObject()
            : base(ObjectTypeId.GameObject)
        {
        }

        public GameObjectState State
        {
            get { return (GameObjectState)GetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, 0); }
            set { SetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, (byte)value, 0); }
        }

        public GameObjectTypes GameObjectType
        {
            get { return (GameObjectTypes)GetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, 1); }
            set { SetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, (byte)value, 1); }
        }

        public byte ArtKit
        {
            get { return GetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, 2); }
            set { SetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, value, 2); }
        }

        public byte AnimationProgress
        {
            get { return GetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, 3); }
            set { SetByte(GameObjectUpdateFields.GAMEOBJECT_BYTES_1, value, 3); }
        }

        public WowGuid CreatorGuid
        {
            get { return new WowGuid(GetULong(GameObjectUpdateFields.OBJECT_FIELD_CREATED_BY)); }
            set { SetULong(GameObjectUpdateFields.OBJECT_FIELD_CREATED_BY, value.Raw); }
        }

        public GameObjectDynamicFlagsLo DynamicFlagsLo
        {
            get { return (GameObjectDynamicFlagsLo)GetShort(GameObjectUpdateFields.GAMEOBJECT_DYNAMIC, 0); }
            set { SetShort(GameObjectUpdateFields.GAMEOBJECT_DYNAMIC, (ushort)value, 0); }
        }

        public GameObjectDynamicFlagsHi DynamicFlagsHi
        {
            get { return (GameObjectDynamicFlagsHi)GetShort(GameObjectUpdateFields.GAMEOBJECT_DYNAMIC, 1); }
            set { SetShort(GameObjectUpdateFields.GAMEOBJECT_DYNAMIC, (ushort)value, 1); }
        }

        public uint Flags
        {
            get { return GetUInt(GameObjectUpdateFields.GAMEOBJECT_FLAGS); }
            set { SetUInt(GameObjectUpdateFields.GAMEOBJECT_FLAGS, value); }
        }

        public uint Faction
        {
            get { return GetUInt(GameObjectUpdateFields.GAMEOBJECT_FACTION); }
            set { SetUInt(GameObjectUpdateFields.GAMEOBJECT_FACTION, value); }
        }

        /// <summary>
        /// Gets or sets the level of the current game object.
        /// 
        /// For <see href="Kamilla.Network.Protocols.Wow.Latest.GameObjectTypes.MOTransport"/>
        /// this value represents relocation period in milliseconds.
        /// </summary>
        public uint Level
        {
            get { return GetUInt(GameObjectUpdateFields.GAMEOBJECT_LEVEL); }
            set { SetUInt(GameObjectUpdateFields.GAMEOBJECT_LEVEL, value); }
        }

        #region GameObject Update Fields Getters & Setters
        public bool ValueExists(GameObjectUpdateFields index) { return ValueExists((uint)index); }

        public ulong GetULong(GameObjectUpdateFields index) { return GetULong((uint)index); }
        public long GetLong(GameObjectUpdateFields index) { return GetLong((uint)index); }
        public float GetFloat(GameObjectUpdateFields index) { return GetFloat((uint)index); }
        public uint GetUInt(GameObjectUpdateFields index) { return GetUInt((uint)index); }
        public int GetInt(GameObjectUpdateFields index) { return GetInt((uint)index); }
        public ushort GetShort(GameObjectUpdateFields index, byte offset) { return GetShort((uint)index, offset); }
        public byte GetByte(GameObjectUpdateFields index, byte offset) { return GetByte((uint)index, offset); }

        public void SetULong(GameObjectUpdateFields index, ulong value) { SetULong((uint)index, value); }
        public void SetLong(GameObjectUpdateFields index, long value) { SetLong((uint)index, value); }
        public void SetFloat(GameObjectUpdateFields index, float value) { SetFloat((uint)index, value); }
        public void SetUInt(GameObjectUpdateFields index, uint value) { SetUInt((uint)index, value); }
        public void SetInt(GameObjectUpdateFields index, int value) { SetInt((uint)index, value); }
        public void SetShort(GameObjectUpdateFields index, ushort value, byte offset) { SetShort((uint)index, value, offset); }
        public void SetByte(GameObjectUpdateFields index, byte value, byte offset) { SetByte((uint)index, value, offset); }
        #endregion
    }
}
