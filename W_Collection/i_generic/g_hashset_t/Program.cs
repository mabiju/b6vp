namespace g_hashset_t;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> MyIntHash = new HashSet<int>() { 12, 34, 45, 56, 78, 99, 90, 23, 45 };
        Console.WriteLine("Elements is HashSet");
        foreach (var item in MyIntHash)
        {
            Console.WriteLine(item);
        }
    }
}
