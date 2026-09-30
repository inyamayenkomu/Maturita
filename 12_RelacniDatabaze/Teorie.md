# 12. Relační databáze

> Co znamená pojem relační databáze? Definujte pojmy tabulka, atribut, záznam, primární a cizí klíč, integritní omezení. Jaké typy atributů znáte? Definujte pojem transakce, v čem spočívá význam transakcí?

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Relace** | Tabulka v relačním modelu – řádky a sloupce | Seznam studentů v tabulce |
| **Primární klíč (PK)** | Unikátní identifikátor řádku v tabulce | Číslo občanky – každý má jiné |
| **Cizí klíč (FK)** | Sloupec odkazující na PK jiné tabulky | Objednávka odkazuje na zákazníka |
| **Integrita** | Pravidla, že data „dávají smysl“ a jsou konzistentní | Nemůžeš objednat pro neexistujícího zákazníka |
| **Transakce** | Soubor operací provedených jako jeden celek | Převod peněz – obě strany nebo žádná |

---

## Relační databáze

> **Přirovnání**: Data jsou v **tabulkách** jako v Excelu, ale s pevnými pravidly a vztahy mezi tabulkami – ne jen volné buňky.

- **Definice**: Databázový systém založený na **tabulkách (relacích)**. Data jsou v řádcích a sloupcích, vztahy mezi tabulkami se definují pomocí klíčů.

---

## Tabulka, atribut, záznam

| Pojem | Vysvětlení |
| ----- | ---------- |
| **Tabulka** | Struktura pro ukládání dat – sloupce (atributy) a řádky (záznamy). |
| **Atribut** | Vlastnost entity = **sloupec** tabulky (jméno, email, cena). |
| **Záznam** | Jeden **řádek** = jedna konkrétní instance (jeden zákazník). |
| **Entita** *(doplňkově)* | Objekt reálného světa modelovaný tabulkou (zákazník, produkt). |

### Typy atributů

| Typ | Popis | Příklad |
| --- | ----- | ------- |
| **Jednoduchý** | Jedna nedělitelná hodnota | Číslo, datum, text |
| **Složený** | Skládá se z více částí logicky | Adresa = ulice + PSČ + město |
| **Odvozený** | Počítá se z jiných dat | Věk z data narození |

---

## Primární a cizí klíč

- **Primární klíč (PK)**: Unikátní identifikátor záznamu. Nesmí být NULL, v tabulce se neopakuje. Např. `ZakaznikID`.

- **Cizí klíč (FK)**: Sloupec, který odkazuje na PK **jiné** tabulky. Zajišťuje vztah (např. `ZakaznikID` v Objednávkách → tabulka Zákazníci).

```
┌─────────────────┐         ┌─────────────────────┐
│   Zákazníci     │         │    Objednávky       │
│─────────────────│         │─────────────────────│
│ ZakaznikID (PK) │◀────────│ ZakaznikID (FK)     │
│ jméno           │         │ ObjednavkaID (PK)   │
│ email           │         │ datum               │
└─────────────────┘         └─────────────────────┘
```

### Typy vztahů (stručně)

| Vztah | Popis |
| ----- | ----- |
| **1 : 1** | Jedna entita k jedné (osoba – občanka). |
| **1 : N** | Jeden zákazník, mnoho objednávek. |
| **M : N** | Studenti – předměty (často přes spojovací tabulku). |

---

## Integritní omezení

Pravidla pro konzistenci dat:

| Omezení | Význam |
| ------- | ------ |
| **Primární klíč** | Unikátnost, NOT NULL. |
| **Cizí klíč** | Hodnota musí existovat v odkazované tabulce (nebo NULL podle pravidla). |
| **NOT NULL** | Sloupec nesmí být prázdný. |
| **UNIQUE** | Hodnoty ve sloupci musí být jedinečné. |
| **CHECK** | Podmínka na hodnotu (např. věk ≥ 18). |

---

## Transakce

- **Definice**: Série operací provedených jako **jeden logický celek**. Buď proběhnou všechny, nebo žádná (rollback).

- **Příklad**: Převod peněz – odečtení z účtu A a připsání na účet B musí být obojí, ne jen jedna polovina.

### ACID

| Vlastnost | Význam |
| --------- | ------ |
| **A**tomicita | Celá transakce nebo nic. |
| **C**onzistence | Po dokončení zůstanou data v platném stavu. |
| **I**zolace | Paralelní transakce se navzájem „nepřekážejí“. |
| **D**urabilita | Po potvrzení (COMMIT) jsou změny trvalé i po výpadku. |

**Význam**: Spolehlivost u bank, e-shopů, rezervací – žádné „poloviční“ stavy.

---

## Shrnutí

- **Relační DB** – data v tabulkách, vztahy přes klíče.
- **Tabulka / atribut / záznam** – sloupce a řádky modelující data.
- **PK** – unikátní řádek; **FK** – odkaz na jinou tabulku.
- **Integritní omezení** – PK, FK, NOT NULL, UNIQUE, CHECK.
- **Transakce** – celek operací; **ACID** zajišťuje spolehlivost.

---

## Materiály od učitele

Sekce vychází z `agregace.sql` a datového souboru `chinook.db`.

### Agregační funkce

- Základní agregace: `MIN()`, `MAX()`, `SUM()`, `AVG()`, `COUNT()`.
- Agregace lze kombinovat s filtrem `WHERE` a se seskupením `GROUP BY`.
- Příklad ze zdroje: průměrné a počty faktur po datu nebo po zemi (`BillingCountry`).

### Důležité pravidlo při agregacích

- Nemíchat neagregované sloupce s agregovanými bez `GROUP BY`.
- U SQLite může dotaz vrátit „nějakou“ hodnotu, jiné databáze to často ukončí chybou.
- Pro přenositelný SQL zápis vždy dodržet: všechny neagregované sloupce musí být v `GROUP BY`.

### Pro ty, co chtej vedet vic

- [chinook.db](Materialy/chinook.db)
- [agregace.sql](Materialy/agregace.sql)
- [select.sql](Materialy/select.sql)
- [join.sql](Materialy/join.sql)
- [insert.sql](Materialy/insert.sql)
- [update.sql](Materialy/update.sql)
- [delete.sql](Materialy/delete.sql)
- [transakce.sql](Materialy/transakce.sql)
- [integritni_omezeni.sql](Materialy/integritni_omezeni.sql)
- [vnorene_prikazy.sql](Materialy/vnorene_prikazy.sql)
