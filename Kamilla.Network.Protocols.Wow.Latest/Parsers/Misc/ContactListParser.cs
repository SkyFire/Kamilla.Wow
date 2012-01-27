using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_CONTACT_LIST)]
    internal sealed class ContactListParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            Output.AppendLine("Mask:  " + (SocialFlag)Reader.ReadUInt32());
            int size = Reader.ReadInt32();
            Output.AppendLine("Friends Count: " + size);
            for (int i = 0; i < size; ++i)
            {
                Output.AppendLine();
                Output.AppendLine("Player GUID: " + Reader.ReadGuid());
                SocialFlag sflag = (SocialFlag)Reader.ReadUInt32();
                Output.AppendFormatLine("Social Flag: {0} ({0:D})", sflag);
                Output.AppendLine("Note: " + Reader.ReadCString());
                if ((sflag & SocialFlag.Friend) != 0)
                {
                    FriendStatus second = (FriendStatus)Reader.ReadByte();
                    Output.AppendLine("Friend Status: " + second);
                    if ((byte)second > 0)
                    {
                        Output.AppendFormatLine("Area:  {0:D} {0}", (Zones)Reader.ReadUInt32());
                        Output.AppendLine("Level: " + Reader.ReadUInt32());
                        Output.AppendFormatLine("Class: {0:D} {0}", (Classes)Reader.ReadUInt32());
                    }
                }
            }

            if (!Reader.IsRead)
                Output.AppendLine("Bot Check ARC4 Key: " + Reader.ReadBytes(16).ToHexString());
        }
    }
}
