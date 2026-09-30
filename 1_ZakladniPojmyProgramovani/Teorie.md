# 1. Základní pojmy programování

> Definujte pojmy algoritmus, program, datový typ, proměnná, deklarace. Popište strukturu programu v jazyce C# a řízení toku programu. Vyjmenujte základní datové typy jazyka C#. Jaký je rozdíl mezi hodnotovým a referenčním datovým typem? Co je to oblast platnosti proměnné?

---

## 📖 Slovníček pojmů


| Pojem                                  | Co to je                                                                       | Příklad z reálného světa                                       |
| -------------------------------------- | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Zásobník (Stack)**                   | Rychlá paměť pro dočasná data, funguje jako LIFO (poslední dovnitř, první ven) | Hromada talířů – bereš vždy ten navrchu                        |
| **Halda (Heap)**                       | Větší paměť pro složitější data, pomalejší přístup                             | Velký sklad – můžeš si vzít cokoliv, ale musíš vědět kde to je |
| **Reference (odkaz)**                  | Adresa, která říká "data jsou TADY"                                            | GPS souřadnice k domu (ne dům samotný)                         |
| **Inicializace**                       | Přiřazení první hodnoty proměnné                                               | Napsat jméno na prázdnou jmenovku                              |
| **Iterace**                            | Jedno provedení cyklu                                                          | Jedno kolečko na běžeckém oválu                                |
| **Blok kódu**                          | Kód mezi složenými závorkami `{ }`                                             | Místnost s dveřmi – co je uvnitř, zůstává uvnitř               |
| **Jmenný prostor (namespace)**         | Organizační složka pro třídy                                                   | Příjmení rodiny – odlišuje Denise od Denise                    |
| **Metoda****(funkce v OOP kontextu)** | Pojmenovaný kus kódu, který něco dělá                                          | Recept v kuchařce – můžeš ho použít opakovaně                  |
| **Kompilace**                          | Překlad kódu do jazyka počítače                                                | Překlad knihy z češtiny do strojového kódu                     |


---

## Základní pojmy

### Algoritmus

> 🍳 **Přirovnání**: Algoritmus je jako **recept na vaření**. Máš ingredience (vstup), postupuješ podle kroků, a na konci máš jídlo (výstup).

- **Definice**: Přesný, jednoznačný a konečný postup řešení problému pomocí konečného počtu kroků

```
┌─────────────────────────────────────────────────────────┐
│                    ALGORITMUS                           │
│                                                         │
│   VSTUP ──▶ [ Krok 1 ] ──▶ [ Krok 2 ] ──▶ ... ──▶ VÝSTUP│
│                                                         │
│   Např:                                                 │
│   Čísla ──▶ [Porovnej] ──▶ [Vyber větší] ──▶ Maximum    │
└─────────────────────────────────────────────────────────┘
```

- **Vlastnosti algoritmu**:
  - **Konečnost** – musí skončit (recept má konec, nevaříš věčně)
  - **Determinovanost** – každý krok je jasný (ne "přidej trochu soli")
  - **Resultativnost** – vede k výsledku (na konci máš jídlo)
  - **Obecnost** – funguje pro více případů (recept na těstoviny funguje vždy)
  - **Vstup/Výstup** – něco dostane, něco vydá

### Program

> 🎮 **Přirovnání**: Program je jako **hra na konzoli**. Je to algoritmus (pravidla hry) zapsaný v jazyce, kterému rozumí počítač.

- **Definice**: Zápis algoritmu v programovacím jazyce, který může být spuštěn na počítači
- Program je posloupnost instrukcí, které počítač vykonává, jako kuchařka
- Programovací jazyky: C#, Java, Python, C++, JavaScript...

```
┌──────────────┐      ┌──────────────┐      ┌──────────────┐
│  ALGORITMUS  │ ───▶ │   PROGRAM    │ ───▶ │   POČÍTAČ    │
│   (nápad)    │      │   (C# kód)   │      │  (vykonává)  │
└──────────────┘      └──────────────┘      └──────────────┘
    Recept       Recept v angličtině    Kuchař vaří podle něj
```

### Datový typ

> 📦 **Přirovnání**: Datový typ je jako **typ krabice**. Krabice na boty pojme boty, krabice na pizzu pojme pizzu. Nemůžeš dát pizzu do krabice na boty.

- **Definice**: Určuje druh hodnot, které může proměnná obsahovat, a operace, které s ní lze provádět

