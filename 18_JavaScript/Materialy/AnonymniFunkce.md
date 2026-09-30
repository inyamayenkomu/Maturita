# Anonymní funkce

Anonymní funkce, také známé jako lambda funkce, jsou funkce, které nemají jméno. Jsou často používány pro krátké a jednoduché operace, které nepotřebují být znovu použity jinde v kódu. V mnoha programovacích jazycích jsou anonymní funkce podporovány a mohou být definovány přímo v místě, kde jsou potřeba.

## Příklad v C#

```csharp
// Anonymní funkce pro sečtení dvou čísel
Func<int, int, int> sum = (a, b) => a + b;
int result = sum(5, 3); // result bude 8
```

## Příklad v JavaScriptu

V JavaScriptu je zápis stejný:

```javascript
// Anonymní funkce pro sečtení dvou čísel
const sum = (a, b) => a + b;
const result = sum(5, 3); // result bude 8
```

## Closures

Anonymní funkce mohou k sobě přibalit i další proměnné z okolního kontextu (closure):

```csharp
int multiplier = 2;
Func<int, int> multiply = x => x * multiplier;
int result = multiply(5); // result bude 10
```

## Další pojmy:

- Čistá funkce (pure function): Funkce, která nemá žádné vedlejší účinky a vždy vrací stejný výsledek pro stejné vstupy.
- Funkce vyššího řádu (higher-order function): Funkce, která může přijímat jiné funkce jako argumenty nebo vracet funkce jako výsledek.
- Funkce jako občan první kategorie (first-class citizen): Vlastnost programovacího jazyka, která umožňuje funkcím být přiřazovány do proměnných, předávány jako argumenty a vraceny z jiných funkcí.
- Lambda funkce (lambda function): Název vypůjčený z matematiky, často se používá jako synonymum pro anonymní funkce (např. v Pythonu).