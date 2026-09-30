# 5. Rekurze

> Vysvětlete pojem a princip fungování rekurze. Aplikace rekurze. Jaké typy rekurze znáte? Výhody a nevýhody rekurze. Uveďte příklady využití a odstranění rekurze. Jaký je vztah rekurze a zásobníku?

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Základní případ (base case)** | Podmínka, která ukončí rekurzi – už nevoláme sama sebe | „Mám 0 koláčů – končím rozdávání“ |
| **Rekurzivní krok** | Volání funkce sama sebe s menším/jednodušším vstupem | „5! = 5 × 4! – spočítej menší faktoriál a vynásob“ |
| **Zásobník volání (call stack)** | Paměť, kam se ukládají nedokončená volání | Hromada talířů – poslední položený = první vybraný |
| **Stack overflow** | Přetečení zásobníku – příliš hluboká rekurze | Příliš vysoká hromada talířů – spadne |
| **Tail rekurze** | Rekurzivní volání je poslední operace před return | Odcházíš a už se nevracíš – nic dalšího neděláš |
| **Iterativní přístup** | Řešení pomocí cyklů místo rekurze | Místo „volám sám sebe“ použiješ for/while |

---

## Pojem a princip rekurze

> 🪆 **Přirovnání**: Rekurze je jako **matrjoška** – otevřeš jednu, uvnitř je menší, otevřeš ji, uvnitř je ještě menší… až narazíš na nejmenší (základní případ) a začneš „skládat“ výsledek zpět.

- **Definice**: Rekurze je technika, kdy **funkce volá sama sebe** k řešení menší nebo jednodušší instance téhož problému. Každé volání zmenšuje problém, až dosáhne **základního případu**, který už řeší přímo.

```
┌─────────────────────────────────────────────────────────┐
│                    REKURZE                               │
│                                                         │
│   F(5) ──▶ F(4) ──▶ F(3) ──▶ F(2) ──▶ F(1) ──▶ F(0)     │
│    │        │        │        │        │        │        │
│    │        │        │        │        │        └─ základní případ
│    │        │        │        │        │                 │
│    │        │        │        │        ◀─────────────────┘
│    │        │        │        ◀──────────────────────────┘
│    │        │        ◀────────────────────────────────────┘
│    │        ◀─────────────────────────────────────────────┘
│    ◀──────────────────────────────────────────────────────┘
│                                                         │
│   Sestup (volání) → Základní případ → Výstup (návraty)   │
└─────────────────────────────────────────────────────────┘
```

### Dva kroky rekurze

1. **Základní případ** – podmínka, při které rekurze končí. Bez ní by funkce volala sama sebe donekonečna.
2. **Rekurzivní krok** – zmenšení problému a volání sebe sama s menším vstupem.

```csharp
int Faktorial(int n)
{
    // 1. Základní případ – konec rekurze
    if (n <= 1)
        return 1;

    // 2. Rekurzivní krok – menší problém + volání sebe
    return n * Faktorial(n - 1);
}
```

---

## Typy rekurze

### Přímá rekurze

> Funkce volá **přímo sama sebe**.

```csharp
int Faktorial(int n)
{
    if (n <= 1) return 1;
    return n * Faktorial(n - 1);  // volá sama sebe
}
```

### Nepřímá rekurze

> Funkce A volá funkci B, funkce B volá zpět funkci A.

```csharp
void A(int n)
{
    if (n <= 0) return;
    Console.WriteLine("A");
    B(n - 1);  // A volá B
}

void B(int n)
{
    if (n <= 0) return;
    Console.WriteLine("B");
    A(n - 1);  // B volá zpět A
}
```

### Tail rekurze (koncová rekurze)

> Rekurzivní volání je **poslední operace** před return – funkce po návratu už nic nedělá.

