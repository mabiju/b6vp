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
        names.Enqueue("Sita");
        names.Enqueue("Mohan");
        
        Console.WriteLine("The number of items in queue = " + names.Count);
        Console.WriteLine("The first item in queue = " + names.Peek()); // Peek function is used to display the first element in the queue without removing it.

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
