using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Latest
{
    public static class SpecialWowOpcodes
    {
        public const uint UnknownOpcode = SpecialOpcodes.UnknownOpcode;
        public const uint HelloOpcode = uint.MaxValue - 2;
    }
}
