namespace Ucet;


// Navrhněte a implementujte v C# třídu `Ucet` (bankovní účet), která:
// - Má zapouzdřený datový člen `zustatek` (private) – nikdo zvenčí ho nemůže přímo měnit
// - Nabízí metody `Vlozit(double castka)` a `Vybrat(double castka)` – ověřte, že nelze vybrat víc než je na účtu
// - Má veřejnou metodu `ZobrazZustatek()` pro výpis zůstatku
// - Má konstruktor pro nastavení počátečního zůstatku
// - Demonstrujte zapouzdření – zůstatek je chráněn před neplatnými operacemi
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Ucet
{
    private double zustatek;
    public Ucet()
    {
        this.zustatek = 0;
    }

    public void Vlozit(double castka)
    {
        this.zustatek += castka;
    }
    public void Vybrat(double castka)
    {
        if(this.zustatek-castka < 0)
        {
            Console.WriteLine("nedostatek penez na ucut");
            return;
        }
        else
        {
            this.zustatek -= castka;
        }
    }
    public void ZobrazZustatek()
    {
        Console.WriteLine(this.zustatek);
    }
}
