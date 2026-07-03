namespace b_struct;

struct Student
{
    public int roll;
    public string name;
    public int age;
    public string address;
    public string faculty;
}
class Program
{
    static void Main(string[] args)
    {
        Student s1, s2;

        s1.roll = 23;
        s1.name = "ram";
        s1.age = 25;
        s1.address = "Ghopteodar";
        s1.faculty = "Education";

        s2.roll = 12;
        s2.name = "sita";
        s2.age = 22;
        s2.address = "Anakantar";
        s2.faculty = "Science";


        Console.WriteLine("Roll number of Student one = " + s1.roll);
        Console.WriteLine("Name of Student one = " + s1.name);
        Console.WriteLine("Age of Student one = " + s1.age);
        Console.WriteLine("Address of Student one = " + s1.address);
        Console.WriteLine("Faculty of Student one = " + s1.faculty);
        Console.WriteLine();
        Console.WriteLine("Roll number of Student two = " + s2.roll);
        Console.WriteLine("Name of Student two = " + s2.name);
        Console.WriteLine("Age of Student two = " + s2.age);
        Console.WriteLine("Address of Student two = " + s2.address);
        Console.WriteLine("Faculty of Student two = " + s2.faculty);
    }
}
