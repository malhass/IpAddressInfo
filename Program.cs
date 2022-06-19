using System.Text.Json;

namespace IpAddressInfo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "IpAddressInfo";

            string? ipAddress = Console.ReadLine();

            IpBaseAPIClientImpl ipBaseAPIClientImpl = new IpBaseAPIClientImpl();
            ipBaseAPIClientImpl.GetIpInfo(ipAddress);

            VizualizatorIpAddress ipAddressVizualizator = new(new DeserializationJsonFromHttp(), new PrinterInfo());

            try
            { 
                await ipAddressVizualizator.VizualizatorJsonAsync();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.ReadKey();
        }
    }
}

