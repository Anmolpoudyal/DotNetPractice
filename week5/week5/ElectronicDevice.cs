using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    // Abstract class
    public abstract class ElectronicDevice
    {
        // Private fields
        private string brand;
        private double price;

        // Public properties (Encapsulation)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentException("Price cannot be negative");
            }
        }

        // Constructor to initialize brand and price
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method
        public abstract void ShowInfo();
    }
}
