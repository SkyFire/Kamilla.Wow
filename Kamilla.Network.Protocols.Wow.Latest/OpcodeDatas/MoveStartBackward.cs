
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    internal sealed class MoveStartBackward : RegularMovementPacket
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
MovementStatusElements.GuidByte4, // 67EEAC
MovementStatusElements.GuidByte1, // 67EEB8
MovementStatusElements.GuidByte5, // 67EEC3
MovementStatusElements.Flags2, // 67EED7
MovementStatusElements.GuidByte3, // 67EEE4
MovementStatusElements.GuidByte6, // 67EF12
MovementStatusElements.GuidByte0, // 67EF37
MovementStatusElements.GuidByte2, // 67EF5C
MovementStatusElements.GuidByte7, // 67EF81
MovementStatusElements.Flags, // 67EFB2
MovementStatusElements.HaveSpline, // 67EFC6
MovementStatusElements.HaveFallData, // 67EFE9
MovementStatusElements.HaveFallTransferDirection, // 67F00E
MovementStatusElements.HaveTransportData, // 67F034
MovementStatusElements.TransportGuidByte6, // 67F05B
MovementStatusElements.TransportGuidByte3, // 67F08F
MovementStatusElements.TransportGuidByte7, // 67F0C0
MovementStatusElements.TransportGuidByte4, // 67F0F1
MovementStatusElements.TransportGuidByte1, // 67F122
MovementStatusElements.TransportGuidByte0, // 67F153
MovementStatusElements.TransportGuidByte2, // 67F183
MovementStatusElements.TransportGuidByte5, // 67F1B4
MovementStatusElements.TransportHaveTime3, // 67F1E7
MovementStatusElements.TransportHaveTime2, // 67F213
MovementStatusElements.HavePitch, // 67F233
MovementStatusElements.HaveSplineElev, // 67F253
MovementStatusElements.PositionX, // 67F27E
MovementStatusElements.Timestamp, // 67F2AE
MovementStatusElements.PositionO, // 67F2B6
MovementStatusElements.GuidByte0_2, // 67F2D0
MovementStatusElements.GuidByte5_2, // 67F2E4
MovementStatusElements.FallVerticalSpeed, // 67F2F5
MovementStatusElements.FallTime, // 67F317
MovementStatusElements.FallHorizontalSpeed, // 67F348
MovementStatusElements.FallCosAngle, // 67F36E
MovementStatusElements.FallSinAngle, // 67F37C
MovementStatusElements.GuidByte4_2, // 67F39A
MovementStatusElements.GuidByte2_2, // 67F3AE
MovementStatusElements.TransportTime, // 67F3C8
MovementStatusElements.TransportPositionX, // 67F3DA
MovementStatusElements.TransportPositionO, // 67F413
MovementStatusElements.TransportSeat, // 67F434
MovementStatusElements.TransportGuidByte3_2, // 67F448
MovementStatusElements.TransportGuidByte1_2, // 67F476
MovementStatusElements.TransportTime3, // 67F4C3
MovementStatusElements.TransportGuidByte6_2, // 67F4D7
MovementStatusElements.TransportGuidByte0_2, // 67F505
MovementStatusElements.TransportGuidByte5_2, // 67F530
MovementStatusElements.TransportTime2, // 67F57D
MovementStatusElements.TransportGuidByte7_2, // 67F591
MovementStatusElements.TransportGuidByte4_2, // 67F5BF
MovementStatusElements.TransportGuidByte2_2, // 67F5ED
MovementStatusElements.GuidByte6_2, // 67F61D
MovementStatusElements.Pitch, // 67F62A
MovementStatusElements.GuidByte3_2, // 67F647
MovementStatusElements.SplineElev, // 67F657
MovementStatusElements.GuidByte1_2, // 67F67A
MovementStatusElements.GuidByte7_2, // 67F68E
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_BACKWARD; }
        }
    }
}
