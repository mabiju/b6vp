namespace g_array_sort_c_style;

class Program
{
    static void Main(string[] args)
    {
        int[] apple = new int[] { 34, 56, 78, 90, 66, 77, 3, 5, 1, 89, 123, 44, 67, 13, 7 };
        int count = 0;
        for (int i = 0; i < apple.Length; i++)
        {
            if (apple[i] > 25)
            {
                count += 1;
            }
        }
        int[] orange = new int[count];
        int oi = 0;
        for (int i = 0; i < apple.Length; i++)
        {
            if (apple[i] > 25)
            {
                orange[oi] = apple[i];
                oi += 1;
            }
        }
        Array.Sort(orange);
        //Array.Reverse(orange);

        foreach (int item in orange)
        {
            Console.WriteLine(item + " ");
        }
    }
}
