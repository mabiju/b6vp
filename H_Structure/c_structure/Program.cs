namespace c_structure;

struct Students
{
    public int roll;
    public string fullname;
    public string email;
    public string faculty;

    public void getDetails(int rn, string fn, string ei, string fa)
    {
        roll = rn;
        fullname = fn;
        email = ei;
        faculty = fa;
    }

    public void displayDetails()
    {
        Console.WriteLine("Roll number = {0}", roll);
        Console.WriteLine("Fullname = {0}", fullname);
        Console.WriteLine("Email = {0}", email);
        Console.WriteLine("Faculty = {0}", faculty);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Students st1 = new Students();
        Students st2 = new Students();

        st1.getDetails(12, "Ram Thapa", "ram@gmail.com", "Information Technology");
        st2.getDetails(23, "Sita Rai", "sita@yahoo.com", "Business Studies");
        st1.displayDetails();
        Console.WriteLine();
        st2.displayDetails();
    }
}
