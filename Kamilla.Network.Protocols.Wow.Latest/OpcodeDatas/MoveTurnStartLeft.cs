
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class MoveTurnStartLeft : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_TURN_LEFT; }
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
MovementStatusElements.Flags, // 6857E6
MovementStatusElements.GuidByte3, // 6857F8
MovementStatusElements.GuidByte5, // 685826
MovementStatusElements.GuidByte7, // 68584B
MovementStatusElements.Flags2, // 68587D
MovementStatusElements.GuidByte6, // 685886
MovementStatusElements.HaveSpline, // 6858B6
MovementStatusElements.GuidByte0, // 6858D7
MovementStatusElements.GuidByte2, // 6858FC
MovementStatusElements.GuidByte1, // 685921
MovementStatusElements.GuidByte4, // 685946
MovementStatusElements.HaveFallData, // 68596D
MovementStatusElements.HaveFallTransferDirection, // 685992
MovementStatusElements.HaveSplineElev, // 6859B8
MovementStatusElements.HavePitch, // 6859DB
MovementStatusElements.HaveTransportData, // 6859FB
MovementStatusElements.TransportGuidByte6, // 685A28
MovementStatusElements.TransportGuidByte3, // 685A5C
MovementStatusElements.TransportGuidByte7, // 685A8D
MovementStatusElements.TransportGuidByte4, // 685ABE
MovementStatusElements.TransportGuidByte1, // 685AEF
MovementStatusElements.TransportGuidByte0, // 685B20
MovementStatusElements.TransportGuidByte2, // 685B50
MovementStatusElements.TransportGuidByte5, // 685B81
MovementStatusElements.TransportHaveTime3, // 685BB4
MovementStatusElements.TransportHaveTime2, // 685BE0
MovementStatusElements.PositionO, // 685C08
MovementStatusElements.Timestamp, // 685C1C
MovementStatusElements.PositionX, // 685C24
MovementStatusElements.PositionY, // 685C32
MovementStatusElements.PositionZ, // 685C40
MovementStatusElements.GuidByte2_2, // 685C5A
MovementStatusElements.GuidByte6_2, // 685C6E
MovementStatusElements.FallVerticalSpeed, // 685C7F
MovementStatusElements.FallTime, // 685CA1
MovementStatusElements.FallHorizontalSpeed, // 685CD2
MovementStatusElements.FallCosAngle, // 685CF8
MovementStatusElements.FallSinAngle, // 685D06
MovementStatusElements.GuidByte4_2, // 685D24
MovementStatusElements.SplineElev, // 685D34
MovementStatusElements.GuidByte0_2, // 685D57
MovementStatusElements.GuidByte7_2, // 685D6B
MovementStatusElements.Pitch, // 685D78
MovementStatusElements.GuidByte1_2, // 685D95
MovementStatusElements.GuidByte5_2, // 685DA9
MovementStatusElements.GuidByte3_2, // 685DBD
MovementStatusElements.TransportTime, // 685DD4
MovementStatusElements.TransportPositionX, // 685DE8
MovementStatusElements.TransportPositionY, // 685DF7
MovementStatusElements.TransportPositionZ, // 685E06
MovementStatusElements.TransportPositionO, // 685E21
MovementStatusElements.TransportSeat, // 685E42
MovementStatusElements.TransportGuidByte3_2, // 685E56
MovementStatusElements.TransportGuidByte1_2, // 685E83
MovementStatusElements.TransportTime3, // 685ED0
MovementStatusElements.TransportGuidByte6_2, // 685EE4
MovementStatusElements.TransportGuidByte0_2, // 685F12
MovementStatusElements.TransportGuidByte5_2, // 685F3E
MovementStatusElements.TransportTime2, // 685F8A
MovementStatusElements.TransportGuidByte7_2, // 685F9E
MovementStatusElements.TransportGuidByte4_2, // 685FCB
MovementStatusElements.TransportGuidByte2_2, // 685FF9
                };
            }
        }
    }
}
