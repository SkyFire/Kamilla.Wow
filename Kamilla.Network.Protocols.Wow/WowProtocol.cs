using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Kamilla.Network.Logging;
using Kamilla.Network.Parsing;
using Kamilla.Network.Protocols.Wow.Parsers.Generic;
using Kamilla.Network.Viewing;

namespace Kamilla.Network.Protocols.Wow
{
    public sealed class WowProtocol : Protocol
    {
        sealed class ItemData
        {
            readonly ViewerItem m_item;
            string m_c2sStr;
            string m_s2cStr;
            string m_preview;

            /// <summary>
            /// Initializes a new instance of
            /// <see cref="Kamilla.Network.Protocols.DefaultProtocol.ItemData"/> class.
            /// </summary>
            /// <param name="item">
            /// The underlying instance of <see cref="Kamilla.Network.Viewing.ViewerItem"/> class.
            /// </param>
            /// <exception cref="System.ArgumentNullException">
            /// <c>item</c> is null.
            /// </exception>
            public ItemData(ViewerItem item)
            {
                if (item == null)
                    throw new ArgumentNullException("item");

                m_item = item;
            }

            public string ArrivalTime
            {
                get { return m_item.Packet.ArrivalTime.ToString("HH:mm:ss"); }
            }

            public string ArrivalTicks
            {
                get
                {
                    var log = m_item.Log as IHasStartTicks;
                    if (log != null)
                        return ((int)(m_item.Packet.ArrivalTicks - log.StartTicks)).ToString();

                    return m_item.Packet.ArrivalTicks.ToString();
                }
            }

            public string C2sStr
            {
                get
                {
                    if (m_c2sStr == null)
                    {
                        var packet = m_item.Packet;
                        if (packet.Direction != TransferDirection.ToServer)
                            m_c2sStr = string.Empty;
                        else
                        {
                            var wowPacket = packet as WowPacket;
                            if (wowPacket == null)
                                m_c2sStr = NetworkStrings.bytes.LocalizedFormat(packet.Data.Length);
                            else
                            {
                                var opcStr = ((WowOpcodes)wowPacket.Opcode).ToString();
                                if (opcStr.StartsWith("CMSG_"))
                                    opcStr = opcStr.Substring(5);

                                m_c2sStr = opcStr;
                            }
                        }
                    }

                    return m_c2sStr;
                }
            }

            public string S2cStr
            {
                get
                {
                    if (m_s2cStr == null)
                    {
                        var packet = m_item.Packet;
                        if (packet.Direction != TransferDirection.ToClient)
                            m_s2cStr = string.Empty;
                        else
                        {
                            var wowPacket = packet as WowPacket;
                            if (wowPacket == null)
                                m_s2cStr = NetworkStrings.bytes.LocalizedFormat(packet.Data.Length);
                            else
                            {
                                var opcStr = ((WowOpcodes)wowPacket.Opcode).ToString();
                                if (opcStr.StartsWith("SMSG_"))
                                    opcStr = opcStr.Substring(5);

                                m_s2cStr = opcStr;
                            }
                        }
                    }

                    return m_s2cStr;
                }
            }

            public string ConnectionId
            {
                get
                {
                    var packet = m_item.Packet as WowPacket;
                    if (packet != null)
                        return packet.ConnectionId.ToString();

                    return string.Empty;
                }
            }

            public string Preview
            {
                get
                {
                    if (m_preview == null)
                    {
                        var parser = m_item.Parser;
                        if (parser != null && parser.IsParsed)
                            m_preview = CreateAnnot(parser.ParsedText);
                    }

                    return m_preview;
                }
            }

            public bool ParsingError
            {
                get
                {
                    var parser = m_item.Parser;
                    if (parser != null)
                        return parser.ParsingError;

                    return false;
                }
            }

            public bool IsFreezed { get { return (m_item.Packet.Flags & PacketFlags.Freezed) != 0; } }
            public bool IsCustom { get { return (m_item.Packet.Flags & PacketFlags.Custom) != 0; } }
            public bool IsUndefinedParser { get { return m_item.Parser is UndefinedPacketParser; } }
        }

        static string CreateAnnot(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            int idx1 = text.IndexOf("_____");
            int idx2 = text.IndexOf("=====");

            int idx;
            if (idx1 >= 0)
            {
                if (idx2 >= 0)
                    idx = Math.Min(idx1, idx2);
                else
                    idx = idx1;
            }
            else if (idx2 >= 0)
                idx = idx2;
            else
                idx = -1;

            if (idx >= 0)
                text = text.Substring(0, idx);

            return text.TrimWhiteSpace(200, ' ');
        }

