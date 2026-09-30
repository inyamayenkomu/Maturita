# 2. Základní principy a pojmy OOP

> Definujte pojmy třída, objekt, abstrakce, zapouzdření, datový člen, metoda, konstruktor, dědičnost, polymorfismus. Popište způsob komunikace mezi objekty, uveďte příklad. Srovnejte objektově orientované a procedurální programování.

---

## 📖 Slovníček pojmů


| Pojem                         | Co to je                                            | Příklad z reálného světa                                      |
| ----------------------------- | --------------------------------------------------- | ------------------------------------------------------------- |
| **Instance**                  | Konkrétní vytvořený objekt z třídy                  | Konkrétní auto z výrobní linky (ne plánek)                    |
| **Rodičovská třída (base)**   | Třída, ze které jiná třída dědí                     | Obecný recept – základ pro specializované recepty             |
| **Potomková třída (derived)** | Třída, která dědí z jiné třídy                      | Recept na čokoládový dort – rozšíření základního receptu      |
| **Přepsání (override)**       | Nahrazení metody z rodiče vlastní implementací      | Potomek si upraví recept podle sebe                           |
| **Přístupový modifikátor**    | Určuje, kdo může přistupovat k členu třídy          | Zámek na dveřích – private = jen já, public = všichni         |
| **Zpráva (message)**          | Volání metody na objektu – „požadavek“ něco udělat  | „Zazvoň!“ – voláš metodu Zazvonit() na objektu Zvon           |
| **Stav objektu**              | Souhrn hodnot všech datových členů v daném okamžiku | Fotka auta – barva, rychlost, stav paliva – v jednom okamžiku |


---

## Základní pojmy

### Třída

> 🏗️ **Přirovnání**: Třída je jako **modrák (plán) domu**. Není to samotný dům – je to jen popis, jak má dům vypadat, jaké má mít místnosti, co v nich bude. Z jednoho plánu můžeš postavit mnoho domů.

- **Definice**: Šablona nebo návrh definující vlastnosti (datové členy) a chování (metody) pro objekty

```
┌─────────────────────────────────────────────────────────┐
│                    TŘÍDA (šablona)                      │
│                                                         │
│   class Auto {                                          │
│       string barva;      ◀── datové členy (vlastnosti)  │
│       int rychlost;                                     │
│                                                         │
│       void Zrychli() { } ◀── metody (chování)           │
│       void Zastav() { }                                 │
│   }                                                     │
│                                                         │
│   Plán = "co má auto mít" + "co má auto umět"           │
└─────────────────────────────────────────────────────────┘
```

- **Vlastnosti třídy**:
  - **Datové členy** – popisují stav (barva, rychlost) – „co objekt má“
  - **Metody** – popisují chování (Zrychli, Zastav) – „co objekt umí“
  - Třída sama o sobě nic nedělá – musíš z ní vytvořit objekty

### Objekt

> 🚗 **Přirovnání**: Objekt je jako **konkrétní auto** postavené podle plánu. Třída je plán, objekt je skutečné auto. Můžeš mít mnoho aut ze stejného plánu – každé jiné barvy, jiné rychlosti.

- **Definice**: Konkrétní instance třídy vytvořená za běhu programu

```
┌─────────────────────────────────────────────────────────┐
│  TŘÍDA Auto              OBJEKTY (instance)             │
│                                                         │
│  ┌──────────────┐       ┌────────────┐ ┌────────────┐   │
│  │  ŠABLONA     │       │ auto1      │ │ auto2      │   │
│  │  barva       │  ──▶  │ barva: č.  │ │ barva: m.  │   │
│  │  rychlost    │       │ rychlost:0 │ │ rychlost:50│   │
│  │  Zrychli()   │       └────────────┘ └────────────┘   │
│  │  Zastav()    │       Jedno auto     Druhé auto       │
│  └──────────────┘       (červené)     (modré)           │
└─────────────────────────────────────────────────────────┘
```

```csharp
// Třída = plán
class Auto
{
    public string barva;
    public int rychlost;
}

// Objekty = konkrétní auta
Auto mojeAuto = new Auto();        // mojeAuto je objekt
mojeAuto.barva = "červená";
mojeAuto.rychlost = 0;

Auto kamaradovoAuto = new Auto();  // další objekt
kamaradovoAuto.barva = "modrá";
```

