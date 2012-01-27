using System;
using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Achievements
{
    [WowPacketParser(WowOpcodes.SMSG_ALL_ACHIEVEMENT_DATA)]
    internal sealed class AchievementDataParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            var reader = this.Reader;
            uint nAchievements = reader.ReadUInt32();
            Output.AppendLine("Achievements: " + nAchievements);

            Output.AppendLine();
            for (uint i = 0; i < nAchievements; ++i)
                Output.AppendFormatLine("  Completed {1}: {0}", reader.ReadUInt32().AsTimeBitFields(), i);

            uint nCriterias = reader.ReadUInt32();
            Output.AppendLine("Criterias: " + nCriterias);

            Output.AppendLine();
            for (uint i = 0; i < nCriterias; ++i)
                Output.AppendFormatLine("  Criteria Id {1}: {0}", reader.ReadUInt32(), i);

            Output.AppendLine();
            for (uint i = 0; i < nAchievements; ++i)
                Output.AppendFormatLine("  Achievement Id {1}: {0}", reader.ReadUInt32(), i);

            Output.AppendLine();
            for (uint i = 0; i < nCriterias; ++i)
                Output.AppendFormatLine("  Criteria Time3 {1}: {0}", TimeSpan.FromSeconds(reader.ReadUInt32()), i);
            Output.AppendLine();
            for (uint i = 0; i < nCriterias; ++i)
                Output.AppendFormatLine("  Criteria Counter {1}: {0}", reader.ReadUInt64(), i);
            Output.AppendLine();
            for (uint i = 0; i < nCriterias; ++i)
                Output.AppendFormatLine("  Criteria Time2 {1}: {0}", reader.ReadUInt32().AsTimeBitFields(), i);
            Output.AppendLine();
            for (uint i = 0; i < nCriterias; ++i)
                Output.AppendFormatLine("  Criteria Time1 {1}: {0}", TimeSpan.FromSeconds(reader.ReadUInt32()), i);
            Output.AppendLine();
            for (uint i = 0; i < nCriterias; ++i)
                Output.AppendFormatLine("  Criteria Guid {1}: {0}", reader.ReadGuid(), i);

            Output.AppendLine();

            int numbytes = (int)Math.Ceiling((double)nCriterias * 2.0 / 8.0);
            Output.AppendLine("Mask: " + reader.ReadBytes(numbytes).ToHexString());
        }
    }
}
