namespace c_static;

class Employee
{
    public static string companyName = "Microsoft";
    public int empId;
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.empId = 56;

        Console.WriteLine("Employee id = " + e1.empId);
        Console.WriteLine("Company name = " + Employee.companyName);

        Employee e2 = new Employee();
        e2.empId = 23;
        Console.WriteLine("Employee id = " + e2.empId);
        Console.WriteLine("Company name = " + Employee.companyName);

        Employee e3 = new Employee();
        e3.empId = 33;
        Employee.companyName = "Google";
        Console.WriteLine("Employee id = " + e3.empId);
        Console.WriteLine("Company name = " + Employee.companyName);
    }
}
