using System;
using System.Threading.Tasks;

namespace Bigfix
{
    public class ComputerRequests : RequestBase
    {
        public ComputerRequests(BigfixClient client) : base(client) { }

        public async Task<ComputerResult> Get(string id)
        {
            this.Url = "computer/" + id;

            var response = await this.GetAsync<ComputerResponse>();
            return new ComputerResult(response);
        }
    }
}
