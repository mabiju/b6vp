namespace m_string_compare;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = "Hello";
        string s3 = "hello";
        string s4 = "Sanothimi";
        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s2, s3));
        Console.WriteLine(string.Compare(s1, s4)); // same i.e. 0
    }
}
