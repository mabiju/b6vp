// Lambda type : Expression Lambda
namespace a_lambda;

delegate int myDel(int a);
class Program
{
    static void Main(string[] args)
    {
        myDel d = a => a * a;
        int value = d(5);
        Console.WriteLine("The result = " + value);
    }
}
