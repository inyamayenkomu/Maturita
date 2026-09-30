# 12. Relační databáze – praktické příklady (chinook.db)

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)  
**Databáze:** [Materialy/chinook.db](Materialy/chinook.db)

---

## Příklad 1: Firemní přehled „kdo prodává nejvíc“

V databázi `chinook.db` připravte dotaz nebo sadu dotazů, které:

- Spojí zákazníky, faktury a položky tak, aby šlo spočítat obrat na zákazníka.
- Vrátí žebříček zákazníků podle celkové utracené částky; u každého uveďte jméno, zemi a počet faktur.
- Vyfiltrujte jen zákazníky s obratem nad zvolenou hranicí (hranici si stanovte a uveďte v zadání řešení).

---

## Příklad 2: Skladba alba a skladatel

Napište dotaz, který pro vybrané album (podle názvu nebo id – zvolte a uveďte) vypíše:

- Seznam skladeb s pořadím, délkou a žánrem.
- U každé skladby jméno skladatele (pokud chybí, musí to být z výsledku patrné).

---

## Příklad 3: Zaměstnanci a jejich prodeje

Napište dotaz, který ukáže zaměstnance (z tabulek o zaměstnancích a prodejích), kteří vyřídili alespoň určitý počet faktur:

- U každého zaměstnance uveďte jméno, počet faktur a součet částek.
- Seřaďte podle celkové částky sestupně.

---

## Příklad 4: Trend nákupů v čase

Napište dotaz, který seskupí obrat po měsících a rocích (podle data na faktuře):

- Výstup musí obsahovat rok, měsíc, počet faktur a součet částek.
- Omezte se například na jednu zemi nebo na jednoho interpreta – filtr si zvolte a zdůvodněte.

---

## Příklad 5: „Top skladby“ v kontextu alba

Napište dotaz, který pro každé album vybere jednu reprezentační skladbu podle vámi zvoleného kritéria (např. nejdelší, nejdražší, nejčastěji zakoupená – pokud to data dovolí):

- Výsledek musí obsahovat název alba, název vybrané skladby a hodnotu kritéria.
- Alba bez vhodné skladby musí být zpracována předvídatelně (výjimka ve smyslu SQL, ne pád nástroje).

---

## Bonus: Playlisty s neobvyklou délkou

Napište dotaz, který najde playlisty, jejichž celková délka skladeb překročí zvolenou mez:

- U každého playlistu uveďte název, počet skladeb a součet délek.
- Seřaďte podle součtu délek.
