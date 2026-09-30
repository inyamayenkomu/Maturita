# 6. Číselné soustavy – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje – jde jen o zadání.

**Syntaxe a nápověda k C#:** [Projekty/SyntaxePrikladu.md](Projekty/SyntaxePrikladu.md)

---

## Příklad 1: IPv4 adresa jako 32 bitů

Napište konzolovou aplikaci v C#, která:

- Načte platnou IPv4 adresu a ukáže ji jako jednu 32bitovou hodnotu v desítkové i šestnáctkové podobě.
- Umožní vybrat jeden oktet a zobrazit ho jako osmibitový binární zápis.
- Při neplatném oktetu uvede, která část adresy je špatně.

---

## Příklad 2: Práva jako bitová maska

Napište konzolovou aplikaci v C#, která pracuje s právy reprezentovanými bity (čtení, zápis, mazání, administrace apod. podle vašeho návrhu):

- Uživatel zadá dvě masky v šestnáctkovém tvaru; program je zobrazí i v binární podobě.
- Ukažte, která práva jsou společná, která po doplnění přibudou a jak vypadá inverze masky – výsledky musí být lidsky čitelné (ne jen číslo bez vysvětlení).

---

## Příklad 3: Hlavička paketu

Napište konzolovou aplikaci v C#, která z malých políček informací (verze, typ, délka apod.) složí jedno 32bitové slovo a zase ho rozloží zpět:

- Po složení a rozložení musí sedět všechny původní hodnoty.
- Výstup obsahuje i přehled v hexadecimální podobě.

---

## Příklad 4: Převod mezi soustavami

Napište konzolovou aplikaci v C#, která převede zápis čísla z jedné soustavy (2–16) do jiné (2–16):

- Odmítne znaky, které v daném základu nemohou existovat.
- Musí hlásit případ, kdy mezivýsledek nebo výsledek nepojme zvolený typ bez ztráty informace.

---

## Příklad 5: Binární část desetinného zlomku

Napište konzolovou aplikaci v C#, která pro zlomek tvaru `1/n` ukáže začátek binárního zápisu za binární tečkou:

- U délky výpisu si stanovte rozumný limit a případnou periodu označte.
- Jednou větou propojte pozorování s přesností uložení reálných čísel v počítači.
