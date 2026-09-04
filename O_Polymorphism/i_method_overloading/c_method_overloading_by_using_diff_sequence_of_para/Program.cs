namespace c_method_overloading_by_using_diff_sequence_of_para;

class MyClass
{
    public void displayDetails(int age, string name)
    {
        Console.WriteLine(name + " is " + age + " years old.");
    }
    public void displayDetails(string name, int age)
    {
        Console.WriteLine(name + " is " + age + " years old.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.displayDetails("Ram", 23);
        obj.displayDetails(12, "Sita");
    }
}
