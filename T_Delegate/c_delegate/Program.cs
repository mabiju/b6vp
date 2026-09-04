namespace c_delegate;

public delegate int NumberCalc(int num);
class Program
{
    static int num = 10;
    public static int AddNum(int a)
    {
        num += a; // num = num + a;
        return num;
    }
    public static int MulNum(int a)
    {
        num *= a;   // num = num * a;
        return num;
    }
    public static int GetNum()
    {
        return num;
    }
    static void Main(string[] args)
    {
        NumberCalc nc1 = new NumberCalc(AddNum);
        nc1(5);
        Console.WriteLine("New value = {0}", GetNum());
        NumberCalc nc2 = new NumberCalc(MulNum);
        nc2(5);
        Console.WriteLine("New value = {0}", GetNum());
    }
}