```csharp
// Tail rekurze – volání je poslední operace
int FaktorialTail(int n, int akumulator = 1)
{
    if (n <= 1) return akumulator;
    return FaktorialTail(n - 1, n * akumulator);  // nic po return
}

// NENÍ tail rekurze – po návratu ještě násobíme
int Faktorial(int n)
{
    if (n <= 1) return 1;
    return n * Faktorial(n - 1);  // po návratu: n * (výsledek)
}
```

| Typ | Popis |
| --- | ----- |
| **Přímá** | Funkce volá sama sebe |
| **Nepřímá** | A → B → A → B … |
| **Tail** | Volání je poslední operace – kompilátor může optimalizovat na cyklus |

---

## Aplikace rekurze

### Faktoriál

```csharp
int Faktorial(int n)
{
    if (n <= 1) return 1;
    return n * Faktorial(n - 1);
}
// Faktorial(5) = 5 * Faktorial(4) = 5 * 4 * 3 * 2 * 1 = 120
```

### Fibonacciho posloupnost

```csharp
int Fib(int n)
{
    if (n <= 1) return n;
    return Fib(n - 1) + Fib(n - 2);
}
// Fib(0)=0, Fib(1)=1, Fib(2)=1, Fib(3)=2, Fib(4)=3, ...
```

### Procházení stromových struktur

```csharp
void ProjdiStrom(Uzel uzel)
{
    if (uzel == null) return;
    Console.WriteLine(uzel.Hodnota);
    ProjdiStrom(uzel.Levy);   // rekurze do levého podstromu
    ProjdiStrom(uzel.Pravy);  // rekurze do pravého podstromu
}
```

### Hanoi věže

> **Problém**: Máš 3 tyče (A, B, C) a na první tyči n kotoučů různé velikosti (největší dole, nejmenší nahoře). Cíl: přenést **všechny kotouče na třetí tyč**. Pravidla: vždy jen **jeden kotouč najednou**, můžeš dávat **jen menší na větší** (nikdy větší na menší).
>
> **Rekurzivní postup**: (1) Přesuň n−1 kotoučů na pomocnou tyč. (2) Přesuň největší kotouč na cíl. (3) Přesuň n−1 kotoučů z pomocné na cíl.
>
> ⚠️ **Poznámka**: Hanoi věže jsou celkem pokročilé – na maturitu to nemusíš umět, stačí vědět, že existuje. Důležitější jsou faktoriál a Fibonacci.

```csharp
void Hanoi(int n, char od, char pom, char kam)
{
    if (n == 1)
        Console.WriteLine($"Přesuň z {od} na {kam}");
    else
    {
        Hanoi(n - 1, od, kam, pom);   // přesuň n-1 na pomocný
        Console.WriteLine($"Přesuň z {od} na {kam}");
        Hanoi(n - 1, pom, od, kam);   // přesuň n-1 z pomocného na cíl
    }
}
```

---

## Výhody a nevýhody rekurze

### Výhody

| Výhoda | Popis |
| ------ | ----- |
| **Elegance** | Přirozeně rekurzivní problémy (stromy, Hanoi) se píší jednoduše |
| **Čitelnost** | Kód často lépe odpovídá matematické definici |
| **Zjednodušení** | U vnořených struktur (stromy, seznamy) méně kódu než iterativně |

### Nevýhody

| Nevýhoda | Popis |
| -------- | ----- |
| **Stack overflow** | Příliš hluboká rekurze přeteče zásobník (např. Faktorial(100000)) |
| **Paměť** | Každé volání zabírá místo na zásobníku |
| **Výkon** | Každé volání musí uložit stav na zásobník a po návratu ho načíst – to trvá čas. U Fibonacci se navíc stejné hodnoty počítají mnohokrát (Fib(3) se volá několikrát). |

