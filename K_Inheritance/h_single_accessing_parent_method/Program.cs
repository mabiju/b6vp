namespace h_single_accessing_parent_method;

class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi, this is super class");
    }
}
class SubClass : SuperClass
{
    public new void hi()
    {
        base.hi();
        Console.WriteLine("Hello, this is sub class");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClass subo = new SubClass();
        subo.hi();
    }
}
