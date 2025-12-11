namespace k_dictionary_tk_tv_user_credential;

class Program
{
    static void Main(string[] args)
    {
        bool found = false;
        Dictionary<string, string> credentials = new Dictionary<string, string>{
            {"ram","ram@123"},
            {"sita","sita@123"},
            {"hari","hari@321"}
        };

        Console.WriteLine("Enter username:");
        string u = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string p = Console.ReadLine();

        if (credentials.ContainsKey(u))
        {
            if (credentials[u] == p)
            {
                found = true;
            }

        }

        if (found)
        {
            Console.WriteLine("Hello, " + u);
        }
        else
        {
            Console.WriteLine("Credentials mismatched.");
        }

    }
}