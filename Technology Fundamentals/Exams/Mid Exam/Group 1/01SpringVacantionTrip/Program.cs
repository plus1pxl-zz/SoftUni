using System;

namespace _01SpringVacantionTrip
{
    class Program
    {
        static void Main(string[] args)
        {
             


            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int persons = int.Parse(Console.ReadLine());
            double fuelPricePerKm = double.Parse(Console.ReadLine());
            double foodExpensesPerDay = double.Parse(Console.ReadLine());
            double roomPricePerDay = double.Parse(Console.ReadLine());
            int kmTravelled = 0;
            double currentExpenses = 0;

            if (persons > 10)
            {
                roomPricePerDay *= 0.75;
            }

            currentExpenses = (foodExpensesPerDay + roomPricePerDay) * days * persons;

            for (int i = 1; i <= days; i++)
            {
                kmTravelled = int.Parse(Console.ReadLine());
                currentExpenses += kmTravelled * fuelPricePerKm;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses += currentExpenses * 0.4;
                }
                if (i % 7 == 0)
                {
                    currentExpenses -= currentExpenses / persons;
                }
                if (currentExpenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpenses - budget):F2}$ more.");
                    return;
                }
            }

            Console.WriteLine($"You have reached the destination. You have {(budget - currentExpenses):F2}$ budget left.");



        }
    }
}
