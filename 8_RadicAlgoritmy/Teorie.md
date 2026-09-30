# 8. Řadící algoritmy

> Popište řazení vkládáním (Insertion Sort), výběrem (Selection Sort), bublinkové (Bubble Sort), rozdělováním (Quick Sort). Demonstrujte řazení na zvolené číselné posloupnosti, popište implementaci.

---

## 📖 Slovníček pojmů

| Pojem | Co to je | Příklad z reálného světa |
| ------------------------------ | ------------------------------------------------------------------------------ | -------------------------------------------------------------- |
| **Pivot** | Prvek, podle kterého se dělí pole (menší vlevo, větší vpravo) | Střední hodnota – kolem ní se třídí |
| **Stabilita** | Stejné prvky zůstávají v původním pořadí | Dva „5“ – po řazení v tom pořadí, v jakém byly |
| **In-place** | Algoritmus řadí v původním poli, nepotřebuje pomocné pole | Šetří paměť – nic navíc |
| **Seřazená část** | Úsek pole, který je už uspořádaný | Insert Sort ji postupně rozšiřuje |

---

## Insertion Sort (Řazení vkládáním)

> 📥 **Přirovnání**: Jako **řazení karet v ruce** – levá část je seřazená. Bereš další kartu a posouváš ji doleva (ve stejném poli), dokud nenajdeš správné místo. Žádné nové pole – jen posouvání.

### Princip krok za krokem

1. **Začátek**: První prvek (index 0) považujeme za „seřazenou část“ – jeden prvek je vždy seřazený.
2. **Pro každý další prvek** (i = 1, 2, 3, …):
   - Uložíme ho do `key` (abychom ho neztratili při posouvání).
   - Jdeme od pozice i−1 **doleva** a porovnáváme s `key`.
   - Pokud je prvek větší než `key`, **posuneme ho doprava** (abychom udělali místo).
   - Když najdeme menší prvek nebo začátek pole, vložíme `key` na správné místo.

**Proč posouvání?** Protože vkládáme „dovnitř“ seřazené části – musíme ostatní prvky odsunout, aby se udělalo místo. Vše se děje v původním poli.

### Příklad: [5, 2, 4, 6, 1, 3]

| Krok | Co děláme | Stav pole |
| ---- | --------- | --------- |
| Start | Seřazená část: [5] | [5, 2, 4, 6, 1, 3] |
| 1 | Bereme 2. 5 > 2 → posuneme 5 doprava, vložíme 2 | [2, 5, 4, 6, 1, 3] |
| 2 | Bereme 4. 5 > 4 → posuneme 5, vložíme 4 | [2, 4, 5, 6, 1, 3] |
| 3 | Bereme 6. 5 < 6 → 6 zůstane na místě | [2, 4, 5, 6, 1, 3] |
| 4 | Bereme 1. 6,5,4,2 > 1 → posuneme všechny, vložíme 1 na začátek | [1, 2, 4, 5, 6, 3] |
| 5 | Bereme 3. 6,5,4 > 3 → posuneme, vložíme 3 | [1, 2, 3, 4, 5, 6] |

### Implementace (s komentáři)

```csharp
static void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)  // od 2. prvku – 1. je už „seřazený“
    {
        int key = arr[i];      // prvek, který vkládáme
        int j = i - 1;         // začneme u prvku vlevo od něj

        // posouváme větší prvky doprava, dokud nenajdeme místo pro key
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];  // posun prvku doprava
            j--;
        }
        arr[j + 1] = key;  // vložíme key na správné místo
    }
}
```

---

## Selection Sort (Řazení výběrem)

> 🎯 **Přirovnání**: Jako **vybírání nejmenšího z hromady** – vždy najdeš minimum v neseřazené části a dáš ho na začátek. Pak opakuješ pro zbytek.

### Princip krok za krokem

1. **Rozdělení pole**: Levá část (od začátku do indexu i) = už seřazená. Pravá část = neseřazená.
2. **V každém kroku**:
   - Projdeš celou neseřazenou část a najdeš **index** nejmenšího prvku (`minIndex`).
   - Prohodíš prvek na pozici `i` s prvkem na `minIndex`.
   - Tím se nejmenší prvek dostane na začátek neseřazené části (= konec seřazené).
3. **Opakuješ**, dokud není celé pole seřazené.

**Proč prohození?** Neposouváš prvky – jen najdeš minimum a prohodíš ho s prvním neseřazeným. Jednoduché, ale vždy projdeš celou neseřazenou část.

