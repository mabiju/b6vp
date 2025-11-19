namespace h_string_lowercase;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "HelloSano";
        string str2 = str1.ToLower();
        Console.WriteLine("Original string = " + str1);
        Console.WriteLine("Converted lowercase string = " + str2);
    }
}
