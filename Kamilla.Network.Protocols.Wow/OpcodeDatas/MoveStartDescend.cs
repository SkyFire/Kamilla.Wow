
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    internal sealed class MoveStartDescend : RegularMovementPacket
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
MovementStatusElements.GuidByte7, // 69C1FA
MovementStatusElements.GuidByte0, // 69C204
MovementStatusElements.GuidByte2, // 69C20F
MovementStatusElements.GuidByte1, // 69C21A
MovementStatusElements.GuidByte6, // 69C225
MovementStatusElements.GuidByte4, // 69C230
MovementStatusElements.GuidByte5, // 69C23B
MovementStatusElements.HaveSpline, // 69C24A
MovementStatusElements.GuidByte3, // 69C25C
MovementStatusElements.Flags2, // 69C27A
MovementStatusElements.Flags, // 69C28E
MovementStatusElements.HaveFallData, // 69C29E
MovementStatusElements.HaveFallDirection, // 69C2C4
MovementStatusElements.HavePitch, // 69C2EA
MovementStatusElements.HaveSplineElev, // 69C30A
MovementStatusElements.HaveTransportData, // 69C32D
MovementStatusElements.TransportGuidByte6, // 69C35B
MovementStatusElements.TransportGuidByte3, // 69C391
MovementStatusElements.TransportGuidByte7, // 69C3C4
MovementStatusElements.TransportGuidByte4, // 69C3F7
MovementStatusElements.TransportGuidByte1, // 69C42A
MovementStatusElements.TransportGuidByte0, // 69C45D
MovementStatusElements.TransportGuidByte2, // 69C48F
MovementStatusElements.TransportGuidByte5, // 69C4C2
MovementStatusElements.TransportHaveTime3, // 69C4F7
MovementStatusElements.TransportHaveTime2, // 69C524
MovementStatusElements.Timestamp, // 69C554
MovementStatusElements.PositionX, // 69C559
MovementStatusElements.PositionY, // 69C567
MovementStatusElements.PositionZ, // 69C575
MovementStatusElements.PositionO, // 69C583
MovementStatusElements.GuidByte3_2, // 69C591
MovementStatusElements.GuidByte4_2, // 69C5A5
MovementStatusElements.GuidByte2_2, // 69C5B9
MovementStatusElements.FallVerticalSpeed, // 69C5D7
MovementStatusElements.FallTime, // 69C5FD
MovementStatusElements.FallHorizontalSpeed, // 69C62F
MovementStatusElements.FallCosAngle, // 69C657
MovementStatusElements.FallSinAngle, // 69C664
MovementStatusElements.Pitch, // 69C678
MovementStatusElements.GuidByte5_2, // 69C689
MovementStatusElements.SplineElev, // 69C6A6
MovementStatusElements.TransportTime, // 69C6D0
MovementStatusElements.TransportPositionX, // 69C6E2
MovementStatusElements.TransportPositionY, // 69C6F0
MovementStatusElements.TransportPositionZ, // 69C6FE
MovementStatusElements.TransportPositionO, // 69C719
MovementStatusElements.TransportSeat, // 69C73B
MovementStatusElements.TransportGuidByte3_2, // 69C74D
MovementStatusElements.TransportGuidByte1_2, // 69C77E
MovementStatusElements.TransportTime3, // 69C7D4
MovementStatusElements.TransportGuidByte6_2, // 69C7E6
MovementStatusElements.TransportGuidByte0_2, // 69C817
MovementStatusElements.TransportGuidByte5_2, // 69C845
MovementStatusElements.TransportTime2, // 69C89B
MovementStatusElements.TransportGuidByte7_2, // 69C8AD
MovementStatusElements.TransportGuidByte4_2, // 69C8DE
MovementStatusElements.TransportGuidByte2_2, // 69C90F
MovementStatusElements.GuidByte1_2, // 69C932
MovementStatusElements.GuidByte0_2, // 69C946
MovementStatusElements.GuidByte7_2, // 69C95A
MovementStatusElements.GuidByte6_2, // 69C96E
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_DESCEND; }
        }
    }
}
