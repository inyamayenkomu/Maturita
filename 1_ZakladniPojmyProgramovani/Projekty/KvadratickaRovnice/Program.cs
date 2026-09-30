using System.Runtime.Intrinsics.X86;

namespace KvadratickaRovnice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadej a: ");
        double a;
        while (true)
        {
            bool parsed =  double.TryParse(Console.ReadLine(), out a);   
            if(parsed)
            {break;}
        }
        double b;
        Console.WriteLine("Zadej b: ");
        while (true)
        {
            bool parsed =  double.TryParse(Console.ReadLine(), out b);   
            if(parsed)
            {break;}
        }
        Console.WriteLine("Zadej c: ");
        double c;
        while (true)
        {
            bool parsed =  double.TryParse(Console.ReadLine(), out c);   
            if(parsed)
            {break;}
        }
        double d = Math.Pow(b,2) - (4*a*c);
        double sqrtD = Math.Sqrt(d);
        double firstX = ((-1*b) + sqrtD)/2*a;
        double secondX = ((-1*b) - sqrtD)/2*a;
        if(double.IsNaN(firstX))
        {Console.WriteLine("Nema koreny.");}
        else if (firstX == secondX)
        {Console.WriteLine("Pouze jeden koren: " + firstX);}
        else
        {
        Console.WriteLine("Prvni Koren: " + firstX);
        Console.WriteLine("Druhy Koren: " + secondX);
        }
    }
}


