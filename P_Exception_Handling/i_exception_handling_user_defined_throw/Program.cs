namespace i_exception_handling_user_defined_throw;

class Program
{
    static void Main(string[] args)
    {
        Voter V = new Voter();
        try
        {
            V.checkage();
        }
        catch (AgeIsBelowEighteenException ex)
        {
            Console.WriteLine("AgeIsBelowEighteenException:{0}", ex);
        }
        Console.ReadLine();
    }
}
public class AgeIsBelowEighteenException : ApplicationException
{
    public AgeIsBelowEighteenException(string message) : base(message)
    {

    }
}
class Voter
{
    public void checkage()
    {
        Console.WriteLine("Enter your age :");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            throw (new AgeIsBelowEighteenException("You are not eligible to Vote"));
        }
        else
        {
            Console.WriteLine("you may Vote");
        }
    }
}
