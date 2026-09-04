// what is collection-initializer in Geneic Types. Write a program in c# with creating a SortedList of string keys and string values using collection-initializer syntax.
using System.Diagnostics;

namespace n_sorted_list_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        /* Creating a SortedList of string keys, string values using collection-initializer syntax */

        SortedList<string, string> cities = new SortedList<string, string>()
        {
            {"Nepal","Kathmandu"},
            {"India","New Delhi"},
            {"Japan","Tokyo"},
            {"Australia","Canberra"}
        };
        
        foreach (var item in cities)
        {
            Console.WriteLine("{0} is the capital city of {1}.", item.Value, item.Key);
        }
    }
}