### Příklad: [5, 2, 4, 6, 1, 3]

| Krok | Neseřazená část | Minimum | Akce | Stav pole |
| ---- | ---------------- | ------- | ---- | --------- |
| Start | [5,2,4,6,1,3] | 1 (index 4) | prohodit 5↔1 | [1, 2, 4, 6, 5, 3] |
| 2 | [2,4,6,5,3] | 2 (na místě) | nic | [1, 2, 4, 6, 5, 3] |
| 3 | [4,6,5,3] | 3 (index 5) | prohodit 4↔3 | [1, 2, 3, 6, 5, 4] |
| 4 | [6,5,4] | 4 (index 5) | prohodit 6↔4 | [1, 2, 3, 4, 5, 6] |

### Implementace (s komentáři)

```csharp
static void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)  // i = začátek neseřazené části
    {
        int minIndex = i;  // zatím předpokládáme, že minimum je na i

        for (int j = i + 1; j < arr.Length; j++)  // projdi zbytek
            if (arr[j] < arr[minIndex]) minIndex = j;  // našel menší? zapamatuj index

        (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);  // prohoď
    }
}
```

---

## Bubble Sort (Bublinkové řazení)

> 🫧 **Přirovnání**: Jako **bubliny stoupající v sodovce** – větší prvky „probublávají“ nahoru. Porovnáváš sousedy a prohazuješ, dokud není vše seřazeno.

### Princip krok za krokem

1. **Jeden průchod**: Projdeš pole zleva doprava. U každé dvojice sousedů (j, j+1): pokud je levý větší než pravý, **prohodíš je**.
2. **Co se stane**: Největší prvek v průchodu „probublá“ až na konec pole (protože je větší než všichni, s nimiž se potká).
3. **Opakování**: Po prvním průchodu je největší na konci. Po druhém je druhý největší před ním. Atd.
4. **Optimalizace `swapped`**: Pokud v celém průchodu neproběhne ani jedno prohození, pole už je seřazené a algoritmus může skončit dřív.
5. **Proč `j < n - 1` a `n--`?** Po každém průchodu je poslední prvek už na správném místě, takže další průchod může být kratší.

**Proč „bubliny“?** Větší čísla postupně „stoupají“ doprava (k vyšším indexům), menší zůstávají vlevo.

### Příklad: [5, 2, 4, 6, 1, 3]

**Průchod 1** (porovnáváme sousedy, prohazujeme větší doprava):
- 5>2 → prohodit → [2,5,4,6,1,3]
- 5>4 → prohodit → [2,4,5,6,1,3]
- 5<6 → nic
- 6>1 → prohodit → [2,4,5,1,6,3]
- 6>3 → prohodit → [2,4,5,1,3,**6**]  ← 6 na konci

**Průchod 2**: [2,4,1,3,**5**,6]  ← 5 na místo  
**Průchod 3**: [2,1,3,**4**,5,6]  
**Průchod 4**: [1,2,**3**,4,5,6]  ← hotovo

### Implementace (s komentáři)

```csharp
static void BubbleSort(int[] arr)
{
    bool swapped;
    int n = arr.Length;

    do
    {
        swapped = false;

        for (int j = 0; j < n - 1; j++)  // po každém průchodu je konec už seřazený
        {
            if (arr[j] > arr[j + 1])
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);  // prohoď sousedy
                swapped = true;
            }
        }

        n--;  // poslední prvek už nemusíme znovu porovnávat
    }
    while (swapped);
}
```

---

## Quick Sort (Řazení rozdělováním)

> ✂️ **Přirovnání**: Jako **řezání dortu** – vybereš pivot (střední kus), menší kusy dáš vlevo, větší vpravo. Pak to samé rekurzivně pro každou polovinu.

### Princip krok za krokem

1. **Pivot**: Vybereš prvek (obvykle střední) – hodnota, kolem které dělíš pole.
2. **Rozdělení (partition)**: Projdeš pole dvěma ukazateli:
   - **i** jde zleva doprava – hledá prvek **větší nebo rovný** pivotu.
   - **j** jde zprava doleva – hledá prvek **menší nebo rovný** pivotu.
   - Když oba najdou „špatný“ prvek, **prohodíš je**.
   - Opakuješ, dokud se i a j neprotnou.
3. **Výsledek rozdělení**: Vlevo od určité hranice jsou menší prvky, vpravo větší. Pivot je „někde uprostřed“.
4. **Rekurze**: Stejný postup aplikuješ na levou část (low … j) a pravou část (i … high). Základní případ: úsek má 0 nebo 1 prvek – už je seřazený.

