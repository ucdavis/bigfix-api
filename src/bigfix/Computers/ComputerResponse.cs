using System.Xml.Serialization;

namespace Bigfix
{
    [XmlRoot("BESAPI")]
    public class ComputerResponse
    {
        [XmlArray("Computer")]
        [XmlArrayItem("Property", typeof(BigfixProperty))]
        public BigfixProperty[] Properties { get; set; }
    }
}