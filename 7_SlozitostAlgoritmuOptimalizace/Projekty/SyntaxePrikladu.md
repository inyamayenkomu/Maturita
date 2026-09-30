# Syntaxe k příkladům (téma 7 – složitost a optimalizace)

Přehled C# k zadáním v [../Priklady.md](../Priklady.md): součet v cyklu, lineární a binární vyhledávání, duplicity (dvojitý cyklus a `HashSet`).

Základní vstup/výstup a `TryParse`: viz téma 1 – [../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md](../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md).

Teorie (např. binární vyhledávání): [../Teorie.md](../Teorie.md).

---

## Součet prvků pole

```csharp
int soucet = 0;
for (int i = 0; i < pole.Length; i++)
    soucet += pole[i];
```

---

## Lineární vyhledávání

```csharp
int HledejLineárne(int[] pole, int hledane)
{
    for (int i = 0; i < pole.Length; i++)
        if (pole[i] == hledane)
            return i;
    return -1;  // nenalezeno
}
```

---

## Binární vyhledávání v seřazeném poli

```csharp
int HledejBinárne(int[] serazene, int hledane)
{
    int levy = 0;
    int pravy = serazene.Length - 1;

    while (levy <= pravy)
    {
        int stred = (levy + pravy) / 2;
        if (serazene[stred] == hledane)
            return stred;
        if (serazene[stred] < hledane)
            levy = stred + 1;
        else
            pravy = stred - 1;
    }
    return -1;
}
```

---

## Duplicity – naivně (dva cykly)

```csharp
bool MaDuplicituPomalu(int[] pole)
{
    for (int i = 0; i < pole.Length; i++)
        for (int j = i + 1; j < pole.Length; j++)
            if (pole[i] == pole[j])
                return true;
    return false;
}
```

---

## Duplicity – `HashSet`

```csharp
bool MaDuplicitu(int[] pole)
{
    var navstiveno = new HashSet<int>();
    foreach (int x in pole)
    {
        if (!navstiveno.Add(x))
            return true;
    }
    return false;
}
```

---

## Mapování: příklad → kód

| Příklad | Hlavní konstrukce |
| ------- | ----------------- |
| 1 Součet | jeden `for`, akumulátor |
| 2 Lineární hledání | jeden `for`, porovnání s `hledane` |
| 3 Binární hledání | `while (levy <= pravy)`, `stred` |
| 4 Duplicity naivně | vnořené `for`, `j = i + 1` |
| 5 Duplicity `HashSet` | `foreach`, `Add` / kontrola návratové hodnoty |
