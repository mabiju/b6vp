namespace g_multiplication_table_upto_user_input;

class Program
{
    static void Main(string[] args)
    {
        int n;
        string input;
        do
        {
            Console.WriteLine("Multiplication table upto:");
            input = Console.ReadLine();
        }
        while (!int.TryParse(input, out n));

        WriteMultiplicationTable(n);
        Console.ReadLine();
    }
    private static void WriteMultiplicationTable(int n)
    {
        int i = 1;
        while (i <= n)
        {
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                j++;
            }
            Console.WriteLine("--------------------");
            i++;
        }
    }
}