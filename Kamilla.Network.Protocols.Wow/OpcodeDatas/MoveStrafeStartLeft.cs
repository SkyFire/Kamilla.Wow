
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveStrafeStartLeft : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_STRAFE_LEFT; }
        }

        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToServer; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte5, // 69B14C
MovementStatusElements.GuidByte0, // 69B158
MovementStatusElements.GuidByte3, // 69B163
MovementStatusElements.Flags, // 69B176
MovementStatusElements.GuidByte6, // 69B183
MovementStatusElements.GuidByte1, // 69B1B3
MovementStatusElements.GuidByte4, // 69B1D9
MovementStatusElements.Flags2, // 69B20C
MovementStatusElements.HaveSpline, // 69B220
MovementStatusElements.GuidByte7, // 69B241
MovementStatusElements.GuidByte2, // 69B266
MovementStatusElements.HaveTransportData, // 69B28D
MovementStatusElements.TransportGuidByte6, // 69B2B4
MovementStatusElements.TransportGuidByte3, // 69B2E8
MovementStatusElements.TransportGuidByte7, // 69B319
MovementStatusElements.TransportGuidByte4, // 69B34A
MovementStatusElements.TransportGuidByte1, // 69B37B
MovementStatusElements.TransportGuidByte0, // 69B3AC
MovementStatusElements.TransportGuidByte2, // 69B3DC
MovementStatusElements.TransportGuidByte5, // 69B40D
MovementStatusElements.TransportHaveTime3, // 69B440
MovementStatusElements.TransportHaveTime2, // 69B46C
MovementStatusElements.HaveSplineElev, // 69B48C
MovementStatusElements.HaveFallData, // 69B4AF
MovementStatusElements.HaveFallTransferDirection, // 69B4D4
MovementStatusElements.HavePitch, // 69B4FA
MovementStatusElements.PositionO, // 69B522
MovementStatusElements.Timestamp, // 69B536
MovementStatusElements.PositionX, // 69B53E
MovementStatusElements.PositionY, // 69B54C
MovementStatusElements.PositionZ, // 69B55A
MovementStatusElements.GuidByte3_2, // 69B574
MovementStatusElements.TransportTime, // 69B58B
MovementStatusElements.TransportPositionX, // 69B59F
MovementStatusElements.TransportPositionY, // 69B5AE
MovementStatusElements.TransportPositionZ, // 69B5BD
MovementStatusElements.TransportPositionO, // 69B5D8
MovementStatusElements.TransportSeat, // 69B5F9
MovementStatusElements.TransportGuidByte3_2, // 69B60D
MovementStatusElements.TransportGuidByte1_2, // 69B63B
MovementStatusElements.TransportTime3, // 69B688
MovementStatusElements.TransportGuidByte6_2, // 69B69C
MovementStatusElements.TransportGuidByte0_2, // 69B6CA
MovementStatusElements.TransportGuidByte5_2, // 69B6F5
MovementStatusElements.TransportTime2, // 69B742
MovementStatusElements.TransportGuidByte7_2, // 69B756
MovementStatusElements.TransportGuidByte4_2, // 69B784
MovementStatusElements.TransportGuidByte2_2, // 69B7B2
MovementStatusElements.GuidByte5_2, // 69B7E2
MovementStatusElements.GuidByte1_2, // 69B7F6
MovementStatusElements.GuidByte4_2, // 69B80A
MovementStatusElements.GuidByte2_2, // 69B81E
MovementStatusElements.GuidByte0_2, // 69B832
MovementStatusElements.SplineElev, // 69B842
MovementStatusElements.GuidByte6_2, // 69B865
MovementStatusElements.FallVerticalSpeed, // 69B876
MovementStatusElements.FallTime, // 69B898
MovementStatusElements.FallHorizontalSpeed, // 69B8C9
MovementStatusElements.FallCosAngle, // 69B8EF
MovementStatusElements.FallSinAngle, // 69B8FD
MovementStatusElements.GuidByte7_2, // 69B91B
MovementStatusElements.Pitch, // 69B928
                };
            }
        }
    }
}
