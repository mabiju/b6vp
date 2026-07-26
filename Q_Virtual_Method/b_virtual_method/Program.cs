namespace b_virtual_method;

class Shape
{
    protected int width, height;
    public Shape(int a = 0, int b = 0)
    {
        width = a;
        height = b;
    }
    public virtual int area()
    {
        return 0;
    }
}

class Rectangle : Shape
{
    public Rectangle(int a = 0, int b = 0) : base(a, b) { }
    public override int area()
    {
        Console.Write("Rectangle ");
        return (width * height);
    }
}
class Triangle : Shape
{
    public Triangle(int a = 0, int b = 0) : base(a, b) { }
    public override int area()
    {
        Console.Write("Triangle ");
        return (width * height / 2);
    }
}

class Caller
{
    public void CallArea(Shape sh)
    {
        int ar;
        ar = sh.area();
        Console.WriteLine("area = {0}", ar);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Caller obj = new Caller();
        Rectangle r = new Rectangle(10, 20);
        Triangle t = new Triangle(10, 20);
        obj.CallArea(r);
        obj.CallArea(t);
    }
}
