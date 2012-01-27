
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class ForceWaterWalkAck : ForceAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_WATER_WALK_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.HaveSpline, // 689E3A
MovementStatusElements.GuidByte4, // 689E46
MovementStatusElements.GuidByte6, // 689E53
MovementStatusElements.GuidByte1, // 689E60
MovementStatusElements.Flags2, // 689E79
MovementStatusElements.GuidByte7, // 689E7E
MovementStatusElements.Flags, // 689EBB
MovementStatusElements.GuidByte5, // 689EC0
MovementStatusElements.GuidByte2, // 689EEF
MovementStatusElements.GuidByte3, // 689F14
MovementStatusElements.GuidByte0, // 689F39
MovementStatusElements.HaveTransportData, // 689F60
MovementStatusElements.TransportGuidByte6, // 689F87
MovementStatusElements.TransportGuidByte3, // 689FBB
MovementStatusElements.TransportGuidByte7, // 689FEC
MovementStatusElements.TransportGuidByte4, // 68A01D
MovementStatusElements.TransportGuidByte1, // 68A04E
MovementStatusElements.TransportGuidByte0, // 68A07F
MovementStatusElements.TransportGuidByte2, // 68A0AF
MovementStatusElements.TransportGuidByte5, // 68A0E0
MovementStatusElements.TransportHaveTime3, // 68A113
MovementStatusElements.TransportHaveTime2, // 68A13F
MovementStatusElements.HavePitch, // 68A15F
MovementStatusElements.HaveFallData, // 68A17F
MovementStatusElements.HaveFallTransferDirection, // 68A1A4
MovementStatusElements.HaveSplineElev, // 68A1CA
MovementStatusElements.Timestamp, // 68A1FE
MovementStatusElements.PositionO, // 68A203
MovementStatusElements.GenericDword0, // 68A21A
MovementStatusElements.PositionX, // 68A21F
MovementStatusElements.PositionY, // 68A22D
MovementStatusElements.PositionZ, // 68A23B
MovementStatusElements.GuidByte3_2, // 68A249
MovementStatusElements.GuidByte7_2, // 68A25D
MovementStatusElements.TransportTime, // 68A283
MovementStatusElements.TransportPositionX, // 68A294
MovementStatusElements.TransportPositionY, // 68A2A3
MovementStatusElements.TransportPositionZ, // 68A2B2
MovementStatusElements.TransportPositionO, // 68A2CD
MovementStatusElements.TransportSeat, // 68A2F1
MovementStatusElements.TransportGuidByte3_2, // 68A302
MovementStatusElements.TransportGuidByte1_2, // 68A330
MovementStatusElements.TransportTime3, // 68A380
MovementStatusElements.TransportGuidByte6_2, // 68A391
MovementStatusElements.TransportGuidByte0_2, // 68A3BF
MovementStatusElements.TransportGuidByte5_2, // 68A3EA
MovementStatusElements.TransportTime2, // 68A43A
MovementStatusElements.TransportGuidByte7_2, // 68A44B
MovementStatusElements.TransportGuidByte4_2, // 68A479
MovementStatusElements.TransportGuidByte2_2, // 68A4A7
MovementStatusElements.GuidByte2_2, // 68A4C8
MovementStatusElements.GuidByte5_2, // 68A4DF
MovementStatusElements.GuidByte1_2, // 68A4F3
MovementStatusElements.Pitch, // 68A50C
MovementStatusElements.FallVerticalSpeed, // 68A526
MovementStatusElements.FallTime, // 68A54B
MovementStatusElements.FallHorizontalSpeed, // 68A579
MovementStatusElements.FallCosAngle, // 68A59F
MovementStatusElements.FallSinAngle, // 68A5AD
MovementStatusElements.GuidByte6_2, // 68A5BF
MovementStatusElements.GuidByte0_2, // 68A5D3
MovementStatusElements.GuidByte4_2, // 68A5E7
MovementStatusElements.SplineElev, // 68A603
                };
            }
        }
    }
}
