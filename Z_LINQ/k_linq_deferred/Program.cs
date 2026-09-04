/* 2. Deferred Execution: In deferred execution, the LINQ query is not executed when it is created. It is executed later when the results are actually accessed, such as when using a foreach loop. Methods that cause deferred execution include:
a. Where()
b. Select()
c. OrderBy() 

Example
numbers.Where(...)
*/

namespace k_linq_deferred;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Query is created but NOT executed yet
        var result = numbers.Where(n => n > 25);

        Console.WriteLine("Query created.");

        // Query executes here
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}

/* The important point is:
var result = numbers.Where(n => n > 25);
does not immediately execute the query.

The query runs when:
foreach (int n in result)
accesses the results. */
