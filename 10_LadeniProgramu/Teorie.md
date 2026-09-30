# 10. Ladění programu

> Popište rozdíl mezi syntaktickou a logickou chybou v programu. Co jsou to výjimky a jak se s nimi pracuje? Jak výjimky organizujeme? Vyjmenujte několik typů výjimek. Jaké nástroje se dají použít na ladění chyb v programu?

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Syntaktická chyba** | Chyba v zápisu kódu – program nelze zkompilovat | Chybějící středník, překlep v klíčovém slově |
| **Logická chyba** | Kód je syntakticky správně, ale dává nesprávné výsledky | Špatná podmínka – program běží, ale počítá špatně |
| **Výjimka (Exception)** | Událost přerušující běh programu kvůli chybě | Dělení nulou, přístup k neexistujícímu souboru |
| **Breakpoint** | Místo v kódu, kde se program pozastaví při ladění | Zastavíš se a prohlédneš si stav proměnných |
| **Call Stack** | Hierarchie volání metod – kdo koho zavolal | „Main → MetodaA → MetodaB“ – kde přesně se chyba stala |

---

## Syntaktická vs. logická chyba

> 🔧 **Přirovnání**: **Syntaktická chyba** je jako překlep v receptu – kuchař ani nezačne vařit. **Logická chyba** je jako špatné množství – uvaříš to, ale jídlo je nedobré.

### Syntaktická chyba

- **Definice**: Chyba v zápisu kódu – překladač ji odhalí, program nelze zkompilovat.
- **Příklady**: Chybějící středník, závorka, překlep v klíčovém slově (`retrun` místo `return`).

```csharp
// Syntaktická chyba – chybějící středník
int x = 5
Console.WriteLine(x);  // kompilátor: chyba!

// Syntaktická chyba – překlep
retrun 42;  // mělo být return
```

### Logická chyba

- **Definice**: Kód je syntakticky správně, program se zkompiluje a spustí, ale dává **nesprávné výsledky**.
- **Příklady**: Špatná podmínka v algoritmu, záměna operátorů, špatná inicializace.

```csharp
// Logická chyba – místo "+" je "*"
int Soucet(int a, int b)
{
    return a * b;  // syntakticky OK, ale logicky špatně – mělo být a + b
}

Console.WriteLine(Soucet(3, 5));  // vypíše 15 místo 8
```

| Typ chyby | Kdy se projeví | Kdo ji odhalí |
| --------- | -------------- | ------------- |
| **Syntaktická** | Při kompilaci | Kompilátor |
| **Logická** | Za běhu programu | Tester, uživatel, debugger |

---

## Výjimky a try-catch-finally

> ⚠️ **Přirovnání**: Výjimka je jako **poplach** – něco se pokazilo (dělení nulou, soubor nenalezen), program to nemůže ignorovat a musí to zpracovat nebo spadne.

- **Definice**: Výjimka je událost, která přeruší normální běh programu kvůli chybě. Bez zpracování program skončí s chybovou hláškou.

```csharp
try
{
    // Rizikový kód – může vyhodit výjimku
    int x = 10 / 0;  // DivideByZeroException
}
catch (DivideByZeroException ex)
{
    // Zpracování konkrétní výjimky
    Console.WriteLine("Dělení nulou!");
}
catch (Exception ex)
{
    // Obecné zpracování – zachytí cokoli
    Console.WriteLine($"Chyba: {ex.Message}");
}
finally
{
    // Úklidové akce – vždy se provede (i při výjimce)
    Console.WriteLine("Úklid – zavření souboru, uvolnění zdrojů");
}
```

---

## Jak výjimky organizujeme

> 📁 **Přirovnání**: Organizace výjimek je jako **třídění pošty** – běžná pošta jde do schránky, doporučené do trezoru, neznámé se vrátí odesílateli.

### Hierarchie výjimek

- V C# všechny výjimky dědí z **`Exception`**.
- Obecnější výjimky se chytají **níže**, specifické **výše**:

```csharp
try
{
    // rizikový kód
}
catch (FormatException ex)        // nejdřív specifická
{
    Console.WriteLine("Špatný formát");
}
catch (IOException ex)            // další specifická
{
    Console.WriteLine("Chyba souboru");
}
catch (Exception ex)              // nakonec obecná
{
    Console.WriteLine("Neznámá chyba");
}
```

### Vlastní výjimky

- Pro aplikační chyby lze vytvořit **vlastní třídu** dědící z `Exception`:

```csharp
class NeplatnyVekException : Exception
{
    public NeplatnyVekException(string msg) : base(msg) { }
}
```

### Kdy chytat a kdy nechat probublat

