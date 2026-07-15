namespace j_constructor_parameterized_getter_setter;

class Person
{
    public string FirstName{ get; set; }
    public string LastName{ get; set; }

    public Person(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }
    static void Main(string[] args)
    {
        Person p1 = new Person("Ram", "Thapa");
        Console.WriteLine(p1.FirstName + " " + p1.LastName);
    }
}
