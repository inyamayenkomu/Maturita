# 11. Desktopové aplikace

> Popište strukturu desktopové aplikace. Definujte pojem událost. Vyjmenujte základní ovládací prvky a způsoby jejich využití. Uveďte příklady využití ovládacích prvků. K čemu slouží dialogová okna, jaké druhy dialogových oken znáte?

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **XAML** | Deklarativní jazyk pro popis rozhraní (WPF) – co kde je a jak to vypadá | Plán pokoje – nábytek na papíře, ne samotný nábytek |
| **Code-behind** | C# kód navázaný na okno – logika, reakce na události | Elektrikář – zapojení za tím, co vidíš na stěně |
| **Událost (event)** | Signál, že se něco stalo (klik, změna textu) | Zvonek u dveří – někdo zazvonil |
| **Event handler** | Metoda, která se zavolá při události | Když zazvoní zvonek, otevřeš dveře |
| **Modální dialog** | Okno, které musíš zavřít dřív, než pokračuješ v hlavním | Potvrzení „Opravdu smazat?“ |

---

## Struktura desktopové aplikace (WPF)

> **Přirovnání**: XAML je **návrh obýváku** (kde je gauč, lampa), code-behind je **co se stane**, když někdo stiskne vypínač.

### Hlavní části

| Část | Úloha |
| ---- | ----- |
| **XAML** | Definice UI – rozložení, ovládací prvky, vzhled (XML-like syntaxe). |
| **Code-behind** | C# – obsluha událostí, výpočty, práce s daty. |
| **MVVM** | Model–View–ViewModel – oddělení logiky od vzhledu (pokročilejší architektura). |
| **Resources** | Styly, šablony, převodníky v XAML pro opakované použití. |
| **App.xaml** | Globální nastavení aplikace, startovací okno, sdílené zdroje. |

```
┌─────────────────────────────────────────────────────────┐
│  WPF APLIKACE                                           │
│                                                         │
│   XAML (MainWindow.xaml)     Code-behind (.xaml.cs)     │
│   ─────────────────────      ─────────────────────      │
│   Jak to vypadá              Co se děje při kliknutí   │
│   Button, TextBox...         Button_Click() { ... }     │
└─────────────────────────────────────────────────────────┘
```

---

## Událost (event)

- **Definice**: Reakce na akci uživatele nebo systému (klik myší, načtení okna, změna textu).
- **Obsluha**: V XAML např. `Click="Button_Click"`, v C# metoda `private void Button_Click(object sender, RoutedEventArgs e)`.

```xml
<Button Content="Klikni" Click="Button_Click" />
```

```csharp
private void Button_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Ahoj!");
}
```

---

## Základní ovládací prvky

| Prvek | Využití |
| ----- | ------- |
| **Button** | Spuštění akce (odeslání, uložení). |
| **TextBox** | Zadávání textu od uživatele. |
| **Label** | Popisky u vstupů (needitovatelný text). |
| **ComboBox** | Výběr jedné možnosti z rozbalovacího seznamu. |
| **ListBox** | Seznam položek, výběr jedné nebo více. |
| **DataGrid** | Tabulkové zobrazení dat (řádky/sloupce). |
| **CheckBox** | Ano/ne, více nezávislých voleb. |
| **RadioButton** | Právě jedna možnost ve skupině (např. pohlaví). |
| **Image** | Zobrazení obrázku. |
| **Slider** | Nastavení hodnoty posunem (hlasitost, jas). |

### Příklady využití

- **TextBox** – jméno uživatele při registraci.
- **DataGrid** – seznam produktů v administraci.
- **RadioButton** – výběr dopravy (osobně / poštou).
- **Slider** – hlasitost v přehrávači.

---

## Dialogová okna

- **Účel**: Krátká interakce s uživatelem – potvrzení, výběr souboru, upozornění.

### Druhy

| Typ | Popis | Příklad |
| --- | ----- | ------- |
| **Modální** | Blokuje hlavní okno, dokud dialog neuzavřeš. | `MessageBox.Show("Uložit změny?")` |
| **Nemodální** | Hlavní okno zůstane použitelné. | Vyhledávací panel, nápověda. |
| **Souborové** | Výběr cesty k souboru. | `OpenFileDialog`, `SaveFileDialog` |
| **Vlastní** | Vlastní XAML okno (přihlášení, nastavení). | Custom Window |

```csharp
MessageBox.Show("Uložit změny?", "Potvrzení", MessageBoxButton.YesNo);
// OpenFileDialog – výběr obrázku k nahrání
```

---

## Shrnutí

- **Struktura** – XAML (UI) + code-behind (logika); volitelně MVVM, App.xaml, resources.
- **Událost** – reakce na akci; obsluha přes event handler v C#.
- **Ovládací prvky** – Button, TextBox, Label, ComboBox, ListBox, DataGrid, CheckBox, RadioButton, Image, Slider.
- **Dialogy** – modální / nemodální, souborové, vlastní; MessageBox pro rychlé potvrzení.

---

## Materiály od učitele

Sekce vychází z `Udalosti.txt`.

- Událost implementuje princip „publisher -> subscribers“ (Observer).
- V C# je event definovaný jako delegát (`event EventHandler NazevUdálosti`).
- Registrace probíhá přes `+=`, odregistrace přes `-=`.
- Vyvolání události má kontrolovat `null` (nebo null-conditional syntaxi), aby nevznikla výjimka.
- Události jsou klíčové v GUI: kliknutí, změna textu, změna hodnoty komponenty.

### Pro ty, co chtej vedet vic

- [Udalosti.txt](Materialy/Udalosti.txt)
