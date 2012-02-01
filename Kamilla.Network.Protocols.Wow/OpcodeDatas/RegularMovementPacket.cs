using System;
using System.Collections.Generic;
using System.Text;
using Kamilla.IO;
using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    /// <summary>
    /// Represents a regular movement packet such as
    /// <see href="Kamilla.Network.Protocols.Wow.WowOpcodes.CMSG_MOVE_STOP"/>.
    /// </summary>
    public abstract class RegularMovementPacket : OpcodeData
    {
        /// <summary>
        /// Defines all transmitted elements of <see cref="Kamilla.Network.Protocols.Wow.MovementStatus"/>.
        /// </summary>
        protected enum MovementStatusElements
        {
            Flags,
            Flags2,
            Timestamp,
            HavePitch,
            #region Guid
            GuidByte0, // 6DB645
            GuidByte1, // 6DB5D7
            GuidByte2, // 6DB605
            GuidByte3, // 6DB8C3
            GuidByte4, // 6DB8E8
            GuidByte5, // 6DB90D
            GuidByte6, // 6DB581
            GuidByte7, // 6DB960
            #endregion
            HaveFallData,
            HaveFallTransferDirection,
            HaveTransportData,
            TransportHaveTime2,
            TransportHaveTime3,
            #region TransportGuid
            TransportGuidByte0, // 6DB70C
            TransportGuidByte1, // 6DB6A8
            TransportGuidByte2, // 6DB7EC
            TransportGuidByte3, // 6DB7BA
            TransportGuidByte4, // 6DB6DA
            TransportGuidByte5, // 6DB89B
            TransportGuidByte6, // 6DB788
            TransportGuidByte7, // 6DB81E
            #endregion
            HaveSpline,
            HaveSplineElev,
            PositionX,
            PositionY,
            PositionZ,
            PositionO,
            #region Guid Seq
            GuidByte0_2, // 6DB9BF
            GuidByte1_2, // 6DBAC6
            GuidByte2_2, // 6DBD6F
            GuidByte3_2, // 6DBE0E
            GuidByte4_2, // 6DB9F8
            GuidByte5_2, // 6DBDF5
            GuidByte6_2, // 6DBDB0
            GuidByte7_2, // 6DBE27
            #endregion
            Pitch,
            FallTime,
            #region TransportGuid Seq
            TransportGuidByte0_2, // 6DBD35
            TransportGuidByte1_2, // 6DBB63
            TransportGuidByte2_2, // 6DBD49
            TransportGuidByte3_2, // 6DBB31
            TransportGuidByte4_2, // 6DBC79
            TransportGuidByte5_2, // 6DBCFD
            TransportGuidByte6_2, // 6DBC17
            TransportGuidByte7_2, // 6DBAFF
            #endregion
            SplineElev,
            FallHorizontalSpeed,
            FallVerticalSpeed,
            FallCosAngle,
            FallSinAngle,
            TransportSeat,
            TransportPositionO,
            TransportPositionX,
            TransportPositionY,
            TransportPositionZ,
            TransportTime,
            TransportTime2,
            TransportTime3,
            GenericDword0,
            GenericDword1,
            GenericDword2,
            GenericDword3,
        }

        /// <summary>
        /// Gets or sets the player movement status associated with the current packet.
        /// </summary>
        public MovementStatus Status { get; set; }

        /// <summary>
        /// Gets the guid of the unit associated with the current packet.
        /// </summary>
        public WowGuid Unit { get; set; }

        /// <summary>
        /// Initializes a new instance of
        /// <see cref="Kamilla.Network.Protocols.Wow.OpcodeDatas.RegularMovementPacket"/>.
        /// </summary>
        protected RegularMovementPacket()
        {
        }

        /// <summary>
        /// Gets the packet transfer direction.
        /// </summary>
        protected abstract TransferDirection TransferDirection { get; }

        /// <summary>
        /// Gets the opcode that is used to transmit the packet.
        /// </summary>
        public abstract WowOpcodes Opcode { get; }

        /// <summary>
        /// Gets the <see cref="System.Array"/> of
        /// <see cref="Kamilla.Network.Protocols.Wow.OpcodeDatas.RegularMovementPacket.MovementStatusElements"/>
        /// in the sequence they are transmitted.
        /// </summary>
        protected abstract MovementStatusElements[] Elements { get; }

        /// <summary>
        /// Creates a packet that represents the current
        /// <see cref="Kamilla.Network.Protocols.Wow.OpcodeDatas.RegularMovementPacket"/>.
        /// </summary>
        /// <returns>
        /// A packet to client that represents the current
        /// <see cref="Kamilla.Network.Protocols.Wow.OpcodeDatas.RegularMovementPacket"/>.
        /// </returns>
        public override CustomPacket CreatePacket()
        {
            return base.CreatePacket(this.Opcode, this.TransferDirection);
        }

        void VerifySequence(MovementStatusElements[] sequence)
        {
            if (sequence == null)
                throw new ArgumentNullException("Elements", "Elements must not be null.");

            var already = new List<MovementStatusElements>(sequence.Length);

            for (int i = 0; i < sequence.Length; i++)
            {
                var element = sequence[i];

                var idx = already.IndexOf(element);
                if (idx != -1)
                    throw new InvalidOperationException(
                        string.Format("Sequence has at least two entries of {0}: at {1} and {2}", element, idx, i)
                        );

                already.Add(element);
            }
        }

        protected virtual void ReadElement(StreamHandler reader, MovementStatusElements element, MovementStatus status, byte[] guid, byte[] tguid)
        {
            if (element >= MovementStatusElements.GuidByte0 && element <= MovementStatusElements.GuidByte7)
            {
                ReadByteMask(reader, ref guid[element - MovementStatusElements.GuidByte0]);
                return;
            }

            if (element >= MovementStatusElements.TransportGuidByte0 &&
                element <= MovementStatusElements.TransportGuidByte7)
            {
                if (status.HaveTransportData)
                    ReadByteMask(reader, ref tguid[element - MovementStatusElements.TransportGuidByte0]);
                return;
            }

            if (element >= MovementStatusElements.GuidByte0_2 && element <= MovementStatusElements.GuidByte7_2)
            {
                ReadByteSeq(reader, ref guid[element - MovementStatusElements.GuidByte0_2]);
                return;
            }

            if (element >= MovementStatusElements.TransportGuidByte0_2 &&
                element <= MovementStatusElements.TransportGuidByte7_2)
            {
                if (status.HaveTransportData)
                    ReadByteSeq(reader, ref tguid[element - MovementStatusElements.TransportGuidByte0_2]);
                return;
            }

            switch (element)
            {
                case MovementStatusElements.Flags:
                    status.Flags = (MovementFlags)reader.UnalignedReadInt(30);
                    break;
                case MovementStatusElements.Flags2:
                    status.Flags2 = (MovementFlags2)reader.UnalignedReadSmallInt(12);
                    break;
                case MovementStatusElements.Timestamp:
                    status.TimeStamp = reader.ReadUInt32();
                    break;
                case MovementStatusElements.HavePitch:
                    status.HavePitch = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.HaveFallData:
                    status.HaveFallData = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.HaveFallTransferDirection:
                    if (status.HaveFallData)
                        status.HaveFallTransferDirection = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.HaveTransportData:
                    status.HaveTransportData = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.TransportHaveTime2:
                    if (status.HaveTransportData)
                        status.HaveTransportTime2 = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.TransportHaveTime3:
                    if (status.HaveTransportData)
                        status.HaveTransportTime3 = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.HaveSpline:
                    status.HaveSpline = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.HaveSplineElev:
                    status.HaveSplineElevation = reader.UnalignedReadBit();
                    break;
                case MovementStatusElements.PositionX:
                    status.Position = reader.ReadVector3();
                    break;
                case MovementStatusElements.PositionO:
                    status.Orientation = reader.ReadSingle();
                    break;
                case MovementStatusElements.Pitch:
                    if (status.HavePitch)
                        status.Pitch = reader.ReadSingle();
                    break;
                case MovementStatusElements.FallTime:
                    if (status.HaveFallData)
                        status.FallTime = reader.ReadUInt32();
                    break;
                case MovementStatusElements.SplineElev:
                    if (status.HaveSplineElevation)
                        status.SplineElevation = reader.ReadSingle();
                    break;
                case MovementStatusElements.FallHorizontalSpeed:
                    if (status.HaveFallTransferDirection)
                        status.FallHorizontalSpeed = reader.ReadSingle();
                    break;
                case MovementStatusElements.FallVerticalSpeed:
                    if (status.HaveFallData)
                        status.FallVerticalSpeed = reader.ReadSingle();
                    break;
                case MovementStatusElements.FallCosAngle:
                    if (status.HaveFallTransferDirection)
                        status.FallCosAngle = reader.ReadSingle();
                    break;
                case MovementStatusElements.FallSinAngle:
                    if (status.HaveFallTransferDirection)
                        status.FallSinAngle = reader.ReadSingle();
                    break;
                case MovementStatusElements.TransportSeat:
                    if (status.HaveTransportData)
                        status.TransportSeat = reader.ReadSByte();
                    break;
                case MovementStatusElements.TransportPositionO:
                    if (status.HaveTransportData)
                        status.TransportFacing = reader.ReadSingle();
                    break;
                case MovementStatusElements.TransportPositionX:
                    if (status.HaveTransportData)
                    {
                        status.TransportPosition.X = reader.ReadSingle();
                        status.TransportPosition.Y = reader.ReadSingle();
                        status.TransportPosition.Z = reader.ReadSingle();
                    }
                    break;
                case MovementStatusElements.TransportTime:
                    if (status.HaveTransportData)
                        status.TransportTime = reader.ReadUInt32();
                    break;
                case MovementStatusElements.TransportTime2:
                    if (status.HaveTransportTime2)
                        status.TransportTime2 = reader.ReadUInt32();
                    break;
                case MovementStatusElements.TransportTime3:
                    if (status.HaveTransportTime3)
                        status.TransportTime3 = reader.ReadUInt32();
                    break;
                case MovementStatusElements.PositionY:
                case MovementStatusElements.PositionZ:
                case MovementStatusElements.TransportPositionY:
                case MovementStatusElements.TransportPositionZ:
                    break;
                default:
                    throw new InvalidOperationException("Unknown element: " + element);
            }
        }

        public override void Read(StreamHandler reader)
        {
            var sequence = this.Elements;
            VerifySequence(sequence);

            var status = this.Status = new MovementStatus();

            var guid = new byte[8];
            var tguid = new byte[8];

            for (int i = 0; i < sequence.Length; ++i)
            {
                try
                {
                    ReadElement(reader, sequence[i], status, guid, tguid);
                }
                catch (Exception e)
                {
                    throw new Exception(string.Format("Failed when reading element {0}: {1}", i, sequence[i]), e);
                }
            }

            this.Unit = new WowGuid(guid);
            status.TransportGuid = new WowGuid(tguid);
        }

        protected void ReadByteMask(StreamHandler reader, ref byte b)
        {
            b = reader.UnalignedReadBit() ? (byte)1 : (byte)0;
        }

        protected void ReadByteSeq(StreamHandler reader, ref byte b)
        {
            if (b != 0)
                b ^= reader.ReadByte();
        }

        protected virtual void WriteElement(StreamHandler writer, MovementStatusElements element, MovementStatus status, byte[] guid, byte[] tguid)
        {
            if (element >= MovementStatusElements.GuidByte0 && element <= MovementStatusElements.GuidByte7)
            {
                WriteByteMask(writer, guid[element - MovementStatusElements.GuidByte0]);
                return;
            }

            if (element >= MovementStatusElements.TransportGuidByte0 &&
                element <= MovementStatusElements.TransportGuidByte7)
            {
                if (status.HaveTransportData)
                    WriteByteMask(writer, tguid[element - MovementStatusElements.TransportGuidByte0]);
                return;
            }

            if (element >= MovementStatusElements.GuidByte0_2 && element <= MovementStatusElements.GuidByte7_2)
            {
                WriteByteSeq(writer, guid[element - MovementStatusElements.GuidByte0_2]);
                return;
            }

            if (element >= MovementStatusElements.TransportGuidByte0_2 &&
                element <= MovementStatusElements.TransportGuidByte7_2)
            {
                if (status.HaveTransportData)
                    WriteByteSeq(writer, tguid[element - MovementStatusElements.TransportGuidByte0_2]);
                return;
            }

            switch (element)
            {
                case MovementStatusElements.Flags:
                    writer.UnalignedWriteInt((uint)status.Flags, 30);
                    break;
                case MovementStatusElements.Flags2:
                    writer.UnalignedWriteInt((ushort)status.Flags2, 12);
                    break;
                case MovementStatusElements.Timestamp:
                    writer.FlushUnalignedBits();
                    writer.WriteUInt32(status.TimeStamp);
                    break;
                case MovementStatusElements.HavePitch:
                    writer.UnalignedWriteBit(status.HavePitch);
                    break;
                case MovementStatusElements.HaveFallData:
                    writer.UnalignedWriteBit(status.HaveFallData);
                    break;
                case MovementStatusElements.HaveFallTransferDirection:
                    if (status.HaveFallData)
                        writer.UnalignedWriteBit(status.HaveFallTransferDirection);
                    break;
                case MovementStatusElements.HaveTransportData:
                    writer.UnalignedWriteBit(status.HaveTransportData);
                    break;
                case MovementStatusElements.TransportHaveTime2:
                    if (status.HaveTransportData)
                        writer.UnalignedWriteBit(status.HaveTransportTime2);
                    break;
                case MovementStatusElements.TransportHaveTime3:
                    if (status.HaveTransportData)
                        writer.UnalignedWriteBit(status.HaveTransportTime3);
                    break;
                case MovementStatusElements.HaveSpline:
                    writer.UnalignedWriteBit(status.HaveSpline);
                    break;
                case MovementStatusElements.HaveSplineElev:
                    writer.UnalignedWriteBit(status.HaveSplineElevation);
                    break;
                case MovementStatusElements.PositionX:
                    writer.FlushUnalignedBits();
                    writer.WriteVector3(ref status.Position);
                    break;
                case MovementStatusElements.PositionO:
                    writer.FlushUnalignedBits();
                    writer.WriteSingle(status.Orientation);
                    break;
                case MovementStatusElements.Pitch:
                    writer.FlushUnalignedBits();
                    if (status.HavePitch)
                        writer.WriteSingle(status.Pitch);
                    break;
                case MovementStatusElements.FallTime:
                    writer.FlushUnalignedBits();
                    if (status.HaveFallData)
                        writer.WriteUInt32(status.FallTime);
                    break;
                case MovementStatusElements.SplineElev:
                    writer.FlushUnalignedBits();
                    if (status.HaveSplineElevation)
                        writer.WriteSingle(status.SplineElevation);
                    break;
                case MovementStatusElements.FallHorizontalSpeed:
                    writer.FlushUnalignedBits();
                    if (status.HaveFallTransferDirection)
                        writer.WriteSingle(status.FallHorizontalSpeed);
                    break;
                case MovementStatusElements.FallVerticalSpeed:
                    writer.FlushUnalignedBits();
                    if (status.HaveFallData)
                        writer.WriteSingle(status.FallVerticalSpeed);
                    break;
                case MovementStatusElements.FallCosAngle:
                    writer.FlushUnalignedBits();
                    if (status.HaveFallTransferDirection)
                        writer.WriteSingle(status.FallCosAngle);
                    break;
                case MovementStatusElements.FallSinAngle:
                    writer.FlushUnalignedBits();
                    if (status.HaveFallTransferDirection)
                        writer.WriteSingle(status.FallSinAngle);
                    break;
                case MovementStatusElements.TransportSeat:
                    writer.FlushUnalignedBits();
                    if (status.HaveTransportData)
                        writer.WriteSByte(status.TransportSeat);
                    break;
                case MovementStatusElements.TransportPositionO:
                    writer.FlushUnalignedBits();
                    if (status.HaveTransportData)
                        writer.WriteSingle(status.TransportFacing);
                    break;
                case MovementStatusElements.TransportPositionX:
                    writer.FlushUnalignedBits();
                    if (status.HaveTransportData)
                    {
                        writer.WriteSingle(status.TransportPosition.X);
                        writer.WriteSingle(status.TransportPosition.Y);
                        writer.WriteSingle(status.TransportPosition.Z);
                    }
                    break;
                case MovementStatusElements.TransportTime:
                    writer.FlushUnalignedBits();
                    if (status.HaveTransportData)
                        writer.WriteUInt32(status.TransportTime);
                    break;
                case MovementStatusElements.TransportTime2:
                    writer.FlushUnalignedBits();
                    if (status.HaveTransportTime2)
                        writer.WriteUInt32(status.TransportTime2);
                    break;
                case MovementStatusElements.TransportTime3:
                    writer.FlushUnalignedBits();
                    if (status.HaveTransportTime3)
                        writer.WriteUInt32(status.TransportTime3);
                    break;
                case MovementStatusElements.PositionY:
                case MovementStatusElements.PositionZ:
                case MovementStatusElements.TransportPositionY:
                case MovementStatusElements.TransportPositionZ:
                    break;
                default:
                    throw new InvalidOperationException("Unknown element: " + element);
            }
        }

        public override void Save(StreamHandler writer)
        {
            var sequence = this.Elements;
            VerifySequence(sequence);

            var status = this.Status;

            var guid = BitConverter.GetBytes(this.Unit.Raw);
            var tguid = BitConverter.GetBytes(status.TransportGuid.Raw);

            for (int i = 0; i < sequence.Length; ++i)
                WriteElement(writer, sequence[i], status, guid, tguid);
        }

        protected void WriteByteMask(StreamHandler writer, byte b)
        {
            writer.UnalignedWriteBit(b != 0);
        }

        protected void WriteByteSeq(StreamHandler writer, byte b)
        {
            writer.FlushUnalignedBits();
            if (b != 0)
                writer.WriteByte((byte)(b ^ 1));
        }

        public override void ToString(StringBuilder builder)
        {
            builder.AppendLine("Unit: " + this.Unit);
            this.Status.ToString(builder);
        }
    }
}
