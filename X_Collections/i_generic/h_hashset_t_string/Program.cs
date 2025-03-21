namespace h_hashset_t_string;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Ram");
        names.Add("Sita");
        names.Add("Hari");
        names.Add("Gita");
        names.Add("Mina");
        names.Add("Tina");
        names.Add("Sita");
        names.Add("Rina");
        names.Add("Hina");
        names.Add("Gina");

        // to remove an element
        // names.Remove("Gita");

        Console.WriteLine("Elements in HashSet before clear:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

         // to clear HashSet
        names.Clear(); // to remove all the elements from HashSet all at once.
        Console.WriteLine("Elements in HashSet after clear:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        
    }
}
