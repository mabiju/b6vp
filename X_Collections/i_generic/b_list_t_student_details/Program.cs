namespace b_list_t_student_details;

#nullable disable
public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student() {Roll = 420, Name= "Ram Thapa"},
            new Student() {Roll = 421, Name= "Sita Thapa"},
            new Student() {Roll = 422, Name= "Hari Thapa"},
            new Student() {Roll = 423, Name= "Nita Thapa"},
            new Student() {Roll = 424, Name= "Mina Thapa"}
        };

        var StudNames =
            from s in students
                // where s.Name == "Nita Thapa"
            select s;

        foreach (var student in StudNames)
        {
            Console.WriteLine(student.Roll + " " + student.Name);
        }

    }
}
