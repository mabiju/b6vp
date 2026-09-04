namespace k_string_clone;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Sita";
        string str2 = (string)str1.Clone();
        Console.WriteLine("Source string = " + str1);
        Console.WriteLine("Cloned string = " + str2);
    }
}
