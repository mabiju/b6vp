namespace h_hashset_t_string;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Ram");
        names.Add("Sita");
        names.Add("Hari");
        names.Add("Laxman");
        names.Add("Rina");
        names.Add("Tina");
        names.Add("Ram");
        names.Add("Mina");
        names.Add("Jina");
        names.Add("Hina");

        // to remove an element
        names.Remove("Mina");

        Console.WriteLine("Elements in string hashset before clear:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
        // to clear HashSet, i.e., remove all elements
        names.Clear();
        Console.WriteLine("Elements in string hashset after clear:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
