using Kamilla.Network.Protocols.Wow.Game;

namespace Kamilla.Network.Protocols.Wow.Parsers.Gossip
{
    [WowPacketParser(WowOpcodes.SMSG_GOSSIP_MESSAGE)]
    internal sealed class GossipMessageParser : WowPacketParser
    {
        public WowGuid Object { get; private set; }
        public GossipMenu Menu { get; private set; }
        public QuestOption[] QuestOptions { get; private set; }

        public struct QuestOption
        {
            public uint Quest;
            public uint Icon;
            public int Level;
            public QuestFlags Flags;
            public byte Unk;
            public string Text;
        }

        protected override void InternalParse()
        {
            this.Object = Reader.ReadGuid();
            this.Menu = new GossipMenu();
            this.Menu.MenuId = Reader.ReadUInt32();
            this.Menu.TextId = Reader.ReadUInt32();

            var options = Reader.ReadInt32();
            this.Menu.GossipOptions = new GossipMenuOption[options];
            for (int i = 0; i < options; ++i)
            {
                var option = this.Menu.GossipOptions[i] = new GossipMenuOption();

                option.OptionId = Reader.ReadUInt32();
                option.Icon = Reader.ReadByte();
                option.IsPasswordRequired = Reader.ReadBoolean();
                option.MoneyRequired = Reader.ReadUInt32();
                option.Text = Reader.ReadCString();
                option.BoxText = Reader.ReadCString();
            }

            var quests = Reader.ReadInt32();
            this.QuestOptions = new QuestOption[quests];
            for (int i = 0; i < quests; ++i)
            {
                this.QuestOptions[i].Quest = Reader.ReadUInt32();
                this.QuestOptions[i].Icon = Reader.ReadUInt32();
                this.QuestOptions[i].Level = Reader.ReadInt32();
                this.QuestOptions[i].Flags = (QuestFlags)Reader.ReadUInt32();
                this.QuestOptions[i].Unk = Reader.ReadByte();
                this.QuestOptions[i].Text = Reader.ReadCString();
            }

            Output
                .Append("Entity: ").AppendLine(this.Object.ToString())
                .Append("Menu Id: ").Append(this.Menu.MenuId).AppendLine()
                .Append("Text Id: ").Append(this.Menu.TextId).AppendLine()
                .AppendLine();

            foreach (var option in this.Menu.GossipOptions)
            {
                Output
                    .Append("[").Append(option.OptionId).Append("] [Icon #")
                    .Append(option.Icon).Append("] ")
                    .Append(option.Text).AppendLine();

                if (option.IsPasswordRequired ||
                    option.MoneyRequired != 0 ||
                    option.BoxText != string.Empty)
                {
                    Output
                        .Append("  [")
                        .Append(option.IsPasswordRequired ? "password" : "")
                        .Append(option.MoneyRequired != 0
                            ? new Money(option.MoneyRequired).ToString()
                            : "")
                        .Append("] ").AppendLine(option.BoxText);
                }
            }

            Output.AppendLine();

            for (int i = 0; i < this.QuestOptions.Length; i++)
            {
                Output
                    .Append("[").Append(this.QuestOptions[i].Quest).Append("] [Icon #")
                    .Append(this.QuestOptions[i].Icon).Append("] ")
                    .Append(this.QuestOptions[i].Text).Append(" [")
                    .Append(this.QuestOptions[i].Level).Append("]")
                    .AppendLine()
                    .Append("  Unk: ").Append(this.QuestOptions[i].Unk)
                    .Append("  Flags: ").AppendLine(this.QuestOptions[i].Flags.ToString());
            }
        }
    }
}
