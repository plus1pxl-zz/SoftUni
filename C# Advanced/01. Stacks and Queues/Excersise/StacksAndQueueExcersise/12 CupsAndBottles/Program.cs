using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12_CupsAndBottles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cups = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueCups = new Queue<int>(cups);
            Stack<int> stackBottles = new Stack<int>(bottles);
            int wastedLitersOfWater = 0;
            int remainingCupVolume = queueCups.Peek();
            while (queueCups.Count != 0 && stackBottles.Count !=0)
            {
                
                if (stackBottles.Peek() >= remainingCupVolume)
                {
                    wastedLitersOfWater += stackBottles.Pop() - remainingCupVolume;
                    queueCups.Dequeue();
                    if (queueCups.Count > 0)
                    {
                        remainingCupVolume = queueCups.Peek();
                    }
                }
                else
                {
                    remainingCupVolume -= stackBottles.Pop();

                }
            }

            if (queueCups.Count == 0)
            {
                Queue<int> remainingBottles = new Queue<int>(stackBottles.Reverse());
                Console.Write("Bottles:");
                while (remainingBottles.Count > 0)
                {
                    Console.Write(" " + remainingBottles.Dequeue());
                }
                Console.WriteLine(Environment.NewLine + $"Wasted litters of water: {wastedLitersOfWater}");
            }
            else if (stackBottles.Count == 0)
            {
                Stack<int> remainingCups = new Stack<int>(queueCups.Reverse());
                Console.Write("Cups:");
                while (remainingCups.Count > 0)
                {
                    Console.Write(" " + remainingCups.Pop());
                }
                Console.WriteLine(Environment.NewLine + $"Wasted litters of water: {wastedLitersOfWater}");
            }
        }
    }
}