### Abstrakce

> 🎯 **Přirovnání**: Abstrakce je jako **mapa města**. Mapa neobsahuje každý kámen na chodníku – zobrazuje jen důležité (ulice, budovy). Zjednodušuje realitu tak, aby byla použitelná.

- **Definice**: Zjednodušení reality pomocí izolace podstatných vlastností a ignorace detailů

```
┌─────────────────────────────────────────────────────────┐
│  ABSTRAKCE = Zjednodušení reality                       │
│                                                         │
│   SKUTEČNÉ AUTO              ABSTRAKCE (v programu)     │
│   ┌─────────────────┐       ┌─────────────────┐         │
│   │ miliony šroubků  │      │ barva           │         │
│   │ tisíce drátů     │  ──▶ │ rychlost        │         │
│   │ chemie motoru    │      │ Zrychli()       │         │
│   │ fyzika pneumatik │      │ Zastav()        │         │
│   └─────────────────┘       └─────────────────┘         │
│                                                         │
│   Bereme jen TO, co potřebujeme pro řešení problému     │
└─────────────────────────────────────────────────────────┘
```

- **Proč abstrakce**:
  - Zvládneme složité systémy – nemusíme řešit vše
  - Zaměřujeme se na podstatné – „co auto umí?“, ne „jak funguje karburátor“
  - Každá úroveň může mít jinou abstrakci – řidič vidí volant, mechanik vidí motor

### Zapouzdření (Encapsulation)

> 🔒 **Přirovnání**: Zapouzdření je jako **trezor v bance**. Peníze jsou uvnitř (private), nikdo k nim nemůže přímo. Měl bys jít přes bankomát (veřejnou metodu), který kontroluje, co se děje – ne rozbíjet trezor.

- **Definice**: Skrytí vnitřní implementace a ochrana dat pomocí přístupových modifikátorů (private, public)

```
┌─────────────────────────────────────────────────────────┐
│  ZAPOUZDŘENÍ = Skrytí vnitřku, veřejné rozhraní         │
│                                                         │
│   ┌─────────────────────────────────────────┐           │
│   │  OBJEKT BankovníUcet                    │           │
│   │                                         │           │
│   │  ┌──────────────────────────────────┐   │           │
│   │  │  private double zustatek; SKRYTÉ │   │           │
│   │  │  (přímý přístup ZAKÁZÁN)         │   │           │
│   │  └──────────────────────────────────┘   │           │
│   │                                         │           │
│   │  ┌──────────────────────────────────┐   │           │
│   │  │  public void Vloz(double castka) │   │ VEŘEJNÉ   │
│   │  │  public double ZjistiZustatek()  │   │ (brána)   │
│   │  └──────────────────────────────────┘   │           │
│   └─────────────────────────────────────────┘           │
│                                                         │
│   Vnější kód: ucet.Vloz(100); ✓  ucet.zustatek=-100; ✗  │
└─────────────────────────────────────────────────────────┘
```

```csharp
class BankovníUcet
{
    private double zustatek;  // private = skryté, nelze přistupovat zvenčí

    public void Vloz(double castka)
    {
        if (castka > 0)  // kontrola – můžeme validovat data
            zustatek += castka;
    }

    public double ZjistiZustatek()
    {
        return zustatek;
    }
}
```

- **Přístupové modifikátory**:
  - `private` – pouze uvnitř třídy, nikdo zvenčí
  - `public` – kdokoliv může přistupovat
  - `protected` – třída + potomci (v dědičnosti)

### Datový člen

> 📦 **Přirovnání**: Datový člen je jako **políčko v dotazníku**. Každý objekt má svou kopii – „jméno“, „věk“, „adresa“. Uchovává stav objektu.

- **Definice**: Proměnná definovaná uvnitř třídy pro uchovávání stavu objektu

```
┌─────────────────────────────────────────────────────────┐
│  DATOVÉ ČLENY = Stav objektu                            │
│                                                         │
│   class Student {                                       │
│       string jmeno;     ◀── datový člen                 │
│       int vek;          ◀── datový člen                 │
│       double prumer;    ◀── datový člen                 │
│   }                                                     │
│                                                         │
│   Každý objekt Student má vlastní jmeno, vek, prumer    │
│   student1: jmeno="Petr", vek=18, prumer=1.5            │
│   student2: jmeno="Anna", vek=17, prumer=2.0            │
└─────────────────────────────────────────────────────────┘
```

