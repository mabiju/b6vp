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
        names.Add("Zina");
        names.Add("Eena");
        names.Add("Rina");
        names.Add("Hina");
        names.Add("Dina");

        // to remove an element
        names.Remove("Mina");
        Console.WriteLine("Elements in hash set:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        // Clear() function removes all the hash elements.
        names.Clear();
        Console.WriteLine("Elements in hash set after clear function:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
