using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAddressInfo
{
    internal class PrinterInfo : IPrinterInfo
    {
        public void Printer(IPInfo jsonObj)
        {
            Console.WriteLine($"ip: \'{jsonObj.data.ip}\'");
            Console.WriteLine($"type: \'{jsonObj.data.type}\'");
            Console.WriteLine($"connection.asn: \'{jsonObj.data.connection.asn}\'");
            Console.WriteLine($"connection.organization: \'{jsonObj.data.connection.organization}\'");
            Console.WriteLine($"connection.isp: \'{jsonObj.data.connection.isp}\'");
        }
    }
}
