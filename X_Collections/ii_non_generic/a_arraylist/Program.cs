namespace a_arraylist;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList nameList = new ArrayList();
        nameList.Add("Ram");
        nameList.Add("Sita");
        nameList.Add("Hari");
        nameList.Add("Gita");

        /* foreach (var item in nameList)
        {
            Console.WriteLine(item);
        } */
        /* foreach (var item in nameList)
        {
            Console.WriteLine("Name is " + item);
        } */

        /* foreach (var item in nameList)
        {
            string arrayNames = string.Format($"Name is {item}");
            Console.WriteLine(arrayNames);
        } */
        Console.WriteLine("==========Original List===========");
        for (int i = 0; i < nameList.Count; i++)
        {
            Console.WriteLine(nameList[i]);
        }

        // adding a new item
        // nameList.Insert(1, "John");

        // Removing an item
        // nameList.Remove("Hari");

        // Removing an item based on its index
        nameList.RemoveAt(2);

        Console.WriteLine("==========Updated List===========");
        for (int i = 0; i < nameList.Count; i++)
        {
            Console.WriteLine($"Name is {nameList[i]}");
        }
    }
}
