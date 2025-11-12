namespace f_abstract;

abstract class SuperClass
{
    public int sum(int i, int j)
    {
        return i + j;
    }
    public abstract int product(int i, int j);
}
class SubOne : SuperClass
{
    public override int product(int i, int j)
    {
        return i * j;
    }
}
class SubTwo : SuperClass
{
    public override int product(int i, int j)
    {
        return i - j;
    }
}
class SubThree : SubOne
{
    public override int product(int i, int j)
    {
        return i + j;
    }
}
class MyClass
{
    static void Main(string[] args)
    {
        SubOne obj = new SubThree();
        int a = obj.product(2, 4);
        SuperClass obj1 = new SubOne();
        int b = obj1.product(4, 2);
        SuperClass obj2 = new SubTwo();
        int c = obj2.product(4, 2);
        Console.Write("{0},{1},{2}", a, b, c);
    }
}

