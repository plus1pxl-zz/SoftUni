using System;

namespace _08beerCegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currentVolume = 0;
            double maxVolume = 0;
            string largestKeg = "";

            for (int i = 0; i < n; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                currentVolume = Math.PI * radius * radius * height;

                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;
                    largestKeg = kegName;
                }

            }
            Console.WriteLine($"{largestKeg}");

        }
    }
}
