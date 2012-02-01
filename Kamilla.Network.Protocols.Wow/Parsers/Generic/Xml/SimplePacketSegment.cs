using System;
using System.IO;
using Kamilla.IO;
using System.Reflection;
using Kamilla;
using Kamilla.Network.Protocols.Wow.OpcodeDatas;

namespace Kamilla.Network.Protocols.Wow.Parsers.Generic.Xml
{
    /// <summary>
    /// Represents a simple packet segment.
    /// </summary>
    public class SimplePacketSegment : XmlPacketSegment
    {
        // TODO: REDO METHOD
        /// <summary>
        /// Overrides <see cref="XmlPacketSegment.Parse"/>,
        /// parsing the current SimplePacketSegment.
        /// </summary>
        /// <param name="Reader">The packet data reader.</param>
        /// <param name="Container">The parent packet segment container.</param>
        /// <param name="parser">The Xml packet parser.</param>
        /// <returns>The parsed string.</returns>
        public override string Parse(XmlParser parser, StreamHandler Reader, IXmlPacketSegmentContainer Container)
        {
            Type T = null;

            if (SimpleType != XmlTypes.OpcodeData)
                Value = XmlTypeReader.Read(Reader, SimpleType);

            if (!String.IsNullOrEmpty(this.EnumName))
            {
                string nameSpace = Assembly.GetExecutingAssembly().GetName().Name;
                string[] searches =
                {
                    // game namespace
                    nameSpace + ".Game.{0}, " + nameSpace,
                    // base assembly
                    ProjectInformation.Title + ".Network.Protocols.Wow.{0}, " + ProjectInformation.Title + ".Wow",
                    // opcode datas
                    nameSpace + ".OpcodeDatas.{0}, " + nameSpace,
                    // base namespace
                    nameSpace + ".{0}, " + nameSpace,
                };

                int i = -1;
                while (T == null && ++i < searches.Length)
                    T = Type.GetType(string.Format(searches[i], this.EnumName));

                if (T == null)
                    throw new Exception("Type " + this.EnumName + " cannot be found.");

                if (SimpleType == XmlTypes.OpcodeData)
                {
                    if (T.GetInterface(typeof(IOpcodeData).Name) == null)
                        throw new Exception("Type " + T + " does not implement IOpcodeData interface.");

                    IOpcodeData data = null;

                    try
                    {
                        data = (IOpcodeData)Activator.CreateInstance(T, Reader, true);
                    }
                    catch (MissingMethodException)
                    {
                        try
                        {
                            data = (IOpcodeData)Activator.CreateInstance(T);
                        }
                        catch (MissingMethodException)
                        {
                            throw new Exception("Type " + T + " has no appropriate constructors.");
                        }
                        catch (System.Reflection.TargetInvocationException e)
                        {
                            throw e.InnerException;
                        }
                    }
                    catch (System.Reflection.TargetInvocationException e)
                    {
                        throw e.InnerException;
                    }

                    data.Read(Reader);

                    Value = data.ToString();
                }
                else
                {
                    try
                    {
                        var longval = long.Parse(Value);
                        var enumized = (Enum)Enum.ToObject(T, longval);

                        Value = String.Format("{0} ({1:D}, 0x{1:X})", enumized.GetLocalizedName(), longval);
                    }
                    catch (Exception e)
                    {
                        Value = string.Format("{0} (Failed to convert to {1}, error={2})", Value, T, e);
                    }
                }
            }

            if (!string.IsNullOrEmpty(this.SegmentName))
            {
                string header = this.SegmentName + ": ";

                return header + Value.PadMultiline(header.Length);
            }
            else
                return Value;
        }
    }
}
