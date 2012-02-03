using System;
using System.Text;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Game
{
    [Flags]
    public enum MovementFlags : uint
    {
        None                = 0x00000000,
        Forward             = 0x00000001,
        Backward            = 0x00000002,
        StrafeLeft          = 0x00000004,
        StrafeRight         = 0x00000008,
        TurnLeft            = 0x00000010,
        TurnRight           = 0x00000020,
        PitchUp             = 0x00000040,
        PitchDown           = 0x00000080,
        WalkMode            = 0x00000100,
        GravityDisabled     = 0x00000200,
        Root                = 0x00000400,
        Falling             = 0x00000800,
        FallingFar          = 0x00001000,
        PendingStop         = 0x00002000,
        PendingStrafeStop   = 0x00004000,
        PendingForward      = 0x00008000,
        PendingBackward     = 0x00010000,
        PendingStrafeLeft   = 0x00020000,
        PendingStrafeRight  = 0x00040000,
        PendingRoot         = 0x00080000,
        Swimming            = 0x00100000,
        Ascending           = 0x00200000,
        Descending          = 0x00400000,
        CanFly              = 0x00800000,
        Flying              = 0x01000000,
        //unknown           = 0x02000000,
        WaterWalking        = 0x04000000,
        SafeFall            = 0x08000000,
        Hover               = 0x10000000,
        CollisionDisabled   = 0x20000000,
        OnTransport         = 0x40000000, // wtf?
    }

    [Flags]
    public enum MovementFlags2 : ushort
    {
        None                            = 0x0000,
        Unknown1                        = 0x0001,
        Unknown2                        = 0x0002,
        Unknown4                        = 0x0020,
        Unknown5                        = 0x0040,
        Unknown6                        = 0x0080,

        CanTransitionBetweenSwimAndFly  = 0x0400,
        Unknown10                       = 0x0800,

        InterpolatedPlayerTurning       = 0x4000,
    }

    public enum MoveTypes : int
    {
        None = -1,
        Walk = 0,
        Run = 1,
        RunBack = 2,
        Swim = 3,
        SwimBack = 4,
        Turn = 5,
        Flight = 6,
        FlightBack = 7,
        Pitch = 8,
        Total = 9
    }

    public class MovementStatus
    {
        public bool HaveTransportData;
        public bool HaveTransportTime2;
        public bool HaveTransportTime3;
        public bool HavePitch;
        public bool HaveFallData;
        public bool HaveFallTransferDirection;
        public bool HaveSplineElevation;
        public bool HaveSpline;
        public bool HaveSpline2;

        public MovementFlags Flags;
        public MovementFlags2 Flags2;
        public uint TimeStamp;
        public Vector3 Position;
        public float Orientation;

        public WowGuid TransportGuid;
        public Vector3 TransportPosition;
        public float TransportFacing;
        public uint TransportTime;
        public sbyte TransportSeat;
        public uint TransportTime2;
        public uint TransportTime3;

        public float Pitch;
        public uint FallTime;
        public float FallSinAngle;
        public float FallCosAngle;
        public float FallVerticalSpeed;
        public float FallHorizontalSpeed;
        public float SplineElevation;

        public MovementStatus()
        {
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            ToString(builder);
            return builder.ToString();
        }

        public void ToString(StringBuilder builder)
        {
            builder.AppendLine("Flags: " + Flags);
            builder.AppendLine("Flags2: " + Flags2);
            builder.AppendLine("Timestamp: " + TimeStamp);

            builder.AppendLine("Position: " + Position + " Orientation: " + Orientation);

            if (HaveTransportData)
            {
                builder.AppendLine(" Transport Guid: " + TransportGuid);
                builder.AppendLine(" Transport Position: " + TransportPosition + " Orientation: " + TransportFacing);
                builder.AppendLine(" Transport Time: " + TransportTime);
                builder.AppendLine(" Transport Seat: " + TransportSeat);
                if (HaveTransportTime2)
                    builder.AppendLine("  Transport Time2: " + TransportTime2);
                if (HaveTransportTime3)
                    builder.AppendLine("  Transport Time3: " + TransportTime3);
            }

            if (HavePitch)
                builder.AppendLine("Pitch: " + Pitch);

            if (HaveFallData)
            {
                builder.AppendLine(" Fall Time: " + FallTime);
                builder.AppendLine(" Fall Vertical Speed: " + FallVerticalSpeed);

                if (HaveFallTransferDirection)
                {
                    builder.AppendLine("  Fall Cos Angle: " + FallCosAngle);
                    builder.AppendLine("  Fall Sin Angle: " + FallSinAngle);
                    builder.AppendLine("  Fall Horizontal Speed: " + FallHorizontalSpeed);
                }
            }

            if (HaveSplineElevation)
                builder.AppendLine("Spline Elevation: " + SplineElevation);
        }
    }

    public class MovementInfo : MovementStatus
    {
        public SplineInfo       Spline = new SplineInfo();
        public WowGuid          Guid;
        public WowGuid          AttackingTarget;
        public uint             VehicleId;
        public float            VehicleAimAdjustement;
        public Quaternion       GameObjectRotation;

        public float[]          Speeds = new float[(int)MoveTypes.Total]
        {
            2.5f, 7.0f, 4.5f, 4.72222f, 2.5f, 7.0f, 4.5f, 3.141593f, 3.141593f
        };

        //public ushort[]         UnkUInt16 = new ushort[3];
        public uint[]           UnkUInt32 = new uint[0];

        public float CollisionHeight = 1.0f;
        public bool HaveVehicleData;
        public bool HaveAttackingTarget;
        public bool HaveGameObjectRotation;
        public bool HaveTransportTime;
        public bool Living;
        public bool SelfTarget;
        public bool HavePosition;
        public bool HaveGameObjectPosition;

        public MovementInfo(WowGuid guid)
        {
            this.Guid = guid;
        }

        public unsafe MovementInfo(StreamHandler Reader)
        {
            var guid = new WowGuid();
            this.HaveAttackingTarget = Reader.UnalignedReadBit();
            guid.Bytes[2] = Reader.UnalignedReadTinyInt(1);
            this.HaveVehicleData = Reader.UnalignedReadBit();
            guid.Bytes[1] = Reader.UnalignedReadTinyInt(1);
            guid.Bytes[4] = Reader.UnalignedReadTinyInt(1);
            guid.Bytes[3] = Reader.UnalignedReadTinyInt(1);
            this.HaveTransportTime = Reader.UnalignedReadBit();
            this.HaveGameObjectPosition = Reader.UnalignedReadBit();
            bool field_1C8 = Reader.UnalignedReadBit();
            bool field_1AC = Reader.UnalignedReadBit();
            this.HaveGameObjectRotation = Reader.UnalignedReadBit();
            this.Living = Reader.UnalignedReadBit();
            this.HavePosition = Reader.UnalignedReadBit();
            var arrCounter = Reader.UnalignedReadInt(24);
            guid.Bytes[0] = Reader.UnalignedReadTinyInt(1);

            bool havePFlags = false;
            WowGuid p_guid;
            uint splinePoints = 0;
            bool havePFlags2 = false;
            bool haveOrientation = false;

            if (this.Living)
            {
                this.HaveTransportData = Reader.UnalignedReadBit();
                if (this.HaveTransportData)
                {
                    fixed (byte* bytes = this.TransportGuid.Bytes)
                    {
                        bytes[2] = Reader.UnalignedReadTinyInt(1);
                        bytes[7] = Reader.UnalignedReadTinyInt(1);
                        bytes[5] = Reader.UnalignedReadTinyInt(1);
                        this.HaveTransportTime3 = Reader.UnalignedReadBit();
                        bytes[3] = Reader.UnalignedReadTinyInt(1);
                        bytes[0] = Reader.UnalignedReadTinyInt(1);
                        bytes[4] = Reader.UnalignedReadTinyInt(1);
                        bytes[1] = Reader.UnalignedReadTinyInt(1);
                        this.HaveTransportTime2 = Reader.UnalignedReadBit();
                        bytes[6] = Reader.UnalignedReadTinyInt(1);
                    }
                }

                this.HaveSpline2 = Reader.UnalignedReadBit();
                p_guid.Bytes[7] = Reader.UnalignedReadTinyInt(1);
                p_guid.Bytes[6] = Reader.UnalignedReadTinyInt(1);
                p_guid.Bytes[5] = Reader.UnalignedReadTinyInt(1);
                p_guid.Bytes[2] = Reader.UnalignedReadTinyInt(1);
                p_guid.Bytes[4] = Reader.UnalignedReadTinyInt(1);
                havePFlags = !Reader.UnalignedReadBit();
                p_guid.Bytes[1] = Reader.UnalignedReadTinyInt(1);
                this.SelfTarget = Reader.UnalignedReadBit();
                this.TimeStamp = !Reader.UnalignedReadBit() ? 1U : 0U;
                havePFlags2 = !Reader.UnalignedReadBit();

                if (this.HaveSpline2)
                {
                    this.HaveSpline = Reader.UnalignedReadBit();
                    if (this.HaveSpline)
                    {
                        this.Spline.HaveDurationMultiplier = Reader.UnalignedReadBit();
                        this.Spline.Flags = (SplineFlags)Reader.UnalignedReadInt(25);
                        this.Spline.SplineMode = (SplineMode)Reader.UnalignedReadTinyInt(2);
                        this.Spline.HaveUnknown1 = Reader.UnalignedReadBit();
                        splinePoints = Reader.UnalignedReadInt(22);
                        this.Spline.SplineType = (SplineType)Reader.UnalignedReadTinyInt(2);
                        if (this.Spline.SplineType == SplineType.FacingTarget)
                        {
                            fixed (byte* bytes = this.Spline.FacingTarget.Bytes)
                            {
                                bytes[7] = Reader.UnalignedReadTinyInt(1);
                                bytes[3] = Reader.UnalignedReadTinyInt(1);
                                bytes[4] = Reader.UnalignedReadTinyInt(1);
                                bytes[2] = Reader.UnalignedReadTinyInt(1);
                                bytes[1] = Reader.UnalignedReadTinyInt(1);
                                bytes[6] = Reader.UnalignedReadTinyInt(1);
                                bytes[0] = Reader.UnalignedReadTinyInt(1);
                                bytes[5] = Reader.UnalignedReadTinyInt(1);
                            }
                        }
                    }
                }

                p_guid.Bytes[3] = Reader.UnalignedReadTinyInt(1);
                if (havePFlags)
                    this.Flags = (MovementFlags)Reader.UnalignedReadInt(30);
                this.HavePitch = !Reader.UnalignedReadBit();
                this.HaveFallData = Reader.UnalignedReadBit();

                if (havePFlags2)
                    this.Flags2 = (MovementFlags2)Reader.UnalignedReadSmallInt(12);

                p_guid.Bytes[0] = Reader.UnalignedReadTinyInt(1);
                haveOrientation = !Reader.UnalignedReadBit();

                if (this.HaveFallData)
                    this.HaveFallTransferDirection = Reader.UnalignedReadBit();

                this.HaveSplineElevation = !Reader.UnalignedReadBit();
            }

            if (this.HaveGameObjectPosition)
            {
                fixed (byte* bytes = this.TransportGuid.Bytes)
                {
                    bytes[1] = Reader.UnalignedReadTinyInt(1);
                    this.HaveTransportTime3 = Reader.UnalignedReadBit();
                    bytes[3] = Reader.UnalignedReadTinyInt(1);
                    bytes[2] = Reader.UnalignedReadTinyInt(1);
                    bytes[6] = Reader.UnalignedReadTinyInt(1);
                    bytes[5] = Reader.UnalignedReadTinyInt(1);
                    bytes[0] = Reader.UnalignedReadTinyInt(1);
                    bytes[4] = Reader.UnalignedReadTinyInt(1);
                    this.HaveTransportTime2 = Reader.UnalignedReadBit();
                    bytes[7] = Reader.UnalignedReadTinyInt(1);
                }
            }

            ushort field_1B2 = 0;
            ushort field_1AE = 0;
            ushort field_1B0 = 0;
            if (field_1AC)
            {
                field_1B2 = (ushort)(!Reader.UnalignedReadBit() ? 1 : 0);
                field_1AE = (ushort)(!Reader.UnalignedReadBit() ? 1 : 0);
                field_1B0 = (ushort)(!Reader.UnalignedReadBit() ? 1 : 0);
            }

            if (this.HaveAttackingTarget)
            {
                fixed (byte* bytes = this.AttackingTarget.Bytes)
                {
                    bytes[3] = Reader.UnalignedReadTinyInt(1);
                    bytes[4] = Reader.UnalignedReadTinyInt(1);
                    bytes[6] = Reader.UnalignedReadTinyInt(1);
                    bytes[0] = Reader.UnalignedReadTinyInt(1);
                    bytes[1] = Reader.UnalignedReadTinyInt(1);
                    bytes[7] = Reader.UnalignedReadTinyInt(1);
                    bytes[5] = Reader.UnalignedReadTinyInt(1);
                    bytes[2] = Reader.UnalignedReadTinyInt(1);
                }
            }

            this.UnkUInt32 = new uint[arrCounter];
            for (uint i = 0; i < arrCounter; ++i)
            {
                this.UnkUInt32[i] = Reader.ReadUInt32();
            }

            if (this.HavePosition)
            {
                Reader
                    .ReadSingle(out this.Position.Z)
                    .ReadSingle(out this.Orientation)
                    .ReadSingle(out this.Position.X)
                    .ReadSingle(out this.Position.Y);
            }

            if (this.HaveVehicleData)
            {
                Reader
                    .ReadUInt32(out this.VehicleId)
                    .ReadSingle(out this.VehicleAimAdjustement);
            }

            if (this.HaveGameObjectPosition)
            {
                fixed (byte* bytes = this.TransportGuid.Bytes)
                {
                    Reader
                        .ReadXorByte(ref bytes[1])
                        .ReadXorByte(ref bytes[4])
                        .ReadSingle(out this.TransportPosition.Z);

                    if (this.HaveTransportTime3)
                        this.TransportTime3 = Reader.ReadUInt32();

                    this.TransportTime = Reader.ReadUInt32();

                    Reader
                        .ReadXorByte(ref bytes[5])
                        .ReadXorByte(ref bytes[6])
                        .ReadSingle(out this.TransportPosition.X)
                        .ReadXorByte(ref bytes[2]);

                    if (this.HaveTransportTime2)
                        this.TransportTime2 = Reader.ReadUInt32();

                    Reader
                        .ReadSByte(out this.TransportSeat)
                        .ReadXorByte(ref bytes[3])
                        .ReadSingle(out this.TransportPosition.Y)
                        .ReadSingle(out this.TransportFacing)
                        .ReadXorByte(ref bytes[7])
                        .ReadXorByte(ref bytes[0]);
                }
            }

            if (this.Living)
            {
                if (this.HaveSpline2)
                {
                    if (this.HaveSpline)
                    {
                        var points = this.Spline.Points;
                        points.Capacity = (int)splinePoints;
                        for (int i = 0; i < splinePoints; i++)
                            points.Add(new Vector3()
                            {
                                Y = Reader.ReadSingle(),
                                X = Reader.ReadSingle(),
                                Z = Reader.ReadSingle()
                            });

                        if (this.Spline.HaveDurationMultiplier)
                        {
                            this.Spline.DurationMultiplier = Reader.ReadSingle();
                        }

                        this.Spline.UnknownFloat2 = Reader.ReadSingle();

                        if (this.Spline.SplineType == SplineType.FacingTarget)
                        {
                            fixed (byte* bytes = this.Spline.FacingTarget.Bytes)
                            {
                                Reader
                                    .ReadXorByte(ref bytes[3])
                                    .ReadXorByte(ref bytes[4])
                                    .ReadXorByte(ref bytes[5])
                                    .ReadXorByte(ref bytes[7])
                                    .ReadXorByte(ref bytes[2])
                                    .ReadXorByte(ref bytes[0])
                                    .ReadXorByte(ref bytes[6])
                                    .ReadXorByte(ref bytes[1]);
                            }
                        }

                        if (this.Spline.HaveUnknown1)
                        {
                            this.Spline.Unknown1 = Reader.ReadUInt32();
                        }

                        this.Spline.UnknownFloat3 = Reader.ReadSingle();
                        this.Spline.Unknown2 = Reader.ReadUInt32();

                        if (this.Spline.SplineType == SplineType.FacingSpot)
                        {
                            Reader
                                .ReadSingle(out this.Spline.FacingSpot.Y)
                                .ReadSingle(out this.Spline.FacingSpot.Z)
                                .ReadSingle(out this.Spline.FacingSpot.X);
                        }

                        this.Spline.CurrentTime = Reader.ReadUInt32();

                        if (this.Spline.SplineType == SplineType.FacingAngle)
                            this.Spline.FacingAngle = Reader.ReadSingle();
                    }

                    Reader
                        .ReadSingle(out this.Spline.EndPoint.Z)
                        .ReadSingle(out this.Spline.EndPoint.Y)
                        .ReadUInt32(out this.Spline.FullTime)
                        .ReadSingle(out this.Spline.EndPoint.X);
                }

                this.Speeds[8] = Reader.ReadSingle();

                // Transport Data
                if (this.HaveTransportData)
                {
                    fixed (byte* bytes = this.TransportGuid.Bytes)
                    {
                        Reader
                            .ReadXorByte(ref bytes[4])
                            .ReadSingle(out this.TransportPosition.Z)
                            .ReadXorByte(ref bytes[7])
                            .ReadXorByte(ref bytes[5])
                            .ReadXorByte(ref bytes[1])
                            .ReadSingle(out this.TransportPosition.X)
                            .ReadXorByte(ref bytes[3])
                            .ReadXorByte(ref bytes[6]);

                        if (this.HaveTransportTime3)
                            this.TransportTime3 = Reader.ReadUInt32();

                        Reader
                            .ReadSingle(out this.TransportPosition.Y)
                            .ReadSByte(out this.TransportSeat)
                            .ReadSingle(out this.TransportFacing);

                        if (this.HaveTransportTime2)
                            this.TransportTime2 = Reader.ReadUInt32();

                        Reader
                            .ReadXorByte(ref bytes[2])
                            .ReadUInt32(out this.TransportTime)
                            .ReadXorByte(ref bytes[0]);
                    }
                }

                Reader
                    .ReadSingle(out this.Speeds[7])
                    .ReadSingle(out this.Position.X);

                if (this.HavePitch)
                    Reader.ReadSingle(out this.Pitch);

                // Fall Data
                if (this.HaveFallData)
                {
                    Reader.ReadUInt32(out this.FallTime);
                    if (this.HaveFallTransferDirection)
                    {
                        Reader
                            .ReadSingle(out this.FallSinAngle)
                            .ReadSingle(out this.FallHorizontalSpeed)
                            .ReadSingle(out this.FallCosAngle);
                    }
                    Reader.ReadSingle(out this.FallVerticalSpeed);
                }

                Reader
                    .ReadXorByte(ref p_guid.Bytes[7])
                    .ReadSingle(out this.Speeds[4])
                    .ReadXorByte(ref p_guid.Bytes[0])
                    .ReadXorByte(ref p_guid.Bytes[5]);

                if (this.TimeStamp != 0)
                    this.TimeStamp = Reader.ReadUInt32();

                Reader
                    .ReadSingle(out this.Position.Z)
                    .ReadSingle(out this.Speeds[6])
                    .ReadXorByte(ref p_guid.Bytes[1])
                    .ReadSingle(out this.Speeds[2])
                    .ReadSingle(out this.Speeds[5])
                    .ReadSingle(out this.Speeds[3])
                    .ReadSingle(out this.Speeds[0])
                    .ReadXorByte(ref p_guid.Bytes[3])
                    .ReadXorByte(ref p_guid.Bytes[4])
                    .ReadXorByte(ref p_guid.Bytes[2])
                    .ReadXorByte(ref p_guid.Bytes[6]);

                if (this.HaveSplineElevation)
                    this.SplineElevation = Reader.ReadSingle();

                this.Position.Y = Reader.ReadSingle();

                if (haveOrientation)
                    this.Orientation = Reader.ReadSingle();

                this.Speeds[1] = Reader.ReadSingle();
            }

            if (field_1C8)
            {
                Console.WriteLine("Error: 16 floats @ 1CC detected !!!");

                Reader.ReadBytes(16 * 4); // 16 floats starting at 1CC
                var field_20C = Reader.ReadByte();
            }

            // transport time
            if (this.HaveTransportTime)
                Reader.ReadUInt32(out this.TransportTime);

            // unk2 ?
            if (field_1AC)
            {
                Console.WriteLine("Error: 3 shorts @ 1AE detected !!!");

                if (field_1B0 != 0)
                    field_1B0 = Reader.ReadUInt16();
                if (field_1B2 != 0)
                    field_1B2 = Reader.ReadUInt16();
                if (field_1AE != 0)
                    field_1AE = Reader.ReadUInt16();
            }

            // go rotation?
            if (this.HaveGameObjectRotation)
                this.GameObjectRotation = Reader.ReadUInt64().UnpackQuaternion();

            // target guid?
            if (this.HaveAttackingTarget)
            {
                fixed (byte* bytes = this.AttackingTarget.Bytes)
                {
                    Reader
                        .ReadXorByte(ref bytes[3])
                        .ReadXorByte(ref bytes[5])
                        .ReadXorByte(ref bytes[0])
                        .ReadXorByte(ref bytes[7])
                        .ReadXorByte(ref bytes[2])
                        .ReadXorByte(ref bytes[4])
                        .ReadXorByte(ref bytes[6])
                        .ReadXorByte(ref bytes[1]);
                }
            }

            this.Guid = guid;
        }

        public unsafe void Save(StreamHandler Writer)
        {
            var guid = this.Guid;

            Writer
                .UnalignedWriteBit(this.HaveAttackingTarget)
                .UnalignedWriteBit(guid.Bytes[2] != 0)
                .UnalignedWriteBit(this.HaveVehicleData)
                .UnalignedWriteBit(guid.Bytes[1] != 0)
                .UnalignedWriteBit(guid.Bytes[4] != 0)
                .UnalignedWriteBit(guid.Bytes[3] != 0)
                .UnalignedWriteBit(this.HaveTransportTime)
                .UnalignedWriteBit(this.HaveGameObjectPosition)
                .UnalignedWriteBit(false) // TODO
                .UnalignedWriteBit(false) // TODO
                .UnalignedWriteBit(this.HaveGameObjectRotation)
                .UnalignedWriteBit(this.Living)
                .UnalignedWriteBit(this.HavePosition)
                .UnalignedWriteInt((uint)this.UnkUInt32.Length, 24)
                .UnalignedWriteBit(guid.Bytes[0] != 0)
                ;

            var p_guid = this.Guid;

            if (this.Living)
            {
                Writer.UnalignedWriteBit(this.HaveTransportData);
                if (this.HaveTransportData)
                {
                    fixed (byte* bytes = this.TransportGuid.Bytes)
                    {
                        Writer
                            .UnalignedWriteBit(bytes[2] != 0)
                            .UnalignedWriteBit(bytes[7] != 0)
                            .UnalignedWriteBit(bytes[5] != 0)
                            .UnalignedWriteBit(this.HaveTransportTime3)
                            .UnalignedWriteBit(bytes[3] != 0)
                            .UnalignedWriteBit(bytes[0] != 0)
                            .UnalignedWriteBit(bytes[4] != 0)
                            .UnalignedWriteBit(bytes[1] != 0)
                            .UnalignedWriteBit(this.HaveTransportTime2)
                            .UnalignedWriteBit(bytes[6] != 0);
                    }
                }

                Writer
                    .UnalignedWriteBit(this.HaveSpline2)
                    .UnalignedWriteBit(p_guid.Bytes[7] != 0)
                    .UnalignedWriteBit(p_guid.Bytes[6] != 0)
                    .UnalignedWriteBit(p_guid.Bytes[5] != 0)
                    .UnalignedWriteBit(p_guid.Bytes[2] != 0)
                    .UnalignedWriteBit(p_guid.Bytes[4] != 0)
                    .UnalignedWriteBit(!(this.Flags != 0))
                    .UnalignedWriteBit(p_guid.Bytes[1] != 0)
                    .UnalignedWriteBit(this.SelfTarget)
                    .UnalignedWriteBit(!(this.TimeStamp != 0))
                    .UnalignedWriteBit(!(this.Flags2 != 0));

                if (this.HaveSpline2)
                {
                    Writer.UnalignedWriteBit(this.HaveSpline);
                    if (this.HaveSpline)
                    {
                        Writer
                            .UnalignedWriteBit(this.Spline.HaveDurationMultiplier)
                            .UnalignedWriteInt((uint)this.Spline.Flags, 25)
                            .UnalignedWriteInt((byte)this.Spline.SplineMode, 2)
                            .UnalignedWriteBit(this.Spline.HaveUnknown1)
                            .UnalignedWriteInt((uint)this.Spline.Points.Count, 22)
                            .UnalignedWriteInt((byte)this.Spline.SplineType, 2);

                        if (this.Spline.SplineType == SplineType.FacingTarget)
                        {
                            fixed (byte* bytes = this.Spline.FacingTarget.Bytes)
                            {
                                Writer
                                    .UnalignedWriteBit(bytes[7] != 0)
                                    .UnalignedWriteBit(bytes[3] != 0)
                                    .UnalignedWriteBit(bytes[4] != 0)
                                    .UnalignedWriteBit(bytes[2] != 0)
                                    .UnalignedWriteBit(bytes[1] != 0)
                                    .UnalignedWriteBit(bytes[6] != 0)
                                    .UnalignedWriteBit(bytes[0] != 0)
                                    .UnalignedWriteBit(bytes[5] != 0);
                            }
                        }
                    }
                }

                Writer
                    .UnalignedWriteBit(p_guid.Bytes[3] != 0);

                if (this.Flags != 0)
                    Writer.UnalignedWriteInt((uint)this.Flags, 30);

                Writer
                    .UnalignedWriteBit(!this.HavePitch)
                    .UnalignedWriteBit(this.HaveFallData);
                if (this.Flags2 != 0)
                    Writer.UnalignedWriteInt((ushort)this.Flags2, 12);
                Writer
                    .UnalignedWriteBit(p_guid.Bytes[0] != 0)
                    .UnalignedWriteBit(!(this.Orientation != 0.0f)); // !haveOrient

                if (this.HaveFallData)
                    Writer.UnalignedWriteBit(this.HaveFallTransferDirection);

                Writer.UnalignedWriteBit(!this.HaveSplineElevation);
            }

            if (this.HaveGameObjectPosition)
            {
                fixed (byte* bytes = this.TransportGuid.Bytes)
                {
                    Writer
                        .UnalignedWriteBit(bytes[1] != 0)
                        .UnalignedWriteBit(this.HaveTransportTime3)
                        .UnalignedWriteBit(bytes[3] != 0)
                        .UnalignedWriteBit(bytes[2] != 0)
                        .UnalignedWriteBit(bytes[6] != 0)
                        .UnalignedWriteBit(bytes[5] != 0)
                        .UnalignedWriteBit(bytes[0] != 0)
                        .UnalignedWriteBit(bytes[4] != 0)
                        .UnalignedWriteBit(this.HaveTransportTime2)
                        .UnalignedWriteBit(bytes[7] != 0);
                }
            }

            // TODO: shorts here

            if (this.HaveAttackingTarget)
            {
                fixed (byte* bytes = this.AttackingTarget.Bytes)
                {
                    Writer
                        .UnalignedWriteBit(bytes[3] != 0)
                        .UnalignedWriteBit(bytes[4] != 0)
                        .UnalignedWriteBit(bytes[6] != 0)
                        .UnalignedWriteBit(bytes[0] != 0)
                        .UnalignedWriteBit(bytes[1] != 0)
                        .UnalignedWriteBit(bytes[7] != 0)
                        .UnalignedWriteBit(bytes[5] != 0)
                        .UnalignedWriteBit(bytes[2] != 0);
                }
            }

            Writer.FlushUnalignedBits();

            foreach (var val in this.UnkUInt32)
                Writer.WriteUInt32(val);

            if (this.HavePosition)
            {
                Writer
                    .WriteSingle(this.Position.Z)
                    .WriteSingle(this.Orientation)
                    .WriteSingle(this.Position.X)
                    .WriteSingle(this.Position.Y);
            }

            if (this.HaveVehicleData)
            {
                Writer
                    .WriteUInt32(this.VehicleId)
                    .WriteSingle(this.VehicleAimAdjustement);
            }

            if (this.HaveGameObjectPosition)
            {
                fixed (byte* bytes = this.TransportGuid.Bytes)
                {
                    Writer
                        .WriteXorByte(bytes[1])
                        .WriteXorByte(bytes[4])
                        .WriteSingle(this.TransportPosition.Z);

                    if (this.HaveTransportTime3)
                        Writer.WriteUInt32(this.TransportTime3);

                    Writer.WriteUInt32(this.TransportTime);

                    Writer
                        .WriteXorByte(bytes[5])
                        .WriteXorByte(bytes[6])
                        .WriteSingle(this.TransportPosition.X)
                        .WriteXorByte(bytes[2]);

                    if (this.HaveTransportTime2)
                        Writer.WriteUInt32(this.TransportTime2);

                    Writer
                        .WriteSByte(this.TransportSeat)
                        .WriteXorByte(bytes[3])
                        .WriteSingle(this.TransportPosition.Y)
                        .WriteSingle(this.TransportFacing)
                        .WriteXorByte(bytes[7])
                        .WriteXorByte(bytes[0]);
                }
            }

            if (this.Living)
            {
                if (this.HaveSpline2)
                {
                    if (this.HaveSpline)
                    {
                        foreach (var point in this.Spline.Points)
                            Writer.WriteSingle(point.Y).WriteSingle(point.X).WriteSingle(point.Z);

                        if (this.Spline.HaveDurationMultiplier)
                        {
                            Writer.WriteSingle(this.Spline.DurationMultiplier);
                        }

                        Writer.WriteSingle(this.Spline.UnknownFloat2);

                        if (this.Spline.SplineType == SplineType.FacingTarget)
                        {
                            fixed (byte* bytes = this.Spline.FacingTarget.Bytes)
                            {
                                Writer
                                    .WriteXorByte(bytes[3])
                                    .WriteXorByte(bytes[4])
                                    .WriteXorByte(bytes[5])
                                    .WriteXorByte(bytes[7])
                                    .WriteXorByte(bytes[2])
                                    .WriteXorByte(bytes[0])
                                    .WriteXorByte(bytes[6])
                                    .WriteXorByte(bytes[1]);
                            }
                        }

                        if (this.Spline.HaveUnknown1)
                        {
                            Writer.WriteUInt32(this.Spline.Unknown1);
                        }

                        Writer.WriteSingle(this.Spline.UnknownFloat3);
                        Writer.WriteUInt32(this.Spline.Unknown2);

                        if (this.Spline.SplineType == SplineType.FacingSpot)
                        {
                            Writer
                                .WriteSingle(this.Spline.FacingSpot.Y)
                                .WriteSingle(this.Spline.FacingSpot.Z)
                                .WriteSingle(this.Spline.FacingSpot.X);
                        }

                        Writer.WriteUInt32(this.Spline.CurrentTime);

                        if (this.Spline.SplineType == SplineType.FacingAngle)
                            Writer.WriteSingle(this.Spline.FacingAngle);
                    }

                    Writer
                        .WriteSingle(this.Spline.EndPoint.Z)
                        .WriteSingle(this.Spline.EndPoint.Y)
                        .WriteUInt32(this.Spline.FullTime)
                        .WriteSingle(this.Spline.EndPoint.X);
                }

                Writer.WriteSingle(this.Speeds[8]);

                // Transport Data
                if (this.HaveTransportData)
                {
                    fixed (byte* bytes = this.TransportGuid.Bytes)
                    {
                        Writer
                            .WriteXorByte(bytes[4])
                            .WriteSingle(this.TransportPosition.Z)
                            .WriteXorByte(bytes[7])
                            .WriteXorByte(bytes[5])
                            .WriteXorByte(bytes[1])
                            .WriteSingle(this.TransportPosition.X)
                            .WriteXorByte(bytes[3])
                            .WriteXorByte(bytes[6]);

                        if (this.HaveTransportTime3)
                            Writer.WriteUInt32(this.TransportTime3);

                        Writer
                            .WriteSingle(this.TransportPosition.Y)
                            .WriteSByte(this.TransportSeat)
                            .WriteSingle(this.TransportFacing);

                        if (this.HaveTransportTime2)
                            Writer.WriteUInt32(this.TransportTime2);

                        Writer
                            .WriteXorByte(bytes[2])
                            .WriteUInt32(this.TransportTime)
                            .WriteXorByte(bytes[0]);
                    }
                }

                Writer
                    .WriteSingle(this.Speeds[7])
                    .WriteSingle(this.Position.X);

                if (this.HavePitch)
                    Writer.WriteSingle(this.Pitch);

                // Fall Data
                if (this.HaveFallData)
                {
                    Writer.WriteUInt32(this.FallTime);
                    if (this.HaveFallTransferDirection)
                    {
                        Writer
                            .WriteSingle(this.FallSinAngle)
                            .WriteSingle(this.FallHorizontalSpeed)
                            .WriteSingle(this.FallCosAngle);
                    }
                    Writer.WriteSingle(this.FallVerticalSpeed);
                }

                Writer
                    .WriteXorByte(p_guid.Bytes[7])
                    .WriteSingle(this.Speeds[4])
                    .WriteXorByte(p_guid.Bytes[0])
                    .WriteXorByte(p_guid.Bytes[5]);

                if (this.TimeStamp != 0)
                    Writer.WriteUInt32(this.TimeStamp);

                Writer
                    .WriteSingle(this.Position.Z)
                    .WriteSingle(this.Speeds[6])
                    .WriteXorByte(p_guid.Bytes[1])
                    .WriteSingle(this.Speeds[2])
                    .WriteSingle(this.Speeds[5])
                    .WriteSingle(this.Speeds[3])
                    .WriteSingle(this.Speeds[0])
                    .WriteXorByte(p_guid.Bytes[3])
                    .WriteXorByte(p_guid.Bytes[4])
                    .WriteXorByte(p_guid.Bytes[2])
                    .WriteXorByte(p_guid.Bytes[6]);

                if (this.HaveSplineElevation)
                    Writer.WriteSingle(this.SplineElevation);

                Writer.WriteSingle(this.Position.Y);
                if (this.Orientation != 0.0f)
                    Writer.WriteSingle(this.Orientation);
                Writer.WriteSingle(this.Speeds[1]);
            }

            // floats here

            // transport time
            if (this.HaveTransportTime)
                Writer.WriteUInt32(this.TransportTime);

            // shorts here

            // go rotation?
            if (this.HaveGameObjectRotation)
                Writer.WriteUInt64(this.GameObjectRotation.Pack());

            // target guid?
            if (this.HaveAttackingTarget)
            {
                fixed (byte* bytes = this.AttackingTarget.Bytes)
                {
                    Writer
                        .WriteXorByte(bytes[3])
                        .WriteXorByte(bytes[5])
                        .WriteXorByte(bytes[0])
                        .WriteXorByte(bytes[7])
                        .WriteXorByte(bytes[2])
                        .WriteXorByte(bytes[4])
                        .WriteXorByte(bytes[6])
                        .WriteXorByte(bytes[1]);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            ToString(builder);
            return builder.ToString();
        }

        public new void ToString(StringBuilder builder)
        {
            builder
                .Append("Flags: ").AppendLine(this.Flags.ToString())
                .Append("Flags2: ").AppendLine(this.Flags2.ToString())
                .Append("Bools: ");

            if (this.HaveAttackingTarget)
                builder.Append("Attacking Target, ");
            if (this.HaveFallData)
                builder.Append("Fall Data, ");
            if (this.HaveFallTransferDirection)
                builder.Append("Fall TransferDirection, ");
            if (this.HaveGameObjectPosition)
                builder.Append("GO Position, ");
            if (this.HaveGameObjectRotation)
                builder.Append("GO Rotation, ");
            if (this.HavePitch)
                builder.Append("Pitch, ");
            if (this.HavePosition)
                builder.Append("Position, ");
            if (this.HaveSpline)
                builder.Append("Spline, ");
            if (this.HaveSpline2)
                builder.Append("Spline2, ");
            if (this.HaveSplineElevation)
                builder.Append("Spline Elevation, ");
            if (this.HaveTransportData)
                builder.Append("Transport Data, ");
            if (this.HaveTransportTime)
                builder.Append("Transport Time, ");
            if (this.HaveTransportTime2)
                builder.Append("Transport Time 2, ");
            if (this.HaveTransportTime3)
                builder.Append("Transport Time 3, ");
            if (this.HaveVehicleData)
                builder.Append("Vehicle Data, ");
            if (this.Living)
                builder.Append("Living, ");
            if (this.SelfTarget)
                builder.Append("Self Target");

            builder.AppendLine();

            if (this.HavePosition || this.Living)
            {
                builder
                    .Append("Position: ").Append(this.Position.ToString())
                    .Append(" Orientation: ").Append(this.Orientation).AppendLine();
            }

            if (this.HaveGameObjectPosition || this.HaveTransportData)
            {
                builder
                    .Append("Transport: ").Append(this.TransportGuid.ToString()).AppendLine()
                    .Append(" Pos: ").Append(this.TransportPosition)
                    .Append(" Facing: ").Append(this.TransportFacing).AppendLine()
                    .Append(" Seat: ").Append(this.TransportSeat).AppendLine();
            }

            if (this.HaveTransportTime)
                builder.Append(" Time: ").Append(this.TransportTime).AppendLine();
            if (this.HaveTransportTime2)
                builder.Append(" Time2: ").Append(this.TransportTime2).AppendLine();
            if (this.HaveTransportTime3)
                builder.Append(" Time3: ").Append(this.TransportTime3).AppendLine();

            if (this.Living)
            {
                if (this.HaveSpline2)
                {
                    builder.Append("Spline:");
                    if (this.HaveSpline)
                    {
                        builder
                            .Append(" Flags: ").Append(this.Spline.Flags.ToString()).AppendLine()
                            .Append(" Mode: ").Append(this.Spline.SplineMode.ToString())
                            .Append(" Type: ").Append(this.Spline.SplineType.ToString()).AppendLine()
                            .Append(" Points:").AppendLine();

                        foreach (var point in this.Spline.Points)
                            builder.AppendLine(point.ToString());

                        if (this.Spline.HaveDurationMultiplier)
                            builder.Append(" Duration Multiplier: ").Append(this.Spline.DurationMultiplier).AppendLine();

                        builder.Append(" UnknownFloat2: ").Append(this.Spline.UnknownFloat2).AppendLine();

                        if (this.Spline.SplineType == SplineType.FacingTarget)
                            builder.Append(" Facing Target: ").Append(this.Spline.FacingTarget.ToString()).AppendLine();

                        if (this.Spline.HaveUnknown1)
                            builder.Append(" Unknown1: ").Append(this.Spline.Unknown1).AppendLine();

                        builder.Append(" UnknownFloat3: ").Append(this.Spline.UnknownFloat3).AppendLine();
                        builder.Append(" Unknown2: ").Append(this.Spline.Unknown2).AppendLine();

                        if (this.Spline.SplineType == SplineType.FacingSpot)
                            builder.Append(" Facing Spot: ").Append(this.Spline.FacingSpot.ToString()).AppendLine();

                        builder.Append(" Time: ").Append(this.Spline.CurrentTime).AppendLine();

                        if (this.Spline.SplineType == SplineType.FacingAngle)
                            builder.Append(" Facing Angle: ").Append(this.Spline.FacingAngle).AppendLine();
                    }

                    builder.Append(" Full Time: ").Append(this.Spline.FullTime).AppendLine();
                    builder.Append(" End Point: ").Append(this.Spline.EndPoint.ToString()).AppendLine();
                }

                for (int i = 0; i < (int)MoveTypes.Total; i++)
			        builder.Append(((MoveTypes)i).ToString()).Append(" Speed: ").Append(this.Speeds[i]).AppendLine();

                if (this.HavePitch)
                    builder.Append("Pitch: ").Append(this.Pitch).AppendLine();

                // Fall Data
                if (this.HaveFallData)
                {
                    builder.Append("Fall Time: ").Append(this.FallTime).AppendLine();

                    if (this.HaveFallTransferDirection)
                    {
                        builder
                            .Append("Fall Sin Angle: ").Append(this.FallSinAngle).AppendLine()
                            .Append("Fall Cos Angle: ").Append(this.FallCosAngle).AppendLine()
                            .Append("Fall Horizontal Speed: ").Append(this.FallHorizontalSpeed).AppendLine();
                    }
                    builder
                        .Append("Fall Vertical Speed: ").Append(this.FallVerticalSpeed).AppendLine();
                }

                if (this.TimeStamp != 0)
                    builder.Append("Timestamp: ").Append(this.TimeStamp).AppendLine();

                if (this.HaveSplineElevation)
                    builder.Append("Spline Elevation: ").Append(this.SplineElevation).AppendLine();
            }

            if (this.HaveGameObjectRotation)
                builder.Append("Rotation: ").Append(this.GameObjectRotation.ToString()).AppendLine();

            if (this.HaveAttackingTarget)
                builder.Append("Attacking Target: ").Append(this.AttackingTarget.ToString()).AppendLine();

            if (this.UnkUInt32.Length > 0)
            {
                builder.Append("Unk UInt32s: ");
                foreach (var val in this.UnkUInt32)
                    builder.Append(val);
                builder.AppendLine();
            }

            if (this.HaveVehicleData)
            {
                builder
                    .Append("Vehicle Id: ").Append(this.VehicleId)
                    .Append(" Aim Adjustment: ").Append(this.VehicleAimAdjustement).AppendLine();
            }
        }

        public void SetStatus(MovementStatus status)
        {
            base.HaveFallData = status.HaveFallData;
            base.HaveFallTransferDirection = status.HaveFallTransferDirection;
            base.HavePitch = status.HavePitch;
            base.HaveSpline = status.HaveSpline;
            base.HaveSplineElevation = status.HaveSplineElevation;
            base.HaveTransportData = status.HaveTransportData;
            base.HaveTransportTime2 = status.HaveTransportTime2;
            base.HaveTransportTime3 = status.HaveTransportTime3;
            base.FallCosAngle = status.FallCosAngle;
            base.FallHorizontalSpeed = status.FallHorizontalSpeed;
            base.FallSinAngle = status.FallSinAngle;
            base.FallTime = status.FallTime;
            base.FallVerticalSpeed = status.FallVerticalSpeed;
            base.Flags = status.Flags;
            base.Flags2 = status.Flags2;
            base.Pitch = status.Pitch;
            base.Position = status.Position;
            base.SplineElevation = status.SplineElevation;
            base.TimeStamp = status.TimeStamp;
            base.TransportFacing = status.TransportFacing;
            base.TransportGuid = status.TransportGuid;
            base.TransportPosition = status.TransportPosition;
            base.TransportSeat = status.TransportSeat;
            base.TransportTime = status.TransportTime;
            base.TransportTime2 = status.TransportTime2;
            base.TransportTime3 = status.TransportTime3;
        }
    }
}
