namespace a_struct;

struct Student
{
    public int roll;

    public void getAge(int roll)
    {
        Console.WriteLine("Roll number = " + roll);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Student s1 = new Student();
        Student s1;
        s1.roll = 89;
        s1.getAge(s1.roll);
    }
}
