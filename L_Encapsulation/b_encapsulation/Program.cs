namespace b_encapsulation;
#nullable disable

class Student
{
    private int sroll;
    private string sname;

    public int Roll
    {
        get
        {
            return sroll;
        }
        set
        {
            sroll = value;
        }
    }
    public string Name
    {
        get
        {
            return sname;
        }
        set
        {
            sname = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Roll = 56;
        s1.Name = "Ram";

        Console.WriteLine("Roll number = " + s1.Roll);
        Console.WriteLine("Name = " + s1.Name);
    }
}
