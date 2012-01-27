using Kamilla.Network.Protocols.Wow.Latest.Game;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Gossip
{
    // TODO: redo
    [WowPacketParser(WowOpcodes.SMSG_GOSSIP_POI)]
    internal sealed class GossipPoiParser : WowPacketParser
    {
        protected override PacketGroups WowGroup { get { return PacketGroups.Queries; } }

        protected override void InternalParse()
        {
            GossipPoi gp = new GossipPoi();

            if (Reader.BaseStream.Length < 5)
                return;

            gp.Flag = Reader.ReadInt32();
            gp.X = Reader.ReadSingle();
            gp.Y = Reader.ReadSingle();
            gp.Icon = Reader.ReadInt32();
            gp.Data = Reader.ReadInt32();
            gp.Location = Reader.ReadCString(); 

            Output.AppendLine("POI Flag:   " + gp.Flag);
            Output.AppendFormatLine("POI Points: X={0:F5} Y={1:F5}", gp.X, gp.Y);
            Output.AppendLine("POI Icon:   " + gp.Icon);
            Output.AppendLine("POI Data:   " + gp.Data);
            Output.AppendLine("Location:   " + gp.Location);

            //AppendFormatLine("UPDATE `gossip_menu_option` SET action_poi_id = '{0}' WHERE menu_id = '{1}' && id = '{2}';", Utility.MemberPOIId, Utility.MemberMenuIdOld, Utility.MemberMenuItemId);
            //AppendFormatLine(@"INSERT IGNORE INTO `points_of_interest` (`entry`, `x`, `y`, `icon`, `flags`, `data`, `icon_name`) VALUE ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", Utility.MemberPOIId, coord_x, coord_y, icon, flag, data, location);
        }
    }

    struct GossipPoi
    {
        public int    Flag;
        public float  X;
        public float  Y;
        public int    Icon;
        public int    Data;
        public string Location;
    }
}
