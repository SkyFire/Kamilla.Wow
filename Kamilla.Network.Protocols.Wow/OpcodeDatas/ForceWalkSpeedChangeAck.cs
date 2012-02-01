
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceWalkSpeedChangeAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_WALK_SPEED_CHANGE_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.Flags, // 67B993
MovementStatusElements.GuidByte4, // 67B998
MovementStatusElements.GuidByte6, // 67B9C7
MovementStatusElements.Flags2, // 67B9FE
MovementStatusElements.GuidByte3, // 67BA03
MovementStatusElements.GuidByte2, // 67BA32
MovementStatusElements.GuidByte5, // 67BA57
MovementStatusElements.GuidByte0, // 67BA7C
MovementStatusElements.GuidByte1, // 67BAA1
MovementStatusElements.GuidByte7, // 67BAC6
MovementStatusElements.HaveSpline, // 67BAED
MovementStatusElements.HaveFallData, // 67BB10
MovementStatusElements.HaveFallTransferDirection, // 67BB35
MovementStatusElements.HaveSplineElev, // 67BB5B
MovementStatusElements.HaveTransportData, // 67BB7E
MovementStatusElements.TransportGuidByte6, // 67BBA5
MovementStatusElements.TransportGuidByte3, // 67BBD9
MovementStatusElements.TransportGuidByte7, // 67BC0A
MovementStatusElements.TransportGuidByte4, // 67BC3B
MovementStatusElements.TransportGuidByte1, // 67BC6C
MovementStatusElements.TransportGuidByte0, // 67BC9D
MovementStatusElements.TransportGuidByte2, // 67BCCD
MovementStatusElements.TransportGuidByte5, // 67BCFE
MovementStatusElements.TransportHaveTime3, // 67BD31
MovementStatusElements.TransportHaveTime2, // 67BD5D
MovementStatusElements.HavePitch, // 67BD7D
MovementStatusElements.GenericDword2, // 67BDA5
MovementStatusElements.Timestamp, // 67BDBF
MovementStatusElements.PositionX, // 67BDC4
MovementStatusElements.PositionY, // 67BDD2
MovementStatusElements.PositionZ, // 67BDE0
MovementStatusElements.PositionO, // 67BDEE
MovementStatusElements.GenericDword0, // 67BE05
MovementStatusElements.GuidByte6_2, // 67BE0A
MovementStatusElements.FallVerticalSpeed, // 67BE27
MovementStatusElements.FallTime, // 67BE4C
MovementStatusElements.FallHorizontalSpeed, // 67BE7A
MovementStatusElements.FallCosAngle, // 67BEA0
MovementStatusElements.FallSinAngle, // 67BEAE
MovementStatusElements.SplineElev, // 67BEC8
MovementStatusElements.GuidByte2_2, // 67BEDF
MovementStatusElements.GuidByte3_2, // 67BEF3
MovementStatusElements.GuidByte5_2, // 67BF07
MovementStatusElements.GuidByte7_2, // 67BF1B
MovementStatusElements.GuidByte0_2, // 67BF2F
MovementStatusElements.GuidByte4_2, // 67BF43
MovementStatusElements.TransportTime, // 67BF6A
MovementStatusElements.TransportPositionX, // 67BF7B
MovementStatusElements.TransportPositionY, // 67BF8A
MovementStatusElements.TransportPositionZ, // 67BF99
MovementStatusElements.TransportPositionO, // 67BFB4
MovementStatusElements.TransportSeat, // 67BFD8
MovementStatusElements.TransportGuidByte3_2, // 67BFE9
MovementStatusElements.TransportGuidByte1_2, // 67C017
MovementStatusElements.TransportTime3, // 67C067
MovementStatusElements.TransportGuidByte6_2, // 67C078
MovementStatusElements.TransportGuidByte0_2, // 67C0A6
MovementStatusElements.TransportGuidByte5_2, // 67C0D1
MovementStatusElements.TransportTime2, // 67C121
MovementStatusElements.TransportGuidByte7_2, // 67C132
MovementStatusElements.TransportGuidByte4_2, // 67C160
MovementStatusElements.TransportGuidByte2_2, // 67C18E
MovementStatusElements.GuidByte1_2, // 67C1AF
MovementStatusElements.Pitch, // 67C1C9
                };
            }
        }
    }
}
