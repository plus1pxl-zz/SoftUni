using System;
using System.Collections.Generic;
using System.Linq;

namespace _03houseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCOmmands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCOmmands; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                if (command[2] == "going!")
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else if (command[2] == "not")
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
           // Console.WriteLine(string.Join(' ', guests));
        }
    }
}