```
┌─────────────────────────────────────────────────────────┐
│                    DATOVÉ TYPY                          │
│                                                         │
│   int ──────▶ [ 42 ]         Krabice na celá čísla      │
│   string ───▶ [ "Ahoj" ]     Krabice na text            │
│   bool ─────▶ [ true ]       Krabice na ano/ne          │
│   double ───▶ [ 3.14 ]       Krabice na desetinná č.    │
└─────────────────────────────────────────────────────────┘
```

- Definuje:
  - Množinu přípustných hodnot (co se vejde do krabice)
  - Velikost paměti pro uložení (jak velká je krabice)
  - Operace, které lze s hodnotami provádět (co s tím můžeš dělat, např. string má často funkci replace())

### Proměnná

> 🏷️ **Přirovnání**: Proměnná je jako **krabice s nálepkou**. Nálepka je jméno (např. "vek"), uvnitř je hodnota (např. 25), a typ krabice určuje, co tam může být.

- **Definice**: Pojmenované místo v paměti pro ukládání hodnot během běhu programu

```
┌─────────────────────────────────────────────────────────┐
│                     PROMĚNNÁ                            │
│                                                         │
│         ┌─────────┐                                     │
│   jméno │   vek   │  ◀── "nálepka na krabici"           │
│         ├─────────┤                                     │
│hodnota  │   25    │  ◀── "co je uvnitř"                 │
│         ├─────────┤                                     │
│   typ   │   int   │  ◀── "typ krabice"                  │
│         └─────────┘                                     │
│                                                         │
│   V kódu: int vek = 25;                                 │
└─────────────────────────────────────────────────────────┘
```

- Má:
  - **Jméno** (identifikátor) – např. `cislo`, `jmeno`
  - **Datový typ** – určuje, jaké hodnoty může obsahovat (typ krabice)
  - **Hodnotu** – aktuální obsah proměnné 
  - **Adresu** – místo v paměti

### Deklarace

> 📝 **Přirovnání**: Deklarace je jako **objednání krabice**. Řekneš "chci krabici typu X a bude se jmenovat Y". Ještě v ní nic není, ale máš ji připravenou.

- **Definice**: Oznámení existence proměnné, funkce nebo jiného prvku včetně jeho jména a datového typu

```csharp
int cislo;           // deklarace - "objednávám krabici na int, bude se jmenovat cislo"
int cislo = 10;      // deklarace s inicializací - "objednávám a hned do ní dávám 10"
string jmeno;        // deklarace řetězce
```

---

## Struktura programu v jazyce C#

> 🏢 **Přirovnání**: Program je jako **budova firmy**. Má adresu (namespace), patra (třídy), kanceláře (metody), a hlavní vchod (Main).

```
┌─────────────────────────────────────────────────────────────────┐
│  STRUKTURA C# PROGRAMU                                          │
│                                                                 │
│  ┌─────────────────────────────────────────────────────────┐    │
│  │ using System;              ◀── IMPORTY (dovoz nástrojů) │    │
│  └─────────────────────────────────────────────────────────┘    │
│                              │                                  │
│                              ▼                                  │
│  ┌─────────────────────────────────────────────────────────┐    │
│  │ namespace MojeAplikace    ◀── JMENNÝ PROSTOR (adresa)   │    │
│  │ ┌─────────────────────────────────────────────────────┐ │    │
│  │ │ class Program           ◀── TŘÍDA (budova)          │ │    │
│  │ │ ┌─────────────────────────────────────────────────┐ │ │    │
│  │ │ │ static void Main()    ◀── HLAVNÍ METODA (vchod) │ │ │    │
│  │ │ │                                                 │ │ │    │
│  │ │ │    Console.WriteLine("Ahoj!");  ◀── PŘÍKAZY     │ │ │    │
│  │ │ │                                                 │ │ │    │
│  │ │ └─────────────────────────────────────────────────┘ │ │    │
│  │ └─────────────────────────────────────────────────────┘ │    │
│  └─────────────────────────────────────────────────────────┘    │
└─────────────────────────────────────────────────────────────────┘
```

```csharp
using System;                    // 1. Direktivy using - import jmenných prostorů

namespace MojeAplikace           // 2. Jmenný prostor (namespace)
{
    class Program                // 3. Třída
    {
        static void Main(string[] args)   // 4. Metoda Main - vstupní bod celého programu
        {
            // 5. Příkazy programu
            Console.WriteLine("Hello World!");
        }
    }
}
```

### Části struktury:

