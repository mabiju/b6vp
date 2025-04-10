namespace d_linq_oddnum;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 23, 44, 56, 2, 34, 55, 67, 89, 10 };
        int oddNums = nums.Count(n => n % 2 == 1);
        Console.WriteLine("No of odd numbers = " + oddNums);
    }
}
