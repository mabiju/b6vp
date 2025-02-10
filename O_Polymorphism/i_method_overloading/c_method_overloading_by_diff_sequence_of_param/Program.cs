// method overloading by different sequence of parameters
namespace c_method_overloading_by_diff_sequence_of_param;

class MyClass
{
    public void DisplayDetails(int age, string name)
    {
        Console.WriteLine(name + " is " + age + " years old.");
    }
    public void DisplayDetails(string name, int age)
    {
        Console.WriteLine(name + " is " + age + " years old.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.DisplayDetails(25, "Ram");
        obj.DisplayDetails("Sita", 22);
    }
}
