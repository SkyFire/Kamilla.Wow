
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MovePitchStartUp : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_PITCH_UP; }
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
MovementStatusElements.GuidByte7, // 673FEC
MovementStatusElements.GuidByte5, // 673FF8
MovementStatusElements.GuidByte1, // 674003
MovementStatusElements.Flags2, // 67401F
MovementStatusElements.GuidByte3, // 674024
MovementStatusElements.GuidByte6, // 674054
MovementStatusElements.Flags, // 67408A
MovementStatusElements.GuidByte0, // 67408F
MovementStatusElements.GuidByte4, // 6740BE
MovementStatusElements.HaveSpline, // 6740E5
MovementStatusElements.GuidByte2, // 674108
MovementStatusElements.HaveFallData, // 67412F
MovementStatusElements.HaveFallDirection, // 674154
MovementStatusElements.HaveTransportData, // 67417A
MovementStatusElements.TransportGuidByte6, // 6741A1
MovementStatusElements.TransportGuidByte3, // 6741D5
MovementStatusElements.TransportGuidByte7, // 674206
MovementStatusElements.TransportGuidByte4, // 674237
MovementStatusElements.TransportGuidByte1, // 674268
MovementStatusElements.TransportGuidByte0, // 674299
MovementStatusElements.TransportGuidByte2, // 6742C9
MovementStatusElements.TransportGuidByte5, // 6742FA
MovementStatusElements.TransportHaveTime3, // 67432D
MovementStatusElements.TransportHaveTime2, // 674359
MovementStatusElements.HaveSplineElev, // 674379
MovementStatusElements.HavePitch, // 67439C
MovementStatusElements.Timestamp, // 6743CD
MovementStatusElements.PositionO, // 6743D2
MovementStatusElements.PositionX, // 6743E0
MovementStatusElements.PositionY, // 6743EE
MovementStatusElements.PositionZ, // 6743FC
MovementStatusElements.FallVerticalSpeed, // 674413
MovementStatusElements.FallTime, // 674438
MovementStatusElements.FallHorizontalSpeed, // 674466
MovementStatusElements.FallCosAngle, // 67448C
MovementStatusElements.FallSinAngle, // 67449A
MovementStatusElements.TransportTime, // 6744BC
MovementStatusElements.TransportPositionX, // 6744CD
MovementStatusElements.TransportPositionY, // 6744DC
MovementStatusElements.TransportPositionZ, // 6744EB
MovementStatusElements.TransportPositionO, // 674506
MovementStatusElements.TransportSeat, // 67452A
MovementStatusElements.TransportGuidByte3_2, // 67453B
MovementStatusElements.TransportGuidByte1_2, // 674568
MovementStatusElements.TransportTime3, // 6745B8
MovementStatusElements.TransportGuidByte6_2, // 6745C9
MovementStatusElements.TransportGuidByte0_2, // 6745F7
MovementStatusElements.TransportGuidByte5_2, // 674623
MovementStatusElements.TransportTime2, // 674672
MovementStatusElements.TransportGuidByte7_2, // 674683
MovementStatusElements.TransportGuidByte4_2, // 6746B0
MovementStatusElements.TransportGuidByte2_2, // 6746DE
MovementStatusElements.GuidByte5_2, // 674700
MovementStatusElements.GuidByte6_2, // 674717
MovementStatusElements.SplineElev, // 674733
MovementStatusElements.GuidByte7_2, // 67474A
MovementStatusElements.GuidByte0_2, // 67475E
MovementStatusElements.GuidByte1_2, // 674772
MovementStatusElements.GuidByte3_2, // 674786
MovementStatusElements.GuidByte2_2, // 67479A
MovementStatusElements.Pitch, // 6747B3
MovementStatusElements.GuidByte4_2, // 6747C4
                };
            }
        }
    }
}
