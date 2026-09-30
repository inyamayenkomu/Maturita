# 16. Web a internetové prohlížeče

> Co je to internetový prohlížeč a k čemu slouží? Jaká je jeho role na bezpečnost na internetu? Vyjmenujte nejpoužívanější prohlížeče a jejich základní funkce. Vysvětlete pojmy cookies, web, URL, HTTP, HTTPS, cache. Jak funguje historie v prohlížeči? Příklad.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Webový prohlížeč** | Program, který načítá a zobrazuje webové stránky | Chrome otevře stránku školy |
| **URL** | Adresa zdroje na webu | `https://www.seznam.cz` |
| **HTTP / HTTPS** | Protokol pro přenos webových dat (HTTPS je šifrovaný) | Přihlášení do banky přes HTTPS |
| **Cookie** | Malý soubor s informacemi o uživateli/schůzce | Přihlášení zůstane aktivní |
| **Cache** | Dočasně uložené soubory webu pro rychlejší načítání | Obrázky stránky se načtou rychleji podruhé |

---

## Co je internetový prohlížeč

> **Přirovnání**: Prohlížeč je jako **tlumočník mezi člověkem a webem** - z kódu webu (HTML, CSS, JS) udělá stránku, se kterou umíš pracovat.

- Umožňuje otevírat webové stránky, vyhledávat informace a používat webové aplikace.
- Komunikuje se servery přes protokoly HTTP/HTTPS.
- Zpracovává HTML, CSS a JavaScript, ukládá historii, cookies a cache.

---

## Role prohlížeče v bezpečnosti

- Prohlížeč je první obranná vrstva uživatele na webu.
- Kontroluje certifikáty HTTPS a varuje u nedůvěryhodných webů.
- Blokuje nebezpečný obsah (škodlivé skripty, phishingové stránky) podle bezpečnostních databází.
- Nabízí anonymní režim, správu oprávnění webu (kamera, mikrofon, poloha) a správce hesel.

| Bezpečnostní funkce | K čemu slouží |
| ------------------- | ------------- |
| **HTTPS kontrola** | Ověření, že spojení je šifrované a certifikát je platný |
| **Sandbox panelů** | Izolace panelů a procesů, aby chyba v jednom neohrozila celý systém |
| **Aktualizace** | Opravy známých zranitelností |
| **Safe Browsing** | Upozornění na podvodné a škodlivé stránky |

---

## Nejpoužívanější prohlížeče a základní funkce

| Prohlížeč | Typické vlastnosti |
| --------- | ------------------ |
| **Google Chrome** | Rychlost, široká podpora rozšíření, synchronizace účtu |
| **Mozilla Firefox** | Důraz na soukromí, otevřenost, rozsáhlé nastavení |
| **Microsoft Edge** | Integrace s Windows, režim kompatibility, úspora energie |
| **Safari** | Optimalizace pro Apple zařízení, nízká spotřeba baterie |
| **Opera / Brave** | Vestavěné blokování reklam, orientace na soukromí |

**Základní funkce společné prohlížečům**:
- Panely, záložky, historie, stahování.
- Správa hesel a automatické vyplňování formulářů.
- Režim soukromého prohlížení a práce s rozšířeními.

---

## Web, URL, HTTP, HTTPS, cookies, cache

| Pojem | Vysvětlení |
| ----- | ---------- |
| **Web** | Systém propojených stránek a služeb dostupných přes internet. |
| **URL** | Jednoznačná adresa zdroje (protokol + doména + cesta). |
| **HTTP** | Nešifrovaný přenos webových dat. |
| **HTTPS** | HTTP přes TLS - data jsou šifrovaná a server má certifikát. |
| **Cookies** | Data uložená v prohlížeči (např. relace, preference, sledování). |
| **Cache** | Lokální kopie souborů stránky pro rychlejší opětovné načtení. |

---

## Jak funguje historie v prohlížeči

- Prohlížeč si ukládá seznam navštívených URL, čas návštěvy a často i název stránky.
- Historie slouží pro rychlý návrat na dříve otevřený web a návrhy ve vyhledávacím řádku.
- Může se synchronizovat mezi zařízeními při přihlášení k účtu.
- Uživatel historii může ručně smazat, případně používat anonymní režim (ten běžnou historii neukládá).

---

## Příklad v praxi

1. Otevřeš `https://www.idnes.cz` v prohlížeči.
2. Prohlížeč ověří HTTPS certifikát, stáhne HTML/CSS/JS.
3. Část obsahu uloží do cache, aby se při příští návštěvě načetla rychleji.
4. Do cookies se uloží jazyk webu a případně přihlášená relace.
5. URL se uloží do historie pro snadné znovuotevření.

---

## Shrnutí

- Prohlížeč zobrazuje webové stránky a zajišťuje práci s webovými aplikacemi.
- Bezpečnostní role: kontrola HTTPS, izolace procesů, varování před podvody, aktualizace.
- Důležité pojmy: web, URL, HTTP/HTTPS, cookies, cache.
- Historie je záznam navštívených stránek, který lze spravovat nebo mazat.

---

## Materiály od učitele

Učitelský podklad navazuje na praktické zadání se simulací jednoduchého HTTP serveru.

### Pro ty, co chtej vedet vic

- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)
