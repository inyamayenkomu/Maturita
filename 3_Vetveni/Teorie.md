# 3. Větvení a operátory

> Vysvětlete pojmy větvení a skok. Popište základní typy větvení v jazyce C#. Co je to operátor? Popište operátory dle typů (aritmetické, logické, porovnávací a přiřazovací) a počtu argumentů (unární, binární, ternární). Uveďte příklady, kdy je vhodné jednotlivé operátory použít.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Podmínka** | Výraz, který vyhodnotí na true/false | Semafor – zelená (true) = jeď, červená (false) = stůj |
| **Operand** | Hodnota, na které operátor pracuje | V „5 + 3“ jsou operandy čísla 5 a 3 |
| **Arita** | Počet operandů operátoru | Unární = 1, binární = 2, ternární = 3 |
| **Short-circuit** | Vyhodnocení zastaví, jakmile je výsledek jasný | U `false && cokoliv` se `cokoliv` už nevyhodnocuje |
| **Blok kódu** | Kód mezi `{ }` – provede se jako celek | Místnost – buď vstoupíš celá, nebo vůbec |
| **Větvení** | Rozdělení programu podle podmínky | Semafor – jedna cesta pro zelenou, jiná pro červenou |
| **Skok** | Přeskočení části kódu nebo změna toku programu | `break` z cyklu, `return` z metody |


---

## Větvení a skok

### Větvení

> 🚦 **Přirovnání**: Větvení je jako **křižovatka** – podle podmínky program pokračuje jednou nebo druhou cestou.

- **Definice**: Změna toku programu podle splnění podmínky. Program neběží vždy stejně shora dolů, ale vybírá větev.
- **Základní typy v C#**:
  - **`if` / `else if` / `else`** – obecné podmíněné větvení
  - **`switch`** – větvení podle konkrétní hodnoty (den v týdnu, volba menu)
  - **Ternární operátor `? :`** – zkrácené větvení při přiřazení hodnoty

### Skok

> ⏭️ **Přirovnání**: Skok je jako **zkratka v budově** – přeskočíš část cesty, kterou nechceš projít.

- **Definice**: Příkaz, který **změní pořadí vykonávání** kódu – program „skočí“ jinam, místo aby šel řádek za řádkem.
- **Nejčastější skoky v C#**:

| Příkaz | Co dělá | Kdy použít |
| ------ | ------- | ---------- |
| **`break`** | Ukončí cykl nebo `switch` | Nalezena hledaná hodnota, konec menu |
| **`continue`** | Přeskočí zbytek aktuální iterace cyklu | Přeskočit sudá čísla, neplatné záznamy |
| **`return`** | Ukončí metodu a vrátí výsledek | Konec výpočtu, ukončení při chybě |
| **`goto`** | Skok na štítek | Spíše se nepoužívá – horší čitelnost kódu |

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break;      // skok ven z cyklu

    if (i % 2 == 0)
        continue;   // skok na další iteraci

    Console.WriteLine(i);
}
```

---

## 📐 Slovník symbolů – základní flowchart

| Symbol | Význam |
| ------ | ------ |
| **Oval** | Začátek nebo konec programu |
| **Kosočtverec** | Podmínka – true/false rozhodnutí |
| **Obdélník** | Akce – příkaz, výstup |
| **Šipka** | Tok – směr provedení |

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
              ╱─────╲
             ╱ podm. ╲
            ╱    ?    ╲
            ╲         ╱
             ╲───────╱
          False│   │True
               │   │
               ▼   ▼
        ┌─────────┐ ┌─────────┐
        │ větev B │ │ větev A │
        └────┬────┘ └────┬────┘
             │           │
             └────┬─┬────┘
                  │ │
                  ▼ ▼
            ╭──────────╮
            │ Continue │
            ╰──────────╯
```

---

## Základní typy větvení v C#

