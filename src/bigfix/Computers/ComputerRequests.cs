using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bigfix
{
    public class ComputerRequests : RequestBase
    {
        public ComputerRequests(BigfixClient client) : base(client) { }

        public async Task<ComputerResults> Get(string id)
        {
            this.Url = "computers/" + id;

            return await this.GetAsync<ComputerResults>();
        }
    }
}
