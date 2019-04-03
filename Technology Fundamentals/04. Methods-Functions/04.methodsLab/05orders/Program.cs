using System;

namespace _05orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            OrderTotal(product, qty);
        }

        static void OrderTotal(string product, int qty)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                        break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snack":
                    price = 2.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{qty * price:F2}");
        }
    }
}
