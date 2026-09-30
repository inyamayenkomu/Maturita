# Testování

Vysvětlete hlavní cíle testování SW. Popište základní druhy testování (jednotkové, integrační, systémové) a jejich výhody a nevýhody. Jaký je rozdíl mezi funkčním a nefunkčním testováním? Vysvětlete pojmy black-box, white-box a explorativní testování. Jaké informace je potřeba při reportování chyby uvádět?

Testování SW je proces ověřování, že software funguje podle očekávání a splňuje požadavky. Hlavní cíle testování jsou identifikace chyb, zajištění kvality a spolehlivosti softwaru.

## Základní druhy testování

- Jednotkové testování: Testuje jednotlivé části kódu (funkce, metody) izolovaně. Jsou rychlé a snadno automatizovatelné.
- Integrační testování: Testuje spolupráci mezi jednotlivými částmi systému.
- Systémové testování (end-to-end): Testuje celý systém jako celek, často od UI vrstvy (pak se používá termín UI testování).
- Manuální testování: Testování prováděné ručně bez použití automatizačních nástrojů.

## Testovací pyramida

Koncept testovací pyramidy zdůrazňuje to, že ne každý test má stejnou cenu. Chceme mít co nejlepší poměr mezi náklady a přínosem testů. Více např. [zde](https://martinfowler.com/articles/practical-test-pyramid.html).

## Funkční vs. nefunkční testování

- Funkční testování: testuje, zda systém dělá to, co má dělat.
- Nefunkční testování: ověřuje výkon, bezpečnost, použitelnost a další nefunkční aspekty softwaru.

## Black-box, white-box a explorativní testování

- Black-box testování: Testování bez znalosti vnitřní struktury kódu. Testuje se pouze vstup a výstup.
- White-box testování: Testování s plnou znalostí vnitřní struktury kódu. Testuje se logika a struktura kódu.
- Explorativní testování: Testování, které není předem plánované, ale je založené na průzkumu a zkušenostech testera.

## Testovací scénáře

Tester typicky postupuje tak, že před samotným zahájením testování vytvoří scénáře, které bude prověřovat. Scénáře by měly pokrýt různé uživatelské cesty: happy path, edge case, negativní scénáře.

### Příklad:

- Happy path: Uživatel zadá správné přihlašovací údaje a úspěšně se přihlásí.
- Edge case: Uživatel zadá velmi dlouhé heslo.
- Negativní scénář: Uživatel zadá nesprávné přihlašovací údaje a přihlášení selže.

## Reportování chyby

Při reportování chyb je důležité být co nejkonkrétnější a pokusit se vždy chybu navodit v co nejvíce zjednodušené formě. Tzn. odstranit všechny zbytečné kroky a snažit se elminovat specifika našeho prostředí. Dále je potřeba uvést:

- Popis chyby
- Kroky k reprodukci
- Očekávaný výsledek
- Skutečný výsledek
- Screenshoty/logy/video

