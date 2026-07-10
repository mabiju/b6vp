namespace f_hierarchical_inheritance;

public class A
{
    public int a = 45;
}
public class B : A
{
    public int b = 89;
    public void add()
    {
        Console.WriteLine("The sum = " + (a + b));
    }
}
public class C : A
{
    public int c = 90;
    public void add()
    {
        Console.WriteLine("The sum =" + (a + c));
    }
}
class Program
{
    static void Main(string[] args)
    {
        B b1 = new B();
        b1.add();
        C c1 = new C();
        c1.add();
    }
}