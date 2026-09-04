namespace d_delegate_singlecast;

public class Program
{
    public delegate void DelegateMethod();
    class MyClass
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
            Console.WriteLine("Good morning Sanothimi");
        }

        static void Main(string[] args)
        {
            DelegateMethod d1 = MyClass.display;
            DelegateMethod d2 = new DelegateMethod(MyClass.show);
            MyClass obj = new MyClass();
            DelegateMethod d3 = obj.print;
            d1();
            d2();
            d3.Invoke();
        }
    }

}
