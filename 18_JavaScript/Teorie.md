# 18. JavaScript

> Popište vlastnosti, výhody a nevýhody jazyka JavaScript. Jak se dá JavaScript použít v HTML dokumentu? Jaké datové typy JavaScript podporuje? Popište pojmy kompilace, transpilace a interpretace. Příklad.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **JavaScript** | Skriptovací jazyk pro interaktivitu webu | Otevření menu po kliknutí |
| **Interpretace** | Kód se vykonává za běhu bez klasického předchozího překladu do strojáku | Spuštění JS v prohlížeči |
| **Kompilace** | Překlad zdrojového kódu do nižší formy před spuštěním | C/C++ před vytvořením `.exe` |
| **Transpilace** | Převod z jednoho vyššího jazyka do jiného | TypeScript -> JavaScript |
| **Runtime** | Prostředí, kde kód běží | Prohlížeč nebo Node.js |

---

## Vlastnosti JavaScriptu

- Vysokoúrovňový, dynamicky typovaný jazyk.
- Událostmi řízený model (klik, změna pole, načtení stránky).
- Podporuje funkcionální i objektový styl.
- Běží ve všech moderních prohlížečích a také na serveru (Node.js).

> **Přirovnání**: HTML je obsah, CSS vzhled, JavaScript je **chování stránky**.

---

## Výhody a nevýhody

| Výhody | Nevýhody |
| ------ | -------- |
| Běží přímo v prohlížeči bez instalace | Dynamické typování může vést k chybám |
| Velký ekosystém knihoven a frameworků | Rozdíly mezi prostředími (browser vs. server) |
| Umožňuje bohaté interaktivní aplikace | U velkých projektů může být složitější údržba bez disciplíny |
| Snadné propojení s HTML/CSS | Bezpečnostní rizika při špatném použití (např. XSS) |

---

## Jak použít JavaScript v HTML

### 1) Inline (nevhodné pro větší projekty)

```html
<button onclick="alert('Ahoj')">Klikni</button>
```

### 2) Interní skript

```html
<script>
  console.log("Ahoj z interniho skriptu");
</script>
```

### 3) Externí soubor (doporučeno)

```html
<script src="app.js" defer></script>
```

- `defer` zajistí spuštění až po načtení HTML.

---

## Datové typy v JavaScriptu

### Primitivní typy

- `string` - text
- `number` - čísla (celá i desetinná)
- `boolean` - `true` / `false`
- `null` - úmyslně prázdná hodnota
- `undefined` - hodnota není nastavena
- `bigint` - velmi velká celá čísla
- `symbol` - unikátní identifikátor

### Referenční typ

- `object` - objekty, pole, funkce, datum apod.

---

## Kompilace, transpilace, interpretace

| Pojem | Princip |
| ----- | ------- |
| **Kompilace** | Zdrojový kód se před spuštěním přeloží do nižší formy (často strojový kód). |
| **Transpilace** | Překlad z jednoho vyššího jazyka/syntaxe do jiné vyšší syntaxe. |
| **Interpretace** | Kód je vykonáván za běhu interpretem nebo runtime enginem. |

Poznámka:
- JavaScript je tradičně považovaný za interpretovaný jazyk, ale moderní enginy (V8, SpiderMonkey) používají i JIT kompilaci pro výkon.

---

## Příklad v praxi

Úloha: po kliknutí na tlačítko změnit text odstavce.

```html
<p id="stav">Vypnuto</p>
<button id="tlacitko">Prepni</button>
<script src="app.js" defer></script>
```

```javascript
const stav = document.getElementById("stav");
const tlacitko = document.getElementById("tlacitko");

tlacitko.addEventListener("click", () => {
  stav.textContent = stav.textContent === "Vypnuto" ? "Zapnuto" : "Vypnuto";
});
```

---

## Shrnutí

- JavaScript zajišťuje logiku a interaktivitu webu.
- Má silný ekosystém, ale vyžaduje disciplínu kvůli dynamickým typům.
- V HTML se napojuje inline, interně nebo externím souborem (nejlepší praxe).
- Podporuje primitivní i referenční datové typy.
- Důležité pojmy: kompilace, transpilace, interpretace.

---

## Materiály od učitele

Sekce vychází z `JavaScript.md` a z JS části `AnonymniFunkce.md`.

### Doplňky k vlastnostem JavaScriptu

- JavaScript je dynamicky typovaný, má implicitní konverze typů (type coercion).
- V prohlížeči běží v sandboxu s omezeným přístupem k systému.
- Běh je možný i mimo prohlížeč (např. Node.js).

### Datové typy a JSON

- Zdroj uvádí primitivní typy (`Number`, `String`, `Boolean`, `Undefined`, `Null`) a složený typ `Object`.
- Důležitý formát je JSON pro přenos strukturovaných dat mezi klientem a serverem.

### Anonymní/lambda funkce

- Krátké funkce bez jména (arrow syntaxe) jsou běžné jak v C#, tak v JavaScriptu.
- Podstatný pojem je closure (funkce nese kontext okolních proměnných).

### Pro ty, co chtej vedet vic

- [JavaScript.md](Materialy/JavaScript.md)
- [AnonymniFunkce.md](Materialy/AnonymniFunkce.md)
- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)
