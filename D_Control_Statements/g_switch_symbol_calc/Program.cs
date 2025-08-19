namespace g_switch_symbol_calc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your choice from the list below");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Press + to find sum");
        Console.WriteLine("Press - to find difference");
        Console.WriteLine("Press * to find product");
        Console.WriteLine("Press / to find quotient");

        switch (Console.ReadLine())
        {
            case "+":
                Console.WriteLine("Sum = " + (a + b));
                break;
            case "-":
                Console.WriteLine("Difference = " + (a - b));
                break;
            case "*":
                Console.WriteLine("Product = " + (a * b));
                break;
            case "/":
                Console.WriteLine("Quotient = " + (a / b));
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
