# 13. Textový editor

> Popište význam a možnosti textových editorů. Předveďte formátování odstavců, oddílů, stránek, celého dokumentu. Popište a demonstrujte výhody použití stylů. Vysvětlete pojmy prostý text a formátovaný text, jaké jsou jejich výhody? Vysvětlete pojem kódování textu.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Odstavec** | Blok textu s vlastním formátováním | Jedna myšlenka = jeden odstavec |
| **Oddíl** | Část dokumentu s vlastním rozložením stránky | Kapitola s jinými okraji než titulní strana |
| **Styl** | Pojmenovaná sada formátování (písmo, mezery, odsazení) | „Nadpis 1“ – vždy stejně velké a tučné |
| **Prostý text** | Jen znaky bez formátování | Poznámka v .txt |
| **Formátovaný text** | Text + vzhled, obrázky, tabulky | Diplomová práce v Wordu |
| **Kódování textu** | Mapování znaků na bajty v souboru | UTF-8, Windows-1250 |

---

## Význam a možnosti textových editorů

> **Přirovnání**: Textový editor (např. Microsoft Word, LibreOffice Writer) je jako **profesionální tiskárna s šablonami** – nejen píšeš, ale upravuješ vzhled, strukturu a můžeš generovat obsah.

- Tvorba a úprava dokumentů na úrovni vhodné pro školu, práci, úřad.
- Vkládání obrázků, tabulek, kontrola pravopisu, generování obsahu a rejstříků.
- Šablony a styly pro opakované typy dokumentů.

---

## Formátování dokumentu

### Odstavec

| Možnost | Popis |
| ------- | ----- |
| Zarovnání | Vlevo, na střed, vpravo, do bloku. |
| Odsazení | Levý/pravý okraj odstavce, odsazení prvního řádku. |
| Řádkování | Jednoduché, 1,5, dvojité. |
| Odrážky / číslování | Seznamy. |

### Oddíly

- Dokument rozdělíš na **oddíly** – každý může mít jiné okraje, záhlaví, zápatí, počet sloupců.
- Příklad: titulní strana bez čísla stránky, hlavní text s číslováním od 1.

### Stránky

- Okraje (horní, dolní, levý, pravý).
- Orientace na výšku / na šířku.
- Číslování stránek, záhlaví a zápatí.

### Celý dokument

- Motivy (barvy, písma).
- Vodoznak.
- Hromadná korespondence (šablona + data).

```
[Odstavec]
├─ Zarovnání: do bloku
├─ Odsazení prvního řádku: 1,25 cm
├─ Řádkování: 1,5
└─ Okraje stránky: vlevo 3 cm, vpravo 2 cm
```

---

## Výhody stylů

| Výhoda | Popis |
| ------ | ----- |
| **Konzistence** | Všechny nadpisy stejné – změníš styl jednou, platí všude. |
| **Úspora času** | Nemusíš ručně měnit každý nadpis zvlášť. |
| **Automatizace** | Obsah, navigace – staví se z nadpisů se styly. |

**Příklady stylů**: Nadpis 1, Nadpis 2, Normální, Citace (kurzíva, odsazení).

> **Přirovnání**: Styl je jako **uniforma** – všichni stejného typu vypadají stejně; změníš vzor uniformy a všichni se přizpůsobí.

---

## Prostý text vs. formátovaný text

| | Prostý text (.txt) | Formátovaný text (.docx, .odt) |
| --- | --- | --- |
| **Výhody** | Malá velikost, čte ho kdekoliv, vhodné pro kód, konfiguraci | Grafika, tabulky, profesionální vzhled |
| **Nevýhody** | Žádné tučné, barvy, obrázky | Větší soubor, potřebuješ kompatibilní program |

---

## Kódování textu

> 🔤 **Přirovnání**: Kódování je jako **slovník mezi písmeny a čísly** – počítač neukládá „A“, ale číslo (bajt nebo sekvenci bajtů), podle kterého znak pozná.

- **Definice**: Pravidla, jak se **znaky převádějí na bajty** v souboru a zpět.
- Bez správného kódování vzniká **„rozsypaný čaj“** – špatně zobrazené háčky a čárky.

| Kódování | Popis |
| -------- | ----- |
| **ASCII** | 128 znaků (angličtina, čísla) – nestačí pro češtinu |
| **Windows-1250** | Starší kódování pro středoevropské jazyky (Windows) |
| **Unicode** | Univerzální sada znaků pro všechny jazyky světa |
| **UTF-8** | Nejpoužívanější zápis Unicode – kompatibilní s ASCII, standard na webu |

### Důležité rozlišení

| Pojem | Co to je |
| ----- | -------- |
| **Kódování** | Jak jsou znaky uloženy v souboru (UTF-8, …) |
| **Font (písmo)** | Jak znaky vypadají na obrazovce – font nevyřeší špatné kódování |

### Praktické tipy

- U `.txt` souborů vždy znát kódování (UTF-8 vs. Windows-1250).
- V editoru (Word) lze při ukládání zvolit kódování; u moderních `.docx` je Unicode standard.
- **BOM** (Byte Order Mark) – volitelná hlavička souboru označující UTF-8/UTF-16.

---

## Příklad v praxi (akademická práce)

1. Styly **Nadpis 1** pro kapitoly.
2. Automatický **obsah** z nadpisů.
3. **Oddíly** pro abstrakt vs. hlavní text (jiná záhlaví).
4. **Číslování stránek** od zadané kapitoly.

---

## Shrnutí

- Textové editory slouží k profesionální tvorbě dokumentů včetně multimédií a automatizace.
- **Formátování** – odstavec, oddíl, stránka, celý dokument.
- **Styly** – konzistence, rychlost, automatický obsah.
- **Prostý text** – jednoduchost a univerzálnost; **formátovaný** – vzhled a struktura.
- **Kódování textu** – mapování znaků na bajty (UTF-8, Unicode); špatné kódování = rozsypaný čaj.
