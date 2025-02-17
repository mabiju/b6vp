// Lambda type : Statement Lambda
namespace d_lambda;

delegate void myDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) =>
        {
            Console.WriteLine("The result = " + (a * b));
            Console.WriteLine("End of the program");
        };
        d(2, 3);
    }
}
