using System.Runtime.InteropServices;
using System.Text;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_SETUP_CURRENCY)]
    internal sealed class InitCurrencyParser : WowPacketParser
    {
        /// <summary>
        /// Represents currency info of this session.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        class CurrencyData
        {
            public uint Count;
            public int WeekCap;
            public int TotalCap;
            public int ThisWeek;
            public CurrencyTypes Type;
            public byte UnkByte;
            public bool HasWeekCap;
            public bool HasTotalCap;
            public bool HasThisWeek;

            public override string ToString()
            {
                var builder = new StringBuilder(256);
                this.ToString(builder);
                return builder.ToString();
            }

            public void ToString(StringBuilder builder)
            {
                builder.AppendFormatLine("Count: {0}    Type: {1} ({1:D})", this.Count, this.Type);
                if (this.HasWeekCap)
                    builder.AppendLine("Week Cap: " + this.WeekCap);
                if (this.HasTotalCap)
                    builder.AppendLine("Total Cap: " + this.TotalCap);
                if (this.HasThisWeek)
                    builder.AppendLine("This Week: " + this.ThisWeek);

                builder.AppendLine("Unk Byte: " + this.UnkByte);
            }
        }

        protected override void InternalParse()
        {
            var reader = this.Reader;

            uint count = reader.ReadUInt32();
            Output.AppendLine("Currency Count: " + count);
            var datas = new CurrencyData[count];

            for (uint i = 0; i < count; ++i)
            {
                var d = datas[i] = new CurrencyData();
                d.HasTotalCap = reader.UnalignedReadBit();
                d.HasWeekCap = reader.UnalignedReadBit();
                d.HasThisWeek = reader.UnalignedReadBit();
            }

            for (uint i = 0; i < count; ++i)
            {
                var d = datas[i];

                if (d.HasTotalCap)
                    d.TotalCap = reader.ReadInt32();

                if (d.HasWeekCap)
                    d.WeekCap = reader.ReadInt32();

                if (d.HasThisWeek)
                    d.ThisWeek = reader.ReadInt32();

                d.UnkByte = reader.ReadByte();
                d.Type = (CurrencyTypes)reader.ReadUInt32();
                d.Count = reader.ReadUInt32();

                Output.AppendLine("____________");
                Output.AppendFormatLine("Currency {0}:", i);
                d.ToString(Output);
                Output.AppendLine();
            }
        }
    }
}
