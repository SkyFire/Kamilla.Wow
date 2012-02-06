
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MovePitchStop : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_STOP_PITCH; }
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
MovementStatusElements.GuidByte6, // 66C7EC
MovementStatusElements.GuidByte0, // 66C7F5
MovementStatusElements.GuidByte5, // 66C802
MovementStatusElements.GuidByte7, // 66C80D
MovementStatusElements.HaveSpline, // 66C81C
MovementStatusElements.GuidByte1, // 66C822
MovementStatusElements.Flags2, // 66C83B
MovementStatusElements.Flags, // 66C84E
MovementStatusElements.GuidByte3, // 66C853
MovementStatusElements.GuidByte4, // 66C882
MovementStatusElements.GuidByte2, // 66C8A7
MovementStatusElements.HaveTransportData, // 66C8CE
MovementStatusElements.TransportGuidByte6, // 66C8F5
MovementStatusElements.TransportGuidByte3, // 66C929
MovementStatusElements.TransportGuidByte7, // 66C95A
MovementStatusElements.TransportGuidByte4, // 66C98B
MovementStatusElements.TransportGuidByte1, // 66C9BC
MovementStatusElements.TransportGuidByte0, // 66C9ED
MovementStatusElements.TransportGuidByte2, // 66CA1D
MovementStatusElements.TransportGuidByte5, // 66CA4E
MovementStatusElements.TransportHaveTime3, // 66CA81
MovementStatusElements.TransportHaveTime2, // 66CAAD
MovementStatusElements.HavePitch, // 66CACD
MovementStatusElements.HaveFallData, // 66CAED
MovementStatusElements.HaveFallDirection, // 66CB12
MovementStatusElements.HaveSplineElev, // 66CB38
MovementStatusElements.Timestamp, // 66CB6C
MovementStatusElements.PositionO, // 66CB71
MovementStatusElements.PositionX, // 66CB7F
MovementStatusElements.PositionY, // 66CB8D
MovementStatusElements.PositionZ, // 66CB9B
MovementStatusElements.GuidByte3_2, // 66CBA9
MovementStatusElements.TransportTime, // 66CBCF
MovementStatusElements.TransportPositionX, // 66CBE0
MovementStatusElements.TransportPositionY, // 66CBEF
MovementStatusElements.TransportPositionZ, // 66CBFE
MovementStatusElements.TransportPositionO, // 66CC19
MovementStatusElements.TransportSeat, // 66CC3D
MovementStatusElements.TransportGuidByte3_2, // 66CC4E
MovementStatusElements.TransportGuidByte1_2, // 66CC7C
MovementStatusElements.TransportTime3, // 66CCCC
MovementStatusElements.TransportGuidByte6_2, // 66CCDD
MovementStatusElements.TransportGuidByte0_2, // 66CD0B
MovementStatusElements.TransportGuidByte5_2, // 66CD36
MovementStatusElements.TransportTime2, // 66CD86
MovementStatusElements.TransportGuidByte7_2, // 66CD97
MovementStatusElements.TransportGuidByte4_2, // 66CDC5
MovementStatusElements.TransportGuidByte2_2, // 66CDF3
MovementStatusElements.GuidByte0_2, // 66CE14
MovementStatusElements.GuidByte1_2, // 66CE2B
MovementStatusElements.Pitch, // 66CE44
MovementStatusElements.GuidByte7_2, // 66CE55
MovementStatusElements.GuidByte2_2, // 66CE69
MovementStatusElements.FallVerticalSpeed, // 66CE86
MovementStatusElements.FallTime, // 66CEAB
MovementStatusElements.FallHorizontalSpeed, // 66CED9
MovementStatusElements.FallCosAngle, // 66CEFF
MovementStatusElements.FallSinAngle, // 66CF0D
MovementStatusElements.GuidByte5_2, // 66CF1F
MovementStatusElements.GuidByte6_2, // 66CF33
MovementStatusElements.SplineElev, // 66CF4F
MovementStatusElements.GuidByte4_2, // 66CF66
                };
            }
        }
    }
}
