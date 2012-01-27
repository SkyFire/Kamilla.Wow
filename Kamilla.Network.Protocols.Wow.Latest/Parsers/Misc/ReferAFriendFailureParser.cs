using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_REFER_A_FRIEND_FAILURE)]
    internal sealed class ReferAFriendFailureParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            uint error = Reader.ReadUInt32();
            Output.AppendLine("Error: " + error);
            if (error == 9)
                Output.AppendLine("String: " + Reader.ReadCString());

            switch (error)
            {
                case 1:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_NOT_REFERRED_BY);
                    break;
                case 2:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_TARGET_TOO_HIGH);
                    break;
                case 3:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_INSUFFICIENT_GRANTABLE_LEVELS);
                    break;
                case 4:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_TOO_FAR);
                    break;
                case 5:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_DIFFERENT_FACTION);
                    break;
                case 6:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_NOT_NOW);
                    break;
                case 7:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_GRANT_LEVEL_MAX_I);
                    break;
                case 8:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_GENERIC_NO_TARGET);
                    break;
                case 9:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_TARGET_NOT_IN_GROUP_S);
                    break;
                case 10:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_SUMMON_LEVEL_MAX_I);
                    break;
                case 11:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_SUMMON_COOLDOWN);
                    break;
                case 13:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_SUMMON_OFFLINE_S);
                    break;
                case 12:
                    Output.AppendLine("Real Error: " + UIErrors.ERR_REFER_A_FRIEND_INSUF_EXPAN_LVL);
                    break;
                default:
                    break;
            }
        }
    }
}
