using System;

namespace Kamilla.Network.Protocols.Wow
{
    /// <summary>
    /// Contains data disassemblied from the client's binary files.
    /// </summary>
    public static class Disassembly
    {
        /// <summary>
        /// The unique client build number. This field is constant.
        /// </summary>
        public const ushort ClientBuild = 15211;

        /// <summary>
        /// A static class containing Connection-related constants.
        /// </summary>
        public static class Connection
        {
            /// <remarks>
            /// Updated for client build 15005.
            /// </remarks>
            public const long Current = 0x009BE68C;

            /// <remarks>
            /// Updated for client build 15005.
            /// </remarks>
            public const long Offset_SessionKey = 0x0508;
            /// <remarks>
            /// Updated for client build 15005.
            /// </remarks>
            public const long SessionKey_Length = 0x0028;
            /// <remarks>
            /// Updated for client build 15005.
            /// </remarks>
            public const long Offset_OpcodeHandlers = 0x0560;
            /// <remarks>
            /// Updated for client build 15005.
            /// </remarks>
            public const long Offset_OpcodeHandlerStates = 0x2560;
        }

        /// <summary>
        /// Address of the current locale string of the client.
        /// </summary>
        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public const long Locale = 0x00973178;

        /// <summary>
        /// Condenses the provided uncondensed opcode.
        /// </summary>
        /// <param name="opcode">The uncondensed opcode.</param>
        /// <returns>The reqular opcode index. Value ranges in [0, 2048].</returns>
        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static uint CondenseOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return (i & 6 | ((i & 0x20 | (((i & 0x80) | (i >> 1) & 0x3F00) >> 1)) >> 2)) >> 1;
        }

        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static bool IsRegularOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return (i & 0x8159) == 0;
        }

        /// <summary>
        /// Condenses the provided uncondensed JAM opcode.
        /// </summary>
        /// <param name="opcode">The uncondensed JAM opcode.</param>
        /// <returns>The JAM opcode index. Value ranges in [0, 128].</returns>
        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static uint CondenseJamOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return (i & 6 | ((i & 0x30 | (((i & 0x80) | ((i & 0x200 | ((i & 0x800 | (i >> 1) & 0x3000) >> 1)) >> 1)) >> 1)) >> 1)) >> 1;
        }

        /// <summary>
        /// Indicates whether the current opcode is JAM opcode or not.
        /// </summary>
        /// <param name="opcode">The current opcode.</param>
        /// <returns>true if the current opcode is JAM opcode; othewise, false.</returns>
        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static bool IsJamOpcode(this WowOpcodes opcode)
        {
            return ((uint)opcode & 0x9549) == 1032;
        }

        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static uint CondenseAuthOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return i & 1 | ((i & 0x20 | ((i & 0x400 | (i >> 1) & 0x800) >> 4)) >> 4);
        }

        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static bool IsAuthOpcode(this WowOpcodes opcode)
        {
            return ((uint)opcode & 0xEBDE) == 770;
        }

        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static bool IsCompressedOpcode(this WowOpcodes opcode)
        {
            return ((uint)opcode & 0xFFFF8000) == 0x8000;
        }

        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static WowOpcodes MakeUncompressed(this WowOpcodes opcode)
        {
            if (!opcode.IsCompressedOpcode())
                throw new InvalidOperationException();

            return (WowOpcodes)((uint)opcode & 0x7FFF);
        }

        /// <remarks>
        /// Updated for client build 15005.
        /// </remarks>
        public static uint GetHandlerByOpcode(uint transformedHandler, WowOpcodes opcode)
        {
            uint o = (uint)opcode;
            return transformedHandler - ((o | (o << 16)) ^ 0x62A3A31D);
        }

        public static uint UncondenseJam(uint index)
        {
            return Uncondense(index, x => !IsAuthOpcode(x) && !IsRegularOpcode(x) && IsJamOpcode(x), CondenseJamOpcode);
        }

        public static uint UncondenseAuth(uint index)
        {
            return Uncondense(index, x => IsAuthOpcode(x) && !IsRegularOpcode(x) && !IsJamOpcode(x), CondenseAuthOpcode);
        }

        public static uint UncondenseRegular(uint index)
        {
            return Uncondense(index, x => !IsAuthOpcode(x) && IsRegularOpcode(x) && !IsJamOpcode(x), CondenseOpcode);
        }

        private static uint Uncondense(uint index, Func<WowOpcodes, bool> checker, Func<WowOpcodes, uint> condenser)
        {
            uint ret = uint.MaxValue;

            for (ushort i = 0; i < ushort.MaxValue; ++i)
            {
                var o = (WowOpcodes)i;
                if (checker(o) && condenser(o) == index)
                {
                    if (ret == uint.MaxValue)
                        ret = i;
                    else
                    {
                        Console.WriteLine("Cannot uncondense index {0}", index);
                        return SpecialWowOpcodes.UnknownOpcode;
                    }
                }
            }

            return ret;
        }
    }
}
