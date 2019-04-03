using System;
using System.Linq;

namespace _00Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr =
                {
                    {"Sofia", "Plovdiv" }, // 0
                    {"Varna", "Bourgas" }, // 1
                    {"Veliko Tarnovo", "Yambol" }, // 2

                };
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
