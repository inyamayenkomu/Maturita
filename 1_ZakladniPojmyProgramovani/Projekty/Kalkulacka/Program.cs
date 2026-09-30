namespace Kalkulacka;


//Napište konzolovou aplikaci v C#, která:
//- Načte od uživatele dvě čísla
//- Načte zvolenou operaci (+, −, ×, ÷)
//- Vypočítá a vypíše výsledek
//- Použijte proměnné, vstup/výstup (Console.ReadLine, Console.WriteLine) a základní operátory
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ahoj, zde je kalkulacka.");
        double a = InputNumber("prvni cislo");
        double b = InputNumber("druhe cislo");
        Console.WriteLine("Zadej operaci (*,+,-,/)");
        string operation;
        while (true)
        {
            operation = Console.ReadLine();
            if(operation == "+") 
            {
                double c = a+b;
                Console.WriteLine(c);
                break;
            }
            else if(operation == "-") 
            {
                double c = a-b;
                Console.WriteLine(c);
                break;
            }
            else if(operation == "/") 
            {
                double c = a/b;
                Console.WriteLine(c);
                break;
            }
            else if(operation == "*") 
            {
                double c = a*b;
                Console.WriteLine(c);
                break;
            }
        }


    }

    static double InputNumber(string name)
    {
        double output;
        while(true)
        {
            Console.WriteLine("Zadej " + name + ": ");
            bool parsed = double.TryParse(Console.ReadLine(), out output);
            if (parsed)
            {return output;}
        }
    }
}
