namespace k_linq_deferred;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 5, 8, 6, 6, 4, 2, 3, 1, 4 };
        var query = from number in numbers where number > 4 select number;
        foreach (var n in query)
        {
            Console.Write(n + " ");
        }
    }
}

