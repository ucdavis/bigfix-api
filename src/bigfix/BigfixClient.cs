using System;
using System.Net.Http;

namespace Bigfix
{
    public class BigfixClient
    {
        public string BaseUrl { get; private set; }
        public HttpClient HttpProvider { get; private set; }

        public BigfixClient(string baseUrl = "https://bfix/api/")
        {
            HttpProvider = new HttpClient();
            this.BaseUrl = BaseUrl;
        }

        public ComputerRequests Computers => new ComputerRequests(this);
    }
}
