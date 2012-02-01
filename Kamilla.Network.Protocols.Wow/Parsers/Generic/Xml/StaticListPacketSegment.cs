using System;
using System.Xml.Serialization;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Parsers.Generic.Xml
{
    /// <summary>
    /// Represents a list of simple packet segments with a static length.
    /// </summary>
    public class StaticListPacketSegment : ListPacketSegment
    {
        /// <summary>
        /// Gets or sets the length of the list.
        /// </summary>
        [XmlAttribute("Length")]
        public new ulong Length { get; set; }

        /// <summary>
        /// Overrides <see cref="XmlPacketSegment.Parse"/>,
        /// parsing the current StaticListPacketSegment.
        /// </summary>
        /// <param name="Reader">The packet data reader.</param>
        /// <param name="Container">The parent packet segment container.</param>
        /// <param name="parser">The Xml packet parser.</param>
        /// <returns>The parsed string.</returns>
        public override string Parse(XmlParser parser, StreamHandler Reader, IXmlPacketSegmentContainer Container)
        {
            string content = "Static List (" + this.SegmentName + ": " + this.Length + ")" + Environment.NewLine;

            // This looks like this:
            // List (Static Count: 2)                 -- Header.
            //   0) Member1: 1                        -- These two lines are parsed
            //      Member2: 2                        -- by the ParseList overrides.
            //   1) Member1: 3
            //      Member2: 4

            for (ulong i = 0; i < this.Length; ++i)
                content += ParseList(i, parser, Reader, this);

            return content;
        }
    }
}