> 🚦 **Přirovnání**: Podmíněný příkaz je jako **semafor na křižovatce**. Zelená? Jeď. Červená? Stůj. Podle stavu podmínky se program rozhodne, kterou větev kódu provede.

- **Definice**: Umožňuje větvení programu na základě splnění nebo nesplnění podmínky. Program se „rozdělí“ – jedna větev se provede, druhá ne.

### if / else if / else

### Syntaxe v C#

```csharp
if (podmínka)
{
    // kód, když je podmínka true
}
else if (další_podmínka)
{
    // kód, když první false, ale druhá true
}
else
{
    // kód, když vše false
}
```

### Příklad

```csharp
int vek = 17;

if (vek >= 18)
{
    Console.WriteLine("Můžeš volit");
}
else if (vek == 17)
{
    Console.WriteLine("Skoro můžeš volit");
}
else
{
    Console.WriteLine("Nemůžeš volit");
}
```

---

## Vývojový diagram podmíněného větvení

> 📐 **Přirovnání**: Jako **stěrače – prší?** True = zapni, False = vypni. Pak pokračuj dál.

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
            ╱───────────╲
           ╱  Prší?      ╲
          ╱               ╲
          ╲               ╱
           ╲─────────────╱
         False│       │True
              │       │
              ▼       ▼
      ┌────────────┐ ┌────────────┐
      │ Stěrače OFF│ │ Stěrače ON │
      └──────┬─────┘ └──────┬─────┘
             │              │
             └──────┬─┬─────┘
                    │ │
                    ▼ ▼
              ╭──────────╮
              │ Continue │
              ╰──────────╯
```

### Zjednodušený tvar (if-else)

```
             ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
            ╱───────────╲
           ╱  věk ≥ 18 ? ╲
          ╱               ╲
          ╲               ╱
           ╲─────────────╱
         False│       │True
              │       │
              ▼       ▼
   ┌────────────────┐ ┌────────────────┐
   │ Nemůžeš volit  │ │ Můžeš volit    │
   └────────┬───────┘ └────────┬───────┘
            │                  │
            └────────┬─┬───────┘
                     │ │
                     ▼ ▼
               ╭─────────╮
               │   End   │
               ╰─────────╯
