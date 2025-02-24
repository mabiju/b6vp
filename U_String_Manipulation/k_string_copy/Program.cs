namespace k_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string name = "Sanothimi";
        // string myName = string.Copy(name); // not recommended to use
        string myName = new string(name);
        Console.WriteLine(name);
        Console.WriteLine(myName);
    }
}
