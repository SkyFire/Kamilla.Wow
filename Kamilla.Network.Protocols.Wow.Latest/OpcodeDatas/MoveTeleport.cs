
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class MoveTeleport : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_TELEPORT; }
        }

        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToClient; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new[]{
MovementStatusElements.Flags2, // 6D9653
MovementStatusElements.Flags, // 6D9662
MovementStatusElements.GuidByte5, // 6D968C
MovementStatusElements.HaveTransportData, // 6D96B5
MovementStatusElements.TransportGuidByte1, // 6D96EF
MovementStatusElements.TransportGuidByte4, // 6D9721
MovementStatusElements.TransportGuidByte0, // 6D9753
MovementStatusElements.TransportHaveTime2, // 6D9784
MovementStatusElements.TransportGuidByte6, // 6D97CF
MovementStatusElements.TransportGuidByte3, // 6D9801
MovementStatusElements.TransportGuidByte2, // 6D9833
MovementStatusElements.TransportGuidByte7, // 6D9865
MovementStatusElements.TransportHaveTime3, // 6D9897
MovementStatusElements.TransportGuidByte5, // 6D98E2
MovementStatusElements.HaveFallData, // 6D990E
MovementStatusElements.HaveFallTransferDirection, // 6D9945
MovementStatusElements.HaveSpline, // 6D998B
MovementStatusElements.GuidByte1, // 6D99B3
MovementStatusElements.GuidByte6, // 6D99D8
MovementStatusElements.HavePitch, // 6D9A01
MovementStatusElements.HaveSplineElev, // 6D9A30
MovementStatusElements.GuidByte7, // 6D9A61
MovementStatusElements.GuidByte2, // 6D9A86
MovementStatusElements.GuidByte0, // 6D9AAB
MovementStatusElements.GuidByte3, // 6D9AD0
MovementStatusElements.GuidByte4, // 6D9AEC
MovementStatusElements.TransportGuidByte7_2, // 6D9B0F
MovementStatusElements.TransportGuidByte3_2, // 6D9B41
MovementStatusElements.TransportGuidByte1_2, // 6D9B73
MovementStatusElements.TransportSeat, // 6D9BAB
MovementStatusElements.TransportTime2, // 6D9BE3
MovementStatusElements.TransportGuidByte0_2, // 6D9BF7
MovementStatusElements.TransportGuidByte6_2, // 6D9C27
MovementStatusElements.TransportPositionX, // 6D9C5F
MovementStatusElements.TransportGuidByte4_2, // 6D9C89
MovementStatusElements.TransportPositionO, // 6D9CC1
MovementStatusElements.TransportTime3, // 6D9CF9
MovementStatusElements.TransportGuidByte5_2, // 6D9D0D
MovementStatusElements.TransportTime, // 6D9D45
MovementStatusElements.TransportGuidByte2_2, // 6D9D59
MovementStatusElements.FallTime, // 6D9DA2
MovementStatusElements.FallHorizontalSpeed, // 6D9DDD
MovementStatusElements.FallCosAngle, // 6D9E00
MovementStatusElements.FallSinAngle, // 6D9E0C
MovementStatusElements.FallVerticalSpeed, // 6D9E24
MovementStatusElements.PositionX, // 6D9E32
MovementStatusElements.GuidByte1_2, // 6D9E53
MovementStatusElements.GuidByte7_2, // 6D9E6C
MovementStatusElements.Pitch, // 6D9E9D
MovementStatusElements.SplineElev, // 6D9EC9
MovementStatusElements.GuidByte0_2, // 6D9ED1
MovementStatusElements.GuidByte4_2, // 6D9EEA
MovementStatusElements.Timestamp, // 6D9F06
MovementStatusElements.GuidByte2_2, // 6D9F0E
MovementStatusElements.GuidByte6_2, // 6D9F27
MovementStatusElements.PositionO, // 6D9F43
MovementStatusElements.GuidByte5_2, // 6D9F4B
MovementStatusElements.GuidByte3_2, // 6D9F64
            };
            }
        }
    }
}
