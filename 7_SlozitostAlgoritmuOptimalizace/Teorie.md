# 7. Složitost algoritmu a optimalizace

> Co je to složitost algoritmu a k čemu se používá? Vyjmenujte nejčastější třídy složitostí. Co je to optimalizace? Jaký má výběr programovacího jazyka vliv na rychlost programu?

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Big O notace** | Zápis, jak roste čas/paměť s velikostí vstupu | O(n) = „čas roste lineárně s počtem prvků“ |
| **Asymptotická složitost** | Chování pro velké n – ignoruje konstanty a menší členy | 5n² + 3n → O(n²) |
| **Optimalizace** | Úprava kódu nebo algoritmu ke zlepšení výkonu | Nahradit vnořené cykly lepším algoritmem |
| **Předčasná optimalizace** | Optimalizace před měřením – často zbytečná, zhorší čitelnost | „Je to pomalé“ – ale nikdo to neměřil |
| **Kompilovaný jazyk** | Překlad do strojového kódu před spuštěním | C#, C++, Rust |
| **Interpretovaný jazyk** | Překlad za běhu při každém spuštění | Python, JavaScript |
| **Garbage collection (GC)** | Automatické uvolňování paměti – runtime sám maže objekty, které už nikdo nepoužívá | C#, Java, Python – nemusíš ručně volat „delete“ |

---

## Složitost algoritmu

> ⏱️ **Přirovnání**: Složitost je jako **odhad, jak dlouho ti zabere úkol** – hledání v seznamu 10 položek vs. 1 000 000 položek. Nezáleží na přesném počítači, ale na tom, jak roste čas s velikostí.

- **Definice**: Teoretická míra spotřeby **času** (časová složitost) nebo **paměti** (prostorová složitost) v závislosti na velikosti vstupních dat (n).

- **K čemu se používá**: Analýza efektivity algoritmů, předpověď chování pro velké datové sady, porovnání algoritmů.

```
┌─────────────────────────────────────────────────────────┐
│  SLOŽITOST = odpověď na „Jak roste čas s n?“            │
│                                                         │
│   n = 10      n = 1000      n = 1 000 000               │
│   O(n)        lineárně      → předvídatelné              │
│   O(n²)       kvadraticky   → může být problém           │
│   O(2ⁿ)       exponenciálně → katastrofa pro velké n     │
└─────────────────────────────────────────────────────────┘
```

---

## Nejčastější třídy složitostí (Big O)

> Od nejrychlejší k nejpomalejší. Big O popisuje **horší případ** – jak roste v nejhorším scénáři.

| Třída | Název | Popis | Příklad |
| ----- | ----- | ----- | ------- |
| **O(1)** | Konstantní | Čas nezávisí na n | Přístup k prvku v poli podle indexu |
| **O(log n)** | Logaritmická | Roste velmi pomalu | Binární vyhledávání v seřazeném poli |
| **O(n)** | Lineární | Čas roste přímo úměrně n | Procházení pole, jednoduché vyhledávání |
| **O(n log n)** | Lineárně-logaritmická | Dobrá pro řazení | Merge sort, quicksort |
| **O(n²)** | Kvadratická | Čas roste s druhou mocninou n | Dva vnořené cykly přes pole |
| **O(n³)** | Kubická | Čas roste s třetí mocninou | Tři vnořené cykly |
| **O(2ⁿ)** | Exponenciální | Velmi rychlý růst | Naivní Fibonacci, některé brute-force |

```
┌─────────────────────────────────────────────────────────┐
│  ROSTOUCÍ ČAS (přibližně)                                │
│                                                         │
│   O(1)          ████  (konstantní)                      │
│   O(log n)      ██████  (výborné)                       │
│   O(n)          ████████████  (dobré)                   │
│   O(n log n)    ████████████████  (přijatelné)          │
│   O(n²)         ████████████████████████████  (pomalé)  │
│   O(2ⁿ)         ████████████████████████████████████████  (katastrofa)
└─────────────────────────────────────────────────────────┘
```

### Příklady v kódu

```csharp
// O(1) – konstantní
int x = pole[0];

// O(n) – lineární
for (int i = 0; i < pole.Length; i++)
    Console.WriteLine(pole[i]);

// O(n²) – kvadratická (dva vnořené cykly)
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        Console.WriteLine(pole[i] + pole[j]);

// O(log n) – binární vyhledávání v seřazeném poli
int Levy = 0, Pravy = pole.Length - 1;
while (Levy <= Pravy)
{
    int stred = (Levy + Pravy) / 2;
    if (pole[stred] == hledane) return stred;
    if (pole[stred] < hledane) Levy = stred + 1;
    else Pravy = stred - 1;
}
```

