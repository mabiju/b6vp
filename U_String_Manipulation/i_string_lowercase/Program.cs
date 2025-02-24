namespace i_string_lowercase;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "HelLoSano";
        string str2 = str1.ToLower();
        Console.WriteLine("Original String = " + str1);
        Console.WriteLine("Converted lowercase String = " + str2);
    }
}
