// explicit interface interaction
namespace e_interface_same_method;

interface IDad
{
    void call();
}
interface IMom
{
    void call();
}

class Home : IDad, IMom
{
    void IDad.call()
    {
        Console.WriteLine("Calling from your Dad.");
    }
    void IMom.call()
    {
        Console.WriteLine("Calling from your Mom.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Home h1 = new Home();
        IDad d1 = h1;
        IMom m1 = h1;
        d1.call();
        m1.call();
    }
}
