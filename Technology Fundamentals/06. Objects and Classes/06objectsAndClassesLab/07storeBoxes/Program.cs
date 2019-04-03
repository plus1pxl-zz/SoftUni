using System;
using System.Collections.Generic;
using System.Linq;

namespace _07storeBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] inputParts = input.Split();
                string serialNumber = inputParts[0];
                string itemName = inputParts[1];
                int itemQuantity = int.Parse(inputParts[2]);
                decimal priceItem = decimal.Parse(inputParts[3]);
                decimal priceBox = itemQuantity * priceItem;

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Quantity = itemQuantity,
                    PriceBox = priceBox
                };
                box.Item = new Item()
                {
                    Name = itemName,
                    Price = priceItem
                };
                boxes.Add(box);
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(o => o.PriceBox).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }

    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
    }
}
