# 4. Cykly

> Popište význam cyklu a syntaxi různých typů cyklů v jazyce C#. Nakreslete vývojový diagram cyklu. Popište vztah cyklu a pole. Co to je nekonečný cyklus a jaká nebezpečí představuje? Uveďte příklady užití cyklů.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Iterace** | Jedno provedení těla cyklu | Jedno kolečko na běžeckém oválu |
| **Čítač** | Proměnná, která sleduje počet iterací | Počítadlo kol – kolikrát jsi už oběhl |
| **Inicializace** | Nastavení počáteční hodnoty před cyklem | Postavit se na startovní čáru |
| **Podmínka ukončení** | Výraz, který rozhoduje, zda cyklus pokračuje | „Ještě jsem neuběhl 5 kol?“ |
| **Nekonečný cyklus** | Cyklus, jehož podmínka nikdy není false | Běhání dokola bez cíle – nikdy neskončíš |
| **break** | Okamžité ukončení cyklu | Zastavit běh uprostřed kola |
| **continue** | Přeskočení zbytku iterace, pokračování další | Přeskočit jedno kolečko a běžet dál |

---

## Význam cyklu

> 🔄 **Přirovnání**: Cyklus je jako **opakované kolečko na oválu**. Dokud platí podmínka („ještě neuběhl jsem 5 kol?“), běžíš dál. Jakmile neplatí, zastavíš.

- **Definice**: Cyklus umožňuje **opakované provádění bloku kódu**, dokud je splněna podmínka. Místo psaní stejného kódu stokrát ho napíšeš jednou a necháš ho opakovat.

```
┌─────────────────────────────────────────────────────────┐
│                    CYKLUS                               │
│                                                         │
│   [Začátek] ──▶ [Podmínka?] ◀──────────────────────┐    │
│                    │     │                          │    │
│                    Ne    Ano                       │    │
│                    │     │                          │    │
│                    │     ▼                          │    │
│                    │  [Blok kódu] ──────────────────┘    │
│                    │                                    │
│                    ▼                                    │
│               [Konec]                                   │
└─────────────────────────────────────────────────────────┘
```

---

## Syntaxe cyklů v C#

### for – cyklus s čítačem

> 📊 **Přirovnání**: Jako **počítání do deseti** – víš předem, kolikrát to uděláš.

```csharp
for (inicializace; podmínka; iterace)
{
    // kód
}
```

```csharp
// Výpis čísel 0 až 4
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
// i = 0: inicializace (na začátku)
// i < 5: podmínka (kontroluje se před každou iterací)
// i++: iterace (provede se po každé iteraci)
```

### while – cyklus s podmínkou na začátku

> ⏳ **Přirovnání**: Jako **čekání na autobus** – dokud nepřijel, čekáš. Podmínka se kontroluje **před** provedením bloku.

```csharp
while (podmínka)
{
    // kód
}
```

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

### do-while – cyklus s podmínkou na konci

> 🥄 **Přirovnání**: Jako **ochutnání před nákupem** – nejdřív ochutnáš (blok se vždy provede), teprve pak se ptáš „chci ještě?“ (podmínka na konci).

```csharp
do
{
    // kód
} while (podmínka);
```

```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);
```

### foreach – průchod kolekcí

> 📦 **Přirovnání**: Jako **procházení nákupního seznamu** – bereš jeden prvek za druhým, nemusíš řešit indexy.

```csharp
foreach (typ prvek in kolekce)
{
    // kód
}
```

```csharp
int[] pole = { 10, 20, 30 };
foreach (int cislo in pole)
{
    Console.WriteLine(cislo);  // 10, 20, 30
}
```

---

## Vývojový diagram cyklu (while)

> 📐 **Přirovnání**: Tok programu – začátek, kontrola podmínky, buď provedení bloku a návrat, nebo konec.

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
            ╱───────────╲
           ╱  Podmínka?  ╲ ◀──────────────────┐
          ╱               ╲                    │
          ╲               ╱                    │
           ╲─────────────╱                     │
         False│       │True                    │
              │       │                        │
              │       ▼                        │
              │  ┌────────────┐                │
              │  │ Blok kódu  │────────────────┘
              │  └────────────┘
              │
              ▼
        ╭─────────╮
        │   End   │
        ╰─────────╯
