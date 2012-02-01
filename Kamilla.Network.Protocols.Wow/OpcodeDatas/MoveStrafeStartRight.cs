
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveStrafeStartRight : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_START_STRAFE_RIGHT; }
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
MovementStatusElements.GuidByte2, // 69E51F
MovementStatusElements.Flags, // 69E52C
MovementStatusElements.GuidByte3, // 69E53F
MovementStatusElements.Flags2, // 69E578
MovementStatusElements.GuidByte0, // 69E581
MovementStatusElements.GuidByte6, // 69E5B0
MovementStatusElements.HaveSpline, // 69E5D7
MovementStatusElements.GuidByte1, // 69E5F8
MovementStatusElements.GuidByte4, // 69E61D
MovementStatusElements.GuidByte5, // 69E642
MovementStatusElements.GuidByte7, // 69E667
MovementStatusElements.HaveSplineElev, // 69E68E
MovementStatusElements.HavePitch, // 69E6B1
MovementStatusElements.HaveTransportData, // 69E6D1
MovementStatusElements.TransportGuidByte6, // 69E6F8
MovementStatusElements.TransportGuidByte3, // 69E72C
MovementStatusElements.TransportGuidByte7, // 69E75D
MovementStatusElements.TransportGuidByte4, // 69E78E
MovementStatusElements.TransportGuidByte1, // 69E7BF
MovementStatusElements.TransportGuidByte0, // 69E7F0
MovementStatusElements.TransportGuidByte2, // 69E820
MovementStatusElements.TransportGuidByte5, // 69E851
MovementStatusElements.TransportHaveTime3, // 69E884
MovementStatusElements.TransportHaveTime2, // 69E8B0
MovementStatusElements.HaveFallData, // 69E8D0
MovementStatusElements.HaveFallTransferDirection, // 69E8FB
MovementStatusElements.Timestamp, // 69E92F
MovementStatusElements.PositionO, // 69E937
MovementStatusElements.PositionX, // 69E945
MovementStatusElements.GuidByte7_2, // 69E97B
MovementStatusElements.GuidByte1_2, // 69E98F
MovementStatusElements.SplineElev, // 69E99F
MovementStatusElements.GuidByte3_2, // 69E9C2
MovementStatusElements.Pitch, // 69E9CF
MovementStatusElements.TransportTime, // 69E9EF
MovementStatusElements.TransportPositionX, // 69EA03
MovementStatusElements.TransportPositionO, // 69EA3C
MovementStatusElements.TransportSeat, // 69EA5D
MovementStatusElements.TransportGuidByte3_2, // 69EA71
MovementStatusElements.TransportGuidByte1_2, // 69EA9F
MovementStatusElements.TransportTime3, // 69EAEC
MovementStatusElements.TransportGuidByte6_2, // 69EB00
MovementStatusElements.TransportGuidByte0_2, // 69EB2E
MovementStatusElements.TransportGuidByte5_2, // 69EB59
MovementStatusElements.TransportTime2, // 69EBA6
MovementStatusElements.TransportGuidByte7_2, // 69EBBA
MovementStatusElements.TransportGuidByte4_2, // 69EBE8
MovementStatusElements.TransportGuidByte2_2, // 69EC16
MovementStatusElements.GuidByte5_2, // 69EC46
MovementStatusElements.GuidByte2_2, // 69EC5A
MovementStatusElements.GuidByte6_2, // 69EC6E
MovementStatusElements.GuidByte4_2, // 69EC82
MovementStatusElements.GuidByte0_2, // 69EC96
MovementStatusElements.FallVerticalSpeed, // 69ECA7
MovementStatusElements.FallTime, // 69ECC9
MovementStatusElements.FallHorizontalSpeed, // 69ECFA
MovementStatusElements.FallCosAngle, // 69ED20
MovementStatusElements.FallSinAngle, // 69ED2D
                };
            }
        }
    }
}
