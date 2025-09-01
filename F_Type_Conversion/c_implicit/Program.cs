namespace c_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        int b = a;
        long c = a;

        /* int b = (int)a;
        long c = (long)a; */

        Console.WriteLine("Byte a =" + a);
        Console.WriteLine("Integer b = " + b);
        Console.WriteLine("Long integer c = " + c);
    }
}
