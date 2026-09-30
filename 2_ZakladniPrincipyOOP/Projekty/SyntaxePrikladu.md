# Syntaxe k příkladům (téma 2 – OOP)

Přehled C# syntaxe k zadáním v [../Priklady.md](../Priklady.md). Zaměřeno na třídy, zapouzdření, dědičnost a polymorfismus.

---

## Třída, pole, konstruktor (příklad 1 – účet)

```csharp
public class Ucet
{
    private double zustatek;   // viditelné jen uvnitř třídy

    public Ucet(double pocatek)  // konstruktor – stejné jméno jako třída, bez návratového typu
    {
        zustatek = pocatek;
    }

    public void Vlozit(double castka)
    {
        zustatek += castka;
    }

    public bool Vybrat(double castka)
    {
        if (castka > zustatek) return false;
        zustatek -= castka;
        return true;
    }

    public void ZobrazZustatek()
    {
        Console.WriteLine($"Zůstatek: {zustatek}");
    }
}
```

- **`private`** – zvenku nelze psát `ucet.zustatek = 1000`.
- **`public`** – metody, které mají být API třídy.
- **`new Ucet(100)`** – vytvoření objektu, zavolá se konstruktor.

---

## Vlastnosti (property) místo pole

Často se místo `public string jmeno` použije zapouzdřená vlastnost:

```csharp
private string jmeno = "";

public string Jmeno
{
    get { return jmeno; }
    set { jmeno = value; }   // value je klíčové slovo v setteru
}

// zkráceně (auto-property s private backing field – nebo jen { get; set; } pokud nepotřebuješ logiku)
public string Jmeno { get; private set; }
```

---

## Dědičnost, virtual, override (příklad 2 – zvířata)

```csharp
public class Zvire
{
    public virtual string Mluv()   // lze přepsat v potomkovi
    {
        return "...";
    }
}

public class Pes : Zvire          // dědí z Zvire
{
    public override string Mluv()
    {
        return "Haf!";
    }
}
```

- **`:`** – „dědí z“.
- **`virtual`** v základní třídě, **`override`** v odvozené.
- **`base.Mluv()`** – zavolání verze z rodiče zevnitř přepsané metody.

---

## Pole a polymorfismus

```csharp
Zvire[] zvirata = { new Pes(), new Kocka(), new Pes() };

foreach (Zvire z in zvirata)
    Console.WriteLine(z.Mluv());   // podle skutečného typu Pes/Kocka
```

---

## Abstraktní třída (příklad 3 – tvary)

```csharp
public abstract class Tvar
{
    public abstract double Obsah();   // bez těla – musí implementovat potomek
}

public class Obdelnik : Tvar
{
    public double A { get; set; }
    public double B { get; set; }

    public override double Obsah() => A * B;
}

public class Kruh : Tvar
{
    public double R { get; set; }

    public override double Obsah() => Math.PI * R * R;
}
```

- **`abstract class`** – nelze `new Tvar()`, jen potomci.
- **`abstract`** metoda – povinný `override` v neabstraktním potomkovi.

---

## List a vlastní třídy (příklad 4 – e-shop)

```csharp
using System.Collections.Generic;

public class Produkt
{
    public string Nazev { get; set; } = "";
    public double Cena { get; set; }
}

public class Kosik
{
    private List<Produkt> polozky = new List<Produkt>();

    public void Pridat(Produkt p) => polozky.Add(p);

    public double CelkovaCena()
    {
        double soucet = 0;
        foreach (var p in polozky)
            soucet += p.Cena;
        return soucet;
    }
}
```

Na začátku souboru (nebo v projektu s implicitními usings) často stačí `List<>` díky `global using`.

---

## Dědičnost + override + seznam základního typu (příklad 5)

```csharp
public class Zamestnanec
{
    public string Jmeno { get; set; } = "";
    public double Plat { get; set; }

    public virtual void VypisInfo()
    {
        Console.WriteLine($"{Jmeno}, plat: {Plat}");
    }
}

public class Manager : Zamestnanec
{
    public double Bonus { get; set; }

    public override void VypisInfo()
    {
        Console.WriteLine($"{Jmeno}, plat: {Plat}, bonus: {Bonus}");
    }
}

// v Main:
List<Zamestnanec> lide = new List<Zamestnanec>
{
    new Zamestnanec { Jmeno = "Ana", Plat = 30000 },
    new Manager { Jmeno = "Bob", Plat = 50000, Bonus = 10000 }
};

foreach (Zamestnanec z in lide)
    z.VypisInfo();
```

---

## Mapování: příklad → syntaxe

| Příklad | Klíčová slova / typy |
| ------- | -------------------- |
| 1 Účet | `class`, `private`, konstruktor, `public void` / `bool` |
| 2 Zvířata | `virtual`, `override`, `: Zvire`, `Zvire[]` |
| 3 Tvary | `abstract class`, `abstract double Obsah()`, `override`, `Math.PI` |
| 4 E-shop | `List<Produkt>`, `Add`, vlastnosti `get; set;` |
| 5 Zaměstnanci | `virtual` / `override`, `List<Zamestnanec>`, objekty odvozené třídy v seznamu |
