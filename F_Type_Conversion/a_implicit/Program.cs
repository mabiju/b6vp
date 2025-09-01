namespace a_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        float b = a; // implicit
        // float b = (float)a; // explicit
        Console.WriteLine("The byte value before conversion : " + a);
        Console.WriteLine("The float value after conversion : " + b);
    }
}
