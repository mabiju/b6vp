/* IEnumerable is a fundamental interface that represents a read-only sequence of items that can be
looked at one by one. It serves as the base contract for almost all collections in .NET—including arrays, List<T>,
and dictionaries—and is the core mechanism that powers the foreach loop. */

namespace q_ienumerable_demo;

class Program
{
    static void Main(string[] args)
    {

        //IEnumerable interface enables foreach looping construct.
        IEnumerable<int> e = Enumerable.Range(1, 10);

        Console.WriteLine("Enumerate using foreach");
        foreach (int i in e)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Enumerate using while");
        var enumerator = e.GetEnumerator();
        while (enumerator.MoveNext())
        {
            int i = enumerator.Current;
            Console.WriteLine(i);
        }
    }
}
