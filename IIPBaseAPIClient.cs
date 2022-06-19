using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAddressInfo
{
    internal interface IIPBaseAPIClient
    {
        Task<IPInfo> GetIpInfo(string ipAddress);
    }
}
