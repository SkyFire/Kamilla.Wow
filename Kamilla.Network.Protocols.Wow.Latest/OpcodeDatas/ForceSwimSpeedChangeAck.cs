
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class ForceSwimSpeedChangeAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_SWIM_SPEED_CHANGE_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.Flags, // 680073
MovementStatusElements.GuidByte6, // 680078
MovementStatusElements.GuidByte5, // 6800A7
MovementStatusElements.GuidByte7, // 6800CE
MovementStatusElements.GuidByte2, // 6800F4
MovementStatusElements.GuidByte1, // 68011A
MovementStatusElements.GuidByte4, // 680140
MovementStatusElements.Flags2, // 68017A
MovementStatusElements.HaveSpline, // 68018A
MovementStatusElements.GuidByte0, // 6801AB
MovementStatusElements.GuidByte3, // 6801D1
MovementStatusElements.HaveTransportData, // 6801F9
MovementStatusElements.TransportGuidByte6, // 680221
MovementStatusElements.TransportGuidByte3, // 680257
MovementStatusElements.TransportGuidByte7, // 68028A
MovementStatusElements.TransportGuidByte4, // 6802BD
MovementStatusElements.TransportGuidByte1, // 6802F0
MovementStatusElements.TransportGuidByte0, // 680323
MovementStatusElements.TransportGuidByte2, // 680355
MovementStatusElements.TransportGuidByte5, // 680388
MovementStatusElements.TransportHaveTime3, // 6803BD
MovementStatusElements.TransportHaveTime2, // 6803EA
MovementStatusElements.HaveSplineElev, // 68040A
MovementStatusElements.HaveFallData, // 68042D
MovementStatusElements.HaveFallTransferDirection, // 680453
MovementStatusElements.HavePitch, // 680479
MovementStatusElements.GenericDword0, // 6804AF
MovementStatusElements.PositionO, // 6804B4
MovementStatusElements.PositionX, // 6804C2
MovementStatusElements.PositionY, // 6804D0
MovementStatusElements.PositionZ, // 6804DE
MovementStatusElements.GenericDword2, // 6804EC
MovementStatusElements.Timestamp, // 680503
MovementStatusElements.GuidByte6_2, // 680508
MovementStatusElements.TransportTime, // 68052F
MovementStatusElements.TransportPositionX, // 680541
MovementStatusElements.TransportPositionY, // 68054F
MovementStatusElements.TransportPositionZ, // 68055D
MovementStatusElements.TransportPositionO, // 680578
MovementStatusElements.TransportSeat, // 68059A
MovementStatusElements.TransportGuidByte3_2, // 6805AC
MovementStatusElements.TransportGuidByte1_2, // 6805DD
MovementStatusElements.TransportTime3, // 680632
MovementStatusElements.TransportGuidByte6_2, // 680644
MovementStatusElements.TransportGuidByte0_2, // 680674
MovementStatusElements.TransportGuidByte5_2, // 6806A3
MovementStatusElements.TransportTime2, // 6806F9
MovementStatusElements.TransportGuidByte7_2, // 68070B
MovementStatusElements.TransportGuidByte4_2, // 68073C
MovementStatusElements.TransportGuidByte2_2, // 68076C
MovementStatusElements.GuidByte1_2, // 680790
MovementStatusElements.GuidByte3_2, // 6807A4
MovementStatusElements.GuidByte0_2, // 6807B8
MovementStatusElements.GuidByte4_2, // 6807CC
MovementStatusElements.GuidByte7_2, // 6807E0
MovementStatusElements.GuidByte2_2, // 6807F4
MovementStatusElements.SplineElev, // 680811
MovementStatusElements.FallVerticalSpeed, // 680832
MovementStatusElements.FallTime, // 680858
MovementStatusElements.FallHorizontalSpeed, // 68088A
MovementStatusElements.FallCosAngle, // 6808B2
MovementStatusElements.FallSinAngle, // 6808BF
MovementStatusElements.GuidByte5_2, // 6808CD
MovementStatusElements.Pitch, // 6808E8
                };
            }
        }
    }
}
