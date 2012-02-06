
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    internal sealed class MoveSwimStart : RegularMovementPacket
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
MovementStatusElements.GuidByte1, // 68C1CC
MovementStatusElements.GuidByte5, // 68C1D8
MovementStatusElements.Flags, // 68C1F4
MovementStatusElements.GuidByte2, // 68C1F9
MovementStatusElements.HaveSpline, // 68C22B
MovementStatusElements.GuidByte6, // 68C24D
MovementStatusElements.Flags2, // 68C284
MovementStatusElements.GuidByte4, // 68C289
MovementStatusElements.GuidByte7, // 68C2B8
MovementStatusElements.GuidByte0, // 68C2DD
MovementStatusElements.GuidByte3, // 68C302
MovementStatusElements.HavePitch, // 68C329
MovementStatusElements.HaveSplineElev, // 68C349
MovementStatusElements.HaveFallData, // 68C36C
MovementStatusElements.HaveFallDirection, // 68C391
MovementStatusElements.HaveTransportData, // 68C3B7
MovementStatusElements.TransportGuidByte6, // 68C3E4
MovementStatusElements.TransportGuidByte3, // 68C418
MovementStatusElements.TransportGuidByte7, // 68C449
MovementStatusElements.TransportGuidByte4, // 68C47A
MovementStatusElements.TransportGuidByte1, // 68C4AB
MovementStatusElements.TransportGuidByte0, // 68C4DC
MovementStatusElements.TransportGuidByte2, // 68C50C
MovementStatusElements.TransportGuidByte5, // 68C53D
MovementStatusElements.TransportHaveTime3, // 68C570
MovementStatusElements.TransportHaveTime2, // 68C59C
MovementStatusElements.PositionO, // 68C5C4
MovementStatusElements.PositionX, // 68C5D5
MovementStatusElements.PositionY, // 68C5E3
MovementStatusElements.PositionZ, // 68C5F1
MovementStatusElements.Timestamp, // 68C605
MovementStatusElements.Pitch, // 68C60F
MovementStatusElements.GuidByte4_2, // 68C62F
MovementStatusElements.SplineElev, // 68C63C
MovementStatusElements.FallVerticalSpeed, // 68C65C
MovementStatusElements.FallTime, // 68C681
MovementStatusElements.FallHorizontalSpeed, // 68C6AF
MovementStatusElements.FallCosAngle, // 68C6D5
MovementStatusElements.FallSinAngle, // 68C6E3
MovementStatusElements.GuidByte0_2, // 68C704
MovementStatusElements.GuidByte7_2, // 68C718
MovementStatusElements.TransportTime, // 68C730
MovementStatusElements.TransportPositionX, // 68C741
MovementStatusElements.TransportPositionY, // 68C750
MovementStatusElements.TransportPositionZ, // 68C75F
MovementStatusElements.TransportPositionO, // 68C77A
MovementStatusElements.TransportSeat, // 68C79E
MovementStatusElements.TransportGuidByte3_2, // 68C7AF
MovementStatusElements.TransportGuidByte1_2, // 68C7DC
MovementStatusElements.TransportTime3, // 68C82C
MovementStatusElements.TransportGuidByte6_2, // 68C83D
MovementStatusElements.TransportGuidByte0_2, // 68C86B
MovementStatusElements.TransportGuidByte5_2, // 68C897
MovementStatusElements.TransportTime2, // 68C8E6
MovementStatusElements.TransportGuidByte7_2, // 68C8F7
MovementStatusElements.TransportGuidByte4_2, // 68C924
MovementStatusElements.TransportGuidByte2_2, // 68C952
MovementStatusElements.GuidByte6_2, // 68C986
MovementStatusElements.GuidByte5_2, // 68C99A
MovementStatusElements.GuidByte2_2, // 68C9AE
MovementStatusElements.GuidByte1_2, // 68C9C2
MovementStatusElements.GuidByte3_2, // 68C9D6
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_SWIM; }
        }
    }
}
