using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Chat
{
    [WowPacketParser(WowOpcodes.SMSG_CHANNEL_NOTIFY)]
    internal sealed class ChannelNotifyParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Chat; } }

        protected override void InternalParse()
        {
            var notification = (ChannelNotification)Reader.ReadByte();
            Output.AppendLine("Type: " + notification);
            Output.AppendLine("Channel: " + Reader.ReadCString());
            Output.AppendLine();

            switch (notification)
            {
                case ChannelNotification.PlayerJoined:
                case ChannelNotification.PlayerLeft:
                case ChannelNotification.PasswordChanged:
                case ChannelNotification.OwnerChanged:
                case ChannelNotification.Announcing:
                case ChannelNotification.NotAnnouncing:
                case ChannelNotification.Moderated:
                case ChannelNotification.NotModerated:
                case ChannelNotification.AlreadyOnChannel:
                case ChannelNotification.BeenInvitedToChannel:
                case ChannelNotification.VoiceDisabled:
                case ChannelNotification.VoiceEnabled:
                case ChannelNotification.VoiceEnabled2:
                    Output.AppendLine("Player: " + Reader.ReadGuid());
                    break;
                case ChannelNotification.YouJoined:
                    Output.AppendLine("Unk byte: " + Reader.ReadByte());
                    Output.AppendLine("Unk u32: " + Reader.ReadUInt32());
                    Output.AppendLine("Unk u32: " + Reader.ReadUInt32());
                    if (!Reader.IsRead)
                        Output.AppendLine("Unk str: " + Reader.ReadCString());
                    break;
                case ChannelNotification.YouLeft:
                    Output.AppendLine("Unk u32: " + Reader.ReadUInt32());
                    Output.AppendLine("Unk byte: " + Reader.ReadByte());
                    break;
                case ChannelNotification.PlayerNotOnChannel:
                case ChannelNotification.PlayerNotBanned:
                case ChannelNotification.CurrentOwner:
                case ChannelNotification.HaveInvitedToChannel:
                case ChannelNotification.CannotInviteBannedPlayer:
                    Output.AppendLine("Player: " + Reader.ReadCString());
                    break;
                case ChannelNotification.Mute:
                    Output.AppendLine("Player: " + Reader.ReadGuid());
                    Output.AppendLine("Unk byte: " + Reader.ReadByte());
                    Output.AppendLine("Unk byte: " + Reader.ReadByte());
                    break;
                case ChannelNotification.Kicked:
                case ChannelNotification.Banned:
                case ChannelNotification.Unbanned:
                    Output.AppendLine("Player 1: " + Reader.ReadGuid());
                    Output.AppendLine("Player 2: " + Reader.ReadGuid());
                    break;
            }
        }
    }
}
