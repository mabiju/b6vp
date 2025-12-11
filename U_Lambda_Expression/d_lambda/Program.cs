// Lambda type : Statement Lambda
namespace d_lambda;

delegate void myDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) =>
        {
            Console.WriteLine("The sum = " + (a + b));
            Console.WriteLine("End of the program");
        };
        d(10, 20);
    }
}
