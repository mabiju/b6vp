namespace i_array_two_dimensional;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArray = new int[5, 2]
        {
            {23,4},
            {4,5},
            {41,34},
            {9,12},
            {34,1}
        };
        Console.WriteLine("Printing array elements:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("myArray {0}{1} = {2}", i, j, myArray[i,j]);
            }
        }
    }
}
