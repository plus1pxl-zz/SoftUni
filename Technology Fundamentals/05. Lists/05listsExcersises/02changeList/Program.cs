using System;
using System.Collections.Generic;
using System.Linq;

namespace _02changeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                
                string input = Console.ReadLine();
                List<string> command = input.Split().ToList();
                if (command[0].ToLower() == "end")
                {
                    break;
                }
                else if (command[0].ToLower() == "delete")
                {
                    int valueToRemove = int.Parse(command[1]);
                    for (int i = 0; i < collection.Count; i++)
                    {
                        if (collection[i] == valueToRemove)
                        {
                            collection.Remove(valueToRemove);
                            i--;
                        }
                    }
                }

                else if (command[0].ToLower() == "insert")
                {
                    int valueToInsert = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    collection.Insert(index, valueToInsert);
                }
            }
            Console.WriteLine(string.Join((char)32, collection));
        }
    }
}
