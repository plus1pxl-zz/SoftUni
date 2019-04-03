using System;

namespace _002left2Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string stringBeforeSpace = input.Substring(0, input.IndexOf(" "));
                string stringAfterSpace = input.Substring(input.IndexOf(" ") +1);
                long numLeft = long.Parse(stringBeforeSpace);
                long numRight = long.Parse(stringAfterSpace);

                if (numLeft >= numRight)
                {
                    numLeft = Math.Abs(numLeft);
                    long sumOfDigits = 0;
                    while (numLeft > 0)
                    {
                        sumOfDigits += numLeft % 10;
                        numLeft /= 10;
                    }
                    Console.WriteLine(sumOfDigits);
                }
                else if (numLeft < numRight)
                {
                    numRight = Math.Abs(numRight);
                    long sumOfDigits = 0;
                    while (numRight > 0)
                    {
                        sumOfDigits += numRight % 10;
                        numRight /= 10;
                    }
                    Console.WriteLine(sumOfDigits);
                }
                //Console.WriteLine(numLeft);
            }
        }
    }
}
