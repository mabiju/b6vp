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
        names.Enqueue("Zina");
        names.Enqueue("Bina");
        Console.WriteLine("The number of elements in the queue = " + names.Count);
        // Peek function is used to display the first element in the queue.
        Console.WriteLine("The first element in the queue = " + names.Peek());

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
