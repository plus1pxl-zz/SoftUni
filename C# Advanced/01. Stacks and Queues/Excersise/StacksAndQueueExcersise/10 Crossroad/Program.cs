using System;
using System.Collections;
using System.Collections.Generic;


namespace _10_Crossroad
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> queueOfCars = new Queue<string>();
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            bool isHitted = false;
            string currentCarName = string.Empty;
            char hittedSymbol = '\0';
            int passedCars = 0;

            while (input?.ToLower() !="end")
            {
                if (input?.ToLower() != "green")
                {
                    queueOfCars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }

                int currentGreenLightDuration = greenLightDuration;

                while (currentGreenLightDuration > 0 && queueOfCars.Count > 0)
                {
                    string carName = queueOfCars.Dequeue();
                    int carLength = carName.Length;

                    if (currentGreenLightDuration - carLength >= 0)
                    {
                        currentGreenLightDuration -= carLength;
                        passedCars++;
                    }
                    else
                    {
                        currentGreenLightDuration += freeWindowDuration;
                        if (currentGreenLightDuration - carLength >= 0)
                        {
                            passedCars++;
                            break;
                        }
                        else
                        {
                            isHitted = true;
                            currentCarName = carName;
                            hittedSymbol = carName[currentGreenLightDuration];
                            break;
                        }
                    }
                }
                if (isHitted)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{currentCarName} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
