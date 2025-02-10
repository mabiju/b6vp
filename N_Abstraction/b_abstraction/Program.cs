namespace b_abstraction;

abstract class MyClass
{
    // public virtual int calc(int a, int b)
    public int calc(int a, int b)
    {
        return (a + b);
    }
}

class YourClass : MyClass
{
    // public override int calc(int a, int b)
    public int mul(int a, int b)
    {
        return (a * b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        YourClass obj = new YourClass();
        int result = obj.calc(12, 34);
        Console.WriteLine("The result = {0}", result);
    }
}
