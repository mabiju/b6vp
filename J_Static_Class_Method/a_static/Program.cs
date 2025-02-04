namespace a_static;

static class Shape
{
    public static int length = 45;

    public static int areaSquare()
    {
        return (length * length);
    }
    public static int cube(int a)
    {
        return (a*a*a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The length = " + Shape.length);
        Console.WriteLine("Area of square = " + Shape.areaSquare() + " u. sq.");
        Console.WriteLine("Cube of a number = " + Shape.cube(5));
    }
}
