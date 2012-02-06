
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetCollisionHeight : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
MovementStatusElements.GuidByte2, // 6D6928
MovementStatusElements.GuidByte3, // 6D6933
MovementStatusElements.GuidByte4, // 6D693E
MovementStatusElements.Flags, // 6D695F
MovementStatusElements.GuidByte5, // 6D6989
MovementStatusElements.HaveFallData, // 6D69B2
MovementStatusElements.HaveFallDirection, // 6D69E9
MovementStatusElements.HavePitch, // 6D6A2B
MovementStatusElements.HaveTransportData, // 6D6A60
MovementStatusElements.TransportGuidByte1, // 6D6A9A
MovementStatusElements.TransportGuidByte4, // 6D6ACC
MovementStatusElements.TransportGuidByte0, // 6D6AFE
MovementStatusElements.TransportHaveTime2, // 6D6B2F
MovementStatusElements.TransportGuidByte6, // 6D6B7A
MovementStatusElements.TransportGuidByte3, // 6D6BAC
MovementStatusElements.TransportGuidByte2, // 6D6BDE
MovementStatusElements.TransportGuidByte7, // 6D6C10
MovementStatusElements.TransportHaveTime3, // 6D6C42
MovementStatusElements.TransportGuidByte5, // 6D6C93
MovementStatusElements.Flags2, // 6D6CAB
MovementStatusElements.HaveSpline, // 6D6CDB
MovementStatusElements.GuidByte0, // 6D6D03
MovementStatusElements.HaveSplineElev, // 6D6D2C
MovementStatusElements.GuidByte7, // 6D6D5D
MovementStatusElements.GuidByte6, // 6D6D82
MovementStatusElements.GuidByte1, // 6D6DAA
MovementStatusElements.GenericDword0, // 6D6DAD
MovementStatusElements.GuidByte3_2, // 6D6DB2
MovementStatusElements.PositionX, // 6D6DD2
MovementStatusElements.PositionY, // 6D6DDE
MovementStatusElements.PositionZ, // 6D6DEA
MovementStatusElements.GuidByte1_2, // 6D6DF2
MovementStatusElements.GuidByte7_2, // 6D6E0B
MovementStatusElements.GuidByte6_2, // 6D6E24
MovementStatusElements.GuidByte5_2, // 6D6E3D
MovementStatusElements.GuidByte4_2, // 6D6E56
MovementStatusElements.FallTime, // 6D6E92
MovementStatusElements.FallHorizontalSpeed, // 6D6ECD
MovementStatusElements.FallCosAngle, // 6D6EEE
MovementStatusElements.FallSinAngle, // 6D6EFA
MovementStatusElements.FallVerticalSpeed, // 6D6F14
MovementStatusElements.Pitch, // 6D6F34
MovementStatusElements.TransportGuidByte7_2, // 6D6F59
MovementStatusElements.TransportGuidByte3_2, // 6D6F8B
MovementStatusElements.TransportGuidByte1_2, // 6D6FBD
MovementStatusElements.TransportSeat, // 6D6FF8
MovementStatusElements.TransportTime2, // 6D7030
MovementStatusElements.TransportGuidByte0_2, // 6D7041
MovementStatusElements.TransportGuidByte6_2, // 6D7071
MovementStatusElements.TransportPositionX, // 6D70AA
MovementStatusElements.TransportPositionY, // 6D70B6
MovementStatusElements.TransportPositionZ, // 6D70C2
MovementStatusElements.TransportGuidByte4_2, // 6D70D3
MovementStatusElements.TransportPositionO, // 6D710E
MovementStatusElements.TransportTime3, // 6D7146
MovementStatusElements.TransportGuidByte5_2, // 6D7157
MovementStatusElements.TransportTime, // 6D7192
MovementStatusElements.TransportGuidByte2_2, // 6D71A3
MovementStatusElements.Timestamp, // 6D71D2
MovementStatusElements.SplineElev, // 6D71FE
MovementStatusElements.GuidByte0_2, // 6D7203
MovementStatusElements.GuidByte2_2, // 6D721C
MovementStatusElements.PositionO, // 6D723B
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_COLLISION_HEIGHT; }
        }
    }
}
