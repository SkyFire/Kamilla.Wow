
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class SetFlightSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.HaveTransportData, // 6DCB12
MovementStatusElements.TransportGuidByte1, // 6DCB32
MovementStatusElements.TransportGuidByte4, // 6DCB49
MovementStatusElements.TransportGuidByte0, // 6DCB60
MovementStatusElements.TransportHaveTime2, // 6DCB76
MovementStatusElements.TransportGuidByte6, // 6DCBA6
MovementStatusElements.TransportGuidByte3, // 6DCBC0
MovementStatusElements.TransportGuidByte2, // 6DCBD2
MovementStatusElements.TransportGuidByte7, // 6DCBFA
MovementStatusElements.TransportHaveTime3, // 6DCC11
MovementStatusElements.TransportGuidByte5, // 6DCC43
MovementStatusElements.HavePitch, // 6DCC57
MovementStatusElements.HaveFallData, // 6DCC86
MovementStatusElements.HaveFallTransferDirection, // 6DCCBD
MovementStatusElements.GuidByte2, // 6DCCFB
MovementStatusElements.GuidByte3, // 6DCD20
MovementStatusElements.GuidByte6, // 6DCD45
MovementStatusElements.GuidByte1, // 6DCD68
MovementStatusElements.Flags2, // 6DCD88
MovementStatusElements.GuidByte0, // 6DCDB3
MovementStatusElements.GuidByte7, // 6DCDD8
MovementStatusElements.GuidByte5, // 6DCDFD
MovementStatusElements.GuidByte4, // 6DCE32
MovementStatusElements.Flags, // 6DCE40
MovementStatusElements.HaveSplineElev, // 6DCE6E
MovementStatusElements.HaveSpline, // 6DCE9D
MovementStatusElements.Timestamp, // 6DCEA3
MovementStatusElements.TransportGuidByte7_2, // 6DCEC8
MovementStatusElements.TransportGuidByte3_2, // 6DCEFA
MovementStatusElements.TransportGuidByte1_2, // 6DCF2C
MovementStatusElements.TransportSeat, // 6DCF67
MovementStatusElements.TransportTime2, // 6DCF9F
MovementStatusElements.TransportGuidByte0_2, // 6DCFB0
MovementStatusElements.TransportGuidByte6_2, // 6DCFE0
MovementStatusElements.TransportPositionX, // 6DD019
MovementStatusElements.TransportPositionY, // 6DD025
MovementStatusElements.TransportPositionZ, // 6DD031
MovementStatusElements.TransportGuidByte4_2, // 6DD042
MovementStatusElements.TransportPositionO, // 6DD07D
MovementStatusElements.TransportTime3, // 6DD0B5
MovementStatusElements.TransportGuidByte5_2, // 6DD0C6
MovementStatusElements.TransportTime, // 6DD101
MovementStatusElements.TransportGuidByte2_2, // 6DD112
MovementStatusElements.GuidByte3_2, // 6DD13B
MovementStatusElements.Pitch, // 6DD16F
MovementStatusElements.FallTime, // 6DD197
MovementStatusElements.FallHorizontalSpeed, // 6DD1D2
MovementStatusElements.FallCosAngle, // 6DD1F3
MovementStatusElements.FallSinAngle, // 6DD1FF
MovementStatusElements.FallVerticalSpeed, // 6DD219
MovementStatusElements.GuidByte5_2, // 6DD21E
MovementStatusElements.GuidByte4_2, // 6DD237
MovementStatusElements.GenericDword0, // 6DD259
MovementStatusElements.PositionO, // 6DD264
MovementStatusElements.GuidByte1_2, // 6DD269
MovementStatusElements.GuidByte6_2, // 6DD282
MovementStatusElements.GuidByte2_2, // 6DD29B
MovementStatusElements.GuidByte7_2, // 6DD2B4
MovementStatusElements.GuidByte0_2, // 6DD2CD
MovementStatusElements.SplineElev, // 6DD30D
MovementStatusElements.PositionX, // 6DD318
MovementStatusElements.PositionY, // 6DD323
MovementStatusElements.PositionZ, // 6DD32E
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_FLIGHT_SPEED; }
        }
    }
}
