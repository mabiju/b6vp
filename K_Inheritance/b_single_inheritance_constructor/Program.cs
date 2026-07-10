namespace b_single_inheritance_constructor;

class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Constructor from Parent class");
    }
    public void ParentMethod()
    {
        Console.WriteLine("Hello from Parent method.");
    }
}
class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Constructor from Child class");
    }
    public void ChildMethod()
    {
        Console.WriteLine("Hello from Child method.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ChildClass c1 = new ChildClass();
        c1.ParentMethod();
        c1.ChildMethod();
    }
}
