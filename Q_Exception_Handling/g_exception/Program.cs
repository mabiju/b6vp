// user defined exception using throw
namespace g_exception;

class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine(str);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyException obj = new MyException("This is user defined exception demo.");
        try
        {
            throw obj;
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

