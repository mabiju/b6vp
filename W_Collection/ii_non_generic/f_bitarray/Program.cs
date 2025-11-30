namespace f_bitarray;

using System.Collections;
class Program
{
    static void Main()
    {
        // Create a BitArray with an initial size of 5 (all bits set to false by default)
        BitArray bitArray = new BitArray(5);

        // Set values for specific bits
        bitArray[0] = true;  // Set the first bit to true
        bitArray[1] = false; // Set the second bit to false
        bitArray[2] = true;  // Set the third bit to true
        bitArray[3] = true;  // Set the fourth bit to true
        bitArray[4] = false; // Set the fifth bit to false

        // Display the BitArray elements
        Console.WriteLine("BitArray Elements:");
        for (int i = 0; i < bitArray.Count; i++)
        {
            Console.WriteLine($"Bit {i}: {bitArray[i]}");
        }

        // Perform a NOT operation on the BitArray
        Console.WriteLine("\nPerforming NOT operation...");
        bitArray.Not();

        // Display the updated BitArray elements
        Console.WriteLine("Updated BitArray Elements:");
        for (int i = 0; i < bitArray.Count; i++)
        {
            Console.WriteLine($"Bit {i}: {bitArray[i]}");
        }
    }
}
