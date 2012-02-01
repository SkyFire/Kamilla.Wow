
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceRootAck : ForceAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FORCE_ROOT_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte4, // 66FB2C
MovementStatusElements.GuidByte0, // 66FB35
MovementStatusElements.HaveSpline, // 66FB47
MovementStatusElements.Flags, // 66FB58
MovementStatusElements.GuidByte1, // 66FB61
MovementStatusElements.GuidByte6, // 66FB8F
MovementStatusElements.GuidByte2, // 66FBB4
MovementStatusElements.GuidByte5, // 66FBD9
MovementStatusElements.GuidByte7, // 66FBFE
MovementStatusElements.Flags2, // 66FC30
MovementStatusElements.GuidByte3, // 66FC39
MovementStatusElements.HaveFallData, // 66FC69
MovementStatusElements.HaveFallTransferDirection, // 66FC8E
MovementStatusElements.HavePitch, // 66FCB4
MovementStatusElements.HaveSplineElev, // 66FCD4
MovementStatusElements.HaveTransportData, // 66FCF7
MovementStatusElements.TransportGuidByte6, // 66FD24
MovementStatusElements.TransportGuidByte3, // 66FD58
MovementStatusElements.TransportGuidByte7, // 66FD89
MovementStatusElements.TransportGuidByte4, // 66FDBA
MovementStatusElements.TransportGuidByte1, // 66FDEB
MovementStatusElements.TransportGuidByte0, // 66FE1C
MovementStatusElements.TransportGuidByte2, // 66FE4C
MovementStatusElements.TransportGuidByte5, // 66FE7D
MovementStatusElements.TransportHaveTime3, // 66FEB0
MovementStatusElements.TransportHaveTime2, // 66FEDC
MovementStatusElements.Timestamp, // 66FF0A
MovementStatusElements.GenericDword0, // 66FF18
MovementStatusElements.PositionX, // 66FF20
MovementStatusElements.PositionY, // 66FF2E
MovementStatusElements.PositionZ, // 66FF3C
MovementStatusElements.PositionO, // 66FF4A
MovementStatusElements.FallVerticalSpeed, // 66FF61
MovementStatusElements.FallTime, // 66FF83
MovementStatusElements.FallHorizontalSpeed, // 66FFB4
MovementStatusElements.FallCosAngle, // 66FFDA
MovementStatusElements.FallSinAngle, // 66FFE8
MovementStatusElements.Pitch, // 66FFFF
MovementStatusElements.GuidByte2_2, // 67001C
MovementStatusElements.GuidByte3_2, // 670030
MovementStatusElements.GuidByte1_2, // 670044
MovementStatusElements.GuidByte4_2, // 670058
MovementStatusElements.GuidByte6_2, // 67006C
MovementStatusElements.GuidByte7_2, // 670080
MovementStatusElements.GuidByte0_2, // 670094
MovementStatusElements.SplineElev, // 6700A4
MovementStatusElements.GuidByte5_2, // 6700C7
MovementStatusElements.TransportTime, // 6700DE
MovementStatusElements.TransportPositionX, // 6700F2
MovementStatusElements.TransportPositionY, // 670101
MovementStatusElements.TransportPositionZ, // 670110
MovementStatusElements.TransportPositionO, // 67012B
MovementStatusElements.TransportSeat, // 67014C
MovementStatusElements.TransportGuidByte3_2, // 670160
MovementStatusElements.TransportGuidByte1_2, // 67018E
MovementStatusElements.TransportTime3, // 6701DB
MovementStatusElements.TransportGuidByte6_2, // 6701EF
MovementStatusElements.TransportGuidByte0_2, // 67021D
MovementStatusElements.TransportGuidByte5_2, // 670248
MovementStatusElements.TransportTime2, // 670295
MovementStatusElements.TransportGuidByte7_2, // 6702A9
MovementStatusElements.TransportGuidByte4_2, // 6702D7
MovementStatusElements.TransportGuidByte2_2, // 670305
                };
            }
        }
    }
}
