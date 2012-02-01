
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetFlightBackSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.HavePitch, // 6DAB9D
MovementStatusElements.HaveFallData, // 6DABB4
MovementStatusElements.HaveFallTransferDirection, // 6DABD3
MovementStatusElements.GuidByte7, // 6DAC0A
MovementStatusElements.Flags2, // 6DAC18
MovementStatusElements.GuidByte0, // 6DAC43
MovementStatusElements.GuidByte5, // 6DAC68
MovementStatusElements.HaveSplineElev, // 6DAC91
MovementStatusElements.GuidByte6, // 6DACC2
MovementStatusElements.GuidByte3, // 6DACE7
MovementStatusElements.GuidByte4, // 6DAD0A
MovementStatusElements.Flags, // 6DAD2A
MovementStatusElements.GuidByte1, // 6DAD54
MovementStatusElements.HaveSpline, // 6DAD81
MovementStatusElements.GuidByte2, // 6DADA9
MovementStatusElements.HaveTransportData, // 6DADD2
MovementStatusElements.TransportGuidByte1, // 6DAE0C
MovementStatusElements.TransportGuidByte4, // 6DAE3E
MovementStatusElements.TransportGuidByte0, // 6DAE70
MovementStatusElements.TransportHaveTime2, // 6DAEA1
MovementStatusElements.TransportGuidByte6, // 6DAEEC
MovementStatusElements.TransportGuidByte3, // 6DAF1E
MovementStatusElements.TransportGuidByte2, // 6DAF50
MovementStatusElements.TransportGuidByte7, // 6DAF82
MovementStatusElements.TransportHaveTime3, // 6DAFB4
MovementStatusElements.TransportGuidByte5, // 6DAFF9
MovementStatusElements.Pitch, // 6DB016
MovementStatusElements.GuidByte1_2, // 6DB02F
MovementStatusElements.FallTime, // 6DB06B
MovementStatusElements.FallHorizontalSpeed, // 6DB0A6
MovementStatusElements.FallCosAngle, // 6DB0C7
MovementStatusElements.FallSinAngle, // 6DB0D3
MovementStatusElements.FallVerticalSpeed, // 6DB0ED
MovementStatusElements.GuidByte0_2, // 6DB0F2
MovementStatusElements.GenericDword0, // 6DB114
MovementStatusElements.SplineElev, // 6DB140
MovementStatusElements.GuidByte6_2, // 6DB145
MovementStatusElements.GuidByte7_2, // 6DB15E
MovementStatusElements.Timestamp, // 6DB17E
MovementStatusElements.PositionX, // 6DB18A
MovementStatusElements.PositionY, // 6DB196
MovementStatusElements.PositionZ, // 6DB1A4
MovementStatusElements.PositionO, // 6DB1AF
MovementStatusElements.GuidByte5_2, // 6DB1B4
MovementStatusElements.GuidByte4_2, // 6DB1CD
MovementStatusElements.TransportGuidByte7_2, // 6DB206
MovementStatusElements.TransportGuidByte3_2, // 6DB238
MovementStatusElements.TransportGuidByte1_2, // 6DB26A
MovementStatusElements.TransportSeat, // 6DB2A5
MovementStatusElements.TransportTime2, // 6DB2DD
MovementStatusElements.TransportGuidByte0_2, // 6DB2EE
MovementStatusElements.TransportGuidByte6_2, // 6DB31E
MovementStatusElements.TransportPositionX, // 6DB357
MovementStatusElements.TransportPositionY, // 6DB363
MovementStatusElements.TransportPositionZ, // 6DB36F
MovementStatusElements.TransportGuidByte4_2, // 6DB380
MovementStatusElements.TransportPositionO, // 6DB3BB
MovementStatusElements.TransportTime3, // 6DB3F3
MovementStatusElements.TransportGuidByte5_2, // 6DB404
MovementStatusElements.TransportTime, // 6DB43F
MovementStatusElements.TransportGuidByte2_2, // 6DB450
MovementStatusElements.GuidByte2_2, // 6DB477
MovementStatusElements.GuidByte3_2, // 6DB491
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED; }
        }
    }
}
