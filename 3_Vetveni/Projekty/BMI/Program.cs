namespace BMI;

// Napište konzolovou aplikaci v C#, která:
// - Načte od uživatele váhu (kg) a výšku (m)
// - Vypočítá BMI = váha / výška²
// - Podle hodnoty BMI vypíše kategorii: podváha (< 18,5), normální (18,5–25), nadváha (25–30), obezita (> 30)
// - Použijte vnořené nebo složené podmínky (if-else if-else)
class Program
{
    static void Main(string[] args)
    {
        double vaha = getNumber("vahu");
        double vyska = getNumber("vysku");
        double BMI = vaha/(Math.Pow(vyska,2));
        if(BMI <= 18.5)
        {Console.WriteLine("Mate podvahu");}
        else if(BMI <= 25)
        {Console.WriteLine("Vase vaha je normalni");}
        else if(BMI <= 30)
        {Console.WriteLine("Mate nadvahu");}
        else
        {Console.WriteLine("Jste obezni");}
    }

    static double getNumber(string s)
    {
        double number;
        Console.WriteLine($"Zadejte {s}: ");
        while(true)
        {
            bool parsed = double.TryParse(Console.ReadLine(), out number);
            if(parsed && number > 0)
            {return number;}
        }
    }
}
