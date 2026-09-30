using System.Runtime.InteropServices;

namespace Eshop;

// Navrhněte v C# jednoduchý model e-shopu:
// - Třída `Produkt` – vlastnosti: název, cena; konstruktor pro inicializaci
// - Třída `Kosik` – obsahuje seznam produktů (List<Produkt>), metody `Pridat(Produkt p)` a `CelkovaCena()` (součet cen všech produktů)
// - V Main vytvořte několik produktů, přidejte je do košíku a vypište celkovou cenu
// - Demonstrujte vytváření objektů, komunikaci mezi objekty (Kosik pracuje s Produkt)
class Program
{
    static void Main(string[] args)
    {
        Produkt pocitac1 = new Produkt("pocitac1", 20000);
        Produkt kartacek = new Produkt("kartacek", 50);
        Produkt granule = new Produkt("granule", 200);
        Kosik kosik = new Kosik();
        kosik.addProdukt(pocitac1);
        kosik.addProdukt(kartacek);
        kosik.addProdukt(granule);
        Console.WriteLine(kosik.celkovaCena());
    }
}

class Produkt
{
    private string nazev;
    private double cena;
    public Produkt(string nazev, double cena)
    {
        this.nazev = nazev;
        this.cena = cena;
    }

    public string getNazev()
    {
        return this.nazev;
    }

    public double getCena()
    {
        return this.cena;
    }
}

class Kosik
{
    public List<Produkt> produkty;
    public Kosik()
    {
        produkty = new List<Produkt>();
    }

    public void addProdukt(Produkt produkt)
    {
        this.produkty.Add(produkt);
    }

    public double celkovaCena()
    {
        double cena = 0;
        foreach(Produkt produkt in produkty)
        {
            cena += produkt.getCena();
        }
        return cena;
    }
}
