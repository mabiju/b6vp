namespace c_linq_distinct_num_entry;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 2, 3, 5, 5, 7, 8, 3, 3, 5, 9, 9, 1, 2, 3 };
        int unqNums = numbers.Distinct().Count();
        Console.WriteLine("Total number of unique elements = " + unqNums);
    }
}
