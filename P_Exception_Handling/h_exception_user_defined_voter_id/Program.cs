namespace h_exception_user_defined_voter_id;

class InvalidVoter : Exception
{
    public InvalidVoter(string message) : base(message) { }
}
class Program
{
    static void ageValidate(int age)
    {
        if (age < 18)
        {
            throw new InvalidVoter("You are not eligible to get voter ID.");
        }
        else
        {
            Console.WriteLine("You're eligible to get your voter ID, not get your citizenship card");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter age:");
        int a = Convert.ToInt32(Console.ReadLine());
        try
        {
            ageValidate(a);
        }
        catch (InvalidVoter e)
        {
            Console.WriteLine(e);
        }
    }
}
