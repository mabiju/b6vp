namespace j_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string clz = "Sanothimi";
        // string myClz = string.Copy(clz); // not recommended to use
        string myClz = new string(clz);
        Console.WriteLine("Source string =" + clz);
        Console.WriteLine("Copied string =" + myClz);
    }
}
