namespace h_non_compatible_using_parse_method;

class Program
{
    static void Main(string[] args)
    {
        string a = "123";
        int b = int.Parse(a);
        Console.WriteLine(a); // prints string value
        Console.WriteLine(b); // prints integer value
    }
}


/* Every data type has a parse method
Byte.Parse();
short.Parse();
int.Parse();
bool.Parse(); */