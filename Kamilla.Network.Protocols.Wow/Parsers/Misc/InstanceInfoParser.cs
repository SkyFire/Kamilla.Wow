using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Misc
{
    [WowPacketParser(WowOpcodes.SMSG_WORLD_SERVER_INFO)]
    internal sealed class InstanceInfoParser : WowPacketParser
    {
        protected override void InternalParse()
        {
            var moneyCap = Reader.UnalignedReadBit();
            var levelCap = Reader.UnalignedReadBit();

            Output.AppendLine("Last Weekly Reset: " + Reader.ReadUInt32().AsUnixTime());
            Output.AppendLine("Instance Difficulty: " + (RaidDifficulty)Reader.ReadUInt32());

            if (moneyCap)
                Output.AppendLine("Trial Money Cap: " + new Money(Reader.ReadUInt32()));

            Output.AppendLine("Is On Tournament Realm: " + Reader.ReadByte());

            if (levelCap)
                Output.AppendLine("Trial Level Cap: " + Reader.ReadUInt32());
        }
    }
}
