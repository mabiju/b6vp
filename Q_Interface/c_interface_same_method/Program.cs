namespace c_interface_same_method;

interface IStudent
{
    public void exam();
}
interface ITeacher
{
    public void exam();
}

public class College : IStudent, ITeacher
{
    void IStudent.exam()
    {
        Console.WriteLine("I am a student.");
    }
    void ITeacher.exam()
    {
        Console.WriteLine("I am a teacher.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IStudent s1 = new College();
        ITeacher t1 = new College();
        s1.exam();
        t1.exam();
    }
}
