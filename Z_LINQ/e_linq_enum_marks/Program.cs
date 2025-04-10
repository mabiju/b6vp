namespace e_linq_enum_marks;

class Program
{
    static void Main(string[] args)
    {
        int[] marks = new int[] { 45, 67, 89, 90, 99, 82 };
        IEnumerable<int> marksQuery = from mark in marks where mark >= 80 select mark;

        //foreach (int mark in marks)
        foreach (int mark in marksQuery)
        {
            Console.WriteLine(mark);
        }
    }
}
