using System;

namespace _11snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballValue = 0;
            int bestSnowballValue = 0;
            int bestsnowballSnow = 0;
            int bestsnowballTime = 0;
            int bestsnowballQuality = 0;

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = (int)Math.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestsnowballSnow = snowballSnow;
                    bestsnowballTime = snowballTime;
                    bestsnowballQuality = snowballQuality;

                }

            }
            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {bestSnowballValue} ({bestsnowballQuality})");
        }
    }
}
