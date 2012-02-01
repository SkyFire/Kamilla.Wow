
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    internal sealed class MoveHeartBeat : RegularMovementPacket
    {
        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToServer; }
        }

        protected override RegularMovementPacket.MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 68464C
MovementStatusElements.GuidByte5, // 684658
MovementStatusElements.GuidByte2, // 684663
MovementStatusElements.Flags2, // 684677
MovementStatusElements.GuidByte3, // 684684
MovementStatusElements.GuidByte4, // 6846B4
MovementStatusElements.HaveSpline, // 6846DC
MovementStatusElements.Flags, // 68470A
MovementStatusElements.GuidByte0, // 684713
MovementStatusElements.GuidByte6, // 684741
MovementStatusElements.GuidByte7, // 684766
MovementStatusElements.HaveTransportData, // 68478D
MovementStatusElements.TransportGuidByte6, // 6847B4
MovementStatusElements.TransportGuidByte3, // 6847E8
MovementStatusElements.TransportGuidByte7, // 684819
MovementStatusElements.TransportGuidByte4, // 68484A
MovementStatusElements.TransportGuidByte1, // 68487B
MovementStatusElements.TransportGuidByte0, // 6848AC
MovementStatusElements.TransportGuidByte2, // 6848DC
MovementStatusElements.TransportGuidByte5, // 68490D
MovementStatusElements.TransportHaveTime3, // 684940
MovementStatusElements.TransportHaveTime2, // 68496C
MovementStatusElements.HavePitch, // 68498C
MovementStatusElements.HaveSplineElev, // 6849AC
MovementStatusElements.HaveFallData, // 6849CF
MovementStatusElements.HaveFallTransferDirection, // 6849FA
MovementStatusElements.PositionO, // 684A28
MovementStatusElements.PositionX, // 684A39
MovementStatusElements.PositionY, // 684A47
MovementStatusElements.PositionZ, // 684A55
MovementStatusElements.Timestamp, // 684A66
MovementStatusElements.GuidByte6_2, // 684A7A
MovementStatusElements.TransportTime, // 684A91
MovementStatusElements.TransportPositionX, // 684AA5
MovementStatusElements.TransportPositionY, // 684AB4
MovementStatusElements.TransportPositionZ, // 684AC3
MovementStatusElements.TransportPositionO, // 684ADE
MovementStatusElements.TransportSeat, // 684AFF
MovementStatusElements.TransportGuidByte3_2, // 684B13
MovementStatusElements.TransportGuidByte1_2, // 684B41
MovementStatusElements.TransportTime3, // 684B8D
MovementStatusElements.TransportGuidByte6_2, // 684BA1
MovementStatusElements.TransportGuidByte0_2, // 684BCE
MovementStatusElements.TransportGuidByte5_2, // 684BFA
MovementStatusElements.TransportTime2, // 684C47
MovementStatusElements.TransportGuidByte7_2, // 684C5B
MovementStatusElements.TransportGuidByte4_2, // 684C89
MovementStatusElements.TransportGuidByte2_2, // 684CB6
MovementStatusElements.Pitch, // 684CE0
MovementStatusElements.SplineElev, // 684CF9
MovementStatusElements.FallVerticalSpeed, // 684D19
MovementStatusElements.FallTime, // 684D3B
MovementStatusElements.FallHorizontalSpeed, // 684D6C
MovementStatusElements.FallCosAngle, // 684D92
MovementStatusElements.FallSinAngle, // 684DA0
MovementStatusElements.GuidByte5_2, // 684DBE
MovementStatusElements.GuidByte1_2, // 684DD2
MovementStatusElements.GuidByte7_2, // 684DE6
MovementStatusElements.GuidByte0_2, // 684DFA
MovementStatusElements.GuidByte2_2, // 684E0E
MovementStatusElements.GuidByte4_2, // 684E22
MovementStatusElements.GuidByte3_2, // 684E36
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_HEARTBEAT; }
        }
    }
}
