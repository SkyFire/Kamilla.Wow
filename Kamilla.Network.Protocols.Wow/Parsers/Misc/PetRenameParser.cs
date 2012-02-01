using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.CMSG_PET_RENAME)]
    internal sealed class PetRenameParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            Output.AppendLine("Guid: " + this.Reader.ReadGuid());
            Output.AppendLine("Name: " + this.Reader.ReadCString());
            bool declined = Reader.ReadBoolean();
            Output.AppendLine("Declined: " + declined);
            if (declined)
            {
                for (int i = 0; i < 5; ++i)
                    Output.AppendFormatLine("  Declined Name {1}: {0}", Reader.ReadCString(), i);
            }
        }
    }
}
