
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveFallLand : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_FALL_LAND; }
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
MovementStatusElements.GuidByte5, // 68123C
MovementStatusElements.GuidByte6, // 681245
MovementStatusElements.GuidByte4, // 681252
MovementStatusElements.GuidByte1, // 681260
MovementStatusElements.GuidByte2, // 68126A
MovementStatusElements.HaveSpline, // 68127A
MovementStatusElements.Flags2, // 681287
MovementStatusElements.GuidByte7, // 681290
MovementStatusElements.GuidByte3, // 6812BF
MovementStatusElements.GuidByte0, // 6812E5
MovementStatusElements.Flags, // 681317
MovementStatusElements.HaveFallData, // 68132B
MovementStatusElements.HaveFallTransferDirection, // 681350
MovementStatusElements.HaveTransportData, // 681376
MovementStatusElements.TransportGuidByte6, // 68139D
MovementStatusElements.TransportGuidByte3, // 6813D1
MovementStatusElements.TransportGuidByte7, // 681402
MovementStatusElements.TransportGuidByte4, // 681433
MovementStatusElements.TransportGuidByte1, // 681464
MovementStatusElements.TransportGuidByte0, // 681495
MovementStatusElements.TransportGuidByte2, // 6814C5
MovementStatusElements.TransportGuidByte5, // 6814F6
MovementStatusElements.TransportHaveTime3, // 681529
MovementStatusElements.TransportHaveTime2, // 681555
MovementStatusElements.HavePitch, // 681575
MovementStatusElements.HaveSplineElev, // 681595
MovementStatusElements.Timestamp, // 6815C6
MovementStatusElements.PositionX, // 6815CE
MovementStatusElements.PositionY, // 6815DC
MovementStatusElements.PositionZ, // 6815EA
MovementStatusElements.PositionO, // 6815F8
MovementStatusElements.GuidByte7_2, // 681612
MovementStatusElements.GuidByte2_2, // 681626
MovementStatusElements.GuidByte3_2, // 68163A
MovementStatusElements.GuidByte0_2, // 68164E
MovementStatusElements.GuidByte1_2, // 681662
MovementStatusElements.GuidByte5_2, // 681676
MovementStatusElements.FallVerticalSpeed, // 681687
MovementStatusElements.FallTime, // 6816A9
MovementStatusElements.FallHorizontalSpeed, // 6816DA
MovementStatusElements.FallCosAngle, // 681700
MovementStatusElements.FallSinAngle, // 68170E
MovementStatusElements.TransportTime, // 68172F
MovementStatusElements.TransportPositionX, // 681741
MovementStatusElements.TransportPositionY, // 681750
MovementStatusElements.TransportPositionZ, // 68175F
MovementStatusElements.TransportPositionO, // 68177A
MovementStatusElements.TransportSeat, // 68179B
MovementStatusElements.TransportGuidByte3_2, // 6817AF
MovementStatusElements.TransportGuidByte1_2, // 6817DD
MovementStatusElements.TransportTime3, // 68182A
MovementStatusElements.TransportGuidByte6_2, // 68183E
MovementStatusElements.TransportGuidByte0_2, // 68186C
MovementStatusElements.TransportGuidByte5_2, // 681897
MovementStatusElements.TransportTime2, // 6818E4
MovementStatusElements.TransportGuidByte7_2, // 6818F8
MovementStatusElements.TransportGuidByte4_2, // 681926
MovementStatusElements.TransportGuidByte2_2, // 681954
MovementStatusElements.Pitch, // 68197D
MovementStatusElements.SplineElev, // 681996
MovementStatusElements.GuidByte6_2, // 6819B9
MovementStatusElements.GuidByte4_2, // 6819CD
                };
            }
        }
    }
}
