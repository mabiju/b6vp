namespace i_linq_no_of_vowels;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        var sentence = Console.ReadLine();

        // using imparative syntax (foreach loop)
        /* int c = 0;
        foreach(var letter in sentence.ToUpper())
        {
           if(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
           {
               c++;
           }
        }
        Console.WriteLine("Number of vowels = {0}", c); */

        // using declarative syntax (LINQ)
        var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
        var query = from letter in sentence.ToUpper() where vowels.Contains(letter) select letter;
        var count = query.Count(); 
        Console.WriteLine("Number of vowels = {0}", count);
    }
}