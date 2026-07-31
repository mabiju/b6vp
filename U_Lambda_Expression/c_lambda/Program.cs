// Lambda type : Expression Lambda
namespace c_lambda;

delegate int myDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) => a > b ? a : b;
        int value = d(45, 67);
        Console.WriteLine("The larger value = " + value);
    }
}