### Metoda

> 🎬 **Přirovnání**: Metoda je jako **akce, kterou objekt umí**. Auto umí „Zrychli“, „Zastav“. Student umí „OdevzdatÚkol“. Metoda popisuje chování.

- **Definice**: Funkce definovaná uvnitř třídy popisující chování objektu

```
┌─────────────────────────────────────────────────────────┐
│  METODA = Chování objektu                               │
│                                                         │
│   class Auto {                                          │
│       int rychlost;                                     │
│                                                         │
│       void Zrychli() { rychlost += 10; }  ◀── metoda    │
│       void Zastav() { rychlost = 0; }     ◀── metoda    │
│       void Zazvon() { ... }              ◀── metoda     │
│   }                                                     │
│                                                         │
│   auto.Zrychli();  ◀── volání metody = "udělej tohle"   │
└─────────────────────────────────────────────────────────┘
```

### Konstruktor

> 🏭 **Přirovnání**: Konstruktor je jako **pracovník na výrobní lince**. Když vytváříš nové auto (new Auto()), konstruktor ho „sestaví“ – nastaví výchozí hodnoty, připraví ho do provozu.

- **Definice**: Speciální metoda pro inicializaci objektu při jeho vytváření

```
┌─────────────────────────────────────────────────────────┐
│  KONSTRUKTOR = Inicializace při vytvoření               │
│                                                         │
│   new Auto()  ──▶  [Konstruktor se automaticky zavolá]  │
│                         │                               │
│                         ▼                               │
│   ┌─────────────────────────────────────────┐           │
│   │  Auto() {                               │           │
│   │      barva = "bílá";   // výchozí       │           │
│   │      rychlost = 0;     // výchozí       │           │
│   │  }                                      │           │
│   └─────────────────────────────────────────┘           │
│                         │                               │
│                         ▼                               │
│   Objekt je připraven k použití                         │
└─────────────────────────────────────────────────────────┘
```

```csharp
class Auto
{
    public string barva;
    public int rychlost;

    // Konstruktor – jméno = jméno třídy, žádný návratový typ
    public Auto()
    {
        barva = "bílá";
        rychlost = 0;
    }

    // Konstruktor s parametry – přetížení
    public Auto(string barva)
    {
        this.barva = barva;
        rychlost = 0;
    }
}

Auto a = new Auto();           // zavolá Auto() → bílá, 0
Auto b = new Auto("červená");  // zavolá Auto(string) → červená, 0
```

### Dědičnost

> 👨‍👩‍👧 **Přirovnání**: Dědičnost je jako **rodina**. Rodič má vlastnosti (má oči, ruce). Dítě je zdědí – nemusíš je znovu popisovat. Dítě může přidat něco vlastního (umí programovat) nebo něco změnit (override).

- **Definice**: Mechanismus, kdy třída (potomek) přebírá vlastnosti a metody z jiné třídy (rodič)

```
┌─────────────────────────────────────────────────────────────────┐
│  DĚDIČNOST = Potomek přebírá od rodiče                          │
│                                                                 │
│   ┌─────────────────────┐                                       │
│   │  Zvire (rodič)      │                                       │
│   │  - jmeno            │                                       │
│   │  - Zvuk()           │                                       │
│   └──────────┬──────────┘                                       │
│              │ dědí                                             │
│     ┌────────┴────────┐                                         │
│     ▼                 ▼                                         │
│   ┌──────────┐    ┌──────────┐                                  │
│   │ Pes      │    │ Kocka    │  ◀── přidávají vlastní chování   │
│   │ - štěká  │    │ - mňouká │      nebo vlastnosti             │
│   └──────────┘    └──────────┘                                  │
│                                                                 │
│   Pes i Kocka mají jmeno (zděděno) + vlastní Zvuk() (přepsáno)  │
└─────────────────────────────────────────────────────────────────┘
```

```csharp
class Zvire
{
    public string jmeno;
    public virtual void Zvuk() { Console.WriteLine("..."); }
}

class Pes : Zvire  // Pes dědí od Zvire
{
    public override void Zvuk() { Console.WriteLine("Haf!"); }
}

class Kocka : Zvire
{
    public override void Zvuk() { Console.WriteLine("Mňau!"); }
}
```

