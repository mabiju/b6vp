namespace m_sortedlist_tk_tv;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> rollnames = new SortedList<int, string>();
        rollnames.Add(1, "Ram");
        rollnames.Add(17, "Sita");
        // rollnames.Add(1, "Hari");
        rollnames.Add(12, "Gita");
        rollnames.Add(7, "Nita");
        rollnames.Add(6, "Mina");
        rollnames.Add(3, "Tina");
        rollnames.Add(9, null);
        rollnames.Add(2, "Jina");

        rollnames[9] = "John";  // assign with a value if there is not
        rollnames[2] = "Gina";  // Update a value

        Console.WriteLine(rollnames[3]); // Tina

        foreach (var item in rollnames)
        {
            Console.WriteLine("Key is {0} and value is {1}", item.Key, item.Value);
        }


        //The following will throw exceptions
        //rollnames.Add("Jack", 2); //Compile-time error: key must be int type
        //rollnames.Add(1, "Ravan"); //Run-time exception: duplicate key
        //rollnames.Add(null, "Anne");//Run-time exception: key cannot be null
    }
}
