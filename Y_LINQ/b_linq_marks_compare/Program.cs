namespace b_linq_marks_compare;

class Program
{
    static void Main(string[] args)
    {
        int[] marks1 = new int[] { 34, 56, 78, 89, 43, 54, 67 };
        int[] marks2 = new int[] { 67, 90, 88, 44, 49, 99, 97 };
        var results = from a in marks1 from b in marks2 where a < b select new { a, b };
        foreach (var item in results)
        {
            Console.WriteLine("{0} is less than {1}", item.a, item.b);
        }
    }
}
