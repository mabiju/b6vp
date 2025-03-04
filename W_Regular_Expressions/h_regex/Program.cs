namespace h_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\d+";
        string input = "ram:1234 sita:6780 hari:5023";
        string replacement = "****";

        string result = Regex.Replace(input, pattern, replacement);
        Console.WriteLine(result);
    }
}
