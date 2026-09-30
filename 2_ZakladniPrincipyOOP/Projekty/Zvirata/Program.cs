namespace Zvirata;

//Definujte pojmy třída, objekt, abstrakce, zapouzdření, datový člen, metoda, konstruktor, dědičnost, polymorfismus. Popište způsob komunikace mezi objekty, uveďte příklad. Srovnejte objektově orientované a procedurální programování.

// Navrhněte v C# hierarchii tříd:
// Základní třída Zvire s virtuální metodou Mluv(), která vrací string (např. „…“)
// Třída Pes dědící z Zvire – přepíše Mluv() tak, aby vracela „Haf!“
// Třída Kocka dědící z Zvire – přepíše Mluv() tak, aby vracela „Mňau!“
// V Main vytvořte pole typu Zvire[] s instancemi Psa a Kočky a pro každý prvek volejte Mluv() – demonstrujte polymorfismus (stejné volání, různá implementace)
class Program
{
    static void Main(string[] args)
    {
        List<Zvire> list = new List<Zvire>();
        while(true)
        {
            string s = GetOption();
            if(s is "k")
            {break;}
            else if(s is "m")
            {
            list.Add(new Kocka());
            }
            else if(s is "p")
            {
            list.Add(new Pes());
            }
        }
        foreach(Zvire zvire in list)
        {
            zvire.Mluv();
        }
    }
    static string GetOption()
    {
        Console.WriteLine("Zadejete moznost Kocka (m) Pes (p) Konec (k)");
        while(true)
        {
            string s = Console.ReadLine();
            if (s == "k" || s == "p" || s == "m")
            {
                return s;
            }
            else
            {
                Console.WriteLine("Spatne zadani.");
            }
            
        }
    }
}

public class Zvire
{
    public Zvire()
    {}
    public virtual void Mluv()
    {
        Console.WriteLine("...");
    }
}

public class Pes : Zvire
{
    public Pes()
    {}
    public override void Mluv()
    {
        Console.WriteLine("Haf!");
    }
}


public class Kocka : Zvire
{
    public Kocka()
    {}
    public override void Mluv()
    {
        Console.WriteLine("Mnau!");
    }
}
