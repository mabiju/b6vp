namespace d_queue_t_string;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("Ram");
        names.Enqueue("Sita");
        names.Enqueue("Hari");
        names.Enqueue("Gita");
        names.Enqueue("Nita");
        names.Enqueue("Mina");
        names.Enqueue("Tina");
        names.Enqueue("Rina");
        names.Enqueue("Jina");

        Console.WriteLine("The number of elements in queue = " + names.Count);
        // Peek function is used to display the first element in the queue without removing it.
        Console.WriteLine("The first element in the queue = " + names.Peek());
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
