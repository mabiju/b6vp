namespace l_list_t_tuple_user_credential;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        bool isFound = false;
        List<Tuple<string,string>> credential = new List<Tuple<string, string>>
        {
            new Tuple<string, string>("ram","ram@123"),
            new Tuple<string, string>("sita","sita@123"),
            new Tuple<string, string>("hari","hari@321")
        };

        Console.WriteLine("Enter name:");
        string u = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string p = Console.ReadLine();

        foreach (Tuple<string,string> c in credential)
        {
            if(c.Item1 ==u && c.Item2 == p)
            {
                isFound = true;
                break;
            }
        }
        if (isFound)
        {
            Console.WriteLine("Welcome {0}",u);
        }
        else
        {
            Console.WriteLine("Invalid username/password");
        }
    }
}
