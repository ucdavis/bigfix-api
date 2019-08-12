using System.Linq;
using System.Xml.Serialization;

namespace Bigfix
{
    public class ComputerResult {
        public ComputerResult(ComputerResponse response)
        {
            OS = response.Properties.SingleOrDefault(r => r.Name.Equals("OS", System.StringComparison.OrdinalIgnoreCase))?.Value;           
        }

        public string OS { get; }
    }

    [XmlRoot("BESAPI")]
    public class ComputerResponse
    {
        [XmlArray("Computer")]
        [XmlArrayItem("Property", typeof(BigfixProperty))]
        public BigfixProperty[] Properties { get; set; }
    }

    public class BigfixProperty
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}