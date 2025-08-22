namespace d_array_min_max_sum_avg;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 12, 34, 56, 78, 90, 43, 54, 76, 881 };
        Console.WriteLine("Minimum value from the array collection = " + myArray.Min());
        Console.WriteLine("Maximum value from the array collection = " + myArray.Max());
        Console.WriteLine("Sum of all array elements = " + myArray.Sum());
        Console.WriteLine("Average of all array elements = " + myArray.Average());
    }
}
