using System;
using System.Text;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    /// <summary>
    /// Represents a single aura application.
    /// </summary>
    public sealed class Aura
    {
        /// <summary>
        /// Represents the maximum number of auras per unit.  This field is constant.
        /// </summary>
        public const int MaxAuras = 64;

        /// <summary>
        /// Represents the number of aura effects.  This field is constant.
        /// </summary>
        public const int MaxEffects = 3;

        /// <summary>
        /// Gets or sets the guid of the underlying unit.
        /// </summary>
        public WowGuid Unit { get; set; }

        /// <summary>
        /// Gets or sets the guid of the caster unit.
        /// </summary>
        public WowGuid Caster { get; set; }

        /// <summary>
        /// Gets or sets the slot of the current aura.
        /// </summary>
        public byte Slot { get; set; }

        /// <summary>
        /// Gets or sets the spell id of the current aura.
        /// </summary>
        public uint Spell { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Kamilla.Network.Protocols.Wow.Latest.AuraFlags"/>
        /// of the current aura.
        /// </summary>
        public AuraFlags Flags { get; set; }

        /// <summary>
        /// Gets or sets the level of the current aura.
        /// </summary>
        public byte Level { get; set; }

        /// <summary>
        /// Gets or sets the number of charges of the current aura.
        /// </summary>
        public byte Charges { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration of the current aura in milliseconds.
        /// </summary>
        public uint MaxDuration { get; set; }

        /// <summary>
        /// Gets or sets the local tick count of when the aura was applied.
        /// </summary>
        public uint AppliedTime { get; set; }

        /// <summary>
        /// Gets the number of milliseconds left until the current aura's expiration.
        /// </summary>
        public uint LeftDuration
        {
            get
            {
                uint appliedAgoMs = (uint)Environment.TickCount - AppliedTime;

                if (appliedAgoMs > MaxDuration)
                    return 0;
                else
                    return MaxDuration - appliedAgoMs;
            }
        }

        /// <summary>
        /// Gets the <see cref="System.Array"/> of base points of the current aura's effects.
        /// </summary>
        public int[] BasePoints { get; private set; }

        /// <summary>
        /// Initializes a new instance of Aura class.
        /// </summary>
        public Aura()
        {
            this.BasePoints = new int[MaxEffects];
        }

        public void Read(StreamHandler Reader)
        {
            Slot = Reader.ReadByte();
            Spell = Reader.ReadUInt32();

            Caster = Unit;

            if (Spell != 0)
            {
                Flags = (AuraFlags)Reader.ReadUInt16();
                Level = Reader.ReadByte();
                Charges = Reader.ReadByte();

                if ((Flags & AuraFlags.NotCaster) == 0)
                    Caster = Reader.ReadPackedGuid();

                if ((Flags & AuraFlags.Duration) != 0)
                {
                    MaxDuration = Reader.ReadUInt32();
                    var currentDurationMs = Reader.ReadUInt32();

                    this.AppliedTime = (uint)Environment.TickCount - currentDurationMs;
                }

                if ((Flags & AuraFlags.BasePoints) != 0)
                {
                    for (int i = 0; i < MaxEffects; ++i)
                    {
                        if ((Flags & (AuraFlags)(1 << i)) != 0)
                            BasePoints[i] = Reader.ReadInt32();
                        else
                            BasePoints[i] = 0;
                    }
                }
                else
                    Array.Clear(BasePoints, 0, MaxEffects);
            }
        }

        public void Save(StreamHandler writer)
        {
            writer
                .WriteByte(this.Slot)
                .WriteUInt32(this.Spell);

            if (this.Spell != 0)
            {
                writer
                    .WriteUInt16((ushort)this.Flags)
                    .WriteByte(this.Level)
                    .WriteByte(this.Charges);

                if ((Flags & AuraFlags.NotCaster) == 0)
                    writer.WritePackedGuid(this.Caster);

                if ((Flags & AuraFlags.Duration) != 0)
                {
                    writer.WriteUInt32(this.MaxDuration);
                    writer.WriteUInt32(this.LeftDuration);
                }

                if ((Flags & AuraFlags.BasePoints) != 0)
                {
                    for (int i = 0; i < MaxEffects; ++i)
                    {
                        if ((Flags & (AuraFlags)(1 << i)) != 0)
                            writer.WriteInt32(BasePoints[i]);
                    }
                }
            }
        }

        public void ToString(StringBuilder Output)
        {
            Output.AppendLine("   Slot: " + Slot);
            Output.AppendLine("   Spell: " + Spell);

            if (Spell > 0)
            {
                Output.AppendFormatLine("   Flags: {0} (0x{1:X2})", Flags, (uint)Flags);
                Output.AppendLine("   Level: " + Level);
                Output.AppendLine("   Charges: " + Charges);

                if ((Flags & AuraFlags.NotCaster) == 0)
                    Output.AppendLine("   Caster: " + Caster);

                if ((Flags & AuraFlags.Duration) != 0)
                {
                    Output.AppendLine("   Max Duration: " + TimeSpan.FromSeconds(MaxDuration / 1000));
                    Output.AppendLine("   Current Duration: " + TimeSpan.FromSeconds(LeftDuration / 1000));
                }

                if ((Flags & AuraFlags.BasePoints) != 0)
                {
                    for (int i = 0; i < MaxEffects; ++i)
                    {
                        if ((Flags & (AuraFlags)(1 << i)) != 0)
                            Output.AppendFormatLine("   Base Points {0}: {1}", i, BasePoints[i]);
                    }
                }
            }

            if (this.Slot >= MaxAuras)
                throw new NotImplementedException("Not implemented slot id = " + this.Slot);
        }
    }
}