| Přístup | Kdy |
| ------- | --- |
| **Chytit a zpracovat** | Víš, jak chybu opravit nebo uživateli srozumitelně sdělit (např. špatný vstup) |
| **Chytit, zalogovat, znovu vyhodit** | Chceš zaznamenat chybu, ale nechat ji řešit výše (`throw;`) |
| **Nechat probublat** | Metoda neví, co s chybou – nechá ji zpracovat volající vrstvě |

### Logování a `finally`

- **`finally`** – úklid vždy proběhne (zavření souboru, uvolnění zdrojů).
- **Logování** (NLog, Serilog) – záznam výjimek pro pozdější analýzu v produkci.

---

## Typy výjimek v C#

| Výjimka | Kdy vznikne | Příklad |
| ------- | ----------- | ------- |
| **NullReferenceException** | Práce s null objektem | `string s = null; int x = s.Length;` |
| **IndexOutOfRangeException** | Přístup mimo rozsah pole | `int[] p = {1,2}; int x = p[5];` |
| **FormatException** | Neplatný převod řetězce na číslo | `int.Parse("abc");` |
| **IOException** | Chyba při práci se soubory | Soubor neexistuje, není oprávnění |
| **DivideByZeroException** | Dělení nulou | `int x = 10 / 0;` |

```csharp
// NullReferenceException
string text = null;
Console.WriteLine(text.Length);  // crash!

// IndexOutOfRangeException
int[] pole = { 1, 2, 3 };
int hodnota = pole[10];  // crash!

// FormatException
int cislo = int.Parse("nečíslo");  // crash!
```

---

## Nástroje pro ladění

> 🔍 **Přirovnání**: Ladění je jako **detektivní práce** – zastavíš program v podezřelém místě, prohlédneš si důkazy (hodnoty proměnných) a krok za krokem sleduješ, co se děje.

### 1. Breakpointy

- **Co to je**: Místo v kódu, kde se program pozastaví při spuštění v režimu ladění.
- **Jak**: Kliknutí do levého okraje řádku nebo F9. Program se zastaví před provedením daného řádku.

### 2. Krokování

| Příkaz | Zkratka | Co dělá |
| ------ | ------- | ------- |
| **Step Over** | F10 | Provede aktuální řádek, nepůjde do volané metody |
| **Step Into** | F11 | Přejde dovnitř volané metody |
| **Step Out** | Shift+F11 | Dokončí aktuální metodu a vrátí se k volajícímu |

### 3. Watch okno

- Sledování hodnot proměnných za běhu – přidáš výraz (např. `i`, `pole.Length`) a vidíš jeho hodnotu při každém kroku.

### 4. Call Stack

- Zobrazení hierarchie volání – která metoda zavolala kterou. Užitečné při hledání, odkud přišla výjimka.

### 5. Logování

- Záznam chyb a událostí do souboru (NLog, Serilog) – pro analýzu chyb v produkci.

### 6. Unit testy

- Automatické odhalování chyb v izolovaných částech kódu – testy ověří, že metoda vrací očekávaný výsledek.

```
┌─────────────────────────────────────────────────────────┐
│  NÁSTROJE LADĚNÍ                                        │
│                                                         │
│   Breakpoint  →  Zastav program tady                     │
│   Step Over   →  Proveď řádek, nepřejdi do metody        │
│   Step Into   →  Přejdi dovnitř metody                  │
│   Watch       →  Sleduj hodnoty proměnných              │
│   Call Stack  →  Kdo koho zavolal                       │
│   Unit testy  →  Automatická kontrola správnosti        │
└─────────────────────────────────────────────────────────┘
```

---

## Příklad logické chyby

> Klasický příklad – funkce má vracet součet, ale vrací součin. Kompilátor to neodhalí, protože syntaxe je v pořádku.

```csharp
int Soucet(int a, int b)
{
    return a * b;  // CHYBA: mělo být a + b
}

// Test odhalí chybu:
// Soucet(2, 3) očekáváme 5, dostaneme 6
```

**Jak odhalit**: Unit test, ruční testování, nebo debugger – zastavíš se v metodě a sleduješ hodnoty `a` a `b` a výsledek.

---

## Shrnutí

- **Syntaktická chyba** – chyba v zápisu, kompilátor ji odhalí. **Logická chyba** – kód běží, ale dává špatné výsledky.
- **Výjimky** – události přerušující běh (dělení nulou, null, mimo rozsah). Zpracování: `try-catch-finally`.
- **Organizace výjimek** – hierarchie od specifických k obecným, vlastní výjimky, logování, `finally` pro úklid.
- **Typy výjimek** – NullReferenceException, IndexOutOfRangeException, FormatException, IOException, DivideByZeroException.
- **Nástroje** – breakpointy, krokování (Step Into/Over/Out), Watch, Call Stack, logování, unit testy.
- **Příklad logické chyby** – `Soucet` vrací `a * b` místo `a + b` – syntakticky OK, logicky špatně.
