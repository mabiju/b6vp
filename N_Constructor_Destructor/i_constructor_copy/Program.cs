namespace i_constructor_copy;

class Student
{
    string name;
    int age;

    // parameterized constructor
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    // copy constructor
    public Student(Student s)
    {
        this.name = s.name;
        this.age = s.age;
    }

    public void getData()
    {
        Console.WriteLine("Name = {0}", name);
        Console.WriteLine("Age = {0}", age);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Ram Thapa", 20);
        s1.getData();
        Student s2 = new Student(s1); // new object
        s2.getData();
    }
}

