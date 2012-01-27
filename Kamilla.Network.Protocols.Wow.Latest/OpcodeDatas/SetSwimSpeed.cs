
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public sealed class SetSwimSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.HavePitch, // 6D8D0D
MovementStatusElements.GuidByte7, // 6D8D1E
MovementStatusElements.GuidByte4, // 6D8D29
MovementStatusElements.GuidByte2, // 6D8D34
MovementStatusElements.HaveFallData, // 6D8D4A
MovementStatusElements.HaveFallTransferDirection, // 6D8D6E
MovementStatusElements.Flags, // 6D8DA4
MovementStatusElements.Flags2, // 6D8DB2
MovementStatusElements.GuidByte0, // 6D8DDD
MovementStatusElements.HaveSpline, // 6D8E0A
MovementStatusElements.GuidByte3, // 6D8E32
MovementStatusElements.GuidByte5, // 6D8E57
MovementStatusElements.HaveSplineElev, // 6D8E80
MovementStatusElements.HaveTransportData, // 6D8EB5
MovementStatusElements.TransportGuidByte1, // 6D8EEF
MovementStatusElements.TransportGuidByte4, // 6D8F21
MovementStatusElements.TransportGuidByte0, // 6D8F53
MovementStatusElements.TransportHaveTime2, // 6D8F84
MovementStatusElements.TransportGuidByte6, // 6D8FCF
MovementStatusElements.TransportGuidByte3, // 6D9001
MovementStatusElements.TransportGuidByte2, // 6D9033
MovementStatusElements.TransportGuidByte7, // 6D9065
MovementStatusElements.TransportHaveTime3, // 6D9097
MovementStatusElements.TransportGuidByte5, // 6D90E2
MovementStatusElements.GuidByte1, // 6D910A
MovementStatusElements.GuidByte6, // 6D9129
MovementStatusElements.Pitch, // 6D915F
MovementStatusElements.GuidByte1_2, // 6D9164
MovementStatusElements.GuidByte7_2, // 6D917D
MovementStatusElements.FallTime, // 6D91B9
MovementStatusElements.FallHorizontalSpeed, // 6D91F4
MovementStatusElements.FallCosAngle, // 6D9215
MovementStatusElements.FallSinAngle, // 6D9221
MovementStatusElements.FallVerticalSpeed, // 6D923B
MovementStatusElements.GenericDword0, // 6D9249
MovementStatusElements.Timestamp, // 6D9254
MovementStatusElements.PositionO, // 6D925F
MovementStatusElements.GuidByte5_2, // 6D9264
MovementStatusElements.GuidByte3_2, // 6D927D
MovementStatusElements.GuidByte2_2, // 6D9296
MovementStatusElements.GuidByte4_2, // 6D92AF
MovementStatusElements.SplineElev, // 6D92EF
MovementStatusElements.TransportGuidByte7_2, // 6D9314
MovementStatusElements.TransportGuidByte3_2, // 6D9349
MovementStatusElements.TransportGuidByte1_2, // 6D937E
MovementStatusElements.TransportSeat, // 6D93B9
MovementStatusElements.TransportTime2, // 6D93F1
MovementStatusElements.TransportGuidByte0_2, // 6D9402
MovementStatusElements.TransportGuidByte6_2, // 6D9432
MovementStatusElements.TransportPositionX, // 6D946B
MovementStatusElements.TransportPositionY, // 6D9477
MovementStatusElements.TransportPositionZ, // 6D9483
MovementStatusElements.TransportGuidByte4_2, // 6D9494
MovementStatusElements.TransportPositionO, // 6D94CF
MovementStatusElements.TransportTime3, // 6D9507
MovementStatusElements.TransportGuidByte5_2, // 6D9518
MovementStatusElements.TransportTime, // 6D9553
MovementStatusElements.TransportGuidByte2_2, // 6D9564
MovementStatusElements.PositionX, // 6D9591
MovementStatusElements.PositionY, // 6D959D
MovementStatusElements.PositionZ, // 6D95A9
MovementStatusElements.GuidByte0_2, // 6D95AF
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_SWIM_SPEED; }
        }
    }
}
