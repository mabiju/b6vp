namespace a_default_constructor;

class Student
{
    public Student()
    {
        Console.WriteLine("Hello Sanothimi");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Student obj = new Student();
        new Student();
    }
}
