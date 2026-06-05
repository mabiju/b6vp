namespace f_reference_type_object;

class Program
{
    static void Main(string[] args)
    {
        // declare object obj 
        object obj;
        obj = 45;
        Console.WriteLine(obj);
        // to show type of object 
        // using GetType() 
        Console.WriteLine(obj.GetType());
    }
}
