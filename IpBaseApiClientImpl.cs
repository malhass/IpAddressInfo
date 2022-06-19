using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace IpAddressInfo
{
    class IpBaseAPIClientImpl : IIPBaseAPIClient
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IPInfo?> GetIpInfo(string ipAddress)
        {
            var uri = @$"???";

            DeserializationJsonFromHttp deserialization = new DeserializationJsonFromHttp();

            return await deserialization.DeserializeJson(uri);
        }
    }
}
