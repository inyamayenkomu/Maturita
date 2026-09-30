# 6. Číselné soustavy

> Objasněte pojem číselná soustava. Využití číselných soustav v informatice. Jaké standardy pro zápis se používají? Význam dvojkové soustavy v informatice. Převody mezi číselnými soustavami.

---

## 📖 Slovníček pojmů


| Pojem             | Co to je                                              | Příklad z reálného světa                       |
| ----------------- | ----------------------------------------------------- | ---------------------------------------------- |
| **Základ (báze)** | Počet symbolů v soustavě – kolika „číslicemi“ počítáš | Desítková má základ 10 (0–9), dvojková 2 (0–1) |
| **Bit**           | Jedna dvojková číslice (0 nebo 1)                     | Zapnuto/vypnuto, ano/ne                        |
| **Byte**          | 8 bitů – základní jednotka v počítači                 | Jeden znak (např. 'A' = 65)                    |
| **Hexadecimální** | Soustava se základem 16 (0–9, A–F)                    | Zkrácený zápis binárních dat                   |
| **Pozice (váha)** | Místo číslice určuje její hodnotu                     | V 123 je 1 = stovky, 2 = desítky, 3 = jednotky |


---

## Pojem číselná soustava

> 🔢 **Přirovnání**: Číselná soustava je jako **abeceda pro čísla** – určuje, jaké symboly používáš a jak se z nich skládá hodnota. Desítková má 10 symbolů (0–9), dvojková jen 2 (0 a 1).

- **Definice**: Systém pro vyjádření čísel pomocí **symbolů** a **základu (báze)**. Hodnota čísla = součet (číslice × základ^pozice).

### Základní soustavy v informatice


| Soustava               | Základ | Symboly  | Příklad |
| ---------------------- | ------ | -------- | ------- |
| **Desítková (dec)**    | 10     | 0–9      | 42      |
| **Dvojková (bin)**     | 2      | 0, 1     | 101010  |
| **Osmičková (okt)**    | 8      | 0–7      | 52      |
| **Šestnáctková (hex)** | 16     | 0–9, A–F | 2A      |


```
┌─────────────────────────────────────────────────────────┐
│  DESÍTKOVÁ:  123 = 1×10² + 2×10¹ + 3×10⁰ = 100+20+3    │
│  DVOJKOVÁ:   101 = 1×2² + 0×2¹ + 1×2⁰ = 4+0+1 = 5      │
│  HEX:        2A  = 2×16¹ + 10×16⁰ = 32+10 = 42         │
└─────────────────────────────────────────────────────────┘
```

---

## Využití v informatice


