namespace a_value_types;

class Program
{
    static void Main(string[] args)
    {
        // declaring character 
        char a = 'S';

        // Integer data type is generally 
        // used for numeric values 
        int i = 89;

        short s = 56;

        // this will give error as number 
        // is larger than short range 
        // short s1 = 87878787878; 

        // long uses Integer values which  
        // may signed or unsigned 
        long l = 4564;

        // UInt data type is generally 
        // used for unsigned integer values 
        uint ui = 95;

        ushort us = 76;
        // this will give error as number is 
        // larger than short range 

        // ulong data type is generally 
        // used for unsigned integer values 
        ulong ul = 3624573;

        // by default fraction value 
        // is double in C# 
        double d = 8.358674532;

        // for float use 'f' as suffix 
        float f = 3.7330645f;

        // for float use 'm' as suffix 
        decimal dc = 389.5m;


        Console.WriteLine("Character = " + a);
        Console.WriteLine("Integer = " + i);
        Console.WriteLine("Short = " + s);
        Console.WriteLine("Long = " + l);
        Console.WriteLine("Unsigned integer = " + ui);
        Console.WriteLine("Unsigned short = " + us);
        Console.WriteLine("Unsigned long = " + ul);
        Console.WriteLine("Double = " + d);
        Console.WriteLine("Float = " + f);
        Console.WriteLine("Decimal = " + dc);
    }
}
