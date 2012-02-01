using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    [Flags]
    public enum TrackedResourcesMask
    {
        None = 0,
        Herbs = 1 << (2 - 1),
        Minerals = 1 << (3 - 1),
        Quest = 1 << (5 - 1),
        Fish = 1 << (19 - 1),
        Archaeology = 1 << (22 - 1),
        All = Herbs | Minerals | Fish | Archaeology | Quest
    }

    public sealed class WowPlayer : WowUnit
    {
        public WowPlayer()
            : base(ObjectTypeId.Player)
        {
        }

        public byte Skin
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES, 0); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES, value, 0); }
        }

        public byte Face
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES, 1); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES, value, 1); }
        }

        public byte HairStyle
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES, 2); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES, value, 2); }
        }

        public byte HairColor
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES, 3); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES, value, 3); }
        }

        public byte FaceFeatures
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES_2, 0); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES_2, value, 0); }
        }

        //public byte UnkBytes1
        //{
        //    get { return GetByte(PlayerUpdateFields.PLAYER_BYTES_2, 1); }
        //    set { SetByte(PlayerUpdateFields.PLAYER_BYTES_2, value, 1); }
        //}

        public byte BankBagSlotCount
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES_2, 2); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES_2, value, 2); }
        }

        public byte RestState
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES_2, 3); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES_2, value, 3); }
        }

        public bool IsInGuild
        {
            get { return (this.TypeFlags & 1) != 0; }
            set
            {
                if (value)
                    this.TypeFlags |= 1;
                else
                    this.TypeFlags &= unchecked((ushort)~1);
            }
        }

        public WowGuid Guild
        {
            get
            {
                if (this.IsInGuild)
                    return new WowGuid(ObjectData);
                else
                    return WowGuid.Empty;
            }
            set
            {
                this.IsInGuild = value.IsEmpty;
                this.ObjectData = value.Raw;
            }
        }

        //public override Genders Gender
        //{
        //    get
        //    {
        //        Genders gender = (Genders)GetByte(PlayerUpdateFields.PLAYER_BYTES_3, 0);

        //        if (gender != base.Gender)
        //            throw new Exception(string.Format("Genders are faulty! unit={0}, player={1}", base.Gender, gender));

        //        return gender;
        //    }
        //    set
        //    {
        //        SetByte(PlayerUpdateFields.PLAYER_BYTES_3, (byte)value, 0);
        //        base.Gender = value;
        //    }
        //}

        public byte DrunkState
        {
            get { return GetByte(PlayerUpdateFields.PLAYER_BYTES_3, 3); }
            set { SetByte(PlayerUpdateFields.PLAYER_BYTES_3, value, 3); }
        }

        public CreatureTypeMask TrackedCreatures
        {
            get { return (CreatureTypeMask)GetUInt(PlayerUpdateFields.PLAYER_TRACK_CREATURES); }
            set { SetUInt(PlayerUpdateFields.PLAYER_TRACK_CREATURES, (uint)value); }
        }

        public TrackedResourcesMask TrackedResources
        {
            get { return (TrackedResourcesMask)GetUInt(PlayerUpdateFields.PLAYER_TRACK_RESOURCES); }
            set { SetUInt(PlayerUpdateFields.PLAYER_TRACK_RESOURCES, (uint)value); }
        }

        #region Visible Items
        public const uint MaxVisibleItems = 19;
        public const PlayerUpdateFields FirstVisibleItem = PlayerUpdateFields.PLAYER_VISIBLE_ITEM_1_ENTRYID;

        public uint GetVisibleItemEntry(uint index)
        {
            if (index >= MaxVisibleItems)
                throw new ArgumentOutOfRangeException("index");

            return GetUInt(FirstVisibleItem + index * 2);
        }
        public uint GetVisibleItemEntry(InventorySlot index)
        {
            return GetVisibleItemEntry((uint)index);
        }
        public uint GetVisibleItemEnchantment(uint index)
        {
            if (index >= MaxVisibleItems)
                throw new ArgumentOutOfRangeException("index");

            return GetUInt(FirstVisibleItem + index * 2 + 1);
        }
        public void SetVisibleItemEntry(uint index, uint entry)
        {
            if (index >= MaxVisibleItems)
                throw new ArgumentOutOfRangeException("index");

            SetUInt(FirstVisibleItem + index * 2, entry);
        }
        public void SetVisibleItemEnchantment(uint index, uint enchantment)
        {
            if (index >= MaxVisibleItems)
                throw new ArgumentOutOfRangeException("index");

            SetUInt(FirstVisibleItem + index * 2 + 1, enchantment);
        }
        #endregion

        #region Player Update Fields Getters & Setters
        public bool ValueExists(PlayerUpdateFields index) { return ValueExists((uint)index); }

        public ulong GetULong(PlayerUpdateFields index) { return GetULong((uint)index); }
        public long GetLong(PlayerUpdateFields index) { return GetLong((uint)index); }
        public float GetFloat(PlayerUpdateFields index) { return GetFloat((uint)index); }
        public uint GetUInt(PlayerUpdateFields index) { return GetUInt((uint)index); }
        public int GetInt(PlayerUpdateFields index) { return GetInt((uint)index); }
        public ushort GetShort(PlayerUpdateFields index, byte offset) { return GetShort((uint)index, offset); }
        public byte GetByte(PlayerUpdateFields index, byte offset) { return GetByte((uint)index, offset); }

        public void SetULong(PlayerUpdateFields index, ulong value) { SetULong((uint)index, value); }
        public void SetLong(PlayerUpdateFields index, long value) { SetLong((uint)index, value); }
        public void SetFloat(PlayerUpdateFields index, float value) { SetFloat((uint)index, value); }
        public void SetUInt(PlayerUpdateFields index, uint value) { SetUInt((uint)index, value); }
        public void SetInt(PlayerUpdateFields index, int value) { SetInt((uint)index, value); }
        public void SetShort(PlayerUpdateFields index, ushort value, byte offset) { SetShort((uint)index, value, offset); }
        public void SetByte(PlayerUpdateFields index, byte value, byte offset) { SetByte((uint)index, value, offset); }
        #endregion
    }
}
