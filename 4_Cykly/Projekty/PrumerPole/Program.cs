namespace PrumerPole;

// Napište konzolovou aplikaci v C#, která:

// - Má pole nebo `List<int>` s několika celými čísly (může být zadané přímo v kódu nebo načtené v cyklu `for`)
// - Pomocí cyklu `**foreach**` projde všechny prvky a vypočítá aritmetický průměr
// - Vypíše součet, počet prvků a průměr
// - Vysvětlete vztah cyklu a pole (iterace přes prvky)
class Program
{
    static void Main(string[] args)
    {
        int[] pole = new int[5];
        Random rand = new Random();
        for(int i = 0; i<5; i++)
        {
            pole[i] = rand.Next(1, 500);
        }
        int soucet = 0;
        foreach(int num in pole)
        {
            Console.WriteLine($"Prvek ma hodnotu {num} ");
            soucet += num;
        }
        double prumer = (double)(soucet/pole.Count());
        Console.WriteLine($"Prumer je {prumer}");
        Console.WriteLine($"Kontorla: {pole.Average()}");
    }
    
}
