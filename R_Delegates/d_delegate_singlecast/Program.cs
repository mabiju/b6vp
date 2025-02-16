namespace d_delegate_singlecast;

class Program
{
    public delegate void DetegateMethod();
    public class MyClass
    {
        public static void display()
        {
            Console.WriteLine("Hello Sanothimi");
        }
        public static void show()
        {
            Console.WriteLine("Hi Sanothimi");
        }
        public void print()
        {
            Console.WriteLine("Namaste Sanothimi");
        }
    }
    static void Main(string[] args)
    {
        DetegateMethod d1 = MyClass.display;
        DetegateMethod d2 = new DetegateMethod(MyClass.show);
        MyClass obj = new MyClass();
        DetegateMethod d3 = obj.print;
        d1();
        d2();
        d3();
    }
}
