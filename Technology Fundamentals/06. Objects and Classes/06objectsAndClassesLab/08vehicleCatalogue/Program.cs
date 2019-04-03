using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08vehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogVehicle collection = new CatalogVehicle();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                
                string[] inputParts = input.Split('/');
                if (inputParts[0].ToLower() == "car")
                {
                    Car newCar = new Car
                    {
                        Brand = inputParts[1],
                        Model = inputParts[2],
                        Power = int.Parse(inputParts[3])
                    };
                    collection.CarsCatalog.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck
                    {
                        Brand = inputParts[1],
                        Model = inputParts[2],
                        Weight = int.Parse(inputParts[3])
                    };
                    collection.TrucksCatalog.Add(newTruck);
                }

            }
            Console.Write(collection.ToString());

        }
    }
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Power { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {Power}hp";
        }
    }
    class CatalogVehicle
    {
        public List<Car> CarsCatalog { get; set; }
        public List<Truck> TrucksCatalog { get; set; }
        public CatalogVehicle()
        {
            TrucksCatalog = new List<Truck>();
            CarsCatalog = new List<Car>();
        }
        public override string ToString()
        {
            List<Car> orderedCars = CarsCatalog.OrderBy(c => c.Brand).ToList();
            List<Truck> orderedTrucks = TrucksCatalog.OrderBy(t => t.Brand).ToList();
            StringBuilder sb = new StringBuilder();
            if (orderedCars.Count > 0)
            {
                sb.AppendLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    sb.AppendLine(car.ToString());
                }
            }
            if (orderedTrucks.Count > 0)
            {
                sb.AppendLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    sb.AppendLine(truck.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
