using System.Linq;
using System.Threading.Tasks;
using Bigfix;
using Xunit;

namespace tests
{
    public class ApiTests
    {
        const string username = "bfixcaes";
        const string password = "";

        [Fact]
        public async Task CanGetComputer()
        {
            var client = new BigfixClient(username, password);

            var result = await client.Computers.Get("1677559868");

            Assert.True(true);

            var ip = result.Get(ComputerProperty.IPAddress);

            Assert.False(string.IsNullOrEmpty(ip));
        }

        [Fact]
        public async Task CanGetQuery()
        {
            var client = new BigfixClient(username, password);

            var result = await client.Queries.Search("(values of it) of (results (bes properties (\"IP Address\"), it)) of bes computers");

            Assert.NotEmpty(result.AllAnswers);
        }

        [Fact]
        public async Task CanGetTupleQuery()
        {
            var client = new BigfixClient(username, password);

            var result = await client.Queries.SearchWithGroupedResults("(id of it , name of it) of bes computers whose (name of it equals \"CAES-7TW1H12\")");

            Assert.NotEmpty(result.Tuples);
        }

        [Fact]
        public async Task CanGetNoResultTupleQuery()
        {
            var client = new BigfixClient(username, password);

            var result = await client.Queries.SearchWithGroupedResults("(id of it , name of it) of bes computers whose (name of it equals \"BADNAME\")");

            Assert.Empty(result.Tuples);
        }

        [Fact]
        public async Task CanUseCommonQuery()
        {
            var client = new BigfixClient(username, password);

            var query = client.Queries.Common.GetComputerByName("CAES-7TW1H12");
            var result = await client.Queries.SearchWithGroupedResults(query);

            Assert.NotEmpty(result.Tuples);
        }
    }
}