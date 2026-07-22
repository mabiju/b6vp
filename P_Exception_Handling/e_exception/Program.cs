namespace e_exception;

class Program
{
    static void Main(string[] args)
    {
        // string value = null;
        string value = "ram";
        try
        {
            // if(value.Length == 0){
            if(value.Length != 0){
                Console.WriteLine(value);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception found " + e);
        }
    }
}
