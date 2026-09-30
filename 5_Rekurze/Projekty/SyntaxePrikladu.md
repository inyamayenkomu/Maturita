# Syntaxe k příkladům (téma 5 – rekurze)

Přehled C# k zadáním v [../Priklady.md](../Priklady.md): rekurzivní metody, základní případ, zásobník volání.

Základní metody a typy: viz téma 1 – [../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md](../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md).

---

## Struktura rekurzivní metody

```csharp
static long Faktorial(int n)
{
    if (n <= 1)           // základní případ
        return 1;
    return n * Faktorial(n - 1);  // rekurzivní krok
}
```

- Každé volání musí **směřovat k základnímu případu**, jinak **nekonečná rekurze** → přetečení zásobníku (`StackOverflowException`).

---

## Faktoriál (příklad 1)

```csharp
static long Faktorial(int n)
{
    if (n == 0) return 1;
    return n * Faktorial(n - 1);
}
```

---

## Fibonacci (příklad 2)

```csharp
static long Fib(int n)
{
    if (n <= 1) return n;
    return Fib(n - 1) + Fib(n - 2);
}
```

- Pro velké `n` roste exponenciálně počet volání; na maturitě stačí malé `n` nebo zmínit iterativní variantu v teorii.

---

## Mocnina (příklad 3)

```csharp
static double Mocnina(double a, int n)
{
    if (n == 0) return 1;
    return a * Mocnina(a, n - 1);
}
```

---

## NSD – Euklides (příklad 4)

```csharp
static int NSD(int a, int b)
{
    if (b == 0) return a;
    return NSD(b, a % b);
}
```

---

## Palindrom řetězce (příklad 5)

```csharp
static bool JePalindrom(string s, int levy, int pravy)
{
    if (levy >= pravy) return true;
    if (s[levy] != s[pravy]) return false;
    return JePalindrom(s, levy + 1, pravy - 1);
}
// Volání: JePalindrom(text, 0, text.Length - 1)
```

---

## Rekurze a zásobník

Každé volání metody ukládá **rámeček** na **zásobník volání**. Příliš hluboká rekurze → **přetečení zásobníku**. Proto u Fibonacciho znovu zdůraznit malé `n` nebo tail rekurze / iterace jen v teorii.

---

## Mapování: příklad → koncept

| Příklad | Základní případ | Rekurzivní krok |
| ------- | ---------------- | ---------------- |
| 1 Faktoriál | `n ≤ 1` → 1 | `n * (n-1)!` |
| 2 Fibonacci | `n ≤ 1` | součet dvou menších |
| 3 Mocnina | `n = 0` → 1 | `a * a^(n-1)` |
| 4 NSD | `b = 0` → `a` | `NSD(b, a % b)` |
| 5 Palindrom | `levy ≥ pravy` | porovnání krajů + zúžení |
