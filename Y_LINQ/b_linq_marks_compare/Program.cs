namespace b_linq_marks_compare;

class Program
{
    static void Main(string[] args)
    {
        int[] marks1 = new int[] { 23, 45, 67, 21, 32, 43, 7, 30, 96 };
        int[] marks2 = new int[] { 2, 56, 78, 91, 40, 21, 22, 65, 18 };
        var resultSet = from a in marks1 from b in marks2 where a < b select new { a, b };
        foreach (var item in resultSet)
        {
            Console.WriteLine("{0} is less than {1}", item.a, item.b);
        }

    }
}
