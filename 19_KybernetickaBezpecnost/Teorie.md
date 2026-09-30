# 19. Kybernetická bezpečnost

> Objasněte pojmy počítačový vir, spyware, phishing, spam, ransomware. V čem spočívá nebezpečí jednotlivých hrozeb? Popište způsoby obrany proti jednotlivým bezpečnostním hrozbám. Objasněte pojem DoS útok a princip jeho fungování. Co je to end-to-end šifrování? Příklad.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Počítačový vir** | Škodlivý kód, který se šíří a napadá systém | Infikovaná příloha e-mailu |
| **Spyware** | Software tajně sbírající data o uživateli | Pegasus na mobilu, Superfish na noteboocích |
| **Phishing** | Podvodné vylákání citlivých údajů | Falešná stránka internetového bankovnictví |
| **Ransomware** | Malware, který zašifruje data a žádá výkupné | Zamčené firemní soubory |
| **DoS** | Útok zahlcením služby požadavky | Web školy je dočasně nedostupný |

---

## Hrozby a jejich nebezpečí

| Hrozba | Jak funguje | Riziko |
| ------ | ----------- | ------ |
| **Vir** | Vkládá se do souborů/programů a šíří se dál | Poškození dat, nestabilita systému |
| **Spyware** | Běží skrytě a sleduje aktivitu uživatele | Únik hesel, soukromých dat |
| **Phishing** | Vydává se za důvěryhodnou službu | Krádež identity a financí |
| **Spam** | Nevyžádané zprávy | Ztráta času, často nosič phishingu/malwaru |
| **Ransomware** | Zašifruje soubory a požaduje výkupné | Ztráta přístupu k datům, finanční škody |

---

## Slavné reálné příklady (co se opravdu stalo)

> U zkoušky stačí **jeden konkrétní příklad** k typu; níže jsou jména a situace, které se často zmiňují v médiích a bezpečnostních přehledech.

### Spyware (odposlech bez vědomí uživatele)

- **Pegasus (NSO Group)** – izraelský „vládní“ spyware na mobily; velký rozruch kolem **Projektu Pegasus** (2021), kdy novináři popsali cílené sledování politiků, aktivistů a reportérů přes zranitelnosti v telefonech (často i bez kliknutí na odkaz).
- **Superfish (Lenovo, 2014–2015)** – na některých noteboocích byl předinstalovaný software, který **zasahoval do šifrovaného prohlížení** (HTTPS) kvůli reklamám; uživatel to neinstaloval sám – typický případ „spyware / adware od výrobce“.
- **FinFisher / FinSpy** – komerční balík prodávaný státům jako sledovací nástroj; opakovaně unikaly informace o nasazení proti opozici a novinářům.
- **CoolWebSearch** – kdysi velmi rozšířený „pack“ prohlížečového spywaru: přesměrování vyhledávání, skryté stahování dalšího malwaru.

### Vir / červ (šíření napříč stroji)

- **ILOVEYOU (2000)** – e-mail „Miluji tě“ s přílohou `LOVE-LETTER-FOR-YOU.txt.vbs`; rozšířil se po celém světě během hodin a způsobil obří škody v podnicích.
- **Melissa (1999)** – makrovir ve Wordu; po otevření dokumentu rozeslal sám sebe z Outlooku kontaktům oběti – ukázka viru šířícího se přes **důvěřivé e-maily**.
- **Stuxnet (cca 2010)** – červ cílený na **průmyslové PLC** (centrifugy v Íránu); ukázka, že malware nemusí být jen „rozšířený spam“, ale přesně navržený útok na hardware.

### Phishing (podvodné vylákání údajů)

- **Útok na Twitter (2020)** – útočníci přesvědčili zaměstnance (telefonát / sociální inženýrství), získali přístup k interním nástrojům a rozšířili **podvodné tweety** (např. kryptopeníze).
- **CEO fraud (BEC)** – e-mail „jsem ředitel, pošli platbu hned“ na účet podvodníka; reálné firmy přišly o miliony, i když „technicky“ šlo jen o podvodnou zprávu.

