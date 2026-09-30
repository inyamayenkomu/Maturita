# 5. Rekurze – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Strom složek (textový model)

Napište konzolovou aplikaci v C#, která pracuje s modelem adresářové struktury v paměti (nemusí číst skutečný disk):

- Uživatel zvolí maximální hloubku výpisu; hlubší úrovně se neukazují.
- Výpis stromu používá odsazení podle úrovně.
- Součástí je rekurzivní součet: kolik „souborů“ je v celém podstromu od kořene.
- U obhajoby ukažte, kde je základní případ a kde rekurzivní krok.

---

## Příklad 2: Výraz se závorkami

Napište konzolovou aplikaci v C#, která načte aritmetický výraz s čísly, závorkami a operacemi sčítání, odčítání a násobení:

- Rozsah a formát si stanovte tak, aby byl problém zvládnutelný v čase přípravy, ale nebyl triviální (např. omezení na jednociferná čísla nebo jen kladná čísla – pravidla musí být uvedena v dokumentaci řešení).
- Program vrátí číselný výsledek a při neplatném vstupu vysvětlí proč.
- Požadavek: použití rekurze při rozboru výrazu (např. podle priorit operátorů).

---

## Příklad 3: Hledání cesty v mřížce

Napište konzolovou aplikaci v C#, která v malé mřížce průchodů a zdí zjistí, zda existuje cesta z jednoho rohu do druhého:

- Pohyb je omezený (např. jen doprava a dolů); zeď neprojdete.
- Pokud cesta existuje, vypište ji jako posloupnost políček; pokud ne, vypište důvod.
- Musí být zřejmé, že program se nezacyklí při prohledávání.

---

## Příklad 4: Rozklad na prvočinitele

Napište konzolovou aplikaci v C#, která načte celé číslo větší než 1 a vypíše prvočinitele včetně násobnosti:

- Jedna varianta řešení má být rekurzivní.
- Druhá varianta stejný výsledek spočítá bez rekurze.
- Porovnejte pro stejné vstupy „náklad“ vhodnou metrikou (např. počet volání / iterací), kterou si definujete.

---

## Příklad 5: Čísla ve vnořené struktuře

Navrhněte strukturu, kde se střídají seznamy čísel a další vnořené celky (např. složky s položkami):

- Data mohou být zadaná přímo v kódu jako ukázka.
- Rekurzivně spočítejte součet všech čísel v celé struktuře a největší hloubku zanoření.
- Stručně popište základní případ a rekurzivní krok.
