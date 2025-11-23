namespace b_string_builder_append_format;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("The cost price of this mobile phone is :");
        // s.Append(999.9);
        s.AppendFormat("{0:c}", 999.9);
        Console.WriteLine(s);
    }
}
