using System;
using System.ComponentModel;
using System.Windows.Input;
using Kamilla.Network.Viewing;
using Kamilla.Network.Viewing.Plugins;
using System.Xml.Serialization;
using System.Reflection;
using System.Linq;

namespace Kamilla.Network.Protocols.Wow.Plugins
{
    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    [XmlRoot("OpcodeInfo")]
    public class OpcodeInfo
    {
        public class OpcodeSenderInfo
        {
            [XmlAttribute("func")]
            public uint Function;

            [XmlAttribute("addr")]
            public uint Address;

            [XmlAttribute("name")]
            public string Name;
        }

        [XmlAttribute("value")]
        public uint Opcode;

        [XmlAttribute("index")]
        public uint Index;

        [XmlAttribute("ctor")]
        public uint Constructor;

        [XmlAttribute("handler")]
        public uint Handler;

        [XmlAttribute("dtor")]
        public uint Destructor;

        [XmlAttribute("comment")]
        public string Comment;

        [XmlArray("Senders")]
        [XmlArrayItem("Sender")]
        public OpcodeSenderInfo[] Senders;
    }

    sealed class OpcodeInfoPlugin : INetworkLogViewerPlugin
    {
        static OpcodeInfo[] m_infos;
        public static OpcodeInfo[] OpcodeInfos
        {
            get
            {
                if (m_infos == null)
                {
                    try
                    {
                        var assembly = Assembly.GetExecutingAssembly();
                        var filename = assembly.GetManifestResourceNames().Single(
                            s => s.EndsWith("OpcodeInfo.xml", StringComparison.InvariantCultureIgnoreCase));
                        using (var stream = assembly.GetManifestResourceStream(filename))
                        {
                            var ser = new XmlSerializer(typeof(OpcodeInfo[]));
                            m_infos = (OpcodeInfo[])ser.Deserialize(stream);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: Failed to extract opcode info.{0}{1}",
                            Environment.NewLine, e.ToString());

                        m_infos = new OpcodeInfo[0];
                    }
                }

                return m_infos;
            }
        }

        NetworkLogViewerBase m_viewer;
        OpcodeInfoWindow m_wnd;
        PluginCommand m_command;
        bool m_commandRegistered;

        public void Initialize(NetworkLogViewerBase viewer)
        {
            m_viewer = viewer;
            m_command = new PluginCommand(this, Strings.OI_OpenOI,
                new KeyGesture(Key.O, ModifierKeys.Control | ModifierKeys.Alt), Clicked);

            viewer.ProtocolChanged += new EventHandler(viewer_ProtocolChanged);
            viewer.NetworkLogChanged += new EventHandler(viewer_NetworkLogChanged);

            this.UpdateCommand();
            Console.WriteLine("Debug: Opcode Info initialized.");
        }

        void UpdateCommand()
        {
            if (m_viewer.CurrentProtocol is WowProtocol)
            {
                if (!m_commandRegistered)
                {
                    m_viewer.RegisterPluginCommand(m_command);
                    m_commandRegistered = true;
                }
            }
            else
            {
                if (m_commandRegistered)
                {
                    m_viewer.UnregisterPluginCommand(m_command);
                    m_commandRegistered = false;
                }

                if (m_wnd != null && m_wnd.IsVisible)
                    m_wnd.Close();
            }
        }

        void viewer_NetworkLogChanged(object sender, EventArgs e)
        {
            this.UpdateCommand();
        }

        void viewer_ProtocolChanged(object sender, EventArgs e)
        {
            this.UpdateCommand();
        }

        void Clicked()
        {
            if (m_wnd == null)
                m_wnd = new OpcodeInfoWindow(m_viewer);

            var item = m_viewer.SelectedItem;
            if (item != null)
            {
                var packet = item.Packet as IPacketWithOpcode;
                if (packet != null)
                    m_wnd.Prepare((WowOpcodes)packet.Opcode);
            }

            if (!m_wnd.IsVisible)
                m_wnd.Show();
        }
    }
}