### Polymorfismus

> 🎭 **Přirovnání**: Polymorfismus je jako **„Zazpívej!“** – každému řekneš jinak. Když řekneš zpěvákovi, zazpívá. Když řekneš ptákovi, zazpívá jinak. Stejné volání, různé chování podle toho, kdo to je.

- **Definice**: Schopnost objektu použít metodu definovanou v rodičovské třídě s vlastní implementací

```
┌─────────────────────────────────────────────────────────────────┐
│  POLYMORFISMUS = Stejné volání, různé chování                   │
│                                                                 │
│   Zvire z = new Pes();   // z ukazuje na objekt typu Pes        │
│   z.Zvuk();              // volá se Pes.Zvuk() → "Haf!"         │
│                                                                 │
│   Zvire z2 = new Kocka();                                       │
│   z2.Zvuk();             // volá se Kocka.Zvuk() → "Mňau!"      │
│                                                                 │
│   ┌───────────────────────────────────────────────┐             │
│   │  Zvire[] zvirata = { new Pes(), new Kocka() };│             │
│   │  foreach (var z in zvirata)                   │             │
│   │      z.Zvuk();   // každé "zazpívá" jinak.    │             │
│   └───────────────────────────────────────────────┘             │
│                                                                 │
│   Výstup: Haf!  Mňau!                                           │
└─────────────────────────────────────────────────────────────────┘
```

```csharp
Zvire z = new Pes();
z.Zvuk();  // "Haf!" – polymorfismus: volá se Pes implementace

Zvire z2 = new Kocka();
z2.Zvuk();  // "Mňau!" – volá se Kocka implementace
```

### Virtual a override (virtuální funkce)

> 🔑 **Přirovnání**: `virtual` je jako **otevřená brána** – říkáš potomkům „můžeš si to přepsat“. Bez `virtual` by potomek nemohl metodu přepsat a při volání `z.Zvuk()` by se vždy zavolala verze z rodiče.

- **Virtual** – klíčové slovo v rodičovské třídě. Označuje metodu, kterou může potomková třída přepsat (override). Bez `virtual` by polymorfismus nefungoval – kompilátor by vždy zavolal metodu podle typu proměnné (Zvire), ne podle skutečného objektu (Pes/Kocka).

- **Override** – klíčové slovo v potomkovi. Říká „nahrazuji implementaci z rodiče vlastní“. Metoda musí mít stejnou signaturu (název, parametry, návratový typ).

```csharp
// BEZ virtual – polymorfismus nefunguje
class Zvire
{
    public void Zvuk() { Console.WriteLine("..."); }  // bez virtual
}
class Pes : Zvire
{
    public void Zvuk() { Console.WriteLine("Haf!"); }  // skryje, ale nepřepíše
}
Zvire z = new Pes();
z.Zvuk();  // Výstup: "..."  ← volá se Zvire.Zvuk(), ne Pes.Zvuk()!

// S virtual + override – polymorfismus funguje
class Zvire
{
    public virtual void Zvuk() { Console.WriteLine("..."); }
}
class Pes : Zvire
{
    public override void Zvuk() { Console.WriteLine("Haf!"); }
}
Zvire z = new Pes();
z.Zvuk();  // Výstup: "Haf!"  ← volá se Pes.Zvuk(), správně!
```

- **Shrnutí**: `virtual` umožňuje pozdní vazbu (late binding) – až za běhu programu se rozhodne, která implementace se zavolá, podle skutečného typu objektu.

---

## Komunikace mezi objekty

> 📞 **Přirovnání**: Objekty spolu komunikují jako **lidé po telefonu**. Jeden objekt „zavolá“ druhému – volá jeho metodu. To je posílání zprávy (message passing). „Objekte Studente, odevzdej úkol!“ = `student.OdevzdatUkol();`

- **Definice**: Objekty spolu komunikují voláním metod (posíláním zpráv). Jeden objekt volá metodu druhého objektu.

```
┌─────────────────────────────────────────────────────────────────┐
│  KOMUNIKACE MEZI OBJEKTY = Volání metod                         │
│                                                                 │
│   ┌──────────────┐                    ┌──────────────┐          │
│   │   Učitel     │                    │   Student    │          │
│   │              │  OdevzdatUkol()    │              │          │
│   │  Zadej() ────┼───────────────────▶│  OdevzdatUkol│          │
│   │              │  "zpráva"          │  ()          │          │
│   └──────────────┘                    └──────────────┘          │
│                                                                 │
│   Učitel volá: student.OdevzdatUkol();                          │
│   = "Objekte Studente, odevzdej úkol!"                          │
└─────────────────────────────────────────────────────────────────┘
```

