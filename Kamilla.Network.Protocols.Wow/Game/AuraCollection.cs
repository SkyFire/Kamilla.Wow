using System;
using System.Collections;
using System.Collections.Generic;

namespace Kamilla.Network.Protocols.Wow.Game
{
    public sealed class AuraCollection : IEnumerable<Aura>, IEnumerable
    {
        private int m_version;
        private ulong m_auraMask;
        private Aura[] m_auras;

        public AuraCollection()
        {
            m_auras = new Aura[Aura.MaxAuras];
        }

        IEnumerator<Aura> IEnumerable<Aura>.GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        public void Add(Aura aura)
        {
            if (aura == null)
                throw new ArgumentNullException("aura", "aura is null.");

            this[aura.Slot] = aura;
        }

        public void Remove(byte slot)
        {
            this[slot] = null;
        }

        public void Clear()
        {
            Array.Clear(m_auras, 0, Aura.MaxAuras);
            m_auraMask = 0UL;
            ++m_version;
        }

        public Aura this[byte slot]
        {
            get
            {
                if (slot >= Aura.MaxAuras)
                    throw new ArgumentOutOfRangeException("slot", "Slot (" + slot + ") must be less than MaxAuras.");

                return m_auras[slot];
            }
            set
            {
                if (slot >= Aura.MaxAuras)
                    throw new ArgumentOutOfRangeException("slot", "Slot (" + slot + ") must be less than MaxAuras.");

                if (value != null && value.Slot != slot)
                    throw new ArgumentException("The provided Aura has for the slot has different slot.", "value");

                if (value.Spell == 0)
                    value = null;

                m_auras[slot] = value;

                ulong bit = 1UL << slot;
                if (value != null)
                    m_auraMask |= bit;
                else
                    m_auraMask &= ~bit;

                ++m_version;
            }
        }

        public sealed class Enumerator : IEnumerator<Aura>, IEnumerator, IDisposable
        {
            private AuraCollection m_collection;
            private int m_version;
            private int m_index;
            private Aura m_current;

            public Aura Current { get { return m_current; } }
            object IEnumerator.Current { get { return m_current; } }

            internal Enumerator(AuraCollection auraCollection)
            {
                m_collection = auraCollection;
                m_version = m_collection.m_version;

                this.Reset();
            }

            public void Reset()
            {
                if (m_version != m_collection.m_version)
                    throw new InvalidOperationException("The collection was modified after the enumerator was created.");

                m_index = -1;
                m_current = null;
            }

            public bool MoveNext()
            {
                if (m_version != m_collection.m_version)
                    throw new InvalidOperationException("The collection was modified after the enumerator was created.");

                ulong mask = m_collection.m_auraMask;
                for (ulong i = 1UL << ++m_index; m_index < Aura.MaxAuras; i <<= 1, ++m_index)
                {
                    if ((mask & i) != 0)
                        break;
                }

                if (m_index == Aura.MaxAuras)
                {
                    this.Reset();
                    return false;
                }
                else
                {
                    m_current = m_collection[(byte)m_index];
                    return true;
                }
            }

            public void Dispose()
            {
                m_collection = null;
                m_current = null;
            }
        }
    }
}
