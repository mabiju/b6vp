namespace a_abstract_method;

abstract class HelloNepal
{
    public abstract void hi();
}
class Kathmandu : HelloNepal
{
    public override void hi()
    {
        Console.WriteLine("Hi Kathmandu");
    }
}
class Bhaktapur : HelloNepal
{
    public override void hi()
    {
        Console.WriteLine("Hi Bhaktapur");
    }
}
class Program
{
    static void Main(string[] args)
    {
        HelloNepal h;
        h = new Kathmandu();
        h.hi();
        h = new Bhaktapur();
        h.hi();
    }
}
