# 1. Základní pojmy programování – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Simulace platebního terminálu

Napište konzolovou aplikaci v C#, která simuluje krátký průběh platby:

- Uživatel zadá částku, měnu a PIN; program musí rozumně pracovat s tím, že PIN je tajný text, ne „obyčejné číslo“.
- Neplatná částka nebo nepodporovaná měna se nepřijmou: uživatel dostane srozumitelnou hlášku a může zadání opravit, dokud to není v pořádku.
- Po potvrzení vstupů program ukáže přehled transakce (částka zaokrouhlená na haléře / centy podle zvolené měny) a náhodný potvrzovací kód.
- Na závěr uživatel zvolí potvrzení nebo storno; výsledný stav musí být z výpisu jasný.

---

## Příklad 2: Import tabulky osob ze vstupu

Napište konzolovou aplikaci v C#, která načte malou „tabulku“ z konzole:

- Nejprve uživatel uvede, kolik řádků následuje; každý řádek obsahuje jméno, věk a skóre oddělené středníkem.
- Program odmítne řádky, které neodpovídají dohodnutému formátu nebo rozumným mezím věku a skóre; u chyby uvede číslo řádku a důvod.
- Po načtení vypíše počet platných záznamů, průměrné skóre a počet osob nad zvolenou hranicí věku (např. 65 let).
- U průměru musí být z výpisu patrný rozdíl mezi výsledkem „celočíselného“ a „reálného“ dělení (obě hodnoty ukažte s popiskem).

---

## Příklad 3: Jednoduchý přihlašovací scénář

Napište konzolovou aplikaci v C#, která simuluje přihlášení do systému:

- Uvnitř programu jsou uložené správné přihlašovací údaje (stačí jeden účet).
- Uživatel může opakovaně volit: pokus o přihlášení, zobrazení stavu účtu (jen po přihlášení), odhlášení, konec.
- Pravidla porovnávání hesla a uživatelského jména musí být ze zadání a z chování programu jednoznačná (např. rozlišení velikosti písmen u hesla ano/ne).
- Po několika neúspěšných pokusech se účet zablokuje a další přihlášení je odmítnuto, dokud program neskončí nebo nedojde k resetu podle vašeho zadání (pravidla popište).

---

## Příklad 4: Kalkulátor s režimy a historií

Napište konzolovou aplikaci v C#, která funguje jako malá kalkulačka s pamětí:

- Uživatel vybírá druh operace a zadává dvě čísla; u dělení musí být ošetřen vstup, který by vedl k dělení nulou.
- Program si pamatuje posledních několik operací (horní mez si stanovte) a umí je vypsat očíslované.
- Umožněte smazat poslední uloženou operaci z historie.
- Režimy operací musí být v kódu přehledně rozlišené (vhodné využití pojmů z teorie: např. výčtový typ nebo ekvivalentní přehledná struktura).

---

## Příklad 5: Jednotkový převod s přehledem

Napište konzolovou aplikaci v C#, která převádí mezi dvěma jednotkami jedné veličiny (např. km ↔ míle, °C ↔ °F – zvolte jednu dvojici a držte ji):

- Uživatel zadá číslo a směr převodu; program ověří rozumný rozsah vstupu.
- Výstup ukáže původní hodnotu, převedenou hodnotu a použitý vzorec slovně nebo symbolicky.
- Při neplatné volbě směru nebo vstupu program nespadne a vysvětlí problém.
