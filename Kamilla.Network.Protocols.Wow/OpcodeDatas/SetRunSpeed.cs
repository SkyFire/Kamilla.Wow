
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetRunSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.Flags, // 6D4CBF
MovementStatusElements.GuidByte3, // 6D4CE9
MovementStatusElements.HaveFallData, // 6D4D12
MovementStatusElements.HaveFallDirection, // 6D4D49
MovementStatusElements.GuidByte5, // 6D4D87
MovementStatusElements.HaveSpline, // 6D4DB1
MovementStatusElements.GuidByte6, // 6D4DD9
MovementStatusElements.GuidByte1, // 6D4DFC
MovementStatusElements.Flags2, // 6D4E1C
MovementStatusElements.GuidByte2, // 6D4E47
MovementStatusElements.HaveSplineElev, // 6D4E70
MovementStatusElements.HaveTransportData, // 6D4EA5
MovementStatusElements.TransportGuidByte1, // 6D4EDF
MovementStatusElements.TransportGuidByte4, // 6D4F11
MovementStatusElements.TransportGuidByte0, // 6D4F43
MovementStatusElements.TransportHaveTime2, // 6D4F74
MovementStatusElements.TransportGuidByte6, // 6D4FBF
MovementStatusElements.TransportGuidByte3, // 6D4FF1
MovementStatusElements.TransportGuidByte2, // 6D5023
MovementStatusElements.TransportGuidByte7, // 6D5055
MovementStatusElements.TransportHaveTime3, // 6D5087
MovementStatusElements.TransportGuidByte5, // 6D50D2
MovementStatusElements.GuidByte0, // 6D50FA
MovementStatusElements.GuidByte7, // 6D511F
MovementStatusElements.HavePitch, // 6D5148
MovementStatusElements.GuidByte4, // 6D516D
MovementStatusElements.GuidByte1_2, // 6D5170
MovementStatusElements.FallTime, // 6D51AC
MovementStatusElements.FallHorizontalSpeed, // 6D51E7
MovementStatusElements.FallCosAngle, // 6D5208
MovementStatusElements.FallSinAngle, // 6D5214
MovementStatusElements.FallVerticalSpeed, // 6D522E
MovementStatusElements.GuidByte5_2, // 6D5233
MovementStatusElements.PositionX, // 6D5253
MovementStatusElements.PositionY, // 6D525F
MovementStatusElements.PositionZ, // 6D526B
MovementStatusElements.SplineElev, // 6D5296
MovementStatusElements.GuidByte0_2, // 6D52AF
MovementStatusElements.GuidByte6_2, // 6D52C8
MovementStatusElements.GuidByte4_2, // 6D52E1
MovementStatusElements.TransportGuidByte7_2, // 6D531A
MovementStatusElements.TransportGuidByte3_2, // 6D534C
MovementStatusElements.TransportGuidByte1_2, // 6D537E
MovementStatusElements.TransportSeat, // 6D53B9
MovementStatusElements.TransportTime2, // 6D53F1
MovementStatusElements.TransportGuidByte0_2, // 6D5402
MovementStatusElements.TransportGuidByte6_2, // 6D5432
MovementStatusElements.TransportPositionX, // 6D546B
MovementStatusElements.TransportPositionY, // 6D5477
MovementStatusElements.TransportPositionZ, // 6D5483
MovementStatusElements.TransportGuidByte4_2, // 6D5494
MovementStatusElements.TransportPositionO, // 6D54CF
MovementStatusElements.TransportTime3, // 6D5507
MovementStatusElements.TransportGuidByte5_2, // 6D5518
MovementStatusElements.TransportTime, // 6D5553
MovementStatusElements.TransportGuidByte2_2, // 6D5564
MovementStatusElements.GuidByte7_2, // 6D558D
MovementStatusElements.Pitch, // 6D55C1
MovementStatusElements.GuidByte3_2, // 6D55C6
MovementStatusElements.GenericDword0, // 6D55E8
MovementStatusElements.PositionO, // 6D55F3
MovementStatusElements.Timestamp, // 6D55FE
MovementStatusElements.GuidByte2_2, // 6D5603
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_RUN_SPEED; }
        }
    }
}
