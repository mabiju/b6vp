namespace d_interface_inherit_interface;

interface IOne
{
    public void MethodOne();
}
interface ITwo
{
    public void MethodTwo();
}
interface IThree : IOne, ITwo
{
    public void MethodThree();
}
public class Program : IThree
{
    void IOne.MethodOne()
    {
        Console.WriteLine("I'm body from Interface IOne");
    }
    void ITwo.MethodTwo()
    {
        Console.WriteLine("I'm body from Interface ITwo");
    }
    void IThree.MethodThree()
    {
        Console.WriteLine("I'm body from Interface IThree");
    }
    static void Main(string[] args)
    {
        IThree i = new Program();
        i.MethodOne();
        i.MethodTwo();
        i.MethodThree();
    }
}
