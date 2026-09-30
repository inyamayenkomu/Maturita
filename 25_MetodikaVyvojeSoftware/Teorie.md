# 25. Metodika vývoje software

> Popište etapy životního cyklu aplikace (analýza požadavků, návrh systému, implementace, testování, nasazení a údržba). Popište princip agilních metod vývoje a porovnejte je s vodopádovým modelem. Uveďte výhody a nevýhody obou metodik. Co je to verzovací systém a jakou má roli při vývoji software? Příklad.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Životní cyklus aplikace (SDLC)** | Etapy od nápadu po provoz a údržbu | Od zadání e-shopu po provoz a support |
| **Agilní vývoj** | Iterativní vývoj v krátkých cyklech s průběžnou zpětnou vazbou | Scrum sprinty po 2 týdnech |
| **Vodopádový model** | Postup po pevně navazujících fázích | Analýza -> návrh -> vývoj -> test -> nasazení |
| **Sprint** | Časově omezený blok práce v agile | Dvoutýdenní sprint s review |
| **Verzovací systém (VCS)** | Nástroj pro historii změn v kódu | Git, GitHub, GitLab |

---

## Etapy životního cyklu aplikace

### 1) Analýza požadavků
- Co má aplikace řešit, kdo je uživatel, jaké jsou cíle.
- Výstupy: funkční a nefunkční požadavky, priority.

### 2) Návrh systému
- Architektura, datový model, UI návrhy, technologie.
- Výstup: technický návrh a plán implementace.

### 3) Implementace
- Programování funkcionalit podle návrhu.
- Práce s úkoly, code review, průběžná integrace.

### 4) Testování
- Ověření kvality (unit, integrační, systémové testy).
- Hledání chyb před nasazením do produkce.

### 5) Nasazení (deployment)
- Přesun aplikace do produkčního prostředí.
- Konfigurace, migrace dat, monitoring.

### 6) Údržba a rozvoj
- Opravy chyb, bezpečnostní aktualizace, nové funkce.
- Dlouhodobá podpora a optimalizace.

---

## Agilní přístup vs vodopád

### Agilní vývoj

- Vývoj po malých krocích (iterace/sprinty).
- Častá komunikace s klientem, rychlá reakce na změny.
- Pravidelná demonstrace fungující části produktu.

### Vodopádový model

- Každá fáze je oddělená a následuje po předchozí.
- Změny později v projektu jsou dražší.
- Vhodné při stabilních a dobře známých požadavcích.

---

## Výhody a nevýhody metodik

| Metodika | Výhody | Nevýhody |
| -------- | ------ | -------- |
| **Agile** | Flexibilita, rychlá zpětná vazba, dřívější doručování hodnoty | Vyšší nároky na komunikaci, riziko scope creep |
| **Vodopád** | Jasný plán, předvídatelné fáze, silná dokumentace | Horší reakce na změny, pozdní odhalení problémů |

---

## Co je verzovací systém a jeho role

Verzovací systém (typicky Git) umožňuje:

- ukládat historii změn v kódu,
- vracet se ke starším verzím,
- pracovat paralelně přes větve (branches),
- bezpečně spojovat změny více vývojářů,
- dohledat kdo, kdy a proč změnu provedl.

Bez VCS je týmový vývoj výrazně rizikovější a hůře auditovatelný.

---

## Příklad v praxi

Tým vyvíjí školní aplikaci:

1. V analýze určí moduly (docházka, známky, rozvrh).
2. V agilním režimu plánuje sprinty po 2 týdnech.
3. Každý vývojář pracuje na své větvi v Gitu.
4. Po code review se změny mergují do hlavní větve.
5. Po testech se vydá nová verze, následně běží údržba.

---

## Shrnutí

- SDLC pokrývá analýzu, návrh, implementaci, testování, nasazení i údržbu.
- Agile je flexibilní a iterativní, vodopád je sekvenční a plánově pevný.
- Volba metodiky závisí na stabilitě požadavků a typu projektu.
- Verzovací systém je základ týmového vývoje, kontroly změn a bezpečného releasu.

---

## Materiály od učitele

Učitelský podklad upřesňuje praktickou část jako primitivní bug tracker v konzoli.

### Pro ty, co chtej vedet vic

- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)
