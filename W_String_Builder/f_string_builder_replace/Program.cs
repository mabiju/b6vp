namespace f_string_builder_replace;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello, Sanothimi", 20);
        s.Replace("Sanothimi", "Bhaktapur");
        Console.WriteLine(s);
    }
}
