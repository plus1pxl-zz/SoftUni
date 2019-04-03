using System;
using System.Collections.Generic;
using System.Linq;

namespace _04listOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> collection = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();


            while (true)
            {
                string input = Console.ReadLine();
                List<string> command = input.Split().ToList();
                if (command[0].ToLower() == "end")
                {
                    break;
                }
                else if (command[0].ToLower() == "add")
                {
                    int valueToAdd = int.Parse(command[1]);
                    collection.Add(valueToAdd);
                }
                else if (command[0].ToLower() == "insert")
                {
                    int valueToInsert = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index >= collection.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        collection.Insert(index, valueToInsert);
                    }

                }
                else if (command[0].ToLower() == "remove")
                {
                    int index = index = int.Parse(command[1]);
                    if (index >= collection.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        collection.RemoveAt(index);
                    }

                }
                else if (command[0].ToLower() == "shift")
                {
                    int timesToShift = int.Parse(command[2]);
                    if (command[1].ToLower() == "left")
                    {
                        for (int i = 0; i < timesToShift; i++)
                        {
                            collection.Add(collection[0]);
                            collection.RemoveAt(0);
                        }
                    }
                    else if (command[1].ToLower() == "right")
                    {
                        for (int i = 0; i < timesToShift; i++)
                        {
                            collection.Insert(0, collection[collection.Count - 1]);
                            collection.RemoveAt(collection.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', collection));
        }
    }
}
