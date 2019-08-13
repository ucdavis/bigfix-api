using System;
using System.Threading.Tasks;

namespace Bigfix
{
    public class QueryRequests : RequestBase
    {
        public CommonQueryRequests Common { get; set; }
        public QueryRequests(BigfixClient client) : base(client) {
            Common = new CommonQueryRequests();
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

    public class CommonQueryRequests {
        public string GetComputerByName(string name) {
            return $"(id of it , name of it) of bes computers whose (name of it equals \"{name}\")";
        }
    }
}
