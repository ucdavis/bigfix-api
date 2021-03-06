using System;

namespace Bigfix
{
    public class CommonGroupedQueryRequests
    {
        public string GetComputerByNameEquals(string name)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(ComputerByNameEqualsQuery));
            return str.Replace("{name}", name?.ToUpper());
        }

        public string GetComputerByNameContains(string name)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(ComputerByNameContainsQuery));
            return str.Replace("{name}", name?.ToUpper());
        }

        private string ComputerByNameEqualsQuery = "KGlkIG9mIGl0ICwgbmFtZSBvZiBpdCkgb2YgYmVzIGNvbXB1dGVycyB3aG9zZSAobmFtZSBvZiBpdCBhcyB1cHBlcmNhc2UgZXF1YWxzICJ7bmFtZX0iKQ==";
        private string ComputerByNameContainsQuery = "KGlkIG9mIGl0ICwgbmFtZSBvZiBpdCkgb2YgYmVzIGNvbXB1dGVycyB3aG9zZSAobmFtZSBvZiBpdCBhcyB1cHBlcmNhc2UgY29udGFpbnMgIntuYW1lfSIp";
    }
}
