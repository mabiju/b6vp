namespace e_linq_enum_marks;

class Program
{
    static void Main(string[] args)
    {
        int[] marks = { 34, 56, 78, 90, 98, 76, 54, 77, 81, 83, 43, 23 };
        // var marksQuery = from mark in marks where mark >= 80 select mark;
        IEnumerable<int> marksQuery = from mark in marks where mark >= 80 select mark;
        // foreach (var mark in marks)
        foreach (var mark in marksQuery)
        {
            Console.WriteLine(mark);
        }
    }
}