| Soustava         | Kde se používá                                                                  |
| ---------------- | ------------------------------------------------------------------------------- |
| **Dvojková**     | Základ všeho – procesor, paměť, disky. Reprezentace bitů 0/1.                   |
| **Šestnáctková** | Adresy paměti, barvy v CSS (#FF0000), MAC adresy. Zkrácený zápis binárních dat. |
| **Osmičková**    | Historické systémy (Unix oprávnění). Méně častá.                                |


---

## Standardy pro zápis

> Prefixy říkají, v jaké soustavě je číslo zapsané.


| Prefix      | Soustava     | Příklad                    |
| ----------- | ------------ | -------------------------- |
| (nic)       | Desítková    | 42                         |
| `0b`        | Dvojková     | 0b101010                   |
| `0x`        | Šestnáctková | 0x2A                       |
| `0` (někdy) | Osmičková    | 052 (v některých jazycích) |


```csharp
int a = 42;       // desítkově
int b = 0b101010; // binárně = 42
int c = 0x2A;     // hex = 42
```

---

## Význam dvojkové soustavy

> ⚡ **Proč dvojková?** Počítač pracuje s **elektrickými stavy** – napětí je buď nízké (0), nebo vysoké (1). Dva stavy = dva symboly = dvojková soustava.

- **Reprezentace**: 0 = nízké napětí, 1 = vysoké napětí (nebo naopak)
- **Základ digitálních systémů**: Procesor, paměť RAM, disk – vše je nakonec 0 a 1
- **Logické operace**: AND, OR, XOR – pracují přímo s bity

```
┌─────────────────────────────────────────────────────────┐
│  BIT = jeden přepínač                                    │
│                                                         │
│  0 = vypnuto (0 V)    1 = zapnuto (např. 5 V)           │
│                                                         │
│  8 bitů = 1 bajt = 256 možných hodnot (0–255)            │
└─────────────────────────────────────────────────────────┘
```

---

## Převody mezi soustavami

### Desítková → jiná (dělení základem)

> Opakované dělení základem, zbytky (odspodu) dávají výsledek.

**Příklad: 42 (dec) → binární**

```
42 : 2 = 21  zbytek 0  ─┐
21 : 2 = 10  zbytek 1   │
10 : 2 =  5  zbytek 0   │  Čti odspodu: 101010
 5 : 2 =  2  zbytek 1   │
 2 : 2 =  1  zbytek 0   │
 1 : 2 =  0  zbytek 1  ─┘
```

**Výsledek: 42 = 101010 (bin)**

**Příklad: 42 (dec) → hex**

```
42 : 16 = 2  zbytek 10 (= A)
 2 : 16 = 0  zbytek  2
```

**Výsledek: 42 = 2A (hex)**

### Binární/Hex/Osmičková → desítková (součet váh)

> Každá číslice × základ^pozice (pozice od 0 zprava).

**Příklad: 101010 (bin) → dec**

```
1×2⁵ + 0×2⁴ + 1×2³ + 0×2² + 1×2¹ + 0×2⁰
= 32 + 0 + 8 + 0 + 2 + 0 = 42
```

**Příklad: 2A (hex) → dec**

```
2×16¹ + 10×16⁰ = 32 + 10 = 42
```

### Binární ↔ hex (skupiny 4 bitů)

> 1 hex číslice = 4 bity. Rozděl binární číslo po 4 bitech (zprava), každou skupinu převeď na hex.


| Binární | Hex |
| ------- | --- |
| 0000    | 0   |
| 0001    | 1   |
| 0010    | 2   |
| ...     | ... |
| 1010    | A   |
| 1011    | B   |
| ...     | ... |
| 1111    | F   |


**Příklad: 1010 1111 (bin) → hex**

- 1010 = A, 1111 = F → **AF**

**Příklad: 2A (hex) → bin**

- 2 = 0010, A = 1010 → **0010 1010** = 101010

### Binární ↔ osmičková (skupiny 3 bitů)

> 1 osmičková číslice = 3 bity.

**Příklad: 101 010 (bin) → okt**

- 101 = 5, 010 = 2 → **52**

---

## Přehled převodů


| Dec | Bin    | Hex |
| --- | ------ | --- |
| 0   | 0000   | 0   |
| 1   | 0001   | 1   |
| 2   | 0010   | 2   |
| ... | ...    | ... |
| 10  | 1010   | A   |
| 15  | 1111   | F   |
| 42  | 101010 | 2A  |


**Příklady:**

- 15 (dec) = 1111 (bin) = F (hex)
- 0x2A (hex) = 42 (dec)
- 0b1101 (bin) = 13 (dec)

---

## Shrnutí

- **Číselná soustava** – systém pro zápis čísel pomocí symbolů a základu.
- **Dvojková** – základ počítačů (0/1 = elektrické stavy). **Hex** – zkrácený zápis (adresy, barvy).
- **Převod dec → jiná**: Dělení základem, zbytky odspodu.
- **Převod jiná → dec**: Součet (číslice × základ^pozice).
- **Bin ↔ hex**: Skupiny 4 bitů ↔ 1 hex číslice. **Bin ↔ okt**: Skupiny 3 bitů ↔ 1 okt číslice.

