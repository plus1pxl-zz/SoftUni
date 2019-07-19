using System;
using System.Collections.Generic;
using System.Text;

namespace _04_CarEngineAndTires
{
    class Engine
    {
        private int power;
        private double capacity;

        public Engine(int power, double capacity)
        {
            this.Power = power;
            this.Capacity = capacity;
        }

        public int Power
        {
            get
            {
                return this.power;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Power must be a positive number.");
                }

                this.power = value;
            }
        }
        public double Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity must be a positive number.");
                }
                this.capacity = value;
            }
        }

    }
}
