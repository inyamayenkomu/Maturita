namespace PrevodStupnu;

// Napište konzolovou aplikaci v C#, která:
// - Načte teplotu v stupních Celsia
// - Vypočítá a vypíše ekvivalent ve stupních Fahrenheita (vzorec: F = C × 9/5 + 32)
// - Načte teplotu ve Fahrenheitech a vypočítá ekvivalent v Celsiích (vzorec: C = (F − 32) × 5/9)
// - Demonstrujte práci s datovými typy (double) a aritmetickými výrazy

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chcete prevest z Celsia -> Farenheit (1) nebo Ferenheit -> Celsia (2)");
        int option;
        while (true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out option);
            if (parsed)
            {break;}
        }
        Console.WriteLine("Kolik stupnu?");
        double stupne;
        while (true)
        {
            bool parsed = double.TryParse(Console.ReadLine(), out stupne);
            if (parsed)
            {break;}
        }
        double output = 0;
        if (option == 1)
        {
            output = stupne * 9 / 5 +32;
        }
        else if (option == 2)
        {
            output = (stupne - 32) * 5 / 9;
        }
        Console.WriteLine("Prevod je: " + stupne + " -> " + output );
    }   
}
