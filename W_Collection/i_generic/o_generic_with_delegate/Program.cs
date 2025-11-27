namespace o_generic_with_delegate;

class Program
{
    delegate T Add<T>(T a, T b);
    static void Main(string[] args)
    {
        Add<int> ptr1 = Function1;
        Console.WriteLine("Sum={0}", ptr1(4, 7));

        Add<string> ptr2 = Function2;
        Console.WriteLine("Sum={0}", ptr2("A", "B"));

        Add<double> ptr3 = Function3;
        Console.WriteLine("Sum={0}", ptr3(4.4, 7));
    }
    static int Function1(int x, int y)
    {
        return x + y;
    }

    static string Function2(string x, string y)
    {
        return x + y;
    }

    static double Function3(double x, double y)
    {
        return x + y;
    }
}
