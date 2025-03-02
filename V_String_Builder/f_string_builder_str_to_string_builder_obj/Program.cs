namespace f_string_builder_str_to_string_builder_obj;


using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        StringBuilder s = new StringBuilder(s1);
        Console.WriteLine(s);
    }
}
