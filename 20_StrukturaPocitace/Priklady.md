# 20. Struktura počítače – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: CPU simulace - základní instrukce

Napište konzolovou aplikaci v C#, která:

- Má pevný počet registrů (např. `R0` až `R3`), všechny `int`, na začátku nastavené na `0`.
- Uživatel píše instrukce do konzole po řádcích.
- Podporuje minimálně instrukce `ADD`, `SUB`, `MUL`, `DIV`, `INC`.
- Má vlastní instrukci `PRINT`, která vypíše hodnotu vybraného registru.

---

## Příklad 2: CPU simulace - práce s konstantou

Napište konzolovou aplikaci v C#, která:

- Navazuje na stejný model registrů (všechny registry začínají na `0`).
- Podporuje instrukce s konstantou, např. `ADD R1 5`, `MUL R2 3`, `DIV R0 2`.
- Uživatel zadává instrukce, dokud nenapíše `END`.
- Instrukce `PRINT Rn` slouží jako ověření mezivýsledků.

---

## Příklad 3: CPU simulace - registr na registr

Napište konzolovou aplikaci v C#, která:

- Podporuje operace mezi registry, např. `ADD R1 R2`, `SUB R3 R0`, `MUL R0 R1`.
- Zachová instrukci `INC Rn` pro zvýšení registru o 1.
- Po každé instrukci `PRINT` vypíše aktuální hodnotu cílového registru.
- Na konci vypíše všechny registry v jednom řádku.

---

## Příklad 4: CPU simulace - jednoduché kontroly chyb

Napište konzolovou aplikaci v C#, která:

- Používá stejný model instrukcí (`ADD`, `SUB`, `MUL`, `DIV`, `INC`, `PRINT`).
- Ošetří neplatný název registru (např. `R9`) chybovou hláškou.
- Ošetří dělení nulou (`DIV`) bez pádu aplikace.
- Po chybě pokračuje dalším příkazem od uživatele.

---

## Příklad 5: CPU simulace - mini program s ověřením

Napište konzolovou aplikaci v C#, která:

- Umožní uživateli zadat krátký „program“ o 5-10 instrukcích.
- Program spustí instrukce postupně v pořadí, ve kterém byly zadány.
- Instrukce `PRINT` se použije pro kontrolu správnosti výpočtu během běhu.
- Na konci vypíše finální hodnoty všech registrů (`R0`, `R1`, `R2`, ...).

