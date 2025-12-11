namespace d_stack;

using System.Collections;
class Program
{
    static void Main()
    {
        // Create a non-generic stack
        Stack stack = new Stack();

        // Add elements to the stack using Push
        stack.Push(10);          // Integer
        stack.Push("Hello");     // String
        stack.Push(3.14);        // Double
        stack.Push(true);        // Boolean

        // Display all elements in the stack
        Console.WriteLine("Stack Elements:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // Remove and display the top element using Pop
        Console.WriteLine("\nPopped Element: " + stack.Pop());

        // Peek at the top element without removing it
        Console.WriteLine("Top Element (Peek): " + stack.Peek());

        // Check if a specific element exists in the stack
        Console.WriteLine("Contains 'Hello': " + stack.Contains("Hello"));

        // Display remaining elements after Pop
        Console.WriteLine("\nRemaining Stack Elements:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

