
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceFlightSpeedChangeAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_FLIGHT_SPEED_CHANGE_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.Flags2, // 698E34
MovementStatusElements.HaveSpline, // 698E44
MovementStatusElements.GuidByte5, // 698E65
MovementStatusElements.GuidByte0, // 698E8C
MovementStatusElements.GuidByte7, // 698EB2
MovementStatusElements.GuidByte2, // 698ED8
MovementStatusElements.GuidByte3, // 698EFE
MovementStatusElements.Flags, // 698F37
MovementStatusElements.GuidByte1, // 698F3C
MovementStatusElements.GuidByte4, // 698F6B
MovementStatusElements.GuidByte6, // 698F91
MovementStatusElements.HaveTransportData, // 698FB9
MovementStatusElements.TransportGuidByte6, // 698FE1
MovementStatusElements.TransportGuidByte3, // 699017
MovementStatusElements.TransportGuidByte7, // 69904A
MovementStatusElements.TransportGuidByte4, // 69907D
MovementStatusElements.TransportGuidByte1, // 6990B0
MovementStatusElements.TransportGuidByte0, // 6990E3
MovementStatusElements.TransportGuidByte2, // 699115
MovementStatusElements.TransportGuidByte5, // 699148
MovementStatusElements.TransportHaveTime3, // 69917D
MovementStatusElements.TransportHaveTime2, // 6991AA
MovementStatusElements.HaveFallData, // 6991CA
MovementStatusElements.HaveFallTransferDirection, // 6991F0
MovementStatusElements.HaveSplineElev, // 699216
MovementStatusElements.HavePitch, // 699239
MovementStatusElements.PositionO, // 699263
MovementStatusElements.GenericDword2, // 699274
MovementStatusElements.GenericDword0, // 69928E
MovementStatusElements.PositionX, // 699293
MovementStatusElements.PositionY, // 6992A1
MovementStatusElements.PositionZ, // 6992AF
MovementStatusElements.Timestamp, // 6992C3
MovementStatusElements.GuidByte4_2, // 6992C8
MovementStatusElements.GuidByte2_2, // 6992DC
MovementStatusElements.GuidByte7_2, // 6992F0
MovementStatusElements.GuidByte0_2, // 699304
MovementStatusElements.GuidByte3_2, // 699318
MovementStatusElements.GuidByte5_2, // 69932C
MovementStatusElements.TransportTime, // 699353
MovementStatusElements.TransportPositionX, // 699365
MovementStatusElements.TransportPositionY, // 699373
MovementStatusElements.TransportPositionZ, // 699381
MovementStatusElements.TransportPositionO, // 69939C
MovementStatusElements.TransportSeat, // 6993BE
MovementStatusElements.TransportGuidByte3_2, // 6993D0
MovementStatusElements.TransportGuidByte1_2, // 699401
MovementStatusElements.TransportTime3, // 699456
MovementStatusElements.TransportGuidByte6_2, // 699468
MovementStatusElements.TransportGuidByte0_2, // 699498
MovementStatusElements.TransportGuidByte5_2, // 6994C7
MovementStatusElements.TransportTime2, // 69951D
MovementStatusElements.TransportGuidByte7_2, // 69952F
MovementStatusElements.TransportGuidByte4_2, // 699560
MovementStatusElements.TransportGuidByte2_2, // 699590
MovementStatusElements.FallVerticalSpeed, // 6995BE
MovementStatusElements.FallTime, // 6995E4
MovementStatusElements.FallHorizontalSpeed, // 699616
MovementStatusElements.FallCosAngle, // 69963E
MovementStatusElements.FallSinAngle, // 69964B
MovementStatusElements.SplineElev, // 699663
MovementStatusElements.Pitch, // 699680
MovementStatusElements.GuidByte6_2, // 699691
MovementStatusElements.GuidByte1_2, // 6996A5
                };
            }
        }
    }
}
