# 10. Ladění programu – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Rozbitý statistik

**Co má hotová aplikace umět:** Načíst `n` čísel, spočítat součet, průměr, minimum a maximum a říct, zda mezi nimi bylo sudé číslo. Má také bezpečně pracovat s počtem vstupů a výpisem poslední hodnoty.

**Úkol:** Opravte níže uvedený kód tak, aby odpovídal popisu výše, prošel kompilací a při běžných vstupech nespadl. Zaměřte se na navazující chyby (syntaxe, běh, logika), ne jen na jednu drobnost.

```csharp
using System;
using System.Collections.Generic

class Program
{
    static void Main()
    {
        Console.Write("Kolik cisel chces zadat? ")
        int n = int.Parse(Console.ReadLine());
        List<int> values = new List<int>();
        int sum = 0;
        int min = 0;
        int max = 0;
        bool hasEven = false

        if (n < 0)
            Console.WriteLine("N musi byt kladne")

        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Zadej cislo #{i + 1}: ");
            string raw = Console.ReadLine();
            int number = int.Parse(raw);
            values.Add(number);
            sum =+ number;

            if (i == 0)
            {
                min = 0;
                max = 0;
            }
            else if (number < min)
            {
                min = number;
            }
            else if (number > max)
            {
                max = i;
            }

            if (number % 2 == 0)
                hasEven = true;
        }

        double avg = sum / values.Count;
        Console.WriteLine("Soucet: " + sum);
        Console.WriteLine("Prumer: " + avg.ToString("F2"));
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Obsahuje suda cisla: " + hasEven)

        Console.WriteLine("Posledni cislo: " + values[values.Count]);
    }
}
```

- Najděte a popište alespoň deset problémů v původním řešení (stačí rozumně pojmenovat, nemusí jich být přesně deset, pokud už není co popisovat).
- U každého problému uveďte, zda jde o chybu při překladu, při běhu nebo o logickou chybu.
- Ošetřete i nesmyslné hodnoty `n` (např. záporné nebo nula), aby se program choval předvídatelně.

---

## Příklad 2: Dělení se vstupem uživatele

**Co má hotová aplikace umět:** Načíst dvě celá čísla a bezpečně ukázat výsledek celočíselného dělení a zbytek po dělení, případně vysvětlit, proč operaci nelze provést.

**Úkol:** Opravte kód tak, aby splnil popis a vždy na konci informoval o ukončení programu.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bezpecna kalkulacka");
        Console.Write("a = ");
        string rawA = Console.ReadLine();
        Console.Write("b = ");
        string rawB = Console.ReadLine()

        int a = int.Parse(rawA);
        int b = int.Parse(rawB);
        int operationCount = 0;

        try
        {
            int division = a / b;
            int modulo = a % b;
            Console.WriteLine($"a / b = {division}");
            Console.WriteLine($"a % b = {modulo}");
            operationCount = operationCount + 1
        }
        catch (FormatException)
        {
            Console.WriteLine("Spatny format cisla.");
        }
        catch (DivideByZeroException ex)
            Console.WriteLine("Deleni nulou: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nastala chyba: " + ex.Message);
        }

        if (operationCount = 0)
        {
            Console.WriteLine("Operace selhala");
        }

        Console.WriteLine("Konec programu")
    }
}
```

- Opravte syntaktické chyby a nesmyslné větvení kolem výjimek tak, aby odpovídalo záměru programu.
- Doplňte chování po skončení operace (např. informace, zda se podařila).
- Navíc připravte stručný návrh, jak totéž řešit bez výjimek při čtení vstupu (stačí jako komentář nebo krátký text v dokumentaci řešení).

---

## Příklad 3: Hledání maxima v poli

**Co má hotová aplikace umět:** Najít největší hodnotu v poli celých čísel, včetně případu záporných hodnot a prázdného pole.

**Úkol:** Opravte kód a vysvětlete slovně, proč původní verze dávala špatný výsledek.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] values = { -7, -2, -19, -4, -15 };
        int max = 0;

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < max)
            {
                max = values[i];
            }
        }

        Console.WriteLine("Maximum: " + max);
    }
}
```

---

## Příklad 4: Pád aplikace při práci s polem

**Co má hotová aplikace umět:** Vypsat všechny prvky pole, vypsat souhrn (součet a průměr) a nakonec poslední prvek; musí fungovat i pro prázdné pole.

**Úkol:** Najděte všechna místa, kde může program spadnout nebo datově „ujet“, a opravte je.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] data = { 10, 20, 30, 40 };
        PrintAll(data)
        PrintSummary(data);
        Console.WriteLine("Posledni prvek: " + data[data.Length]);
    }

    static void PrintAll(int[] arr)
    {
        for (int i = 0; i <= arr.Length; i++)
        {
            Console.WriteLine($"arr[{i}] = {arr[i]}");
        }
    }

    static void PrintSummary(int[] arr)
    {
        int sum = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        double avg = sum / arr.Length;
        Console.WriteLine("Soucet: " + sum);
        Console.WriteLine("Prumer: " + avg);

        if (arr.Length == 0)
            Console.WriteLine("Pole je prazdne");
        else
            Console.WriteLine("Prvni prvek: " + arr[1])
    }
}
```

---

## Příklad 5: Rozbitý import souboru

**Co má hotová aplikace umět:** Načíst textový soubor s čísly po řádcích, sečíst je, vypsat počet, součet a průměr a najít největší hodnotu.

**Úkol:** Opravte kód a doplňte chování pro běžné poruchy vstupu (chybějící soubor, nečíselný řádek, prázdný soubor).

```csharp
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string path = "data.txt";
        List<int> parsed = new List<int>();
        int total = 0;

        Console.WriteLine("Import dat ze souboru...");
        string[] lines = File.ReadAllLines(path)

        for (int i = 0; i <= lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (line == "")
            {
                Console.WriteLine($"Radek {i} je prazdny - preskakuju")
                continue
            }

            int value = int.Parse(line);
            parsed.Add(value);
            total = total + i;
        }

        double avg = total / parsed.Count;
        Console.WriteLine("Nacteno cisel: " + parsed.Count);
        Console.WriteLine("Soucet: " + total);
        Console.WriteLine("Prumer: " + avg);

        Console.WriteLine("Nejvetsi hodnota: " + parsed[parsed.Count]);
    }
}
```

- Přidejte krátký postup, jak byste problém hledali při ladění (kroky vhodné pro obhajobu u tabule).
