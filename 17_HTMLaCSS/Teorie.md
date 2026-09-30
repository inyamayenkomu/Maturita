# 17. HTML a CSS

> Objasněte pojmy HTML, značka, atribut. Popište základní strukturu HTML dokumentu, demonstrujte základní prvky - odstavce, odkazy, obrázky, seznamy. Vysvětlete pojem CSS a popište, jak funguje. Možnosti napojení CSS do HTML. Popište pojmy třída a identifikátor. Jak funguje dědičnost kaskádových stylů? Příklad.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **HTML** | Značkovací jazyk určující strukturu webové stránky | Nadpis, odstavec, odkaz |
| **Značka (tag)** | Prvek HTML v lomených závorkách | `<p>`, `<a>`, `<img>` |
| **Atribut** | Doplňující informace u značky | `href`, `src`, `alt`, `class` |
| **CSS** | Jazyk stylů pro vzhled HTML prvků | Barva textu, velikost písma |
| **Třída / ID** | Selektory pro cílení stylů a skriptů | `.menu`, `#hlavicka` |

---

## HTML, značka, atribut

- **HTML (HyperText Markup Language)** popisuje obsah a strukturu stránky.
- **Značka (tag)** říká, co je daný obsah (nadpis, odstavec, seznam...).
- **Atribut** upřesňuje chování nebo vlastnosti značky.

Příklad:

```html
<a href="https://www.example.com" target="_blank">Otevri web</a>
```

- Značka: `<a>`
- Atributy: `href`, `target`

---

## Základní struktura HTML dokumentu

```html
<!doctype html>
<html lang="cs">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Moje stranka</title>
  </head>
  <body>
    <h1>Nadpis</h1>
    <p>Odstavec textu.</p>
  </body>
</html>
```

- `head` obsahuje metadata (kódování, název stránky, odkazy na CSS).
- `body` obsahuje viditelný obsah.

---

## Základní HTML prvky

| Prvek | Značka | Použití |
| ----- | ------ | ------- |
| **Odstavec** | `<p>` | Běžný text |
| **Odkaz** | `<a href="...">` | Přechod na jinou stránku |
| **Obrázek** | `<img src="..." alt="...">` | Zobrazení obrázku |
| **Nečíslovaný seznam** | `<ul><li>...</li></ul>` | Výčet bodů |
| **Číslovaný seznam** | `<ol><li>...</li></ol>` | Kroky v pořadí |

---

## Co je CSS a jak funguje

> **Přirovnání**: HTML je kostra domu, CSS je jeho vzhled - barva, velikost, rozložení.

- CSS (Cascading Style Sheets) určuje, jak mají HTML prvky vypadat.
- Styl se skládá ze **selektoru** a **deklarací**.

```css
p {
  color: navy;
  font-size: 18px;
}
```

- Selektor `p` cílí na všechny odstavce.
- Deklarace mění jejich vlastnosti.

---

## Možnosti napojení CSS do HTML

| Způsob | Jak | Kdy se hodí |
| ------ | --- | ----------- |
| **Inline** | Atribut `style` přímo u prvku | Jednorázová úprava |
| **Interní** | `<style>` v `<head>` | Jedna stránka |
| **Externí** | Soubor `.css` přes `<link>` | Víc stránek, nejlepší praxe |

```html
<link rel="stylesheet" href="styles.css" />
```

---

## Třída a identifikátor

- **Třída (`class`)** může být použita na více prvcích.
- **Identifikátor (`id`)** má být unikátní na stránce.

```html
<p class="info">Informacni text</p>
<h1 id="hlavni-nadpis">Moje stranka</h1>
```

```css
.info {
  color: green;
}

#hlavni-nadpis {
  text-transform: uppercase;
}
```

---

## Dědičnost a kaskáda stylů

- **Dědičnost**: některé vlastnosti (např. `color`, `font-family`) se přenáší z rodiče na potomky.
- **Kaskáda**: když pravidel platí víc, rozhoduje:
  1. priorita selektoru (specifičnost),
  2. pořadí v souboru (pozdější vyhrává),
  3. `!important` (má nejvyšší prioritu, ale nemá se nadužívat).

---

## Příklad v praxi

1. V HTML vytvoříš seznam úkolů (`<ul><li>`).
2. Přidáš třídu `.todo-item`.
3. V externím `styles.css` nastavíš barvu, mezery a rámeček.
4. Nadpisu dáš `id="hlavni-nadpis"` pro speciální vzhled.

Výsledek: obsah je oddělen od vzhledu, stránka se snadno upravuje a škáluje.

---

## Shrnutí

- HTML definuje strukturu stránky, CSS její vzhled.
- Značka určuje typ prvku, atribut nese detailní nastavení.
- CSS jde připojit inline, interně nebo externě (doporučeno externě).
- `class` je opakovatelná, `id` je unikátní.
- Dědičnost a kaskáda určují, které styly se nakonec použijí.

---

## Materiály od učitele

Sekce vychází z `Html.md` a `Css.md`.

### HTML (z `Html.md`)

- HTML je jazyk struktury a obsahu, ne vzhledu.
- Typické elementy: `html`, `head`, `title`, `body`, `h1..h3`, `p`, `ul/li`, `a`, `img`.
- Zdroj zdůrazňuje, že HTML syntaxe je volnější než XAML (prohlížeč často zvládne i méně striktní zápis).

### CSS (z `Css.md`)

- CSS řeší prezentaci (barvy, písmo, rozložení), zatímco HTML obsah.
- Podporuje selektory prvků, tříd a ID.
- Způsoby připojení: externí soubor, `<style>` blok, inline `style`.
- Pro konflikty pravidel rozhoduje kaskáda a specifičnost.

### Pro ty, co chtej vedet vic

- [Html.md](Materialy/Html.md)
- [Css.md](Materialy/Css.md)
