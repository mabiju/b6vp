namespace c_linq_distinct_num_entry;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[]{2,5,6,2,7,8,9,6,34,45,66,9,3,5,66};
        int uniNum = nums.Distinct().Count();
        Console.WriteLine("Total number of unique values are : " + uniNum);
    }
}
