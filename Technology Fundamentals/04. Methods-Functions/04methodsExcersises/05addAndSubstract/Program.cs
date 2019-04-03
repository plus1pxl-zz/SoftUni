using System;

namespace _05addAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = SumTwoNumbers(a, b);
            int result = SubstractTwoNumbers(sum, c);
            Console.WriteLine(result);
        }


        static int SumTwoNumbers(int a, int b)
        {
            return a + b;
        }

        static int SubstractTwoNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
