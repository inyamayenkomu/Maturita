# 3. Větvení a operátory – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Vstup do budovy

Napište konzolovou aplikaci v C#, která podle zadaných údajů rozhodne, zda je vstup povolen:

- Vstupy zahrnují věk, čas (hodina dne) a informaci, zda má osoba kartu; dále například informaci o doprovodu, pokud je podle vašich pravidel potřeba.
- Pravidla kombinujte logicky (současně, alternativně) tak, aby šlo demonstrovat složitější rozhodování než jeden jednoduchý `if`.
- Při zamítnutí musí být z výpisu zřejmé, které pravidlo rozhodlo (ne jen „zakázáno“).
- Přidejte výjimku pro nouzový vstupový kód, který pravidla obejde, ale zároveň zaloguje varování.

---

## Příklad 2: Ceny podle typu zákazníka

Napište konzolovou aplikaci v C#, která spočítá konečnou cenu podle typu zákazníka a množství:

- Typ zákazníka ovlivňuje výši slevy nebo přirážky; objem nad zvolenou hranicí mění pravidla pro vybraný typ.
- Výběr musí být přehledně rozvětvený (vhodné využití větvení z teorie kapitoly).
- Výstup obsahuje původní cenu, použitou slevu v procentech a výslednou cenu zaokrouhlenou na dvě desetinná místa.
- Neznámý typ zákazníka odmítněte bez pádu aplikace.

---

## Příklad 3: Platnost kalendářního data

Napište konzolovou aplikaci v C#, která ověří platnost data zadaného číselně:

- Musí fungovat přestupné roky a správný počet dní v měsících.
- Při chybě uživatel dostane konkrétní informaci (např. neplatný den vs. neplatný měsíc).
- Pro platné datum doplňte informaci o dni v týdnu a tom, zda jde o víkend.
- Roky zcela mimo rozumný rozsah odmítněte vlastním pravidlem.

---

## Příklad 4: Rizikové skóre

Napište konzolovou aplikaci v C#, která z několika vstupů spočítá jednoduché rizikové skóre:

- Pravidla musí kombinovat více vstupů najednou (věk, počet incidentů, příjem nebo jiné veličiny dle vašeho návrhu).
- Výstupem je kategorie rizika a doporučení; alespoň jedna větev výběru textu má být zapsaná kompaktněji než klasickým `if` (např. vhodné využití operátorů z teorie).
- Nesmyslné kombinace vstupů program odmítne.

---

## Příklad 5: Jednoduchý příkazový řádek

Napište konzolovou aplikaci v C#, která opakovaně čte příkazy a udržuje si paměť klíč → hodnota:

- Podporujte uložení hodnoty pod jméno, vyčtení hodnoty, vymazání všech páru a ukončení.
- Neplatný příkaz nebo špatný počet argumentů nesmí rozhodit paměť ani spadnout.
- Prázdné řádky ignorujte.
