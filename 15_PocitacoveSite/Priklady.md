# 15. Počítačové sítě – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: DNS simulace - základ

Napište konzolovou aplikaci v C#, která:

- Obsahuje předem připravený slovník `doména -> IP`.
- Uživatel zadá doménu (např. `seznam.cz`) a program vrátí IP adresu.
- Pokud doména neexistuje, vypíše „DNS záznam nenalezen“.
- Umožní vypsat všechny dostupné záznamy.

---

## Příklad 2: DNS simulace - více typů záznamů

Napište konzolovou aplikaci v C#, která:

- Podporuje typy záznamů `A` a `CNAME`.
- Uživatel zadá doménu a typ dotazu.
- Program vrátí odpovídající výsledek podle typu záznamu.
- Při chybě vypíše, zda chybí doména nebo typ záznamu.

---

## Příklad 3: DNS simulace - cache resolveru

Napište konzolovou aplikaci v C#, která:

- Simuluje DNS cache (`Dictionary` + čas expirace).
- Při prvním dotazu vrátí odpověď ze „serveru“, při dalším z cache.
- U každé odpovědi vypíše `CACHE HIT` nebo `CACHE MISS`.
- Umožní ručně vyprázdnit cache.

---

## Příklad 4: DNS simulace - reverse lookup

Napište konzolovou aplikaci v C#, která:

- Umožní vyhledat doménu podle IP adresy (`IP -> doména`).
- Podporuje standardní lookup i reverse lookup.
- Vypíše, který směr dotazu byl použit.
- Ošetří situaci, kdy záznam neexistuje.

---

## Příklad 5: DNS simulace - primární a záložní server

Napište konzolovou aplikaci v C#, která:

- Simuluje dva DNS servery: primární a sekundární.
- Dotaz jde nejdřív na primární server, při selhání na sekundární.
- Vypíše, který server odpověděl.
- Na konci vypíše statistiku úspěšnosti obou serverů.
