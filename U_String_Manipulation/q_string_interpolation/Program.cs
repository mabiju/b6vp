namespace q_string_interpolation;

class Program
{
    static void Main(string[] args)
    {
        // 1. use of $ symbol
        /* var name = "Ram";
        var gratitude = "Namaste";

        string greetings = $"{gratitude} sita ko buda {name}";
        Console.WriteLine(greetings); */

        /* var a = 5;
        var result = $"Square of {a} = {a * a}";
        Console.WriteLine(result); */

        /* string name = "Ram";
        string msg = $"Hello {name}";
        Console.WriteLine(msg); */

        // 2. use of string.Format()
        var name = "Sita";
        var greeting = string.Format("Hello {0} {1} !", name, " namaste");
        Console.WriteLine(greeting);
    }
}
