# 25. Metodika vývoje software – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Bug tracker - minimum

Napište konzolovou aplikaci v C#, která:

- Implementuje minimálně funkce `addBug()` a `printBugs()`.
- Každý bug ukládá jako: ID, název, popis, priorita.
- Umožní vložit více bugů přes menu.
- Vypíše všechny bugy v jednotném přehledu.

---

## Příklad 2: Bug tracker - stavový workflow

Napište konzolovou aplikaci v C#, která:

- Navazuje na `addBug()` a `printBugs()`.
- Přidá stavy `Open -> InProgress -> Fixed -> Closed`.
- Umožní měnit stav vybraného bugu podle ID.
- Vypíše historii změn stavu u každého bugu.

---

## Příklad 3: Bug tracker - filtrování a priority

Napište konzolovou aplikaci v C#, která:

- Implementuje `addBug()`, `printBugs()`, `printByPriority()`.
- Umožní filtrovat bugy podle priority (Low/Medium/High/Critical).
- Umožní filtrovat jen otevřené bugy.
- Vypíše počet bugů v jednotlivých prioritách.

---

## Příklad 4: Bug tracker - týmové přiřazení

Napište konzolovou aplikaci v C#, která:

- Implementuje `addBug()`, `assignBug()`, `printBugs()`.
- U každého bugu ukládá přiřazeného řešitele (jméno).
- Umožní vypsat bugy konkrétního člena týmu.
- Vypíše přehled „kdo má kolik bugů“.

---

## Příklad 5: Bug tracker - release report

Napište konzolovou aplikaci v C#, která:

- Implementuje `addBug()`, `printBugs()`, `printReleaseNotes()`.
- Umožní označit bugy, které jsou fixnuté pro aktuální release.
- Vygeneruje textový release report: opravené chyby, otevřené chyby, kritická rizika.
- Na konci vypíše doporučení, zda release pustit nebo odložit.