### Příklad komunikace

```csharp
class Ucitel
{
    public void Zadej(Student student)
    {
        // Učitel komunikuje se studentem – volá jeho metodu
        student.OdevzdatUkol();
    }
}

class Student
{
    public void OdevzdatUkol()
    {
        Console.WriteLine("Úkol odevzdán.");
    }
}

// Použití
Ucitel ucitel = new Ucitel();
Student student = new Student();
ucitel.Zadej(student);  // volá student.OdevzdatUkol(); → "Úkol odevzdán."
```

---

## Srovnání OOP a procedurálního programování

> 🏗️ **Přirovnání**: Procedurální je jako **otevřená kuchyně** – vše je na jednom místě, funkce a data jsou oddělené. OOP je jako **restaurace s oddělenými kuchyněmi** – každá třída má vlastní data a metody pohromadě, uzavřené v sobě.

```
┌─────────────────────────────────────────────────────────────────┐
│  PROCEDURÁLNÍ vs OOP                                            │
│                                                                 │
│   PROCEDURÁLNÍ                      OOP                         │
│   ┌─────────────────┐               ┌─────────────────┐         │
│   │ Data (globální) │               │  class Auto     │         │
│   │ int rychlost    │               │  {              │         │
│   │ string barva    │               │    int rychlost;│         │
│   └────────┬────────┘               │    string barva;│         │
│            │                        │    Zrychli() {} │         │
│   ┌────────▼────────┐               │  }              │         │
│   │ Funkce (odděl.) │               │  data + metody  │         │
│   │ Zrychli()       │               │  POHROMADĚ      │         │
│   │ Zastav()        │               └─────────────────┘         │
│   └─────────────────┘                                           │
│                                                                 │
│   Data a funkce oddělené         Data a funkce v jedné jednotce │
└─────────────────────────────────────────────────────────────────┘
```

### Stejný problém – dva přístupy

> 📝 **Příklad**: Správa bankovního účtu – vložení peněz a kontrola zůstatku.

**Procedurální styl** – data a funkce žijí odděleně. Musíš předávat účet do každé funkce. Kdokoliv může změnit `zustatek` přímo (i na -1000).

```csharp
// Globální nebo předávaná data
double zustatek = 0;

void Vloz(double castka) {
    if (castka > 0) zustatek += castka;
}
double ZjistiZustatek() {
    return zustatek;
}

// Problém: zustatek = -500;  ← nikdo to nehlídá!
```

**OOP styl** – data jsou uvnitř objektu, chráněná. Přistupuješ jen přes metody, které mohou kontrolovat vstupy.

```csharp
class BankovniUcet {
    private double zustatek = 0;  // skryté, nelze změnit zvenčí
    public void Vloz(double castka) {
        if (castka > 0) zustatek += castka;
    }
    public double ZjistiZustatek() { return zustatek; }
}

// ucet.zustatek = -500;  ← KOMPILÁTOR ZAKÁŽE! Bezpečné.
```

### Kdy co použít?

> 🎯 **Procedurální** – když máš **jednoduchý skript**: načti data → zpracuj → ulož. Např. převod souboru, jednorázový výpočet, malé utility. Rychlé napsat, přehledné pro krátké programy.

> 🏢 **OOP** – když buduješ **systém s mnoha entitami**: uživatelé, objednávky, produkty, platby… Každá entita má svá data a chování. OOP ti dá strukturu, zapouzdření a možnost rozšiřovat bez rozbíjení existujícího kódu.

### Proč OOP škáluje lépe?

- **Zapouzdření** – změna uvnitř třídy neovlivní zbytek programu. Měníš implementaci `BankovniUcet`, ne volající kód.
- **Dědičnost** – přidáš `SporiciUcet : BankovniUcet` s úroky – zdědíš Vloz(), ZjistiZustatek() a přidáš jen to nové.
- **Polymorfismus** – můžeš mít pole `BankovniUcet[]` s mixem běžných a spořicích účtů a volat na všech stejně – každý si to vyřeší sám.