        NetworkLogViewerBase m_viewer;
        GridView m_view;
        ViewerItemEventHandler m_itemQueriedHandler;
        ViewerItemEventHandler m_itemParsingDoneHandler;

        public WowProtocol()
        {
            m_itemQueriedHandler = new ViewerItemEventHandler(viewer_ItemQueried);
            m_itemParsingDoneHandler = new ViewerItemEventHandler(viewer_ItemParsingDone);
        }

        public override string Name
        {
            get { return Strings.ProtocolName; }
        }

        public override string CodeName
        {
            get { return "Wow15050"; }
        }

        public override Type OpcodesEnumType
        {
            get { return typeof(WowOpcodes); }
        }

        public override ViewBase View
        {
            get { return m_view; }
        }

        class GridViewColumnWithId : GridViewColumn
        {
            public int ColumnId;
        }

        static readonly double[] s_columnWidths = new double[]
        {
            64,
            85,
            69,
            19,
            170,
            170,
            59,
            200
        };

        static readonly string[] s_columnBindings = new string[]
        {
            ".Index",
            ".Data.ArrivalTime",
            ".Data.ArrivalTicks",
            ".Packet.ConnectionId",
            ".Data.C2sStr",
            ".Data.S2cStr",
            ".Packet.Data.Length",
            ".Data.Preview",
        };

        static Brush s_freezedBrush;
        static Brush s_customBrush;

        public override void Load(NetworkLogViewerBase viewer)
        {
            if (m_viewer != null)
                throw new InvalidOperationException();

            // Check opcode integrity
            {
                Console.WriteLine("Debug: Protocol '{0}' build {1} checking opcode integrity...",
                    this.CodeName, Disassembly.ClientBuild);
                var fields = typeof(WowOpcodes).GetFields(BindingFlags.Static | BindingFlags.Public);

                var list = new SortedSet<uint>();
                foreach (var field in fields)
                {
                    var value = (uint)field.GetRawConstantValue();
                    if (value != SpecialOpcodes.UnknownOpcode)
                    {
                        if (!list.Contains(value))
                            list.Add(value);
                        else
                            Console.WriteLine("Error: Protocol '{1}' duplicate opcode value {0}",
                                value, this.CodeName);
                    }
                }
                Console.WriteLine(
                    "Debug: Integrity check complete, {0}/{1} ({2:0.00}%) known unique opcode values.",
                    list.Count,
                    fields.Length,
                    list.Count * 100.0 / fields.Length
                    );
            }

            m_viewer = viewer;
            viewer.ItemQueried += m_itemQueriedHandler;
            viewer.ItemParsingDone += m_itemParsingDoneHandler;

            var view = m_view = new GridView();

            var nColumns = s_columnWidths.Length;
            var headers = new string[]
            {
                NetworkStrings.CH_Number,
                NetworkStrings.CH_Time,
                NetworkStrings.CH_Ticks,
                Strings.CH_ConnId,
                NetworkStrings.CH_C2S,
                NetworkStrings.CH_S2C,
                NetworkStrings.CH_Length,
                Strings.CH_Preview,
            };
            if (headers.Length != nColumns)
                throw new InvalidOperationException();

            double[] widths = Configuration.GetValue("Column Widths", (double[])null);
            if (widths == null || widths.Length != nColumns)
                widths = s_columnWidths;

            int[] columnOrder = Configuration.GetValue("Column Order", (int[])null);
            if (columnOrder == null || columnOrder.Length != nColumns
                || columnOrder.Any(val => val >= nColumns || val < 0))
                columnOrder = Enumerable.Range(0, nColumns).ToArray();

            if (s_customBrush == null)
                s_customBrush = new SolidColorBrush(Color.FromRgb(132, 22, 35));

            if (s_freezedBrush == null)
                s_freezedBrush = new SolidColorBrush(Color.FromRgb(36, 176, 185));

            for (int i = 0; i < nColumns; i++)
            {
                int col = columnOrder[i];

                var item = new GridViewColumnWithId();
                item.ColumnId = col;
                item.Header = headers[col];
                item.Width = widths[col];

                var dataTemplate = new DataTemplate();
                dataTemplate.DataType = typeof(ItemData);

                var block = new FrameworkElementFactory(typeof(TextBlock));
                block.Name = "tb";
                block.SetValue(TextBlock.TextProperty, new Binding(s_columnBindings[col]));

                // Opcode
                if (col == 4 || col == 5)
                {
                    block.SetValue(TextBlock.FontFamilyProperty, new FontFamily("Lucida Console"));

                    DataTrigger trigger;

                    trigger = new DataTrigger();
                    trigger.Binding = new Binding(".Data.IsCustom");
                    trigger.Value = true;
                    trigger.Setters.Add(new Setter(TextBlock.ForegroundProperty, s_customBrush, "tb"));
                    dataTemplate.Triggers.Add(trigger);

                    trigger = new DataTrigger();
                    trigger.Binding = new Binding(".Data.IsFreezed");
                    trigger.Value = true;
                    trigger.Setters.Add(new Setter(TextBlock.ForegroundProperty, s_freezedBrush, "tb"));
                    dataTemplate.Triggers.Add(trigger);

                    trigger = new DataTrigger();
                    trigger.Binding = new Binding(".Data.IsUndefinedParser");
                    trigger.Value = true;
                    trigger.Setters.Add(new Setter(TextBlock.ForegroundProperty, Brushes.Gray, "tb"));
                    dataTemplate.Triggers.Add(trigger);
                }
                // Preview
                else if (col == 7)
                {
                    var trigger = new DataTrigger();
                    trigger.Binding = new Binding(".Data.ParsingError");
                    trigger.Value = true;
                    trigger.Setters.Add(new Setter(TextBlock.ForegroundProperty, Brushes.Red, "tb"));
                    dataTemplate.Triggers.Add(trigger);
                }

                dataTemplate.VisualTree = block;
                item.CellTemplate = dataTemplate;

                view.Columns.Add(item);
            }
        }

