// Method overloading by using different number of parameters
namespace a_method_overloading_by_diff_no_of_param;

class MyCalc
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
        MyCalc obj = new MyCalc();
        Console.WriteLine("The Sum = " + obj.add(45, 56));
        Console.WriteLine("The Sum = " + obj.add(45, 56, 12));
    }
}
