namespace f_regex;

using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\Bcat\B";
        string input = "acatnapt";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }else{
            Console.WriteLine("Input mismatched.");
        }
    }
}

/* In a C# regular expression, "\b" represents a "word boundary," meaning it matches the
 position between a word character and a non-word character (like a space), while "\B" 
 represents a "non-word boundary," which matches any position that is not a word boundary; 
 essentially, the opposite of "\b" - so it matches between two word characters or between 
 two non-word characters.
  
Key points:
-----------
\b: Matches the start or end of a word.
\B: Matches any position that is not a word boundary. 
Example:
---------
"\bcat\b"
would match "cat" in "The cat sat on the mat" because it is surrounded by spaces (word boundaries). 
"\Bcat\B"
would match "cat" within the word "catnap" because it's not at the start or end of a word.  */