```

### Vývojový diagram cyklu for

```
            ╭─────────╮
            │  Start  │
            ╰────┬────╯
                 │
                 ▼
         ┌──────────────┐
         │ Inicializace │  (např. i = 0)
         └──────┬───────┘
                │
                ▼
           ╱───────────╲
          ╱  i < 5 ?    ╲ ◀────────────────────┐
         ╱               ╲                     │
         ╲               ╱                     │
          ╲─────────────╱                      │
        False│       │True                     │
             │       │                         │
             │       ▼                         │
             │  ┌────────────┐                 │
             │  │ Blok kódu  │                 │
             │  └──────┬─────┘                 │
             │         │                        │
             │         ▼                        │
             │  ┌────────────┐                  │
             │  │ Iterace    │  (např. i++)     │
             │  └──────┬─────┘                  │
             │         │                        │
             │         └────────────────────────┘
             │
             ▼
       ╭─────────╮
       │   End   │
       ╰─────────╯
```

---

## Rozdíly mezi cykly

| Cyklus | Kdy použít | Kontrola podmínky | Typické použití |
| ------ | ---------- | ----------------- | ---------------- |
| **for** | Známý počet iterací předem | Na začátku každé iterace | Procházení pole po indexech, opakování N× |
| **while** | Neurčitý počet iterací | Na začátku každé iterace | Čtení vstupu, čekání na událost |
| **do-while** | Alespoň jedna iterace nutná | Na konci každé iterace | Menu, validace vstupu |
| **foreach** | Procházení kolekcí | Implicitní (konec kolekce) | Pole, seznamy – přímý přístup k hodnotám |

```
┌─────────────────────────────────────────────────────────────────┐
│  ROZDÍLY CYKLŮ                                                   │
│                                                                 │
│   for          →  "Vím, že to udělám 10×"                       │
│   while        →  "Nevím kolikrát, dokud platí podmínka"         │
│   do-while     →  "Aspoň jednou, pak se ptám"                   │
│   foreach      →  "Projdi všechny prvky, neřeš indexy"           │
└─────────────────────────────────────────────────────────────────┘
```

---

## Vztah cyklu a pole

> 🔗 **Přirovnání**: Pole je **řada krabic**. Cyklus je **postup**, jak projít jednu krabici za druhou – buď po indexu (for), nebo přímo hodnoty (foreach).

- **for + index**: Máš přístup k indexu – můžeš měnit prvky, pracovat s pozicí.

```csharp
int[] pole = { 10, 20, 30 };
for (int i = 0; i < pole.Length; i++)
{
    pole[i] = pole[i] * 2;  // můžeme měnit
    Console.WriteLine($"Index {i}: {pole[i]}");
}
```

- **foreach**: Jen čteš hodnoty, nemáš index. Jednodušší zápis, nemůžeš měnit prvky přímo (u hodnotových typů).

```csharp
int[] pole = { 10, 20, 30 };
foreach (int cislo in pole)
{
    Console.WriteLine(cislo);  // jen čtení, číslo je kopie
}
```

| Přístup | Výhoda | Nevýhoda |
| ------- | ------ | -------- |
| **for + index** | Můžeš měnit prvky, znáš pozici | Více kódu |
| **foreach** | Jednoduchý zápis, čitelný | Nemáš index, u hodnotových typů jen čtení |

---

## Nekonečný cyklus a jeho nebezpečí

> ♾️ **Přirovnání**: Jako **běh bez cíle** – podmínka nikdy není false, cyklus nikdy neskončí (pokud ho neukončíš `break` nebo Ctrl+C).

- **Definice**: Cyklus, jehož podmínka je vždy splněna – program v něm zůstane navždy.

```csharp
// Typický nekonečný cyklus
while (true)
{
    Console.WriteLine("Nikdy neskončím!");
    // break;  // bez break by to běželo věčně
}
```

**Kdy může vzniknout omylem:**
- Špatná podmínka: `while (i < 10)` ale `i` se nikdy nezvyšuje
- Chyba v iteraci: `for (int i = 0; i < 10; i--)` – i klesá, nikdy nedosáhne 10

### Nebezpečí nekonečného cyklu

| Nebezpečí | Co se stane |
| --------- | ----------- |
| **Zatížení CPU** | Procesor běží na 100 % – počítač se zpomalí, ventilátory hlučně běží |
| **Zamrznutí aplikace** | U GUI programu přestane reagovat okno – uživatel nemůže klikat |
| **Vyčerpání paměti** | Cyklus může neustále alokovat data (seznamy, logy) → OutOfMemoryException |
| **Log spam** | Opakovaný výpis do konzole/souboru zaplní disk |
| **Blokování programu** | Server nebo služba přestane obsluhovat další požadavky |

### Jak se bránit

- Kontrolovat, že se **čítač nebo podmínka mění** směrem k ukončení
- U `while (true)` mít vždy **podmínku s `break`** (např. platný vstup, konec souboru)
- Při ladění použít **breakpoint** a sledovat hodnotu proměnné v podmínce
- U dlouhých cyklů zvažovat **timeout** nebo limit počtu iterací

---

## Příklady užití cyklů

### 1. for – sečtení prvků pole

```csharp
int[] pole = { 1, 2, 3, 4, 5 };
int suma = 0;

