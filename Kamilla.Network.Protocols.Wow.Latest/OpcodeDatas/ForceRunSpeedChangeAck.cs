
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class ForceRunSpeedChangeAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte6, // 67CB69
MovementStatusElements.GuidByte2, // 67CB77
MovementStatusElements.GuidByte7, // 67CB83
MovementStatusElements.Flags2, // 67CB98
MovementStatusElements.HaveSpline, // 67CBB0
MovementStatusElements.GuidByte3, // 67CBD1
MovementStatusElements.GuidByte5, // 67CBF8
MovementStatusElements.GuidByte4, // 67CC1E
MovementStatusElements.GuidByte0, // 67CC44
MovementStatusElements.GuidByte1, // 67CC6A
MovementStatusElements.Flags, // 67CC9F
MovementStatusElements.HaveTransportData, // 67CCB3
MovementStatusElements.TransportGuidByte6, // 67CCDB
MovementStatusElements.TransportGuidByte3, // 67CD11
MovementStatusElements.TransportGuidByte7, // 67CD44
MovementStatusElements.TransportGuidByte4, // 67CD77
MovementStatusElements.TransportGuidByte1, // 67CDAA
MovementStatusElements.TransportGuidByte0, // 67CDDD
MovementStatusElements.TransportGuidByte2, // 67CE0F
MovementStatusElements.TransportGuidByte5, // 67CE42
MovementStatusElements.TransportHaveTime3, // 67CE77
MovementStatusElements.TransportHaveTime2, // 67CEA4
MovementStatusElements.HavePitch, // 67CEC4
MovementStatusElements.HaveFallData, // 67CEE4
MovementStatusElements.HaveFallTransferDirection, // 67CF0A
MovementStatusElements.HaveSplineElev, // 67CF30
MovementStatusElements.Timestamp, // 67CF63
MovementStatusElements.PositionX, // 67CF6B
MovementStatusElements.PositionY, // 67CF79
MovementStatusElements.PositionZ, // 67CF87
MovementStatusElements.GenericDword0, // 67CF9B
MovementStatusElements.PositionO, // 67CFA3
MovementStatusElements.GenericDword2, // 67CFB1
MovementStatusElements.GuidByte6_2, // 67CFCE
MovementStatusElements.TransportTime, // 67CFE6
MovementStatusElements.TransportPositionX, // 67CFFB
MovementStatusElements.TransportPositionY, // 67D009
MovementStatusElements.TransportPositionZ, // 67D017
MovementStatusElements.TransportPositionO, // 67D032
MovementStatusElements.TransportSeat, // 67D051
MovementStatusElements.TransportGuidByte3_2, // 67D066
MovementStatusElements.TransportGuidByte1_2, // 67D097
MovementStatusElements.TransportTime3, // 67D0E9
MovementStatusElements.TransportGuidByte6_2, // 67D0FE
MovementStatusElements.TransportGuidByte0_2, // 67D12E
MovementStatusElements.TransportGuidByte5_2, // 67D15D
MovementStatusElements.TransportTime2, // 67D1B0
MovementStatusElements.TransportGuidByte7_2, // 67D1C5
MovementStatusElements.TransportGuidByte4_2, // 67D1F6
MovementStatusElements.TransportGuidByte2_2, // 67D226
MovementStatusElements.Pitch, // 67D250
MovementStatusElements.GuidByte2_2, // 67D26D
MovementStatusElements.GuidByte5_2, // 67D281
MovementStatusElements.GuidByte1_2, // 67D295
MovementStatusElements.GuidByte3_2, // 67D2A9
MovementStatusElements.FallVerticalSpeed, // 67D2BB
MovementStatusElements.FallTime, // 67D2DE
MovementStatusElements.FallHorizontalSpeed, // 67D313
MovementStatusElements.FallCosAngle, // 67D33B
MovementStatusElements.FallSinAngle, // 67D348
MovementStatusElements.GuidByte4_2, // 67D363
MovementStatusElements.SplineElev, // 67D374
MovementStatusElements.GuidByte0_2, // 67D397
MovementStatusElements.GuidByte7_2, // 67D3AB
                };
            }
        }
    }
}
