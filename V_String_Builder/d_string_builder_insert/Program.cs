namespace d_string_builder_insert;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello", 20);
        s.Insert(2, "Nepal");
        Console.WriteLine(s);
    }
}
