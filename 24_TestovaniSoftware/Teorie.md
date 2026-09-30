# 24. Testování software

> Vysvětlete hlavní cíle testování SW. Popište základní druhy testování (jednotkové, integrační, systémové) a jejich výhody a nevýhody. Jaký je rozdíl mezi funkčním a nefunkčním testováním? Vysvětlete pojmy black-box, white-box a explorativní testování. Jaké informace je potřeba při reportování chyby uvádět? Příklad.

---

## 📖 Slovníček pojmů


| Pojem                  | Co to je                                                 | Příklad z reálného světa               |
| ---------------------- | -------------------------------------------------------- | -------------------------------------- |
| **Testování SW**       | Ověření, že software funguje správně a splňuje požadavky | Kontrola přihlášení před nasazením     |
| **Bug (chyba)**        | Odchylka od očekávaného chování                          | Tlačítko „Uložit“ nic neudělá          |
| **Test case**          | Konkrétní scénář testu se vstupy a očekávaným výsledkem  | Přihlášení správným/špatným heslem     |
| **Regrese**            | Dříve fungující část po změně přestane fungovat          | Po úpravě registrace nejde reset hesla |
| **Testovací pyramida** | Poměr typů testů podle ceny/přínosu                      | Hodně unit testů, méně E2E             |


---

## Hlavní cíle testování software

- Najít chyby co nejdříve a snížit náklady na opravu.
- Ověřit, že software plní požadavky zákazníka.
- Zvýšit důvěru v kvalitu, stabilitu a bezpečnost systému.
- Omezit riziko regresí při dalších úpravách.

---

## Základní druhy testování


| Druh testu            | Co testuje                                | Výhody                                  | Nevýhody                        |
| --------------------- | ----------------------------------------- | --------------------------------------- | ------------------------------- |
| **Jednotkové (unit)** | Malé části kódu izolovaně (funkce/metody) | Rychlé, levné, snadno automatizovatelné | Neověří integraci mezi moduly   |
| **Integrační**        | Spolupráci více částí systému             | Odhalí chyby na rozhraních              | Pomalejší a složitější příprava |
| **Systémové (E2E)**   | Celý systém jako celek                    | Nejvíce odpovídá reálnému použití       | Nejpomalejší, dražší, křehčí    |


Doplněk:

- **Manuální testování** je důležité hlavně pro UX a explorativní scénáře.
- **Automatizované testy** jsou klíčové pro opakované ověřování a CI/CD.

---

## Funkční vs nefunkční testování

### Funkční testování

- Ověřuje, **co** systém dělá.
- Příklad: „Po kliknutí na Přihlásit s validními údaji se uživatel dostane na dashboard.“

### Nefunkční testování

- Ověřuje, **jak** dobře systém funguje.
- Příklady oblastí: výkon, bezpečnost, dostupnost, použitelnost, škálovatelnost.

---

## Black-box, white-box, explorativní testování


| Typ              | Princip                                                                       |
| ---------------- | ----------------------------------------------------------------------------- |
| **Black-box**    | Tester nezná interní implementaci, hodnotí vstupy a výstupy.                  |
| **White-box**    | Tester zná kód a navrhuje testy podle interní logiky.                         |
| **Explorativní** | Průzkumné testování bez pevného skriptu, založené na zkušenosti a hypotézách. |


---

## Co uvádět při reportování chyby

Kvalitní bug report má obsahovat:

- krátký a výstižný název chyby,
- prostředí (OS, verze aplikace, prohlížeč, zařízení),
- přesné kroky k reprodukci,
- očekávaný výsledek,
- skutečný výsledek,
- přílohy (screenshot, video, logy, stack trace),
- závažnost/prioritu a případný dopad na uživatele.

---

## Příklad v praxi

Bug report:

- **Název:** „Registrace selže při heslu delším než 64 znaků bez chybové hlášky“
- **Kroky:** otevřít registraci -> vyplnit e-mail -> zadat 80znakové heslo -> klik Přihlásit
- **Očekávané:** validace a srozumitelná chyba
- **Skutečné:** tichý návrat na formulář bez informace
- **Přílohy:** screenshot formuláře + log z konzole

---

## Shrnutí

- Testování zvyšuje kvalitu a snižuje riziko chyb v produkci.
- Základní vrstvy: jednotkové, integrační, systémové testy.
- Funkční testy ověřují správnost funkcí, nefunkční kvalitu provozu.
- Pro efektivní opravu je klíčový přesný a reprodukovatelný bug report.

---

## Materiály od učitele

Stručné shrnutí navazuje na učitelské poznámky k testování, testovací pyramidě a reportování chyb.

### Pro ty, co chtej vedet vic

- [Testovani.md](../misc/Testovani.md)
- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)

