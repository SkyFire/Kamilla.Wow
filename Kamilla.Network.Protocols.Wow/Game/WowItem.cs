using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    public class WowItem : WowObject
    {
        public const int MaxEnchantments = 12;

        public WowItem()
            : this(ObjectTypeId.Item)
        {
        }

        protected WowItem(ObjectTypeId type)
            : base(type)
        {
        }
    }
}
