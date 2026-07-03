namespace a_array_nums;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 12, 34, 56, 7, 89, 90 };

        /* for(int i=0; i< myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        } */

        foreach (var item in myArray)
        {
            // Console.WriteLine(item);
            Console.Write("{0}\t",item);
        }
    }
}