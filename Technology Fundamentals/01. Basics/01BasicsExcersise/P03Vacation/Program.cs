using System;

namespace P03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            if (type == "Students")
            {
                if (dayOfTheWeek == "Friday") price = persons * 8.45;
                else if (dayOfTheWeek == "Saturday") price = persons * 9.80;
                else if (dayOfTheWeek == "Sunday") price = persons * 10.46;
                if (persons >= 30) price = price - (price * 0.15);
            }
            if (type == "Business")
            {
                if (persons >= 100) persons = persons - 10;
                if (dayOfTheWeek == "Friday") price = persons * 10.90;
                else if (dayOfTheWeek == "Saturday") price = persons * 15.60;
                else if (dayOfTheWeek == "Sunday") price = persons * 16;
                
            }
            if (type == "Regular")
            {
                if (dayOfTheWeek == "Friday") price = persons * 15;
                else if (dayOfTheWeek == "Saturday") price = persons * 20;
                else if (dayOfTheWeek == "Sunday") price = persons * 22.50;
                if (persons >= 10 && persons <= 20) price = price - (price * 0.05);
            }
            Console.WriteLine($"Total price: {price:F2}");


        }
    }
}
