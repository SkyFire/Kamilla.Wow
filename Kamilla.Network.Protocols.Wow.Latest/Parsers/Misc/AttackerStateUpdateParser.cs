using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_ATTACKERSTATEUPDATE)]
    internal sealed class AttackerStateUpdateParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            var flags = (HitFlags)Reader.ReadUInt32();
            Output.AppendLine("Flags: " + flags);

            Output.AppendLine("Attacker: " + Reader.ReadPackedGuid());
            Output.AppendLine("Target: " + Reader.ReadPackedGuid());

            Output.AppendLine("Damage: " + Reader.ReadUInt32());
            Output.AppendLine("Overkill: " + Reader.ReadUInt32());

            byte count = Reader.ReadByte();
            Output.AppendLine("Damage Count: " + count);

            for (byte i = 0; i < count; ++i)
                Output.AppendFormatLine("  {3}) School: {0}  Float Damage: {1}  UInt Damage: {2}",
                    (SpellSchoolMask)Reader.ReadUInt32(), Reader.ReadSingle(), Reader.ReadUInt32(), i);

            if ((flags & (HitFlags.Absorb_1 | HitFlags.Absorb_2)) != 0)
            {
                Output.AppendLine();
                for (byte i = 0; i < count; ++i)
                    Output.AppendFormatLine("  Absorb {0}: {1}", i, Reader.ReadUInt32());
            }

            if ((flags & (HitFlags.Resist_1 | HitFlags.Resist_2)) != 0)
            {
                Output.AppendLine();
                for (byte i = 0; i < count; ++i)
                    Output.AppendFormatLine("  Resist {0}: {1}", i, Reader.ReadUInt32());
            }

            Output.AppendLine();

            Output.AppendLine("Victim State: " + (VictimState)Reader.ReadByte());
            Output.AppendLine("Unk Int: " + Reader.ReadInt32());
            Output.AppendLine("Unk Int: " + Reader.ReadInt32());

            if ((flags & HitFlags.Block) != 0)
                Output.AppendLine("Block: " + Reader.ReadUInt32());

            if ((flags & HitFlags.HitFlag_0x800000) != 0)
                Output.AppendLine("Unk HitFlag_0x800000: " + Reader.ReadUInt32());

            if ((flags & HitFlags.HitFlag_0x1) != 0)
            {
                Output.AppendLine();
                Output.AppendLine("Unk Extended Data (HitFlag_0x1):");
                Output.AppendLine("Unk UInt: " + Reader.ReadUInt32());
                for (int i = 0; i < 8; ++i)
                    Output.AppendFormatLine("Unk Float {0}: {1}", i, Reader.ReadSingle());
                for (int i = 0; i < 5; ++i)
                    Output.AppendFormatLine("Unk Float Pair {0}: {1}  {2}", i, Reader.ReadSingle(), Reader.ReadSingle());
                Output.AppendLine("Unk UInt: " + Reader.ReadUInt32());
            }
        }
    }
}
