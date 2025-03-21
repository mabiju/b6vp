namespace e_stack_t;

class Program
{
    static void Main(string[] args)
    {
        /* Stack<int> myNums = new Stack<int>();
        myNums.Push(23);
        myNums.Push(34);
        myNums.Push(56);
        myNums.Push(1);
        myNums.Push(78);
        myNums.Push(456);
        myNums.Push(901);
        myNums.Push(44);
        myNums.Push(50); */

        int[] myNumArr = new int[] { 34, 56, 78, 901, 22, 53, 45, 56 };
        // int[] myNumArr = new int[] {};
        Stack<int> myNums = new Stack<int>(myNumArr);

        Console.WriteLine("The number of elements in the stack = " + myNums.Count);

        if (myNums.Count > 0)
        {
            myNums.Pop(); // LIFO
            foreach (var item in myNums)
            {
                Console.WriteLine(item);
            }
        }else{
            Console.WriteLine("There is nothing in the stack.");
        }

    }
}
