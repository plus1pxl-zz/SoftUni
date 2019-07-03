using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04_CitiesByCAC
{
    public class StartUp_04
    {
        static void Main(string[] args)
        {
            int citiesN = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < citiesN; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!cities.ContainsKey(continent))
                {
                    cities[continent] = new Dictionary<string, List<string>>();
                }
                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent][country] = new List<string>();
                }
                cities[continent][country].Add(city);

            }
            foreach (var kvp in cities)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var city in kvp.Value)
                {
                    Console.WriteLine($"{city.Key} -> {String.Join(", ", city.Value)}");
                }
            }
        }
    }
}
