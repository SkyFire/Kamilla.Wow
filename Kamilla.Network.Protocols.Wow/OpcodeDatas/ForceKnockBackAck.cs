
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceKnockBackAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_KNOCK_BACK_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 66EA0C
MovementStatusElements.GuidByte4, // 66EA15
MovementStatusElements.GuidByte2, // 66EA22
MovementStatusElements.GuidByte7, // 66EA2F
MovementStatusElements.GuidByte3, // 66EA3D
MovementStatusElements.GuidByte5, // 66EA47
MovementStatusElements.Flags, // 66EA5C
MovementStatusElements.GuidByte6, // 66EA61
MovementStatusElements.GuidByte0, // 66EA91
MovementStatusElements.HaveSpline, // 66EAB9
MovementStatusElements.Flags2, // 66EAEC
MovementStatusElements.HavePitch, // 66EAFC
MovementStatusElements.HaveFallData, // 66EB1C
MovementStatusElements.HaveFallDirection, // 66EB41
MovementStatusElements.HaveSplineElev, // 66EB67
MovementStatusElements.HaveTransportData, // 66EB8A
MovementStatusElements.TransportGuidByte6, // 66EBB7
MovementStatusElements.TransportGuidByte3, // 66EBEB
MovementStatusElements.TransportGuidByte7, // 66EC1C
MovementStatusElements.TransportGuidByte4, // 66EC4D
MovementStatusElements.TransportGuidByte1, // 66EC7E
MovementStatusElements.TransportGuidByte0, // 66ECAF
MovementStatusElements.TransportGuidByte2, // 66ECDF
MovementStatusElements.TransportGuidByte5, // 66ED10
MovementStatusElements.TransportHaveTime3, // 66ED43
MovementStatusElements.TransportHaveTime2, // 66ED6F
MovementStatusElements.GenericDword0, // 66EDA3
MovementStatusElements.PositionO, // 66EDA8
MovementStatusElements.Timestamp, // 66EDBC
MovementStatusElements.PositionX, // 66EDC1
MovementStatusElements.PositionY, // 66EDCF
MovementStatusElements.PositionZ, // 66EDDD
MovementStatusElements.Pitch, // 66EDF0
MovementStatusElements.GuidByte5_2, // 66EE10
MovementStatusElements.GuidByte1_2, // 66EE24
MovementStatusElements.FallVerticalSpeed, // 66EE32
MovementStatusElements.FallTime, // 66EE57
MovementStatusElements.FallHorizontalSpeed, // 66EE85
MovementStatusElements.FallCosAngle, // 66EEAB
MovementStatusElements.FallSinAngle, // 66EEB9
MovementStatusElements.GuidByte0_2, // 66EEDA
MovementStatusElements.GuidByte7_2, // 66EEEE
MovementStatusElements.SplineElev, // 66EEFB
MovementStatusElements.TransportTime, // 66EF25
MovementStatusElements.TransportPositionX, // 66EF36
MovementStatusElements.TransportPositionY, // 66EF45
MovementStatusElements.TransportPositionZ, // 66EF54
MovementStatusElements.TransportPositionO, // 66EF6F
MovementStatusElements.TransportSeat, // 66EF93
MovementStatusElements.TransportGuidByte3_2, // 66EFA4
MovementStatusElements.TransportGuidByte1_2, // 66EFD2
MovementStatusElements.TransportTime3, // 66F021
MovementStatusElements.TransportGuidByte6_2, // 66F032
MovementStatusElements.TransportGuidByte0_2, // 66F05F
MovementStatusElements.TransportGuidByte5_2, // 66F08B
MovementStatusElements.TransportTime2, // 66F0DB
MovementStatusElements.TransportGuidByte7_2, // 66F0EC
MovementStatusElements.TransportGuidByte4_2, // 66F11A
MovementStatusElements.TransportGuidByte2_2, // 66F147
MovementStatusElements.GuidByte4_2, // 66F17B
MovementStatusElements.GuidByte3_2, // 66F18F
MovementStatusElements.GuidByte2_2, // 66F1A3
MovementStatusElements.GuidByte6_2, // 66F1B7
                };
            }
        }
    }
}
