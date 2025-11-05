namespace a_virtual_method;

class SuperClass
{
    public virtual int add(int a, int b)
    {
        return (a + b);
    }
}
class SubClass : SuperClass
{
    public override int add(int a, int b)
    {
        return (a + b + 5);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        Console.WriteLine("The new redefined sum = " + obj.add(10, 20));
    }
}
