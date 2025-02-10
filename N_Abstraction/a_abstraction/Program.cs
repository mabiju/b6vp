namespace a_abstraction;

public abstract class HelloNepal
{
    public abstract void hello();
}

class Kathmandu : HelloNepal
{
    public override void hello()
    {
        Console.WriteLine("Hello Kathmandu");
    }
}
class Bhaktapur : HelloNepal
{
    public override void hello()
    {
        Console.WriteLine("Hello Bhaktapur");
    }
}
class Program
{
    static void Main(string[] args)
    {
        HelloNepal h;
        h = new Kathmandu();
        h.hello();
        h = new Bhaktapur();
        h.hello();
    }
}
