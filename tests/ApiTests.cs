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

            Assert.False(string.IsNullOrEmpty(result.OS));
        }
    }
}