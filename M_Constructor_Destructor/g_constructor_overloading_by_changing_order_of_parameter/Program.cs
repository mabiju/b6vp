namespace g_constructor_overloading_by_changing_order_of_parameter;

class Student
{
    public int roll;
    public double height;
    public string name;

    // first constructor
    public Student(double h, string n, int r)
    {
        height = h;
        name = n;
        roll = r;
    }
    // second constructor
    public Student(string n, int r, double h)
    {
        name = n;
        roll = r;
        height = h;
    }
    public void display()
    {
        Console.WriteLine("Roll number = " + roll);
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Height = " + height + " feet");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(5.8, "Ram", 23);
        Student s2 = new Student("Sita", 23, 6.2);

        Console.WriteLine("First Constructor");
        s1.display();
        Console.WriteLine("Second Constructor");
        s2.display();
    }
}
