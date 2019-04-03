using System;

namespace _04printTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTriangle(num);
        }

        static void PrintTriangle(int num)
        {
            for (int end = 1; end <= num; end++)
            {
                PrintLine(1, end);
            }
            for (int end = num - 1; end >= 0; end--)
            {
                PrintLine(1, end);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }
    }
}
