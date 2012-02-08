
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class SetWalkSpeed : MoveSetPacket
    {
        protected override MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE_WALK_SPEED; }
        }
    }
}
