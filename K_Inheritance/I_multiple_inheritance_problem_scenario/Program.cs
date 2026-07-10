namespace I_multiple_inheritance_problem_scenario;

class Father
{
    public void FatherMethod()
    {
        Console.WriteLine("Hello from your dad.");
    }
}
class Mother
{
    public void MotherMethod()
    {
        Console.WriteLine("Hello from your mother.");
    }
}

class Child : Father, Mother // Child class cannot have multiple parent classes.
{
    public void ChildMethod()
    {
        Console.WriteLine("Hello dad and mom");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.ChildMethod();
        c1.FatherMethod();
        c1.MotherMethod();
    }
}
