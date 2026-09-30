using System;
using System.Collections.Generic;

namespace RecFib;

class Program
{
    static Dictionary<int, int> memo = new Dictionary<int, int>()
    {
        { 0, 0 },
        { 1, 1 }
    };

    static void Main(string[] args)
    {
        int num = GetNumber();
        int fib = Fib(num);

        Console.WriteLine($"Fib of {num} is {fib}");
    }

    static int Fib(int n)
    {
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }

        memo[n] = Fib(n - 1) + Fib(n - 2);
        return memo[n];
    }

    static int GetNumber()
    {
        int num;

        Console.WriteLine("Enter a non-negative integer:");

        while (true)
        {
            bool parsed = int.TryParse(Console.ReadLine(), out num);

            if (parsed && num >= 0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("That is not a non-negative integer.");
            }
        }
    }
}