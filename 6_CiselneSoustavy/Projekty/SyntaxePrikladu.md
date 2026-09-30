# Syntaxe k příkladům (téma 6 – číselné soustavy)

Přehled C# k zadáním v [../Priklady.md](../Priklady.md): převody mezi soustavami, `Convert`, řetězcová validace.

Základní typy a vstup: viz téma 1 – [../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md](../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md).

---

## Convert – převod s uvedením báze

```csharp
int desetinne = 42;
string binarni = Convert.ToString(desetinne, 2);   // "101010"

string zRadek = "101010";
int zpet = Convert.ToInt32(zRadek, 2);             // 42

string hex = desetinne.ToString("X");              // "2A"
int zHex = Convert.ToInt32("2A", 16);              // 42
```

- **`Convert.ToInt32(řetězec, báze)`** – báze 2, 8, 10 nebo 16 (podle dokumentace použité verze .NET).
- Pro **vlastní algoritmus** binárního zápisu: opakované dělení 2 a sbírání zbytků (nebo bitové operace).

---

## Ověření binárního řetězce

```csharp
bool JenNulyJednicky(string s)
{
    foreach (char c in s)
        if (c != '0' && c != '1') return false;
    return s.Length > 0;
}
```

Nebo `s.All(c => c == '0' || c == '1')` s `using System.Linq;`.

---

## Hexadecimální zápis v kódu

```csharp
int x = 0x2A;   // 42 v desítkové
```

---

## Byte a 8 bitů

```csharp
byte b = 200;
string bin8 = Convert.ToString(b, 2).PadLeft(8, '0');
```

- **`byte`** v C#: vždy 0–255 (unsigned 8 bitů).

---

## Vlastní převod desítkové → binární (dělení 2)

```csharp
static string DesetinneDoBin(int n)
{
    if (n == 0) return "0";
    string vysledek = "";
    while (n > 0)
    {
        vysledek = (n % 2) + vysledek;
        n /= 2;
    }
    return vysledek;
}
```

---

## Mapování: příklad → nástroje

| Příklad | Hlavní nástroje |
| ------- | ---------------- |
| 1 Dec → bin | `Convert.ToString(n, 2)` nebo cyklus `% 2` |
| 2 Bin → dec | `Convert.ToInt32(s, 2)` + validace znaků |
| 3 Dec → hex | `ToString("X")`, `Convert` |
| 4 Hex → dec | `Convert.ToInt32(s, 16)` + validace |
| 5 Byte 8 bitů | `byte`, `PadLeft(8, '0')`, rozsah 0–255 |
