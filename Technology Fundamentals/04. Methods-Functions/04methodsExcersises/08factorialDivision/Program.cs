using System;

namespace _08factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double factorialA = FindFactorial(a);
            double factorialB = FindFactorial(b);
            double result = DivideTwoNumbers(factorialA, factorialB);
            Console.WriteLine($"{result:F2}");


        }

        static double FindFactorial(double n)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static double DivideTwoNumbers(double a, double b)
        {
            return a / b;
        }
    }
}
