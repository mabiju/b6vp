namespace j_string_uppercase;

class Program
{
    static void Main(string[] args)
    {
        string stringOne = "saNoThImi";
        string stringTwo = stringOne.ToUpper();
        Console.WriteLine("The original string = " + stringOne);
        Console.WriteLine("Converted uppercase string = " + stringTwo);
    }
}
