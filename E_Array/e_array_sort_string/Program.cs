namespace e_array_sort_string;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Ram", "Sita", "Hari", "Gita", "Nita", "Mina", "Tina", "Zina" };
        int len = names.Length;

        Console.WriteLine("The number of array element is = " + len);
        Console.WriteLine("\nList of array elements befor sorting:");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Name {0} is = {1} ", i + 1, names[i]);
        }
        // Array.Sort(names); // sort in ascending order
        Array.Reverse(names); // sort in descending order
        Console.WriteLine("\nList of array elements after sorting:");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Name {0} is = {1} ", i + 1, names[i]);
        }
    }
}
