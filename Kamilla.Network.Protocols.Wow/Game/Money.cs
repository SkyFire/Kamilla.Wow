
namespace Kamilla.Network.Protocols.Wow.Game
{
    public static class MoneyUnits
    {
        public const ulong Copper   = 1;
        public const ulong Silver   = 100 * Copper;
        public const ulong Gold     = 100 * Silver;
    }

    public struct Money
    {
        /// <summary>
        /// It's 64-bit long value, as in Cataclysm.
        /// </summary>
        public ulong Raw
        {
            get { return m_raw; }
        }

        public ulong Gold   { get { return (Raw                    ) / MoneyUnits.Gold;   } }
        public ulong Silver { get { return (Raw % MoneyUnits.Gold  ) / MoneyUnits.Silver; } }
        public ulong Copper { get { return (Raw % MoneyUnits.Silver) / MoneyUnits.Copper; } }

        public Money(ulong value)
        {
            m_raw = value;
        }

        private ulong m_raw;

        public override string ToString()
        {
            return (Gold > 0 ? Gold + "g" : "") + (Silver > 0 ? Silver + "s" : "")
                + (Copper > 0 || Silver == 0 && Gold == 0 ? Copper + "c" : "");
        }

        public static explicit operator ulong(Money money)
        {
            return money.Raw;
        }

        public static explicit operator Money(ulong money)
        {
            return new Money(money);
        }
    }
}
