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
        public const ushort ClientBuild = 15314;

        /// <summary>
        /// A static class containing Connection-related constants.
        /// </summary>
        public static class Connection
        {
            /// <remarks>
            /// Updated for client build 15211.
            /// </remarks>
            public const long Current = 0x009BD044;

            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long Offset_SessionKey = 0x0508;
            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long SessionKey_Length = 0x0028;
            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long Offset_OpcodeHandlers = 0x0560;
            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long Offset_OpcodeHandlerStates = 0x2560;
        }

        /// <summary>
        /// A static class containing Connection-related constants in Windows x64 client.
        /// </summary>
        public static class Connection64
        {
            /// <remarks>
            /// Updated for client build 15211.
            /// </remarks>
            public const long Current = 0x00C9F7F0;

            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long Offset_SessionKey = 0x050C;
            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long SessionKey_Length = 0x0028;
            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long Offset_OpcodeHandlers = 0x0568;
            /// <remarks>
            /// Updated for client build 15314.
            /// </remarks>
            public const long Offset_OpcodeHandlerStates = 0x4568;
        }

        /// <summary>
        /// Address of the current locale string of the client.
        /// </summary>
        /// <remarks>
        /// Updated for client build 15211.
        /// </remarks>
        public const long Locale = 0x00971B34;

        /// <summary>
        /// Address of the current locale string of the Windows x64 client.
        /// </summary>
        /// <remarks>
        /// Updated for client build 15211.
        /// </remarks>
        public const long Locale64 = 0x00C29B10;

        /// <summary>
        /// Condenses the provided uncondensed opcode.
        /// </summary>
        /// <param name="opcode">The uncondensed opcode.</param>
        /// <returns>The reqular opcode index. Value ranges in [0, 2048].</returns>
        /// <remarks>
        /// Updated for client build 15314.
        /// </remarks>
        public static uint CondenseOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return i & 1 | ((i & 8 | ((i & 0x1FC0 | (i >> 1) & 0x2000) >> 2)) >> 2);
        }

        /// <remarks>
        /// Updated for client build 15314.
        /// </remarks>
        public static bool IsRegularOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return (i & 0xA036) == 8228;
        }

        /// <summary>
        /// Condenses the provided uncondensed JAM opcode.
        /// </summary>
        /// <param name="opcode">The uncondensed JAM opcode.</param>
        /// <returns>The JAM opcode index. Value ranges in [0, 128].</returns>
        /// <remarks>
        /// Updated for client build 15314.
        /// </remarks>
        public static uint CondenseJamOpcode(this WowOpcodes opcode)
        {
            var i = (uint)opcode;
            return (i & 2 | ((i & 8 | ((i & 0x1C0 | ((i & 0x1C00 | (i >> 1) & 0x2000) >> 1)) >> 2)) >> 1)) >> 1;
        }

        /// <summary>
        /// Indicates whether the current opcode is JAM opcode or not.
        /// </summary>
        /// <param name="opcode">The current opcode.</param>
        /// <returns>true if the current opcode is JAM opcode; othewise, false.</returns>
        /// <remarks>
        /// Updated for client build 15314.
        /// </remarks>
        public static bool IsJamOpcode(this WowOpcodes opcode)
        {
            return ((uint)opcode & 0xA235) == 8196;
        }

        /// <remarks>
        /// Updated for client build 15211.
        /// </remarks>
        public static uint CondenseAuthOpcode(this WowOpcodes opcode)
        {
            uint i = (uint)opcode;
            return i & 1 | ((i & 0x20 | ((i & 0x200 | (i >> 2) & 0x400) >> 3)) >> 4);
        }

        /// <remarks>
        /// Updated for client build 15211.
        /// </remarks>
        public static bool IsAuthOpcode(this WowOpcodes opcode)
        {
            return ((uint)opcode & 0xEDDE) == 264;
        }

        /// <remarks>
        /// Updated for client build 15211.
        /// </remarks>
        public static bool IsCompressedOpcode(this WowOpcodes opcode)
        {
            return ((uint)opcode & 0xFFFF8000) == 0x8000;
        }

        /// <remarks>
        /// Updated for client build 15211.
        /// </remarks>
        public static WowOpcodes MakeUncompressed(this WowOpcodes opcode)
        {
            if (!opcode.IsCompressedOpcode())
                throw new InvalidOperationException();

            return (WowOpcodes)((uint)opcode & 0x7FFF);
        }

        /// <remarks>
        /// Updated for client build 15211.
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
