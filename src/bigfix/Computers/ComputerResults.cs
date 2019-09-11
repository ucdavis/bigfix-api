using System;
using System.Linq;

namespace Bigfix
{
    public class ComputerResult {
        public ComputerResult(ComputerResponse response)
        {
            AllProperties = response.Properties;
        }

        public string Get(string prop) {
            var temp = AllProperties.Where(r => r.Name.Equals(prop, System.StringComparison.OrdinalIgnoreCase)).ToList();
            if (temp.Count > 1)
            {
                return String.Join(", ", temp.Select(a => a.Value).Distinct().ToArray());
            }
            return AllProperties.SingleOrDefault(r => r.Name.Equals(prop, System.StringComparison.OrdinalIgnoreCase))?.Value;
        }

        public BigfixProperty[] AllProperties { get; }
    }
}