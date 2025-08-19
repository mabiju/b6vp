namespace o_return_add;

class Program
{
    static void Main(string[] args)
    {
        int a = 35, b = 25, sum = 0;
        sum = add(a, b);
        Console.WriteLine("The sum = " + sum);
    }
    public static int add(int x, int y)
    {
        int s = x + y;
        return s;
    }
}