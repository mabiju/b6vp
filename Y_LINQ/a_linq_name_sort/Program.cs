namespace a_linq_name_sort;

class Program
{
    static void Main(string[] args)
    {
        string[] Students = {"Ram", "Sita", "Hari", "Gita", "Nita", "Tina","Mina","Jina","Eena","Cena"};
        var nameSort = from name in Students orderby name select name;
        foreach (var name in nameSort)
        {
            Console.WriteLine(name);
        }
        
    }
}
