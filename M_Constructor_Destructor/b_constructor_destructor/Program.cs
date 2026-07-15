namespace b_constructor_destructor;

class Employee
{
    public Employee()
    {
        Console.WriteLine("Constructor called.");
    }
    // not executed though destroys the object call.
    ~Employee()
    {
        Console.WriteLine("Destructor called.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
    }
}
