using System.Diagnostics;

namespace j_dictionary_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        var subjects = new Dictionary<string, string>()
        {
            {"education","Nepali,Maths,English,Population,ICT"},
            {"science","Biology,Chemistry,Physics,Maths"},
            {"humanities","Sociology,Social Work,Journalism"},
            {"management","Finance,Business,Economics"},
        };
        // Console.WriteLine(subjects["education"]);
        // Console.WriteLine(subjects["humanities"]);

        /* if (subjects.ContainsKey("education"))
        {
            Console.WriteLine(subjects["education"]);
        }
        if (subjects.ContainsKey("management"))
        {
            Console.WriteLine(subjects["management"]);
        } */

        /* foreach (var kvp in subjects)
        {
            // Console.WriteLine("Key is = {0} and values are {1}", kvp.Key, kvp.Value);
            Console.WriteLine("{0} subjects are taught in {1} faculty.", kvp.Value, kvp.Key);
        } */

        /* for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine(
                "Key = {0} and value = {1}",
                subjects.ElementAt(i).Key,
                subjects.ElementAt(i).Value
            );
        } */

        // use TryGetValue() to get a value from unknown key
        string? result; // nullable string variable declaration

        if(subjects.TryGetValue("education", out result))
        {
            Console.WriteLine(result);
        }
    }
}
