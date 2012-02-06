
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceToggleCollisionAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_TOGGLE_COLLISION_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.HaveSpline, // 67513A
MovementStatusElements.GuidByte1, // 675142
MovementStatusElements.GuidByte3, // 675152
MovementStatusElements.Flags2, // 67516F
MovementStatusElements.GuidByte4, // 675174
MovementStatusElements.GuidByte2, // 6751A4
MovementStatusElements.GuidByte6, // 6751CA
MovementStatusElements.Flags, // 675200
MovementStatusElements.GuidByte7, // 675205
MovementStatusElements.GuidByte0, // 675233
MovementStatusElements.GuidByte5, // 675258
MovementStatusElements.HaveTransportData, // 67527F
MovementStatusElements.TransportGuidByte6, // 6752A6
MovementStatusElements.TransportGuidByte3, // 6752DA
MovementStatusElements.TransportGuidByte7, // 67530B
MovementStatusElements.TransportGuidByte4, // 67533C
MovementStatusElements.TransportGuidByte1, // 67536D
MovementStatusElements.TransportGuidByte0, // 67539E
MovementStatusElements.TransportGuidByte2, // 6753CE
MovementStatusElements.TransportGuidByte5, // 6753FF
MovementStatusElements.TransportHaveTime3, // 675432
MovementStatusElements.TransportHaveTime2, // 67545E
MovementStatusElements.HaveSplineElev, // 67547E
MovementStatusElements.HavePitch, // 6754A1
MovementStatusElements.HaveFallData, // 6754C1
MovementStatusElements.HaveFallDirection, // 6754EC
MovementStatusElements.PositionO, // 67551A
MovementStatusElements.PositionX, // 67552B
MovementStatusElements.PositionY, // 675539
MovementStatusElements.PositionZ, // 675547
MovementStatusElements.Timestamp, // 67555B
MovementStatusElements.GuidByte1_2, // 675560
MovementStatusElements.GuidByte2_2, // 675574
MovementStatusElements.TransportTime, // 67559A
MovementStatusElements.TransportPositionX, // 6755AB
MovementStatusElements.TransportPositionY, // 6755BA
MovementStatusElements.TransportPositionZ, // 6755C9
MovementStatusElements.TransportPositionO, // 6755E4
MovementStatusElements.TransportSeat, // 675608
MovementStatusElements.TransportGuidByte3_2, // 675619
MovementStatusElements.TransportGuidByte1_2, // 675647
MovementStatusElements.TransportTime3, // 675697
MovementStatusElements.TransportGuidByte6_2, // 6756A8
MovementStatusElements.TransportGuidByte0_2, // 6756D6
MovementStatusElements.TransportGuidByte5_2, // 675701
MovementStatusElements.TransportTime2, // 675751
MovementStatusElements.TransportGuidByte7_2, // 675762
MovementStatusElements.TransportGuidByte4_2, // 675790
MovementStatusElements.TransportGuidByte2_2, // 6757BE
MovementStatusElements.GuidByte4_2, // 6757DF
MovementStatusElements.SplineElev, // 6757FE
MovementStatusElements.Pitch, // 67581A
MovementStatusElements.FallVerticalSpeed, // 675834
MovementStatusElements.FallTime, // 675859
MovementStatusElements.FallHorizontalSpeed, // 675887
MovementStatusElements.FallCosAngle, // 6758AD
MovementStatusElements.FallSinAngle, // 6758BB
MovementStatusElements.GuidByte5_2, // 6758CD
MovementStatusElements.GuidByte0_2, // 6758E1
MovementStatusElements.GuidByte7_2, // 6758F5
MovementStatusElements.GuidByte3_2, // 675909
MovementStatusElements.GuidByte6_2, // 67591D
                };
            }
        }
    }
}
