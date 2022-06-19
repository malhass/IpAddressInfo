using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAddressInfo
{
    internal class VizualizatorIpAddress
    {
        IDeserializationJson DeserializationJson { get; set; }
        IPrinterInfo PrinterInfo { get; set; }

        public VizualizatorIpAddress(IDeserializationJson deserialization, IPrinterInfo printer)
        {
            this.DeserializationJson = deserialization;
            this.PrinterInfo = printer;
        }

        public async Task VizualizatorJsonAsync()
        {
            var uri = "???";
            var jsonObj = await DeserializationJson.DeserializeJson(uri);
            PrinterInfo.Printer(jsonObj);
        }
    }
}