**Proč je to rychlé?** Rozděluješ problém na poloviny – podobně jako binární vyhledávání. O(n log n) místo O(n²).

### Příklad: [5, 2, 4, 6, 1, 3] s pivotem 4 (střed)

**Krok 1 – rozdělení:**
- Pivot = 4. i na začátku, j na konci.
- arr[i]=5 ≥ 4, arr[j]=3 ≤ 4 → prohodit → [3,2,4,6,1,5]
- i++, j--. arr[i]=2 < 4 → i++. arr[j]=1 ≤ 4 → zastav. Prohodit 4↔1 → [3,2,1,6,4,5]
- i a j se protnou → konec. Levá část [3,2,1], pravá [6,5].

**Krok 2 – rekurze:**
- [3,2,1] s pivotem 2 → [1,2,3]
- [6,5] s pivotem 6 → [5,6]

**Výsledek:** [1, 2, 3, 4, 5, 6]

### Implementace (s komentáři)

```csharp
static void QuickSort(int[] arr, int low, int high)
{
    if (low >= high) return;  // základní případ: 0 nebo 1 prvek

    int pivot = arr[(low + high) / 2];  // střední prvek jako pivot
    int i = low, j = high;

    while (i <= j)
    {
        while (arr[i] < pivot) i++;   // i hledá prvek ≥ pivot
        while (arr[j] > pivot) j--;   // j hledá prvek ≤ pivot
        if (i <= j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);  // prohoď
            i++;
            j--;
        }
    }

    // rekurze na levou a pravou část
    if (low < j) QuickSort(arr, low, j);
    if (i < high) QuickSort(arr, i, high);
}

// Volání: QuickSort(pole, 0, pole.Length - 1);
```

---

## Srovnání algoritmů

| Algoritmus | Časová složitost | Stabilita | Kdy použít |
| ---------- | ---------------- | --------- | ---------- |
| **Insertion Sort** | O(n²) | Ano | Malá data, téměř seřazená data |
| **Selection Sort** | O(n²) | Ne | Malá data, výukové účely |
| **Bubble Sort** | O(n²) | Ano | Malá data, výukové účely |
| **Quick Sort** | O(n log n) průměr, O(n²) nejhorší | Obvykle ne | Velká data, obecné řazení |

```
┌─────────────────────────────────────────────────────────┐
│  SROVNÁNÍ                                               │
│                                                         │
│   Insertion/Selection/Bubble:  O(n²)  – pro malá data        │
│   Quick Sort:            O(n log n) – pro velká data    │
│                                                         │
│   Stabilní (zachová pořadí stejných): Insertion, Bubble    │
│   Nestabilní: Selection, Quick                             │
└─────────────────────────────────────────────────────────┘
```

---

## Shrnutí

- **Insertion Sort** – vkládání do seřazené části. O(n²), stabilní.
- **Selection Sort** – výběr minima v neseřazené části. O(n²), nestabilní.
- **Bubble Sort** – prohazování sousedů, „bubliny“ nahoru. O(n²), stabilní.
- **Quick Sort** – pivot, rozdělení, rekurze. O(n log n) průměr, O(n²) nejhorší, obvykle nestabilní.
- Pro velká data preferuj Quick Sort. Pro malá nebo výuku stačí Insert/selection/Bubble.

---

## Materiály od učitele

Tato sekce je převzatá z `Razeni.txt` a `Razeni 1.txt`.

### Obecné vlastnosti řazení

- V praxi se často používá vestavěné řazení (`Array.Sort`, `List.Sort`), ruční implementace slouží hlavně pro výuku.
- Klíčové pojmy: **stabilita**, **adaptabilita**, **online řazení**.
- Seřazená data často zlepšují navazující operace (např. vyhledávání).

### Varianta: `Razeni.txt`

- Důraz na to, kdy je který algoritmus vhodný a jaké má trade-off mezi počtem porovnání a swapů.
- U Bubble Sort je explicitně uvedena varianta „opakuj, dokud probíhají swapy“ (adaptivní ukončení).

### Varianta: `Razeni 1.txt`

- Přidává důkaz nestability Selection Sortu na příkladu duplicit (`5A`, `5B`, `2`).
- Rozšiřuje komentář k nejhoršímu případu Quick Sortu při špatné volbě pivotu.

### Pro ty, co chtej vedet vic

- [Razeni.txt](Materialy/Razeni.txt)
- [Razeni 1.txt](Materialy/Razeni%201.txt)
