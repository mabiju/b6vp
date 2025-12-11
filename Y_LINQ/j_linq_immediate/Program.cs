namespace j_linq_immediate;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 4, 5, 6, 7, 34, 3, 6, 6, 7, 56 };
        //immediate linq using ToList() method
        IEnumerable<int> query = (from number in numbers where number > 9 select number).ToList();

        foreach (var n in query)
        {
            Console.WriteLine(n + " ");
        }
    }
}
