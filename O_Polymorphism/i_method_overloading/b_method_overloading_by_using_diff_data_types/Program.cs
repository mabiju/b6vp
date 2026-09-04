namespace b_method_overloading_by_using_diff_data_types;

class MyAdder
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
        MyAdder obj = new MyAdder();
        Console.WriteLine("The sum of integers = " + obj.add(10, 20));
        Console.WriteLine("The sum of doubles = " + obj.add(10.78, 20.45));
        Console.WriteLine("String concatenation = " + obj.add("Ram ", "Thapa"));
    }
}
