using System;
using System.Collections.Generic;
using System.Linq;

namespace _01train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxPersonsPerWagon = int.Parse(Console.ReadLine());
            int passengersToBoard = 0;


            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }

                if (input.ToLower().Contains("add"))
                {
                    wagons.Add(int.Parse(input.Substring(4)));
                }

                else
                {
                    passengersToBoard = int.Parse(input);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] < maxPersonsPerWagon)
                        {
                            if (wagons[i] + passengersToBoard <= maxPersonsPerWagon)
                            {
                                wagons.Insert(i, wagons[i] + passengersToBoard);
                                wagons.RemoveAt(i + 1);
                                passengersToBoard = 0;
                                break;
                            }
                        }
                    }
                }


            }


            Console.WriteLine(string.Join(' ', wagons));
        }

    }
}
