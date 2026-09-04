namespace e_encapsulation;

class Student
{
    private string code = "";
    private string name = "";
    private int age = 0;

    // Declare a Code property of type string:
    public string Code
    {
        get { return code; }
        set { code = value; }
    }

    // Declare a Name property of type string:
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Declare a Age property of type int:
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public override string ToString()
    {
        return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Student object:
        Student s = new Student();

        // Setting code, name and the age of the student
        s.Code = "001";
        s.Name = "Ram";
        s.Age = 9;
        Console.WriteLine("Student Info: {0}", s);

        //let us increase age
        s.Age += 1;
        Console.WriteLine("Student Info: {0}", s);
    }
}
