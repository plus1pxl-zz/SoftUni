using System;

namespace _01cookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pricePerFlourPackage = double.Parse(Console.ReadLine());
            double pricePerEgg = double.Parse(Console.ReadLine());
            double pricePerApron = double.Parse(Console.ReadLine());
            
            double MoneyNeededForFlour = (students - (students / 5)) * pricePerFlourPackage;
            double MoneyNeededForEggs = students * 10 * pricePerEgg;
            double MoneyNeededForAprons = (students + Math.Ceiling(students * 0.2)) * pricePerApron;

            double totalMoneyNeeded = MoneyNeededForFlour + MoneyNeededForEggs + MoneyNeededForAprons;

            if (budget >= totalMoneyNeeded)
            {
                Console.WriteLine($"Items purchased for {totalMoneyNeeded:F2}$.");
            }
            else
            {
                double moneyShort = totalMoneyNeeded - budget;
                Console.WriteLine($"{moneyShort:F2}$ more needed.");
            }


        }
    }
}
