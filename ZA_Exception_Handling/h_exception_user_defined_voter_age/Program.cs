namespace h_exception_user_defined_voter_age;

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
            throw new InvalidVoter("You cannot cast your vote.");
        }
    }
    static void Main(string[] args)
    {
        try
        {
            ageValidate(10);
        }
        catch (InvalidVoter e)
        {
            Console.WriteLine(e);
        }
    }
}