for (int i = 0; i < pole.Length; i++)
{
    suma += pole[i];
}

Console.WriteLine($"Součet: {suma}");  // 15
```

### 2. while – čtení vstupu, dokud není platný

```csharp
int cislo;
Console.Write("Zadej číslo: ");

while (!int.TryParse(Console.ReadLine(), out cislo))
{
    Console.WriteLine("Neplatný vstup, zkus znovu:");
}

Console.WriteLine($"Zadal jsi: {cislo}");
```

### 3. do-while – menu

```csharp
int volba;
do
{
    Console.WriteLine("1. Nová hra");
    Console.WriteLine("2. Nastavení");
    Console.WriteLine("0. Konec");
    volba = int.Parse(Console.ReadLine());

    switch (volba)
    {
        case 1: /* ... */ break;
        case 2: /* ... */ break;
    }
} while (volba != 0);
```

### 4. foreach – výpis všech položek

```csharp
string[] jmena = { "Anna", "Petr", "Marie" };

foreach (var jmeno in jmena)
{
    Console.WriteLine(jmeno);
}
```

### 5. break a continue

```csharp
// break – ukončí cyklus při první nule
for (int i = 0; i < 10; i++)
{
    if (pole[i] == 0)
        break;  // okamžitě ven
    Console.WriteLine(pole[i]);
}

// continue – přeskočí sudá čísla
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
        continue;  // přeskoč na další iteraci
    Console.WriteLine(i);  // vypíše jen lichá
}
```

---

## Shrnutí

- **Cykly** – opakované provádění bloku kódu podle podmínky.
- **for** – pevný počet iterací, čítač. **while** – podmínka na začátku. **do-while** – podmínka na konci, alespoň 1×. **foreach** – průchod kolekcí.
- **Vývojový diagram** – diamant = podmínka, obdélník = blok, šipka zpět = opakování.
- **Pole + cyklus** – `for` pro indexování a změny, `foreach` pro čtení hodnot.
- **Nekonečný cyklus** – podmínka nikdy false; nebezpečí: CPU 100 %, zamrznutí, vyčerpání paměti. Prevence: správná podmínka, `break`, ladění.

---

## Materiály od učitele

Sekce vychází z `Opakovani.txt`.

- Přehled forem opakování: `foreach`, `while`, `do-while`, `for`, plus rekurze.
- `foreach` je nejjednodušší pro průchod kolekcí, ale bez explicitního indexu.
- `while` je vhodné, když neznáme počet iterací dopředu; `do-while` běží alespoň jednou.
- Řízení toku: `break` (okamžité ukončení), `continue` (přeskočení iterace), `return` (ukončení metody).
- Rekurze je alternativa cyklu, ale vyžaduje ukončovací podmínku kvůli riziku přetečení zásobníku.

### Pro ty, co chtej vedet vic

- [Opakovani.txt](Materialy/Opakovani.txt)
