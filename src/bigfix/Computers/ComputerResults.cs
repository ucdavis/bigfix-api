using System;
using System.Linq;

namespace Bigfix
{
    public class ComputerResult {
        public ComputerResult(ComputerResponse response)
        {
            AllProperties = response.Properties;
        }

        public string Get(string prop)
        {

            return string.Join(", ",AllProperties
                    .Where(r => r.Name.Equals(prop, System.StringComparison.OrdinalIgnoreCase))
                    .Select(a => a.Value).Distinct().ToArray());
        }

        public BigfixProperty[] AllProperties { get; }
    }
}