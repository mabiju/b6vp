namespace e_hierarchical_inheritance;

class Father
{
    public void dad()
    {
        Console.WriteLine("Hello Child");
    }
}
class Son : Father
{
    public void xora()
    {
        Console.WriteLine("Hello Father, I'm your son");
    }
}
class Daughter : Father
{
    public void xori()
    {
        Console.WriteLine("Hello Father, I'm your daughter");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Son s = new Son();
        s.dad();
        s.xora();

        Daughter d = new Daughter();
        d.dad();
        d.xori();
    }
}
