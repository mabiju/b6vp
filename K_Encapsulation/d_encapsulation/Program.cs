namespace d_encapsulation;

class Cuboid
{
    private double length;
    private double breadth;
    private double height;

    public void setData()
    {
        Console.Write("Enter length:");
        length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter breadth:");
        breadth = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height:");
        height = Convert.ToDouble(Console.ReadLine());
    }
    public double vol()
    {
        return length * breadth * height;
    }
    public void displayVolume()
    {
        Console.WriteLine("The volume is = " + vol());
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cuboid c1 = new Cuboid();
        c1.setData();
        c1.displayVolume();
    }
}