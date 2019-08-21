using System.Xml.Serialization;

namespace Bigfix
{
    [XmlRoot("BESAPI")]
    public class QueryResponse
    {
        [XmlElement("Query")]
        public QueryResultSet Query { get; set; }
    }

    [XmlRoot("BESAPI")]
    public class QueryResponseWithTuples
    {
        [XmlElement("Query")]
        public QueryResultSetWithTuples Query { get; set; }
    }

    public class QueryResultSet
    {
        [XmlArray("Result")]
        [XmlArrayItem("Answer", typeof(QueryAnswer))]
        public QueryAnswer[] Answers { get; set; }
    }

    public class QueryResultSetWithTuples
    {
        [XmlArray("Result")]
        [XmlArrayItem("Tuple", typeof(QueryTuple))]
        public QueryTuple[] Tuples { get; set; }
    }

    public class QueryTuple {
        [XmlElement("Answer")]
        public QueryAnswer[] Answers { get; set; }
    }

    public class QueryAnswer
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}