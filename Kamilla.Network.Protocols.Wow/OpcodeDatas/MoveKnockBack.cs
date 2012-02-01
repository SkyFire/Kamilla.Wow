
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveKnockBack : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_KNOCK_BACK; }
        }

        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToClient; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 6D5C4C
MovementStatusElements.HaveSplineElev, // 6D5C5B
MovementStatusElements.GuidByte3, // 6D5C72
MovementStatusElements.GuidByte0, // 6D5C7D
MovementStatusElements.HavePitch, // 6D5C8C
MovementStatusElements.HaveFallData, // 6D5CA3
MovementStatusElements.HaveFallTransferDirection, // 6D5CC2
MovementStatusElements.GuidByte5, // 6D5CE8
MovementStatusElements.HaveSpline, // 6D5D22
MovementStatusElements.Flags2, // 6D5D33
MovementStatusElements.GuidByte6, // 6D5D5E
MovementStatusElements.GuidByte4, // 6D5D83
MovementStatusElements.HaveTransportData, // 6D5DAC
MovementStatusElements.TransportGuidByte1, // 6D5DE6
MovementStatusElements.TransportGuidByte4, // 6D5E18
MovementStatusElements.TransportGuidByte0, // 6D5E4A
MovementStatusElements.TransportHaveTime2, // 6D5E7B
MovementStatusElements.TransportGuidByte6, // 6D5EC6
MovementStatusElements.TransportGuidByte3, // 6D5EF8
MovementStatusElements.TransportGuidByte2, // 6D5F2A
MovementStatusElements.TransportGuidByte7, // 6D5F5C
MovementStatusElements.TransportHaveTime3, // 6D5F8E
MovementStatusElements.TransportGuidByte5, // 6D5FD9
MovementStatusElements.GuidByte7, // 6D6011
MovementStatusElements.Flags, // 6D601D
MovementStatusElements.GuidByte2, // 6D603F
MovementStatusElements.GuidByte6_2, // 6D6042
MovementStatusElements.GuidByte1_2, // 6D605B
MovementStatusElements.GuidByte0_2, // 6D6074
MovementStatusElements.SplineElev, // 6D60B4
MovementStatusElements.PositionO, // 6D60BF
MovementStatusElements.Pitch, // 6D60DF
MovementStatusElements.FallTime, // 6D6107
MovementStatusElements.FallHorizontalSpeed, // 6D6142
MovementStatusElements.FallCosAngle, // 6D6163
MovementStatusElements.FallSinAngle, // 6D616F
MovementStatusElements.FallVerticalSpeed, // 6D6189
MovementStatusElements.GuidByte3_2, // 6D618E
MovementStatusElements.GuidByte2_2, // 6D61A7
MovementStatusElements.GuidByte5_2, // 6D61C0
MovementStatusElements.TransportGuidByte7_2, // 6D61F9
MovementStatusElements.TransportGuidByte3_2, // 6D622B
MovementStatusElements.TransportGuidByte1_2, // 6D625D
MovementStatusElements.TransportSeat, // 6D6298
MovementStatusElements.TransportTime2, // 6D62D0
MovementStatusElements.TransportGuidByte0_2, // 6D62E1
MovementStatusElements.TransportGuidByte6_2, // 6D6311
MovementStatusElements.TransportPositionX, // 6D634A
MovementStatusElements.TransportPositionY, // 6D6356
MovementStatusElements.TransportPositionZ, // 6D6362
MovementStatusElements.TransportGuidByte4_2, // 6D6373
MovementStatusElements.TransportPositionO, // 6D63AE
MovementStatusElements.TransportTime3, // 6D63E6
MovementStatusElements.TransportGuidByte5_2, // 6D63F7
MovementStatusElements.TransportTime, // 6D6432
MovementStatusElements.TransportGuidByte2_2, // 6D6443
MovementStatusElements.GuidByte7_2, // 6D6469
MovementStatusElements.PositionX, // 6D648A
MovementStatusElements.PositionY, // 6D6496
MovementStatusElements.PositionZ, // 6D64A2
MovementStatusElements.GuidByte4_2, // 6D64A7
MovementStatusElements.Timestamp, // 6D64C8
                };
            }
        }
    }
}
