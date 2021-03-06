using System;
using System.Threading.Tasks;

namespace Bigfix
{
    public class QueryRequests : RequestBase
    {
        public CommonAccessor Common { get; set; }
        public QueryRequests(BigfixClient client) : base(client) {
            Common = new CommonAccessor();
        }

        public async Task<QueryResult> Search(string relevance)
        {
            this.Url = "query?relevance=" + relevance;

            var response = await this.GetAsync<QueryResponse>();
            return new QueryResult(response);
        }

        public async Task<QueryResult> SearchWithGroupedResults(string relevance)
        {
            this.Url = "query?relevance=" + relevance;

            var response = await this.GetAsync<QueryResponseWithTuples>();
            return new QueryResult(response);
        }
    }

    public class CommonAccessor {
        public CommonQueryRequests Queries { get; set; }
        public CommonGroupedQueryRequests GroupedQueries { get; set; }

        public CommonAccessor()
        {
            Queries = new CommonQueryRequests();
            GroupedQueries = new CommonGroupedQueryRequests();
        }
    }
}
