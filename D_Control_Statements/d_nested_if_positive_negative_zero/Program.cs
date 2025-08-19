namespace d_nested_if_positive_negative_zero;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num != 0)
        {
            if (num > 0)
            {
                Console.WriteLine("The number " + num + " is a positive number.");
            }
            else
            {
                Console.WriteLine("The number " + num + " is a negative number.");
            }
        }
        else
        {
            Console.WriteLine("The number is " + num + ".");
        }
    }
}
