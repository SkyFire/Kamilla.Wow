using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Generic.Xml
{
    /// <summary>
    /// Represents a list of simple packet segments.
    /// </summary>
    public class ListPacketSegment : SimplePacketSegment, IXmlPacketSegmentContainer
    {
        /// <summary>
        /// Gets or sets the length of the list.
        /// </summary>
        [XmlIgnore]
        public ulong Length { get; set; }

        /// <summary>
        /// Optional Length Segment Name.
        /// </summary>
        [XmlAttribute("LengthSegment")]
        public string LengthSegmentName;

        /// <summary>
        /// Overrides <see cref="XmlPacketSegment.Parse"/>,
        /// parsing the current ListPacketSegment.
        /// </summary>
        /// <param name="Reader">The packet data reader.</param>
        /// <param name="Container">The parent packet segment container.</param>
        /// <param name="parser">The Xml packet parser.</param>
        /// <returns>The parsed string.</returns>
        public override string Parse(XmlParser parser, StreamHandler Reader, IXmlPacketSegmentContainer Container)
        {
            string content = string.Empty;

            if (String.IsNullOrEmpty(LengthSegmentName))
            {
                content = "List (" + base.Parse(parser, Reader, Container) + ")" + Environment.NewLine;
                this.Length = ulong.Parse(base.Value);
            }
            else
            {
                XmlPacketSegment lengthSegment = null;
                foreach (XmlPacketSegment segment in Container.GetContainedSegments())
                {
                    if (segment.SegmentName == LengthSegmentName)
                        lengthSegment = segment;
                }

                if (lengthSegment != null)
                {
                    content = "List (" + LengthSegmentName + ": " + lengthSegment.Value + ")" + Environment.NewLine;
                    this.Length = ulong.Parse(lengthSegment.Value);
                }
                else
                    throw new Exception("Failed to find Length Segment with name '" + LengthSegmentName + "'");
            }

            // This looks like this:
            // List (Element Count: 2)                -- Header.
            //   0) Member1: 1                        -- These two lines are parsed
            //      Member2: 2                        -- by the ParseList overrides.
            //   1) Member1: 3
            //      Member2: 4

            for (ulong i = 0; i < this.Length; ++i)
                content += ParseList(i, parser, Reader, this);

            return content;
        }

        /// <summary>
        /// Parses one list element.
        /// </summary>
        /// <param name="Reader">The packet data reader.</param>
        /// <param name="List">Current list.</param>
        /// <param name="index">Index of the current element.</param>
        /// <param name="parser">The Xml packet parser.</param>
        /// <returns>The parsed string.</returns>
        public string ParseList(ulong index, XmlParser parser, StreamHandler Reader, ListPacketSegment List)
        {
            //   1) Member1: 3
            //      Member2: 4

            string content = index.ToString().PadLeft(3) + ") ";

            bool first = true;
            foreach (XmlPacketSegment segment in List.GetContainedSegments())
            {
                if (!first)
                    content += string.Empty.PadRight(5);
                else
                    first = false;

                content += segment.Parse(parser, Reader, List).PadMultiline(5) + Environment.NewLine;
            }

            return content;
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
