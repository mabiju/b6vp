namespace e_stack_t;

class Program
{
    static void Main(string[] args)
    {
        /* Stack<int> myNums = new Stack<int>();
        myNums.Push(78);
        myNums.Push(8);
        myNums.Push(7);
        myNums.Push(787);
        myNums.Push(788);
        myNums.Push(34);
        myNums.Push(1);
        myNums.Push(781); */

        // int[] myArray = new int[] {};
        int[] myArray = new int[] {34,6,72,35,12,32,456};
        Stack<int> myNums = new Stack<int>(myArray);

        Console.WriteLine("The total number of elements in the stack = " + myNums.Count);
        myNums.Pop(); // LIFO
        if(myNums.Count > 0)
        {
            foreach (var item in myNums)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("There is nothing in the stack");
        }
        
    }
}
