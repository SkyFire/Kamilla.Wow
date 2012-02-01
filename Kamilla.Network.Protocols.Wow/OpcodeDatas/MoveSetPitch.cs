
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveSetPitch : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_PITCH; }
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
MovementStatusElements.GuidByte4, // 697C29
MovementStatusElements.GuidByte6, // 697C37
MovementStatusElements.GuidByte2, // 697C43
MovementStatusElements.Flags2, // 697C60
MovementStatusElements.GuidByte1, // 697C65
MovementStatusElements.GuidByte7, // 697C94
MovementStatusElements.GuidByte5, // 697CBB
MovementStatusElements.GuidByte3, // 697CE1
MovementStatusElements.HaveSpline, // 697D09
MovementStatusElements.GuidByte0, // 697D2A
MovementStatusElements.Flags, // 697D63
MovementStatusElements.HaveFallData, // 697D73
MovementStatusElements.HaveFallTransferDirection, // 697D99
MovementStatusElements.HaveTransportData, // 697DBF
MovementStatusElements.TransportGuidByte6, // 697DE7
MovementStatusElements.TransportGuidByte3, // 697E1D
MovementStatusElements.TransportGuidByte7, // 697E50
MovementStatusElements.TransportGuidByte4, // 697E83
MovementStatusElements.TransportGuidByte1, // 697EB6
MovementStatusElements.TransportGuidByte0, // 697EE9
MovementStatusElements.TransportGuidByte2, // 697F1B
MovementStatusElements.TransportGuidByte5, // 697F4E
MovementStatusElements.TransportHaveTime3, // 697F83
MovementStatusElements.TransportHaveTime2, // 697FB0
MovementStatusElements.HaveSplineElev, // 697FD0
MovementStatusElements.HavePitch, // 697FF3
MovementStatusElements.PositionO, // 69801D
MovementStatusElements.Timestamp, // 698034
MovementStatusElements.PositionX, // 698039
MovementStatusElements.PositionY, // 698047
MovementStatusElements.PositionZ, // 698055
MovementStatusElements.GuidByte2_2, // 698063
MovementStatusElements.GuidByte6_2, // 698077
MovementStatusElements.GuidByte5_2, // 69808B
MovementStatusElements.FallVerticalSpeed, // 6980A9
MovementStatusElements.FallTime, // 6980CF
MovementStatusElements.FallHorizontalSpeed, // 698101
MovementStatusElements.FallCosAngle, // 698129
MovementStatusElements.FallSinAngle, // 698136
MovementStatusElements.GuidByte3_2, // 698144
MovementStatusElements.TransportTime, // 69816B
MovementStatusElements.TransportPositionX, // 69817D
MovementStatusElements.TransportPositionY, // 69818B
MovementStatusElements.TransportPositionZ, // 698199
MovementStatusElements.TransportPositionO, // 6981B4
MovementStatusElements.TransportSeat, // 6981D6
MovementStatusElements.TransportGuidByte3_2, // 6981E8
MovementStatusElements.TransportGuidByte1_2, // 698219
MovementStatusElements.TransportTime3, // 69826F
MovementStatusElements.TransportGuidByte6_2, // 698281
MovementStatusElements.TransportGuidByte0_2, // 6982B2
MovementStatusElements.TransportGuidByte5_2, // 6982E0
MovementStatusElements.TransportTime2, // 698336
MovementStatusElements.TransportGuidByte7_2, // 698348
MovementStatusElements.TransportGuidByte4_2, // 698379
MovementStatusElements.TransportGuidByte2_2, // 6983AA
MovementStatusElements.GuidByte0_2, // 6983CD
MovementStatusElements.GuidByte1_2, // 6983E2
MovementStatusElements.SplineElev, // 6983FF
MovementStatusElements.GuidByte7_2, // 698416
MovementStatusElements.GuidByte4_2, // 69842A
MovementStatusElements.Pitch, // 698444
                };
            }
        }
    }
}
