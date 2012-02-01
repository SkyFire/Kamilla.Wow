using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    public enum DynamicObjectTypes
    {
        /// <summary>
        /// Unused.
        /// </summary>
        Portal          = 0,
        AreaSpell       = 1,
        FarsightFocus   = 2,
        RaidMarker      = 3,
    }

    public sealed class WowDynamicObject : WowObject
    {
        public WowDynamicObject()
            : base(ObjectTypeId.DynamicObject)
        {
        }

        public DynamicObjectTypes DynamicObjectType
        {
            get { return (DynamicObjectTypes)(GetByte(DynamicObjectUpdateFields.DYNAMICOBJECT_BYTES, 3) >> 4); }
            set { SetByte(DynamicObjectUpdateFields.DYNAMICOBJECT_BYTES, (byte)((int)value << 4), 3); }
        }

        public ushort SpellVisual
        {
            get { return GetShort(DynamicObjectUpdateFields.DYNAMICOBJECT_BYTES, 0); }
            set { SetShort(DynamicObjectUpdateFields.DYNAMICOBJECT_BYTES, value, 0); }
        }

        public uint Spell
        {
            get { return GetUInt(DynamicObjectUpdateFields.DYNAMICOBJECT_SPELLID); }
            set
            {
                SetUInt(DynamicObjectUpdateFields.DYNAMICOBJECT_SPELLID, value);
                Entry = value;
            }
        }

        public WowGuid CasterGuid
        {
            get { return new WowGuid(GetULong(DynamicObjectUpdateFields.DYNAMICOBJECT_CASTER)); }
            set { SetULong(DynamicObjectUpdateFields.DYNAMICOBJECT_CASTER, value.Raw); }
        }

        /// <summary>
        /// Milliseconds.
        /// </summary>
        public uint CastTime
        {
            get { return GetUInt(DynamicObjectUpdateFields.DYNAMICOBJECT_CASTTIME); }
            set { SetUInt(DynamicObjectUpdateFields.DYNAMICOBJECT_CASTTIME, value); }
        }

        public float Radius
        {
            get { return GetFloat(DynamicObjectUpdateFields.DYNAMICOBJECT_RADIUS); }
            set { SetFloat(DynamicObjectUpdateFields.DYNAMICOBJECT_RADIUS, value); }
        }

        #region DynamicObject Update Fields Getters & Setters
        public bool ValueExists(DynamicObjectUpdateFields index) { return ValueExists((uint)index); }

        public ulong GetULong(DynamicObjectUpdateFields index) { return GetULong((uint)index); }
        public long GetLong(DynamicObjectUpdateFields index) { return GetLong((uint)index); }
        public float GetFloat(DynamicObjectUpdateFields index) { return GetFloat((uint)index); }
        public uint GetUInt(DynamicObjectUpdateFields index) { return GetUInt((uint)index); }
        public int GetInt(DynamicObjectUpdateFields index) { return GetInt((uint)index); }
        public ushort GetShort(DynamicObjectUpdateFields index, byte offset) { return GetShort((uint)index, offset); }
        public byte GetByte(DynamicObjectUpdateFields index, byte offset) { return GetByte((uint)index, offset); }

        public void SetULong(DynamicObjectUpdateFields index, ulong value) { SetULong((uint)index, value); }
        public void SetLong(DynamicObjectUpdateFields index, long value) { SetLong((uint)index, value); }
        public void SetFloat(DynamicObjectUpdateFields index, float value) { SetFloat((uint)index, value); }
        public void SetUInt(DynamicObjectUpdateFields index, uint value) { SetUInt((uint)index, value); }
        public void SetInt(DynamicObjectUpdateFields index, int value) { SetInt((uint)index, value); }
        public void SetShort(DynamicObjectUpdateFields index, ushort value, byte offset) { SetShort((uint)index, value, offset); }
        public void SetByte(DynamicObjectUpdateFields index, byte value, byte offset) { SetByte((uint)index, value, offset); }
        #endregion
    }
}
