namespace b_delegate;

public delegate void MyDel(int num);

class MyNum
{
    public static void square(int num)
    {
        Console.WriteLine("Square of {0} is = {1}", num, num * num);
    }
    public static void cube(int num)
    {
        Console.WriteLine("Cube of {0} is = {1}", num, num * num * num);
    }
}
class Program : MyNum
{
    static void Main(string[] args)
    {
        MyDel d1 = square;
        d1(3);
        MyDel d2 = cube;
        d2.Invoke(3);
    }
}
