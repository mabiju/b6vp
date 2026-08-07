namespace c_queue_t;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(3);
        nums.Enqueue(233);
        nums.Enqueue(203);
        nums.Enqueue(387);
        nums.Dequeue();
        
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
        // Contains() method check whether an item exist in a queue or not
        Console.WriteLine(nums.Contains(3)); // True
        Console.WriteLine(nums.Contains(55)); // Talse
    }
}
