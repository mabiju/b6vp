namespace d_user_inputs_with_methods;
#nullable disable

class Student
{
    int roll;
    string name;

    public void input()
    {
        Console.WriteLine("Enter roll number:");
        roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter name:");
        name = Console.ReadLine();
    }
    public void output()
    {
        Console.WriteLine("The roll number is " + roll + " and name is " + name);
    }
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.input();
        s1.output();
    }
}
