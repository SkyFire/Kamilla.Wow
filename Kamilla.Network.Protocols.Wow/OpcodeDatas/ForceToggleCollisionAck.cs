
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class ForceToggleCollisionAck : ForceChangeAckPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_TOGGLE_COLLISION_ACK; }
        }

        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
                };
            }
        }
    }
}
