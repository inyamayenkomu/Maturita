## Průběh maturit

- Být na místě o něco dřív (alespoň 5 - 10 minut)
- U tažení otázek musí být předseda (bude se tahat až v učebně informatiky)
- Příprava je 30 minut (doporučuji rozdělit 20 minut příklad, 10 minut teorie), studenti přichází postupně
- Na přípravě budou k dispozici 4 PC s přihlášeným účtem maturant 1 - 4
  - Čistý účet, na ploše programy, které budete používat (VS, VS Code, SQLite, Office, Teams, Chrome)
  - Některé příklady mají přílohy (ty najdete také na ploše)
  - Bude tam teams přihlášený do maturant účtu
  - Vypracované úkoly se budou zipovat a posílat do teams účtu
  - U učitelského PC se stáhnou, rozbalí a budou se demonstrovat
- Používání Internetu je v malé míře povoleno, používání LLM je zakázáno
- Zkoušení je 15 minut
  - Začněte teorií, pokud chcete 1, měli byste být schopni mluvit samostatně k tématu cca 2 minuty
  - Poté se budeme případně ptát
  - Pak se budeme dívat na vypracovaný úkol
  - Dobře si rozvrhněte čas, i nedokončená práce se dá prezentovat, pokud je rozpracovaná dobře!

## Opakování

- Fetch řetězení v JavaScriptu

```javascript
fetch('https://api.example.com/data')
  .then(response => response.json())
  .then(data => {
    console.log(data);
    return fetch('https://api.example.com/other-data');
  })
  .then(otherResponse => otherResponse.json())
  .then(otherData => {
    console.log(otherData);
  })
  .catch(error => {
    console.error('Error:', error);
  });
```

## Struktura PC

- Druhy paměti
  - [Hierarchie pamětí](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgPZMdZ097yVKyuYsXm9olu946P0B4oUg1S5GSw_rR5KJYidhPeAoCCyT0ENIhB9aDEwk8xdwrFJSpe14k63awSMrpEtIMGkWRpSmQSAC8R7vncrHswkGEEoqyu6kHGPQufFe15z8Gk3IBMcKbNJhifwu27ymEKL9s4Ey1n6qWdsuj-vcHS_bFmTHIU9w/s1400/a.jpg)
  - [Rychlost pamětí](https://cs.brown.edu/courses/csci1310/2020/notes/assets/l10-storage-hierarchy.png)
- Jak funguje CPU
  - Instrukční sada (instrukce jako ADD, SUB, MUL, DIV, MOV, JMP)
  - Registry
  - Přerušení
  - Jádra
  - Control bus, data bus, address bus
  - Frekvence
- Ukázka příkladu:
  - Simulátor procesoru, který vykonává instrukce a má několik registrů (A, B, C):
    - Instrukce:
      - MUL A, 5
      - MUL A, B
      - INC C
      - PRINT A

## Vstupní a výstupní zařízení

- Síťová karta, bluetooth modul, wifi karta, monitor, myš, tiskárna
- Ukázka možného příkladu:
  - Napište konzolový program simulující chování hostitelského zařízení (PC) po připojení USB zařízení. Uživatel konzolové aplikace bude jednat jako libovolné zařízení připojené do USB portu (fotoaparát, flash paměťové médium, klávesnice).
    - Po připojení zařízení se provede série kroků:
      - Hostitelské zařízení pošle RESET signál, zařízení (uživatel) musí odpovědět „RESET“.
      - Hostitel se zeptá na maximální délku paketu v bytech, zařízení musí odpovědět číslem větším než 8 a menším než 4096.
      - Hostitel pošle READY signál, zařízení musí odpovědět „READY“.
      - Hostitel vygeneruje adresu pro připojené zařízení (číslo 0 – 127) a pošle ji.
      - Hostitel se zeptá na název zařízení. Zařízení odpoví textovým řetězcem o maximální délce 32 znaků.
      - Hostitel se zeptá na ID výrobce zařízení. Zařízení odpoví textovým řetězcem o maximální délce 32 znaků.
      - Hostitel se podívá do seznamu ovladačů k zařízení dle ID výrobce. Pokud ovladač nenajde, odpoví chybou. Pokud jej najde, zařízení mohou začít komunikovat.

## Počítačové sítě a Internet

- Úkázka příkladu:
  - Simulace jednoduché síťové služby: DNS nebo DHCP

## Web a prohlížeče

- Ukázka příkladu:
  - Simulace jednoduchého HTTP serveru

## Kybernetická bezpečnost

- Ukázka příkladu:
  - Jednoduchá šifra (dělali jsme jen jednu) => caesar cifre

## Souborový systém a nosiče informací

- Ukázka příkladu:
  - Procházení souborového systému v rekurzi

## Operační systémy

- Ukázka příkladu:
  - Simulace jednoduchého plánovače procesů

## Metodika vývoje software

- Ukázka příkladu:
  - Primitivní bug tracker v konzoli

