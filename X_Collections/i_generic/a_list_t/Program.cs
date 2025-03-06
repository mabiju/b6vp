namespace a_list_t;

class Program
{
    static void Main(string[] args)
    {
        // List<int> nums = new List<int>();

        /* var nums = new List<int>();
        nums.Add(23);
        nums.Add(3);
        nums.Add(33);
        nums.Add(14); */

        var nums = new List<int>() { 24, 56, 78, 87, 65, 4, 24, 31 };

        /* Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[3]); */

        // nums.Insert(1,123);
        // nums.Remove(33); // removes the particular element
        // nums.RemoveAt(1);    // removes the item at position
        // nums.Clear();
        // nums.Insert(0,555);



        // for (int i = 0; i < 4; i++)
        /* for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        } */

        nums.ForEach(nums => Console.WriteLine(nums));
    }
}
