using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    public class GossipMenuOption
    {
        public uint OptionId;
        public byte Icon;
        public bool IsPasswordRequired;
        public uint MoneyRequired;
        public string Text;
        public string BoxText;
    }

    public struct GossipMenuOptionEqualityComparer : IEqualityComparer<GossipMenuOption>
    {
        public static readonly IEqualityComparer<GossipMenuOption> Instance = new GossipMenuOptionEqualityComparer();

        public bool Equals(GossipMenuOption x, GossipMenuOption y)
        {
            return (object)x == (object)y || (
                x.BoxText == y.BoxText &&
                x.Icon == y.Icon &&
                x.IsPasswordRequired == y.IsPasswordRequired &&
                x.MoneyRequired == y.MoneyRequired &&
                x.OptionId == y.OptionId &&
                x.Text == y.Text);
        }

        public int GetHashCode(GossipMenuOption opt)
        {
            return
                opt.BoxText.GetHashCode() ^
                opt.Icon.GetHashCode() ^
                opt.IsPasswordRequired.GetHashCode() ^
                opt.MoneyRequired.GetHashCode() ^
                opt.OptionId.GetHashCode() ^
                opt.Text.GetHashCode();
        }
    }

    public class GossipMenu : IEquatable<GossipMenu>
    {
        public uint MenuId;
        public uint TextId;

        public GossipMenuOption[] GossipOptions;

        public bool Equals(GossipMenu menu)
        {
            return (object)this == (object)menu || (
                this.MenuId == menu.MenuId &&
                this.TextId == menu.TextId &&
                this.GossipOptions.SequenceEqual(menu.GossipOptions, GossipMenuOptionEqualityComparer.Instance)
                );
        }
    }
}
