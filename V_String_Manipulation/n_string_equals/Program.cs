namespace n_string_equals;

class Program
{
    static void Main(string[] args)
    {
        string pass1 = "pass@123";
        string pass2 = "pass@456";
        string pass3 = "pass@123";

        Boolean result1 = pass1.Equals(pass2);
        Boolean result2 = pass1.Equals(pass3);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}
