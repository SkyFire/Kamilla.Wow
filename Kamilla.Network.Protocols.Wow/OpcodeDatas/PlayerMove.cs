
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class PlayerMove : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE; }
        }

        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToClient; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[] {
MovementStatusElements.HavePitch, // 6DB570
MovementStatusElements.GuidByte6, // 6DB581
MovementStatusElements.HaveFallData, // 6DB592
MovementStatusElements.HaveFallDirection, // 6DB5B1
MovementStatusElements.GuidByte1, // 6DB5D7
MovementStatusElements.GuidByte2, // 6DB605
MovementStatusElements.Flags2, // 6DB61A
MovementStatusElements.GuidByte0, // 6DB645
MovementStatusElements.HaveTransportData, // 6DB66E
MovementStatusElements.TransportGuidByte1, // 6DB6A8
MovementStatusElements.TransportGuidByte4, // 6DB6DA
MovementStatusElements.TransportGuidByte0, // 6DB70C
MovementStatusElements.TransportHaveTime2, // 6DB73D
MovementStatusElements.TransportGuidByte6, // 6DB788
MovementStatusElements.TransportGuidByte3, // 6DB7BA
MovementStatusElements.TransportGuidByte2, // 6DB7EC
MovementStatusElements.TransportGuidByte7, // 6DB81E
MovementStatusElements.TransportHaveTime3, // 6DB850
MovementStatusElements.TransportGuidByte5, // 6DB89B
MovementStatusElements.GuidByte3, // 6DB8C3
MovementStatusElements.GuidByte4, // 6DB8E8
MovementStatusElements.GuidByte5, // 6DB90D
MovementStatusElements.HaveSpline, // 6DB937
MovementStatusElements.GuidByte7, // 6DB960
MovementStatusElements.HaveSplineElev, // 6DB990
MovementStatusElements.Flags, // 6DB9B1
MovementStatusElements.PositionO, // 6DB9B7
MovementStatusElements.GuidByte0_2, // 6DB9BF
MovementStatusElements.Pitch, // 6DB9F0
MovementStatusElements.GuidByte4_2, // 6DB9F8
MovementStatusElements.FallTime, // 6DBA31
MovementStatusElements.FallHorizontalSpeed, // 6DBA6C
MovementStatusElements.FallCosAngle, // 6DBA8F
MovementStatusElements.FallSinAngle, // 6DBA9B
MovementStatusElements.FallVerticalSpeed, // 6DBAB3
MovementStatusElements.Timestamp, // 6DBABE
MovementStatusElements.GuidByte1_2, // 6DBAC6
MovementStatusElements.TransportGuidByte7_2, // 6DBAFF
MovementStatusElements.TransportGuidByte3_2, // 6DBB31
MovementStatusElements.TransportGuidByte1_2, // 6DBB63
MovementStatusElements.TransportSeat, // 6DBB9B
MovementStatusElements.TransportTime2, // 6DBBD3
MovementStatusElements.TransportGuidByte0_2, // 6DBBE7
MovementStatusElements.TransportGuidByte6_2, // 6DBC17
MovementStatusElements.TransportPositionX, // 6DBC4F
MovementStatusElements.TransportGuidByte4_2, // 6DBC79
MovementStatusElements.TransportPositionO, // 6DBCB1
MovementStatusElements.TransportTime3, // 6DBCE9
MovementStatusElements.TransportGuidByte5_2, // 6DBCFD
MovementStatusElements.TransportTime, // 6DBD35
MovementStatusElements.TransportGuidByte2_2, // 6DBD49
MovementStatusElements.GuidByte2_2, // 6DBD6F
MovementStatusElements.PositionX, // 6DBD8F
MovementStatusElements.GuidByte6_2, // 6DBDB0
MovementStatusElements.SplineElev, // 6DBDED
MovementStatusElements.GuidByte5_2, // 6DBDF5
MovementStatusElements.GuidByte3_2, // 6DBE0E
MovementStatusElements.GuidByte7_2, // 6DBE27
                };
            }
        }
    }
}
