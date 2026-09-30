# 23. Operační systémy

> Vyjmenujte několik nejpoužívanějších typů operačních systémů. Jaká je role operačního systému v počítači? Co je to multitasking? Popište odlišnosti mezi operačními systémy určené pro PC a pro mobilní zařízení. Příklad.

---

## 📖 Slovníček pojmů


| Pojem                    | Co to je                                              | Příklad z reálného světa                  |
| ------------------------ | ----------------------------------------------------- | ----------------------------------------- |
| **Operační systém (OS)** | Základní software, který řídí hardware a běh programů | Windows, Linux, Android                   |
| **Proces**               | Běžící instance programu                              | Otevřený prohlížeč jako samostatný proces |
| **Multitasking**         | Současné zpracování více úloh                         | Hudba hraje, zároveň píšeš dokument       |
| **Jádro (kernel)**       | Nejnižší část OS komunikující přímo s hardwarem       | Správa paměti a CPU plánování             |
| **Ovladač (driver)**     | Software pro komunikaci OS s konkrétním zařízením     | Ovladač tiskárny, grafické karty          |


---

## Nejčastější operační systémy

### Pro PC / servery

- **Windows**
- **Linux** (Ubuntu, Debian, Fedora...)
- **macOS**

### Pro mobilní zařízení

- **Android**
- **iOS**

---

## Linux do hloubky: kernel vs distribuce

- **Linux** v přesném smyslu slova označuje hlavně **jádro (kernel)**.
- To, co uživatel běžně instaluje jako „Linux“, je ve skutečnosti **distribuce**:
  - kernel + systémové nástroje (často GNU) + správce balíčků + služby + desktopové prostředí.
- Proto se liší Ubuntu, Debian, Fedora nebo Arch - používají stejný (nebo velmi podobný) kernel, ale odlišné „okolí“.

Příklad:
- **Kernel** řeší plánování procesů, paměť, ovladače.
- **Distribuce** řeší uživatelský komfort: instalaci programů, výchozí nastavení, aktualizační model.

---

## Role operačního systému

Operační systém je prostředník mezi hardwarem a aplikacemi. Zajišťuje:

- správu procesoru (plánování úloh),
- správu paměti (alokace RAM),
- správu souborového systému,
- správu vstupních/výstupních zařízení přes ovladače,
- uživatelské rozhraní a bezpečnost (účty, práva, izolace).

Bez OS by uživatel musel řešit hardware velmi nízkoúrovňově.

### Vrstvy OS (zjednodušeně)

1. **Hardware** - CPU, RAM, disk, síť.
2. **Kernel** - přímá správa zdrojů a ochrana systému.
3. **Systémové služby a knihovny** - API pro aplikace.
4. **Aplikace a UI** - to, s čím pracuje uživatel.

---

## Co je multitasking

- **Multitasking** je schopnost OS obsluhovat více procesů „najednou“.
- V praxi OS rychle střídá úlohy (time slicing), takže uživatel má dojem paralelního běhu.
- Na vícejádrových CPU se část úloh opravdu vykonává paralelně.

Typy:

- **Preemptivní multitasking** - OS rozhoduje, kdy proces dostane CPU (dnes standard).
- **Kooperativní multitasking** - procesy si CPU „předávají“ dobrovolně (historicky).

---

## PC vs mobilní OS


| Oblast                 | PC OS                         | Mobilní OS                         |
| ---------------------- | ----------------------------- | ---------------------------------- |
| **Ovládání**           | Klávesnice/myš, více oken     | Dotyk, gesta, menší obrazovka      |
| **Správa aplikací**    | Volnější běh na pozadí        | Agresivnější omezení kvůli baterii |
| **Hardware**           | Velká variabilita konfigurací | Více uzavřený ekosystém            |
| **Instalace software** | Různé zdroje instalace        | Hlavně oficiální store             |
| **Spotřeba energie**   | Menší tlak na úsporu          | Velký důraz na baterii             |


---

## Příklad v praxi

Na notebooku s Windows:

1. Uživatel píše dokument.
2. Na pozadí běží synchronizace cloudového disku.
3. Prohlížeč přehrává hudbu.
4. OS plánuje procesy, přiděluje RAM a přes ovladače obsluhuje WiFi, zvuk i displej.

---

## Shrnutí

- OS je klíčový software, který řídí hardware i běh aplikací.
- Nejčastější OS: Windows, Linux, macOS, Android, iOS.
- Multitasking umožňuje současnou práci s více úlohami.
- Mobilní OS jsou více optimalizované na dotyk, bezpečnost ekosystému a výdrž baterie.

---

## Materiály od učitele

Učitelský podklad cílí praktickou část na simulaci plánovače procesů (scheduler).

### Pro ty, co chtej vedet vic

- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)

