namespace a_encapsulation;

class Student
{
    private int roll;

    public int DisplayRoll(int a)
    {
        roll = a;
        return roll;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine("Roll number = " + s1.DisplayRoll(34));
    }
}
