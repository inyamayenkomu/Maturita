# CSS

- Cascading Style Sheets - jazyk pro popis vzhledu a formátování webových stránek
- Používá se k oddělení obsahu (HTML) od prezentace (CSS)
- Umožňuje definovat styly pro různé elementy, třídy, id a další selektory
- Důležitý je koncept specificity a kaskády stylů, kdy se rozhoduje, které pravidlo se aplikuje, pokud je pro jeden element definováno více pravidel
  - Import stylu z *.css souboru (externí soubor)
  - Vložení css přímo do style elementu
  - Style attribut v html elementu

## Ukázka
```css
/* Základní styl pro celý dokument */
body {
    background-color: #f0f0f0;
    font-family: Arial, sans-serif;
}

/* Styl pro všechny h1 elementy */
h1 {
    color: #333333;
    text-align: center;
}

/* Styl pro element s id "main-content" */
#main-content {
    width: 80%;
    margin: 0 auto;
}

/* Styl pro elementy s třídou "highlight" */
.highlight {
    color: red;
    font-weight: bold;
}
```