using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductShop
{
    public class StartUp_03
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> items = new SortedDictionary<string, Dictionary<string, double>>();

            string[] tokens = Console.ReadLine()
                .Split(", ")
                .ToArray();

            while (tokens[0]?.ToLower() != "revision")
            {
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!items.ContainsKey(shop))
                {
                    items[shop] = new Dictionary<string, double>();
                    items[shop].Add(product, price);
                }
                else
                {
                    items[shop].Add(product, price);
                }

                tokens = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
            }

            foreach (var kvp in items)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }

        }
    }
}
