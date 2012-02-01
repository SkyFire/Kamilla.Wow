
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveStopAscend : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_STOP_ASCEND; }
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
MovementStatusElements.HaveSpline, // 699FFA
MovementStatusElements.GuidByte5, // 69A005
MovementStatusElements.GuidByte3, // 69A012
MovementStatusElements.GuidByte1, // 69A01F
MovementStatusElements.Flags, // 69A038
MovementStatusElements.GuidByte4, // 69A03D
MovementStatusElements.GuidByte7, // 69A06D
MovementStatusElements.GuidByte2, // 69A093
MovementStatusElements.Flags2, // 69A0CA
MovementStatusElements.GuidByte6, // 69A0CF
MovementStatusElements.GuidByte0, // 69A0FD
MovementStatusElements.HavePitch, // 69A124
MovementStatusElements.HaveSplineElev, // 69A144
MovementStatusElements.HaveFallData, // 69A167
MovementStatusElements.HaveFallTransferDirection, // 69A18C
MovementStatusElements.HaveTransportData, // 69A1B2
MovementStatusElements.TransportGuidByte6, // 69A1DF
MovementStatusElements.TransportGuidByte3, // 69A213
MovementStatusElements.TransportGuidByte7, // 69A244
MovementStatusElements.TransportGuidByte4, // 69A275
MovementStatusElements.TransportGuidByte1, // 69A2A6
MovementStatusElements.TransportGuidByte0, // 69A2D7
MovementStatusElements.TransportGuidByte2, // 69A307
MovementStatusElements.TransportGuidByte5, // 69A338
MovementStatusElements.TransportHaveTime3, // 69A36B
MovementStatusElements.TransportHaveTime2, // 69A397
MovementStatusElements.Timestamp, // 69A3C8
MovementStatusElements.PositionX, // 69A3CD
MovementStatusElements.PositionY, // 69A3DB
MovementStatusElements.PositionZ, // 69A3E9
MovementStatusElements.PositionO, // 69A3F7
MovementStatusElements.GuidByte5_2, // 69A405
MovementStatusElements.GuidByte2_2, // 69A419
MovementStatusElements.GuidByte0_2, // 69A42D
MovementStatusElements.GuidByte7_2, // 69A441
MovementStatusElements.Pitch, // 69A45A
MovementStatusElements.GuidByte3_2, // 69A46B
MovementStatusElements.GuidByte4_2, // 69A47F
MovementStatusElements.GuidByte1_2, // 69A493
MovementStatusElements.SplineElev, // 69A4AF
MovementStatusElements.FallVerticalSpeed, // 69A4CF
MovementStatusElements.FallTime, // 69A4F4
MovementStatusElements.FallHorizontalSpeed, // 69A522
MovementStatusElements.FallCosAngle, // 69A548
MovementStatusElements.FallSinAngle, // 69A556
MovementStatusElements.GuidByte6_2, // 69A568
MovementStatusElements.TransportTime, // 69A58E
MovementStatusElements.TransportPositionX, // 69A59F
MovementStatusElements.TransportPositionY, // 69A5AE
MovementStatusElements.TransportPositionZ, // 69A5BD
MovementStatusElements.TransportPositionO, // 69A5D8
MovementStatusElements.TransportSeat, // 69A5FC
MovementStatusElements.TransportGuidByte3_2, // 69A60D
MovementStatusElements.TransportGuidByte1_2, // 69A63B
MovementStatusElements.TransportTime3, // 69A68A
MovementStatusElements.TransportGuidByte6_2, // 69A69B
MovementStatusElements.TransportGuidByte0_2, // 69A6C8
MovementStatusElements.TransportGuidByte5_2, // 69A6F4
MovementStatusElements.TransportTime2, // 69A744
MovementStatusElements.TransportGuidByte7_2, // 69A755
MovementStatusElements.TransportGuidByte4_2, // 69A783
MovementStatusElements.TransportGuidByte2_2, // 69A7B0
                };
            }
        }
    }
}
