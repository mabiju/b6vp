namespace b_partial_class;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        string userInput = s1.getInput();
        s1.displayData(userInput);
    }
}
