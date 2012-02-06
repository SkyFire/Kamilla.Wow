
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveStop : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_STOP; }
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
MovementStatusElements.GuidByte4, // 688C8A
MovementStatusElements.GuidByte3, // 688C98
MovementStatusElements.Flags, // 688CAA
MovementStatusElements.GuidByte5, // 688CBA
MovementStatusElements.GuidByte6, // 688CE9
MovementStatusElements.GuidByte0, // 688D0F
MovementStatusElements.GuidByte1, // 688D35
MovementStatusElements.GuidByte2, // 688D5B
MovementStatusElements.GuidByte7, // 688D81
MovementStatusElements.HaveSpline, // 688DA9
MovementStatusElements.Flags2, // 688DDA
MovementStatusElements.HavePitch, // 688DEE
MovementStatusElements.HaveSplineElev, // 688E0E
MovementStatusElements.HaveFallData, // 688E31
MovementStatusElements.HaveFallDirection, // 688E57
MovementStatusElements.HaveTransportData, // 688E7D
MovementStatusElements.TransportGuidByte6, // 688EAB
MovementStatusElements.TransportGuidByte3, // 688EE1
MovementStatusElements.TransportGuidByte7, // 688F14
MovementStatusElements.TransportGuidByte4, // 688F47
MovementStatusElements.TransportGuidByte1, // 688F7A
MovementStatusElements.TransportGuidByte0, // 688FAD
MovementStatusElements.TransportGuidByte2, // 688FDF
MovementStatusElements.TransportGuidByte5, // 689012
MovementStatusElements.TransportHaveTime3, // 689047
MovementStatusElements.TransportHaveTime2, // 689074
MovementStatusElements.Timestamp, // 6890A4
MovementStatusElements.PositionX, // 6890AC
//MovementStatusElements.PositionY, // 6890BA
//MovementStatusElements.PositionZ, // 6890C8
MovementStatusElements.PositionO, // 6890D6
MovementStatusElements.GuidByte6_2, // 6890F0
MovementStatusElements.GuidByte5_2, // 689104
MovementStatusElements.GuidByte1_2, // 689118
MovementStatusElements.GuidByte3_2, // 68912C
MovementStatusElements.Pitch, // 68913A
MovementStatusElements.GuidByte2_2, // 689157
MovementStatusElements.SplineElev, // 689168
MovementStatusElements.GuidByte4_2, // 68918B
MovementStatusElements.GuidByte0_2, // 68919F
MovementStatusElements.GuidByte7_2, // 6891B3
MovementStatusElements.FallVerticalSpeed, // 6891C5
MovementStatusElements.FallTime, // 6891E8
MovementStatusElements.FallHorizontalSpeed, // 68921D
MovementStatusElements.FallCosAngle, // 689245
MovementStatusElements.FallSinAngle, // 689252
MovementStatusElements.TransportTime, // 689270
MovementStatusElements.TransportPositionX, // 689285
//MovementStatusElements.TransportPositionY, // 689293
//MovementStatusElements.TransportPositionZ, // 6892A1
MovementStatusElements.TransportPositionO, // 6892BC
MovementStatusElements.TransportSeat, // 6892DB
MovementStatusElements.TransportGuidByte3_2, // 6892F0
MovementStatusElements.TransportGuidByte1_2, // 689320
MovementStatusElements.TransportTime3, // 689373
MovementStatusElements.TransportGuidByte6_2, // 689388
MovementStatusElements.TransportGuidByte0_2, // 6893B9
MovementStatusElements.TransportGuidByte5_2, // 6893E8
MovementStatusElements.TransportTime2, // 68943A
MovementStatusElements.TransportGuidByte7_2, // 68944F
MovementStatusElements.TransportGuidByte4_2, // 68947F
MovementStatusElements.TransportGuidByte2_2, // 6894B0
                };
            }
        }
    }
}
