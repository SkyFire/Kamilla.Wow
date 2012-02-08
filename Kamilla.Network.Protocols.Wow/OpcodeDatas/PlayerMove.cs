
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class PlayerMove : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.SMSG_MOVE_UPDATE; }
        }

        protected override TransferDirection TransferDirection
        {
            get { return TransferDirection.ToClient; }
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
