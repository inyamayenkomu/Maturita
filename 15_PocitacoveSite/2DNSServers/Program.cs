using System.Threading.Channels;

namespace _2DNSServers;

class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<string,string> primary = new Dictionary<string, string>{
            ["seznam.cz"] = "12.34.56",
            ["google.com"] = "123.456.6898",
            ["youtube.com"] = "13.45.665"
            }; 

        Dictionary<string,string> secondary = new Dictionary<string, string>{
            ["example.cz"] = "13.32.123",
            ["google.com"] = "123.456.6898",
            ["youtube.com"] = "13.45.665"
            }; 
        
        DNS primaryDNS = new DNS(primary,1);
        DNS secondaryDNS = new DNS(secondary,2);
        DNS[] DNSServers = new DNS[2];
        DNSServers.Append(primaryDNS);
        DNSServers.Append(secondaryDNS);

        while(true)
        {
            Console.WriteLine("Zadejte url: ");
            string url = Console.ReadLine();
            foreach(DNS server in DNSServers)
            {
                string response = server.Lookup(url);
                
                Console.WriteLine(response);
            }
        }
        Console.WriteLine("Hello, World!");
    }
}
class DNS
{
    private Dictionary<string,string> d;
    private int num;
    public DNS(Dictionary<string,string> d, int num)
    {
        this.d = d; 
        this.num = num;
    }
    public string Lookup(string url)
    {
        string ip;
        bool good = d.TryGetValue(url, out ip);
        if(good)
        {
            return ip + num;
        }
        else
        {
            return "not good " + num;
        }
    }
}
