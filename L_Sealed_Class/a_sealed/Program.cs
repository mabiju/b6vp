namespace a_sealed;

// sealed class SuperClass
class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi, friends!.");
    }
}
class SubClass : SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hello Sanothimi");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        obj.hi();
        obj.hello();
    }
}
