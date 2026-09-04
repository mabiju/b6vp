namespace d_interface_with_property;

interface IVehicle
{
    int speed { get; set; } // property
    void run();
}
class Car : IVehicle
{
    public int speed { get; set; }
    public void run()
    {
        Console.WriteLine($"Car is running at{speed} km/h");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car { speed = 76 };
        c1.run();
    }
}
