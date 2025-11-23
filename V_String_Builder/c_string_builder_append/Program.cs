namespace c_string_builder_append;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        const int MaxSize = 50;
        StringBuilder sb = new StringBuilder();
        void AppendWithLimit(string text)
        {
            if (sb.Length + text.Length > MaxSize)
            {
                Console.WriteLine("Cannot append: size limit reached.");
                return;
            }
            sb.Append(text);
        }
        AppendWithLimit("Hello ");
        AppendWithLimit("Sanothimi!");
        AppendWithLimit(new string('x', 10)); // will print
        AppendWithLimit(new string('x', 40)); // Too big, will be blocked
        Console.WriteLine(sb.ToString());
    }
}