```
┌─────────────────────────────────────────────────────────┐
│  REKURZE vs ITERACE                                     │
│                                                         │
│   Rekurze:                    Iterace:                  │
│   ✓ Elegantní                 ✓ Méně paměti             │
│   ✓ Přirozená pro stromy      ✓ Žádné stack overflow    │
│   ✗ Riziko stack overflow     ✓ Často rychlejší         │
│   ✗ Větší paměťová náročnost  ✗ Složitější u stromů     │
└─────────────────────────────────────────────────────────┘
```

---

## Vztah rekurze a zásobníku

> 📚 **Přirovnání**: Zásobník volání je jako **hromada talířů** – každé rekurzivní volání položí talíř navrch, po návratu talíř sebereme.

- Při každém volání funkce se na **zásobník (call stack)** uloží:
  - adresa návratu (kam pokračovat po skončení),
  - lokální proměnné daného volání,
  - parametry funkce.
- Rekurze = **více neukončených volání** na zásobníku najednou – čekají na základní případ.

```
Faktorial(3)
  └─ volá Faktorial(2)
       └─ volá Faktorial(1)
            └─ vrátí 1  ← základní případ
       ← vrátí 2
  ← vrátí 6
```

| Aspekt | Vysvětlení |
| ------ | ---------- |
| **Hloubka rekurze** | Počet volání na zásobníku současně |
| **Stack overflow** | Příliš hluboká rekurze přeteče zásobník → program spadne |
| **Paměť** | Každé volání zabírá místo – u hluboké rekurze náročné |
| **Odstranění rekurze** | Iterace nebo vlastní zásobník – neukládá se do call stacku |

```csharp
// Příliš hluboká rekurze → StackOverflowException
void Nekonecna(int n) => Nekonecna(n + 1);
```

---

## Odstranění rekurze

### 1. Iterativní přístup (cykly)

> Nejčastější způsob – přepsat rekurzi na `for` nebo `while`.

```csharp
// Rekurzivní
int Faktorial(int n)
{
    if (n <= 1) return 1;
    return n * Faktorial(n - 1);
}

// Iterativní – odstranění rekurze
int Faktorial(int n)
{
    int vysledek = 1;
    for (int i = 2; i <= n; i++)
        vysledek *= i;
    return vysledek;
}
```

```csharp
// Rekurzivní Fibonacci
int Fib(int n)
{
    if (n <= 1) return n;
    return Fib(n - 1) + Fib(n - 2);
}

// Iterativní – rychlejší, žádné přetečení zásobníku
int Fib(int n)
{
    if (n <= 1) return n;
    int pred = 0, akt = 1;
    for (int i = 2; i <= n; i++)
    {
        int temp = akt;
        akt = pred + akt;
        pred = temp;
    }
    return akt;
}
```

### 2. Explicitní zásobník

> Když iterativní převod je složitý (např. procházení stromu), simuluje se zásobník volání vlastním zásobníkem.

```csharp
void ProjdiStromIterativne(Uzel koren)
{
    var zasobnik = new Stack<Uzel>();
    zasobnik.Push(koren);

    while (zasobnik.Count > 0)
    {
        var uzel = zasobnik.Pop();
        if (uzel == null) continue;

        Console.WriteLine(uzel.Hodnota);
        zasobnik.Push(uzel.Pravy);  // nejdřív pravý (vyjde se v opačném pořadí)
        zasobnik.Push(uzel.Levy);
    }
}
```

---

## Shrnutí

- **Rekurze** – funkce volá sama sebe. Potřebuje základní případ a rekurzivní krok.
- **Zásobník** – každé volání ukládá stav na call stack; hluboká rekurze → stack overflow.
- **Typy** – přímá (volá sebe), nepřímá (A↔B), tail (volání je poslední operace).
- **Aplikace** – faktoriál, Fibonacci, stromy, Hanoi věže.
- **Výhody** – elegance, čitelnost u rekurzivních problémů.
- **Nevýhody** – stack overflow, větší paměť, někdy horší výkon.
- **Odstranění** – iterace (cykly) nebo explicitní zásobník.