1. **Direktivy using** – importují jmenné prostory (jako "dovoz nástrojů z jiného skladu", např. můžu importovat funkci z nějaké knihovny)
2. **Namespace** – logické seskupení tříd (jako "příjmení" – odliší tvůj Program od cizího)
3. **Třída (class)** – základní stavební blok v C#, obsahuje data a metody
4. **Metoda Main** – vstupní bod programu, kde počítač začíná číst
5. **Příkazy** – konkrétní instrukce uvnitř metod

---

## Řízení toku programu

> 🚗 **Přirovnání**: Řízení toku je jako **GPS navigace**. Normálně jedeš rovně (sekvenční), na křižovatce se rozhoduješ (podmínka), a někdy jedeš dokola (cyklus).

```
┌─────────────────────────────────────────────────────────────────┐
│  TŘI TYPY ŘÍZENÍ TOKU                                           │
│                                                                 │
│  1. SEKVENCE        2. VĚTVENÍ           3. CYKLUS              │
│     (rovně)         (křižovatka)         (kolečko)              │
│                                                                 │
│       │                  │                    │                 │
│       ▼                  ▼                 ┌──▼──┐              │
│    [Krok 1]         ┌──────────┐           │     │              │
│       │             │ Podmínka?│           | Krok│◀─┐           │
│       ▼             └───┬──────┘           │     │  │           │
│    [Krok 2]         ┌───┴───┐              └──┬──┘  │           │
│       │             ▼       ▼                 │     │           │
│       ▼          [ANO]    [NE]             [Opakuj?]│           │
│    [Krok 3]         │       │                 │ ANO │           │
│                     └───┬───┘                 └─────┘           │
└─────────────────────────────────────────────────────────────────┘
```

### Podmínky (větvení)

> 🚦 **Přirovnání**: Podmínka je jako **semafor**. Zelená? Jeď. Červená? Stůj. Podle stavu se rozhodneš, co uděláš.

**if-else:**

```csharp
if (vek >= 18)          // KDYŽ je věk 18 nebo víc
{
    Console.WriteLine("Můžeš volit");    // udělej tohle
}
else if(vek == 17) // NEBO KDYŽ je ti 17 
{
    Console.WriteLine("Skoro můžeš volit.")  // udělej tohle
}
else                    // JINAK
{
    Console.WriteLine("Nemůžeš volit");  // udělej tohle
}
```

```
           ┌──────────────┐
           │  vek >= 18?  │
           └──────┬───────┘
              ┌───┴────────┐
            ANO           NE
              │            │
              ▼            │
         [Můžeš]           │                
          volit        ┌───┴─────────┐
                       │  vek = 17?  │
                       └──────┬──────┘
                          ┌───┴────────┐
                         ANO           NE
                          │            │
                          ▼            ▼             
                   [Skoro Můžeš]      [Nemůžeš]
                       volit           volit
```

**switch:**

> 🎰 **Přirovnání**: Switch je jako **automat na nápoje**. Zmáčkneš tlačítko (hodnota), automat se podívá které to je, a vydá odpovídající nápoj. Když zmáčkneš něco neznámého, dostaneš výchozí nápoj (default).

```
┌─────────────────────────────────────────────────────────────────┐
│  SWITCH = AUTOMAT NA NÁPOJE                                     │
│                                                                 │
│         ┌─────────┐                                             │
│         │  den=?  │  ◀── Jakou hodnotu má proměnná?             │
│         └────┬────┘                                             │
│              │                                                  │
│    ┌─────────┼─────────┬─────────┬─────────┐                    │
│    ▼         ▼         ▼         ▼         ▼                    │
│ ┌──────┐ ┌──────┐ ┌──────┐ ┌──────┐ ┌─────────┐                 │
│ │den=1 │ │den=2 │ │den=3 │ │den=4 │ │ default │                 │
│ └──┬───┘ └──┬───┘ └──┬───┘ └──┬───┘ └────┬────┘                 │
│    ▼        ▼        ▼        ▼          ▼                      │
│ [Pondělí] [Úterý] [Středa] [Čtvrtek] [Jiný den]                 │
│                                                                 │
│  Zmáčknu "2" ──▶ dostanu "Úterý"                                │
│  Zmáčknu "99" ─▶ dostanu "Jiný den" (default)                   │
└─────────────────────────────────────────────────────────────────┘
```

