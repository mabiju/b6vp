namespace e_constructor;

class Teacher
{
    public Teacher()
    {
        Console.WriteLine("Hello Students");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher();
    }
}
