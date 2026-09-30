# Syntaxe k příkladům (téma 8 – řadící algoritmy)

Kostry metod podle [../Teorie.md](../Teorie.md).�plné znění včetně komentářů je v teorii.

Základní výpis pole: `Console.WriteLine(string.Join(" ", pole));`

---

## Prohození dvou prvků

```csharp
(arr[i], arr[j]) = (arr[j], arr[i]);
```

---

## Insert Sort

```csharp
static void InsertSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}
```

---

## Select Sort

```csharp
static void SelectSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j] < arr[minIndex]) minIndex = j;
        (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
    }
}
```

---

## Bubble Sort

```csharp
static void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
            if (arr[j] > arr[j + 1])
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
}
```

---

## Quick Sort

```csharp
static void QuickSort(int[] arr, int low, int high)
{
    if (low >= high) return;

    int pivot = arr[(low + high) / 2];
    int i = low, j = high;

    while (i <= j)
    {
        while (arr[i] < pivot) i++;
        while (arr[j] > pivot) j--;
        if (i <= j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
            i++;
            j--;
        }
    }

    if (low < j) QuickSort(arr, low, j);
    if (i < high) QuickSort(arr, i, high);
}
```

---

## Kopie pole před řazením

```csharp
int[] kopie = (int[])puvodni.Clone();
```
