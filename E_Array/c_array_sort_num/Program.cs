namespace c_array_sort_num;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 23, 45, 67, 89, 10, 233 };
        Console.WriteLine("Array Elements before sorting:");
        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
        // Array.Sort(myArray); // sorting the array in ascending order
        Array.Reverse(myArray); // sorting the array in decending order

        Console.WriteLine("Array Elements after sorting:");
        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
        Array.ForEach(myArray, item => Console.WriteLine(item));
    }
}
