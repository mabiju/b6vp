namespace e_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\bcat\b";
        string input = "a cat sat on a mat";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }else{
            Console.WriteLine("Input mismatched.");
        }
    }
}
