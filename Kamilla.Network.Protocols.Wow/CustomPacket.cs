using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow
{
    public class CustomPacket
    {
        private List<byte> Data;
        public TransferDirection TransferDirection { get; set; }
        public WowOpcodes Opcode { get; set; }

        // ctor
        public CustomPacket(WowOpcodes opcode, TransferDirection transferDirection)
        {
            this.Opcode = opcode;
            this.Data = new List<byte>();
            this.TransferDirection = transferDirection;
        }

        public WowPacket ToPacket()
        {
            return new WowPacket(this.Data.ToArray(), TransferDirection, PacketFlags.Custom,
                DateTime.Now, (uint)Environment.TickCount, (uint)Opcode, 0);
        }

        public CustomPacket WriteInt32(int val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteUInt32(uint val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteSingle(float val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteByte(byte val)
        {
            Data.Add(val);
            return this;
        }
        public CustomPacket WriteSByte(sbyte val)
        {
            Data.Add((byte)val);
            return this;
        }
        public CustomPacket WriteInt16(short val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteUInt16(ushort val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteInt64(long val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteUInt64(ulong val)
        {
            Data.AddRange(BitConverter.GetBytes(val));
            return this;
        }
        public CustomPacket WriteString(string val)
        {
            Data.AddRange(Encoding.ASCII.GetBytes(val));
            WriteByte(0);
            return this;
        }
        public CustomPacket WriteBytes(IEnumerable<byte> bytes)
        {
            Data.AddRange(bytes);
            return this;
        }
        public CustomPacket WriteReverseBytes(List<byte> val)
        {
            val.Reverse();
            Data.AddRange(val);
            return this;
        }
    }
}
