using System;
using System.Collections.Generic;
using System.Text;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Game
{
    [Flags]
    public enum SplineFlags : uint
    {
        None            = 0x00000000,
        Forward         = 0x00000001,
        Backward        = 0x00000002,
        StrafeLeft      = 0x00000004,
        StrafeRight     = 0x00000008,
        TurnLeft        = 0x00000010,
        TurnRight       = 0x00000020,
        Falling         = 0x00000040,
        NoSpline        = 0x00000080,
        Flying          = 0x00000200,
        CatMullRom      = 0x00000800,
        SmoothPathing   = 0x00100000,
        Animation       = 0x01000000,
        Parabolic       = 0x02000000,

        WalkMode        = 0x00000200,
        RotationFixed   = 0x00000800,
        FinalPoint      = 0x00001000,
        FinalTarget     = 0x00002000,
        FinalOrient     = 0x00004000,
        Cyclic          = 0x00010000,
        EnterCycle      = 0x00020000,
        Unk4            = 0x00080000,
        Unk5            = 0x00100000,
        Unk6            = 0x00200000,
        Unk7            = 0x00400000,
        Unk8            = 0x00800000,
        InvertOrient    = 0x01000000,
        Unk11           = 0x04000000,
        Unk12           = 0x08000000, // related monster move vectors
    }

    public enum SplineMode : byte
    {
        Linear      = 0,
        CatmullRom  = 1,
        Bezier3     = 2,
    }

    public enum SplineType : byte
    {
        Normal          = 0,
        Stop            = 1,
        FacingSpot      = 2,
        FacingTarget    = 3,
        FacingAngle     = 4,
    }
    
    public class SplineInfo
    {
        public SplineFlags  Flags;
        public Vector3      FinalPoint;
        public WowGuid      FinalGuid;
        public float        FinalRotation;
        public uint         CurrentTime;
        public uint         FullTime;
        public bool         HaveUnknown1;
        public uint         Unknown1;
        public bool         HaveDurationMultiplier;
        public float        DurationMultiplier;
        public float        UnknownFloat2;
        public float        UnknownFloat3;
        public uint         Unknown2;
        public SplineMode   SplineMode;
        public SplineType   SplineType;
        public Vector3      EndPoint;

        public WowGuid      FacingTarget;
        public Vector3      FacingSpot;
        public float        FacingAngle;

        public List<Vector3> Points = new List<Vector3>();

        public override string ToString()
        {
            var builder = new StringBuilder();
            ToString(builder);
            return builder.ToString();
        }

        public void ToString(StringBuilder builder)
        {
            builder.AppendLine("  SplineFlags: " + Flags);

            if ((Flags & SplineFlags.FinalPoint) != SplineFlags.None)
                builder.AppendLine("  Final Point: " + FinalPoint);

            if ((Flags & SplineFlags.FinalTarget) != SplineFlags.None)
                builder.AppendLine("  Final Target: " + FinalGuid);

            if ((Flags & SplineFlags.FinalOrient) != SplineFlags.None)
                builder.AppendLine("  Final Orient: " + FinalRotation);

            builder.AppendLine("  Current Time: " + CurrentTime);
            builder.AppendLine("  Full Time: " + FullTime);
            builder.AppendLine("  Unk1: " + Unknown1);
            builder.AppendLine("  Duration Multiplier: " + DurationMultiplier);
            builder.AppendLine("  UnkFloat2: " + UnknownFloat2);
            builder.AppendLine("  UnkFloat3: " + UnknownFloat3);
            builder.AppendLine("  Unk2: " + Unknown2);
            builder.AppendLine("  Point Count: " + Points.Count);

            for (int i = 0; i < Points.Count; ++i)
                builder.AppendLine("   Point: " + Points[i]);

            builder.AppendLine("  Spline Mode: " + SplineMode);
            builder.AppendLine("  End Point: " + EndPoint);
        }
    }

    public static partial class StreamHandlerWriterExtensions
    {
        /// <summary>
        /// Reads the spline info from the current stream,
        /// advancing the current position by spline info's size.
        /// </summary>
        public static SplineInfo ReadSplineInfo(this StreamHandler Reader)
        {
            var info = new SplineInfo();

            var flags = info.Flags = (SplineFlags)Reader.ReadUInt32();

            if ((flags & SplineFlags.FinalPoint) != SplineFlags.None)
                info.FinalPoint = Reader.ReadVector3();

            if ((flags & SplineFlags.FinalTarget) != SplineFlags.None)
                info.FinalGuid = Reader.ReadGuid();

            if ((flags & SplineFlags.FinalOrient) != SplineFlags.None)
                info.FinalRotation = Reader.ReadSingle();

            info.CurrentTime = Reader.ReadUInt32();
            info.FullTime = Reader.ReadUInt32();
            info.Unknown1 = Reader.ReadUInt32();
            info.DurationMultiplier = Reader.ReadSingle();
            info.UnknownFloat2 = Reader.ReadSingle();
            info.UnknownFloat3 = Reader.ReadSingle();
            info.Unknown2 = Reader.ReadUInt32();
            int count = Reader.ReadInt32();

            var points = info.Points;
            points.Capacity = count;
            for (int i = 0; i < count; ++i)
                points.Add(Reader.ReadVector3());

            if ((flags & (SplineFlags.Flying | SplineFlags.CatMullRom)) != 0)
            {
                if ((flags & SplineFlags.Cyclic) != 0)
                {
                    points.RemoveAt(0);

                    if ((flags & SplineFlags.EnterCycle) != 0)
                        points.RemoveAt(0);

                    points.RemoveAt(points.Count - 1);
                    points.RemoveAt(points.Count - 1);
                }
                else
                {
                    points.RemoveAt(0);
                    points.RemoveAt(points.Count - 1);
                }
            }

            info.SplineMode = (SplineMode)Reader.ReadByte();
            info.EndPoint = Reader.ReadVector3();

            return info;
        }

        /// <summary>
        /// Writes the spline info into the current stream,
        /// advancing the current position by spline info's size.
        /// </summary>
        public static void WriteSplineInfo(this StreamHandler Writer, SplineInfo Info)
        {
            Writer.WriteUInt32((uint)Info.Flags);

            if ((Info.Flags & SplineFlags.FinalPoint) != SplineFlags.None)
                Writer.WriteStruct<Vector3>(Info.FinalPoint);

            if ((Info.Flags & SplineFlags.FinalTarget) != SplineFlags.None)
                Writer.WriteGuid(Info.FinalGuid);

            if ((Info.Flags & SplineFlags.FinalOrient) != SplineFlags.None)
                Writer.WriteSingle(Info.FinalRotation);

            Writer.WriteUInt32(Info.CurrentTime);
            Writer.WriteUInt32(Info.FullTime);
            Writer.WriteUInt32(Info.Unknown1);
            Writer.WriteSingle(Info.DurationMultiplier);
            Writer.WriteSingle(Info.UnknownFloat2);
            Writer.WriteSingle(Info.UnknownFloat3);
            Writer.WriteUInt32(Info.Unknown2);
            Writer.WriteInt32(Info.Points.Count);

            for (int i = 0; i < Info.Points.Count; ++i)
                Writer.WriteStruct<Vector3>(Info.Points[i]);

            Writer.WriteByte((byte)Info.SplineMode);
            Writer.WriteStruct<Vector3>(Info.EndPoint);
        }
    };
}
