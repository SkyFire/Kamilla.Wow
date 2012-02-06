
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetPitchRate : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte5, // 6D412C
MovementStatusElements.HaveFallData, // 6D413D
MovementStatusElements.HaveFallDirection, // 6D415C
MovementStatusElements.GuidByte0, // 6D4182
MovementStatusElements.GuidByte6, // 6D41B0
MovementStatusElements.Flags, // 6D41C5
MovementStatusElements.HavePitch, // 6D41F3
MovementStatusElements.GuidByte3, // 6D421E
MovementStatusElements.GuidByte1, // 6D4253
MovementStatusElements.Flags2, // 6D4261
MovementStatusElements.HaveTransportData, // 6D4290
MovementStatusElements.TransportGuidByte1, // 6D42CA
MovementStatusElements.TransportGuidByte4, // 6D42FC
MovementStatusElements.TransportGuidByte0, // 6D432E
MovementStatusElements.TransportHaveTime2, // 6D435F
MovementStatusElements.TransportGuidByte6, // 6D43AA
MovementStatusElements.TransportGuidByte3, // 6D43DC
MovementStatusElements.TransportGuidByte2, // 6D440E
MovementStatusElements.TransportGuidByte7, // 6D4440
MovementStatusElements.TransportHaveTime3, // 6D4472
MovementStatusElements.TransportGuidByte5, // 6D44BD
MovementStatusElements.GuidByte2, // 6D44E5
MovementStatusElements.HaveSplineElev, // 6D450E
MovementStatusElements.HaveSpline, // 6D4544
MovementStatusElements.GuidByte7, // 6D456D
MovementStatusElements.GuidByte4, // 6D458D
MovementStatusElements.GuidByte6_2, // 6D4590
MovementStatusElements.Timestamp, // 6D45AF
MovementStatusElements.FallTime, // 6D45D7
MovementStatusElements.FallHorizontalSpeed, // 6D4612
MovementStatusElements.FallCosAngle, // 6D4633
MovementStatusElements.FallSinAngle, // 6D463F
MovementStatusElements.FallVerticalSpeed, // 6D4659
MovementStatusElements.PositionX, // 6D4665
MovementStatusElements.PositionY, // 6D4671
MovementStatusElements.PositionZ, // 6D467D
MovementStatusElements.GuidByte1_2, // 6D4685
MovementStatusElements.GuidByte2_2, // 6D469E
MovementStatusElements.GuidByte0_2, // 6D46B7
MovementStatusElements.GuidByte5_2, // 6D46D0
MovementStatusElements.GuidByte3_2, // 6D46E9
MovementStatusElements.GenericDword0, // 6D470B
MovementStatusElements.Pitch, // 6D472B
MovementStatusElements.TransportGuidByte7_2, // 6D4750
MovementStatusElements.TransportGuidByte3_2, // 6D4782
MovementStatusElements.TransportGuidByte1_2, // 6D47B4
MovementStatusElements.TransportSeat, // 6D47EF
MovementStatusElements.TransportTime2, // 6D4827
MovementStatusElements.TransportGuidByte0_2, // 6D4838
MovementStatusElements.TransportGuidByte6_2, // 6D4868
MovementStatusElements.TransportPositionX, // 6D48A1
MovementStatusElements.TransportPositionY, // 6D48AD
MovementStatusElements.TransportPositionZ, // 6D48B9
MovementStatusElements.TransportGuidByte4_2, // 6D48CA
MovementStatusElements.TransportPositionO, // 6D4905
MovementStatusElements.TransportTime3, // 6D493D
MovementStatusElements.TransportGuidByte5_2, // 6D494E
MovementStatusElements.TransportTime, // 6D4989
MovementStatusElements.TransportGuidByte2_2, // 6D499A
MovementStatusElements.SplineElev, // 6D49E6
MovementStatusElements.GuidByte4_2, // 6D49FF
MovementStatusElements.GuidByte7_2, // 6D4A18
MovementStatusElements.PositionO, // 6D4A37
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_PITCH_RATE; }
        }
    }
}
