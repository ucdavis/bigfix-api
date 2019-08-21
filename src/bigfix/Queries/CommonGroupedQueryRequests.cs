using System;

namespace Bigfix
{
    public class CommonGroupedQueryRequests
    {
        public string GetComputerByNameEquals(string name)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(ComputerByNameEqualsQuery));
            return str.Replace("{name}", name);
        }

        public string GetComputerByNameContains(string name)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(ComputerByNameContainsQuery));
            return str.Replace("{name}", name);
        }

        private string ComputerByNameEqualsQuery = "KGlkIG9mIGl0ICwgbmFtZSBvZiBpdCkgb2YgYmVzIGNvbXB1dGVycyB3aG9zZSAobmFtZSBvZiBpdCBlcXVhbHMgIntuYW1lfSIp";
        private string ComputerByNameContainsQuery = "KGlkIG9mIGl0ICwgbmFtZSBvZiBpdCkgb2YgYmVzIGNvbXB1dGVycyB3aG9zZSAobmFtZSBvZiBpdCBjb250YWlucyAie25hbWV9Iik=";
    }
}
