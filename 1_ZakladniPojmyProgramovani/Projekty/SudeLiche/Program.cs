namespace SudeLiche;

// Napište konzolovou aplikaci v C#, která:
// - Načte od uživatele celé číslo
// - Zjistí, zda je číslo sudé nebo liché (operátor modulo %)
// - Vypíše odpovídající zprávu
// - Demonstrujte práci s datovým typem int a operátorem zbytku po dělení
class Program
{
    static void Main(string[] args)
    {
        int cislo;
        Console.WriteLine("Zadejte cislo: ");
        while(true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out cislo);
            if(parsed)
            {break;}
        }
        int zbytek = cislo%2;
        if(zbytek == 0)
        {
            Console.WriteLine("Cislo " + cislo + " je sude");
        }
        else
        {
            Console.WriteLine("Cislo " + cislo + " je liche");
        }
    }
}
