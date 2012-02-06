
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveStrafeStop : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_STOP_STRAFE; }
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
MovementStatusElements.GuidByte3, // 6A4FFF
MovementStatusElements.Flags, // 6A500C
MovementStatusElements.HaveSpline, // 6A502A
MovementStatusElements.GuidByte4, // 6A504C
MovementStatusElements.GuidByte0, // 6A5072
MovementStatusElements.Flags2, // 6A50A5
MovementStatusElements.GuidByte5, // 6A50AE
MovementStatusElements.GuidByte6, // 6A50DC
MovementStatusElements.GuidByte7, // 6A5101
MovementStatusElements.GuidByte1, // 6A5126
MovementStatusElements.GuidByte2, // 6A514B
MovementStatusElements.HaveTransportData, // 6A5172
MovementStatusElements.TransportGuidByte6, // 6A5199
MovementStatusElements.TransportGuidByte3, // 6A51CD
MovementStatusElements.TransportGuidByte7, // 6A51FE
MovementStatusElements.TransportGuidByte4, // 6A522F
MovementStatusElements.TransportGuidByte1, // 6A5260
MovementStatusElements.TransportGuidByte0, // 6A5291
MovementStatusElements.TransportGuidByte2, // 6A52C1
MovementStatusElements.TransportGuidByte5, // 6A52F2
MovementStatusElements.TransportHaveTime3, // 6A5325
MovementStatusElements.TransportHaveTime2, // 6A5351
MovementStatusElements.HaveSplineElev, // 6A5371
MovementStatusElements.HavePitch, // 6A5394
MovementStatusElements.HaveFallData, // 6A53B4
MovementStatusElements.HaveFallDirection, // 6A53DF
MovementStatusElements.PositionX, // 6A540D
MovementStatusElements.PositionO, // 6A543A
MovementStatusElements.Timestamp, // 6A544B
MovementStatusElements.GuidByte2_2, // 6A545F
MovementStatusElements.GuidByte7_2, // 6A5473
MovementStatusElements.GuidByte5_2, // 6A5487
MovementStatusElements.TransportTime, // 6A549E
MovementStatusElements.TransportPositionX, // 6A54B2
MovementStatusElements.TransportPositionO, // 6A54EB
MovementStatusElements.TransportSeat, // 6A550C
MovementStatusElements.TransportGuidByte3_2, // 6A5520
MovementStatusElements.TransportGuidByte1_2, // 6A554E
MovementStatusElements.TransportTime3, // 6A559B
MovementStatusElements.TransportGuidByte6_2, // 6A55AF
MovementStatusElements.TransportGuidByte0_2, // 6A55DD
MovementStatusElements.TransportGuidByte5_2, // 6A5608
MovementStatusElements.TransportTime2, // 6A5655
MovementStatusElements.TransportGuidByte7_2, // 6A5669
MovementStatusElements.TransportGuidByte4_2, // 6A5697
MovementStatusElements.TransportGuidByte2_2, // 6A56C5
MovementStatusElements.GuidByte0_2, // 6A56F5
MovementStatusElements.SplineElev, // 6A5705
MovementStatusElements.Pitch, // 6A5721
MovementStatusElements.FallVerticalSpeed, // 6A573B
MovementStatusElements.FallTime, // 6A575D
MovementStatusElements.FallHorizontalSpeed, // 6A578E
MovementStatusElements.FallCosAngle, // 6A57B4
MovementStatusElements.FallSinAngle, // 6A57C2
MovementStatusElements.GuidByte1_2, // 6A57E0
MovementStatusElements.GuidByte3_2, // 6A57F4
MovementStatusElements.GuidByte4_2, // 6A5808
MovementStatusElements.GuidByte6_2, // 6A581C
                };
            }
        }
    }
}
