﻿// Lambda type : Statement Lambda
namespace e_lambda;

class Program
{
    static void Main(string[] args)
    {
        var calcSum = (int a, int b) =>
        {
            int sum = (a + b);
            return sum;
        };
        Console.WriteLine("The sum = " + calcSum(5, 3));
    }
}
