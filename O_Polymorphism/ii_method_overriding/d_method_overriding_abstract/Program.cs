namespace d_method_overriding_abstract;

abstract class Calc
{
    public abstract int sum();
}

class Nums : Calc
{
    int num1;
    int num2;
    public Nums(int a = 0, int b = 0)
    {
        num1 = a;
        num2 = b;
    }
    public override int sum()
    {
        return (num1 + num2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nums obj = new Nums(45, 67);
        int result = obj.sum();
        Console.WriteLine("The sum =" + result);
    }
}