namespace b_interface_multiple_inheritance_solution;

interface IDad
{
    void hi();
}
interface IMom
{
    void hello();
}

class Child : IDad, IMom
{
    public void hi()
    {
        Console.WriteLine("Hi from your dad");
    }
    public void hello()
    {
        Console.WriteLine("Hello from your mom");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.hi();
        c1.hello();
    }
}