```csharp
switch (den)
{
    case 1:
        Console.WriteLine("Pondělí");
        break;      // DŮLEŽITÉ! Bez break by to "propadlo" dál
    case 2:
        Console.WriteLine("Úterý");
        break;
    case 3:
        Console.WriteLine("Středa");
        break;
    default:        // Když nic nesedí
        Console.WriteLine("Jiný den");
        break;
}
```

**Kdy použít switch místo if-else?**

- Když porovnáváš **jednu proměnnou** s **více konkrétními hodnotami**
- Je přehlednější než 10x `if (den == 1) ... else if (den == 2) ...`

### Cykly (opakování)

> 🔄 **Přirovnání**: Cyklus je jako **opakování písničky**. Hraješ dokola, dokud ti to neřekne stop.

**for** – když víš KOLIKRÁT:

```csharp
// Udělej 10 kliků
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Klik číslo " + i);
}
```

**while** – když nevíš kolikrát, ale víš DOKDY:

```csharp
// Jez dokud máš hlad
while (mamHlad)
{
    Jez();
}
```

**do-while** – jako while, ale ASPOŇ JEDNOU se provede:

```csharp
// Zkus to aspoň jednou
do
{
    Zkus();
} while (neuspech);
```

**foreach** – projdi VŠECHNO v kolekci:

```csharp
// Projdi všechny studenty
foreach (var student in studenti)
{
    Console.WriteLine(student);
}
```

### Skoky

- **break** – "STOP, konec cyklu, jdu pryč"
- **continue** – "tuhle iteraci přeskakuju, jedu další"
- **return** – "končím metodu a vracím výsledek"

---

## Základní datové typy v C#

### Hodnotové typy (Value Types)


| Typ       | Velikost | Rozsah/Popis                             | Důležitost |
| --------- | -------- | ---------------------------------------- | ---------- |
| `bool`    | 1 byte   | `true` / `false`                         | ZÁKLAD     |
| `byte`    | 1 byte   | 0 až 255                                 | méně časté |
| `sbyte`   | 1 byte   | -128 až 127                              | méně časté |
| `short`   | 2 bytes  | -32 768 až 32 767                        | méně časté |
| `ushort`  | 2 bytes  | 0 až 65 535                              | méně časté |
| `int`     | 4 bytes  | -2,1 mld až 2,1 mld                      | ZÁKLAD     |
| `uint`    | 4 bytes  | 0 až 4,3 mld                             | méně časté |
| `long`    | 8 bytes  | velmi velká celá čísla                   | občas      |
| `ulong`   | 8 bytes  | velmi velká kladná celá čísla            | méně časté |
| `float`   | 4 bytes  | desetinná čísla (7 číslic přesnosti)     | občas      |
| `double`  | 8 bytes  | desetinná čísla (15-16 číslic přesnosti) | ZÁKLAD     |
| `decimal` | 16 bytes | přesná desetinná čísla (pro finance)     | občas      |
| `char`    | 2 bytes  | jeden Unicode znak                       | ZÁKLAD     |


### Referenční typy (Reference Types)


| Typ                    | Popis                                         | Příklad                    | Důležitost  |
| ---------------------- | --------------------------------------------- | -------------------------- | ----------- |
| `string`               | Řetězec znaků (text)                          | `string jmeno = "Petr";`   | ZÁKLAD      |
| `object`               | Základní typ, ze kterého dědí všechny ostatní | `object o = 42;`           | dobrý vědět |
| `pole (array)`         | Kolekce prvků stejného typu                   | `int[] cisla = {1, 2, 3};` | ZÁKLAD      |
| `třídy (class)`        | Uživatelem definované typy                    | `class Osoba { }`          | ZÁKLAD      |
| `rozhraní (interface)` | Definuje kontrakt pro třídy                   | `interface IMovable { }`   | pokročilé   |


---

## Rozdíl mezi hodnotovým a referenčním typem

> 📋 **Klíčové přirovnání**:
>
> - **Hodnotový typ** = máš **fotku** v ruce. Když ji dáš kamarádovi, má vlastní kopii. Pokreslí-li ji, tvoje zůstane stejná.
> - **Referenční typ** = dáš kamarádovi **odkaz na Google Disk**. Oba vidíte stejný soubor. Když ho změní, změna je i u tebe.

### Hodnotový typ (Value Type)

