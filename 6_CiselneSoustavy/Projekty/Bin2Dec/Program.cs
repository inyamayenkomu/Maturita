namespace Bin2Dec;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadejte binarni cislo: ");
        string BinString = GetNumber();
        int DecNum = 0;
        int len = BinString.Length;
        for(int i = len-1; i >=0; i--)
        {
            DecNum += int.Parse(BinString[i].ToString()) * (int)Math.Pow(2,len-1-i);
        }
        Console.WriteLine($"Cislo {BinString} je {DecNum} v binarni");
    }

    static string GetNumber()
    {
        int BinNum;
        while(true)
        {
            string BinString = Console.ReadLine();
            bool parsed = int.TryParse(BinString, out BinNum);
            if(parsed && BinNum >=0)
            {return BinString;}
            else
            {
                Console.WriteLine("spatnej input");
            }
        }
    }
}
