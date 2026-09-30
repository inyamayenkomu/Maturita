# 24. Testování software – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Objednávka s více stavy

Na papír si připravte krátké zadání fiktivní aplikace pro objednávku jízdenek s jasnými stavy (košík, platba, potvrzení, storno):

- Navrhněte testovací skript: kroky, očekávaný výsledek, místo pro zápis skutečného výsledku a stav pass/fail.
- Zahrňte alespoň jeden krok, kde má systém odmítnout přechod do dalšího stavu.

---

## Příklad 2: Oprávnění a role

Popište aplikaci s přihlášením a minimálně dvěma rolemi (např. uživatel vs. správce):

- Navrhněte testy, které ověří, co vidí a co změnit může každá role.
- Přidejte negativní scénář: pokus o akci bez oprávnění musí skončit jasnou chybou.

---

## Příklad 3: Platební brána a chyby sítě

Zpracujte zadání platebního kroku v e‑shopu (částka, způsob platby, potvrzení banky):

- Testy musí pokrýt šťastnou cestu i typické chyby (špatná částka, timeout, odmítnutá karta – stačí jako textové popisy simulovaných výsledků).
- Rozdělte testy na funkční a nefunkční (výkon, bezpečnost, spolehlivost – podle toho, co dává smysl k vašemu zadání).

---

## Příklad 4: Import CSV a validace

Aplikace importuje soubor se záznamy zákazníků:

- Navrhněte testy na prázdný soubor, špatné hlavičky, duplicitní id a řádek s chybějícím polem.
- Ke každému fail stavu přidejte krátký bug report (co se stalo, závažnost, doporučení).

---

## Příklad 5: Regresní sada po úpravě

Představte si, že ve stávající aplikaci přibyla nová funkce „filtrování podle data“:

- Vyberte pět existujících scénářů, které musí zůstat funkční, a jeden nový scénář pro filtr.
- Sepsaný test plán musí mít jasnou prioritu (kritické vs. vedlejší) a závěrečné riziko, co by se mohlo pokazit při nasazení.
