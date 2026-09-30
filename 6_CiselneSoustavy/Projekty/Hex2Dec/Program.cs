using System.Dynamic;
using System.Collections;
namespace Hex2Dec;


// Napište konzolovou aplikaci v C#, která:
// - Načte řetězec v hex zápisu (např. `2A` nebo `FF`) – bez prefixu `0x` nebo s ním, ale **konzistentně** v celém programu
// - Ověří platnost znaků (0–9, A–F, případně a–f)
// - Převede na desítkové `int` a vypíše
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadejte Hex cislo (bez prefixu): ");
        string hexString = GetHexNum();
        int DecNum = 0;
        int len = hexString.Length;
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "A", 10 },
            { "B", 11 },
            { "C", 12 },
            { "D", 13 },
            { "E", 14 },
            { "F", 15 }
        };

        for(int i = len-1; i >=0; i--)
        {
            if(char.IsNumber(hexString[i]))
            {
                DecNum += int.Parse(hexString[i].ToString()) * (int)Math.Pow(16,len-1-i);
            }
            else
            {
                int num = dict[hexString[i].ToString().ToUpper()];
                DecNum += num * (int)Math.Pow(16,len-1-i);
            }
            
        }
        Console.WriteLine($"Cislo {hexString} je {DecNum} v decimalni");
    }

    static string GetHexNum()
    {
        while(true)
        {
            string hexString = Console.ReadLine();
            if(hexString.All(char.IsLetterOrDigit))
            {
                return hexString;
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }

    }
}
