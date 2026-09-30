# Syntaxe k příkladům (téma 1 – základní pojmy)

Krátký přehled C# konstrukcí, které se hodí k zadáním v [../Priklady.md](../Priklady.md). Nejsou to hotová řešení, jen „co a jak psát“.

---

## Proměnné a typy

```csharp
double a;           // desetinná čísla (koeficienty, teploty, obvod)
int n;              // celé číslo (sudé/liché)
string text = Console.ReadLine() ?? "";  // řetězec ze vstupu (může být null)
```

- **`double`** – pro výpočty s desetinnou čárkou (kvadratická rovnice, převody teplot, obdélník).
- **`int`** – celá čísla; u modulo (`%`) typicky `int`.

---

## Vstup a výstup

```csharp
Console.WriteLine("Zadej číslo:");
string? radek = Console.ReadLine();

if (double.TryParse(radek, System.Globalization.NumberStyles.Any,
        System.Globalization.CultureInfo.InvariantCulture, out double x))
{
    // x je načtené číslo
}
```

- **`Console.WriteLine(...)`** – výpis na řádek (můžeš skládat řetězec: `"Výsledek: " + vysledek` nebo interpolaci `$"Výsledek: {vysledek}"`).
- **`Console.ReadLine()`** – přečte jeden řádek z konzole; vrací `string?` (může být `null`).
- **`double.TryParse`** – bezpečně převede text na `double`; vrací `true`/`false`. Pro vstup s tečkou jako desetinným oddělovačem použij `InvariantCulture` (viz výše), nebo `CultureInfo.CurrentCulture` podle toho, co zadáváš ty.

Jednodušší varianta (méně bezpečná): `double x = double.Parse(Console.ReadLine()!);` – spadne při špatném vstupu.

---

## Aritmetické operátory

| Operátor | Význam | Příklad |
| -------- | ------ | ------- |
| `+` `-` `*` `/` | sčítání, odčítání, násobení, dělení | `a * b`, `2 * (a + b)` |
| `%` | zbytek po dělení (celočíselně) | `n % 2 == 0` → sudé |
| `*` mocnina | druhá mocnina | `b * b` nebo `Math.Pow(b, 2)` |

**Diskriminant:** `double D = b * b - 4 * a * c;` (pozor na `a`, `b`, `c` jako `double`).

**Kořeny** (když `D >= 0` a `a != 0`):

```csharp
double x1 = (-b + Math.Sqrt(D)) / (2 * a);
double x2 = (-b - Math.Sqrt(D)) / (2 * a);
```

`Math.Sqrt(D)` – druhá odmocnina. Pro `D < 0` reálné kořeny v R nejsou (na maturitě stačí o tom informovat).

---

## Podmínky (větvení u kvadratické rovnice)

```csharp
if (D > 0) { /* dva kořeny */ }
else if (D == 0) { /* jeden dvojnásobný */ }
else { /* žádný reálný */ }
```

U `double` může být kvůli zaokrouhlení lepší `Math.Abs(D) < 1e-9` místo `D == 0` – na začátek stačí `D == 0`.

---

## Převod teplot (příklad 3)

```csharp
double f = c * 9.0 / 5.0 + 32;   // aspoň jedno 9.0 nebo 5.0 → celé dělení nebude „useknout“
double c2 = (f - 32) * 5.0 / 9.0;
```

Když napíšeš `9 / 5` s dvěma `int`, dostaneš `1`, ne `1.8`.

---

## Sudé / liché (příklad 5)

```csharp
if (n % 2 == 0)
    Console.WriteLine("Sudé");
else
    Console.WriteLine("Liché");
```

`%` u záporných čísel v C# má znaménko dělitele – pro maturitní úlohy obvykle stačí kladná `n`.

---

## Struktura programu

```csharp
class Program
{
    static void Main(string[] args)
    {
        // tvůj kód
    }
}
```

`Main` je vstupní bod konzolové aplikace.

---

## Mapování: příklad → hlavní syntaxe

| Příklad v Priklady.md | Co použít |
| --------------------- | --------- |
| 1 Kvadratická rovnice | `double`, `TryParse`, `b*b-4*a*c`, `if` podle `D`, `Math.Sqrt` |
| 2 Kalkulačka | `ReadLine`, převod čísel, `+ - * /`, případně `char` nebo `string` pro operaci |
| 3 Teploty | `double`, `9.0/5.0`, závorky u `(F-32)*5/9` |
| 4 Obdélník | `double`, obvod `2*(a+b)`, obsah `a*b` |
| 5 Sudé/liché | `int`, `%`, `if` |
