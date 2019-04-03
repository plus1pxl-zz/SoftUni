using System;

namespace _01sortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(num);

            Array.Reverse(num);

            foreach (int value in num)
            {
                Console.WriteLine(value);
            }


        }
    }
}
