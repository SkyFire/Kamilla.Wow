
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceSetCanTransitionBetweenSwimAndFlyAck : ForceAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_ENABLE_SWIM_TO_FLY_TRANS_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 696B4C
MovementStatusElements.GuidByte2, // 696B55
MovementStatusElements.HaveSpline, // 696B61
MovementStatusElements.GuidByte3, // 696B67
MovementStatusElements.GuidByte0, // 696B71
MovementStatusElements.GuidByte7, // 696B7B
MovementStatusElements.GuidByte6, // 696B85
MovementStatusElements.GuidByte4, // 696B8F
MovementStatusElements.Flags, // 696BBB
MovementStatusElements.Flags2, // 696BCF
MovementStatusElements.GuidByte5, // 696BD4
MovementStatusElements.HaveSplineElev, // 696C04
MovementStatusElements.HavePitch, // 696C27
MovementStatusElements.HaveTransportData, // 696C47
MovementStatusElements.TransportGuidByte6, // 696C6E
MovementStatusElements.TransportGuidByte3, // 696CA2
MovementStatusElements.TransportGuidByte7, // 696CD3
MovementStatusElements.TransportGuidByte4, // 696D04
MovementStatusElements.TransportGuidByte1, // 696D35
MovementStatusElements.TransportGuidByte0, // 696D66
MovementStatusElements.TransportGuidByte2, // 696D96
MovementStatusElements.TransportGuidByte5, // 696DC7
MovementStatusElements.TransportHaveTime3, // 696DFA
MovementStatusElements.TransportHaveTime2, // 696E26
MovementStatusElements.HaveFallData, // 696E46
MovementStatusElements.HaveFallTransferDirection, // 696E71
MovementStatusElements.PositionX, // 696E9F
MovementStatusElements.PositionY, // 696EB0
MovementStatusElements.PositionZ, // 696EBE
MovementStatusElements.Timestamp, // 696ED2
MovementStatusElements.PositionO, // 696ED7
MovementStatusElements.GenericDword0, // 696EEE
MovementStatusElements.SplineElev, // 696EFB
MovementStatusElements.GuidByte4_2, // 696F12
MovementStatusElements.Pitch, // 696F2B
MovementStatusElements.GuidByte7_2, // 696F3C
MovementStatusElements.GuidByte3_2, // 696F50
MovementStatusElements.GuidByte2_2, // 696F64
MovementStatusElements.GuidByte0_2, // 696F78
MovementStatusElements.GuidByte5_2, // 696F8C
MovementStatusElements.GuidByte1_2, // 696FA0
MovementStatusElements.TransportTime, // 696FC6
MovementStatusElements.TransportPositionX, // 696FD7
MovementStatusElements.TransportPositionY, // 696FE6
MovementStatusElements.TransportPositionZ, // 696FF5
MovementStatusElements.TransportPositionO, // 697010
MovementStatusElements.TransportSeat, // 697034
MovementStatusElements.TransportGuidByte3_2, // 697045
MovementStatusElements.TransportGuidByte1_2, // 697072
MovementStatusElements.TransportTime3, // 6970C2
MovementStatusElements.TransportGuidByte6_2, // 6970D3
MovementStatusElements.TransportGuidByte0_2, // 697101
MovementStatusElements.TransportGuidByte5_2, // 69712D
MovementStatusElements.TransportTime2, // 69717C
MovementStatusElements.TransportGuidByte7_2, // 69718D
MovementStatusElements.TransportGuidByte4_2, // 6971BA
MovementStatusElements.TransportGuidByte2_2, // 6971E8
MovementStatusElements.GuidByte6_2, // 69720A
MovementStatusElements.FallVerticalSpeed, // 69722A
MovementStatusElements.FallTime, // 69724F
MovementStatusElements.FallHorizontalSpeed, // 69727D
MovementStatusElements.FallCosAngle, // 6972A3
MovementStatusElements.FallSinAngle, // 6972B0
                };
            }
        }
    }
}
