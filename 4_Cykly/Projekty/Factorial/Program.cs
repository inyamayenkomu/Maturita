namespace Factorial;
// - Načte od uživatele nezáporné celé číslo `n` (faktoriál je definován pro 0! = 1)
// - Vypočítá `n!` pomocí cyklu `**for**` nebo `**while**` (bez rekurze)
// - Vypíše výsledek
// - Pro neplatný vstup (záporné číslo) vypište chybovou zprávu
class Program
{
    static void Main(string[] args)
    {
        int n = GetNumber();
        if(n == 0)
        {
            Console.WriteLine("Vysledek je 1");
        }
        else
        {
            int output = 1;
            for(int i = 2; i<=n;i++)
            {
                output *= i;
            }
            Console.WriteLine($"Vysledek je {output}");
        }
    }
    static int GetNumber()
    {
        Console.WriteLine("Zadejte cislo: ");
        int num;
        while(true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out num);
            if(parsed && num>=0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Spatna hodnota, zkuste znovu: ");
            }
        }
    }
}