```

---

## Co je to operátor?

> 🔧 **Přirovnání**: Operátor je jako **nástroj v kuchyni** – vezme jednu nebo více hodnot (operandů) a vrátí výsledek (součet, porovnání, true/false).

- **Definice**: Symbol nebo klíčové slovo, které provádí operaci nad **operandy** (hodnotami).
- Operátory dělíme podle **typu** (co dělají) a podle **arity** (kolik operandů potřebují).

---

## Operátory dle typů

### Aritmetické operátory

| Operátor | Význam | Příklad | Kdy použít |
| -------- | ------ | ------- | ---------- |
| `+` | Sčítání | `5 + 3` | Součet, spojení textu |
| `-` | Odčítání | `10 - 4` | Rozdíl, záporné číslo |
| `*` | Násobení | `6 * 7` | Výpočet plochy, ceny |
| `/` | Dělení | `15 / 3` | Průměr, podíl |
| `%` | Modulo (zbytek) | `17 % 5` | Sudé/liché (`i % 2`), cykly |

```csharp
int cena = 100;
int sleva = 20;
int kUhrade = cena - sleva;   // aritmetika
bool jeSudé = (cislo % 2 == 0); // modulo v podmínce
```

### Porovnávací operátory

| Operátor | Význam | Příklad |
| -------- | ------ | ------- |
| `==` | rovno | `vek == 18` |
| `!=` | nerovno | `vek != 0` |
| `<` | menší než | `vek < 18` |
| `>` | větší než | `vek > 18` |
| `<=` | menší nebo rovno | `vek <= 17` |
| `>=` | větší nebo rovno | `vek >= 18` |

**Kdy použít**: V podmínkách `if`, `while`, ternárním operátoru – rozhodnutí na základě vztahu mezi hodnotami.

### Logické operátory

| Operátor | Význam | Příklad |
| -------- | ------ | ------- |
| `&&` | AND – obě podmínky musí být true | `vek >= 18 && maObcanku` |
| `||` | OR – alespoň jedna true (včetně obou) | `jeVikend || jeSvatek` |
| `^` | XOR – právě jedna true (ne obě) | `maKartu ^ maHotovost` |
| `!` | NOT – negace | `!jePlnoletý` |

**Kdy použít**: Spojení více podmínek – např. „můžeš vstoupit, pokud jsi plnoletý **a** máš vstupenku“.

### Přiřazovací operátory

| Operátor | Význam | Příklad |
| -------- | ------ | ------- |
| `=` | Přiřazení hodnoty | `x = 5` |
| `+=` | Přičtení a přiřazení | `x += 3` (x = x + 3) |
| `-=` | Odečtení a přiřazení | `x -= 2` |
| `*=` | Násobení a přiřazení | `x *= 2` |
| `/=` | Dělení a přiřazení | `x /= 2` |
| `++` | Inkrementace (+1) | `i++` nebo `++i` |
| `--` | Dekrementace (−1) | `i--` |

**Kdy použít**: Aktualizace proměnných v cyklech (`i++`), sčítání součtů (`suma += hodnota`), zkrácený zápis místo `x = x + 1`.

### ⚠️ POZOR: OR vs XOR – v češtině „nebo“ často znamená XOR!

> 🗣️ **Přirovnání**: V češtině říkáš „chci kávu **nebo** čaj“ – obvykle myslíš **jedno nebo druhé, ne obě** (XOR). V programování `||` (OR) znamená **alespoň jedno**, tedy **včetně obou**!

| | OR (inclusive) | XOR (exclusive) |
| --- | --- | --- |
| **Význam** | Alespoň jedna podmínka je true | Právě jedna podmínka je true |
| **T + T** | true (obě platí) | **false** (obě nesmí) |
| **T + F** | true | true |
| **F + T** | true | true |
| **F + F** | false | false |
| **Česky** | „A nebo B nebo oboje“ | „Buď A, nebo B – ne oboje“ |

**Příklad**: „Můžeš platit kartou **nebo** hotovostí“ – v češtině často myslíš XOR (jedna z možností). V kódu:
- `karta || hotovost` – true i když máš obojí
- `karta ^ hotovost` – true jen když máš právě jedno

```
┌─────────────────────────────────────────────────────────────────┐
│  LOGICKÉ OPERÁTORY                                              │
│                                                                 │
│   && (AND)     || (OR)      ^ (XOR)     ! (NOT)                 │
│   ┌───┬───┐    ┌───┬───┐    ┌───┬───┐    ┌─────┐                │
│   │ T │ T │→T  │ T │ T │→T  │ T │ T │→F  │  T  │→F              │
│   │ T │ F │→F  │ T │ F │→T  │ T │ F │→T  │  F  │→T              │
│   │ F │ T │→F  │ F │ T │→T  │ F │ T │→T  └─────┘                │
│   │ F │ F │→F  │ F │ F │→F  │ F │ F │→F                         │
│   └───┴───┘    └───┴───┘    └───┴───┘                           │
│   Oba true     Stačí 1      Právě 1     Obrátí                  │
│   (i oba)      (i oba)      (ne oba)    hodnotu                 │
└─────────────────────────────────────────────────────────────────┘
```

---

## Operátory dle počtu argumentů (arity)

> 🎯 **Přirovnání**: Arita = **kolik „spolupracovníků“ operátor potřebuje**. Unární pracuje sám, binární potřebuje dva, ternární tři.

### Unární operátory (arita 1)

- **Arita** = počet operandů, se kterými operátor pracuje. Říká nám, kolik „vstupů“ operátor potřebuje.
- **Unární** = arita 1. Pracují s **jedním operandem**
- **Příklady**: `!x`, `-x`, `++x`, `--x`, `~x`

```csharp
bool jePlnoletý = true;
bool neniPlnoletý = !jePlnoletý;   // ! = unární, 1 operand

