namespace b_if_else_positive_negative;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
        {
            Console.WriteLine("The number " + num + " is a +ve number.");
        }
        else
        {
            Console.WriteLine("The number " + num + " is a -ve number.");
        }
    }
}
