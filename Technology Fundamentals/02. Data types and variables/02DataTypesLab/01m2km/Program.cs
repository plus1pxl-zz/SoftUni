using System;

namespace _01m2km
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int currentNum = 0;
            bool isSpecialNum = false;
            for (int ch = 1; ch <= num; ch++)
            {
                currentNum = ch;
                while (ch > 0)
                {
                    sumOfDigits += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", currentNum, isSpecialNum);
                sumOfDigits = 0;
                ch = currentNum;
            }



        }
    }
}