---

## Optimalizace

> 🔧 **Definice**: Úprava kódu nebo algoritmu ke zlepšení výkonu (rychlost, paměťová náročnost).

### Co optimalizovat

| Typ | Příklad |
| --- | ------- |
| **Algoritmus** | Nahradit O(n²) řazení bublinkou za O(n log n) quicksort |
| **Kód** | Vyhnout se zbytečným výpočtům v cyklu, cachovat výsledky |
| **Struktury** | Použít HashSet místo List pro rychlé vyhledávání |

### ⚠️ Předčasná optimalizace

> „Předčasná optimalizace je kořen všeho zla.“ (Donald Knuth)

- **Problém**: Optimalizujeteš před tím, než víš, kde je úzké místo. Často zbytečně zhoršíš čitelnost.
- **Správný postup**: Nejprve měř (profiler), pak optimalizuj tam, kde to opravdu pomůže.

---

## Vliv programovacího jazyka na rychlost

### Kompilované vs. interpretované

| Typ | Příklady | Rychlost |
| --- | -------- | -------- |
| **Kompilované** | C#, C++, Rust, Go | Obecně rychlejší – předpřeklad do strojového kódu |
| **Interpretované** | Python, JavaScript | Pomalejší – překlad za běhu |

### Úroveň jazyka

| Úroveň | Příklady | Vliv |
| ------ | -------- | ---- |
| **Nízkoúrovňové** | C, Rust | Lepší kontrola hardwaru, manuální optimalizace |
| **Vysokoúrovňové** | Python, Java | Abstrakce (správa paměti, garbage collection – automatické uvolňování nepotřebných objektů) mohou zpomalit |

### Důležité

> **Klíčový faktor**: Volba algoritmu s vhodnou složitostí má **větší dopad** než samotný jazyk. Špatný algoritmus O(n²) v C++ může být pomalejší než dobrý algoritmus O(n log n) v Pythonu.

```
┌─────────────────────────────────────────────────────────┐
│  CO OVLIVŇUJE RYCHLOST (od největšího dopadu)            │
│                                                         │
│   1. VÝBĚR ALGORITMU (O(n²) vs O(n log n))              │
│   2. Implementace (kvalita kódu)                        │
│   3. Programovací jazyk (C vs Python)                   │
│   4. Hardware                                            │
└─────────────────────────────────────────────────────────┘
```

- Dobře napsaný kód v „pomalém“ jazyce může být rychlejší než neoptimalizovaný kód v „rychlém“ jazyce.
- Rychlost závisí i na implementaci – JIT (C#, Java) může konkurovat kompilovaným jazykům.

---

## Shrnutí

- **Složitost algoritmu** – míra spotřeby času/paměti v závislosti na velikosti vstupu. Používá se k analýze a porovnání algoritmů.
- **Big O** – O(1), O(log n), O(n), O(n log n), O(n²), O(n³), O(2ⁿ). Od konstantní po exponenciální.
- **Optimalizace** – úprava kódu/algoritmu. Pozor na předčasnou optimalizaci – měř nejdřív.
- **Vliv jazyka** – kompilované rychlejší než interpretované, ale **volba algoritmu má větší dopad**.

---

## Materiály od učitele

Sekce vychází z `AlgoritmickaSlozitost.txt`.

- Algoritmická složitost popisuje růst časové nebo paměťové náročnosti podle velikosti vstupu.
- Základní škála: `O(1)`, `O(log n)`, `O(n)`, `O(n log n)`, `O(n^2)`.
- Praktické příklady:
  - `O(1)`: přístup k prvku pole podle indexu,
  - `O(log n)`: binární vyhledávání,
  - `O(n log n)`: efektivní řazení (quicksort/mergesort),
  - `O(n^2)`: jednoduché řazení (např. bubble sort).
- Doplněk ze zdroje: [Graf růstu složitostí](https://portal.matematickabiologie.cz/index.php?pg=zaklady-informatiky-pro-biology--algoritmizace-a-programovani--algoritmus--slozitost-algoritmu)

### Pro ty, co chtej vedet vic

- [AlgoritmickaSlozitost.txt](Materialy/AlgoritmickaSlozitost.txt)
