namespace d_linq_oddnum;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 23, 45, 66, 76, 34, 21, 35 };
        int oddNum = nums.Count(n => n % 2 == 1);
        Console.WriteLine("Total number of odd numbers = " + oddNum);
    }
}
