namespace a_method_overriding;

class Dad
{
    public void hi()
    {
        Console.WriteLine("Hi child.");
    }
}
class Child : Dad
{
    // public void hi()
    public new void hi()
    {
        Console.WriteLine("Hi dad.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child obj = new Child();
        obj.hi();
    }
}
