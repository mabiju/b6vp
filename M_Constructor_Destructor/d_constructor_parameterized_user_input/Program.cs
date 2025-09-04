namespace d_constructor_parameterized_user_input;
#nullable disable

class Student
{
    public int roll;
    public string name, address;

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
        int sr;
        string sn, sa;
        Console.WriteLine("Enter roll number:");
        sr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter name:");
        sn = Console.ReadLine();
        Console.WriteLine("Enter address:");
        sa = Console.ReadLine();

        Student s1 = new Student(sr, sn, sa);
        s1.displayDetails();
    }
}
