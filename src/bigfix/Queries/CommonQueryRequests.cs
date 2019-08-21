using System;

namespace Bigfix
{
    public class CommonQueryRequests {

        public string GetWindowsIdentifyingNumberById(string id)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(WindowsIdentifyingNumberByIdQuery));
            return str.Replace("{id}", id);
        }
        public string GetWindowsMacAddressesById(string id)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(WindowsMacAddressesByIdQuery));
            return str.Replace("{id}", id);
        }
        public string GetMacOSXMacAddressesById(string id)
        {
            var str = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(MacOSXMacAddressesByIdQuery));
            return str.Replace("{id}", id);
        }

        private string WindowsIdentifyingNumberByIdQuery = "KGl0KSBvZiAoKGlmIChleGlzdHMgcmVzdWx0IChpdGVtIDAgb2YgaXQgLCBpdGVtIDEgb2YgaXQpIGFuZCBleGlzdHMgdmFsdWVzIG9mIHJlc3VsdCAoaXRlbSAwIG9mIGl0ICwgaXRlbSAxIG9mIGl0KSkgdGhlbiAoY29uY2F0ZW5hdGlvbiAiJTBBIiBvZiB2YWx1ZXMgb2YgcmVzdWx0IChpdGVtIDAgb2YgaXQgLCBpdGVtIDEgb2YgaXQpKSBlbHNlICgiIikpKSBvZiAoZWxlbWVudHMgb2YgaW50ZXJzZWN0aW9uIG9mICgoc2V0cyBvZiBpdGVtcyAwIG9mIChjb21wdXRlcnMgb2YgaXQgLCB2YWx1ZXMgd2hvc2UgKGl0IGFzIGxvd2VyY2FzZSA9ICJ7aWR9Iikgb2YgaXQpIG9mIHJlc3VsdHMgb2YgYmVzIHByb3BlcnR5ICJJRCIpKSAsIGJlcyBwcm9wZXJ0eSAiSWRlbnRpZnlpbmcgTnVtYmVyIC0gV2luZG93cyIpICA=";
        private string WindowsMacAddressesByIdQuery = "KGl0KSBvZiAoKGlmIChleGlzdHMgcmVzdWx0IChpdGVtIDAgb2YgaXQgLCBpdGVtIDEgb2YgaXQpIGFuZCBleGlzdHMgdmFsdWVzIG9mIHJlc3VsdCAoaXRlbSAwIG9mIGl0ICwgaXRlbSAxIG9mIGl0KSkgdGhlbiAoY29uY2F0ZW5hdGlvbiAiJTBBIiBvZiB2YWx1ZXMgb2YgcmVzdWx0IChpdGVtIDAgb2YgaXQgLCBpdGVtIDEgb2YgaXQpKSBlbHNlICgiIikpKSBvZiAoZWxlbWVudHMgb2YgaW50ZXJzZWN0aW9uIG9mICgoc2V0cyBvZiBpdGVtcyAwIG9mIChjb21wdXRlcnMgb2YgaXQgLCB2YWx1ZXMgd2hvc2UgKGl0IGFzIGxvd2VyY2FzZSA9ICJ7aWR9Iikgb2YgaXQpIG9mIHJlc3VsdHMgb2YgYmVzIHByb3BlcnR5ICJJRCIpKSAsIGJlcyBwcm9wZXJ0eSAiTWFjIEFkZHJlc3NlcyAtIFdpbmRvd3MiKSAg";
        private string MacOSXMacAddressesByIdQuery = "KGl0KSBvZiAoKGlmIChleGlzdHMgcmVzdWx0IChpdGVtIDAgb2YgaXQgLCBpdGVtIDEgb2YgaXQpIGFuZCBleGlzdHMgdmFsdWVzIG9mIHJlc3VsdCAoaXRlbSAwIG9mIGl0ICwgaXRlbSAxIG9mIGl0KSkgdGhlbiAoY29uY2F0ZW5hdGlvbiAiJTBBIiBvZiB2YWx1ZXMgb2YgcmVzdWx0IChpdGVtIDAgb2YgaXQgLCBpdGVtIDEgb2YgaXQpKSBlbHNlICgiIikpKSBvZiAoZWxlbWVudHMgb2YgaW50ZXJzZWN0aW9uIG9mICgoc2V0cyBvZiBpdGVtcyAwIG9mIChjb21wdXRlcnMgb2YgaXQgLCB2YWx1ZXMgd2hvc2UgKGl0IGFzIGxvd2VyY2FzZSA9ICJ7aWR9Iikgb2YgaXQpIG9mIHJlc3VsdHMgb2YgYmVzIHByb3BlcnR5ICJJRCIpKSAsIGJlcyBwcm9wZXJ0eSAiTWFjIEFkZHJlc3NlcyAtIE1hYyBPUyBYIikgIA==";

    }
}