### Spam (nevyžádaná pošta jako kanál)

- **Botnety Storm / Rustock** – miliony infikovaných PC rozesílaly spam; Rustock byl jeden z největších, než ho koordinovaně rozmontovaly bezpečnostní firmy a policie.
- **„Nigerijský princ“ (419)** – klasický podvodný řetězec v e-mailu (dědictví, poplatek předem); často spojený se spamem, i když samotný text nemusí být malware.

### Ransomware (výkupné za data)

- **WannaCry (2017)** – využití chyby ve Windows (**EternalBlue**); postihlo mimo jiné britské nemocnice **NHS** – zapamatovatelný příklad, proč záplatovat systémy.
- **NotPetya (2017)** – rozšíření přes účetní software v Ukrajině, obří výpadky u firem (např. **Maersk**); zvenčí jako ransomware, ve skutečnosti hlavně **ničivý útok**.
- **Colonial Pipeline (2021)** – útok na provozovatele ropovodu v USA; reálný dopad na zásobování benzinem (často citovaný „když ransomware zasáhne infrastrukturu“).

### DoS / DDoS (zahlcení služby)

- **Dyn (2016)** – útok na DNS firmy; uživatelům v USA „nepadly“ velké weby, protože nefungovalo rozlišení jmen adres.
- **GitHub (2018)** – obří DDoS; ukázka, že i velké platformy musí mít ochranu proti masovému provozu.

---

## Obrana proti bezpečnostním hrozbám

| Hrozba | Základní obrana |
| ------ | --------------- |
| **Vir / malware** | Antivirový software, aktualizace OS, neinstalovat neznámé programy |
| **Spyware** | Kontrola oprávnění aplikací, antimalware sken, bezpečné zdroje |
| **Phishing** | Kontrola URL, neotvírat podezřelé odkazy, vícefaktorové ověření (MFA) |
| **Spam** | Spam filtry, oddělený e-mail pro registrace, neodpovídat |
| **Ransomware** | Pravidelné offline zálohy, aktualizace, omezení práv uživatelů |

Obecná pravidla:
- Silná a unikátní hesla (ideálně správce hesel).
- Průběžné aktualizace systémů a aplikací.
- Školení uživatelů (lidský faktor je nejčastější slabina).

---

## DoS útok - princip

- **DoS (Denial of Service)** = útok na nedostupnost služby.
- Útočník pošle velké množství požadavků, server nestíhá odpovídat legitimním uživatelům.
- U varianty **DDoS** útočí mnoho zařízení najednou (botnet), proto je obrana složitější.

Možná obrana:
- Rate limiting (omezení počtu požadavků),
- firewall a WAF,
- CDN a ochranné anti-DDoS služby,
- škálování infrastruktury.

---

## End-to-end šifrování (E2EE)

- Data jsou zašifrována u odesílatele a dešifrována až u příjemce.
- Mezičlánky (server provozovatele, poskytovatel připojení) obsah nevidí.
- Zvyšuje soukromí komunikace (chaty, hovory, přenos souborů).

> **Přirovnání**: Jako zamčená schránka, ke které mají klíč jen dva lidé - odesílatel a příjemce.

---

## Příklad v praxi

Uživatel dostane e-mail: "Vaše banka vyžaduje okamžité přihlášení."

1. Zpráva je phishing - odkaz vede na falešný web.
2. Uživatel zkontroluje URL, zjistí podezřelou doménu a nic nevyplní.
3. E-mail nahlásí jako spam/phishing.
4. Díky MFA by útočník ani po získání hesla neměl plný přístup.

---

## Shrnutí

- Kybernetické hrozby zahrnují viry, spyware, phishing, spam a ransomware.
- Obrana stojí na kombinaci techniky (antivir, firewall, zálohy) a chování uživatele.
- DoS/DDoS cílí na dostupnost služby zahlcením.
- End-to-end šifrování chrání obsah komunikace před třetími stranami.

---

## Materiály od učitele

Učitelský podklad upřesňuje praktickou část jako jednoduchou šifru v konzoli.

### Pro ty, co chtej vedet vic

- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)
