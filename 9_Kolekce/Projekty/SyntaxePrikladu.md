# Syntaxe k příkladům (téma 9 – kolekce)

Minimální ukázky k zadáním v [../Priklady.md](../Priklady.md).

Vstup/výstup: téma 1 – [../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md](../../1_ZakladniPojmyProgramovani/Projekty/SyntaxePrikladu.md).

---

## List```csharp
var kosik = new List<string>();
kosik.Add("mléko");
kosik.RemoveAt(kosik.Count - 1);
foreach (var x in kosik)
    Console.WriteLine(x);
```

---

## Stack

```csharp
var zasobnik = new Stack<char>();
zasobnik.Push('(');
if (zasobnik.Count > 0)
    char c = zasobnik.Pop();
```

---

## Queue

```csharp
var fronta = new Queue<string>();
fronta.Enqueue("dokument1.pdf");
string dalsi = fronta.Dequeue();
```

---

## Dictionary

```csharp
var mapa = new Dictionary<int, string>();
mapa[1] = "Anna";
if (mapa.TryGetValue(1, out string? jmeno))
    Console.WriteLine(jmeno);
```

---

## LinkedList

```csharp
var historie = new LinkedList<string>();
historie.AddLast("krok 1");
if (historie.Last != null)
    historie.RemoveLast();
foreach (var uzel in historie)
    Console.WriteLine(uzel);
```

---

## Mapování: příklad → typ| Příklad | Třída |
| ------- | ----- |
| 1 Košík | `List<string>` |
| 2 Závorky | `Stack<char>` |
| 3 Tisk | `Queue<string>` |
| 4 ID → jméno | `Dictionary<int, string>` |
| 5 Historie | `LinkedList<string>` |
