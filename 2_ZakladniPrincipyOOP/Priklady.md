# 2. Základní principy OOP – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: Evidence zakázek

Navrhněte v C# malý model evidence zakázek:

- Zakázka má jednoznačný identifikátor, který se po vytvoření nemění, dále název a cenu; zvenku nesmí jít obejít pravidla modelu „přímou úpravou pole“.
- Změna názvu nebo ceny musí projít přes rozhraní třídy; neplatná hodnota se neuloží a uživatel (konzole) dostane vysvětlení.
- Evidence umí zakázky přidávat, vyhledat podle id, spočítat celkovou hodnotu a průměrnou cenu.
- V ukázkovém scénáři přidejte několik zakázek, jednu upravte a výsledky shrňte výpisem.

---

## Příklad 2: Pokladna a různé typy plateb

Navrhněte v C# model pokladny, kde se platby chovají různě, ale společné rozhraní zůstává stejné:

- Existuje několik druhů platby (např. hotovost, karta, převod); každý druh umí říct částku a lidsky čitelný popis.
- U karty dává smysl držet jen omezené veřejné údaje o platební kartě (např. maskované číslo) a validovat je.
- Pokladna umí vypsat všechny platby a celkovou částku bez toho, aby volající musel rozlišovat konkrétní typ ručně u každého řádku.
- Přidejte export do textu, kde se podoba výpisu liší podle typu platby (rozšíření bez rozbití stávajícího kódu pokladny).

---

## Příklad 3: Dopravní prostředky a ceny jízdenek

Navrhněte hierarchii dopravních prostředků:

- Společný základ popisuje, co všechny prostředky umí (např. odhad ceny podle vzdálenosti).
- Konkrétní typy prostředků používají různá pravidla výpočtu ceny (např. jiné přirážky za vzdálenost).
- Alespoň jedna třída v hierarchii nesmí být dále důvodně děditelná; vysvětlete u ní proč.
- Ukázka: pro stejnou vzdálenost vypište cenu u více prostředků uložených společně v jedné kolekci nadřazeného typu.

---

## Příklad 4: Sklad a upozornění na nízké zásoby

Navrhněte třídu skladu a „notifikátory“, které reagují na stav zásob:

- Sklad umí přidat a odebrat množství; při nedostatku zboží odběr neprovede a musí to být z chování patrné.
- Když zásoba klesne pod vámi zvolenou hranici, sklad o tom informuje registrované posluchače (např. e‑mail a SMS jen jako výpis do konzole).
- Ukázka: několik odběrů až pod hranici, poté odhlášení jednoho posluchače a ověření, že už nedostává události.

---

## Příklad 5: Rozšiřitelné reporty

Navrhněte malý systém reportů nad fiktivními daty:

- Existuje několik druhů reportů se stejným způsobem spuštění (např. období „od–do“ předané jako pojmenované parametry).
- Uživatel v konzoli vybere typ reportu; neznámá volba se odmítne s nápovědou.
- Přidejte nový typ reportu tak, aby se neměnil hlavní „spouštěcí“ kód pro uživatele.