### Tabulka srovnání

| Vlastnost             | Procedurální programování                        | Objektově orientované (OOP)                              |
| --------------------- | ------------------------------------------------ | -------------------------------------------------------- |
| **Organizace**        | Zaměřeno na funkce a operace s daty              | Organizuje kód kolem objektů kombinujících data a metody |
| **Data a funkce**     | Jsou to oddělené entity – data (globální/parametry) existují samostatně, funkce jsou jen operace, které je zpracovávají | Jsou pohromadě – objekt drží data i metody; data „patří“ k objektu, ne k volně plovoucím funkcím |
| **Hierarchie**        | Řeší se skrze volání funkcí                      | Dědičnost – třídy dědí od sebe                           |
| **Zapouzdření**       | Obvykle slabé – data často přístupná všude        | Silné – private, public, protected                       |
| **Opakované použití** | Kopírování funkci, úpravy                         | Dědičnost, polymorfismus – rozšiřování bez kopírování    |
| **Vhodné pro**        | Jednoduché lineární úlohy, skripty, utility      | Komplexní systémy, velké projekty, týmová práce           |

### Shrnutí

- **OOP**: Důraz na zapouzdření, dědičnost, polymorfismus. Objekty = data + chování. Lépe zvládá komplexní systémy, opakované použití kódu a práci v týmu – každý může pracovat na své třídě.
- **Procedurální**: Zaměřeno na funkce. Data a funkce oddělené. Vhodnější pro jednoduché lineární úlohy, skripty a rychlé prototypy. Méně „overheadu“, ale hůř se škáluje.

---

## Materiály od učitele

Tato sekce sjednocuje podklady: `ObjektyATridy.txt`, `ObjektyATridy 1.txt`, `ObjektyATridy 2.txt`, `ObjektyATridyPokracovani.txt`, `ObjektyATridyPokracovani 1.txt`, `Generika.txt`, `Struktury.txt`, `ZivotObjektu.txt`.

### Objekty a třídy

- OOP modeluje systém přes třídy (šablony) a objekty (instance).
- Klíčové principy: zapouzdření, dědičnost, polymorfismus, kompozice.
- `static` člen patří třídě, ne instanci.

### Varianta: `ObjektyATridy 1.txt`

- Důraz na roli statických tříd jako schránek pro pomocné metody.
- Rozšíření zapouzdření o testovatelnost a konzistenci interního stavu.
- Přímé srovnání s dalšími paradigmaty (procedurální/funkcionální).

### Varianta: `ObjektyATridy 2.txt`

- Doplňuje omezení C#: jedna třída má jen jednoho předka.
- Rozšiřuje vztah dědičnosti o praktické důsledky (co jde a nejde při typové substituci).

### Varianta: `ObjektyATridyPokracovani.txt`

- Podrobně rozlišuje field vs property (`get`/`set`, omezení zápisu).
- Zavádí abstraktní třídy, `virtual`/`override` a rozhraní.
- Ukazuje implementaci více rozhraní v jedné třídě.

### Varianta: `ObjektyATridyPokracovani 1.txt`

- Navazuje na předchozí variantu a doplňuje typ `object`, boxing a unboxing.
- Prakticky propojuje OOP koncepty s typovým systémem C#.

### Generika, struktury a životní cyklus

- `Generika.txt`: generické typy/metody (`T`) pro znovupoužitelný a typově bezpečný kód.
- `Struktury.txt`: `struct` jako hodnotový typ, předávání kopií.
- `ZivotObjektu.txt`: vznik objektu přes `new`, zánik řeší GC (garbage collector), ne ruční `delete`.

### Pro ty, co chtej vedet vic

- [Generika.txt](Materialy/Generika.txt)
- [ObjektyATridy.txt](Materialy/ObjektyATridy.txt)
- [ObjektyATridy 1.txt](Materialy/ObjektyATridy%201.txt)
- [ObjektyATridy 2.txt](Materialy/ObjektyATridy%202.txt)
- [ObjektyATridyPokracovani.txt](Materialy/ObjektyATridyPokracovani.txt)
- [ObjektyATridyPokracovani 1.txt](Materialy/ObjektyATridyPokracovani%201.txt)
- [Struktury.txt](Materialy/Struktury.txt)
- [ZivotObjektu.txt](Materialy/ZivotObjektu.txt)

