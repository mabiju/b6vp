namespace k_dictionary_tk_tk_user_credential;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        bool isFound = false;
        Dictionary<string,string> credential = new Dictionary<string, string>
        {
            {"ram","ram@123"},
            {"sita","sita@123"},
            {"hari","hari@321"},
        };

        Console.WriteLine("Enter username:");
        string u = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string p = Console.ReadLine();

        if (credential.ContainsKey(u))
        {
            if(credential[u] ==p)
            {
                isFound = true;
            }
        }
        if (isFound)
        {
            Console.WriteLine("Hello " + u);
        }
        else
        {
            Console.WriteLine("Credential mismatched.");
        }

    }
}
