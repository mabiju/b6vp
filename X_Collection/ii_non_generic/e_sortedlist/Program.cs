namespace e_sortedlist;

using System.Collections;
class Program
{
    static void Main()
    {
        // Create a non-generic SortedList
        SortedList sortedList = new SortedList();

        // Add key-value pairs to the SortedList
        sortedList.Add("First", "Hello");
        sortedList.Add("Second", "World");
        sortedList.Add("Third", "!");

        // Display all key-value pairs in the SortedList
        Console.WriteLine("SortedList Elements:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // Access a value by its key
        Console.WriteLine("\nValue for 'Second': " + sortedList["Second"]);

        // Access a value by its index
        Console.WriteLine("Value at Index 1: " + sortedList.GetByIndex(1));

        // Remove an element by its key
        sortedList.Remove("Second");

        // Display remaining elements after removal
        Console.WriteLine("\nRemaining SortedList Elements:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}