namespace c_queue_t;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(3);
        nums.Enqueue(45);
        nums.Enqueue(68);
        nums.Enqueue(234);
        nums.Dequeue();

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
        // Contains() method checks whether an item exists in a queue or not
        Console.WriteLine(nums.Contains(45)); // true
        Console.WriteLine(nums.Contains(55)); // false

    }
}