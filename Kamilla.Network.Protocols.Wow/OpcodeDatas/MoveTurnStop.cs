
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveTurnStop : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_STOP_TURN; }
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
MovementStatusElements.GuidByte3, // 6834C9
MovementStatusElements.GuidByte5, // 6834D4
MovementStatusElements.GuidByte4, // 6834E3
MovementStatusElements.GuidByte2, // 6834F1
MovementStatusElements.Flags2, // 683504
MovementStatusElements.GuidByte0, // 683510
MovementStatusElements.GuidByte7, // 683540
MovementStatusElements.GuidByte6, // 683567
MovementStatusElements.GuidByte1, // 68358D
MovementStatusElements.HaveSpline, // 6835B5
MovementStatusElements.Flags, // 6835E5
MovementStatusElements.HaveFallData, // 6835F9
MovementStatusElements.HaveFallTransferDirection, // 68361F
MovementStatusElements.HaveTransportData, // 683645
MovementStatusElements.TransportGuidByte6, // 68366D
MovementStatusElements.TransportGuidByte3, // 6836A3
MovementStatusElements.TransportGuidByte7, // 6836D6
MovementStatusElements.TransportGuidByte4, // 683709
MovementStatusElements.TransportGuidByte1, // 68373C
MovementStatusElements.TransportGuidByte0, // 68376F
MovementStatusElements.TransportGuidByte2, // 6837A1
MovementStatusElements.TransportGuidByte5, // 6837D4
MovementStatusElements.TransportHaveTime3, // 683809
MovementStatusElements.TransportHaveTime2, // 683836
MovementStatusElements.HaveSplineElev, // 683856
MovementStatusElements.HavePitch, // 683879
MovementStatusElements.PositionO, // 6838A3
MovementStatusElements.Timestamp, // 6838B7
MovementStatusElements.PositionX, // 6838BF
MovementStatusElements.PositionY, // 6838CD
MovementStatusElements.PositionZ, // 6838DB
MovementStatusElements.GuidByte4_2, // 6838F5
MovementStatusElements.GuidByte2_2, // 683909
MovementStatusElements.GuidByte5_2, // 68391D
MovementStatusElements.FallVerticalSpeed, // 68392F
MovementStatusElements.FallTime, // 683952
MovementStatusElements.FallHorizontalSpeed, // 683987
MovementStatusElements.FallCosAngle, // 6839AF
MovementStatusElements.FallSinAngle, // 6839BC
MovementStatusElements.GuidByte0_2, // 6839D6
MovementStatusElements.GuidByte7_2, // 6839EA
MovementStatusElements.GuidByte6_2, // 6839FE
MovementStatusElements.TransportTime, // 683A16
MovementStatusElements.TransportPositionX, // 683A2B
MovementStatusElements.TransportPositionY, // 683A39
MovementStatusElements.TransportPositionZ, // 683A47
MovementStatusElements.TransportPositionO, // 683A62
MovementStatusElements.TransportSeat, // 683A81
MovementStatusElements.TransportGuidByte3_2, // 683A96
MovementStatusElements.TransportGuidByte1_2, // 683AC6
MovementStatusElements.TransportTime3, // 683B19
MovementStatusElements.TransportGuidByte6_2, // 683B2E
MovementStatusElements.TransportGuidByte0_2, // 683B5F
MovementStatusElements.TransportGuidByte5_2, // 683B8E
MovementStatusElements.TransportTime2, // 683BE0
MovementStatusElements.TransportGuidByte7_2, // 683BF5
MovementStatusElements.TransportGuidByte4_2, // 683C25
MovementStatusElements.TransportGuidByte2_2, // 683C56
MovementStatusElements.SplineElev, // 683C84
MovementStatusElements.GuidByte1_2, // 683CA7
MovementStatusElements.GuidByte3_2, // 683CBB
MovementStatusElements.Pitch, // 683CC9
                };
            }
        }
    }
}
