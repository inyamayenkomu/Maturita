# 21. Vstupní a výstupní zařízení – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: USB handshake - přesná verze

Napište konzolovou aplikaci v C#, která:

- Pracuje se zařízeními jako síťová karta, bluetooth modul, wifi karta, monitor, myš, tiskárna.
- Simuluje hostitelské zařízení (PC) po připojení USB zařízení.
- Uživatel konzole jedná jako připojené zařízení (např. fotoaparát, flash disk, klávesnice).
- Po připojení provede tuto sekvenci:
  - Hostitel pošle `RESET`, zařízení musí odpovědět `RESET`.
  - Hostitel se zeptá na maximální délku paketu, odpověď musí být číslo `> 8` a `< 4096`.
  - Hostitel pošle `READY`, zařízení musí odpovědět `READY`.
  - Hostitel vygeneruje adresu `0-127` a pošle ji zařízení.
  - Hostitel se zeptá na název zařízení (max. 32 znaků).
  - Hostitel se zeptá na ID výrobce zařízení (max. 32 znaků).
  - Hostitel ověří ovladač podle ID výrobce; když není nalezen, vypíše chybu, když je nalezen, komunikace začne.

---

## Příklad 2: USB handshake - validace kroků

Napište konzolovou aplikaci v C#, která:

- Použije stejnou handshake sekvenci jako v příkladu 1.
- Kontroluje přesnost odpovědí (`RESET`, `READY`).
- Validuje číselný rozsah délky paketu a délku textových údajů.
- Při první chybě vypíše konkrétní důvod selhání a ukončí handshake.

---

## Příklad 3: USB handshake - ovladače výrobců

Napište konzolovou aplikaci v C#, která:

- Použije stejnou handshake sekvenci jako v příkladu 1.
- Obsahuje interní seznam známých ID výrobců a jejich ovladačů.
- Po zadání ID výrobce vypíše `Driver found` nebo `Driver not found`.
- Na konci vypíše stav všech kroků handshaku (`OK`/`FAIL`).

---

## Příklad 4: USB handshake - více zařízení

Napište konzolovou aplikaci v C#, která:

- Umožní postupně připojit více zařízení (např. myš, tiskárna, flash disk).
- Pro každé zařízení provede kompletní kroky handshaku.
- Každému zařízení přiřadí adresu v rozsahu `0-127`.
- Na konci vypíše souhrnný report všech připojených zařízení.

---

## Příklad 5: USB handshake + typ zařízení

Napište konzolovou aplikaci v C#, která:

- Naváže na handshake z příkladu 1.
- Po úspěšném připojení určí, zda je zařízení vstupní, výstupní nebo kombinované.
- Pracuje minimálně s těmito typy: síťová karta, bluetooth modul, wifi karta, monitor, myš, tiskárna.
- Vypíše typ dat, která zařízení přenáší (text, obraz, síťová data).

