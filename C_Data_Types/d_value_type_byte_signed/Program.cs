namespace d_value_type_byte_signed;

class Program
{
    static void Main(string[] args)
    {
        sbyte a = 126;

        // sbyte is 8 bit  
        // singned value 
        Console.WriteLine(a);

        a++;
        Console.WriteLine(a);

        // It overflows here because 
        // byte can hold values  
        // from -128 to 127 
        a++;
        Console.WriteLine(a);

        // Looping back within  
        // the range 
        a++;
        Console.WriteLine(a);
    }
}
