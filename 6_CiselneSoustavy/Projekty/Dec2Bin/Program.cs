using System.ComponentModel;

namespace Dec2Bin;


// Napište konzolovou aplikaci v C#, která:
// - Načte od uživatele nezáporné celé číslo v **desítkové** soustavě
// - Převede ho na zápis ve **dvojkové** soustavě (řetězec pouze znaků `'0'` a `'1'`)
// - Můžete použít vestavěné funkce (`Convert`, formátování) **nebo** vlastní algoritmus dělení dvěma v cyklu – podle požadavku učitele vypište obě varianty nebo jednu z nich
// - Výsledek vypište s popiskem (např. „42 v binární soustavě: 101010“)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadejte nezaporne cislo v desitkove soustave: ");
        int decNum = GetNumber();
        int decNumPrint = decNum;
        string binString = "";
        if (decNum != 0)
        {
            while(decNum !=0 )
            {
                int rem = decNum%2;
                binString = rem + binString;
                decNum /= 2;
            }
        }
        else{binString = "0";}
        Console.WriteLine($"Cislo {decNumPrint} je {binString} v binarni soustave");
    }

    static int GetNumber()
    {
        int output;
        while(true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out output);
            if(parsed && output >= 0)
            {return output;}
            else
            {Console.WriteLine("Spatnej input");}
        }
    }
}
