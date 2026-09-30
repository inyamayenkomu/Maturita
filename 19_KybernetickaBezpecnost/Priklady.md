# 19. Kybernetická bezpečnost – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Bob a Alice - Caesar šifra

Napište konzolovou aplikaci v C#, která:

- Má třídy `Bob` a `Alice`, každý má tajný klíč (`int`).
- Implementuje Caesarovu šifru (každé písmeno posune v abecedě o hodnotu klíče).
- V zadání i ve výstupu stručně vysvětlí princip šifry na jednom příkladu znaku.
- Klíče Boba a Alice se nemusí shodovat.
- Pokud se klíče neshodují, vypíše `chyba` (nebo `chyba - klíče nesedí`) a ukončí dešifrování.

---

## Příklad 2: Bob a Alice - Caesar + validace

Napište konzolovou aplikaci v C#, která:

- Navazuje na Caesarovu šifru.
- Vysvětlí princip Caesarovy šifry (posun znaků v abecedě, cyklení po `Z` zpět na `A`).
- Ověřuje, že klíč je v povoleném rozsahu (např. 1-25).
- Při neplatném klíči komunikaci zastaví.
- Pokud klíče nesedí, vypíše `chyba` a přidá důvod selhání do logu.

---

## Příklad 3: Bob a Alice - Vigenere-like varianta

Napište konzolovou aplikaci v C#, která:

- Má třídy `Bob` a `Alice`, každý má tajný klíč.
- Místo jednoho posunu používá opakovaný seznam posunů (`int[] key`) - podobně jako Vigenere.
- Stručně vysvětlí, že každý znak může mít jiný posun podle pozice v klíči.
- Vypíše zašifrovanou zprávu a pokus o dešifrování.
- Pokud klíče nesedí, vypíše `chyba` a označí výsledek jako nečitelný.

---

## Příklad 4: Bob a Alice - XOR šifra

Napište konzolovou aplikaci v C#, která:

- Implementuje jednoduchou XOR šifru nad znaky.
- Vysvětlí princip XOR: stejný klíč při opětovném XOR vrátí původní text.
- Bob a Alice mají každý `int` klíč.
- Pokud se klíče shodují, dešifrování vrátí původní text.
- Pokud se klíče liší, vypíše `chyba` a že text nejde korektně obnovit.

---

## Příklad 5: Bob a Alice - výměna klíče a komunikace

Napište konzolovou aplikaci v C#, která:

- Má třídy `Bob` a `Alice` a simulaci fáze „dohoda na klíči“.
- Dohoda může být úspěšná i neúspěšná (klíče se nemusí shodovat).
- Uživatel vybere variantu šifry (`Caesar` nebo `XOR`).
- Program u vybrané šifry stručně vypíše její princip.
- Program vypíše celý průběh: dohoda, šifrování, dešifrování, výsledek; při neshodě klíčů vypíše `chyba`.

