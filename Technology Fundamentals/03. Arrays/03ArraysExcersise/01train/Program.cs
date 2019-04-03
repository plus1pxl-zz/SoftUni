using System;

namespace _01train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                sum += passangers[i];
            }
            foreach (var item in passangers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n"+ sum);
        }
    }
}
