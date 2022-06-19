using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAddressInfo
{
    internal interface IDeserializationJson
    {
        Task<IPInfo?> DeserializeJson(string uri);
    }
}
