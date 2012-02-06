
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveSetWalkMode : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_WALK_MODE; }
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
MovementStatusElements.Flags2, // 69F6F7
MovementStatusElements.GuidByte2, // 69F709
MovementStatusElements.GuidByte5, // 69F738
MovementStatusElements.Flags, // 69F76A
MovementStatusElements.GuidByte4, // 69F773
MovementStatusElements.HaveSpline, // 69F7A4
MovementStatusElements.GuidByte6, // 69F7C7
MovementStatusElements.GuidByte0, // 69F7EC
MovementStatusElements.GuidByte1, // 69F811
MovementStatusElements.GuidByte3, // 69F836
MovementStatusElements.GuidByte7, // 69F85B
MovementStatusElements.HaveTransportData, // 69F882
MovementStatusElements.TransportGuidByte6, // 69F8A9
MovementStatusElements.TransportGuidByte3, // 69F8DD
MovementStatusElements.TransportGuidByte7, // 69F90E
MovementStatusElements.TransportGuidByte4, // 69F93F
MovementStatusElements.TransportGuidByte1, // 69F970
MovementStatusElements.TransportGuidByte0, // 69F9A1
MovementStatusElements.TransportGuidByte2, // 69F9D1
MovementStatusElements.TransportGuidByte5, // 69FA02
MovementStatusElements.TransportHaveTime3, // 69FA35
MovementStatusElements.TransportHaveTime2, // 69FA61
MovementStatusElements.HaveSplineElev, // 69FA81
MovementStatusElements.HaveFallData, // 69FAA4
MovementStatusElements.HaveFallDirection, // 69FAC9
MovementStatusElements.HavePitch, // 69FAEF
MovementStatusElements.PositionO, // 69FB17
MovementStatusElements.Timestamp, // 69FB2B
MovementStatusElements.PositionX, // 69FB33
MovementStatusElements.PositionY, // 69FB41
MovementStatusElements.PositionZ, // 69FB4F
MovementStatusElements.TransportTime, // 69FB6C
MovementStatusElements.TransportPositionX, // 69FB80
MovementStatusElements.TransportPositionY, // 69FB8F
MovementStatusElements.TransportPositionZ, // 69FB9E
MovementStatusElements.TransportPositionO, // 69FBB9
MovementStatusElements.TransportSeat, // 69FBDA
MovementStatusElements.TransportGuidByte3_2, // 69FBEE
MovementStatusElements.TransportGuidByte1_2, // 69FC1C
MovementStatusElements.TransportTime3, // 69FC69
MovementStatusElements.TransportGuidByte6_2, // 69FC7D
MovementStatusElements.TransportGuidByte0_2, // 69FCAB
MovementStatusElements.TransportGuidByte5_2, // 69FCD6
MovementStatusElements.TransportTime2, // 69FD23
MovementStatusElements.TransportGuidByte7_2, // 69FD37
MovementStatusElements.TransportGuidByte4_2, // 69FD65
MovementStatusElements.TransportGuidByte2_2, // 69FD93
MovementStatusElements.GuidByte2_2, // 69FDC3
MovementStatusElements.GuidByte6_2, // 69FDD7
MovementStatusElements.SplineElev, // 69FDE7
MovementStatusElements.GuidByte7_2, // 69FE0A
MovementStatusElements.GuidByte1_2, // 69FE1E
MovementStatusElements.GuidByte4_2, // 69FE32
MovementStatusElements.GuidByte3_2, // 69FE46
MovementStatusElements.FallVerticalSpeed, // 69FE57
MovementStatusElements.FallTime, // 69FE79
MovementStatusElements.FallHorizontalSpeed, // 69FEAA
MovementStatusElements.FallCosAngle, // 69FED0
MovementStatusElements.FallSinAngle, // 69FEDE
MovementStatusElements.Pitch, // 69FEF5
MovementStatusElements.GuidByte5_2, // 69FF12
MovementStatusElements.GuidByte0_2, // 69FF26
                };
            }
        }
    }
}
