namespace d_exception;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Ram", "Sita", "Hari" };
        try
        {
            // Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception found " + e);
        }
    }
}
