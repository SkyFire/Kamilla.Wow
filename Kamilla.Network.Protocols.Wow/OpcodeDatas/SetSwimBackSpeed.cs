
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetSwimBackSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte0, // 6D839A
MovementStatusElements.GuidByte2, // 6D83A5
MovementStatusElements.HavePitch, // 6D83B4
MovementStatusElements.GuidByte6, // 6D83C3
MovementStatusElements.GuidByte3, // 6D83CE
MovementStatusElements.GuidByte4, // 6D83DB
MovementStatusElements.HaveSpline, // 6D83F1
MovementStatusElements.Flags, // 6D840D
MovementStatusElements.GuidByte1, // 6D8437
MovementStatusElements.HaveTransportData, // 6D8460
MovementStatusElements.TransportGuidByte1, // 6D849A
MovementStatusElements.TransportGuidByte4, // 6D84CC
MovementStatusElements.TransportGuidByte0, // 6D84FE
MovementStatusElements.TransportHaveTime2, // 6D852F
MovementStatusElements.TransportGuidByte6, // 6D857A
MovementStatusElements.TransportGuidByte3, // 6D85AC
MovementStatusElements.TransportGuidByte2, // 6D85DE
MovementStatusElements.TransportGuidByte7, // 6D8610
MovementStatusElements.TransportHaveTime3, // 6D8642
MovementStatusElements.TransportGuidByte5, // 6D868D
MovementStatusElements.GuidByte7, // 6D86B5
MovementStatusElements.HaveFallData, // 6D86DE
MovementStatusElements.HaveFallTransferDirection, // 6D8715
MovementStatusElements.HaveSplineElev, // 6D8757
MovementStatusElements.GuidByte5, // 6D8786
MovementStatusElements.Flags2, // 6D87A0
MovementStatusElements.GuidByte2_2, // 6D87A4
MovementStatusElements.Pitch, // 6D87DA
MovementStatusElements.PositionX, // 6D87E6
MovementStatusElements.PositionY, // 6D87F2
MovementStatusElements.PositionZ, // 6D87FE
MovementStatusElements.GuidByte5_2, // 6D8806
MovementStatusElements.PositionO, // 6D8825
MovementStatusElements.Timestamp, // 6D8830
MovementStatusElements.GenericDword0, // 6D883E
MovementStatusElements.TransportGuidByte7_2, // 6D8863
MovementStatusElements.TransportGuidByte3_2, // 6D8895
MovementStatusElements.TransportGuidByte1_2, // 6D88C7
MovementStatusElements.TransportSeat, // 6D8902
MovementStatusElements.TransportTime2, // 6D893A
MovementStatusElements.TransportGuidByte0_2, // 6D894B
MovementStatusElements.TransportGuidByte6_2, // 6D897B
MovementStatusElements.TransportPositionX, // 6D89B4
MovementStatusElements.TransportPositionY, // 6D89C0
MovementStatusElements.TransportPositionZ, // 6D89CC
MovementStatusElements.TransportGuidByte4_2, // 6D89DD
MovementStatusElements.TransportPositionO, // 6D8A18
MovementStatusElements.TransportTime3, // 6D8A50
MovementStatusElements.TransportGuidByte5_2, // 6D8A61
MovementStatusElements.TransportTime, // 6D8A9C
MovementStatusElements.TransportGuidByte2_2, // 6D8AAD
MovementStatusElements.FallTime, // 6D8AF9
MovementStatusElements.FallHorizontalSpeed, // 6D8B34
MovementStatusElements.FallCosAngle, // 6D8B55
MovementStatusElements.FallSinAngle, // 6D8B61
MovementStatusElements.FallVerticalSpeed, // 6D8B77
MovementStatusElements.SplineElev, // 6D8BB9
MovementStatusElements.GuidByte6_2, // 6D8BBE
MovementStatusElements.GuidByte3_2, // 6D8BD7
MovementStatusElements.GuidByte7_2, // 6D8BF0
MovementStatusElements.GuidByte0_2, // 6D8C09
MovementStatusElements.GuidByte4_2, // 6D8C22
MovementStatusElements.GuidByte1_2, // 6D8C3B
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED; }
        }
    }
}
