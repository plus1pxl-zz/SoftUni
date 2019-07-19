using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Car
{
    public class Car
    {

        private int year;
        private string model;
        public string Make { get; set; }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }
    }
}
