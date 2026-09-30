using System.Runtime.InteropServices.Swift;

namespace Zamestnanci;

// Navrhněte v C# hierarchii pro evidenci zaměstnanců:
// - Třída `Zamestnanec` – zapouzdřené vlastnosti: jmeno, plat; konstruktor; metoda `VypisInfo()` pro výpis jména a platu
// - Třída `Manager` dědící z `Zamestnanec` – přidává vlastnost `bonus`; přepíše `VypisInfo()` tak, aby zobrazila i bonus
// - V Main vytvořte zaměstnance a manažera, uložte je do seznamu typu `Zamestnanec` a pro každého volejte `VypisInfo()` – polymorfismus
// - Demonstrujte zapouzdření (plat není veřejný) a dědičnost
class Program
{
    static void Main(string[] args)
    {
        List<Zamestnanec> zamestnanci = new List<Zamestnanec>();
        Zamestnanec zamestnanecDenis = new Zamestnanec("Denis", 20);
        Manager managerBen = new Manager("Ben", 100000000, 50000000);
        zamestnanci.Add(zamestnanecDenis);
        zamestnanci.Add(managerBen);
        foreach(Zamestnanec zamestnanec in zamestnanci)
        {
            zamestnanec.VypisInfo();
        }

    }
}

class Zamestnanec
{
    private string jmeno;
    private double plat;
    public Zamestnanec(string jmeno, double plat)
    {
        this.jmeno = jmeno;
        this.plat = plat;
    }

    public virtual void VypisInfo()
    {
        Console.WriteLine(this.jmeno + " ma plat: " + this.plat);
    }
}

class Manager : Zamestnanec
{
    private double bonus;
    public Manager(string jmeno, double plat, double bonus) : base (jmeno, plat)
    {
        this.bonus = bonus;
    }

    public override void VypisInfo()
    {
        base.VypisInfo();
        Console.WriteLine("Bonus: " + this.bonus);
    }
}
