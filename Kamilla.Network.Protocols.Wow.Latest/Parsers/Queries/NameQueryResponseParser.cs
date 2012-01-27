using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Queries
{
    [WowPacketParser(WowOpcodes.SMSG_NAME_QUERY_RESPONSE)]
    internal sealed class NameQueryResponseParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            Output.AppendLine("GUID: " + Reader.ReadPackedGuid());
            if (!Reader.ReadBoolean())
            {
                Output.AppendLine("Name: " + Reader.ReadCString());
                Output.AppendLine("Realm: " + Reader.ReadCString());
                Output.AppendLine("Race: " + (Races)Reader.ReadByte());
                Output.AppendLine("Gender: " + (Genders)Reader.ReadByte());
                Output.AppendLine("Class: " + (Classes)Reader.ReadByte());
                bool declined = Reader.ReadBoolean();
                Output.AppendLine("Declined: " + declined);
                if (declined)
                {
                    for (int i = 0; i < 5; ++i)
                        Output.AppendFormatLine("    Declined Name {1}: {0}", Reader.ReadCString(), i);
                }
            }
        }
    }
}
