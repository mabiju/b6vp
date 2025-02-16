namespace f_delegate_multicast_static;

public delegate void MyDel(int a, int b);
class MyClass
{
    public static void sum(int a, int b)
    {
        Console.WriteLine("The sum = " + (a + b));
    }
    public static void product(int a, int b)
    {
        Console.WriteLine("The product = " + (a * b));
    }
    static void Main(string[] args)
    {
        MyDel d1 = new MyDel(MyClass.sum);
        MyDel d2 = new MyDel(MyClass.product);
        d1 = d1 + d2;
        d1(10, 20);
    }
}
