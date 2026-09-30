# 4. Cykly – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Validovaný import logů

Napište konzolovou aplikaci v C#, která načte daný počet řádků logu:

- Každý řádek má dohodnutý tvar (úroveň zprávy a text); neplatný řádek se nepřeskočí tajně – uživatel ho zadá znovu.
- Na konci program uvede statistiky podle úrovní a kde naposledy nastala chybová úroveň.
- Volitelně: jeden speciální vstup celý import přeruší; chování popište v zadání u řešení nebo v úvodním komentáři programu.

---

## Příklad 2: Jednoduchá simulace provozu

Napište konzolovou aplikaci v C#, která po krocích simuluje stav serveru:

- Stav zahrnuje alespoň zátěž, teplotu a informaci o výpadku; uživatel v každém kroku zadává krátký příkaz, který stav mění.
- Při kritických hodnotách se systém chová podle vašich pravidel (např. odmítne další zvyšování zátěže, dokud nepřijde obnova).
- Po ukončení simulace vyhodnoťte: kolik kroků proběhlo, jaká byla nejvyšší teplota, zda nastal výpadek.

---

## Příklad 3: Čísla a tabulka násobilky

Napište konzolovou aplikaci v C#, která:

- Vygeneruje nebo načte sadu celých čísel a vypíše jejich součet a průměr.
- Poté vytiskne čtvercovou tabulku násobilky do zvoleného rozsahu tak, aby se sloupce v konzoli dobře četly.
- U každého řádku tabulky doplňte součet řádku.

---

## Příklad 4: Dvě fronty úloh

Napište konzolovou aplikaci v C#, která simuluje frontu tiskových úloh s prioritou:

- Úlohy jdou do běžné nebo prioritní fronty; zpracování vždy bere nejdřív prioritní úlohy.
- Menu umožní přidávat úlohy, zpracovat jednu, zobrazit stav obou front a skončit.
- Zpracovat úlohu nelze, když jsou obě fronty prázdné; uživatel musí dostat srozumitelnou odpověď.
- Na konci uveďte, kolik úloh odešlo z každé fronty.

---

## Příklad 5: Načítání čísel až do konce

Napište konzolovou aplikaci v C#, která čte vstup po řádcích:

- Dokud uživatel nezadá ukončovací příkaz, program sbírá platná celá čísla a ignoruje nečíselné řádky s upozorněním.
- Speciální příkaz kdykoli vypíše dosavadní minimum, maximum a průměr z platných čísel.
- Po skončení shrňte, kolik platných čísel přišlo.
