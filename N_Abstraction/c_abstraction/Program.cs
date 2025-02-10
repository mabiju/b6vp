namespace c_abstraction;

abstract class MyClass
{
    public abstract void calculate(double a);
}

class SubclassOne : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Square root = " + Math.Sqrt(a));
    }
}
class SubclassTwo : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Square = " + (a * a));
    }
}
class SubclassThree : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Cube = " + (a * a * a));
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubclassOne obj1 = new SubclassOne();
        SubclassTwo obj2 = new SubclassTwo();
        SubclassThree obj3 = new SubclassThree();

        obj1.calculate(9);
        obj2.calculate(9);
        obj3.calculate(9);
    }
}