```
┌─────────────────────────────────────────────────────────────────┐
│  HODNOTOVÝ TYP - kopíruje se HODNOTA                            │
│                                                                 │
│      int a = 5;           int b = a;           b = 10;          │
│                                                                 │
│    STACK (zásobník)      STACK                STACK             │
│    ┌─────┐               ┌─────┐              ┌─────┐           │
│    │ a=5 │               │ a=5 │              │ a=5 │  ◀─ beze  │
│    └─────┘               │ b=5 │              │b=10 │    změny! │
│                          └─────┘              └─────┘           │
│                             ▲                                   │
│                        b je KOPIE                               │
└─────────────────────────────────────────────────────────────────┘
```

- Ukládá **přímo hodnotu** v paměti
- Uložen na **zásobníku (stack)** – rychlá paměť
- Při přiřazení se **kopíruje celá hodnota**
- Příklad: `int`, `double`, `bool`, `char`, `struct`

```csharp
int a = 5;
int b = a;    // b je KOPIE hodnoty 5
b = 10;       // změna b NEOVLIVNÍ a
// Výsledek: a = 5, b = 10
```

### Referenční typ (Reference Type)

```
┌─────────────────────────────────────────────────────────────────┐
│  REFERENČNÍ TYP - kopíruje se ODKAZ (adresa)                    │
│                                                                 │
│  int[] pole1 = {1,2,3};   int[] pole2 = pole1;   pole2[0]=99;   │
│                                                                 │
│    STACK          HEAP        STACK      HEAP                   │
│   ┌──────┐      ┌───────┐    ┌──────┐  ┌───────┐                │
│   │pole1 │─────▶│{1,2,3}│    │pole1 │─▶│{1,2,3}│◀──┐            │
│   └──────┘      └───────┘    │pole2 │──────────────┘            │
│                              └──────┘                           │
│                                 ▲                               │
│                          OBĚ ukazují na                         │
│                          STEJNÁ data!                           │
│                                                                 │
│   Po změně pole2[0] = 99:                                       │
│                                                                 │
│   ┌──────┐                                                      │
│   │pole1 │─────▶ ┌────────┐                                     │
│   │pole2 │─────▶ │{99,2,3}│  ◀── změna se projeví v OBOU!       │
│   └──────┘       └────────┘                                     │
└─────────────────────────────────────────────────────────────────┘
```

- Ukládá **odkaz (referenci)** na místo v paměti
- Data jsou uložena na **haldě (heap)**, reference na zásobníku
- Při přiřazení se **kopíruje pouze odkaz**, ne data
- Příklad: `string`, `object`, pole, třídy

```csharp
int[] pole1 = {1, 2, 3};
int[] pole2 = pole1;    // pole2 odkazuje na STEJNÁ data
pole2[0] = 99;          // změna ovlivní OBĚ proměnné!
// Výsledek: pole1[0] = 99, pole2[0] = 99
```

### Shrnutí rozdílů:


| Vlastnost           | Hodnotový typ             | Referenční typ                           |
| ------------------- | ------------------------- | ---------------------------------------- |
| **Přirovnání**      | Fotka v ruce              | Odkaz na Google Disk                     |
| **Uložení**         | Zásobník (stack)          | Halda (heap) + reference na stacku       |
| **Přiřazení**       | Kopíruje hodnotu          | Kopíruje odkaz                           |
| **Změna kopie**     | Neovlivní originál        | Ovlivní "originál" (je to stejný objekt) |
| **Výchozí hodnota** | 0, false, '\0'            | null                                     |
| **Příklady**        | int, double, bool, struct | string, pole, třídy                      |


---

## Oblast platnosti proměnné (Scope)

> 🏠 **Přirovnání**: Scope je jako **místnosti v domě**. Proměnná "žije" jen ve své místnosti. Můžeš vidět ven (do větší místnosti), ale ne dovnitř menších pokojů.

**Definice**: Oblast platnosti proměnné určuje, ve které části kódu je proměnná přístupná a použitelná.

