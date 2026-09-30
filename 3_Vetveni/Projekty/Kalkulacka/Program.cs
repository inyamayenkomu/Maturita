namespace Kalkulacka;

// Napište konzolovou aplikaci v C#, která:
// - Zobrazí menu: 1 = sčítání, 2 = odčítání, 3 = násobení, 4 = dělení
// - Načte volbu uživatele
// - Načte dvě čísla
// - Pomocí switch vybere příslušnou operaci a vypíše výsledek
// - U dělení ověřte, že dělitel není nula – jinak vypište chybovou zprávu
class Program
{
    static void Main(string[] args)
    {
        double option;
        Console.WriteLine("Zadejte moznost: 1 = sčítání, 2 = odčítání, 3 = násobení, 4 = dělení");
        while(true)
        {
            option = getNumber();
            if(option is 1 or 2 or 3 or 4)
            {
                break;
            }
        }
        Console.WriteLine("Zadejte cislo a: ");
        double a = getNumber();
        Console.WriteLine("Zadejte cislo b: ");
        double b = getNumber();
        switch(option)
        {
            case 1:
                Console.WriteLine("Vysledek je " + (a+b));
                break;
            case 2:
                Console.WriteLine("Vysledek je " + (a-b));
                break;
            case 3:
                Console.WriteLine("Vysledek je " + (a*b));
                break;
            case 4:
                try
                {
                Console.WriteLine("Vysledek je " + (a/b));
                }
                catch(DivideByZeroException e) // tohle je sracka protoze z nejakyho duvodu to vraci ∞ protoze double delenej nulou nema error lmao
                {
                    Console.WriteLine(e);
                }
                break;
        }

        
    }

    static double getNumber()
    {
        double number;
        while(true)
        {
            bool parsed = double.TryParse(Console.ReadLine(), out number);
            if(parsed)
            {
                return number;
            }
        }
    }
}
