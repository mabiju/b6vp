namespace j_dictionary_tk_tv_string;

class Program
{
    static void Main(string[] args)
    {
        // creatin a dictionary using collection-initializer syntax
        var subjects = new Dictionary<string, string> ()
        {
            { "Education","nepali, maths, english, population"},
            { "Science","biology, chemistry, physics, maths"},
            { "Management","business, account, finance, economics"}
        };
        // Console.WriteLine(subjects["education"]);
        // Console.WriteLine(subjects["humanities"]);

        if(subjects.ContainsKey("Education")){
            Console.WriteLine(subjects["Education"]);
        }
        if(subjects.ContainsKey("Humanities")){
            Console.WriteLine(subjects["Humanities"]);
        }
        
    }
}



