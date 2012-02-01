
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetWalkSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 6DC0E8
MovementStatusElements.GuidByte3, // 6DC0F3
MovementStatusElements.Flags, // 6DC111
MovementStatusElements.GuidByte5, // 6DC13D
MovementStatusElements.GuidByte2, // 6DC171
MovementStatusElements.Flags2, // 6DC17F
MovementStatusElements.GuidByte0, // 6DC1AA
MovementStatusElements.HaveFallData, // 6DC1D3
MovementStatusElements.HaveFallTransferDirection, // 6DC20A
MovementStatusElements.HaveSplineElev, // 6DC24C
MovementStatusElements.GuidByte6, // 6DC27D
MovementStatusElements.GuidByte7, // 6DC2A2
MovementStatusElements.HavePitch, // 6DC2CB
MovementStatusElements.GuidByte4, // 6DC2F6
MovementStatusElements.HaveSpline, // 6DC320
MovementStatusElements.HaveTransportData, // 6DC34D
MovementStatusElements.TransportGuidByte1, // 6DC388
MovementStatusElements.TransportGuidByte4, // 6DC3BA
MovementStatusElements.TransportGuidByte0, // 6DC3EC
MovementStatusElements.TransportHaveTime2, // 6DC41D
MovementStatusElements.TransportGuidByte6, // 6DC468
MovementStatusElements.TransportGuidByte3, // 6DC49A
MovementStatusElements.TransportGuidByte2, // 6DC4CC
MovementStatusElements.TransportGuidByte7, // 6DC4FE
MovementStatusElements.TransportHaveTime3, // 6DC530
MovementStatusElements.TransportGuidByte5, // 6DC575
MovementStatusElements.PositionX, // 6DC57F
MovementStatusElements.PositionY, // 6DC58B
MovementStatusElements.PositionZ, // 6DC597
MovementStatusElements.GuidByte4_2, // 6DC59F
MovementStatusElements.PositionO, // 6DC5BE
MovementStatusElements.GuidByte1_2, // 6DC5C3
MovementStatusElements.Timestamp, // 6DC5E2
MovementStatusElements.GenericDword0, // 6DC5F0
MovementStatusElements.FallTime, // 6DC618
MovementStatusElements.FallHorizontalSpeed, // 6DC653
MovementStatusElements.FallCosAngle, // 6DC674
MovementStatusElements.FallSinAngle, // 6DC680
MovementStatusElements.FallVerticalSpeed, // 6DC69A
MovementStatusElements.GuidByte2_2, // 6DC69F
MovementStatusElements.GuidByte7_2, // 6DC6B8
MovementStatusElements.GuidByte3_2, // 6DC6D1
MovementStatusElements.SplineElev, // 6DC711
MovementStatusElements.Pitch, // 6DC731
MovementStatusElements.GuidByte0_2, // 6DC736
MovementStatusElements.GuidByte6_2, // 6DC74F
MovementStatusElements.GuidByte5_2, // 6DC768
MovementStatusElements.TransportGuidByte7_2, // 6DC7A1
MovementStatusElements.TransportGuidByte3_2, // 6DC7D6
MovementStatusElements.TransportGuidByte1_2, // 6DC80B
MovementStatusElements.TransportSeat, // 6DC846
MovementStatusElements.TransportTime2, // 6DC87E
MovementStatusElements.TransportGuidByte0_2, // 6DC88F
MovementStatusElements.TransportGuidByte6_2, // 6DC8BF
MovementStatusElements.TransportPositionX, // 6DC8F8
MovementStatusElements.TransportPositionY, // 6DC904
MovementStatusElements.TransportPositionZ, // 6DC910
MovementStatusElements.TransportGuidByte4_2, // 6DC921
MovementStatusElements.TransportPositionO, // 6DC95C
MovementStatusElements.TransportTime3, // 6DC994
MovementStatusElements.TransportGuidByte5_2, // 6DC9A5
MovementStatusElements.TransportTime, // 6DC9E0
MovementStatusElements.TransportGuidByte2_2, // 6DC9F1
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_WALK_SPEED; }
        }
    }
}
