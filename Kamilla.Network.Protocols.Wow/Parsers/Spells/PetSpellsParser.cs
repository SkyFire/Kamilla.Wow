using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Spells
{
    [WowPacketParser(WowOpcodes.SMSG_PET_SPELLS)]
    internal sealed class PetSpellsParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Spells; } }

        public const int MaxPetSpells = 10;
        public readonly uint[] Spells = new uint[MaxPetSpells];
        public bool HasSpells { get; private set; }
        public uint Entry { get; private set; }
        public CreatureFamilies CreatureFamily { get; private set; }

        protected override void InternalParse()
        {
            var guid = Reader.ReadGuid();
            Output.AppendLine("Pet: " + guid);

            if (guid.IsEmpty)
                return;

            CreatureFamily = (CreatureFamilies)Reader.ReadUInt16();
            Output.AppendFormatLine("Pet Family: ({0:D}) {0}", CreatureFamily);
            Output.AppendLine("Duration:   " + Reader.ReadUInt32());
            Output.AppendFormatLine("React:      ({0:D}) {0}", (PetAttackMode)Reader.ReadByte());
            Output.AppendFormatLine("Action:     ({0:D}) {0}", (PetAction)Reader.ReadByte());
            Output.AppendLine("Flag???:    " + Reader.ReadUInt16());

            Output.AppendLine("Actions: 10 (const)");
            for (int i = 0; i < MaxPetSpells; ++i)
            {
                uint actioninfo = Reader.ReadUInt32();

                var type = (PetActionType)(actioninfo >> 24 & 0x3F);
                uint actionId = actioninfo & 0xFFFFFF;

                if (type == PetActionType.CastSpell ||
                    (type >= PetActionType.CastSpell2 && type <= PetActionType.CastSpell11))
                {
                    Spells[i] = actionId;
                    HasSpells = true;
                }

                Output.AppendFormatLine("  {0}) Action Id: {1}  Type: ({2:D}) {2}", i, actionId, type);
            }

            byte count;
            Output.AppendLine("Talants: " + (count = Reader.ReadByte()));
            for (int i = 0; i < count; ++i)
            {
                uint spellinfo = Reader.ReadUInt32();
                var type = (PetSpellState)(spellinfo >> 24 & 0x3F);
                uint id = spellinfo & 0xFFFFFF;

                Output.AppendFormatLine("  {0}) Spell Id: {1}  State: ({2:D}) {2}", i, id, type);
            }

            Output.AppendLine("Cooldowns: " + (count = Reader.ReadByte()));
            for (int i = 0; i < count; ++i)
            {
                Output.AppendFormatLine(
                    "  {0}) Spell Id: {1}, Category: {2}, Spell Cooldown: {3}, Category Cooldown: {4}",
                    i,
                    Reader.ReadUInt32(),
                    Reader.ReadUInt16(),
                    Reader.ReadUInt32(),
                    Reader.ReadUInt32()
                    );
            }

            this.Entry = guid.IsPet ? (uint)CreatureFamily : guid.Entry;
        }
    }
}
