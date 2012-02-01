
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    internal sealed class MoveStartForward : RegularMovementPacket
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
MovementStatusElements.GuidByte0, // 68F4CC
MovementStatusElements.HaveSpline, // 68F4D7
MovementStatusElements.GuidByte5, // 68F4DD
MovementStatusElements.GuidByte3, // 68F4EA
MovementStatusElements.GuidByte4, // 68F4F5
MovementStatusElements.GuidByte2, // 68F502
MovementStatusElements.GuidByte7, // 68F510
MovementStatusElements.Flags2, // 68F521
MovementStatusElements.Flags, // 68F534
MovementStatusElements.GuidByte6, // 68F53D
MovementStatusElements.GuidByte1, // 68F56C
MovementStatusElements.HavePitch, // 68F593
MovementStatusElements.HaveFallData, // 68F5B5
MovementStatusElements.HaveFallTransferDirection, // 68F5DA
MovementStatusElements.HaveTransportData, // 68F600
MovementStatusElements.TransportGuidByte6, // 68F627
MovementStatusElements.TransportGuidByte3, // 68F65B
MovementStatusElements.TransportGuidByte7, // 68F68C
MovementStatusElements.TransportGuidByte4, // 68F6BD
MovementStatusElements.TransportGuidByte1, // 68F6EE
MovementStatusElements.TransportGuidByte0, // 68F71F
MovementStatusElements.TransportGuidByte2, // 68F74F
MovementStatusElements.TransportGuidByte5, // 68F780
MovementStatusElements.TransportHaveTime3, // 68F7B3
MovementStatusElements.TransportHaveTime2, // 68F7DF
MovementStatusElements.HaveSplineElev, // 68F7FF
MovementStatusElements.Timestamp, // 68F830
MovementStatusElements.PositionX, // 68F838
MovementStatusElements.PositionO, // 68F862
MovementStatusElements.GuidByte7_2, // 68F87C
MovementStatusElements.Pitch, // 68F889
MovementStatusElements.GuidByte1_2, // 68F8A6
MovementStatusElements.GuidByte2_2, // 68F8BA
MovementStatusElements.FallVerticalSpeed, // 68F8CB
MovementStatusElements.FallTime, // 68F8ED
MovementStatusElements.FallHorizontalSpeed, // 68F91E
MovementStatusElements.FallCosAngle, // 68F944
MovementStatusElements.FallSinAngle, // 68F952
MovementStatusElements.GuidByte3_2, // 68F970
MovementStatusElements.GuidByte5_2, // 68F984
MovementStatusElements.GuidByte0_2, // 68F998
MovementStatusElements.GuidByte6_2, // 68F9AC
MovementStatusElements.TransportTime, // 68F9C6
MovementStatusElements.TransportPositionX, // 68F9D8
MovementStatusElements.TransportPositionO, // 68FA11
MovementStatusElements.TransportSeat, // 68FA32
MovementStatusElements.TransportGuidByte3_2, // 68FA46
MovementStatusElements.TransportGuidByte1_2, // 68FA74
MovementStatusElements.TransportTime3, // 68FAC1
MovementStatusElements.TransportGuidByte6_2, // 68FAD5
MovementStatusElements.TransportGuidByte0_2, // 68FB03
MovementStatusElements.TransportGuidByte5_2, // 68FB2E
MovementStatusElements.TransportTime2, // 68FB7B
MovementStatusElements.TransportGuidByte7_2, // 68FB8F
MovementStatusElements.TransportGuidByte4_2, // 68FBBD
MovementStatusElements.TransportGuidByte2_2, // 68FBEB
MovementStatusElements.GuidByte4_2, // 68FC1B
MovementStatusElements.SplineElev, // 68FC29
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_FORWARD; }
        }
    }
}
