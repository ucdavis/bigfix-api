
using System.Linq;

namespace Bigfix
{
    public class QueryResult
    {
        public QueryTuple[] Tuples { get; set; }
        public QueryAnswer[] AllAnswers { get; set; }
        public QueryResult(QueryResponse response)
        {
            AllAnswers = response.Query.Answers;
        }

        public QueryResult(QueryResponseWithTuples response)
        {
            Tuples = response.Query.Tuples;
            AllAnswers = response.Query.Tuples.SelectMany(t => t.Answers).ToArray();
        }
    }
}