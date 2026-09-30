namespace Tvary;

// Navrhněte v C# hierarchii tříd pro geometrické tvary:
// - Abstraktní třída `Tvar` s abstraktní metodou `double Obsah()`
// - Třída `Obdelnik` dědící z `Tvar` – má strany a, b, implementuje `Obsah()` jako a × b
// - Třída `Kruh` dědící z `Tvar` – má poloměr r, implementuje `Obsah()` jako π × r²
// - Vytvořte pole `Tvar[]` s instancemi obdélníku a kruhu a vypište obsah každého – demonstrujte polymorfismus a abstrakci
class Program
{
    static void Main(string[] args)
    {
        Tvar[] tvary = new Tvar[4];
        Obdelnik obdelnik1 = new Obdelnik(1,1);
        Obdelnik obdelnik2 = new Obdelnik(2,2);
        Kruh kruh1 = new Kruh(1);
        Kruh kruh2 = new Kruh(2);
        tvary[0] = obdelnik1;
        tvary[1] = obdelnik2;
        tvary[2] = kruh1;
        tvary[3] = kruh2;
        foreach(Tvar tvar in tvary)
        {
            Console.WriteLine(tvar.Obsah());
        }
    }
}

abstract class Tvar
{
    public abstract double Obsah();
}

class Obdelnik : Tvar
{
    public double a;
    public double b;
    public Obdelnik(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override double Obsah()
    {
        return a*b;
    }
}

class Kruh : Tvar
{
    public double r;
    public Kruh(double r)
    {
        this.r = r;
    }

    public override double Obsah()
    {
        return Math.Pow(r,2)*Math.PI;
    }
}
