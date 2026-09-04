namespace a_method_overloading_by_using_diff_no_of_param;

class MyNum
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public int add(int a, int b, int c)
    {
        return (a + b + c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyNum obj = new MyNum();
        Console.WriteLine("The sum = " + obj.add(10, 20));
        Console.WriteLine("The sum = " + obj.add(10, 20, 40));
    }
}
