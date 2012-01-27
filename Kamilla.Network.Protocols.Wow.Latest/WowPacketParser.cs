using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kamilla.Network.Parsing;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Latest
{
    public abstract class WowPacketParser : PacketParser
    {
        protected virtual PacketGroups WowGroup { get { return PacketGroups.None; } }
        public /*override*/ ulong Group { get { return (ulong)WowGroup; } }

        public new WowPacket Packet { get { return this.Item.Packet as WowPacket; } }
        public WowOpcodes Opcode { get { return (WowOpcodes)this.Packet.Opcode; } }

        List<StreamHandler> m_compressedReaders;

        public StreamHandler DecompressBlock(WowOpcodes opcode)
        {
            if (this.Opcode == opcode)
                return this.DecompressBlock();
            else
                return this.Reader;
        }

        public StreamHandler DecompressBlock()
        {
            long compressedLength = Reader.RemainingLength - 6;
            var ret = Reader.DecompressBlock();
            long decompressedSize = ret.RemainingLength;

            Output.AppendFormatLine("Decompressed packet: {0} compressed size, {1} decompressed size ({2:F1}% profit).",
                compressedLength, decompressedSize,
                (float)(decompressedSize - compressedLength) / (float)decompressedSize * 100.0f);

            if (m_compressedReaders == null)
                m_compressedReaders = new List<StreamHandler>();

            m_compressedReaders.Add(ret);

            return ret;
        }

        public override void Parse()
        {
            if (this.IsParsed)
                return;

            base.Parse();

            if (m_compressedReaders != null)
            {
                m_compressedReaders.ForEach(reader =>
                {
                    if (reader.Position != reader.Length)
                    {
                        Output.AppendFormatLine("Read {0}/{1} compressed bytes.", reader.Position, reader.Length);
                        this.ParsingError = true;
                    }

                    reader.Close();
                });
                m_compressedReaders = null;
            }
        }
    }
}
