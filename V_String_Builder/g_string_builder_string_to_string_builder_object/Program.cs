namespace g_string_builder_string_to_string_builder_object;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        StringBuilder s = new StringBuilder(str);
        Console.WriteLine(s);
    }
}
