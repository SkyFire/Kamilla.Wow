
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class ForceSetCanFlyAck : ForceAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_CAN_FLY_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte0, // 66B6EC
MovementStatusElements.GuidByte6, // 66B6F8
MovementStatusElements.GuidByte5, // 66B703
MovementStatusElements.Flags, // 66B71E
MovementStatusElements.GuidByte3, // 66B723
MovementStatusElements.GuidByte7, // 66B753
MovementStatusElements.GuidByte4, // 66B779
MovementStatusElements.Flags2, // 66B7B0
MovementStatusElements.HaveSpline, // 66B7C0
MovementStatusElements.GuidByte2, // 66B7E1
MovementStatusElements.GuidByte1, // 66B806
MovementStatusElements.HaveSplineElev, // 66B82D
MovementStatusElements.HavePitch, // 66B850
MovementStatusElements.HaveFallData, // 66B870
MovementStatusElements.HaveFallTransferDirection, // 66B895
MovementStatusElements.HaveTransportData, // 66B8BB
MovementStatusElements.TransportGuidByte6, // 66B8E8
MovementStatusElements.TransportGuidByte3, // 66B91C
MovementStatusElements.TransportGuidByte7, // 66B94D
MovementStatusElements.TransportGuidByte4, // 66B97E
MovementStatusElements.TransportGuidByte1, // 66B9AF
MovementStatusElements.TransportGuidByte0, // 66B9E0
MovementStatusElements.TransportGuidByte2, // 66BA10
MovementStatusElements.TransportGuidByte5, // 66BA41
MovementStatusElements.TransportHaveTime3, // 66BA74
MovementStatusElements.TransportHaveTime2, // 66BAA0
MovementStatusElements.PositionO, // 66BAC8
MovementStatusElements.PositionX, // 66BAD9
MovementStatusElements.PositionY, // 66BAE7
MovementStatusElements.PositionZ, // 66BAF5
MovementStatusElements.Timestamp, // 66BB09
MovementStatusElements.GenericDword0, // 66BB17
MovementStatusElements.GuidByte1_2, // 66BB1C
MovementStatusElements.SplineElev, // 66BB38
MovementStatusElements.GuidByte6_2, // 66BB4F
MovementStatusElements.GuidByte0_2, // 66BB63
MovementStatusElements.GuidByte5_2, // 66BB77
MovementStatusElements.GuidByte7_2, // 66BB8B
MovementStatusElements.Pitch, // 66BBA4
MovementStatusElements.GuidByte2_2, // 66BBB5
MovementStatusElements.GuidByte3_2, // 66BBC9
MovementStatusElements.GuidByte4_2, // 66BBDD
MovementStatusElements.FallVerticalSpeed, // 66BBFA
MovementStatusElements.FallTime, // 66BC1F
MovementStatusElements.FallHorizontalSpeed, // 66BC4D
MovementStatusElements.FallCosAngle, // 66BC73
MovementStatusElements.FallSinAngle, // 66BC81
MovementStatusElements.TransportTime, // 66BCA5
MovementStatusElements.TransportPositionX, // 66BCB6
MovementStatusElements.TransportPositionY, // 66BCC5
MovementStatusElements.TransportPositionZ, // 66BCD4
MovementStatusElements.TransportPositionO, // 66BCEF
MovementStatusElements.TransportSeat, // 66BD13
MovementStatusElements.TransportGuidByte3_2, // 66BD24
MovementStatusElements.TransportGuidByte1_2, // 66BD52
MovementStatusElements.TransportTime3, // 66BDA2
MovementStatusElements.TransportGuidByte6_2, // 66BDB3
MovementStatusElements.TransportGuidByte0_2, // 66BDE1
MovementStatusElements.TransportGuidByte5_2, // 66BE0C
MovementStatusElements.TransportTime2, // 66BE5C
MovementStatusElements.TransportGuidByte7_2, // 66BE6D
MovementStatusElements.TransportGuidByte4_2, // 66BE9B
MovementStatusElements.TransportGuidByte2_2, // 66BEC9
                };
            }
        }
    }
}
