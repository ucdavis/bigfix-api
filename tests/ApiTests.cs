using System.Linq;
using System.Threading.Tasks;
using Bigfix;
using Xunit;

namespace tests
{
    public class ApiTests
    {
        const string username = "";
        const string password = "";

        [Fact]
        public async Task CanGetComputer()
        {
            var client = new BigfixClient();

            var result = await client.Computers.Get("1677559868");

            Assert.True(true);
        }
    }
}