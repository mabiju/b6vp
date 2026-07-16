namespace b_method_overriding;

public class Dad
{
    public virtual void hello()
    {
        Console.WriteLine("Hello from your dad.");
    }
}

public class Child : Dad
{
    public override void hello()
    {
        Console.WriteLine("Hello from your child.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Child c1 = new Child();
        // c1.hello();

        Dad d1 = new Child();
        d1.hello();
    }
}
