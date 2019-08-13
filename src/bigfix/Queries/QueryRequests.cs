using System;
using System.Threading.Tasks;

namespace Bigfix
{
    public class QueryRequests : RequestBase
    {
        public QueryRequests(BigfixClient client) : base(client) { }

        public async Task<ComputerResult> Search(string relevance)
        {
            this.Url = "query?relevance=" + relevance;

            var response = await this.GetAsync<ComputerResponse>();
            return new ComputerResult(response);
        }
    }
}
