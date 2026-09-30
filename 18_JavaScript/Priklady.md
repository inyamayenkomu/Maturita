# 18. JavaScript – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Řetězení dotazů na API

Napište skript v JavaScriptu, který z veřejného read-only API postupně získá související data (např. uživatel → jeho příspěvky → komentáře u jednoho příspěvku):

- Použijte síťový dotaz přes `fetch` a práci s JSON odpovědí.
- Při chybě HTTP nebo rozbitém těle odpovědi musí být chování předvídatelné (uživatel / konzole dostane srozumitelnou informaci a řetěz se nesmí „rozjet“ do dalších kroků bez kontroly).

---

## Příklad 2: Více dotazů najednou

Napište skript, který pro sadu identifikátorů stáhne paralelně více zdrojů a výsledek sloučí:

- Pokud část dotazů selže, výstup musí ukázat, co se povedlo a co ne (alespoň na úrovni id nebo URL).
- Strategii pro částečný neúspěch si zvolte a stručně ji zdůvodněte v komentáři k řešení.

---

## Příklad 3: Odeslání dat metodou POST

Napište skript, který odešle nový záznam na veřejné testovací API (např. fiktivní příspěvek nebo objednávku podle dokumentace služby):

- Tělo požadavku musí být ve formátu JSON a serverová odpověď se má ověřit (alespoň kontrola, že odpověď dává smysl vůči odeslaným datům).
- Chyby sítě a neočekávané odpovědi nesmí skončit „tichým pádem“.

---

## Příklad 4: Jednoduchá stránka jako klient

Připravte malou webovou stránku s ovládacími prvky, která:

- Načte seznam záznamů ze statického JSON souboru v projektu a zobrazí ho uživateli.
- Po výběru záznamu načte detail z druhého zdroje (druhý statický soubor nebo druhý dotaz – podstatné je, že jde o dva samostatné kroky načtení).
- Uživatel vidí rozlišení stavů načítání, úspěchu a chyby.

---

## Příklad 5: Stejná logika dvěma styly

Vezměte scénář z příkladu 1 a napište druhou variantu řešení, která dává stejné výsledky, ale používá jiný styl zápisu asynchronní práce než první varianta:

- Krátce shrňte výhody a nevýhody obou stylů z pohledu čitelnosti a práce s chybami.
