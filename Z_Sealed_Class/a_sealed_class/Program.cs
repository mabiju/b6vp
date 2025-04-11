namespace a_sealed_class;

// sealed class SuperClass
class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi Sanothimi");
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
        SubClass s1 = new SubClass();
        s1.hi();
        s1.hello();
    }
}
