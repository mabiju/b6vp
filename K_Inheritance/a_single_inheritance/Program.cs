namespace a_single_inheritance;

class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi friends! I'm from Super class.");
    }
}
class SubClass : SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hello friends! I'm from Sub class.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        obj.hello(); // own method
        obj.hi(); // method from super class
    }
}
