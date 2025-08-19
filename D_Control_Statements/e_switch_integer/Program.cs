namespace e_switch_integer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your choice from 1 to 7 for weekday:");
        int wd = Convert.ToInt32(Console.ReadLine());
        switch (wd)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}