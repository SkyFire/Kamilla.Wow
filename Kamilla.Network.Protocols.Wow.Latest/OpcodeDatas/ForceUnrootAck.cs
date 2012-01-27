
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class ForceUnrootAck : ForceAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_UNROOT_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte5, // 68D390
MovementStatusElements.Flags2, // 68D39D
MovementStatusElements.GuidByte7, // 68D3B0
MovementStatusElements.HaveSpline, // 68D3E1
MovementStatusElements.GuidByte0, // 68D402
MovementStatusElements.GuidByte4, // 68D427
MovementStatusElements.Flags, // 68D458
MovementStatusElements.GuidByte1, // 68D461
MovementStatusElements.GuidByte6, // 68D490
MovementStatusElements.GuidByte2, // 68D4B5
MovementStatusElements.GuidByte3, // 68D4DA
MovementStatusElements.HaveFallData, // 68D501
MovementStatusElements.HaveFallTransferDirection, // 68D526
MovementStatusElements.HaveTransportData, // 68D54C
MovementStatusElements.TransportGuidByte6, // 68D573
MovementStatusElements.TransportGuidByte3, // 68D5A7
MovementStatusElements.TransportGuidByte7, // 68D5D8
MovementStatusElements.TransportGuidByte4, // 68D609
MovementStatusElements.TransportGuidByte1, // 68D63A
MovementStatusElements.TransportGuidByte0, // 68D66B
MovementStatusElements.TransportGuidByte2, // 68D69B
MovementStatusElements.TransportGuidByte5, // 68D6CC
MovementStatusElements.TransportHaveTime3, // 68D6FF
MovementStatusElements.TransportHaveTime2, // 68D72B
MovementStatusElements.HavePitch, // 68D74B
MovementStatusElements.HaveSplineElev, // 68D76B
MovementStatusElements.PositionO, // 68D796
MovementStatusElements.GenericDword0, // 68D7AD
MovementStatusElements.PositionX, // 68D7B5
MovementStatusElements.PositionY, // 68D7C3
MovementStatusElements.PositionZ, // 68D7D1
MovementStatusElements.Timestamp, // 68D7E2
MovementStatusElements.GuidByte5_2, // 68D7F6
MovementStatusElements.FallVerticalSpeed, // 68D807
MovementStatusElements.FallTime, // 68D829
MovementStatusElements.FallHorizontalSpeed, // 68D85A
MovementStatusElements.FallCosAngle, // 68D880
MovementStatusElements.FallSinAngle, // 68D88E
MovementStatusElements.TransportTime, // 68D8AF
MovementStatusElements.TransportPositionX, // 68D8C1
MovementStatusElements.TransportPositionY, // 68D8D0
MovementStatusElements.TransportPositionZ, // 68D8DF
MovementStatusElements.TransportPositionO, // 68D8FA
MovementStatusElements.TransportSeat, // 68D91B
MovementStatusElements.TransportGuidByte3_2, // 68D92F
MovementStatusElements.TransportGuidByte1_2, // 68D95D
MovementStatusElements.TransportTime3, // 68D9AA
MovementStatusElements.TransportGuidByte6_2, // 68D9BE
MovementStatusElements.TransportGuidByte0_2, // 68D9EC
MovementStatusElements.TransportGuidByte5_2, // 68DA17
MovementStatusElements.TransportTime2, // 68DA64
MovementStatusElements.TransportGuidByte7_2, // 68DA78
MovementStatusElements.TransportGuidByte4_2, // 68DAA6
MovementStatusElements.TransportGuidByte2_2, // 68DAD4
MovementStatusElements.GuidByte2_2, // 68DB04
MovementStatusElements.GuidByte4_2, // 68DB18
MovementStatusElements.GuidByte0_2, // 68DB2C
MovementStatusElements.GuidByte6_2, // 68DB40
MovementStatusElements.Pitch, // 68DB4D
MovementStatusElements.GuidByte7_2, // 68DB6A
MovementStatusElements.SplineElev, // 68DB7A
MovementStatusElements.GuidByte3_2, // 68DB9D
MovementStatusElements.GuidByte1_2, // 68DBB1
                };
            }
        }
    }
}
