using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Kamilla.Network.Protocols.Wow.Latest.Game;
using System.Text;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Generic.Xml
{
    // TODO: REMOVE
    /// <summary>
    /// Packet's sender.
    /// </summary>
    public enum PacketSender
    {
        /// <summary>
        /// Both server and client can act as sender.
        /// </summary>
        Any = 0,

        /// <summary>
        /// Only server can act as sender.
        /// </summary>
        Server = 1,

        /// <summary>
        /// Only client can act as sender.
        /// </summary>
        Client = 2
    }

    /// <summary>
    /// Represents a parent for all PacketSegment classes.
    /// </summary>
    public abstract class XmlPacketSegment
    {
        /// <summary>
        /// The Segment's name, displayed to the viewer.
        /// </summary>
        [XmlElement("Name")]
        public string SegmentName;

        /// <summary>
        /// The Segment's data storing type.
        /// </summary>
        [XmlElement("Type")]
        public XmlTypes SimpleType;

        /// <summary>
        /// The enum name this Segment represents.
        /// </summary>
        [XmlElement("SegmentType")]
        public string EnumName;

        /// <summary>
        /// The parsed value, represented by a string.
        /// </summary>
        [XmlIgnore]
        public string Value = string.Empty;

        /// <summary>
        /// Generic parsing method, that must be
        /// implemented by derived PacketSegment classes.
        /// </summary>
        /// <param name="Reader">The packet data reader.</param>
        /// <param name="Container">The parent packet segment container.</param>
        /// <param name="parser">The Xml packet parser.</param>
        /// <returns>The parsed string.</returns>
        public abstract string Parse(XmlParser parser, StreamHandler Reader, IXmlPacketSegmentContainer Container);
    }

    /// <summary>
    /// Represents a segment container.
    /// </summary>
    public interface IXmlPacketSegmentContainer
    {
        /// <summary>
        /// Gets the list of packet segments containted in
        /// the current implementation of IXmlPacketSegmentContainer.
        /// </summary>
        /// <returns>
        /// The list of packet segments containted in the current
        /// implementation of IXmlPacketSegmentContainer.
        /// </returns>
        List<XmlPacketSegment> GetContainedSegments();
    }

    /// <summary>
    /// Represents a single packet definition.
    /// </summary>
    public class XmlPacketDefinition : IXmlPacketSegmentContainer
    {
        /// <summary>
        /// Initializes a new instance of XmlPacketDefinition.
        /// This method is required by serialization.
        /// </summary>
        public XmlPacketDefinition()
        {
        }

        /// <summary>
        /// Contains handled opcode or UNKNOWN_OPCODE.
        /// </summary>
        [XmlAttribute("Opcode")]
        public WowOpcodes Opcode;

        /// <summary>
        /// Specifies the packet group.
        /// </summary>
        [XmlAttribute("Group")]
        public PacketGroups Group;

        /// <summary>
        /// Contains array of handled opcodes.
        /// </summary>
        [XmlArray("Opcodes")]
        [XmlArrayItem("Opcode")]
        public List<WowOpcodes> Opcodes;

        /// <summary>
        /// Represents a list of packet segments of different complexity.
        /// </summary>
        /*
        [XmlElement("FinalList", typeof(FinalListPacketSegment))]
        [XmlElement("Switch", typeof(SwitchPacketSegment))]
        */
        [XmlElement("StaticList", typeof(StaticListPacketSegment))]
        [XmlElement("List", typeof(ListPacketSegment))]
        [XmlElement("Simple", typeof(SimplePacketSegment))]
        [XmlElement("Compressed", typeof(CompressedDataStartPacketSegment))]
        public List<XmlPacketSegment> Structure;

        /// <summary>
        /// Implements <see cref="IXmlPacketSegmentContainer.GetContainedSegments"/>.
        /// </summary>
        /// <returns>The list of packet segments of the current packet definition.</returns>
        public List<XmlPacketSegment> GetContainedSegments() { return Structure; }

        /// <summary>
        /// Contains packet sender or Any.
        /// </summary>
        [XmlAttribute("Sender")]
        public PacketSender Sender;
    }

    /// <summary>
    /// Represents the root element of an XML file, that contains packet definitions.
    /// </summary>
    [XmlRoot("Definitions")]
    public class XmlPacketDefinitions
    {
        /// <summary>
        /// Initializes a new instance of XmlPacketDefinitions.
        /// This method is required by serialization.
        /// </summary>
        public XmlPacketDefinitions()
        {
        }

        /// <summary>
        /// Contains all the packet definitions in the current xml file.
        /// </summary>
        [XmlElement("Packet")]
        public XmlPacketDefinition[] Definitions;
    }

    /// <summary>
    /// Represents the start of compressed data chunk.
    /// </summary>
    public class CompressedDataStartPacketSegment : XmlPacketSegment, IXmlPacketSegmentContainer
    {
        public override string Parse(XmlParser parser, StreamHandler Reader, IXmlPacketSegmentContainer Container)
        {
            var reader = parser.DecompressBlock();
            var builder = new StringBuilder();

            foreach (var segment in this.GetContainedSegments())
                builder.Append(segment.Parse(parser, reader, this));

            return builder.ToString();
        }

        /// <summary>
        /// Represents a list of packet segments of different complexity.
        /// </summary>
        /*
        [XmlElement("FinalList", typeof(FinalListPacketSegment))]
        [XmlElement("Switch", typeof(SwitchPacketSegment))]
        */
        [XmlElement("StaticList", typeof(StaticListPacketSegment))]
        [XmlElement("List", typeof(ListPacketSegment))]
        [XmlElement("Simple", typeof(SimplePacketSegment))]
        public List<XmlPacketSegment> Elements;

        /// <summary>
        /// Implements <see cref="IXmlPacketSegmentContainer.GetContainedSegments"/>.
        /// </summary>
        /// <returns>The list of packet segments of the current list segment.</returns>
        public List<XmlPacketSegment> GetContainedSegments() { return Elements; }
    }
}
