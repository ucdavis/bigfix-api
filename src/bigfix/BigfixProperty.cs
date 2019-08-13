
using System.Xml.Serialization;

namespace Bigfix
{
    public class BigfixProperty
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}