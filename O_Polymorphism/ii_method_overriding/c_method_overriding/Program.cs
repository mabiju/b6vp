namespace c_method_overriding;

public class Dad
{
    public void hello()
    {
        Console.WriteLine("Hello from your dad");
    }
}
public class Child : Dad
{
    public new void hello()
    {
        Console.WriteLine("Hello from your child");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dad d1 = new Child();
        d1.hello();
    }
}
