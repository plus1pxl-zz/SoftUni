using System;
using System.Collections.Generic;
using System.Linq;

namespace _03cookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bestBatch = new List<int>();
            var bestBatchQuality = Int32.MinValue;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Bake It!")
                {
                    break;
                }

                var currentBatchQuality = 0;
                List<int> currentBatch = command.Split('#', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (var bread in currentBatch)
                {
                    currentBatchQuality += bread;
                }

                if (currentBatchQuality > bestBatchQuality)
                {
                    bestBatch = currentBatch;
                    bestBatchQuality = currentBatchQuality;
                }
                else if (currentBatchQuality == bestBatchQuality) //if current batch quality is the same as best batch quality
                {
                    var bestAverageQuality = bestBatchQuality / bestBatch.Count;
                    var currentAverageQualirty = currentBatchQuality / currentBatch.Count;

                    if (currentAverageQualirty > bestAverageQuality) 
                    {
                        bestBatch = currentBatch;
                        bestBatchQuality = currentBatchQuality;
                    }
                    else if (currentAverageQualirty == bestAverageQuality) //if current batch Average quality is the same as best batch Average quality
                    {
                        if (currentBatch.Count < bestBatch.Count)
                        {
                            bestBatch = currentBatch;
                            bestBatchQuality = currentBatchQuality;
                        }
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {bestBatchQuality}");
            Console.WriteLine(String.Join(' ', bestBatch));
        }
    }
}
