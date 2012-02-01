
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveSetFacing : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_FACING; }
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
MovementStatusElements.GuidByte3, // 66D910
MovementStatusElements.GuidByte1, // 66D919
MovementStatusElements.GuidByte0, // 66D926
MovementStatusElements.GuidByte7, // 66D934
MovementStatusElements.Flags2, // 66D942
MovementStatusElements.HaveSpline, // 66D959
MovementStatusElements.GuidByte4, // 66D97B
MovementStatusElements.Flags, // 66D9AD
MovementStatusElements.GuidByte6, // 66D9B6
MovementStatusElements.GuidByte5, // 66D9E5
MovementStatusElements.GuidByte2, // 66DA0A
MovementStatusElements.HaveFallData, // 66DA31
MovementStatusElements.HaveFallTransferDirection, // 66DA56
MovementStatusElements.HaveTransportData, // 66DA7C
MovementStatusElements.TransportGuidByte6, // 66DAA3
MovementStatusElements.TransportGuidByte3, // 66DAD7
MovementStatusElements.TransportGuidByte7, // 66DB08
MovementStatusElements.TransportGuidByte4, // 66DB39
MovementStatusElements.TransportGuidByte1, // 66DB6A
MovementStatusElements.TransportGuidByte0, // 66DB9B
MovementStatusElements.TransportGuidByte2, // 66DBCB
MovementStatusElements.TransportGuidByte5, // 66DBFC
MovementStatusElements.TransportHaveTime3, // 66DC2F
MovementStatusElements.TransportHaveTime2, // 66DC5B
MovementStatusElements.HavePitch, // 66DC7B
MovementStatusElements.HaveSplineElev, // 66DC9B
MovementStatusElements.PositionX, // 66DCC6
MovementStatusElements.PositionY, // 66DCD7
MovementStatusElements.PositionZ, // 66DCE5
MovementStatusElements.PositionO, // 66DCF3
MovementStatusElements.Timestamp, // 66DD04
MovementStatusElements.FallVerticalSpeed, // 66DD15
MovementStatusElements.FallTime, // 66DD37
MovementStatusElements.FallHorizontalSpeed, // 66DD68
MovementStatusElements.FallCosAngle, // 66DD8E
MovementStatusElements.FallSinAngle, // 66DD9C
MovementStatusElements.GuidByte2_2, // 66DDBA
MovementStatusElements.GuidByte4_2, // 66DDCE
MovementStatusElements.TransportTime, // 66DDE8
MovementStatusElements.TransportPositionX, // 66DDFA
MovementStatusElements.TransportPositionY, // 66DE09
MovementStatusElements.TransportPositionZ, // 66DE18
MovementStatusElements.TransportPositionO, // 66DE33
MovementStatusElements.TransportSeat, // 66DE54
MovementStatusElements.TransportGuidByte3_2, // 66DE68
MovementStatusElements.TransportGuidByte1_2, // 66DE96
MovementStatusElements.TransportTime3, // 66DEE2
MovementStatusElements.TransportGuidByte6_2, // 66DEF6
MovementStatusElements.TransportGuidByte0_2, // 66DF23
MovementStatusElements.TransportGuidByte5_2, // 66DF4F
MovementStatusElements.TransportTime2, // 66DF9C
MovementStatusElements.TransportGuidByte7_2, // 66DFB0
MovementStatusElements.TransportGuidByte4_2, // 66DFDE
MovementStatusElements.TransportGuidByte2_2, // 66E00B
MovementStatusElements.GuidByte3_2, // 66E03C
MovementStatusElements.GuidByte7_2, // 66E050
MovementStatusElements.Pitch, // 66E05D
MovementStatusElements.GuidByte5_2, // 66E07A
MovementStatusElements.GuidByte1_2, // 66E08E
MovementStatusElements.GuidByte6_2, // 66E0A2
MovementStatusElements.SplineElev, // 66E0B2
MovementStatusElements.GuidByte0_2, // 66E0D5
                };
            }
        }
    }
}
