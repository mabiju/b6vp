namespace b_interface;

interface IStudent
{
    public void Learn();
}
interface ITecher
{
    public void Teach();
}

class College : IStudent, ITecher
{
    public void Learn()
    {
        Console.WriteLine("Student learns");
    }
    public void Teach()
    {
        Console.WriteLine("Teacher teaches");
    }
}
class Program
{
    static void Main(string[] args)
    {
        College sanothimi = new College();
        sanothimi.Learn();
        sanothimi.Teach();
    }
}
