namespace c_struct;

struct Students
{
    public int roll;
    public string faculty;
    public string address;
    public string email;

    public void getDetails(int r, string f, string a, string e)
    {
        roll = r;
        faculty = f;
        address = a;
        email = e;
    }
    public void displayDetails()
    {
        Console.WriteLine("Roll number = {0}", roll);
        Console.WriteLine("Faculty = {0}", faculty);
        Console.WriteLine("Address = {0}", address);
        Console.WriteLine("Email = {0}", email);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Students s1 = new Students();
        Students s2 = new Students();

        s1.getDetails(12, "Education", "Pokhara", "ram@gmail.com");
        s2.getDetails(17, "Humanities", "Chitwan", "sita@gmail.com");
        s1.displayDetails();
        Console.WriteLine();
        s2.displayDetails();
    }
}
