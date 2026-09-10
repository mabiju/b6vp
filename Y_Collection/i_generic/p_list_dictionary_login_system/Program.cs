namespace p_list_dictionary_login_system;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        IUserRepository repo;

        Console.WriteLine("Choose store:");
        Console.WriteLine("1. List");
        Console.WriteLine("2. Dictionary");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            repo = new ListUserRepository();
        }
        else
        {
            repo = new DictionaryUserRepository();
        }

        Console.Write("Enter username:");
        string username = Console.ReadLine();
        Console.Write("Enter password:");
        string password = Console.ReadLine();

        User user = repo.Login(username, password);
        if (user != null)
        {
            Console.WriteLine("Welcome {0} {1}", user.FirstName, user.LastName);
        }
        else
        {
            Console.WriteLine("Invalid username/password");
        }
    }
}
