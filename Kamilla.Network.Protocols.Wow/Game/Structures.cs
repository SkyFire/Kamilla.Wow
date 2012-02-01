using System.Globalization;
using System.Runtime.InteropServices;

namespace Kamilla.Network.Protocols.Wow.Game
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ItemEnchantmentInfo
    {
        public const int MaxItemEnchantments = 9;

        public uint Id;
        public uint Duration;
        public uint Charges;

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Id {0}, Duration {1}, Charges {2}", Id, Duration, Charges);
        }
    }
}
