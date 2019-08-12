using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bigfix
{
    public abstract class RequestBase
    {
        private readonly BigfixClient client;

        protected string Url { get; set; }

        public RequestBase(BigfixClient client)
        {
            this.client = client;
        }

        protected async Task<T> GetAsync<T>()
        {
            var uri = new StringBuilder();
            uri.Append(client.BaseUrl);
            uri.Append(this.Url);

            // TODO: remove
            System.Console.WriteLine(uri.ToString());

            var result = await client.HttpProvider.GetAsync(uri.ToString());

            result.EnsureSuccessStatusCode();

            var resultContent = await result.Content.ReadAsStringAsync();

            // TODO: remove
            System.Console.WriteLine(resultContent);

            // TODO: convert responce into object
            return default(T);
        }
    }
}