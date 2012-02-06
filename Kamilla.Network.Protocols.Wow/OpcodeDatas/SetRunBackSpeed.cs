
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetRunBackSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte4, // 6D774C
MovementStatusElements.GuidByte5, // 6D7757
MovementStatusElements.GuidByte2, // 6D7762
MovementStatusElements.HaveTransportData, // 6D7778
MovementStatusElements.TransportGuidByte1, // 6D7798
MovementStatusElements.TransportGuidByte4, // 6D77AF
MovementStatusElements.TransportGuidByte0, // 6D77CC
MovementStatusElements.TransportHaveTime2, // 6D77DA
MovementStatusElements.TransportGuidByte6, // 6D781B
MovementStatusElements.TransportGuidByte3, // 6D7832
MovementStatusElements.TransportGuidByte2, // 6D7849
MovementStatusElements.TransportGuidByte7, // 6D7860
MovementStatusElements.TransportHaveTime3, // 6D7877
MovementStatusElements.TransportGuidByte5, // 6D78AE
MovementStatusElements.Flags, // 6D78C0
MovementStatusElements.Flags2, // 6D78D8
MovementStatusElements.GuidByte0, // 6D7903
MovementStatusElements.HavePitch, // 6D792C
MovementStatusElements.HaveFallData, // 6D795B
MovementStatusElements.HaveFallDirection, // 6D7992
MovementStatusElements.HaveSplineElev, // 6D79D4
MovementStatusElements.GuidByte6, // 6D7A05
MovementStatusElements.HaveSpline, // 6D7A2F
MovementStatusElements.GuidByte7, // 6D7A57
MovementStatusElements.GuidByte1, // 6D7A7C
MovementStatusElements.GuidByte3, // 6D7A9B
MovementStatusElements.PositionO, // 6D7AA4
MovementStatusElements.GuidByte0_2, // 6D7AA9
MovementStatusElements.PositionX, // 6D7AC9
MovementStatusElements.PositionY, // 6D7AD5
MovementStatusElements.PositionZ, // 6D7AE1
MovementStatusElements.GuidByte3_2, // 6D7AE6
MovementStatusElements.GuidByte7_2, // 6D7B00
MovementStatusElements.TransportGuidByte7_2, // 6D7B3A
MovementStatusElements.TransportGuidByte3_2, // 6D7B6C
MovementStatusElements.TransportGuidByte1_2, // 6D7B9E
MovementStatusElements.TransportSeat, // 6D7BD9
MovementStatusElements.TransportTime2, // 6D7C11
MovementStatusElements.TransportGuidByte0_2, // 6D7C22
MovementStatusElements.TransportGuidByte6_2, // 6D7C52
MovementStatusElements.TransportPositionX, // 6D7C8B
MovementStatusElements.TransportPositionY, // 6D7C97
MovementStatusElements.TransportPositionZ, // 6D7CA3
MovementStatusElements.TransportGuidByte4_2, // 6D7CB4
MovementStatusElements.TransportPositionO, // 6D7CEF
MovementStatusElements.TransportTime3, // 6D7D27
MovementStatusElements.TransportGuidByte5_2, // 6D7D38
MovementStatusElements.TransportTime, // 6D7D73
MovementStatusElements.TransportGuidByte2_2, // 6D7D84
MovementStatusElements.GuidByte6_2, // 6D7DAD
MovementStatusElements.GuidByte1_2, // 6D7DC6
MovementStatusElements.GenericDword0, // 6D7DE8
MovementStatusElements.Pitch, // 6D7E08
MovementStatusElements.GuidByte2_2, // 6D7E0D
MovementStatusElements.FallTime, // 6D7E49
MovementStatusElements.FallHorizontalSpeed, // 6D7E84
MovementStatusElements.FallCosAngle, // 6D7EA5
MovementStatusElements.FallSinAngle, // 6D7EB1
MovementStatusElements.FallVerticalSpeed, // 6D7ECB
MovementStatusElements.SplineElev, // 6D7EF7
MovementStatusElements.GuidByte4_2, // 6D7EFC
MovementStatusElements.Timestamp, // 6D7F1B
MovementStatusElements.GuidByte5_2, // 6D7F20
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_RUN_BACK_SPEED; }
        }
    }
}