int x = 5;
int y = -x;   // - = unární (změna znaménka)
x++;          // ++ = unární (inkrementace)
```

### Binární operátory (arita 2)

- **Binární** = arita 2. Pracují se **dvěma operandy**
- **Příklady**: `a + b`, `x > 5`, `a && b`

```csharp
int soucet = 5 + 3;        // + má operandy 5 a 3
bool jeVetsi = x > 10;     // > má operandy x a 10
bool oba = (a > 0) && (b > 0);  // && má dva logické výrazy
```

### Ternární operátor (arita 3)

- **Ternární** = arita 3. Jediný ternární operátor v C# – **podmíněný operátor** `? :`
- **Syntaxe**: `podmínka ? hodnota_když_true : hodnota_když_false`

```csharp
int vek = 17;
string stav = (vek >= 18) ? "Dospělý" : "Mladistvý";
//             └─1─┘      └──2──┘     └────3────┘
//             podmínka   když true   když false

int max = (a > b) ? a : b;   // větší z dvou čísel
```

```
┌─────────────────────────────────────────────────────────────────┐
│  TERNÁRNÍ OPERÁTOR  ? :                                         │
│                                                                 │
│   podmínka ? hodnota_true : hodnota_false                       │
│      │           │              │                               │
│      1. operand  2. operand     3. operand                      │
│                                                                 │
│   (vek >= 18) ? "Dospělý" : "Mladistvý"                         │
│        │              │            │                            │
│     Je 18+?        Ano → tohle   Ne → tohle                     │
└─────────────────────────────────────────────────────────────────┘
```

### Tabulka podle arity

| Typ | Počet operandů | Příklady | Použití |
| --- | -------------- | -------- | ------- |
| **Unární** | 1 | `!x`, `-x`, `++x` | Negace, změna znaménka, inkrementace |
| **Binární** | 2 | `a + b`, `x > 5`, `a && b` | Aritmetika, porovnání, logika |
| **Ternární** | 3 | `c ? a : b` | Podmíněné vyhodnocení (zkrácený if-else) |

---

## Příklady užití podmíněných příkazů

### 1. Kontrola věku

```csharp
if (vek >= 18)
{
    Console.WriteLine("Dospělý");
}
```

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
            ╱───────────╲
           ╱  věk ≥ 18 ? ╲
          ╱               ╲
          ╲               ╱
           ╲─────────────╱
         False│       │True
              │       │
              │       ▼
              │  ┌────────────┐
              │  │  Dospělý   │
              │  └─────┬──────┘
              │        │
              └────────┴───────┐
                               ▼
                         ╭─────────╮
                         │   End   │
                         ╰─────────╯
```

### 2. Ternární pro jednoduché rozhodnutí

```csharp
string stav = (teplota > 30) ? "Horko" : "Normál";
```

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
            ╱──────────────╲
           ╱  teplota > 30? ╲
          ╱                  ╲
          ╲                  ╱
           ╲────────────────╱
          False│         │True
               │         │
               ▼         ▼
      ┌────────────┐ ┌────────────┐
      │  "Normál"  │ │  "Horko"   │
      └──────┬─────┘ └──────┬─────┘
             │              │
             └──────┬─┬─────┘
                    │ │
                    ▼ ▼
              ╭─────────╮
              │   End   │
              ╰─────────╯
