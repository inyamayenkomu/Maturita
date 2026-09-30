# 16. Web a internetové prohlížeče – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: HTTP simulace - GET

Napište konzolovou aplikaci v C#, která:

- Simuluje zjednodušený zpravodajský web `noviny.local`.
- Podporuje routy `GET /`, `GET /sport`, `GET /ekonomika`, `GET /pocasi`.
- Pro každou route vrací přesně:
  - `GET /` -> `200 OK`, body: `Vitej na noviny.local`
  - `GET /sport` -> `200 OK`, body: `Sport: Banik vyhral 2:1`
  - `GET /ekonomika` -> `200 OK`, body: `Ekonomika: Inflace klesla`
  - `GET /pocasi` -> `200 OK`, body: `Pocasi: 21C, polojasno`
- Při neexistující route vrací `404 Not Found`.

---

## Příklad 2: HTTP simulace - GET + POST

Napište konzolovou aplikaci v C#, která:

- Simuluje web školního helpdesku `helpdesk.skola.local`.
- `POST /ticket` založí nový ticket (jméno, třída, problém).
- `POST /ticket` vrací:
  - `201 Created`, body: `Ticket #<id> vytvoren`
  - `400 Bad Request`, body: `Chybi jmeno/trida/problem`
- `GET /tickets` vrací:
  - `200 OK`, body: seznam ticketů ve formátu `#id | jmeno | trida | problem`

---

## Příklad 3: HTTP simulace - dva typy serveru

Napište konzolovou aplikaci v C#, která:

- Simuluje dva konkrétní weby: `eshop.local` a `api.eshop.local`.
- `eshop.local` vrací:
  - `GET /` -> `200 OK`, body: `<h1>Eshop</h1>`
  - `GET /produkty` -> `200 OK`, body: `<ul><li>Notebook</li><li>Mys</li></ul>`
  - `GET /kontakt` -> `200 OK`, body: `<p>kontakt@eshop.local</p>`
- `api.eshop.local` vrací:
  - `GET /api/products` -> `200 OK`, body: `[{ "id":1,"name":"Notebook" },{ "id":2,"name":"Mys" }]`
  - `GET /api/product/1` -> `200 OK`, body: `{ "id":1,"name":"Notebook","price":19999 }`
- Pro neznámou route na obou hostech vrací `404 Not Found`.
- Uživatel zadá host + route a program vypíše `host`, `status`, `response body`.

---

## Příklad 4: HTTP simulace - session token

Napište konzolovou aplikaci v C#, která:

- Simuluje studentský portál `portal.zaci.local`.
- Podporuje `POST /login` (uživatel, heslo) a `GET /rozvrh`.
- `POST /login` vrací:
  - `200 OK`, body: `TOKEN:abc123` (při správných údajích)
  - `401 Unauthorized`, body: `Spatne prihlasovaci udaje`
- `GET /rozvrh` vrací:
  - `200 OK`, body: `Po: MAT, Ut: INF, St: AJ`
  - `401 Unauthorized`, body: `Neplatny nebo chybejici token`

---

## Příklad 5: HTTP simulace - mini proxy log

Napište konzolovou aplikaci v C#, která:

- Simuluje školní proxy mezi klientem a weby `seznam.local`, `wikipedia.local`, `neexistuje.local`.
- Každý request loguje: čas, host, metoda, route, status.
- Umožní vypsat jen požadavky na konkrétní web (např. jen `wikipedia.local`).
- Simulované odpovědi backendu:
  - `seznam.local` -> typicky `200 OK`
  - `wikipedia.local` -> typicky `200 OK`
  - `neexistuje.local` -> `502 Bad Gateway` nebo `404 Not Found`
- Vypíše statistiku odpovědí (`2xx`, `4xx`, `5xx`) pro každý web zvlášť.
