
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    internal sealed class MoveSwimStop : RegularMovementPacket
    {
        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToServer; }
        }

        protected override RegularMovementPacket.MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 695A7C
MovementStatusElements.GuidByte3, // 695A88
MovementStatusElements.Flags2, // 695AA5
MovementStatusElements.GuidByte5, // 695AAA
MovementStatusElements.GuidByte6, // 695AD8
MovementStatusElements.GuidByte4, // 695AFD
MovementStatusElements.HaveSpline, // 695B24
MovementStatusElements.GuidByte2, // 695B45
MovementStatusElements.GuidByte7, // 695B6A
MovementStatusElements.GuidByte0, // 695B8F
MovementStatusElements.Flags, // 695BC4
MovementStatusElements.HaveSplineElev, // 695BD4
MovementStatusElements.HavePitch, // 695BF7
MovementStatusElements.HaveFallData, // 695C17
MovementStatusElements.HaveFallTransferDirection, // 695C3C
MovementStatusElements.HaveTransportData, // 695C62
MovementStatusElements.TransportGuidByte6, // 695C8F
MovementStatusElements.TransportGuidByte3, // 695CC3
MovementStatusElements.TransportGuidByte7, // 695CF4
MovementStatusElements.TransportGuidByte4, // 695D25
MovementStatusElements.TransportGuidByte1, // 695D56
MovementStatusElements.TransportGuidByte0, // 695D87
MovementStatusElements.TransportGuidByte2, // 695DB7
MovementStatusElements.TransportGuidByte5, // 695DE8
MovementStatusElements.TransportHaveTime3, // 695E1B
MovementStatusElements.TransportHaveTime2, // 695E47
MovementStatusElements.PositionO, // 695E6F
MovementStatusElements.PositionX, // 695E80
MovementStatusElements.PositionY, // 695E8E
MovementStatusElements.PositionZ, // 695E9C
MovementStatusElements.Timestamp, // 695EB0
MovementStatusElements.GuidByte2_2, // 695EB5
MovementStatusElements.GuidByte0_2, // 695EC9
MovementStatusElements.GuidByte6_2, // 695EDD
MovementStatusElements.SplineElev, // 695EF9
MovementStatusElements.Pitch, // 695F15
MovementStatusElements.GuidByte1_2, // 695F26
MovementStatusElements.GuidByte7_2, // 695F3A
MovementStatusElements.GuidByte4_2, // 695F4E
MovementStatusElements.FallVerticalSpeed, // 695F6B
MovementStatusElements.FallTime, // 695F90
MovementStatusElements.FallHorizontalSpeed, // 695FBE
MovementStatusElements.FallCosAngle, // 695FE4
MovementStatusElements.FallSinAngle, // 695FF2
MovementStatusElements.GuidByte3_2, // 696004
MovementStatusElements.TransportTime, // 69602B
MovementStatusElements.TransportPositionX, // 69603C
MovementStatusElements.TransportPositionY, // 69604B
MovementStatusElements.TransportPositionZ, // 69605A
MovementStatusElements.TransportPositionO, // 696075
MovementStatusElements.TransportSeat, // 696099
MovementStatusElements.TransportGuidByte3_2, // 6960AA
MovementStatusElements.TransportGuidByte1_2, // 6960D8
MovementStatusElements.TransportTime3, // 696128
MovementStatusElements.TransportGuidByte6_2, // 696139
MovementStatusElements.TransportGuidByte0_2, // 696167
MovementStatusElements.TransportGuidByte5_2, // 696192
MovementStatusElements.TransportTime2, // 6961E2
MovementStatusElements.TransportGuidByte7_2, // 6961F3
MovementStatusElements.TransportGuidByte4_2, // 696221
MovementStatusElements.TransportGuidByte2_2, // 69624F
MovementStatusElements.GuidByte5_2, // 696270
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_STOP_SWIM; }
        }
    }
}
