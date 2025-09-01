namespace d_explicit;

class Program
{
    static void Main(string[] args)
    {
        double a = 123.456;
        int b = (int)a;
        Console.WriteLine("Double value = " + a);
        Console.WriteLine("Converted integer value = " + b);
    }
}
// Explicit type conversion is also known as type casting
// where we can convert the value of larger data type to Smaller data type
// data may or may not lose
// search for narrowing type conversion and widening type conversion

