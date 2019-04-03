using System;

namespace _10pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;
            int pokePowerInitial = pokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;
                if (pokePower == pokePowerInitial / 2)
                {
                    if (exhaustionFactor > 0)
                    {

                        pokePower = pokePower / exhaustionFactor;
                    }

                }


            }
            Console.WriteLine(pokePower);
            Console.WriteLine(counter);


        }
    }
}
