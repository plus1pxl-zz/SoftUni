using System;
using System.Collections.Generic;

namespace _05multiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int decimalReminder = 0;
            int currentMultiplication = 0;
            List<int> result = new List<int>();
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = bigNumber[i] - '0';
                currentMultiplication = currentDigit * number;
                currentMultiplication += decimalReminder;
                result.Add(currentMultiplication % 10);
                decimalReminder = currentMultiplication / 10;
            }
            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
