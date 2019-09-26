using System;
using System.Net;

namespace Bigfix
{
    public class BigfixApiException: Exception {
        public BigfixApiException(HttpStatusCode statusCode, string message): base(message)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }
    }
}