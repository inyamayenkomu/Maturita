namespace Maximum3;

// Napište konzolovou aplikaci v C#, která:
// - Načte od uživatele tři celá čísla
// - Pomocí podmíněných příkazů (if/else) zjistí, které z nich je největší
// - Vypíše toto maximum
// - Použijte porovnávací operátory (<, >, ==) a logické operátory (&&, ||) tam, kde dává smysl
class Program
{
    static void Main(string[] args)
    {
        double a = getNumber();
        double b = getNumber();
        double c = getNumber();
        

        //osobne bych to psal pres loop ale zadni me limituje 
        if(a > b && a >c)
        {
            Console.WriteLine("a " + a);
        }
        else if(b > a && b > c)
        {
        Console.WriteLine("b " + b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("c " + c);
        }
        else
        {
            if (a == b && a > c)
            {
                Console.WriteLine("a je stejne jak b " + a +" a jsou vetsi nez c");
            }
            else if (a == c && a > b)
            {
                Console.WriteLine("a je stejne jak c " + a + " a jsou vetsi nez b");
            }
            else if(b == c && b > c)
            {
                Console.WriteLine("b je stejne jak c " + b + " a jsou vetsi nez a");
            }
            else
            {
                Console.WriteLine("cisla jsou stejny " + a);
            }
        }
    
    }

    static double getNumber()
    {
        double number;
        Console.WriteLine("Zadejte cislo: ");
        while(true)
        {
            bool parsed = double.TryParse(Console.ReadLine(), out number);
            if(parsed)
            {
                return number;
            }
            Console.WriteLine("neplatny charakter");
        }
    }
}
