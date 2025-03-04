namespace j_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\D"; // \D: Matches any non-decimal digit equivalent to [^0-9]
        string input = "542tg32t33g45";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }else{
            Console.WriteLine("Input mismatched.");
        }
    }
}
