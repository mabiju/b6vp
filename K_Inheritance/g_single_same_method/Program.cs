namespace g_single_same_method;

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
        Console.WriteLine("Hello, this is sub class");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClass subo = new SubClass();
        SuperClass supo = new SubClass();
        subo.hi();
        supo.hi();
    }
}
