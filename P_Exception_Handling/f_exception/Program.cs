namespace f_exception;

class MyClass
{
    public int divide(int a, int b)
    {
        int result = a / b;
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine("Enter dividend:");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter divisor:");
        int divisor = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine("The quotient is = " + obj.divide(dividend, divisor));
        }
        catch (Exception e)
        {
            Console.WriteLine(e + " Cannot divide by " + divisor);
        }
        
    }
}
