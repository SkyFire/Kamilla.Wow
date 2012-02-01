
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceSetCollisionHeightAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_COLLISION_HEIGHT_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte1, // 68235C
MovementStatusElements.GuidByte6, // 682368
MovementStatusElements.GuidByte0, // 682373
MovementStatusElements.Flags, // 68238E
MovementStatusElements.GuidByte5, // 682393
MovementStatusElements.Flags2, // 6823D0
MovementStatusElements.GuidByte4, // 6823D5
MovementStatusElements.GuidByte2, // 682404
MovementStatusElements.GuidByte3, // 682429
MovementStatusElements.GuidByte7, // 68244E
MovementStatusElements.HaveSpline, // 682475
MovementStatusElements.HavePitch, // 682498
MovementStatusElements.HaveFallData, // 6824B8
MovementStatusElements.HaveFallTransferDirection, // 6824DD
MovementStatusElements.HaveTransportData, // 682503
MovementStatusElements.TransportGuidByte6, // 68252A
MovementStatusElements.TransportGuidByte3, // 68255E
MovementStatusElements.TransportGuidByte7, // 68258F
MovementStatusElements.TransportGuidByte4, // 6825C0
MovementStatusElements.TransportGuidByte1, // 6825F1
MovementStatusElements.TransportGuidByte0, // 682622
MovementStatusElements.TransportGuidByte2, // 682652
MovementStatusElements.TransportGuidByte5, // 682683
MovementStatusElements.TransportHaveTime3, // 6826B6
MovementStatusElements.TransportHaveTime2, // 6826E2
MovementStatusElements.HaveSplineElev, // 682702
MovementStatusElements.PositionX, // 68272D
MovementStatusElements.PositionY, // 68273E
MovementStatusElements.PositionZ, // 68274C
MovementStatusElements.GenericDword2, // 68275A
MovementStatusElements.PositionO, // 68276B
MovementStatusElements.Timestamp, // 68277F
MovementStatusElements.GenericDword0, // 68278D
MovementStatusElements.Pitch, // 682797
MovementStatusElements.GuidByte1_2, // 6827B7
MovementStatusElements.GuidByte4_2, // 6827CB
MovementStatusElements.FallVerticalSpeed, // 6827D9
MovementStatusElements.FallTime, // 6827FE
MovementStatusElements.FallHorizontalSpeed, // 68282C
MovementStatusElements.FallCosAngle, // 682852
MovementStatusElements.FallSinAngle, // 682860
MovementStatusElements.GuidByte0_2, // 682881
MovementStatusElements.TransportTime, // 682899
MovementStatusElements.TransportPositionX, // 6828AA
MovementStatusElements.TransportPositionY, // 6828B9
MovementStatusElements.TransportPositionZ, // 6828C8
MovementStatusElements.TransportPositionO, // 6828E3
MovementStatusElements.TransportSeat, // 682907
MovementStatusElements.TransportGuidByte3_2, // 682918
MovementStatusElements.TransportGuidByte1_2, // 682946
MovementStatusElements.TransportTime3, // 682996
MovementStatusElements.TransportGuidByte6_2, // 6829A7
MovementStatusElements.TransportGuidByte0_2, // 6829D5
MovementStatusElements.TransportGuidByte5_2, // 682A00
MovementStatusElements.TransportTime2, // 682A50
MovementStatusElements.TransportGuidByte7_2, // 682A61
MovementStatusElements.TransportGuidByte4_2, // 682A8F
MovementStatusElements.TransportGuidByte2_2, // 682ABD
MovementStatusElements.GuidByte7_2, // 682AF0
MovementStatusElements.GuidByte3_2, // 682B04
MovementStatusElements.GuidByte5_2, // 682B18
MovementStatusElements.GuidByte6_2, // 682B2C
MovementStatusElements.GuidByte2_2, // 682B40
MovementStatusElements.SplineElev, // 682B4D
                };
            }
        }
    }
}
