namespace a_interface;

interface IVehicle
{
    void accerlerate();
}

class Aeroplane : IVehicle
{
    public void accerlerate()
    {
        Console.WriteLine("Plane flies.");
    }
}
class Car : IVehicle
{
    public void accerlerate()
    {
        Console.WriteLine("Car runs.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IVehicle Boeing747 = new Aeroplane();
        IVehicle BugatiVeron = new Car();
        Boeing747.accerlerate();
        BugatiVeron.accerlerate();
    }
}
