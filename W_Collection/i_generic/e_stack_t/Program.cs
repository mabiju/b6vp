namespace e_stack_t;

class Program
{
    static void Main(string[] args)
    {
        /* Stack<int> myNums = new Stack<int>();
        myNums.Push(43);
        myNums.Push(45);
        myNums.Push(67);
        myNums.Push(98);
        myNums.Push(64);
        myNums.Push(32);
        myNums.Push(3); */

        int[] myNumsArray = new int[] {23,45,67,89,98};
        // int[] myNumsArray = new int[] {};
        Stack<int> myNums = new Stack<int>(myNumsArray);
        
        Console.WriteLine("The total number of elements in the stack = " + myNums.Count);
        myNums.Pop(); // LIFO
        if (myNums.Count > 0)
        {
            
            foreach (var item in myNums)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("This is nothing in the stack");
        }

    }
}
