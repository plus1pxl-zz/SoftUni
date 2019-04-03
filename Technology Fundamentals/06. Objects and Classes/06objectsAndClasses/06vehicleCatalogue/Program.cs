using System;
using System.Collections.Generic;
using System.Linq;

namespace _06vehicleCatalogue
{
    public class Program
    {
        public static void Main()
        {
            var vehicles = new List<Vehicle>();

            while (true)
            {
                var input = Console.ReadLine()
                .Split(' ')
                .ToList();

                if (input[0] == "End")
                {
                    break;
                }
                var type = input[0];
                var model = input[1];
                var color = input[2];
                int horsepower = int.Parse(input[3]);

                vehicles.Add(new Vehicle() { Type = type, Model = model, Color = color, Horsepower = horsepower });
            }

            while (true)
            {
                var modelInput = Console.ReadLine();

                if (modelInput == "Close the Catalogue")
                {
                    break;
                }

                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].Model.Contains(modelInput))
                    {
                        Console.WriteLine($"Type: {UppercaseFirst(vehicles[i].Type)}");
                        Console.WriteLine($"Model: {vehicles[i].Model}");
                        Console.WriteLine($"Color: {vehicles[i].Color}");
                        Console.WriteLine($"Horsepower: {vehicles[i].Horsepower}");
                    }
                }
            }

            double carHorsepower = 0;
            double truckHorsepower = 0;
            int carCount = 0;
            int truckCount = 0;

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Type == "car")
                {
                    carHorsepower += vehicles[i].Horsepower;
                    carCount++;
                }
                else if (vehicles[i].Type == "truck")
                {
                    truckHorsepower += vehicles[i].Horsepower;
                    truckCount++;
                }
            }
            double carsAverageHP = 0;
            double trucksAverageHP = 0;
            if (carCount != 0)
            {
                carsAverageHP = carHorsepower / carCount;
            }
            if (truckCount != 0)
            {
                trucksAverageHP = truckHorsepower / truckCount;
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHP:f2}.");
        }

        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

    }
}
