
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    internal sealed class MoveSetFlying : RegularMovementPacket
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
MovementStatusElements.Flags, // 6A2C93
MovementStatusElements.GuidByte0, // 6A2C98
MovementStatusElements.GuidByte6, // 6A2CC6
MovementStatusElements.GuidByte3, // 6A2CEB
MovementStatusElements.Flags2, // 6A2D21
MovementStatusElements.GuidByte5, // 6A2D26
MovementStatusElements.GuidByte2, // 6A2D54
MovementStatusElements.GuidByte1, // 6A2D79
MovementStatusElements.GuidByte7, // 6A2D9E
MovementStatusElements.GuidByte4, // 6A2DC3
MovementStatusElements.HaveSpline, // 6A2DEA
MovementStatusElements.HaveFallData, // 6A2E0D
MovementStatusElements.HaveFallTransferDirection, // 6A2E32
MovementStatusElements.HaveTransportData, // 6A2E58
MovementStatusElements.TransportGuidByte6, // 6A2E7F
MovementStatusElements.TransportGuidByte3, // 6A2EB3
MovementStatusElements.TransportGuidByte7, // 6A2EE4
MovementStatusElements.TransportGuidByte4, // 6A2F15
MovementStatusElements.TransportGuidByte1, // 6A2F46
MovementStatusElements.TransportGuidByte0, // 6A2F77
MovementStatusElements.TransportGuidByte2, // 6A2FA7
MovementStatusElements.TransportGuidByte5, // 6A2FD8
MovementStatusElements.TransportHaveTime3, // 6A300B
MovementStatusElements.TransportHaveTime2, // 6A3037
MovementStatusElements.HaveSplineElev, // 6A3057
MovementStatusElements.HavePitch, // 6A307A
MovementStatusElements.PositionO, // 6A30A2
MovementStatusElements.PositionX, // 6A30B3
MovementStatusElements.PositionY, // 6A30C1
MovementStatusElements.PositionZ, // 6A30CF
MovementStatusElements.Timestamp, // 6A30E3
MovementStatusElements.FallVerticalSpeed, // 6A30F1
MovementStatusElements.FallTime, // 6A3116
MovementStatusElements.FallHorizontalSpeed, // 6A3144
MovementStatusElements.FallCosAngle, // 6A316A
MovementStatusElements.FallSinAngle, // 6A3178
MovementStatusElements.GuidByte6_2, // 6A318A
MovementStatusElements.GuidByte7_2, // 6A319E
MovementStatusElements.GuidByte0_2, // 6A31B2
MovementStatusElements.TransportTime, // 6A31D9
MovementStatusElements.TransportPositionX, // 6A31EA
MovementStatusElements.TransportPositionY, // 6A31F9
MovementStatusElements.TransportPositionZ, // 6A3208
MovementStatusElements.TransportPositionO, // 6A3223
MovementStatusElements.TransportSeat, // 6A3247
MovementStatusElements.TransportGuidByte3_2, // 6A3258
MovementStatusElements.TransportGuidByte1_2, // 6A3286
MovementStatusElements.TransportTime3, // 6A32D5
MovementStatusElements.TransportGuidByte6_2, // 6A32E6
MovementStatusElements.TransportGuidByte0_2, // 6A3313
MovementStatusElements.TransportGuidByte5_2, // 6A333F
MovementStatusElements.TransportTime2, // 6A338F
MovementStatusElements.TransportGuidByte7_2, // 6A33A0
MovementStatusElements.TransportGuidByte4_2, // 6A33CE
MovementStatusElements.TransportGuidByte2_2, // 6A33FB
MovementStatusElements.GuidByte1_2, // 6A341D
MovementStatusElements.SplineElev, // 6A343C
MovementStatusElements.GuidByte3_2, // 6A3453
MovementStatusElements.GuidByte5_2, // 6A3467
MovementStatusElements.Pitch, // 6A3480
MovementStatusElements.GuidByte2_2, // 6A3491
MovementStatusElements.GuidByte4_2, // 6A34A5
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_FLY; }
        }
    }
}
