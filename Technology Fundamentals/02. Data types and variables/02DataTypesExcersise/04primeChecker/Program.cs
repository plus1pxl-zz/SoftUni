using System;

namespace _004primeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            for (int i = 2; i <= rangeEnd; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());

            }
        }
    }
}
