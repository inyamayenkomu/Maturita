# 9. Kolekce – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Nákupní košík s limitem

Napište konzolovou aplikaci v C#, která simuluje košík v e‑shopu:

- Uživatel přidává a odebírá položky; košík má horní limit počtu nebo celkové ceny podle vašeho návrhu.
- Program hlásí, kdy už nelze přidat, a umí vypsat obsah s pořadím, jak bylo přidáváno.

---

## Příklad 2: Kontrola závorek

Napište konzolovou aplikaci v C#, která načte jeden řádek textu a rozhodne, zda jsou kulaté závorky vyvážené a správně uzavřené:

- Rozšíření volitelné: totéž i pro hranaté a složené závorky, pokud stihnete; jinak stačí jen kulaté.

---

## Příklad 3: Fronta úloh s timeoutem

Napište konzolovou aplikaci v C#, která simuluje tiskovou frontu:

- Úlohy mají název a odhadovanou délku; fronta je FIFO.
- Každé „zpracování“ úlohy odebere jednu z fronty a sečte uběhlý čas; po překročení celkového limitu času už program další úlohy nezpracuje a řekne, co zůstalo ve frontě.

---

## Příklad 4: Telefonní seznam podle přezdívky

Napište konzolovou aplikaci v C#, která udržuje mapování přezdívka → telefonní číslo:

- Umožní přidat, změnit, smazat a vyhledat záznam; při neexistující přezdívce to musí být jasné.
- Na závěr umí vypsat celý seznam seřazený podle přezdívky.

---

## Příklad 5: Historie navštívených stránek

Napište konzolovou aplikaci v C#, která simuluje prohlížeč:

- Uživatel zadává „URL“ jako text; program si pamatuje historii návštěv tak, aby šlo jít „zpět“ a „vpřed“ mezi již otevřenými stránkami (chování podobné zásobníkům v prohlížeči).
- Při kroku zpět na prázdné historii nesmí aplikace spadnout.
