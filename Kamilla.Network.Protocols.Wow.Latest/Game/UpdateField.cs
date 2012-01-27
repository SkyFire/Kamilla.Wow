using System;
using System.Globalization;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    [Flags]
    public enum UpdateFieldFlags : ushort
    {
        None            = 0x00,
        Public          = 0x01,
        Private         = 0x02,
        OwnerOnly       = 0x04,
        Unk1            = 0x08,
        Unk2            = 0x10,
        Unk3            = 0x20,
        GroupOnly       = 0x40,
        Unk4            = 0x80,
        Dynamic         = 0x100
    }
    public enum UpdateFieldType : byte
    {
        None        = 0,
        Int         = 1,
        TwoShort    = 2,
        Float       = 3,
        Long        = 4,
        Bytes       = 5
    }

    public class UpdateField
    {
        public static UpdateField<T> CreateUnknown<T>(T index)
        {
            return new UpdateField<T>(0, 0, index);
        }

        public UpdateFieldFlags Flags { get; protected set; }
        public UpdateFieldType Type { get; protected set; }
        public object Id { get; protected set; }

        public string Print(ulong value)
        {
            if (this is UpdateField<PlayerUpdateFields> && Id is PlayerUpdateFields
                && (PlayerUpdateFields)Id == PlayerUpdateFields.PLAYER_FIELD_COINAGE)
                return new Money(value).ToString();
            else
                return new WowGuid(value).ToString();
        }

        public unsafe string Print(uint value)
        {
            switch (this.Type)
            {
                case UpdateFieldType.Float:
                    return (*(float*)&value).ToString("0.0000", CultureInfo.InvariantCulture);
                case UpdateFieldType.Int:
                case UpdateFieldType.None:
                default:
                    return value.ToString();
                case UpdateFieldType.Long:
                    if (this is UpdateField<PlayerUpdateFields> && Id is PlayerUpdateFields
                        && (PlayerUpdateFields)Id == PlayerUpdateFields.PLAYER_FIELD_COINAGE)
                        return new Money(value).ToString();
                    else
                        return "0x" + value.ToString("X8");
                case UpdateFieldType.Bytes:
                    return string.Concat(
                        "0x", (value & byte.MaxValue).ToString("X2"),
                        " 0x", ((value >> 8) & byte.MaxValue).ToString("X2"),
                        " 0x", ((value >> 16) & byte.MaxValue).ToString("X2"),
                        " 0x", ((value >> 24) & byte.MaxValue).ToString("X2")
                        );
                case UpdateFieldType.TwoShort:
                    return string.Concat(
                        (value & ushort.MaxValue),
                        " ",
                        ((value >> 16) & ushort.MaxValue)
                        );
            }
        }
    }

    public class UpdateField<T> : UpdateField
    {
        public new T Id { get; protected set; }

        public UpdateField(byte type, ushort flags, T id)
        {
            this.Flags = (UpdateFieldFlags)flags;
            this.Type = (UpdateFieldType)type;
            this.Id = id;
            base.Id = id;
        }
    }
}
