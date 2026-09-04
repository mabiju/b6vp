namespace o_genetic_with_delegate;

class Program
{
    delegate T Add<T>(T a, T b);
    static void Main(string[] args)
    {
        Add<int> intResult = FunctionOne;
        Console.WriteLine("The sum = {0}",intResult(34,56));
        Add<string> stringResult = FunctionTwo;
        Console.WriteLine("The Conctenated string = {0}",stringResult("Ram","Sita"));
        Add<double> doubleResult = FunctionThree;
        Console.WriteLine("The sum = {0}",doubleResult(34.56,56.34));
    }

    static int FunctionOne(int x, int y)
    {
        return (x+y);
    }
    static string FunctionTwo(string x, string y)
    {
        return (x+y);
    }
    static double FunctionThree(double x, double y)
    {
        return (x+y);
    }
}
