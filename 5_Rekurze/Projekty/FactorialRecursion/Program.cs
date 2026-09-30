namespace FactorialRecursion;

// Napište konzolovou aplikaci v C#, která:
// - Obsahuje **rekurzivní** metodu pro výpočet `n!` pro nezáporné celé `n` (základní případ: `0! = 1`)
// - V `Main` načte `n` od uživatele a vypíše výsledek voláním této metody
// - U každé rekurze uveďte v komentáři nebo ústně **základní případ** a **rekurzivní krok**
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Faktorial: {Factorial(GetNumber())}");
    }
    static int Factorial(int n)
    {
        //zakladni pripad
        if(n == 0)
        {
            return 1;
        }
        //rekurzivni krok
        return (n * Factorial(n-1));
    }
    static int GetNumber()
    {
        Console.WriteLine("Zadejte cislo: ");
        int num;
        while(true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out num);
            if(parsed && num>=0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Spatna hodnota, zkuste znovu: ");
            }
        }
    }
}
