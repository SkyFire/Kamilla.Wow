using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public sealed class WowCorpse : WowObject
    {
        public WowCorpse()
            : base(ObjectTypeId.Corpse)
        {
        }
    }
}
