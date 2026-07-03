namespace e_explicit;

class Program
{
    static void Main(string[] args)
    {
        int a = 78;
        byte b = (byte)a; // careful about the range of byte i.e 0-255
        Console.WriteLine("Integer value = " + a);
        Console.WriteLine("Converted byte value = " + b);
    }
}
// where data remains same cause of range (byte)
