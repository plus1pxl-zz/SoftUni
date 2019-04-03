using System;
using System.Collections.Generic;
using System.Linq;

namespace _08companyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();
            while (inputLine.ToLower() != "end")
            {
                string[] input = inputLine.Split(" -> ");
                string companyName = input[0];
                string employeeID = input[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    
                }
                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                inputLine = Console.ReadLine();
            }
            foreach (var kvp in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
