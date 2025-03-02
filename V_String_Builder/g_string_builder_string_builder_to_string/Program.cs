namespace g_string_builder_string_builder_to_string;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello Nepal");
        string str = s.ToString();
        Console.WriteLine(str);
    }
}
