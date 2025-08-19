namespace k_foreach_character_array;

class Program
{
    static void Main(string[] args)
    {
        char[] myarray = { 'H', 'E', 'L', 'O' };
        foreach (var item in myarray)
        {
            Console.WriteLine(item);
        }
    }
}

