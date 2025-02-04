namespace b_static;

static class Student
{
    public static string fname = "Ram";
    public static string lname = "Thapa";
    public static int marks = 78;

    public static void display()
    {
        Console.WriteLine("Details of student:");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student.display();
        Console.WriteLine("First name = " + Student.fname);
        Console.WriteLine("Last name = " + Student.lname);
        Console.WriteLine("Obtained marks = " + Student.marks);
    }
}
