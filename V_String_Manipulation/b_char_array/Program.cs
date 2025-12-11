namespace b_char_array;

class Program
{
    static void Main(string[] args)
    {
        // array of characters
        char[] namearray = { 'R', 'a', 'm' };
        string name = new string(namearray);
        Console.WriteLine(name);
    }
}