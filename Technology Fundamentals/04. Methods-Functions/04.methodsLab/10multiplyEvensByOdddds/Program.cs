using System;

namespace _10multiplyEvensByOdddds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);
            int oddsXevens = GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdd);

            Console.WriteLine(oddsXevens);

        }

        static int GetSumOfEvenDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    result += digit;
                }
                number /= 10;
            }
            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    result += digit;
                }
                number /= 10;
            }
            return result;
        }

        static int GetMultipleOfEvenAndOdds(int sumOfEven, int sumOfOdd)
        {
            int result = sumOfEven * sumOfOdd;


            return result;
        }
    }
}
