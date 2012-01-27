
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class MoveTurnStartRight : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_TURN_RIGHT; }
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
MovementStatusElements.GuidByte0, // 6A1AAF
MovementStatusElements.Flags, // 6A1ABC
MovementStatusElements.GuidByte7, // 6A1ACF
MovementStatusElements.HaveSpline, // 6A1B00
MovementStatusElements.GuidByte4, // 6A1B21
MovementStatusElements.GuidByte6, // 6A1B46
MovementStatusElements.GuidByte3, // 6A1B6B
MovementStatusElements.GuidByte1, // 6A1B90
MovementStatusElements.Flags2, // 6A1BC2
MovementStatusElements.GuidByte2, // 6A1BCB
MovementStatusElements.GuidByte5, // 6A1BFA
MovementStatusElements.HaveFallData, // 6A1C21
MovementStatusElements.HaveFallTransferDirection, // 6A1C46
MovementStatusElements.HavePitch, // 6A1C6C
MovementStatusElements.HaveSplineElev, // 6A1C8C
MovementStatusElements.HaveTransportData, // 6A1CAF
MovementStatusElements.TransportGuidByte6, // 6A1CDC
MovementStatusElements.TransportGuidByte3, // 6A1D10
MovementStatusElements.TransportGuidByte7, // 6A1D41
MovementStatusElements.TransportGuidByte4, // 6A1D72
MovementStatusElements.TransportGuidByte1, // 6A1DA3
MovementStatusElements.TransportGuidByte0, // 6A1DD4
MovementStatusElements.TransportGuidByte2, // 6A1E04
MovementStatusElements.TransportGuidByte5, // 6A1E35
MovementStatusElements.TransportHaveTime3, // 6A1E68
MovementStatusElements.TransportHaveTime2, // 6A1E94
MovementStatusElements.PositionO, // 6A1EBC
MovementStatusElements.Timestamp, // 6A1ED0
MovementStatusElements.PositionX, // 6A1ED8
MovementStatusElements.PositionY, // 6A1EE6
MovementStatusElements.PositionZ, // 6A1EF4
MovementStatusElements.GuidByte1_2, // 6A1F0E
MovementStatusElements.GuidByte6_2, // 6A1F22
MovementStatusElements.FallVerticalSpeed, // 6A1F33
MovementStatusElements.FallTime, // 6A1F55
MovementStatusElements.FallHorizontalSpeed, // 6A1F86
MovementStatusElements.FallCosAngle, // 6A1FAC
MovementStatusElements.FallSinAngle, // 6A1FBA
MovementStatusElements.GuidByte0_2, // 6A1FD8
MovementStatusElements.GuidByte5_2, // 6A1FEC
MovementStatusElements.GuidByte2_2, // 6A2000
MovementStatusElements.Pitch, // 6A200D
MovementStatusElements.GuidByte4_2, // 6A202A
MovementStatusElements.GuidByte3_2, // 6A203E
MovementStatusElements.GuidByte7_2, // 6A2052
MovementStatusElements.SplineElev, // 6A2062
MovementStatusElements.TransportTime, // 6A2088
MovementStatusElements.TransportPositionX, // 6A209C
MovementStatusElements.TransportPositionY, // 6A20AB
MovementStatusElements.TransportPositionZ, // 6A20BA
MovementStatusElements.TransportPositionO, // 6A20D5
MovementStatusElements.TransportSeat, // 6A20F6
MovementStatusElements.TransportGuidByte3_2, // 6A210A
MovementStatusElements.TransportGuidByte1_2, // 6A2137
MovementStatusElements.TransportTime3, // 6A2184
MovementStatusElements.TransportGuidByte6_2, // 6A2198
MovementStatusElements.TransportGuidByte0_2, // 6A21C6
MovementStatusElements.TransportGuidByte5_2, // 6A21F2
MovementStatusElements.TransportTime2, // 6A223E
MovementStatusElements.TransportGuidByte7_2, // 6A2252
MovementStatusElements.TransportGuidByte4_2, // 6A227F
MovementStatusElements.TransportGuidByte2_2, // 6A22AD
                };
            }
        }
    }
}
