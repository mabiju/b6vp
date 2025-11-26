namespace f_stack_t;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 12, 34, 501, 5 };
        Stack<int> myNum = new Stack<int>(arr);

        foreach (var item in myNum)
            Console.WriteLine(item);

        Console.WriteLine("The number of elements in stack = " + myNum.Count);

        while (myNum.Count > 0)
            Console.WriteLine(myNum.Pop() + ",");

        Console.WriteLine("\nThe number of elements in stack = " + myNum.Count);
    }
}