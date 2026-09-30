namespace Palindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it's a palindrome");
        string s = Console.ReadLine();
        bool ispalindrome = IsPalindrome(s,0,s.Length-1);
        Console.WriteLine(ispalindrome);
    }

    static bool IsPalindrome(string s, int l, int r)
    {
        if(l>=r)
        {
            return true;
        }
        else
        {
            if(s[l] != s[r])
            {return false;}
            else
            {
            return IsPalindrome(s,l+1,r-1);
            }
        }
    }
}
