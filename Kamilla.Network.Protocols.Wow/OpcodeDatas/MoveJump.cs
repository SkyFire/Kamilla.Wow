
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveJump : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_JUMP; }
        }

        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToServer; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte5, // 69222C
MovementStatusElements.GuidByte1, // 692238
MovementStatusElements.GuidByte6, // 692243
MovementStatusElements.Flags, // 692256
MovementStatusElements.GuidByte2, // 692263
MovementStatusElements.HaveSpline, // 692295
MovementStatusElements.GuidByte3, // 6922B7
MovementStatusElements.Flags2, // 6922EA
MovementStatusElements.GuidByte4, // 6922F3
MovementStatusElements.GuidByte0, // 692322
MovementStatusElements.GuidByte7, // 692347
MovementStatusElements.HaveFallData, // 69236E
MovementStatusElements.HaveFallDirection, // 692393
MovementStatusElements.HaveTransportData, // 6923B9
MovementStatusElements.TransportGuidByte6, // 6923E0
MovementStatusElements.TransportGuidByte3, // 692414
MovementStatusElements.TransportGuidByte7, // 692445
MovementStatusElements.TransportGuidByte4, // 692476
MovementStatusElements.TransportGuidByte1, // 6924A7
MovementStatusElements.TransportGuidByte0, // 6924D8
MovementStatusElements.TransportGuidByte2, // 692508
MovementStatusElements.TransportGuidByte5, // 692539
MovementStatusElements.TransportHaveTime3, // 69256C
MovementStatusElements.TransportHaveTime2, // 692598
MovementStatusElements.HaveSplineElev, // 6925B8
MovementStatusElements.HavePitch, // 6925DB
MovementStatusElements.PositionO, // 692603
MovementStatusElements.PositionX, // 692614
MovementStatusElements.PositionY, // 692622
MovementStatusElements.PositionZ, // 692630
MovementStatusElements.Timestamp, // 692641
MovementStatusElements.GuidByte1_2, // 692655
MovementStatusElements.FallVerticalSpeed, // 692666
MovementStatusElements.FallTime, // 692688
MovementStatusElements.FallHorizontalSpeed, // 6926B9
MovementStatusElements.FallCosAngle, // 6926DF
MovementStatusElements.FallSinAngle, // 6926ED
MovementStatusElements.TransportTime, // 69270B
MovementStatusElements.TransportPositionX, // 692720
MovementStatusElements.TransportPositionY, // 69272F
MovementStatusElements.TransportPositionZ, // 69273E
MovementStatusElements.TransportPositionO, // 692759
MovementStatusElements.TransportSeat, // 69277A
MovementStatusElements.TransportGuidByte3_2, // 69278E
MovementStatusElements.TransportGuidByte1_2, // 6927BB
MovementStatusElements.TransportTime3, // 692808
MovementStatusElements.TransportGuidByte6_2, // 69281C
MovementStatusElements.TransportGuidByte0_2, // 69284A
MovementStatusElements.TransportGuidByte5_2, // 692876
MovementStatusElements.TransportTime2, // 6928C2
MovementStatusElements.TransportGuidByte7_2, // 6928D6
MovementStatusElements.TransportGuidByte4_2, // 692903
MovementStatusElements.TransportGuidByte2_2, // 692931
MovementStatusElements.GuidByte6_2, // 692962
MovementStatusElements.GuidByte4_2, // 692976
MovementStatusElements.SplineElev, // 692986
MovementStatusElements.GuidByte0_2, // 6929A9
MovementStatusElements.Pitch, // 6929B6
MovementStatusElements.GuidByte5_2, // 6929D3
MovementStatusElements.GuidByte3_2, // 6929E7
MovementStatusElements.GuidByte7_2, // 6929FB
MovementStatusElements.GuidByte2_2, // 692A0F
                };
            }
        }
    }
}
