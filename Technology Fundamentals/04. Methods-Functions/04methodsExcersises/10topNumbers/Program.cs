using System;
using System.Linq;

namespace _10topNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                int[] nArray = i.ToString().Select(o => Convert.ToInt32(o)).ToArray();
                if (CheckIfSumIsDivisibleBy8(nArray) == true
                    && CheckIfItContainsOddDigit(nArray))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool CheckIfItContainsOddDigit(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        private static double SumAllDigits(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }
        private static bool CheckIfSumIsDivisibleBy8(int[] n)
        {
            double sum = SumAllDigits(n);

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
