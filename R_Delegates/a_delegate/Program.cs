namespace a_delegate;

public delegate void MyDel(string name);

class Program
{
    public static void displayName(string name)
    {
        Console.WriteLine("Name = " + name);
    }
    static void Main(string[] args)
    {
        MyDel d1 = new MyDel(displayName);
        d1("Sanothimi");
    }
}
