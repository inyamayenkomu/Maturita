# 11. Desktopové aplikace – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Rozdělení obrazovky a logiky

Vytvořte jednoduchou desktopovou aplikaci (WPF), která řeší malý praktický úkol z reálného života (např. převod jednotek, výpočet slevy, evidence knih):

- Uživatelská část je popsána v deklarativním rozhraní, chování v kódu okna.
- Po spuštění je zřejmé, která část definuje vzhled a která reakce na akce uživatele.

---

## Příklad 2: Formulář s kontrolou vstupu

Vytvořte okno, kde uživatel vyplní několik polí a potvrdí odesláním:

- Prázdná nebo nesmyslná pole nesmí projít; uživatel dostane srozumitelné upozornění přímo u problému.
- Po úspěšném odeslání se zobrazí shrnutí zadaných dat (např. v textovém bloku nebo dialogu).

---

## Příklad 3: Panel nastavení

Navrhněte okno „Nastavení“, kde lze přepínat alespoň tři různé typy voleb (např. zapnutí funkce, výběr z nabídky, posuvník s číselnou hodnotou):

- Po uložení musí být zřejmé, jaká nastavení platí; lze je znovu vypsat jedním příkazem z rozhraní.

---

## Příklad 4: Práce se souborem přes dialogy

Vytvořte okno s akcemi pro otevření a uložení textového souboru:

- Uživatel vybírá soubor přes standardní dialog systému; cesta se ukáže v rozhraní.
- Před přepsáním souboru se program zeptá na jistotu; rozdíl mezi modálním a nemodálním dialogem stručně vysvětlete při obhajobě.

---

## Příklad 5: Jednoduchý správce seznamu úkolů

Vytvořte okno pro správu krátkého seznamu položek:

- Přidání, označení jako hotové a odstranění musí být dostupné z rozhraní bez nutnosti editovat kód.
- Operace, které nedávají smyslů (např. smazání, když nic není vybráno), musí skončit bez pádu a s vysvětlením pro uživatele.
