namespace a_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        // define a pattern for a nine letter word starting with "s" and ending with "i"
        string pattern = "s.......i$";

        // create a Regex object
        Regex rg = new Regex(pattern);

        // check if "sanothimi" matches the pattern
        if (rg.IsMatch("sanothimi"))
        {
            Console.WriteLine("String matches the pattern");
        }
        else
        {
            Console.WriteLine("String doesn't match the pattern");
        }


    }
}
