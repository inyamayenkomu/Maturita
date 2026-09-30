using System.Runtime.InteropServices;

namespace Obdelnik;

// Napište konzolovou aplikaci v C#, která:
// - Načte od uživatele délku stran a a b obdélníku
// - Vypočítá obvod (2 × (a + b)) a obsah (a × b)
// - Vypíše obě hodnoty s popisem
// - Použijte proměnné, vstup/výstup a základní operace
class Program
{
    static void Main(string[] args)
    {

        double a = InputSide("a");
        double b = InputSide("b");
        double obsah = a*b;
        double obvod = 2*(a+b);
        Console.WriteLine("Obsah: " + obsah + " Obvod: " + obvod); 
    }
    static double InputSide(string name)
    {
        double side;
        Console.WriteLine("Zadejte stranu " + name + ":");
        while(true)
        {
            bool parsed = double.TryParse(Console.ReadLine(), out side);
            if(parsed)
            {return side;}
        }
    }
}
