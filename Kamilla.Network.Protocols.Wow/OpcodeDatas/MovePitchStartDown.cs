
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MovePitchStartDown : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_PITCH_DOWN; }
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
MovementStatusElements.GuidByte3, // 687B2C
MovementStatusElements.GuidByte7, // 687B38
MovementStatusElements.GuidByte1, // 687B43
MovementStatusElements.Flags, // 687B5E
MovementStatusElements.GuidByte6, // 687B63
MovementStatusElements.HaveSpline, // 687B95
MovementStatusElements.Flags2, // 687BC8
MovementStatusElements.GuidByte5, // 687BCD
MovementStatusElements.GuidByte0, // 687BFC
MovementStatusElements.GuidByte2, // 687C21
MovementStatusElements.GuidByte4, // 687C46
MovementStatusElements.HavePitch, // 687C6D
MovementStatusElements.HaveTransportData, // 687C8D
MovementStatusElements.TransportGuidByte6, // 687CB4
MovementStatusElements.TransportGuidByte3, // 687CE8
MovementStatusElements.TransportGuidByte7, // 687D19
MovementStatusElements.TransportGuidByte4, // 687D4A
MovementStatusElements.TransportGuidByte1, // 687D7B
MovementStatusElements.TransportGuidByte0, // 687DAC
MovementStatusElements.TransportGuidByte2, // 687DDC
MovementStatusElements.TransportGuidByte5, // 687E0D
MovementStatusElements.TransportHaveTime3, // 687E40
MovementStatusElements.TransportHaveTime2, // 687E6C
MovementStatusElements.HaveFallData, // 687E8C
MovementStatusElements.HaveFallTransferDirection, // 687EB1
MovementStatusElements.HaveSplineElev, // 687ED7
MovementStatusElements.Timestamp, // 687F0B
MovementStatusElements.PositionX, // 687F10
MovementStatusElements.PositionY, // 687F1E
MovementStatusElements.PositionZ, // 687F2C
MovementStatusElements.PositionO, // 687F3A
MovementStatusElements.GuidByte3_2, // 687F48
MovementStatusElements.GuidByte4_2, // 687F5C
MovementStatusElements.GuidByte0_2, // 687F70
MovementStatusElements.GuidByte7_2, // 687F84
MovementStatusElements.GuidByte6_2, // 687F98
MovementStatusElements.GuidByte2_2, // 687FAC
MovementStatusElements.Pitch, // 687FC5
MovementStatusElements.TransportTime, // 687FE8
MovementStatusElements.TransportPositionX, // 687FF9
MovementStatusElements.TransportPositionY, // 688008
MovementStatusElements.TransportPositionZ, // 688017
MovementStatusElements.TransportPositionO, // 688032
MovementStatusElements.TransportSeat, // 688056
MovementStatusElements.TransportGuidByte3_2, // 688067
MovementStatusElements.TransportGuidByte1_2, // 688095
MovementStatusElements.TransportTime3, // 6880E5
MovementStatusElements.TransportGuidByte6_2, // 6880F6
MovementStatusElements.TransportGuidByte0_2, // 688124
MovementStatusElements.TransportGuidByte5_2, // 68814F
MovementStatusElements.TransportTime2, // 68819F
MovementStatusElements.TransportGuidByte7_2, // 6881B0
MovementStatusElements.TransportGuidByte4_2, // 6881DE
MovementStatusElements.TransportGuidByte2_2, // 68820C
MovementStatusElements.FallVerticalSpeed, // 688236
MovementStatusElements.FallTime, // 68825E
MovementStatusElements.FallHorizontalSpeed, // 68828C
MovementStatusElements.FallCosAngle, // 6882B2
MovementStatusElements.FallSinAngle, // 6882C0
MovementStatusElements.SplineElev, // 6882DA
MovementStatusElements.GuidByte5_2, // 6882F1
MovementStatusElements.GuidByte1_2, // 688305
                };
            }
        }
    }
}
