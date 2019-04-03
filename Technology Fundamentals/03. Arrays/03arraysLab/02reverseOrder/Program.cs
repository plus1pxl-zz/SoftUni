using System;

namespace _02reverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] num = new int[count];

            for (int i = 0; i < count; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(num);

            foreach (int number in num)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