```

### 3. Složená podmínka (AND, OR)

```csharp
if (vek >= 18 && maObcanku)
{
    Console.WriteLine("Můžeš vstoupit");
}
else
{
    Console.WriteLine("Nemůžeš vstoupit");
}
```

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
        ╱──────────────────────╲
       ╱ věk ≥ 18 && maObčanku? ╲
      ╱                          ╲
      ╲                          ╱
       ╲────────────────────────╱
         False│             │True
              │             │
              ▼             ▼
   ┌────────────────┐ ┌────────────────┐
   │ Nemůžeš        │ │ Můžeš vstoupit │
   │ vstoupit       │ └────────┬───────┘
   └────────┬───────┘          │
            │                  │
            └────────┬─┬───────┘
                     │ │
                     ▼ ▼
               ╭─────────╮
               │   End   │
               ╰─────────╯
```

### 4. Switch pro více hodnot

```csharp
switch (den)
{
    case 1: Console.WriteLine("Pondělí"); break;
    case 2: Console.WriteLine("Úterý"); break;
    case 3: Console.WriteLine("Středa"); break;
    default: Console.WriteLine("Jiný den"); break;
}
```

```
               ╭─────────╮
               │  Start  │
               ╰────┬────╯
                    │
                    ▼
             ╱────────────╲
            ╱    den ?     ╲
           ╱                ╲
           ╲                ╱
            ╲──────────────╱
          ┌──────┼──────┼──────┐
          │      │      │      │
          ▼      ▼      ▼      ▼
   ┌─────────┐ ┌─────────┐ ┌─────────┐ ┌────────────┐
   │ Pondělí │ │  Úterý  │ │ Středa  │ │ Jiný den   │
   └────┬────┘ └────┬────┘ └────┬────┘ └─────┬──────┘
        │           │           │            │
        └─────┬─────┴─────┬─────┴─────┬──────┘
              │           │           │
              └───────────┴───────────┘
                          │
                          ▼
                    ╭─────────╮
                    │   End   │
                    ╰─────────╯
```

### 5. Vnořené podmínky

```csharp
if (maVstupenku)
{
    if (vek >= 18)
        Console.WriteLine("Můžeš dovnitř");
    else
        Console.WriteLine("Potřebuješ doprovod");
}
else
{
    Console.WriteLine("Kupte si vstupenku");
}
```

```
                ╭─────────╮
                │  Start  │
                ╰────┬────╯
                     │
                     ▼
            ╱─────────────────╲
           ╱  máVstupenku ?    ╲
          ╱                     ╲
          ╲                     ╱
           ╲───────────────────╱
            False│         │True
                 │         │
                 ▼         ▼
    ┌──────────────────┐   ╱───────────╲
    │ Kupte si         │  ╱  věk ≥ 18 ? ╲
    │ vstupenku        │ ╱               ╲
    └────────┬─────────┘ ╲               ╱
             │            ╲─────────────╱
             │            False│    │True
             │                 │    │
             │                 ▼    -------------▼
             │      ┌──────────────────┐ ┌──────────────────┐
             │      │ Potřebuješ       │ │ Můžeš dovnitř    │
             │      │ doprovod         │ └────────┬─────────┘
             │      └────────┬─────────┘          │
             │               │                    │
             └───────────────┴──────────┬─────────┘
                                        │
                                        ▼
                                  ╭─────────╮
                                  │   End   │
                                  ╰─────────╯
```

---

## Shrnutí

- **Větvení** – rozdělení programu podle podmínky (`if`, `else`, `switch`, ternární `? :`).
- **Skok** – změna toku programu (`break`, `continue`, `return`).
- **Operátor** – symbol provádějící operaci nad operandy.
- **Typy operátorů** – aritmetické (`+`, `-`, `*`), porovnávací (`==`, `<`), logické (`&&`, `||`, `!`), přiřazovací (`=`, `+=`, `++`).
- **Unární** = 1 operand (`!x`), **binární** = 2 operandy (`a + b`), **ternární** = 3 operandy (`c ? a : b`).
- **Ternární** `? :` – zkrácený zápis pro jednoduché if-else při přiřazení hodnoty.
