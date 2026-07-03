namespace g_non_compatible_using_convert_class;

class Program
{
    static void Main(string[] args)
    {
        string a = "12345";
        long b = Convert.ToInt64(a);
        Console.WriteLine(a); // prints string value
        Console.WriteLine(b); // prints long value
    }
}
