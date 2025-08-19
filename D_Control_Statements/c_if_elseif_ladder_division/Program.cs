namespace c_if_elseif_ladder_division;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks in Nepali:");
        int nepali = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Englidh:");
        int english = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Sciece:");
        int science = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Maths:");
        int maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Computer:");
        int computer = Convert.ToInt32(Console.ReadLine());

        if (nepali > 31 && english > 31 && science > 31 && maths > 31 && computer > 31)
        {
            int total = nepali + english + science + maths + computer;
            float percentage = (float)total / 5.0f;
            Console.WriteLine();
            Console.WriteLine("You've got " + percentage + "%");

            if (percentage > 79)
            {
                Console.WriteLine("Distinction");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("First");
            }
            else if (percentage > 45)
            {
                Console.WriteLine("Second");
            }
            else if (percentage > 32)
            {
                Console.WriteLine("Third");
            }
            else if (percentage < 32)
            {
                Console.WriteLine("Better luck next time");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}
