using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Chat
{
    [WowPacketParser(WowOpcodes.SMSG_SEND_ALL_COMBAT_LOG)]
    [WowPacketParser(WowOpcodes.SMSG_SPELLENERGIZELOG)]
    [WowPacketParser(WowOpcodes.SMSG_SPELLBREAKLOG)]
    [WowPacketParser(WowOpcodes.SMSG_SPELLLOGEXECUTE)]
    [WowPacketParser(WowOpcodes.SMSG_SPELLLOGMISS)]
    [WowPacketParser(WowOpcodes.SMSG_SPELLHEALLOG)]
    [WowPacketParser(WowOpcodes.SMSG_SPELLNONMELEEDAMAGELOG)]
    [WowPacketParser(WowOpcodes.SMSG_PERIODICAURALOG)]
    [WowPacketParser(WowOpcodes.SMSG_LOG_XPGAIN)]
    internal sealed class CombatLogParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.CombatLog; } }

        protected override void InternalParse()
        {
            Parse((WowOpcodes)Packet.Opcode);
        }

        private void Parse(WowOpcodes opcode)
        {
#warning Combat Log Parser not implemented
            /*
            switch (opcode)
            {
                case WowOpcodes.SMSG_SEND_ALL_COMBAT_LOG:
                {
                    uint count = Reader.ReadUInt32();
                    Output.AppendLine("Log Entry Count: " + count);
                    Output.AppendLine("Sent Time Ms: " + Reader.ReadUInt32());
                    for (uint i = 0; i < count; ++i)
                    {
                        Output.AppendLine();
                        Output.AppendLine("This Entry Time Ms: " + Reader.ReadUInt32());
                        WowOpcodes entryOpcode = (WowOpcodes)Reader.ReadUInt32();
                        Output.AppendLine("Opcode: " + entryOpcode);
                        Parse(entryOpcode);
                    }
                    break;
                }
                case WowOpcodes.SMSG_SPELLENERGIZELOG:
                    Output.AppendLine("Victim: " + Reader.ReadPackedGuid());
                    Output.AppendLine("Entity: " + Reader.ReadPackedGuid());
                    Output.AppendLine("Spell Id: " + Reader.ReadUInt32());
                    Output.AppendLine("Power Type: " + (PowerType)Reader.ReadUInt32());
                    Output.AppendLine("Power: " + Reader.ReadUInt32());
                    break;
                case WowOpcodes.SMSG_SPELLBREAKLOG:
                {
                    Output.AppendLine("Victim: " + Reader.ReadPackedGuid());
                    Output.AppendLine("Entity: " + Reader.ReadPackedGuid());
                    Output.AppendLine("Spell Id: " + Reader.ReadUInt32());
                    Output.AppendLine("Unk Byte" + Reader.ReadByte());
                    uint count = Reader.ReadUInt32();
                    Output.AppendLine("Count: " + count);
                    Output.AppendLine();
                    for (uint i = 0; i < count; ++i)
                        Output.AppendFormatLine("  uint32 {0}, byte {1}", Reader.ReadUInt32(), Reader.ReadByte());
                    break;
                }
                case WowOpcodes.SMSG_SPELLLOGEXECUTE:
                    ReadSpellLogExecute();
                    break;
                case WowOpcodes.SMSG_SPELLLOGMISS:
                {
                    Output.AppendLine("Spell Id: " + Reader.ReadUInt32());
                    Output.AppendLine("Guid: " + Reader.ReadGuid());
                    byte unk = Reader.ReadByte();
                    Output.AppendLine("Unk bool: " + unk);
                    uint count = Reader.ReadUInt32();
                    Output.AppendLine("Count: " + count);
                    for (uint i = 0; i < count; ++i)
                    {
                        Output.AppendLine();
                        Output.AppendLine("Guid: " + Reader.ReadGuid());
                        Output.AppendLine("Unk Byte: " + Reader.ReadByte());

                        if (unk != 0)
                        {
                            Output.AppendLine("Float1: " + Reader.ReadSingle());
                            Output.AppendLine("Float2: " + Reader.ReadSingle());
                        }
                    }
                    break;
                }
                case WowOpcodes.SMSG_SPELLNONMELEEDAMAGELOG:
                    ReadSpellNonMeleeDamageLog();
                    break;
                case WowOpcodes.SMSG_SPELLHEALLOG:
                    Output.AppendLine("Target: " + Reader.ReadPackedGuid());
                    Output.AppendLine("Entity: " + Reader.ReadPackedGuid());
                    Output.AppendLine("Spell Id: " + Reader.ReadUInt32());
                    Output.AppendLine("Heal: " + Reader.ReadUInt32());
                    Output.AppendLine("Overheal: " + Reader.ReadUInt32());
                    Output.AppendLine("Absorb: " + Reader.ReadUInt32());
                    Output.AppendLine("Critical: " + Reader.ReadByte());
                    Output.AppendLine("Unk: " + Reader.ReadByte());
                    break;
                case WowOpcodes.SMSG_PERIODICAURALOG:
                    ReadPeriodicAuraLog();
                    break;
                case WowOpcodes.SMSG_LOG_XPGAIN:
                    // sending current guid here will cause "You lose %d experience."
                    Output.AppendLine("Victim: " + Reader.ReadGuid());
                    Output.AppendLine("Total XP Gained: " + Reader.ReadUInt32());
                    XpType type;
                    Output.AppendLine("Type: " + (type = (XpType)Reader.ReadByte()));
                    if (type == XpType.Kill)
                    {
                        Output.AppendLine("XP Before Rested/RAF: " + Reader.ReadUInt32());
                        Output.AppendLine("Group/Raid Modifier: " + Reader.ReadSingle().ToString(CultureInfo.InvariantCulture));
                    }
                    Output.AppendLine("Is RAF: " + Reader.ReadByte());

                    // Calculations are as followed:
                    // total_XP_gained = initial_xp * group_modifier * rested_modifier
                    // xp_before_rested = initial_xp * group_modifier
                    break;
            }
            */
        }

        void ReadPeriodicAuraLog()
        {
            Output.AppendLine("Target: " + Reader.ReadPackedGuid());
            Output.AppendLine("Caster: " + Reader.ReadPackedGuid());
            Output.AppendLine("SpellID: " + Reader.ReadUInt32());
            int count;
            Output.AppendLine("Count: " + (count = Reader.ReadInt32()));

            for (int i = 0; i < count; ++i)
            {
                Output.AppendLine();
                AuraType atype = (AuraType)Reader.ReadUInt32();
                Output.AppendLine("   Mod: " + atype);

                switch (atype)
                {
                    case AuraType.SPELL_AURA_PERIODIC_DAMAGE:
                    case AuraType.SPELL_AURA_PERIODIC_DAMAGE_PERCENT:
                        Output.AppendLine("   Damage:     " + Reader.ReadUInt32());
                        Output.AppendLine("   Over Kill:  " + Reader.ReadInt32());
                        Output.AppendLine("   Scool Mask: " + (SpellSchoolMask)Reader.ReadUInt32());
                        Output.AppendLine("   Absorb:     " + Reader.ReadUInt32());
                        Output.AppendLine("   Resist:     " + Reader.ReadUInt32());
                        Output.AppendLine("   Crit:       " + Reader.ReadByte());
                        break;
                    case AuraType.SPELL_AURA_PERIODIC_HEAL:
                    case AuraType.SPELL_AURA_OBS_MOD_HEALTH:
                        Output.AppendLine("   Damage:    " + Reader.ReadUInt32());
                        Output.AppendLine("   Over Heal: " + Reader.ReadUInt32());
                        Output.AppendLine("   Spell Id:  " + Reader.ReadUInt32());
                        Output.AppendLine("   Crit:      " + Reader.ReadByte());
                        break;
                    case AuraType.SPELL_AURA_OBS_MOD_MANA:
                    case AuraType.SPELL_AURA_PERIODIC_ENERGIZE:
                        Output.AppendLine("   Power Type: " + (PowerType)Reader.ReadUInt32());
                        Output.AppendLine("   Damage:     " + Reader.ReadUInt32());
                        break;
                    case AuraType.SPELL_AURA_PERIODIC_MANA_LEECH:
                        Output.AppendLine("   Power Type:      " + (PowerType)Reader.ReadUInt32());
                        Output.AppendLine("   Amount:          " + Reader.ReadUInt32());
                        Output.AppendLine("   Gain Multiplier: " + Reader.ReadSingle());
                        break;
                }
            }
        }

        void ReadSpellNonMeleeDamageLog()
        {
            Output.AppendLine("Victim: " + Reader.ReadPackedGuid());
            Output.AppendLine("Entity: " + Reader.ReadPackedGuid());
            Output.AppendLine("Spell Id: " + Reader.ReadUInt32());
            Output.AppendLine("Damage: " + Reader.ReadUInt32());
            Output.AppendLine("Overkill: " + Reader.ReadInt32());
            Output.AppendLine("School Mask: " + (SpellSchoolMask)Reader.ReadByte());
            Output.AppendLine("Absorb: " + Reader.ReadUInt32());
            Output.AppendLine("Resist: " + Reader.ReadUInt32());
            Output.AppendLine("Is Physical Log: " + Reader.ReadByte());
            Output.AppendLine("Unused: " + Reader.ReadByte());
            Output.AppendLine("Blocked: " + Reader.ReadUInt32());

            uint mask = Reader.ReadUInt32();
            byte extended = Reader.ReadByte();

            Output.AppendLine("Hit Info Mask: 0x" + mask.ToString("X2"));
            Output.AppendLine("Extended Data: " + extended);

            if (extended != 0)
            {
                if ((mask & 0x01) != 0)
                {
                    Output.AppendLine("Float 0x01 1: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x01 2: " + Reader.ReadSingle());
                }
                if ((mask & 0x04) != 0)
                {
                    Output.AppendLine("Float 0x04 1: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x04 2: " + Reader.ReadSingle());
                }
                if ((mask & 0x20) != 0)
                {
                    Output.AppendLine("Float 0x20 1: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x20 2: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x20 3: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x20 4: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x20 5: " + Reader.ReadSingle());
                    Output.AppendLine("Float 0x20 6: " + Reader.ReadSingle());
                }
            }
        }

        void ReadSpellLogExecute()
        {
            Output.AppendLine("Caster: " + Reader.ReadPackedGuid());
            Output.AppendLine("Spell ID: " + Reader.ReadInt32());
            int count = Reader.ReadInt32();
            Output.AppendLine("Effect count: " + count);
            for (int i = 0; i < count; ++i)
            {
                SpellEffects effect = (SpellEffects)Reader.ReadInt32();
                Output.AppendLine("Spell Effect: " + effect);
                int hitCount = Reader.ReadInt32();
                for (int c = 0; c < hitCount; ++c)
                {
                    switch (effect)
                    {
                        case SpellEffects.PowerDrain:
                        case SpellEffects.PowerBurn:
                            Output.AppendLine("Target: " + Reader.ReadPackedGuid());
                            Output.AppendLine("SpellID: " + Reader.ReadInt32());
                            Output.AppendLine("Unk2: " + Reader.ReadInt32());
                            Output.AppendLine("Unk3: " + Reader.ReadInt32());
                            break;
                        case SpellEffects.AddExtraAttacks:
                        case SpellEffects.InterruptCast:
                            Output.AppendLine("Target: " + Reader.ReadPackedGuid());
                            Output.AppendLine("SpellID: {0}" + Reader.ReadInt32());
                            break;
                        case SpellEffects.DurabilityDamage:
                            Output.AppendLine("Target: " + Reader.ReadPackedGuid());
                            Output.AppendLine("SpellID: " + Reader.ReadInt32());
                            Output.AppendLine("Unk3: " + Reader.ReadInt32());
                            break;
                        case SpellEffects.OpenLock:
                            Output.AppendLine("Target: " + Reader.ReadPackedGuid());
                            break;
                        case SpellEffects.CreateItem:
                        case SpellEffects.CreateRandomItem:
                        case SpellEffects.CreateItem2:
                            Output.AppendLine("ItemID: " + Reader.ReadInt32());
                            break;
                        case SpellEffects.Summon:
                        case SpellEffects.TransDoor:
                        case SpellEffects.SummonPet:
                        case SpellEffects.SummonObjectWild:
                        case SpellEffects.CreateHouse:
                        case SpellEffects.Duel:
                        case SpellEffects.SummonObjectSlot1:
                        case SpellEffects.Effect171:
                            Output.AppendLine("Summoned: " + Reader.ReadPackedGuid());
                            break;
                        case SpellEffects.FeedPet:
                            Output.AppendLine("EatID: " + Reader.ReadInt32());
                            break;
                        case SpellEffects.DismissPet:
                            Output.AppendLine("Pet: " + Reader.ReadPackedGuid());
                            break;
                        case SpellEffects.Resurrect:
                        case SpellEffects.ResurrectNew:
                        case SpellEffects.Effect172:
                            Output.AppendLine("Target: " + Reader.ReadPackedGuid());
                            break;
                    }
                }
            }
        }
    }
}
