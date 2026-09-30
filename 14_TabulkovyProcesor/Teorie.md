# 14. Tabulkový procesor

> Popište význam a možnosti tabulkových procesorů. Objasněte a předveďte využití vzorců, relativních a absolutních odkazů. Demonstrujte práci s grafem v tabulkovém procesoru. Vysvětlete souborový formát CSV.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Buňka** | Jedno pole na křižovatce řádku a sloupce | Jedna částka v tabulce výdajů |
| **Vzorec** | Výpočet z hodnot buněk, začíná `=` | Součet sloupce |
| **Relativní odkaz** | Při kopírování se posune podle nové pozice | Kopíruješ řádek – vzorec se přizpůsobí |
| **Absolutní odkaz** | `$` zafixuje řádek/sloupec – při kopírování zůstane | Sazba DPH v jedné buňce pro celý list |
| **Rozsah** | Souvislá oblast buněk | A1:A10 |

---

## Význam tabulkového procesoru

> **Přirovnání**: Jako **kalkulačka s tabulkou** – máš spoustu čísel vedle sebe, vzorce se přepočítají samy a můžeš si udělat graf.

- Organizace, analýza a vizualizace dat (Excel, LibreOffice Calc, Google Sheets).
- **Výhody**: automatické přepočty, grafy, filtry, třídění, reporty, rozpočty.

### Základní možnosti

- Buňky v řádcích a sloupcích (adresa např. `B3`).
- Vzorce a funkce (matematické, logické, textové).
- Grafy, pivotní tabulky.
- Formátování buněk, filtrování, řazení.

---

## Vzorce a funkce

- Vzorec **vždy začíná znakem `=`**.

| Příklad | Význam |
| ------- | ------ |
| `=A1+B1` | Součet dvou buněk. |
| `=SUM(A1:A10)` | Součet rozsahu A1 až A10. |
| `=AVERAGE(B2:B20)` | Průměr rozsahu. |
| `=IF(C1>50;"Prošel";"Neprošel")` | Podmínka (syntaxe závisí na locale – středník vs. čárka). |

---

## Relativní vs. absolutní odkazy

### Relativní odkaz (`A1`, `B2`)

- Při **kopírování** vzorce se odkazy posunou stejně jako pozice buňky.
- Příklad: v `C1` je `=A1*B1`. Zkopíruješ do `C2` → vzorec se změní na `=A2*B2`.

### Absolutní odkaz (`$A$1`, `$B$1`)

- **`$`** před sloupcem nebo řádkem = tato část zůstane **pevná** při kopírování.
- Příklad: `=$A$1*B1` v `C1` – po zkopírování do `C2` dostaneš `=$A$1*B2` (A1 zůstane, B se posune).

### Smíšený odkaz

- `$A1` – pevný sloupec, řádek se posouvá.
- `A$1` – pevný řádek, sloupec se posouvá.

### Příklad s DPH

```
Buňka D1: sazba DPH 21 %

Buňka C1: =B1*$D$1   (cena × DPH)
Zkopírování C1 → C2: =B2*$D$1
```

> **Přirovnání**: Relativní odkaz je jako **„o jednu buňku vlevo“** – při kopírování se posune. Absolutní je **„vždy tahle konkrétní buňka“** – jako pevná konstanta v rohu listu.

---

## Práce s grafem

1. **Vyber data** – souvislý rozsah (např. kategorie v A, hodnoty v B).
2. **Vložit graf** – typ podle účelu (sloupce, čáry, koláč…).
3. **Upravit** – názvy os, titulek, barvy, datové štítky, případně trendová čára.

| Typ grafu | Kdy použít |
| --------- | ---------- |
| **Sloupcový / sloupcový seskupený** | Srovnání kategorií (měsíční tržby). |
| **Spojnicový** | Vývoj v čase (trend). |
| **Koláčový** | Podíly z celku (max. několik segmentů). |

**Příklad**: Měsíc | Tržby → sloupcový graf, osa X = měsíc, osa Y = tržby.

---

## Souborový formát CSV

> 📄 **Přirovnání**: CSV je jako **tabulka bez barev a vzorců** – jen text oddělený znakem, který Excel nebo jiný program umí načíst jako sloupce.

- **CSV (Comma-Separated Values)** – textový formát pro ukládání tabulkových dat.
- Každý **řádek** = jeden záznam, **sloupce** oddělené oddělovačem (čárka nebo středník).

### Příklad CSV

```csv
Jmeno;Vek;Mesto
Anna;17;Praha
Petr;18;Brno
```

### Důležité vlastnosti

| Vlastnost | Popis |
| --------- | ----- |
| **Oddělovač** | V CZ Excelu často **středník** (`;`), v anglickém prostředí **čárka** (`,`) |
| **Hlavička** | První řádek může obsahovat názvy sloupců |
| **Uvozovky** | Text s oddělovačem se obalí uvozovkami: `"Praha, centrum"` |
| **Kódování** | Doporučeno **UTF-8** kvůli českým znakům |
| **Desetinná čárka** | V CZ CSV bývá `3,14` – při importu pozor na locale |

### Výhody a nevýhody CSV

| Výhody | Nevýhody |
| ------ | -------- |
| Univerzální, malá velikost | Neukládá vzorce, formátování, grafy |
| Snadný import/export | Problém s oddělovači uvnitř textu |
| Vhodné pro výměnu dat mezi systémy | Bez typů sloupců – vše je text |

### Použití

- Export dat z e-shopu, školní evidence, import do databáze.
- V Excelu: **Uložit jako → CSV UTF-8** nebo **Data → Z textu/CSV**.

---

## Shrnutí

- Tabulkové procesory slouží k datům, výpočtům a vizualizaci.
- Vzorce začínají `=`, funkce jako SUM, AVERAGE, IF.
- **Relativní** odkazy se při kopírování posouvají; **absolutní** (`$`) drží řádek/sloupec.
- Graf: výběr dat → typ grafu → úprava popisků a vzhledu.
- **CSV** – textový formát tabulky; oddělovač, hlavička, uvozovky, UTF-8.
