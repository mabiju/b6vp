namespace m_sortedlist_tk_tv;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> rollnames = new SortedList<int, string>();
        rollnames.Add(1, "Ram");
        rollnames.Add(17, "Sita");
        // rollnames.Add(1, "Hina");
        rollnames.Add(12, "Hari");
        rollnames.Add(7, "Gita");
        rollnames.Add(6, "Nita");
        rollnames.Add(3, "Mina");
        rollnames.Add(9, null);
        rollnames.Add(2, "Jina");

        

        rollnames[9] ="John"; // assign with a value if value is not there
        rollnames[2] ="Hohn"; // update a value

        Console.WriteLine(rollnames[3]); // Mina

        foreach (var item in rollnames)
        {
            Console.WriteLine("Key is {0} and value is {1}", item.Key, item.Value);
        }

        // The following will throw exceptions
        /* rollnames.Add("Jack", 11); // compile time exception
        rollnames.Add(1, "Rajesh"); // runtime time exception
        rollnames.Add(null, "anne"); // runtime time exception */
    }
}
