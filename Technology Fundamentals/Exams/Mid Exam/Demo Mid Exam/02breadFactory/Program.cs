using System;
using System.Linq;

namespace _02breadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;

            int currentEnergy = energy;
            int currentCoins = coins;
            var events = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < events.Count; i++)
            {
                var eventParts = events[i].Split('-');
                if (eventParts[0].ToLower() == "rest")
                {
                    var energyGained = int.Parse(eventParts[1]);

                    if (currentEnergy + energyGained >= energy)
                    {
                        Console.WriteLine($"You gained {energy - currentEnergy} energy.");
                        currentEnergy = energy;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {energyGained} energy.");
                        currentEnergy += energyGained;   
                    }

                    Console.WriteLine($"Current energy: {currentEnergy}.");
                }
                else if (eventParts[0].ToLower() == "order")
                {

                    if (currentEnergy - 30 < 0)
                    {
                        currentEnergy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                    else
                    {
                        currentEnergy -= 30;
                        var coinsGained = int.Parse(eventParts[1]);
                        Console.WriteLine($"You earned {coinsGained} coins.");
                        currentCoins += coinsGained;
                    }
                }
                else
                {
                    var ingradientName = eventParts[0];
                    var ingradientPrice = int.Parse(eventParts[1]);
                    currentCoins -= ingradientPrice;

                    if (currentCoins > 0)
                    {
                        Console.WriteLine($"You bought {ingradientName}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {ingradientName}.");
                        break;
                    }
                }
            }

            if (currentCoins > 0)
            {
                Console.WriteLine($"Day completed!");
                Console.WriteLine($"Coins: {currentCoins}");
                Console.WriteLine($"Energy: {currentEnergy}");
            }
        }
    }
}
