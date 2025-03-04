namespace g_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\d"; // d: matches any decimal digit equaivalent to [0-9]
        string input = "The 2 price is Rs 567 of this 8 doll.";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }else{
            Console.WriteLine("Input mismatched.");
        }
    }
}
