namespace c_exception;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] nums = new int[5];
            /* nums[3] = 78;
            Console.WriteLine(nums[3]); */
            nums[10] = 78;
            Console.WriteLine(nums[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error found : " + e);
        }
    }
}
