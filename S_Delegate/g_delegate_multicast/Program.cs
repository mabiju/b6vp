namespace g_delegate_multicast;

#nullable disable
class Program
{
    public delegate void DelMethod(int x, int y);
    public class TestMultipleDelegate
    {
        public void plus_Method1(int x, int y)
        {
            Console.Write("You are in plus_Method :");
            Console.WriteLine(x + y);
        }
        public void subtract_Method2(int x, int y)
        {
            Console.Write("You are in subtract_Method :");
            Console.WriteLine(x - y);
        }
    }
    static void Main(string[] args)
    {
        TestMultipleDelegate obj = new TestMultipleDelegate();
        DelMethod del = new DelMethod(obj.plus_Method1);
        // Here we have multicast  
        del += new DelMethod(obj.subtract_Method2);
        // plus_Method1 and subtract_Method2 are called  
        del(50, 10);
        Console.WriteLine();
        //Here again we have multicast  
        del -= new DelMethod(obj.plus_Method1);
        //Only subtract_Method2 is called  
        del(20, 10);
    }
}
