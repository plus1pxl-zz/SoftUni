using System;

namespace P10RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int trashedHeadsets = gamesLost / 2;
            int trashedMouses = gamesLost / 3;
            int trashedKeyboards = gamesLost / 6;
            int trashedDisplays = gamesLost / 12;

            double moneyNeeded = trashedHeadsets * priceHeadset + trashedMouses * priceMouse + trashedKeyboards * priceKeyboard + trashedDisplays * priceDisplay;

            Console.WriteLine($"Rage expenses: {moneyNeeded:F2} lv.");

        }
    }
}
