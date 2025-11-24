namespace a_list_t;

class Program
{
    static void Main(string[] args)
    {
        // Method 1:
        /* List<int> nums = new List<int>();
        nums.Add(34);
        nums.Add(3);
        nums.Add(33); 
        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);
        */

        // Method 2:
        /* var nums = new List<int>();
        nums.Add(34);
        nums.Add(3);
        nums.Add(33); 
        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);
        */

        // Method 3:
        /* var nums = new List<int>() {23,45,6,78,99,90,22,12};
        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);
        Console.WriteLine(nums[3]);
        Console.WriteLine(nums[4]);
        Console.WriteLine(nums[5]);
        Console.WriteLine(nums[6]);
        Console.WriteLine(nums[7]); */

        //////////////////////////////////////////////////////////////

        var nums = new List<int>() { 23, 45, 6, 78, 99, 90, 22, 12 };
        nums.Insert(0,555); // inserting an element in a fix index
        nums.Remove(99); // removes a particular element
        nums.RemoveAt(3); // removes a value based on index
        nums.Clear(); // removes all list elements all at once\
        nums.Insert(0,44); // inserting an element in a fix index
        // displaying all List elements using for loop:
        /* for (int i = 0; i < 7; i++)
        {
            // Console.WriteLine(nums[i]);
            Console.Write(nums[i] + "\t");
        } */

        // displaying all list elements using ForEach
        nums.ForEach(nums => Console.WriteLine(nums));
    }
}
