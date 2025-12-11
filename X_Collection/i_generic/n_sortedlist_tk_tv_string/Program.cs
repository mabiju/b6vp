namespace n_sortedlist_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        /* Creating a SortedList of string keys, string values
        using collection-initializer syntax */
        SortedList<string, string> cities = new SortedList<string, string>(){
            {"Nepal", "Kathmandu"},
            {"India", "New Delhi"},
            {"Japan", "Tokyo"}
        };


        foreach (var item in cities)
        {
            Console.WriteLine("Key = {0} and value = {1}", item.Key, item.Value);
        }
    }
}
