# 7. Složitost algoritmu a optimalizace – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Měření součtu na velkých datech

Napište konzolovou aplikaci v C#, která:

- Vygeneruje nebo načte dlouhé pole celých čísel (řád alespoň desítky tisíc prvků).
- Spočítá součet jedním průchodem a vypíše výsledek.
- Změří, jak dlouho výpočet trvá, a zopakuje měření pro jinou velikost vstupu; výsledky porovnejte slovně (očekávaný růst času vs. realita).

---

## Příklad 2: Lineární vs. binární vyhledávání

Napište konzolovou aplikaci v C#, která:

- Pracuje se seřazenými daty a umožní hledat hodnotu dvěma způsoby: průchodem od začátku a vyhledáváním „půlením intervalu“ podle teorie v kapitole.
- U obou variant vypíše, zda hodnota existuje, a na indexu / pozici kde byla nalezena.
- U stejného vstupu změřte časy obou přístupů na větším poli a výsledek stručně okomentujte.

---

## Příklad 3: Duplicity – pomalé a rychlé řešení

Napište konzolovou aplikaci v C#, která zjistí, zda pole obsahuje duplicitní hodnotu:

- Nejprve použijte přístup, který je asymptoticky pomalejší vůči počtu prvků (dvojité procházení).
- Poté stejný úkol vyřešte efektivněji vhodnou strukturou z teorie kolekcí.
- Porovnejte časy na stejných datech a vysvětlete rozdíl vlastními slovy podle teorie složitosti.

---

## Příklad 4: Počítání inverzí v poli

Napište konzolovou aplikaci v C#, která pro náhodné nebo zadané pole spočítá počet inverzí (kolikrát je větší prvek před menším):

- Implementujte přímočaré řešení s vnořenými smyčkami a změřte čas pro rostoucí `n`.
- Navrhněte, případně implementujte rychlejší variantu (pokud stihnete); pokud ne, popište myšlenku zrychlení a kde by se projevila.

---

## Příklad 5: Mini optimalizace reálného úkolu

Vyberte jeden malý úkol (např. filtrování slov v dlouhém textu, počítání četností, hledání prefixu) a:

- Napište první verzi co nejjednodušeji ke čtení.
- Najděte v ní operaci, která se opakuje zbytečně často, a připravte druhou verzi s menším opakováním práce.
- Ukažte krátké měření „před a po“ a shrňte kompromis čitelnost vs. rychlost.
