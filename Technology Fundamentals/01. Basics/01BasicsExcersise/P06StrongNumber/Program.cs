using System;

namespace P06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = input;
            int lastNum = 0;
            int sum = 0;
            int factorial = 1;
            int length = num.ToString().Length;


            for (int i = 0; i < length; i++)
            {
                lastNum = num % 10;
                for (int j = lastNum; j > 0; j--)
                {
                    factorial *= j;
                }
                sum += factorial;
                factorial = 1;
                num = num/10;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
