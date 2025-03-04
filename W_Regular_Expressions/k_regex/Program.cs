namespace k_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\s"; // detects white space
        // where a string contains any whitespace character. Equivalent to [ \t\n\r\f\v].
        string input = "hello nepal";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("There is a white space occured.");
        }else{
            Console.WriteLine("Input mismatched.");
        }
    }
}

