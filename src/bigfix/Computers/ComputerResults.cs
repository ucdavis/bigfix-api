using System.Linq;

namespace Bigfix
{
    public class ComputerResult {
        public ComputerResult(ComputerResponse response)
        {
            AllProperties = response.Properties;
        }

        public string Get(string prop) {
            return AllProperties.SingleOrDefault(r => r.Name.Equals(prop, System.StringComparison.OrdinalIgnoreCase))?.Value;
        }

        public BigfixProperty[] AllProperties { get; }
    }
}