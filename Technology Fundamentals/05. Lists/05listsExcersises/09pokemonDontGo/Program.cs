using System;
using System.Collections.Generic;
using System.Linq;

namespace _09pokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sumOfRemovedElements = 0;

            int indexToRemove = int.Parse(Console.ReadLine());
            while (true)
            {
                int indexValue = 0;
                if (indexToRemove < 0)
                {
                    indexValue = collection[0];
                    sumOfRemovedElements += indexValue;
                    collection.RemoveAt(0); // remove first element
                    collection.Insert(0, collection[collection.Count - 1]); // copy the last element to position 0
                }
                else if (indexToRemove > collection.Count - 1)
                {
                    indexValue = collection[collection.Count - 1];
                    sumOfRemovedElements += indexValue;
                    collection.RemoveAt(collection.Count - 1); // remove last element
                    collection.Add(collection[0]); // copy the first element to last position

                }
                else
                {
                    indexValue = collection[indexToRemove];
                    sumOfRemovedElements += indexValue;
                    collection.RemoveAt(indexToRemove);
                }

                for (int i = 0; i < collection.Count; i++)
                {
                    if (collection[i] <= indexValue)
                    {
                        int newValue = collection[i] + indexValue;
                        collection = ReplaceElementValue(collection, i, newValue);
                    }
                    else if (collection[i] > indexValue)
                    {
                        int newValue = collection[i] - indexValue;
                        collection = ReplaceElementValue(collection, i, newValue);
                    }
                }
                if (!collection.Any())
                {
                    break;
                }
                indexToRemove = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfRemovedElements);
        }

        private static List<int> ReplaceElementValue(List<int> collection, int i, int newValue)
        {
            collection.RemoveAt(i);
            collection.Insert(i, newValue);
            return collection;
        }
    }
}
