namespace g_exception_user_defined_throw;

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
        MyException obj = new MyException("The is user defined exception handling demo.");
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

