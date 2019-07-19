using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CarConstructors
{
    /// <summary>
    /// This Class represents a car.
    /// </summary>
    public class Car
    {
        private string make;
        private string model;
        private int year;

        /// <summary>
        /// Creates a car with default values - "VW" make, "Gold" model, 2025 year;
        /// </summary>
        public Car()
            : this("VW", "Golf", 2025)
        {
            
        }
        public Car(
            string make,
            string model,
            int year)
        {
            this.Make = make;
            this.Model =model;
            this.Year = year;
        }
        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }


        public void Drive(double distance)
        {
            var canContinue = this.FuelQuantity - this.FuelConsumption * distance >= 0;
            if (canContinue)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
            }
            else
            {
                throw new CarCannotContinueException("Not enouh fuel!");
            }
        }

        public string GetInformation()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.Append($"Fuel: {this.FuelQuantity:F2}L");
            return result.ToString();

        }
    }
}
