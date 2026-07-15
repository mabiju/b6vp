namespace c_constructor_parameterized;

class Student
{
    public int roll;
    public string name;
    public string address;

    public Student(int r, string n, string a)
    {
        roll = r;
        name = n;
        address = a;
    }
    public void displayDetails()
    {
        Console.WriteLine("Roll number of " + name + " is " + roll + " and lives in " + address + ".");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(45, "Ram Thapa", "Anakantar - 420, Ghopteodar");
        s1.displayDetails();
    }
}
