using System;
using System.Net.Http;

namespace Bigfix
{
    public class BigfixClient : IDisposable
    {
        public string BaseUrl { get; private set; }
        public HttpClient HttpProvider { get; private set; }

        public BigfixClient(string baseUrl = "https://bigfix-master1.ou.ad3.ucdavis.edu:52311/api/")
        {
            // TOOD: workaround because bigfix ssl cert is invalid.  get them to fix
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            HttpProvider = new HttpClient(httpClientHandler);
            this.BaseUrl = baseUrl;
        }

        public ComputerRequests Computers => new ComputerRequests(this);

        public void Dispose()
        {
            if (this.HttpProvider != null) {
                this.HttpProvider.Dispose();
            }
        }
    }
}
