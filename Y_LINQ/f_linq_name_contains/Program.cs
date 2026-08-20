namespace f_linq_name_contains;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "ram", "sita", "hari", "gita", "laxman", "nita" };

        var myLinqQuery =
            from name in names
            where name.Contains("r")
            // where name.Length >= 4
            select name;
        foreach (var item in myLinqQuery)
        {
            Console.WriteLine(item);
        }
    }
}