namespace c_enum;

class Program
{
    static void Main(string[] args)
    {
        string name;
        Days day;
        Console.WriteLine("Enter name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter values from (0-6) for day:");
        int index = int.Parse(Console.ReadLine());
        day = (Days)index;
        Console.WriteLine("Hello " + name + " today is " + day + ".");
    }

    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
}
