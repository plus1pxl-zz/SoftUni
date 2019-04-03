using System;
using System.Collections.Generic;
using System.Linq;

namespace _04orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double[]>();
            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] inputLine = input.Split().ToArray();
                string name = inputLine[0];
                double price = double.Parse(inputLine[1]);
                double qty = double.Parse(inputLine[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new double[2]);
                }
                products[name][0] = price;
                products[name][1] += qty;

                input = Console.ReadLine();
            }
            foreach (var kvp in products)
            {
                double totalPrice = CalculateProductPrice(kvp.Value[0], kvp.Value[1]);
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }


        }

        private static double CalculateProductPrice(double price, double quantity)
        {
            double totalPrice = price * quantity;
            return totalPrice;
        }
    }
}
