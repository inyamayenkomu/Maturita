using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Znamky;

// Napište konzolovou aplikaci v C#, která:
// - Načte od uživatele známku 1–5
// - Pomocí switch nebo if-else přiřadí textový popis: 1 = výborně, 2 = chvalitebně, 3 = dobře, 4 = dostatečně, 5 = nedostatečně
// - Pro neplatnou hodnotu (mimo 1–5) vypíše chybovou zprávu
// - Demonstrujte použití switch pro více větví
class Program
{
    static void Main(string[] args)
    {
        int znamka;
        Console.WriteLine("Zadejte znamku: ");
        while (true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out znamka);
            if(parsed)
            {
                break;
            }
            Console.WriteLine("Neplatna hodnota");
        }
        switch(znamka)
        {
            case 1:
                Console.WriteLine("vyborne");
                break;
            case 2:
                Console.WriteLine("chvalitebne");
                break;
            case 3:
                Console.WriteLine("dobre");
                break;
            case 4:
                Console.WriteLine("dostatecne");
                break;
            case 5:
                Console.WriteLine("nedostatecne");
                break;
            default:
                Console.WriteLine("neplatna hodnota");
                break;
        }
    }
}
