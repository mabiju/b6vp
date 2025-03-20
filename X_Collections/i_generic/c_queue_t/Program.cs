namespace c_queue_t;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(12);
        nums.Enqueue(2);
        nums.Enqueue(23);
        nums.Enqueue(45);
        nums.Enqueue(67);
        nums.Enqueue(78);
        nums.Enqueue(78);
        nums.Enqueue(901);
        nums.Enqueue(1);

        nums.Dequeue();

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }

        // Contains() method checks whether an item exists in a queue or not
        Console.WriteLine(nums.Contains(78)); // true
        Console.WriteLine(nums.Contains(66)); // flase

    }
}
