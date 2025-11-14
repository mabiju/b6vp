// Lambda type : Expression Lambda
namespace b_lambda;

delegate int myDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) => (a + b);
        int value = d(10, 20);
        Console.WriteLine("The result = " + value);
    }
}
