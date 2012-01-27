using System;
using System.Collections;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public enum ObjectTypeId : byte
    {
        Object           = 0,
        Item             = 1,
        Container        = 2,
        Unit             = 3,
        Player           = 4,
        GameObject       = 5,
        DynamicObject    = 6,
        Corpse           = 7,
        AreaTrigger      = 8,
    }

    [Flags]
    public enum ObjectTypeMask
    {
        None           = 0x0000,
        Object         = 0x0001,
        Item           = 0x0002,
        Container      = 0x0004,
        Unit           = 0x0008,
        Player         = 0x0010,
        GameObject     = 0x0020,
        DynamicObject  = 0x0040,
        Corpse         = 0x0080,
        AreaTrigger    = 0x0100,
    }

    public enum UpdateTypes
    {
        UpdateValues   = 0,
        CreateObjects  = 1,
        CreateObjects2 = 2,
        DestroyObjects = 3,
    }

    public abstract class WowObject
    {
        UpdateFields m_updateFields = new UpdateFields();
        BitArray m_updateMask;

        /// <summary>
        /// Gets or sets the movement data of the current object.
        /// </summary>
        public MovementInfo MovementData { get; set; }

        public double GetDistance2D(WowObject other)
        {
            if (other is WowItem || this is WowItem)
                throw new InvalidOperationException("Cannot calculate distance between WowItems.");

            var pos1 = this.MovementData.Position;
            var pos2 = other.MovementData.Position;

            var d_x = (double)(pos1.X - pos2.X);
            var d_y = (double)(pos1.Y - pos2.Y);

            return Math.Sqrt(d_x * d_x + d_y * d_y);
        }

        public double GetDistance3D(WowObject other)
        {
            if (other is WowItem || this is WowItem)
                throw new InvalidOperationException("Cannot calculate distance between WowItems.");

            var pos1 = this.MovementData.Position;
            var pos2 = other.MovementData.Position;

            var d_x = (double)(pos1.X - pos2.X);
            var d_y = (double)(pos1.Y - pos2.Y);
            var d_z = (double)(pos1.Z - pos2.Z);

            return Math.Sqrt(d_x * d_x + d_y * d_y + d_z * d_z);
        }

        protected WowObject(ObjectTypeId typeid)
        {
            m_updateMask = new BitArray((int)UpdateFields.GetCount(typeid, uint.MaxValue));

            this.TypeId = typeid;
            this.TypeMask = (ObjectTypeMask)(1 << (int)typeid) | ObjectTypeMask.Object;
        }

        /// <summary>
        /// Gets or sets the guid of the current object.
        /// </summary>
        public WowGuid Guid
        {
            get { return new WowGuid(GetULong(ObjectUpdateFields.OBJECT_FIELD_GUID)); }
            set { SetULong(ObjectUpdateFields.OBJECT_FIELD_GUID, value.Raw); }
        }

        /// <summary>
        /// Gets or sets the entry of the current object.
        /// </summary>
        public uint Entry
        {
            get { return GetUInt(ObjectUpdateFields.OBJECT_FIELD_ENTRY); }
            set { SetUInt(ObjectUpdateFields.OBJECT_FIELD_ENTRY, value); }
        }

        /// <summary>
        /// Gets or sets the type mask of the current object.
        /// </summary>
        public ObjectTypeMask TypeMask
        {
            get { return (ObjectTypeMask)GetShort(ObjectUpdateFields.OBJECT_FIELD_TYPE, 0); }
            set { SetShort(ObjectUpdateFields.OBJECT_FIELD_TYPE, (ushort)value, 0); }
        }

        /// <summary>
        /// Gets or sets the type flags of the current object.
        /// </summary>
        public ushort TypeFlags
        {
            get { return GetShort(ObjectUpdateFields.OBJECT_FIELD_TYPE, 1); }
            set { SetShort(ObjectUpdateFields.OBJECT_FIELD_TYPE, value, 1); }
        }

        /// <summary>
        /// Gets or sets the OBJECT_FIELD_DATA of the current object.
        /// </summary>
        public ulong ObjectData
        {
            get { return GetULong(ObjectUpdateFields.OBJECT_FIELD_DATA); }
            set { SetULong(ObjectUpdateFields.OBJECT_FIELD_DATA, value); }
        }

        /// <summary>
        /// Gets the type id of the current object.
        /// </summary>
        public ObjectTypeId TypeId { get; private set; }

        /// <summary>
        /// Gets or sets the scale of the current object.
        /// </summary>
        public float Scale
        {
            get { return GetFloat(ObjectUpdateFields.OBJECT_FIELD_SCALE_X); }
            set { SetFloat(ObjectUpdateFields.OBJECT_FIELD_SCALE_X, value); }
        }

        #region Raw Update Fields Getters & Setters
        public void SetValues(UpdateFields values)
        {
            this.m_updateFields = values;
        }

        public void ApplyValues(UpdateFields values)
        {
            foreach (var pair in values)
                this.m_updateFields[pair.Key] = pair.Value;
        }

        public UpdateFields GetValues()
        {
            return this.m_updateFields;
        }

        public UpdateFields CreateUpdate()
        {
            var ret = new UpdateFields();

            for (int i = 0; i < m_updateMask.Length; ++i)
            {
                if (m_updateMask[i])
                    ret.Add((uint)i, GetUInt((uint)i));
            }

            ResetUpdatedFields();

            return ret;
        }

        internal void ResetUpdatedFields()
        {
            m_updateMask.SetAll(false);
        }

        protected bool ValueExists(uint index) { return m_updateFields.ContainsKey(index); }

        protected ulong GetULong(uint index)
        {
            ulong low = GetUInt(index);
            ulong high = GetUInt(index + 1);
            return (high << 32) | low;
        }
        protected unsafe long GetLong(uint index)
        {
            ulong value = GetULong(index);
            return *(long*)&value;
        }
        protected unsafe float GetFloat(uint index)
        {
            uint value = GetUInt(index);
            return *(float*)&value;
        }
        protected uint GetUInt(uint index)
        {
            uint ret;
            m_updateFields.TryGetValue(index, out ret);
            return ret;
        }
        protected unsafe int GetInt(uint index)
        {
            uint value = GetUInt(index);
            return *(int*)&value;
        }
        protected ushort GetShort(uint index, byte offset)
        {
            return (ushort)((GetUInt(index) >> (offset * 16)) & ushort.MaxValue);
        }
        protected byte GetByte(uint index, byte offset)
        {
            return (byte)((GetUInt(index) >> (offset * 8)) & byte.MaxValue);
        }

        protected void SetULong(uint index, ulong value)
        {
            SetUInt(index, (uint)(value & uint.MaxValue));
            SetUInt(index + 1, (uint)((value >> 32) & uint.MaxValue));
        }
        protected unsafe void SetLong(uint index, long value)
        {
            SetULong(index, *(ulong*)&value);
        }
        protected unsafe void SetFloat(uint index, float value)
        {
            SetUInt(index, *(uint*)&value);
        }
        protected void SetUInt(uint index, uint value)
        {
            m_updateFields[index] = value;
            m_updateMask[(int)index] = true;
        }
        protected unsafe void SetInt(uint index, int value)
        {
            SetUInt(index, *(uint*)&value);
        }
        protected void SetShort(uint index, ushort value, byte offset)
        {
            uint oldValue = GetUInt(index);
            oldValue &= ~(uint)((uint)ushort.MaxValue << (offset * 16));
            oldValue |= (uint)((uint)value << (offset * 16));
            SetUInt(index, oldValue);
        }
        protected void SetByte(uint index, byte value, byte offset)
        {
            uint oldValue = GetUInt(index);
            oldValue &= ~(uint)((uint)byte.MaxValue << (offset * 8));
            oldValue |= (uint)((uint)value << (offset * 8));
            SetUInt(index, oldValue);
        }
        #endregion

        #region Object Update Fields Getters & Setters
        public bool ValueExists(ObjectUpdateFields index) { return ValueExists((uint)index); }

        public ulong GetULong(ObjectUpdateFields index) { return GetULong((uint)index); }
        public long GetLong(ObjectUpdateFields index) { return GetLong((uint)index); }
        public float GetFloat(ObjectUpdateFields index) { return GetFloat((uint)index); }
        public uint GetUInt(ObjectUpdateFields index) { return GetUInt((uint)index); }
        public int GetInt(ObjectUpdateFields index) { return GetInt((uint)index); }
        public ushort GetShort(ObjectUpdateFields index, byte offset) { return GetShort((uint)index, offset); }
        public byte GetByte(ObjectUpdateFields index, byte offset) { return GetByte((uint)index, offset); }

        public void SetULong(ObjectUpdateFields index, ulong value) { SetULong((uint)index, value); }
        public void SetLong(ObjectUpdateFields index, long value) { SetLong((uint)index, value); }
        public void SetFloat(ObjectUpdateFields index, float value) { SetFloat((uint)index, value); }
        public void SetUInt(ObjectUpdateFields index, uint value) { SetUInt((uint)index, value); }
        public void SetInt(ObjectUpdateFields index, int value) { SetInt((uint)index, value); }
        public void SetShort(ObjectUpdateFields index, ushort value, byte offset) { SetShort((uint)index, value, offset); }
        public void SetByte(ObjectUpdateFields index, byte value, byte offset) { SetByte((uint)index, value, offset); }
        #endregion

        // ugly hack
        public static ObjectTypeId GetTypeId(WowGuidType type)
        {
            switch (type)
            {
                case WowGuidType.Corpse:
                    return ObjectTypeId.Corpse;
                case WowGuidType.DynamicObject:
                    return ObjectTypeId.DynamicObject;
                case WowGuidType.TransportMo:
                case WowGuidType.Transport:
                case WowGuidType.GameObject:
                    return ObjectTypeId.GameObject;
                case WowGuidType.Item:
                    return ObjectTypeId.Item;
                case WowGuidType.Player:
                    return ObjectTypeId.Player;
                case WowGuidType.Pet:
                case WowGuidType.Creature:
                case WowGuidType.Vehicle:
                    return ObjectTypeId.Unit;
                default:
                    return ObjectTypeId.Object;
            }
        }
    }
}
