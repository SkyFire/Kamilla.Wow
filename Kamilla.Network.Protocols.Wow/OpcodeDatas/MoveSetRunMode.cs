﻿
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public sealed class MoveSetRunMode : RegularMovementPacket
    {
        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_RUN_MODE; }
        }

        protected override TransferDirection Direction
        {
            get { return TransferDirection.ToServer; }
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
