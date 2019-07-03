using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06_ParkingLot
{
    public class StartUp_06
    {
        static void Main(string[] args)
        {
            HashSet<string> numberPlates = new HashSet<string>();
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            while (input[0]?.ToLower() != "end")
            {
                if (input[0]?.ToLower() == "in")
                {
                    numberPlates.Add(input[1]);
                }
                else if (input[0]?.ToLower() == "out")
                {
                    numberPlates.Remove(input[1]);
                }

                input = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
            }
            if (numberPlates.Count > 0)
            {
                foreach (var numberPlate in numberPlates)
                {
                    Console.WriteLine(numberPlate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
