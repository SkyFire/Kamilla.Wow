
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceFlightBackSpeedChangeAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_FLIGHT_BACK_SPEED_CHANGE_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte4, // 67DD3C
MovementStatusElements.HaveSpline, // 67DD4A
MovementStatusElements.GuidByte5, // 67DD50
MovementStatusElements.Flags2, // 67DD6D
MovementStatusElements.GuidByte0, // 67DD72
MovementStatusElements.GuidByte6, // 67DDA0
MovementStatusElements.GuidByte1, // 67DDC5
MovementStatusElements.GuidByte7, // 67DDEA
MovementStatusElements.Flags, // 67DE1F
MovementStatusElements.GuidByte2, // 67DE24
MovementStatusElements.GuidByte3, // 67DE53
MovementStatusElements.HaveFallData, // 67DE7A
MovementStatusElements.HaveFallTransferDirection, // 67DE9F
MovementStatusElements.HaveSplineElev, // 67DEC5
MovementStatusElements.HavePitch, // 67DEE8
MovementStatusElements.HaveTransportData, // 67DF08
MovementStatusElements.TransportGuidByte6, // 67DF35
MovementStatusElements.TransportGuidByte3, // 67DF69
MovementStatusElements.TransportGuidByte7, // 67DF9A
MovementStatusElements.TransportGuidByte4, // 67DFCB
MovementStatusElements.TransportGuidByte1, // 67DFFC
MovementStatusElements.TransportGuidByte0, // 67E02D
MovementStatusElements.TransportGuidByte2, // 67E05D
MovementStatusElements.TransportGuidByte5, // 67E08E
MovementStatusElements.TransportHaveTime3, // 67E0C1
MovementStatusElements.TransportHaveTime2, // 67E0ED
MovementStatusElements.GenericDword2, // 67E115
MovementStatusElements.PositionO, // 67E129
MovementStatusElements.Timestamp, // 67E13D
MovementStatusElements.PositionX, // 67E142
MovementStatusElements.PositionY, // 67E150
MovementStatusElements.PositionZ, // 67E15E
MovementStatusElements.GenericDword0, // 67E175
MovementStatusElements.GuidByte7_2, // 67E17A
MovementStatusElements.FallVerticalSpeed, // 67E197
MovementStatusElements.FallTime, // 67E1BC
MovementStatusElements.FallHorizontalSpeed, // 67E1EA
MovementStatusElements.FallCosAngle, // 67E210
MovementStatusElements.FallSinAngle, // 67E21E
MovementStatusElements.GuidByte3_2, // 67E230
MovementStatusElements.SplineElev, // 67E24C
MovementStatusElements.GuidByte0_2, // 67E263
MovementStatusElements.GuidByte6_2, // 67E277
MovementStatusElements.Pitch, // 67E290
MovementStatusElements.GuidByte2_2, // 67E2A1
MovementStatusElements.GuidByte1_2, // 67E2B5
MovementStatusElements.TransportTime, // 67E2DC
MovementStatusElements.TransportPositionX, // 67E2ED
MovementStatusElements.TransportPositionY, // 67E2FC
MovementStatusElements.TransportPositionZ, // 67E30B
MovementStatusElements.TransportPositionO, // 67E326
MovementStatusElements.TransportSeat, // 67E34A
MovementStatusElements.TransportGuidByte3_2, // 67E35B
MovementStatusElements.TransportGuidByte1_2, // 67E389
MovementStatusElements.TransportTime3, // 67E3D9
MovementStatusElements.TransportGuidByte6_2, // 67E3EA
MovementStatusElements.TransportGuidByte0_2, // 67E418
MovementStatusElements.TransportGuidByte5_2, // 67E443
MovementStatusElements.TransportTime2, // 67E493
MovementStatusElements.TransportGuidByte7_2, // 67E4A4
MovementStatusElements.TransportGuidByte4_2, // 67E4D2
MovementStatusElements.TransportGuidByte2_2, // 67E500
MovementStatusElements.GuidByte4_2, // 67E521
MovementStatusElements.GuidByte5_2, // 67E536
                };
            }
        }
    }
}
