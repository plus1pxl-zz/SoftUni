using System;
using System.Text.RegularExpressions;

namespace _12softUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<qty>\d+)\|[^|$%.]*?(?<price>\d+.*\d*)\$";
            string input = "";
            double totalIncome = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex order = new Regex(pattern);

                if (order.IsMatch(input))
                {
                    string name = order.Match(input).Groups["name"].Value;
                    string product = order.Match(input).Groups["product"].Value;
                    int qty = int.Parse(order.Match(input).Groups["qty"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);

                    double totalPrice = price * qty;
                    totalIncome += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
