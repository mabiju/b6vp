namespace f_type_conversion_non_compatible_convert_class;

class Program
{
    static void Main(string[] args)
    {
        string a = "123";
        int b = Convert.ToInt32(a);
        int c = 567;
        int sum = b + c;
        Console.WriteLine(a); // prints string value
        Console.WriteLine(b); // prints integer value
        Console.WriteLine(sum);
    }
}
/* Convert Classes
ToByte()
TyInt16() = > short
TyInt32() = > int
TyInt64() = > long */