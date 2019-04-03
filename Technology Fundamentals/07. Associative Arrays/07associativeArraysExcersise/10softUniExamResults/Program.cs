using System;
using System.Collections.Generic;
using System.Linq;

namespace _10softUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input  != "exam finished")
            {
                
                string[] inputLine = input.Split("-").ToArray();
                string name = inputLine[0];

                if (inputLine[1] == "banned")
                {
                    results.Remove(name);
                }
                else
                {
                    string technology = inputLine[1];
                    int points = int.Parse(inputLine[2]);
                    if (!results.ContainsKey(name))
                    {
                        results[name] = points;
                    }
                    else if(points > results[name])
                    {
                        results[name] = points;
                    }

                    if (!submissions.ContainsKey(technology))
                    {
                        submissions[technology] = 0;
                    }
                    submissions[technology]++;
                }
                input = Console.ReadLine();
                // Pesho - Java - 84
            }
            Console.WriteLine("Results:");
            foreach (var kvp in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
