namespace a_arraylist;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList namelist = new ArrayList();
        namelist.Add("Ram");
        namelist.Add("Sita");
        namelist.Add("Hari");
        namelist.Add("Gita");
        namelist.Add(10);
        namelist.Add("Laxman");
        namelist.Add(34.56);
        /* foreach (var item in namelist)
        {
            Console.WriteLine(item);
        } */

        /* foreach (var item in namelist)
        {
            Console.WriteLine("Name is " + item);
        } */

        /* foreach (var item in namelist)
        {
            string arrayNames = string.Format($"Name is {item}");
            Console.WriteLine(arrayNames);
        } */

        Console.WriteLine("===============Original List=================");
        for (int i = 0; i < namelist.Count; i++)
        {
            Console.WriteLine(namelist[i]);
        }
        namelist.Insert(1,"John");
        namelist.Remove(10);

        Console.WriteLine("===============Updated List=================");
        for (int i = 0; i < namelist.Count; i++)
        {
            Console.WriteLine(namelist[i]);
        }
    }
}
