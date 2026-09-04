/* 
There are two important ways LINQ queries are executed:

1. Immediate Execution: In immediate execution, the LINQ query is executed immediately when the query is created, and the result is stored in a collection or value. Common methods that cause immediate execution include:
a. ToList()
b. ToArray()
c. Count()
d. Sum()
e. Average()
f. First()

Example:
numbers.Where(...).ToList()
 */

namespace j_linq_immediate;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Query is executed immediately because of ToList()
        var result = numbers
            .Where(n => n > 25)
            .ToList();
            
        Console.WriteLine("Results:");
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}

// Here, ToList() executes the LINQ query immediately and stores the results in result.