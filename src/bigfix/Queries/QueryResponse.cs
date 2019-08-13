using System.Xml.Serialization;

namespace Bigfix
{
    [XmlRoot("BESAPI")]
    public class QueryResponse
    {
        [XmlElement("Query")]
        public QueryResult Query { get; set; }
    }

    public class QueryResult
    {
        [XmlArray("Result")]
        [XmlArrayItem("Answer", typeof(BigfixProperty))]
        public BigfixAnswer[] Answers { get; set; }
    }

    public class BigfixAnswer
    {
        [XmlAttribute]
        public string Type { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}