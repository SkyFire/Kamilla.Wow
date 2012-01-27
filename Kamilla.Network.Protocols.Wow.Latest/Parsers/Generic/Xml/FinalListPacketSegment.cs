using System;
using Kamilla.IO;

namespace Kamilla.Network.Protocols.Wow.Latest.Parsers.Generic.Xml
{
    /// <summary>
    /// Represents a list of simple packet segments with a static length.
    /// </summary>
    public class FinalListPacketSegment : ListPacketSegment
    {
        /// <summary>
        /// Overrides <see cref="XmlPacketSegment.Parse"/>,
        /// parsing the current FinalListPacketSegment.
        /// </summary>
        /// <param name="Reader">The packet data reader.</param>
        /// <param name="Container">The parent packet segment container.</param>
        /// <param name="parser">The Xml packet parser.</param>
        /// <returns>The parsed string.</returns>
        public override string Parse(XmlParser parser, StreamHandler Reader, IXmlPacketSegmentContainer Container)
        {
            string content = "List of " + this.SegmentName + ":" + Environment.NewLine;

            ulong i = 0;
            while (Reader.BaseStream.Position < Reader.BaseStream.Length)
                content += ParseList(i++, parser, Reader, this);

            return content;
        }
    }
}
