# 15. Počítačové sítě a Internet

> Objasněte pojmy Intranet, Internet, WiFi, Ethernet, IP, TCP/IP, doména, DNS. Popište způsoby komunikace peer-to-peer, client-to-server, jejich výhody a nevýhody. Objasněte problematiku dynamických a statických IP adres.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Internet** | Celosvětová síť propojených počítačů | Web, e-mail, cloud |
| **Intranet** | Interní síť organizace | Firemní portál jen pro zaměstnance |
| **WiFi** | Bezdrátová síť (standard IEEE 802.11) | Internet v kavárně |
| **Ethernet** | Kabelová technologie v LAN (často RJ-45) | Kabel z PC do routeru |
| **IP adresa** | Číselná adresa zařízení v síti | `192.168.1.10` |
| **DNS** | Překlad doménových jmen na IP adresy | `www.seznam.cz` → IP |

---

## Intranet, Internet, WiFi, Ethernet

| Pojem | Popis |
| ----- | ----- |
| **Internet** | Globální síť propojující miliardy zařízení; komunikace přes standardizované protokoly (TCP/IP). |
| **Intranet** | Privátní síť organizace s webovými technologiemi; přístup jen interně (např. docházka, dokumenty). |
| **WiFi** | Bezdrátové připojení přes rádiové vlny, rodina standardů 802.11 (2,4 GHz, 5 GHz). |
| **Ethernet** | Kabelová technologie pro lokální sítě; typické rychlosti 100 Mb/s, 1 Gb/s, 10 Gb/s. |

**Příklady**: WiFi – telefony a notebooky doma; Ethernet – herní PC pro stabilní ping a nízké zpoždění.

---

## IP adresa

> 🏠 **Přirovnání**: IP adresa je jako **poštovní adresa domu** – bez ní síť neví, kam doručit data.

- **Definice**: Unikátní (nebo dočasně přidělená) adresa zařízení v síti.
- **IPv4** – 4 bajty, zápis např. `192.168.1.1` (cca 4 miliardy adres).
- **IPv6** – delší adresa kvůli vyčerpání IPv4, např. `2001:0db8::1`.

| Typ IP | Popis |
| ------ | ----- |
| **Veřejná IP** | Viditelná na Internetu – přiřazuje ji poskytovatel (ISP) |
| **Privátní IP** | Adresa uvnitř lokální sítě (např. `192.168.x.x`, `10.x.x.x`) |

---

## TCP/IP

> 📦 **Přirovnání**: TCP/IP je jako **poštovní systém** – IP doručí balík na správnou adresu, TCP zajistí, že obsah dorazí celý a ve správném pořadí.

- **TCP/IP** – soubor protokolů pro komunikaci v síti (Internet i lokální sítě).
- **IP (Internet Protocol)** – směrování paketů podle IP adresy (bez záruky doručení).
- **TCP (Transmission Control Protocol)** – spolehlivé spojení, kontrola doručení, pořadí paketů (web, e-mail).
- **UDP (User Datagram Protocol)** – rychlejší, bez záruky doručení (stream videa, online hry, DNS dotazy).

```
Aplikace (HTTP, e-mail)
        ↓
    TCP / UDP
        ↓
       IP
        ↓
  Ethernet / WiFi
```

---

## Doména a DNS

### Doména

- **Doména** – lidsky čitelné jméno serveru nebo služby na Internetu.
- Příklady: `www.google.com`, `skola.cz`, `mail.seznam.cz`.
- Domény tvoří **hierarchie**: `.cz` (TLD) → `skola.cz` → `www.skola.cz`.

### DNS (Domain Name System)

> 📞 **Přirovnání**: DNS je jako **telefonní seznam** – místo pamatování si čísla (IP) zadáš jméno (doménu).

- **Definice**: Systém překladu doménových jmen na IP adresy.
- Proces: prohlížeč se zeptá DNS serveru → dostane IP → naváže spojení.

```
Uživatel zadá: www.seznam.cz
        ↓
   DNS server
        ↓
   IP adresa (např. 77.75....)
        ↓
   Prohlížeč se připojí
```

- **DNS cache** – dočasné uložení překladů pro rychlejší opakovaný přístup.

---

## Dynamické vs. statické IP adresy

| | **Dynamická IP** | **Statická IP** |
| --- | --- | --- |
| **Přidělení** | Automaticky protokolem **DHCP** | Ručně nastavená nebo pevně přidělená ISP |
| **Platnost** | Může se měnit (po restartu routeru) | Zůstává stejná |
| **Výhody** | Jednoduchá správa, méně konfliktů, vhodné pro běžné uživatele | Stabilní adresa pro servery, vzdálený přístup, firemní služby |
| **Nevýhody** | Adresa se mění – horší pro hosting služeb | Nákladnější, nutná správa, riziko konfliktu při špatném nastavení |
| **Příklad** | Domácí WiFi – telefon dostane IP od routeru | Webový server firmy s pevnou adresou |

**DHCP (Dynamic Host Configuration Protocol)** – router automaticky přidělí IP, masku, bránu a DNS klientovi.

---

## Peer-to-peer vs. client-to-server

### Peer to peer (P2P)

- Uzly jsou si **rovny** – sdílejí přímo mezi sebou, bez jednoho centrálního serveru.

| Výhody | Nevýhody |
| ------ | -------- |
| Žádný centrální server, nižší náklady u malých sítí | Horší správa velkých sítí, bezpečnost |
| Odolnost – výpadek jednoho uzlu nezastaví vše | |

**Příklad**: BitTorrent, historicky sdílení souborů v malé síti.

### Client–server

- **Klient** žádá službu, **server** ji poskytuje (web, e-mail, databáze).

| Výhody | Nevýhody |
| ------ | -------- |
| Centralizovaná správa, zálohy, bezpečnost | Závislost na serveru (single point of failure) |
| Jasná role a škálování | Vyšší náklady na provoz serveru |

**Příklad**: Prohlížeč (klient) a webový server.

```
P2P:     A ◄──► B ◄──► C     (vzájemně)

Client-server:  Klienti ──► Server ◄──► Databáze
```

---

## Shrnutí

- **Internet** – celosvětová síť; **Intranet** – privátní síť firmy.
- **WiFi** – bezdrát; **Ethernet** – kabel v LAN.
- **IP adresa** – identifikace zařízení; **TCP/IP** – protokoly pro spolehlivou síťovou komunikaci.
- **Doména** – lidsky čitelné jméno; **DNS** – překlad domény na IP.
- **Dynamická IP** (DHCP) – mění se, vhodná pro běžné klienty; **statická IP** – pevná, vhodná pro servery.
- **P2P** – rovnocenné uzly; **client–server** – centrální server obsluhuje klienty.

---

## Materiály od učitele

Ukázkové zadání od učitele obsahuje i směr k praktické části (simulace DNS/DHCP) a organizaci maturitní zkoušky.

### Pro ty, co chtej vedet vic

- [MaturitniPrubeh_a_Opakovani_od_ucitele.md](../misc/MaturitniPrubeh_a_Opakovani_od_ucitele.md)
