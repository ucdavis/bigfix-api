using System;
using System.Net.Http;
using System.Text;

namespace Bigfix
{
    public class BigfixClient : IDisposable
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string BaseUrl { get; private set; }
        public HttpClient HttpProvider { get; private set; }

        public BigfixClient(string username, string password, string baseUrl = "https://bigfix-master1.ou.ad3.ucdavis.edu:52311/api/")
        {
            Username = username;
            Password = password;

            HttpProvider = new HttpClient(new HttpClientHandler());

            var byteArray = Encoding.ASCII.GetBytes($"{Username}:{Password}");
            HttpProvider.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            this.BaseUrl = baseUrl;
        }

        public ComputerRequests Computers => new ComputerRequests(this);
        public QueryRequests Queries => new QueryRequests(this);

        public void Dispose()
        {
            if (this.HttpProvider != null)
            {
                this.HttpProvider.Dispose();
            }
        }
    }
}
