namespace j_dictionary_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        // creatin a dictionary using collection-initializer syntax
        var subjects = new Dictionary<string, string>()
        {
            { "Education","nepali, maths, english, population"},
            { "Science","biology, chemistry, physics, maths"},
            { "Management","business, account, finance, economics"}
        };
        // Console.WriteLine(subjects["education"]);
        // Console.WriteLine(subjects["humanities"]);

        /* if(subjects.ContainsKey("Education")){
            Console.WriteLine(subjects["Education"]);
        }
        if(subjects.ContainsKey("Humanities")){
            Console.WriteLine(subjects["Humanities"]);
        } */

        /* foreach (var kvp in subjects)
        {
            Console.WriteLine("Key = {0} and value = {1}", kvp.Key, kvp.Value);
        } */

        /* for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine(
                "Key = {0} and value = {1}",
                subjects.ElementAt(i).Key,
                subjects.ElementAt(i).Value
            );
        } */

        //use TryGetValue() to get a value of unknown key
        
        string? result; // nullable string variable declaration

        if (subjects.TryGetValue("Education", out result))
        {
            Console.WriteLine(result);
        }

    }
}
