# JavaScript

- Dynamický, interpretovaný jazyk pro tvorbu logiky na frontendu
- Nejpoužívanější způsob, jak pouštět logiku na frontendu
  - Historicky se používali i browser pluginy - tahle cesta už je dnes mrtvá
- Rozdíly oproti C#:
  - Pokud běží v prohlížeči, tak má velmi omezený přístup na souborový systém a celkově k HW
    - Omezení z důvodu bezpečnosti
    - Dnes už může běžet i mimo prohlížeč
  - JavaScript je dynamicky typovaný, zatímco C# je staticky typovaný
  - Implicit type coercion (implicitní konverze typů) [https://dorey.github.io/JavaScript-Equality-Table/](https://dorey.github.io/JavaScript-Equality-Table/)
  - Typy v JS:
    - Primitivní typy: Number, String, Boolean, Undefined, Null
    - Složené typy: Object
  - JavaScript má volnější syntaxi a méně přísná pravidla než C#
  - JavaScript potřebuje interpreter, což je prohlížeč (nebo Node.js)
  - Textové řetězce se mohou uvozovat '' i "". Formátované řetězce se uvozují takto: `Ahoj ${foo}`.
  - JavaScript používá prototypové dědičnosti, zatímco C# používá třídní dědičnost
    - Objekty dědí přímo z jiných objektů
    - JS můžeme používat jako OOP jazyk, ale v praxi se to moc nedělá
    - Function-soup architektura :)

## Ukázka
```javascript
// Deklarace proměnné
let x = 5;

// Funkce pro sčítání dvou čísel
function add(a, b) {
    return a + b;
}

// Volání funkce
let result = add(x, 10);
console.log(result); // Výstup: 15

// Cyklus for
for (let i = 0; i < 5; i++) {
    console.log(i);
}

// Cyklus forEach pro pole
let arr = [1, 2, 3];
arr.forEach(function(item) {
    console.log(item);
});
```

## JSON

- JavaScript Object Notation
- Formát pro strukturovaná data, který je snadno čitelný pro lidi i stroje
- Používá se pro přenos dat mezi klientem a serverem
- Podobný formát jako JavaScriptové objekty, ale s určitými omezeními (např. klíče musí být v uvozovkách)

Příklad JSON:

```json
{
    "name": "Alice",
    "age": 30,
    "isStudent": false,
    "hobbies": ["reading", "gaming", "coding"],
    "address": {
        "street": "123 Main St",
        "city": "Anytown",
        "country": "USA"
    }
}
```