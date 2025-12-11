namespace o_string_contains;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "sanothimi";
        string s2 = "sano";
        string s3 = "thulo";
        string s4 = "thimi";

        Console.WriteLine(s1.Contains(s2));
        Console.WriteLine(s1.Contains(s3));
        Console.WriteLine(s1.Contains(s4));
    }
}
