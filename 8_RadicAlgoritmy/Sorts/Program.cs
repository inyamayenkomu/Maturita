using System.Reflection.Metadata;

namespace Sorts;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = GetArr();
        //InsertionSort(arr);
        //SelectionSort(arr);
        //BubbleSort(arr);
        QuickSort(arr, 0, arr.Length-1);
        PrintArr(arr);
    }

    static int[] GetArr()
    { 
        Console.WriteLine("Enter array length: ");
        int len = GetPosInt();
        int[] arr = new int[len];
        Console.WriteLine("Fill in array: ");
        for(int i = 0; i<len;i++)
        {
            arr[i] = GetPosInt();
        }
        return arr;
    }

    static int GetPosInt()
    {
        int n;
        while(true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out n);
            if(parsed && n>=0)
            {return n;}
            else
            {
                Console.WriteLine("That is not a positive integer");
            }
        }
    }

    static void InsertionSort(int[] arr)
    {
        for(int i = 1; i<arr.Length; i++)
        {
            Console.WriteLine($"On I: {i}");
            for(int j = 1; j <= i; j++)
            {
                Console.WriteLine($"On J: {j}");
                if(arr[i-j+1] < arr[i-j])
                {
                    Swap(arr, i-j+1, i-j);
                    Console.WriteLine($"Swapped {arr[i]} and {arr[i-j]}");
                }
                else
                {
                    break;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"I is: {i}");
            int minValue = int.MaxValue;
            int minIndex = i;
            for(int j = i; j<arr.Length; j++)
            {
                Console.WriteLine($"J is: {j}");
                if(arr[j] < minValue)
                {
                    minValue = arr[j];
                    minIndex = j;
                }
            }
            Swap(arr, i, minIndex);
        }
    }

    static void BubbleSort(int[] arr)
    {
        bool swapped = false;
        do
        {
            swapped = false;
            for(int i = 0; i < arr.Length-1;i++)
            {
                if(arr[i]> arr[i+1])
                {
                    Swap(arr, i, i+1);
                    swapped = true;
                }
            }
        }
        while(swapped);
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if(low >= high)
        {return;}

        int pivot = arr[(low + high)/2];
        Console.WriteLine($"Low is {low}");
        Console.WriteLine($"High is {high}");
        Console.WriteLine($"Pivot index is {(low + high)/2}");
        int i = low;
        int j = high;
        while(i <= j)
        {
            
            Console.WriteLine("We are inside the while");
            while (i <= high && arr[i] < pivot) i++;
            while (j >= low && arr[j] > pivot) j--;
            if(i<=j)
            {
            Swap(arr, i, j); 
            PrintArr(arr);
            Console.WriteLine("We are past the swap");
            i++;
            j--;
            }
        }
        QuickSort(arr, low, j);
        QuickSort(arr, i, high);
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
     }
     
    static void PrintArr(int[] arr)
    {
        foreach(int num in arr)
        {
            Console.Write($"{num} ");
        }
    }
}
