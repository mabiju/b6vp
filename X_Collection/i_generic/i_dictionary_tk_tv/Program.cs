namespace i_dictionary_tk_tv;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> rollnames = new Dictionary<int, string>();
        rollnames.Add(420,"Ram");
        rollnames.Add(421,"Sita");
        rollnames.Add(555,"Hari");

        foreach (KeyValuePair<int,string> kvp in rollnames)
        {
            Console.WriteLine("Key is {0} and the value is {1}",kvp.Key,kvp.Value);
        }
    }
}
