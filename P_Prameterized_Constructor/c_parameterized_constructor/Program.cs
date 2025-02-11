namespace c_parameterized_constructor;

class Car
{
    string name;
    int price;

    public Car(string n, int p)
    {
        name = n;
        price = p;
    }
    public void displayDetails()
    {
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Price = " + price);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car("Bugati Chiron", 76000);
        c1.displayDetails();
    }
}
