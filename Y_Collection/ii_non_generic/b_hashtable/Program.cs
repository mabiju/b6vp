namespace b_hashtable;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Hashtable userhash = new Hashtable();
        // HashList userhash = new HashList();
        for (int i = 0; i < 10; i++)
        {
            userhash.Add(i, " user " + i);
        }
        if (userhash.ContainsKey(0))
        {
            userhash.Remove(0);
        }
        if (userhash.ContainsKey(1))
        {
            userhash[1] = "Ram";
        }
        foreach (DictionaryEntry item in userhash)
        {
            Console.WriteLine("Roll is {0} and name is {1}", item.Key, item.Value);
        }
    }
}
