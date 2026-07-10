namespace a_static;

static class Shape
{
    public static int length = 23;
    public static int squareArea()
    {
        return (length * length);
    }
    public static int cube(int a)
    {
        return (a * a * a);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The length of the shape = " + Shape.length);
        Console.WriteLine("The area of the square = " + Shape.squareArea() + " u. sq.");
        Console.WriteLine("The cube of the given number = " + Shape.cube(5));
    }
}
