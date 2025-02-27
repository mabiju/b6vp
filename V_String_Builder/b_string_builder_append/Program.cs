namespace b_string_builder_append;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello");
        s.Append("Hi");
        s.AppendLine("Sanothimi");
        s.Append("Bhaktapur");
        Console.WriteLine(s);
    }
}
