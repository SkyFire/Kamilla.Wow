
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    internal sealed class MoveStartAscend : RegularMovementPacket
    {
        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToServer; }
        }

        protected override RegularMovementPacket.MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte2, // 68E47C
MovementStatusElements.GuidByte3, // 68E485
MovementStatusElements.GuidByte6, // 68E48F
MovementStatusElements.GuidByte4, // 68E499
MovementStatusElements.GuidByte0, // 68E4A3
MovementStatusElements.HaveSpline, // 68E4AF
MovementStatusElements.GuidByte1, // 68E4B5
MovementStatusElements.GuidByte5, // 68E4BF
MovementStatusElements.Flags, // 68E4EB
MovementStatusElements.Flags2, // 68E4FF
MovementStatusElements.GuidByte7, // 68E504
MovementStatusElements.HaveTransportData, // 68E535
MovementStatusElements.TransportGuidByte6, // 68E55C
MovementStatusElements.TransportGuidByte3, // 68E590
MovementStatusElements.TransportGuidByte7, // 68E5C1
MovementStatusElements.TransportGuidByte4, // 68E5F2
MovementStatusElements.TransportGuidByte1, // 68E623
MovementStatusElements.TransportGuidByte0, // 68E654
MovementStatusElements.TransportGuidByte2, // 68E684
MovementStatusElements.TransportGuidByte5, // 68E6B5
MovementStatusElements.TransportHaveTime3, // 68E6E8
MovementStatusElements.TransportHaveTime2, // 68E714
MovementStatusElements.HaveFallData, // 68E734
MovementStatusElements.HaveFallTransferDirection, // 68E759
MovementStatusElements.HavePitch, // 68E77F
MovementStatusElements.HaveSplineElev, // 68E79F
MovementStatusElements.PositionO, // 68E7CA
MovementStatusElements.PositionX, // 68E7DB
MovementStatusElements.PositionY, // 68E7E9
MovementStatusElements.PositionZ, // 68E7F7
MovementStatusElements.Timestamp, // 68E80B
MovementStatusElements.TransportTime, // 68E822
MovementStatusElements.TransportPositionX, // 68E833
MovementStatusElements.TransportPositionY, // 68E842
MovementStatusElements.TransportPositionZ, // 68E851
MovementStatusElements.TransportPositionO, // 68E86C
MovementStatusElements.TransportSeat, // 68E890
MovementStatusElements.TransportGuidByte3_2, // 68E8A1
MovementStatusElements.TransportGuidByte1_2, // 68E8CF
MovementStatusElements.TransportTime3, // 68E91F
MovementStatusElements.TransportGuidByte6_2, // 68E930
MovementStatusElements.TransportGuidByte0_2, // 68E95E
MovementStatusElements.TransportGuidByte5_2, // 68E989
MovementStatusElements.TransportTime2, // 68E9D9
MovementStatusElements.TransportGuidByte7_2, // 68E9EA
MovementStatusElements.TransportGuidByte4_2, // 68EA18
MovementStatusElements.TransportGuidByte2_2, // 68EA46
MovementStatusElements.GuidByte5_2, // 68EA79
MovementStatusElements.GuidByte3_2, // 68EA8D
MovementStatusElements.GuidByte4_2, // 68EAA1
MovementStatusElements.FallVerticalSpeed, // 68EAAF
MovementStatusElements.FallTime, // 68EAD4
MovementStatusElements.FallHorizontalSpeed, // 68EB02
MovementStatusElements.FallCosAngle, // 68EB28
MovementStatusElements.FallSinAngle, // 68EB36
MovementStatusElements.GuidByte0_2, // 68EB57
MovementStatusElements.GuidByte2_2, // 68EB6B
MovementStatusElements.Pitch, // 68EB75
MovementStatusElements.GuidByte6_2, // 68EB95
MovementStatusElements.SplineElev, // 68EBA2
MovementStatusElements.GuidByte7_2, // 68EBC8
MovementStatusElements.GuidByte1_2, // 68EBDC
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_ASCEND; }
        }
    }
}
