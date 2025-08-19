namespace a_class_object_method;

class Student
{
    public void hello()
    {
        Console.WriteLine("Good morning friends.");
    }
    static void Main(string[] args)
    {
        /* creating an object for a class in C#
        class_name object = new class_name(); */
        Student s1 = new Student();
        s1.hello();
    }
}
