namespace SoucetNCisel;

// Napište konzolovou aplikaci v C#, která:

// - Načte od uživatele celé kladné číslo `n`
// - Pomocí cyklu `**for`** vypočítá součet všech celých čísel od 1 do `n` (včetně)
// - Vypíše výsledek
// - Demonstrujte použití čítače `i`, podmínky ukončení a změny čítače po každé iteraci
class Program
{
    static void Main(string[] args)
    {
        int n = GetNumber();
        int num = 0;
        for(int i=1; i<=n; i++ )
        {
            num += i;
        }
        Console.WriteLine("Vase cislo je " + num);
    }
    static int GetNumber()
    {
        Console.WriteLine("Zadejte cislo po ktere checte soucet.");
        int num;
        while(true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out num);
            if (parsed && num>0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Spatna hodnota.");
            }
        }

    }
}
