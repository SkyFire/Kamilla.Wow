using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    public sealed class WowAreaTrigger : WowObject
    {
        public WowAreaTrigger()
            : base(ObjectTypeId.AreaTrigger)
        {
        }

        public uint SpellId
        {
            get { return GetUInt(AreaTriggerUpdateFields.AREATRIGGER_SPELLID); }
            set { SetUInt(AreaTriggerUpdateFields.AREATRIGGER_SPELLID, value); }
        }

        public uint SpellVisualId
        {
            get { return GetUInt(AreaTriggerUpdateFields.AREATRIGGER_SPELLVISUALID); }
            set { SetUInt(AreaTriggerUpdateFields.AREATRIGGER_SPELLVISUALID, value); }
        }

        public Vector3 FinalPosition
        {
            get
            {
                return new Vector3()
                {
                    X = GetFloat(AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS),
                    Y = GetFloat(AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS_2),
                    Z = GetFloat(AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS_3),
                };
            }
            set
            {
                SetFloat(AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS, value.X);
                SetFloat(AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS_2, value.Y);
                SetFloat(AreaTriggerUpdateFields.AREATRIGGER_FINAL_POS_3, value.Z);
            }
        }

        #region AreaTrigger Update Fields Getters & Setters
        public bool ValueExists(AreaTriggerUpdateFields index) { return ValueExists((uint)index); }

        public ulong GetULong(AreaTriggerUpdateFields index) { return GetULong((uint)index); }
        public long GetLong(AreaTriggerUpdateFields index) { return GetLong((uint)index); }
        public float GetFloat(AreaTriggerUpdateFields index) { return GetFloat((uint)index); }
        public uint GetUInt(AreaTriggerUpdateFields index) { return GetUInt((uint)index); }
        public int GetInt(AreaTriggerUpdateFields index) { return GetInt((uint)index); }
        public ushort GetShort(AreaTriggerUpdateFields index, byte offset) { return GetShort((uint)index, offset); }
        public byte GetByte(AreaTriggerUpdateFields index, byte offset) { return GetByte((uint)index, offset); }

        public void SetULong(AreaTriggerUpdateFields index, ulong value) { SetULong((uint)index, value); }
        public void SetLong(AreaTriggerUpdateFields index, long value) { SetLong((uint)index, value); }
        public void SetFloat(AreaTriggerUpdateFields index, float value) { SetFloat((uint)index, value); }
        public void SetUInt(AreaTriggerUpdateFields index, uint value) { SetUInt((uint)index, value); }
        public void SetInt(AreaTriggerUpdateFields index, int value) { SetInt((uint)index, value); }
        public void SetShort(AreaTriggerUpdateFields index, ushort value, byte offset) { SetShort((uint)index, value, offset); }
        public void SetByte(AreaTriggerUpdateFields index, byte value, byte offset) { SetByte((uint)index, value, offset); }
        #endregion
    }
}
