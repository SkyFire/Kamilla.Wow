
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveSetRunMode : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_RUN_MODE; }
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
MovementStatusElements.Flags, // 6A08D6
MovementStatusElements.GuidByte1, // 6A08E8
MovementStatusElements.GuidByte0, // 6A0917
MovementStatusElements.HaveSpline, // 6A093E
MovementStatusElements.GuidByte2, // 6A095F
MovementStatusElements.GuidByte5, // 6A0984
MovementStatusElements.GuidByte7, // 6A09A9
MovementStatusElements.GuidByte3, // 6A09CE
MovementStatusElements.Flags2, // 6A0A00
MovementStatusElements.GuidByte6, // 6A0A09
MovementStatusElements.GuidByte4, // 6A0A38
MovementStatusElements.HaveSplineElev, // 6A0A5F
MovementStatusElements.HaveFallData, // 6A0A82
MovementStatusElements.HaveFallDirection, // 6A0AA7
MovementStatusElements.HavePitch, // 6A0ACD
MovementStatusElements.HaveTransportData, // 6A0AED
MovementStatusElements.TransportGuidByte6, // 6A0B1A
MovementStatusElements.TransportGuidByte3, // 6A0B4E
MovementStatusElements.TransportGuidByte7, // 6A0B7F
MovementStatusElements.TransportGuidByte4, // 6A0BB0
MovementStatusElements.TransportGuidByte1, // 6A0BE1
MovementStatusElements.TransportGuidByte0, // 6A0C12
MovementStatusElements.TransportGuidByte2, // 6A0C42
MovementStatusElements.TransportGuidByte5, // 6A0C73
MovementStatusElements.TransportHaveTime3, // 6A0CA6
MovementStatusElements.TransportHaveTime2, // 6A0CD2
MovementStatusElements.PositionX, // 6A0CFA
MovementStatusElements.PositionY, // 6A0D0B
MovementStatusElements.PositionZ, // 6A0D19
MovementStatusElements.PositionO, // 6A0D27
MovementStatusElements.Timestamp, // 6A0D38
MovementStatusElements.GuidByte0_2, // 6A0D4C
MovementStatusElements.SplineElev, // 6A0D5C
MovementStatusElements.GuidByte6_2, // 6A0D7F
MovementStatusElements.GuidByte4_2, // 6A0D93
MovementStatusElements.GuidByte5_2, // 6A0DA7
MovementStatusElements.GuidByte2_2, // 6A0DBB
MovementStatusElements.FallVerticalSpeed, // 6A0DCC
MovementStatusElements.FallTime, // 6A0DEE
MovementStatusElements.FallHorizontalSpeed, // 6A0E1F
MovementStatusElements.FallCosAngle, // 6A0E45
MovementStatusElements.FallSinAngle, // 6A0E53
MovementStatusElements.GuidByte3_2, // 6A0E71
MovementStatusElements.Pitch, // 6A0E7E
MovementStatusElements.GuidByte7_2, // 6A0E9B
MovementStatusElements.TransportTime, // 6A0EB5
MovementStatusElements.TransportPositionX, // 6A0EC7
MovementStatusElements.TransportPositionY, // 6A0ED6
MovementStatusElements.TransportPositionZ, // 6A0EE5
MovementStatusElements.TransportPositionO, // 6A0F00
MovementStatusElements.TransportSeat, // 6A0F21
MovementStatusElements.TransportGuidByte3_2, // 6A0F35
MovementStatusElements.TransportGuidByte1_2, // 6A0F63
MovementStatusElements.TransportTime3, // 6A0FB0
MovementStatusElements.TransportGuidByte6_2, // 6A0FC4
MovementStatusElements.TransportGuidByte0_2, // 6A0FF2
MovementStatusElements.TransportGuidByte5_2, // 6A101D
MovementStatusElements.TransportTime2, // 6A106A
MovementStatusElements.TransportGuidByte7_2, // 6A107E
MovementStatusElements.TransportGuidByte4_2, // 6A10AC
MovementStatusElements.TransportGuidByte2_2, // 6A10DA
MovementStatusElements.GuidByte1_2, // 6A110D
                };
            }
        }
    }
}
