namespace f_string_name_address;

class Program
{
    static void Main(string[] args)
    {
        string fname = "Sita";
        string lname = "Thapa";
        string address = "Ayodhya";
        Console.WriteLine(fname + " " + lname + " lives in " + address + ".");
        Console.WriteLine("{0} {1} lives in {2}.", fname, lname, address);
    }
}
