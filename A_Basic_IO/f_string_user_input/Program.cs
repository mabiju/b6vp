namespace f_string_user_input;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name:");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        string lname = Console.ReadLine();
        Console.WriteLine("The full name is {0} {1}.", fname, lname);
    }
}
