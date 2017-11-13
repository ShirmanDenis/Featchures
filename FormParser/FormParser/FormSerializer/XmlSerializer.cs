using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FormParser
{
    public class XmlDescriptionBuilder : IDescriptionBuilder, IDisposable
    {
        public XmlWriter Writer { get; private set; }

        public XmlDescriptionBuilder(Stream stream)
        {
            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = ("\t")
            };
            Writer = XmlWriter.Create(stream, settings);
        }

        public object BeginObject(string name)
        {
            Writer.WriteStartElement(name);

            return Writer;
        }

        public void EndObject(object objectHandle)
        {
            Writer.WriteEndElement();
        }

        public void WriteProperty(object parentHandle, string name, string value)
        {
            Writer.WriteAttributeString(name, value);
        }

        public object BeginObjectProperty(object parentHandle, string name, string value = "")
        {
            Writer.WriteStartElement(name);
            if (!string.IsNullOrEmpty(value))
                Writer.WriteValue(value);
            return null;
        }

        public void EndObjectProperty(object objectPropertyHandle)
        {
            Writer.WriteEndElement();
        }

        public object BeginArrayProperty(object parentHandle, string name)
        {
            if (!string.IsNullOrEmpty(name))
                Writer.WriteStartElement(name);

            return string.IsNullOrEmpty(name);
        }

        public void EndArrayProperty(object arrayPropertyHandle)
        {
            var writeArrayAttribute = (bool)arrayPropertyHandle;

            if (!writeArrayAttribute)
                Writer.WriteEndElement();
        }

        public object BeginArrayObjectItem(object parentHandle, string name)
        {
            Writer.WriteStartElement(name);
            return null;
        }

        public void EndArrayObjectItem(object itemHandle)
        {
            Writer.WriteEndElement();
        }

        public void Dispose()
        {
            if (Writer == null) return;

            Writer.Flush();
            Writer.Close();
            Writer = null;
        }
    }

    public class XmlAdapter : IDescriptionAdapter
    {
        public XmlReader Reader { get; private set; }
        public XmlAdapter(Stream stream)
        {
            Reader = XmlReader.Create(stream, new XmlReaderSettings() { IgnoreWhitespace = true, });
        }

        public string GetObjectClassName(object description)
        {
            var reader = (XmlReader)description;
            return reader.LocalName;
        }

        public string GetObjectValue(object description)
        {
            var reader = (XmlReader)description;

            return string.IsNullOrEmpty(reader.Value) ? reader.ReadString() : reader.Value;
        }

        public object GetObjectProperty(object description, string propertyName, params object[] tags)
        {
            throw new NotImplementedException();
        }

        public int? GetIntProperty(object description, string propertyName, params object[] tags)
        {
            var strValue = GetStringProperty(description, propertyName, tags);
            return strValue != null ? (int?)int.Parse(strValue) : null;
        }

        public long? GetLongProperty(object description, string propertyName, params object[] tags)
        {
            var strValue = GetStringProperty(description, propertyName, tags);
            return strValue != null ? (long?)long.Parse(strValue) : null;
        }

        public double? GetDoubleProperty(object description, string propertyName)
        {
            var strValue = GetStringProperty(description, propertyName);
            double returnValue;
            return double.TryParse(strValue, out returnValue) ? (double?)returnValue : null;
        }

        public string GetStringProperty(object description, string propertyName, params object[] tags)
        {
            var reader = (XmlReader)description;

            return reader.NodeType == XmlNodeType.Attribute ? reader.Value : reader.ReadString();
        }

        public T GetEnumProperty<T>(object description, string propertyName, params object[] tags)
        {
            var strValue = GetStringProperty(description, propertyName, tags);
            return strValue != null ? (T)Enum.Parse(typeof(T), strValue) : default(T);
        }

        public bool? GetBoolProperty(object description, string propertyName, params object[] tags)
        {
            var strValue = GetStringProperty(description, propertyName, tags);
            return strValue != null ? (bool?)bool.Parse(strValue) : null;
        }

        public IEnumerable GetArrayProperty(object description, string propertyName, params object[] tags)
        {
            var reader = (XmlReader)description;
            if (reader.EOF) yield break;

            if (tags.Length == 2 && !string.IsNullOrEmpty(propertyName))
            {
                //var objDecodeActions = (Dictionary<string, MetadataDeserializationService.ObjectDecoder>) tags[1];
                Reader.Read();

                //MetadataDeserializationService.ObjectDecoder arrayObjectInitMethod;
                //var isMethodFound = objDecodeActions.TryGetValue(reader.LocalName, out arrayObjectInitMethod);
                //Debug.Assert(isMethodFound, "Missing decode xml part");

                //arrayObjectInitMethod(description, tags[0]);

                yield break;
            }

            Debug.Assert(tags.Length != 0, "Tags must have");
            var arrayItemTypes = (List<string>)tags[0];

            XmlReader inner;
            if (reader.NodeType == XmlNodeType.EndElement)
            {
                reader.Read();
                inner = reader.ReadSubtree();
                inner.Read();
            }
            else if (arrayItemTypes.Contains(reader.LocalName) && reader.NodeType == XmlNodeType.Element)
            {
                var name = reader.LocalName;
                reader.MoveToContent();

                inner = reader.ReadSubtree();
                inner.ReadToDescendant(name);

                var innerDeth = inner.Depth;
                while (arrayItemTypes.Contains(inner.Name) && inner.Depth == innerDeth)
                {
                    yield return inner;
                    inner.Read();
                }
                inner.Close();

                yield break;
            }
            else
            {
                reader.MoveToElement();
                inner = reader.ReadSubtree();
                inner.ReadStartElement(reader.Name);
            }

            var deth = inner.Depth;
            while (arrayItemTypes.Contains(inner.Name) && inner.Depth == deth)
            {
                var itemSubTree = inner.ReadSubtree();

                itemSubTree.Read();
                yield return itemSubTree;
                itemSubTree.Close();

                inner.Read();
            }
            inner.Close();
        }

        public void ReadProperties(object description, object target, Dictionary<string, PropertyDecoder> propDecoders)
        {
            var reader = (XmlReader)description;

            // process attributes
            if (reader.HasAttributes)
            {
                while (reader.MoveToNextAttribute())
                {
                    var propName = reader.LocalName;

                    if (propName == "xsi" || propName == "schemaLocation")
                        continue;

                    PropertyDecoder decoder;
                    if (propDecoders.TryGetValue(propName, out decoder))
                        decoder(reader, target, propName);
                    else
                        throw new Exception("Incorrect xml schema");
                }
            }

            reader.MoveToElement();

            // process inner nodes
            if (!reader.IsEmptyElement)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        propDecoders["text"](description, target, "text");
                        return;
                    }

                    if (reader.NodeType == XmlNodeType.EndElement || reader.NodeType == XmlNodeType.Comment)
                        continue;

                    if (reader.EOF)
                        return;

                    var propName = reader.Name;

                    PropertyDecoder decoder;
                    if (propDecoders.TryGetValue(propName, out decoder))
                    {
                        var subReader = reader.ReadSubtree();
                        subReader.Read();
                        decoder(subReader, target, propName);
                        subReader.Close();
                    }
                    else if (propDecoders.ContainsKey(""))
                    {
                        var subReader = reader.ReadSubtree();
                        subReader.Read();
                        propDecoders[""](subReader, target, propName);
                        subReader.Close();
                    }
                    else
                        throw new Exception("Incorrect xml schema");
                }
            }
        }

        IEnumerable IDescriptionAdapter.GetArrayProperty(object description, string propertyName, params object[] tags)
        {
            throw new NotImplementedException();
        }
    }

    public class XmlSerializer
    {
        public void SerializeObject(Stream stream, object obj)
        {
            using (var builder = new XmlDescriptionBuilder(stream))
            {
                var service = new OptionsSerializationService(builder);
                var handle = builder.BeginObject(obj.GetType().Name);
                {
                    service.EncodeObject(handle, obj);
                }
                builder.EndObject(handle);
            }
        }

        public string SerializeObject(object obj)
        {
            using (var stream = new MemoryStream())
            {
                SerializeObject(stream, obj);

                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public void DeserializeObject(Stream stream, object obj)
        {
            var adapter = new XmlAdapter(stream);
            var service = new OptionsDeserializationService(adapter);

            adapter.Reader.ReadToFollowing(obj.GetType().Name);

            service.DecodeObject(adapter.Reader, obj);
        }

        public void DeserializeObject(string xml, object obj)
        {
            var buffer = Encoding.UTF8.GetBytes(xml);
            using (var memoryStream = new MemoryStream(buffer))
            {
                DeserializeObject(memoryStream, obj);
            }
        }
    }
}
