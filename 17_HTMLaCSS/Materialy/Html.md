# HTML

- HyperText Markup Language
- Jazyk pro deklaraci struktury a obsahu webových stránek (nikoli však vzhled)
- Stejně jako XML nebo XAML se skládá z elementů a atributů
- Rozdíly oproti XAML (volnější syntaxe)
  - Nepárové elementy nemusí být ukončeny vůbec `<img>` nebo `<img />` jsou povoleny
  - Atributy HTML nemusí být vždy v uvozovkách
  - Elementy nemusí být správně zanořeny a ukončeny, přesto prohlížeč stránku vykreslí (u XAML by to vedlo k tvrdé chybě)
- Elementy:
  - `html`, `head`, `title`, `body`
  - `h1`, `h2`, `h3`, `p`
  - `ul`, `li`
  - `a`, `img` - používáme relativní cesty, nebo celou URL

## Ukázka
```html
<!DOCTYPE html>
<html>
<head>
    <title>Moje první webová stránka</title>
</head>
<body>
    <h1>Vítejte na mé první webové stránce!</h1>
    <p>Toto je jednoduchý příklad HTML dokumentu.</p>
    <ul>
        <li>První položka</li>
        <li>Druhá položka</li>
        <li>Třetí položka</li>
    </ul>
    <a href="https://www.example.com">Navštivte Example.com</a>
    <img src="obrazek.jpg" alt="Popis obrázku">
</body>
</html>
```