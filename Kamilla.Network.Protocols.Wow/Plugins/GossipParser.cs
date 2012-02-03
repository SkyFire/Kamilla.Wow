using System;
using System.Windows.Input;
using Kamilla.Network.Viewing;
using Kamilla.Network.Viewing.Plugins;

namespace Kamilla.Network.Protocols.Wow.Plugins
{
    public sealed class GossipParser : INetworkLogViewerPlugin
    {
        NetworkLogViewerBase m_viewer;
        GossipParserWindow m_wnd;
        PluginCommand m_command;
        bool m_commandRegistered;

        public void Initialize(NetworkLogViewerBase viewer)
        {
            m_viewer = viewer;
            m_command = new PluginCommand(this, Strings.Gossip_OpenParser,
                new KeyGesture(Key.G, ModifierKeys.Control | ModifierKeys.Alt), Clicked);

            viewer.ProtocolChanged += new EventHandler(viewer_ProtocolChanged);
            viewer.NetworkLogChanged += new EventHandler(viewer_NetworkLogChanged);

            this.UpdateCommand();
            Console.WriteLine("Debug: Gossip Parser initialized.");
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
            }
        }

        void viewer_NetworkLogChanged(object sender, EventArgs e)
        {
            this.UpdateCommand();

            if (m_wnd != null)
                m_wnd.NewItems(m_viewer.Items);
        }

        void viewer_ProtocolChanged(object sender, EventArgs e)
        {
            this.UpdateCommand();
        }

        void Clicked()
        {
            if (m_wnd == null)
                m_wnd = new GossipParserWindow(m_viewer);

            if (!m_wnd.IsVisible)
                m_wnd.Show();
            else
                m_wnd.Hide();
        }
    }
}
