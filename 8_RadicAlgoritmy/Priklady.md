# 8. Řadicí algoritmy – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Řazení vkládáním s trasováním

Napište konzolovou aplikaci v C#, která seřadí pole čísel algoritmem vkládáním podle teorie v kapitole:

- Kromě výsledného pole vypíše krátký „deník“ kroků (např. po každém vložení prvku), aby bylo vidět, jak se pole mění.
- Ověřte chování na vstupu, který je už seřazený, a na vstupu seřazeném opačně.

---

## Příklad 2: Řazení výběrem a počítání záměn

Napište konzolovou aplikaci v C#, která seřadí pole výběrem:

- Program sleduje, kolik proběhlo záměn prvků mezi pozicemi, a tuto statistiku na konci uvede.
- Výstupem je seřazené pole a souhrnná informace o průběhu.

---

## Příklad 3: Bublinkové řazení a předčasné ukončení

Napište konzolovou aplikaci v C#, která použije bublinkové řazení:

- Pokud v průchodu už nedojde k žádné záměně, další průchody se neprovádějí.
- Ukažte na příkladu, kolik průchodů bylo skutečně potřeba.

---

## Příklad 4: Rychlé řazení

Napište konzolovou aplikaci v C#, která seřadí pole rekurzivním algoritmem „rozděl a panuj“ podle teorie v kapitole:

- Musí zvládnout záporná čísla i duplicity.
- Při obhajobě ukažte na malém poli, jak probíhá dělení a skládání výsledku.

---

## Příklad 5: Porovnání dvou algoritmů na stejných datech

Napište konzolovou aplikaci v C#, která:

- Vygeneruje několik různých typů vstupů (malé, velké, náhodné, témře seřazené).
- Na každém vstupu změří čas dvou různých řadicích algoritmů z této kapitoly a výsledky tabulkově vypíše.
- Stručně okomentujte, který vstup kterému algoritmu „svědčí“ a proč (odkaz na vlastnosti z teorie).
