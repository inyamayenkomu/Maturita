# 20. Struktura počítače

> Popište strukturu počítače a komponenty: základní deska, procesor, operační paměť, grafická karta, zvuková karta, síťová karta. Na jakém principu pracuje procesor? Jaké druhy pamětí znáte? Porovnejte stolní počítač, notebook a smartphone. Příklad.

---

## 📖 Slovníček pojmů


| Pojem                            | Co to je                                                | Příklad z reálného světa         |
| -------------------------------- | ------------------------------------------------------- | -------------------------------- |
| **Základní deska (motherboard)** | Hlavní deska propojující všechny komponenty             | Sloty pro RAM, CPU socket, porty |
| **CPU (procesor)**               | Jednotka vykonávající instrukce programu                | Výpočty v aplikacích a hrách     |
| **RAM**                          | Rychlá operační paměť pro právě běžící data             | Otevřené programy v počítači     |
| **GPU (grafická karta)**         | Specializovaný procesor pro grafiku a paralelní výpočty | Render hry nebo videa            |
| **NIC (síťová karta)**           | Umožňuje síťovou komunikaci                             | Ethernet port nebo WiFi modul    |


---

## Základní struktura počítače

Počítač lze zjednodušeně rozdělit na:

- **Vstupní zařízení** (klávesnice, myš, kamera),
- **zpracování dat** (CPU, RAM, GPU),
- **ukládání dat** (SSD/HDD),
- **výstupní zařízení** (monitor, reproduktory),
- **komunikaci** (síťová karta).

> **Přirovnání**: Počítač je jako kancelář - CPU je pracovník, RAM je pracovní stůl, SSD je archiv, základní deska je chodba spojující místnosti.

---

## Komponenty počítače


| Komponenta               | Úloha                                                                                  |
| ------------------------ | -------------------------------------------------------------------------------------- |
| **Základní deska**       | Propojuje komponenty, zajišťuje komunikaci přes sběrnice, obsahuje čipset a BIOS/UEFI. |
| **Procesor (CPU)**       | Provádí instrukce, řídí chod systému.                                                  |
| **Operační paměť (RAM)** | Krátkodobá, rychlá paměť pro aktivní procesy.                                          |
| **Grafická karta (GPU)** | Výpočty pro obraz, 2D/3D grafiku, někdy i AI a paralelní úlohy.                        |
| **Zvuková karta**        | Zpracování zvuku (integrovaná nebo samostatná).                                        |
| **Síťová karta**         | Připojení do sítě/internetu (Ethernet, WiFi).                                          |


---

## Na jakém principu pracuje procesor

- CPU vykonává strojové instrukce v cyklu:
  1. **Fetch** - načtení instrukce z paměti,
  2. **Decode** - dekódování instrukce,
  3. **Execute** - provedení (výpočet, přesun dat, skok).
- Obsahuje:
  - **ALU** (aritmeticko-logická jednotka),
  - **řadič** (řízení toku instrukcí),
  - **registry** (velmi rychlá interní paměť).
- Výkon ovlivňuje frekvence, počet jader, architektura, cache a spotřeba.

---

## Druhy pamětí


| Typ paměti                | Charakteristika                                                         |
| ------------------------- | ----------------------------------------------------------------------- |
| **Registry CPU**          | Nejrychlejší, nejmenší kapacita, uvnitř procesoru                       |
| **Cache (L1/L2/L3)**      | Velmi rychlá mezi CPU a RAM, zrychluje přístup k často používaným datům |
| **RAM**                   | Volatilní (po vypnutí se smaže), pracovní paměť programů                |
| **ROM/Flash (BIOS/UEFI)** | Nevolatilní firmware                                                    |
| **SSD/HDD**               | Dlouhodobé úložiště dat, SSD je výrazně rychlejší než HDD               |


Rozdělení:

- **Volatilní paměť**: potřebuje napájení (registry, cache, RAM).
- **Nevolatilní paměť**: data drží i po vypnutí (SSD, HDD, ROM).

---

## Porovnání: desktop vs notebook vs smartphone


| Zařízení           | Výhody                                              | Nevýhody                                      | Typické použití                                  |
| ------------------ | --------------------------------------------------- | --------------------------------------------- | ------------------------------------------------ |
| **Stolní počítač** | Nejvyšší výkon/cena, snadný upgrade, dobré chlazení | Nemobilní, vyšší spotřeba                     | Hry, vývoj, grafika                              |
| **Notebook**       | Přenosnost, integrovaný displej a baterie           | Omezený upgrade, menší chlazení               | Škola, kancelář, běžná práce                     |
| **Smartphone**     | Maximální mobilita, senzory, stále online           | Malý displej, omezený výkon pro náročné úlohy | Komunikace, aplikace, rychlý přístup k internetu |


---

## Příklad v praxi

Student upravuje video:

- **CPU** zpracovává efekty a logiku aplikace.
- **GPU** urychluje render náhledu i export.
- **RAM** drží projekt a média během práce.
- **SSD** ukládá zdrojové soubory i export.
- **Síťová karta** odešle hotové video na cloud.

---

## Shrnutí

- Počítač tvoří spolupracující komponenty propojené základní deskou.
- CPU pracuje v cyklu fetch-decode-execute.
- Paměti se liší rychlostí, kapacitou a volatilitou.
- Desktop, notebook i smartphone mají jiné priority: výkon, mobilita, výdrž.

---

## Materiály od učitele

Sekce vychází z `SouborovySystem.txt`.

### Souborový systém

- Souborový systém je hierarchický strom složek a souborů.
- Rozlišujeme absolutní a relativní cesty.
- V C# se pracuje přes `System.IO` (`File`, `Directory`, `FileInfo`, `DirectoryInfo`).

### Praktické operace se soubory

- Čtení/zápis textu: `ReadAllText`, `ReadAllLines`, `WriteAllText`, `WriteAllLines`, `AppendAllText`.
- Streamování velkých souborů: `StreamReader`, `StreamWriter`.
- Důležitý koncept: buffer a flush při zápisu.

### Zámky souborů

- OS používá locky/handly pro ochranu konzistence dat.
- Sdílení přístupu se řídí režimy jako `FileShare.Read`.

### Pro ty, co chtej vedet vic

- [SouborovySystem.txt](Materialy/SouborovySystem.txt)
- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)

