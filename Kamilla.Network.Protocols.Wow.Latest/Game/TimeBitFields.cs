using System;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    public static class TimeBitFields
    {
        public static DateTime AsTimeBitFields(this uint i)
        {
            int bits = (int)i;
            return new DateTime((bits >> 24 & 0xFF) + 2000, (bits >> 20 & 0xF) + 1, (bits >> 14 & 0x3F) + 1, bits >> 6 & 0x1F, bits & 0x3F, 0);
        }

        public static DateTime MinBitFieldsDateTime = new DateTime(2000, 1, 1, 0, 0, 0);
        public static DateTime MaxBitFieldsDateTime = new DateTime(2255, 12, 31, 23, 59, 59);

        public static uint ToTimeBitFields(this DateTime dt)
        {
            if (dt < MinBitFieldsDateTime || dt > MaxBitFieldsDateTime)
                throw new ArgumentOutOfRangeException();

            return (uint)((dt.Year - 2000) << 24 | (dt.Month - 1) << 20 | (dt.Day - 1) << 14 | ((int)dt.DayOfWeek) << 11 | dt.Hour << 6 | dt.Minute);
        }
    }
}
