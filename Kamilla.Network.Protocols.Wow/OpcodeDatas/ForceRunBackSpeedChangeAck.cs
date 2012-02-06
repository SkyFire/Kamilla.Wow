
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceRunBackSpeedChangeAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_RUN_BACK_SPEED_CHANGE_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte3, // 67A80A
MovementStatusElements.GuidByte4, // 67A814
MovementStatusElements.GuidByte2, // 67A81F
MovementStatusElements.GuidByte0, // 67A82A
MovementStatusElements.GuidByte7, // 67A835
MovementStatusElements.GuidByte5, // 67A840
MovementStatusElements.HaveSpline, // 67A84D
MovementStatusElements.GuidByte1, // 67A853
MovementStatusElements.GuidByte6, // 67A86C
MovementStatusElements.Flags2, // 67A88A
MovementStatusElements.Flags, // 67A89E
MovementStatusElements.HaveSplineElev, // 67A8AE
MovementStatusElements.HavePitch, // 67A8D1
MovementStatusElements.HaveFallData, // 67A8F1
MovementStatusElements.HaveFallDirection, // 67A917
MovementStatusElements.HaveTransportData, // 67A93D
MovementStatusElements.TransportGuidByte6, // 67A96B
MovementStatusElements.TransportGuidByte3, // 67A9A1
MovementStatusElements.TransportGuidByte7, // 67A9D4
MovementStatusElements.TransportGuidByte4, // 67AA07
MovementStatusElements.TransportGuidByte1, // 67AA3A
MovementStatusElements.TransportGuidByte0, // 67AA6D
MovementStatusElements.TransportGuidByte2, // 67AA9F
MovementStatusElements.TransportGuidByte5, // 67AAD2
MovementStatusElements.TransportHaveTime3, // 67AB07
MovementStatusElements.TransportHaveTime2, // 67AB34
MovementStatusElements.GenericDword2, // 67AB5E
MovementStatusElements.Timestamp, // 67AB75
MovementStatusElements.GenericDword0, // 67AB83
MovementStatusElements.PositionO, // 67AB88
MovementStatusElements.PositionX, // 67AB96
MovementStatusElements.PositionY, // 67ABA4
MovementStatusElements.PositionZ, // 67ABB2
MovementStatusElements.SplineElev, // 67ABC9
MovementStatusElements.GuidByte2_2, // 67ABE0
MovementStatusElements.Pitch, // 67ABFA
MovementStatusElements.FallVerticalSpeed, // 67AC15
MovementStatusElements.FallTime, // 67AC3B
MovementStatusElements.FallHorizontalSpeed, // 67AC6D
MovementStatusElements.FallCosAngle, // 67AC95
MovementStatusElements.FallSinAngle, // 67ACA2
MovementStatusElements.GuidByte4_2, // 67ACB0
MovementStatusElements.GuidByte1_2, // 67ACC4
MovementStatusElements.GuidByte3_2, // 67ACD8
MovementStatusElements.GuidByte6_2, // 67ACEC
MovementStatusElements.GuidByte7_2, // 67AD00
MovementStatusElements.TransportTime, // 67AD27
MovementStatusElements.TransportPositionX, // 67AD39
MovementStatusElements.TransportPositionY, // 67AD47
MovementStatusElements.TransportPositionZ, // 67AD55
MovementStatusElements.TransportPositionO, // 67AD70
MovementStatusElements.TransportSeat, // 67AD92
MovementStatusElements.TransportGuidByte3_2, // 67ADA4
MovementStatusElements.TransportGuidByte1_2, // 67ADD5
MovementStatusElements.TransportTime3, // 67AE2A
MovementStatusElements.TransportGuidByte6_2, // 67AE3C
MovementStatusElements.TransportGuidByte0_2, // 67AE6C
MovementStatusElements.TransportGuidByte5_2, // 67AE9B
MovementStatusElements.TransportTime2, // 67AEF1
MovementStatusElements.TransportGuidByte7_2, // 67AF03
MovementStatusElements.TransportGuidByte4_2, // 67AF34
MovementStatusElements.TransportGuidByte2_2, // 67AF64
MovementStatusElements.GuidByte0_2, // 67AF88
MovementStatusElements.GuidByte5_2, // 67AF9C
                };
            }
        }
    }
}
