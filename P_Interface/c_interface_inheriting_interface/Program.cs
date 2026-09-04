namespace c_interface_inheriting_interface;

interface IMachine
{
    public void start();
}
interface IComputer : IMachine
{
    public void shutdown();
}

class Laptop : IComputer
{
    public void start()
    {
        Console.WriteLine("My laptop is statring....");
    }
    public void shutdown()
    {
        Console.WriteLine("My computer is shut down.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IComputer l1 = new Laptop();
        l1.start();
        l1.shutdown();
    }
}
