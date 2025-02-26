namespace l_string_clone;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Sita";
        string str2 = (string)str1.Clone();
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}
