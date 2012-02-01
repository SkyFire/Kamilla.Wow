using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Guilds
{
    [WowPacketParser(WowOpcodes.SMSG_GUILD_ROSTER)]
    internal sealed class GuildRosterParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            var reader = this.Reader;
            Output.AppendLine("Guild Info: " + reader.ReadCString());

            uint nMembers;
            Output.AppendLine("Members: " + (nMembers = reader.ReadUInt32()));
            Output.AppendLine();

            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Level {1}: {0}", reader.ReadByte(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Gender {1}: {0}", (Genders)reader.ReadByte(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Int32 {1}: {0}", reader.ReadInt32(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Byte {1}: {0}", reader.ReadByte(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  GUID {1}: {0}", reader.ReadGuid(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Class {1}: {0}", (Classes)reader.ReadByte(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Int32 {1}: {0}", reader.ReadUInt32(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  OffNote {1}: {0}", reader.ReadCString(), i);

            Output.AppendLine("Guild MOTD: " + reader.ReadCString());

            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Int64 {1}: {0}", reader.ReadUInt64(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Name {1}: {0}", reader.ReadCString(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Reputation Left This Week {1}: {0}", reader.ReadUInt32(), i);

            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
            {
                for (uint p = 0; p < 2; ++p)
                    Output.AppendFormatLine("  Player {0} profession {1}: tier {2} points {3} skill {4}",
                        i, p, reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
            }

            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Unk32 {1}: {0}", reader.ReadUInt32(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Unk32 {1}: {0}", reader.ReadUInt32(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Int64 {1}: {0}", reader.ReadUInt64(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Int32 {1}: {0}", reader.ReadInt32(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Float {1}: {0}", reader.ReadSingle(), i);
            Output.AppendLine();
            for (uint i = 0; i < nMembers; ++i)
                Output.AppendFormatLine("  Note {1}: {0}", reader.ReadCString(), i);



            Output.AppendLine();
            for (uint i = 0; i < (nMembers / 8) + 1; ++i)
                Output.AppendFormatLine("  Mask {1:X2}: {0}", reader.ReadByte(), i);

            Output.AppendLine();

            //Output.AppendLine();
            //for (uint i = 0; i < nMembers; ++i)
            //    Output.AppendFormatLine("  Unk32 {1}: {0}", Reader.ReadUInt32(), i);
        }
    }
}
