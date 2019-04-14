using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                string[] input = inputLine.Split("->").ToArray();
                string command = input[0];
                string store = input[1];
                if (command == "Add")
                {

                    if (input.Length > 2)
                    {
                        List<string> items = input[2].Split(",").ToList();
                        if (stores.ContainsKey(store))
                        {
                            foreach (var item in items)
                            {
                                stores[store].Add(item);
                            }
                        }
                        else
                        {
                            stores.Add(store, items);
                        }

                    }
                    else
                    {
                        stores[store].Add(input[2]);
                    }

                }

                else if (command == "Remove")
                {
                    stores.Remove(store);
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Stores list:");

            foreach (var kvp in stores.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
