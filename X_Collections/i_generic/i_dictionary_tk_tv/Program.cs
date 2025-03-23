namespace i_dictionary_tk_tv;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();

        rollnames.Add(11, "Ram");
        rollnames.Add(12, "Sita");
        rollnames.Add(13, "Hari");
        rollnames.Add(15, "Gita");
        rollnames.Add(10, "Nita");
        rollnames.Add(9, "Mita");

        foreach (KeyValuePair<int, string> kvp in rollnames)
        {
            Console.WriteLine("Key is {0} and the value is {1}", kvp.Key, kvp.Value);
        }
    }
}