```
┌───────────────────────────────────────────────────────────────┐
│  SCOPE = KDE PROMĚNNÁ "ŽIJE"                                  │
│                                                               │
│  ┌────────────────────────────────────────────────────────┐   │
│  │  TŘÍDA (celý dům)                                      │   │
│  │  int a = 1;  ◀── viditelné VŠUDE ve třídě              │   │
│  │                                                        │   │
│  │  ┌─────────────────────────────────────────────────┐   │   │
│  │  │  METODA (obývák)                                │   │   │
│  │  │  int b = 2;  ◀── viditelné jen v metodě         │   │   │
│  │  │                                                 │   │   │
│  │  │  ┌─────────────────────────────────────────┐    │   │   │
│  │  │  │  IF BLOK (koupelna)                     │    │   │   │
│  │  │  │  int c = 3;  ◀── viditelné JEN ZDE      │    │   │   │
│  │  │  │                                         │    │   │   │
│  │  │  │  // tady vidím: a ✓ b ✓ c ✓             │    │   │   │
│  │  │  └─────────────────────────────────────────┘    │   │   │
│  │  │                                                 │   │   │
│  │  │  // tady vidím: a ✓  b ✓    c ✗                 │   │   │
│  │  └─────────────────────────────────────────────────┘   │   │
│  │                                                        │   │
│  │  // tady vidím: a ✓    b ✗    c ✗                      │   │
│  └────────────────────────────────────────────────────────┘   │
└───────────────────────────────────────────────────────────────┘
```

### Typy oblastí platnosti:

#### 1. Lokální proměnná (Local Scope)

- Deklarována uvnitř metody nebo bloku `{}`
- Platí pouze v daném bloku
- Po opuštění bloku "umírá"

```csharp
void Metoda()
{
    int x = 10;     // x žije jen v této metodě
    
    if (true)
    {
        int y = 20; // y žije jen v tomto if bloku
        // tady existuje x i y
    }
    // y už neexistuje (vyšli jsme z "místnosti")
    // x stále existuje
}
// x už neexistuje
```

#### 2. Třídní proměnná / Pole (Class Scope / Field)

- Deklarována uvnitř třídy, ale mimo metody
- Přístupná ve všech metodách třídy (jako chodba v domě)

```csharp
class Trida
{
    int cislo = 5;          // viditelné v celé třídě
    
    void Metoda1()
    {
        Console.WriteLine(cislo);   // OK - vidím do "chodby"
    }
    
    void Metoda2()
    {
        cislo = 10;                 // OK - můžu měnit
    }
}
```

#### 3. Globální / Statická proměnná

- Označena klíčovým slovem `static`
- Sdílena mezi všemi instancemi třídy (jako společná nástěnka)

```csharp
class Trida
{
    static int pocet = 0;   // sdílená - všichni vidí stejnou hodnotu
}
```

### Pravidla:

- Proměnná musí být deklarována **před použitím** (nemůžeš použít krabici, která neexistuje)
- V jednom bloku nemohou existovat **dvě proměnné se stejným názvem** (dvě krabice se stejnou nálepkou = chaos)
- Vnitřní bloky mají přístup k proměnným z vnějších bloků, ale ne naopak (z koupelny vidíš do obýváku, ale ne naopak)

---

## Materiály od učitele

Tato sekce sjednocuje obsah z: `DatoveTypy.txt`, `DatumACas.txt`, `Vetveni.txt`, `VyctoveTypy.txt`, `Vyjimky.txt`.

### Datové typy a proměnné

- C# je staticky typovaný jazyk, `var` znamená implicitní odvození typu při deklaraci.
- Hodnotové typy se při předání kopírují, referenční typy pracují s referencí.
- `string` je referenční typ, ale je neměnný (immutable).
- Převody: implicitní (bezpečné), explicitní casting, bezpečné přetypování referencí přes `is` a `as`.

### Datum a čas

- Hlavní typ je `DateTime`, časový interval reprezentuje `TimeSpan`.
- Časté operace: `AddDays`, formátování `ToString("dd.MM.yyyy")`, rozdíl dvou dat (`DateTime - DateTime`).
- Existují i `DateOnly` a `TimeOnly`.

### Větvení

- `if / else` pro podmíněné větvení, `switch` pro více větví nad jednou hodnotou.
- Běžné operátory: `==`, `!=`, `>`, `<`, `>=`, `<=`.

### Výčtové typy (enum)

- `enum` reprezentuje omezenou množinu pojmenovaných konstant.
- Zlepšuje čitelnost a bezpečnost oproti používání „magických čísel“.

### Výjimky

- Výjimka je signál chybového nebo nepředvídaného stavu.
- Zpracování probíhá přes `try/catch`, případně filtrování podle typu výjimky.
- Užitečné informace: `Message` a `StackTrace`.

### Pro ty, co chtej vedet vic

- [DatoveTypy.txt](Materialy/DatoveTypy.txt)
- [DatumACas.txt](Materialy/DatumACas.txt)
- [Vetveni.txt](Materialy/Vetveni.txt)
- [VyctoveTypy.txt](Materialy/VyctoveTypy.txt)
- [Vyjimky.txt](Materialy/Vyjimky.txt)

