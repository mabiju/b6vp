namespace b_string_builder_append;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        // 20 is the capacity of the string object.
        StringBuilder s = new StringBuilder("Hello", 20);
        s.Append("Hi");
        s.AppendLine("Sanothimi");
        s.Append("Bhaktapur");
        Console.WriteLine(s);
    }
}
