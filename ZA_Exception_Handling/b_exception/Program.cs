namespace b_exception;

class Program
{
    static void Main(string[] args)
    {
        int a = 12, b = 0, result;

        try
        {
            result = a / b;
            Console.WriteLine("The result = " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e + "divisor cannot be zero.");
        }


    }
}
