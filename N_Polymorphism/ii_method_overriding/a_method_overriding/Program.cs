namespace a_method_overriding;

class Dad
{
    public void hi()
    {
        Console.WriteLine("Hello Child.");
    }
}

class Child : Dad
{
    // public new void hi()
    public void hi()
    {
        Console.WriteLine("Hello Dad.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.hi();
    }
}
