// Method overloading by using different data types
namespace b_method_overloading_by_diff_data_types;

class MyNum
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public double add(double a, double b)
    {
        return (a + b);
    }
    public string add(string a, string b)
    {
        return (a + b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyNum obj = new MyNum();
        Console.WriteLine("The sum = " + obj.add(23, 45));
        Console.WriteLine("The sum = " + obj.add(23.34, 45.67));
        Console.WriteLine("String concatenation = " + obj.add("Ram ", "Thapa"));
    }
}
