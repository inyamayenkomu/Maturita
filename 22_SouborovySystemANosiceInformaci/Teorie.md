# 22. Souborový systém a nosiče informací

> Jak funguje organizace souborů v počítači? Popište rozdíl mezi absolutní a relativní cestou. Uveďte příklady typů souborů. Popište nosiče informací a jejich možnosti: HDD, SSD, CD, DVD, Blu-ray, flash disk. Příklad.

---

## 📖 Slovníček pojmů


| Pojem                | Co to je                                              | Příklad z reálného světa                      |
| -------------------- | ----------------------------------------------------- | --------------------------------------------- |
| **Souborový systém** | Pravidla a struktura, jak OS ukládá a organizuje data | Strom složek na disku                         |
| **Absolutní cesta**  | Cesta od kořenového adresáře                          | `C:\\Users\\Student\\Dokumenty\\referat.docx` |
| **Relativní cesta**  | Cesta vzhledem k aktuální složce                      | `..\\Obrazky\\graf.png`                       |
| **Přípona souboru**  | Označuje typ/format souboru                           | `.txt`, `.pdf`, `.jpg`, `.mp4`                |
| **Nosič informací**  | Fyzické médium, na kterém jsou uložená data           | SSD, HDD, flash disk, optický disk            |


---

## Organizace souborů v počítači

- Data jsou uložena ve **souborech**, které jsou seskupeny ve **složkách**.
- Struktura je hierarchická (strom): kořen -> složky -> podsložky -> soubory.
- Operační systém přes souborový systém řeší:
  - ukládání dat na médium,
  - přístupová práva,
  - názvy, cesty a metadata (velikost, datum změny).

---

## Absolutní vs relativní cesta


| Typ cesty     | Popis                              | Výhoda                     | Nevýhoda                           |
| ------------- | ---------------------------------- | -------------------------- | ---------------------------------- |
| **Absolutní** | Začíná od kořene disku/systému     | Jednoznačná                | Méně přenositelná mezi prostředími |
| **Relativní** | Začíná od aktuální pracovní složky | Přenositelnější v projektu | Závisí na aktuálním umístění       |


Příklady:

- Absolutní: `C:\\Users\\Student\\Projekt\\data\\input.csv`
- Relativní: `data\\input.csv` nebo `..\\sdilene\\input.csv`

---

## Typy souborů (příklady)


| Kategorie              | Přípony                          |
| ---------------------- | -------------------------------- |
| **Textové dokumenty**  | `.txt`, `.md`, `.docx`, `.pdf`   |
| **Tabulky a data**     | `.csv`, `.xlsx`, `.json`, `.xml` |
| **Obrázky**            | `.jpg`, `.png`, `.gif`, `.svg`   |
| **Audio/Video**        | `.mp3`, `.wav`, `.mp4`, `.mkv`   |
| **Programy a archivy** | `.exe`, `.dll`, `.zip`, `.rar`   |


---

## Nosiče informací

### HDD (Hard Disk Drive)

- Magnetický disk s mechanickými částmi.
- Výhody: nízká cena za 1 GB, velké kapacity.
- Nevýhody: pomalejší přístup, citlivost na otřesy.

### SSD (Solid State Drive)

- Polovodičové úložiště bez pohyblivých částí.
- Výhody: výrazně rychlejší, tiché, odolnější proti otřesům.
- Nevýhody: vyšší cena za 1 GB než HDD.

### CD

- Optický disk s kapacitou typicky kolem **700 MB**.
- Využití: hudební CD, starší instalace software, menší archiv.
- Dnes: spíš okrajové použití.

### DVD

- Optický disk s kapacitou **4.7 GB** (jednovrstvé) nebo **8.5 GB** (dvouvrstvé).
- Využití: filmy, zálohy, distribuční média.
- Oproti CD výrazně vyšší kapacita.

### Blu-ray

- Optický disk s kapacitou **25 GB** (jednovrstvé) nebo **50 GB** (dvouvrstvé), existují i vyšší varianty.
- Využití: HD/4K video, větší archiv dat.
- Oproti DVD vyšší kapacita i přenosová rychlost.

Společné nevýhody optických disků:
- pomalejší práce než SSD/flash,
- mechaniky už nejsou běžná výbava nových notebooků.

### Flash disk (USB)

- Přenosné polovodičové médium.
- Výhody: mobilita, jednoduché použití, opakovaný zápis.
- Nevýhody: nižší životnost při intenzivním přepisování, snadná ztráta zařízení.

---

## Příklad v praxi

Student má projekt ve složce `Projekt`:

1. Zdrojový kód má v `src`.
2. Data pro testování v `data`.
3. Program načítá soubor relativní cestou `data/test.csv`.
4. Projekt je uložen na SSD (rychlá práce), zálohy ukládá na externí HDD.

---

## Shrnutí

- Souborový systém organizuje data do stromu složek a souborů.
- Absolutní cesta je jednoznačná od kořene, relativní je vztažená k aktuální složce.
- Typ souboru se běžně pozná podle přípony.
- Moderně se nejvíc používají SSD/HDD/flash; optické disky mají dnes spíš doplňkovou roli.

---

## Materiály od učitele

Stručné shrnutí vychází z podkladů k souborovému systému a práci se soubory v C#.

### Pro ty, co chtej vedet vic

- [SouborovySystem.txt](../20_StrukturaPocitace/Materialy/SouborovySystem.txt)
- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)

