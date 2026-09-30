# 22. Souborový systém a nosiče informací – praktické příklady

Typické zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Rekurzivní výpis struktury adresáře

Napište konzolovou aplikaci v C#, která:

- Načte od uživatele cestu ke kořenové složce.
- Rekurzivně vypíše celou strukturu adresářů a souborů (stromově, s odsazením podle úrovně).
- U každého souboru vypíše alespoň název a velikost v bajtech.
- Ošetří chyby přístupu (např. nedostatečná oprávnění) bez pádu aplikace.
- Na konci vypíše souhrn: počet složek, počet souborů a celkovou velikost.
