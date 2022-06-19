using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace IpAddressInfo
{
    internal class DeserializationJsonFromHttp : IDeserializationJson
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IPInfo?> DeserializeJson(string uri)
        {
            Task<Stream>? json = client.GetStreamAsync(uri);

            var jsonObj = JsonSerializer.Deserialize<IPInfo>(await json);

            return jsonObj;
        }
    }
}
