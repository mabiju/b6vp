namespace b_list_t_student_list;
#nullable disable

public class Student
{
    public int roll {get; set;}
    public string name {get; set;}
}

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student() {roll = 420, name = "Ram Thapa"},
            new Student() {roll = 421, name = "Sita Nepal"},
            new Student() {roll = 422, name = "Hari Khadka"},
            new Student() {roll = 423, name = "Tina Dube"}
        };

        var StudNames = 
            from s in students
                where s.name == "Hari Khadka"
            select s;

        foreach (var student in StudNames)
        {
            Console.WriteLine(student.roll + " " + student.name);
        }
    }
}
