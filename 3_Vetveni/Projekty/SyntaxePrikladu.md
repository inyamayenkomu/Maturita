# Syntaxe k příkladům (téma 3 – větvení a operátory)

Přehled C# k zadáním v [../Priklady.md](../Priklady.md): `if`, `switch`, porovnání, logika, `switch` s menu.

---

## Porovnávací operátory

| Operátor | Význam |
| -------- | ------ |
| `==` `!=` | rovno, nerovno |
| `<` `>` `<=` `>=` | menší, větší, včetně rovnosti |

Výsledek je vždy `bool` (`true` / `false`).

---

## Logické operátory

| Operátor | Význam | Poznámka |
| -------- | ------ | -------- |
| `&&` | a zároveň | short-circuit – když první část je false, druhá se nevyhodnocuje |
| `||` | nebo | short-circuit – když první část je true, druhá se nevyhodnocuje |
| `!` | negace | `!jePlnoletý` |

---

## if / else if / else (maximum, BMI, přestupný rok)

```csharp
if (a >= b && a >= c)
    max = a;
else if (b >= a && b >= c)
    max = b;
else
    max = c;
```

**Řetězení intervalů (BMI):**

```csharp
if (bmi < 18.5)
    Console.WriteLine("Podváha");
else if (bmi < 25)
    Console.WriteLine("Normální");
else if (bmi < 30)
    Console.WriteLine("Nadváha");
else
    Console.WriteLine("Obezita");
```

---

## switch – známka (příklad 2)

```csharp
switch (znamka)
{
    case 1:
        Console.WriteLine("Výborně");
        break;
    case 2:
        Console.WriteLine("Chvalitebně");
        break;
    case 3:
        Console.WriteLine("Dobře");
        break;
    case 4:
        Console.WriteLine("Dostatečně");
        break;
    case 5:
        Console.WriteLine("Nedostatečně");
        break;
    default:
        Console.WriteLine("Neplatná známka");
        break;
}
```

- Každá větev většinou končí **`break;`** (jinak „propadne“ do další větvě).
- **`default`** – žádná `case` nevyhovuje.

Od C# 7 lze `switch` i na vzorech; pro maturitu stačí klasické `case` s `int`.

---

## switch – menu kalkulačka (příklad 3)

```csharp
int volba = int.Parse(Console.ReadLine()!);  // nebo TryParse bezpečněji
double x = ...;
double y = ...;

switch (volba)
{
    case 1:
        Console.WriteLine(x + y);
        break;
    case 2:
        Console.WriteLine(x - y);
        break;
    case 3:
        Console.WriteLine(x * y);
        break;
    case 4:
        if (y == 0)   // u int; u double raději kontrola |y| < epsilon nebo jen int dělení
            Console.WriteLine("Nelze dělit nulou");
        else
            Console.WriteLine(x / y);
        break;
    default:
        Console.WriteLine("Neplatná volba");
        break;
}
```

**Poznámka:** Dělení nulou u typu **`double`** v C# nevyhodí výjimku, vrátí `Infinity`. Pro úlohu „dělitel nesmí být nula“ použij **`if (y == 0)`** před dělením (u celých čísel), nebo u `double` stejnou kontrolu před `/`.

---

## Přestupný rok – modulo a logika

Pravidlo: rok je přestupný, když

- je dělitelný **400**, nebo
- je dělitelný **4** a zároveň **není** dělitelný **100**.

```csharp
bool prestupny = (rok % 400 == 0) || (rok % 4 == 0 && rok % 100 != 0);
```

- **`%`** – zbytek po dělení: `rok % 4 == 0` znamená „je dělitelný čtyřmi“.

---

## Načtení čísla z konzole

```csharp
if (int.TryParse(Console.ReadLine(), out int n))
{
    // použij n
}
```

Stejně `double.TryParse` pro BMI (`váha`, `výška` jako `double`; výška v **metrech**, např. `1.75`).

**BMI:** `double bmi = vaha / (vyska * vyska);`

---

## Mapování: příklad → syntaxe

| Příklad | Hlavní konstrukce |
| ------- | ----------------- |
| 1 Maximum ze tří | `if` / `else if`, `&&`, porovnání |
| 2 Známka | `switch` + `case` + `break` + `default` |
| 3 Menu kalkulačka | `switch`, u `case 4:` vnořené `if` pro nulu |
| 4 BMI | `double`, `if`–`else if` řetězec, mezní hodnoty 18.5, 25, 30 |
| 5 Přestupný rok | `%`, `&&`, `||`, `!=` |