        public override void Unload()
        {
            if (m_viewer == null)
                throw new InvalidOperationException();

            var view = m_view;
            var columns = view.Columns;
            var nColumns = columns.Count;

            var widths = new double[nColumns];
            var order = new int[nColumns];

            for (int i = 0; i < nColumns; i++)
            {
                var column = (GridViewColumnWithId)columns[i];

                order[i] = column.ColumnId;
                widths[column.ColumnId] = column.Width;
            }

            Configuration.SetValue("Column Widths", widths);
            Configuration.SetValue("Column Order", order);
            m_view = null;

            m_viewer.ItemQueried -= m_itemQueriedHandler;
            m_viewer.ItemParsingDone -= m_itemParsingDoneHandler;

            m_viewer = null;
        }

        void viewer_ItemQueried(object sender, ViewerItemEventArgs e)
        {
            var item = e.Item;
            if (item.Data == null)
                item.Data = CreateDataForItem(item);
        }

        ItemData CreateDataForItem(ViewerItem item)
        {
            return new ItemData(item);
        }

        void viewer_ItemParsingDone(object sender, ViewerItemEventArgs e)
        {
            var item = e.Item;
            if (item.Data == null)
                item.Data = this.CreateDataForItem(item);
            else
                item.NotifyDataChanged();
        }

        protected override PacketParser InternalCreateParser(ViewerItem item)
        {
            var packet = item.Packet as WowPacket;
            if (packet == null)
                return null;

            return XmlParser.GetParser(packet) ?? base.InternalCreateParser(item);
        }

        public override string PacketContentsViewHeader(ViewerItem item)
        {
            var parser = item.Parser;
            var packet = item.Packet;
            var wowPacket = packet as WowPacket;
            var opcodePacket = packet as IPacketWithOpcode;

            int dataLength = packet.Data.Length;
            var builder = new StringBuilder(128);

            builder
                .Append("Packet ")
                .Append((packet.Direction == TransferDirection.ToServer) ? "C->S" : "S->C");

            if (opcodePacket != null)
            {
                var intOpcode = opcodePacket.Opcode;
                var opcode = (WowOpcodes)intOpcode;
                builder
                    .Append(", ").Append(opcode.ToString())
                    .Append(" (").Append(intOpcode)
                    .Append(", 0x").Append(intOpcode.ToString("X4"))
                    .Append(", ").Append(
                        (opcode.IsJamOpcode() ? "jam " + opcode.CondenseJamOpcode() :
                        (opcode.IsAuthOpcode() ? "auth " + opcode.CondenseAuthOpcode() :
                        (opcode.IsRegularOpcode() ? "cond " + opcode.CondenseOpcode() : "other")))
                        )
                    .Append(")");
            }

            builder
                .Append(", ").Append(dataLength)
                .Append(" bytes").Append(", Flags: ").Append(packet.Flags.ToString());

            return builder.ToString();
        }
    }
}
