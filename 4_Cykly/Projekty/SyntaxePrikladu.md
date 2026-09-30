# Syntaxe k příkladům (téma 4 – cykly)

Přehled C# k zadáním v [../Priklady.md](../Priklady.md): `for`, `while`, `do-while`, `foreach`, `break`, `continue`.

Základní vstup/výstup a typy: viz téma 1 – [../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md](../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md).

---

## Cyklus for (součet 1..n, faktoriál)

```csharp
int soucet = 0;
for (int i = 1; i <= n; i++)
    soucet += i;
```

```csharp
long faktorial = 1;
for (int i = 2; i <= n; i++)
    faktorial *= i;
```

- Proměnná **`i`** je často jen uvnitř cyklu (scope bloku `for`).

---

## Cyklus while – opakování do platného vstupu

```csharp
int cislo;
Console.WriteLine("Zadej celé číslo:");
while (!int.TryParse(Console.ReadLine(), out cislo))
{
    Console.WriteLine("Neplatný vstup, zkus to znovu.");
}
```

---

## foreach – průchod polem / seznamem

```csharp
int[] pole = { 3, 7, 2, 9 };
int soucet = 0;
foreach (int x in pole)
    soucet += x;
double prumer = (double)soucet / pole.Length;
```

```csharp
List<int> seznam = new List<int> { 1, 2, 3 };
foreach (int x in seznam)
    Console.WriteLine(x);
```

---

## do-while – menu alespoň jednou

```csharp
int volba;
do
{
    Console.WriteLine("1 = akce A, 0 = konec");
    int.TryParse(Console.ReadLine(), out volba);
    if (volba == 0) break;
    // ...
} while (true);  // nebo while (volba != 0);
```

---

## break a continue

- **`break`** – okamžitě ukončí nejbližší cyklus (`while`, `for`, `switch`).
- **`continue`** – přeskočí zbytek těla aktuální iterace a pokračuje další iterací stejného cyklu.

```csharp
while (true)
{
    string? r = Console.ReadLine();
    if (string.IsNullOrEmpty(r)) continue;  // nová iterace, znovu čti
    if (r == "konec") break;               // ven z cyklu
}
```

---

## Nekonečný cyklus a bezpečnost

`while (true)` nebo `for (;;)` je v pořádku, pokud uvnitř existuje **`break`** nebo **`return`**. Bez ukončovací podmínky vzniká **nekonečný cyklus** (často chyba – program „zamrzne“).

---

## Mapování: příklad → syntaxe

| Příklad | Hlavní konstrukce |
| ------- | ----------------- |
| 1 Součet 1..n | `for` s čítačem |
| 2 Faktoriál | `for` nebo `while`, násobení |
| 3 Platný vstup | `while (!TryParse(...))` |
| 4 Průměr pole | `foreach`, `pole.Length` |
| 5 Menu | `do-while` nebo `while (true)`, `break`, `continue` |
