namespace h_constructor_overloading_by_diff_data_types;

class Add
{
    int a;
    double d;
    string s;

    // Constructor One
    public Add(int x, double y)
    {
        a = x;
        d = y;
    }

    // Constructor Two
    public Add(int x, string y)
    {
        a = x;
        s = y;
    }

    public void displayOne()
    {
        Console.WriteLine("Integer + Double = " + (a + d));
    }
    public void displayTwo()
    {
        Console.WriteLine("String + Integer = " + (s + a));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Add obj1 = new Add(12, 23.45);
        obj1.displayOne();
        Add obj2 = new Add(420, "Roll number is :");
        obj2.displayTwo();
    }
}