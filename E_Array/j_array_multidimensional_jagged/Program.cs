namespace j_array_multidimensional_jagged;

class Program
{
    static void Main(string[] args)
    {
        int[][] myArray = new int[3][];
        myArray[0] = new int[3] { 12, 34, 56 };
        myArray[1] = new int[5] { 2, 34, 6, 56, 21 };
        myArray[2] = new int[2] { 82, 54 };
        foreach (int[] i in myArray)
        {
            foreach (int item in i)
            {
                Console.WriteLine(item);
            }
        }
    }
}
