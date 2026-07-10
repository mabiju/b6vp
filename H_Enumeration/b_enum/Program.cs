namespace b_enum;

class Program
{
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    static void Main(string[] args)
    {
        var today = Days.Sunday;
        if (today == Days.Friday || today == Days.Saturday)
        {
            Console.WriteLine("Hello friends, let have fun.");
        }
        else
        {
            Console.WriteLine("Hi all, we need to go for work.");
        }
    }
}
